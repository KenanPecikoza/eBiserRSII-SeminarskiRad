using AutoMapper;
using eBiser.Data.Requests;
using eBiser.Database;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static eBiser.Data.Requests.KorisniciInserttRequest;
using static eBiser.Data.Requests.KorisniciSearchRequest;
using static eBiser.Data.Requests.KorisniciUpdateRequest;

namespace eBiser.Services
{
    public class KorisniciService : IKorisniciService
    {

        private readonly eBiserContext _db;
        private readonly IMapper _mapper;
        public KorisniciService(eBiserContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }
        public static string GenerateSalt()
        {
            var buf = new byte[16];
            (new RNGCryptoServiceProvider()).GetBytes(buf);
            return Convert.ToBase64String(buf);
        }

        public static string GenerateHash(string salt, string password)
        {
            byte[] src = Convert.FromBase64String(salt);
            byte[] bytes = Encoding.Unicode.GetBytes(password);
            byte[] dst = new byte[src.Length + bytes.Length];

            System.Buffer.BlockCopy(src, 0, dst, 0, src.Length);
            System.Buffer.BlockCopy(bytes, 0, dst, src.Length, bytes.Length);

            HashAlgorithm algorithm = HashAlgorithm.Create("SHA1");
            byte[] inArray = algorithm.ComputeHash(dst);
            return Convert.ToBase64String(inArray);
        }
        private Data.KorisniciSistema DodaniKorisnik(int id)
        {
            var entity = _db.KorisniciSistemas.Include(x => x.KorisnikSistemaTip).FirstOrDefault(x=> x.KorisnikId==id);
            
            var returns = _mapper.Map<Data.KorisniciSistema>(entity);
            string TipKorisnika = _db.KorisnikSistemaTips.Where(x => x.Id == entity.KorisnikSistemaTipId).Select(x => x.Naziv).FirstOrDefault();
            
            if (TipKorisnika == "Clan")
            {
                var clan = _db.Clanovis.FirstOrDefault(x => x.KorisnikId == returns.KorisnikId);
                returns.Id = clan.Id;
            }
            else if (TipKorisnika == "Osoblje")
            {
                var osoblje = _db.Osobljes.FirstOrDefault(x => x.KorisnikId == returns.KorisnikId);
                returns.Id = osoblje.Id;
            }
            else if (TipKorisnika == "Donator")
            {
                var donator = _db.Donatoris.FirstOrDefault(x => x.KorisnikId == returns.KorisnikId);
                returns.Id = donator.Id;
            }
            return returns;
        }

        public  List<Data.KorisniciSistema> Get(KorisniciSearchRequest search)
        {
            var query = _db.KorisniciSistemas.Include(x=> x.KorisnikSistemaTip).AsQueryable();
            if (!string.IsNullOrWhiteSpace(search?.Ime))
            {
                query =query.Where(x => x.Ime.ToLower().StartsWith(search.Ime.ToLower()));
            }
            if (!string.IsNullOrWhiteSpace(search?.Prezime))
            {
                query = query.Where(x => x.Prezime.ToLower().StartsWith(search.Prezime.ToLower()));
            }
            if (!string.IsNullOrWhiteSpace(search?.Email))
            {
                query = query.Where(x => x.Email.ToLower().StartsWith(search.Email.ToLower()));
            }
            if (search.Aktivan!=null)
            {
                query = query.Where(x => x.Aktivan==search.Aktivan);
            }
            var list = query.ToList();
            var result = _mapper.Map<List<Data.KorisniciSistema>>(list);
            foreach (var i in result)
            {
                if (i.KorisnikSistemaTipId == _db.KorisnikSistemaTips.FirstOrDefault(x=> x.Naziv=="Donator").Id)
                {
                    var donator = _db.Donatoris.FirstOrDefault(x => x.KorisnikId == i.KorisnikId);                
                    i.Id = donator.Id;
                }
                if (i.KorisnikSistemaTipId == _db.KorisnikSistemaTips.FirstOrDefault(x => x.Naziv == "Osoblje").Id)
                {
                    var osoblje = _db.Osobljes.FirstOrDefault(x => x.KorisnikId == i.KorisnikId);
                    i.Id = osoblje.Id;
                }
                if (i.KorisnikSistemaTipId == _db.KorisnikSistemaTips.FirstOrDefault(x => x.Naziv == "Clan").Id)
                {
                    var Clan = _db.Clanovis.FirstOrDefault(x => x.KorisnikId == i.KorisnikId);
                    i.Id = Clan.Id;
                    
                }
            }

            return result;
        }
        public Data.KorisniciSistema GetById(int id)
        {
            var entity = _db.KorisniciSistemas.Where(x=> x.KorisnikId==id).Include(x => x.KorisnikSistemaTip).FirstOrDefault();
            var clanDB = _db.Clanovis.Where(x => x.KorisnikId == id).FirstOrDefault();
            if (clanDB != null)
            {
                //var entity2 = _db.Clanovi.Where(x => x.KorisnikId == id).FirstOrDefault();
                Data.ClanDTO clan = _mapper.Map<Data.ClanDTO>(clanDB);
                int brojClanarina = _db.Clanarinas.Where(x => x.ClanId == clanDB.Id).Count();
                clan.Clanarine =  brojClanarina.ToString()+"/12" ;
                return clan;
            }
            var osobljeDB = _db.Osobljes.Include(x=> x.Djelatnost).Where(x => x.KorisnikId == id).FirstOrDefault();
            if (osobljeDB!=null)
            {
                Data.OsobljeDTO osoblje = _mapper.Map<Data.OsobljeDTO>(osobljeDB);
                return osoblje;
            }
            var donatorDB = _db.Donatoris.Where(x => x.KorisnikId == id).FirstOrDefault();
            if (donatorDB != null)
            {
                Data.DonatorDTO donator = _mapper.Map<Data.DonatorDTO>(donatorDB);
                return donator;
            }
            return _mapper.Map<Data.KorisniciSistema>(entity);
        }

        public  Data.KorisniciSistema Insert(KorisniciInserttRequest request)
        {
            var entity = _mapper.Map<KorisniciSistema>(request);
            if (request.Password != request.PasswordPotvrda)
            {
                throw new Exception("Passwordi se ne slažu");
            }
            var email=  _db.KorisniciSistemas.Where(x => x.Email == request.Email).FirstOrDefault();
            if (email!=null)
            {
                throw new Exception("Email adresa se već koristi");
            }
            var korinsckoIme=  _db.KorisniciSistemas.Where(x => x.KorisnickoIme == request.KorisnickoIme).FirstOrDefault();
            if (korinsckoIme!=null)
            {
                throw new Exception("Korisničko ime se već koristi");
            }
            entity.PasswordSalt = GenerateSalt();
            entity.PasswordHash = GenerateHash(entity.PasswordSalt, request.Password);
            string TipKorisnika = _db.KorisnikSistemaTips.Where(x => x.Id == entity.KorisnikSistemaTipId).Select(x=> x.Naziv).FirstOrDefault();
            entity.DatumRegistracije = DateTime.Now;
            entity.DatumIzmjene = DateTime.Now;
            _db.Add(entity);
            if (request is ClanUpsertRequest)
            {
                var req = _mapper.Map<Clanovi>(request);
                entity.KorisnikSistemaTip = _db.KorisnikSistemaTips.FirstOrDefault(x => x.Naziv == "Clan");
                req.Korisnik = entity;
                _db.Add(req);
            }
            if (request is DonatorUpsertRequest)
            {
                var req = _mapper.Map<Donatori>(request);
                entity.KorisnikSistemaTip = _db.KorisnikSistemaTips.FirstOrDefault(x => x.Naziv == "Donator");
                req.Korisnik = entity;
                _db.Add(req);
            }
            if (request is OsobljeUpsertRequest)
            {
                var req = _mapper.Map<Osoblje>(request);
                entity.KorisnikSistemaTip = _db.KorisnikSistemaTips.FirstOrDefault(x => x.Naziv == "Osoblje");
                req.Korisnik = entity;
                _db.Add(req);
            }
            _db.SaveChanges();
            return DodaniKorisnik(entity.KorisnikId) ;    
        }

        public Data.KorisniciSistema Update(int id, KorisniciUpdateRequest request)
        {
            var entity = _db.KorisniciSistemas.Find(id);
            _mapper.Map(request, entity);

            if (request is OsobljeUpdateRequest OUSR)
            {
                var osoblje = _db.Osobljes.FirstOrDefault(x => x.KorisnikId == id);
                _mapper.Map(OUSR, osoblje);
                _db.Update(osoblje);
            }
            else if (request is DonatorUpdateRequest DUSR)
            {
                var donator = _db.Donatoris.FirstOrDefault(x => x.KorisnikId == id);
                _mapper.Map( DUSR, donator);
                _db.Update(donator);
            }
            else if (request is ClanUpdateRequest CUSR)
            {
                var clan = _db.Clanovis.FirstOrDefault(x => x.KorisnikId == id);
                _mapper.Map(CUSR, clan);
                _db.Update(clan);
            }
            _db.SaveChanges();
            return DodaniKorisnik(id);
        }
        public Data.DonatorDTO GetDonator(int id)
        {
            var entity = _db.Donatoris.Include(x => x.Korisnik).FirstOrDefault(x => x.Id == id);
            var returns = _mapper.Map<Data.DonatorDTO>(entity);
            return returns;
        }
        public List<Data.DonatorDTO> GetDonatori(KorisniciSearchRequest search)
        {
            var query = _db.Donatoris.Include(x => x.Korisnik).AsQueryable();
            if (!string.IsNullOrWhiteSpace(search?.Ime))
            {
                query = query.Where(x => x.Korisnik.Ime.ToLower().StartsWith(search.Ime.ToLower()));
            }
            if (!string.IsNullOrWhiteSpace(search?.Prezime))
            {
                query = query.Where(x => x.Korisnik.Prezime.ToLower().StartsWith(search.Prezime.ToLower()));
            }
            if (!string.IsNullOrWhiteSpace(search?.Email))
            {
                query = query.Where(x => x.Korisnik.Email == search.Email);
            }
            if (!string.IsNullOrWhiteSpace(search?.KorisnickoIme))
            {
                query = query.Where(x => x.Korisnik.KorisnickoIme == search.KorisnickoIme);
            }
            if (search.Aktivan != null)
            {
                query = query.Where(x => x.Korisnik.Aktivan == search.Aktivan);
            }
            var list = query.ToList();
            var returns = _mapper.Map<List<Data.DonatorDTO>>(list);
            return returns;
        }
        public Data.ClanDTO GetClan(int id)
        {

            var entity = _db.Clanovis.Include(x => x.Korisnik).FirstOrDefault(x => x.Id == id);
            int brojClanarina=0;
            var returns = _mapper.Map<Data.ClanDTO>(entity);
            try
            {
                brojClanarina = _db.Clanarinas.Where(x => x.ClanId == entity.Id).Count();
                returns.Clanarine = "12/" + brojClanarina.ToString();
            }
            catch (Exception)
            {
            }
            return returns;
        }
        public List<Data.ClanDTO> GetCLanovi(KorisniciSearchRequest search)
        {
            var query = _db.Clanovis.Include(x => x.Korisnik).AsQueryable();
            if (!string.IsNullOrWhiteSpace(search?.Ime))
            {
                query = query.Where(x => x.Korisnik.Ime.ToLower().StartsWith(search.Ime.ToLower()));
            }
            if (!string.IsNullOrWhiteSpace(search?.Prezime))
            {
                query = query.Where(x => x.Korisnik.Prezime.ToLower().StartsWith(search.Prezime.ToLower()));
            }
            if (!string.IsNullOrWhiteSpace(search?.Email))
            {
                query = query.Where(x => x.Korisnik.Email == search.Email);
            }
            if (!string.IsNullOrWhiteSpace(search?.KorisnickoIme))
            {
                query = query.Where(x => x.Korisnik.KorisnickoIme == search.KorisnickoIme);
            }
            if (search.Aktivan != null)
            {
                query = query.Where(x => x.Korisnik.Aktivan == search.Aktivan);
            }
            var list = query.ToList();
            var returns = _mapper.Map<List<Data.ClanDTO>>(list);
            int brojClanarina = 0;
            foreach (var i in returns)
            {
                brojClanarina = 0;
                try
                {
                    brojClanarina = _db.Clanarinas.Where(x => x.ClanId == i.Id).Count();
                    i.Clanarine = "12/" + brojClanarina.ToString();
                }
                catch (Exception)
                {
                }
            }
            return returns;
        }
        public Data.OsobljeDTO GetOsoblje(int id)
        {
            var entity = _db.Osobljes.Include(x => x.Korisnik).Include(x=> x.Djelatnost).FirstOrDefault(x => x.Id == id);
            var returns = _mapper.Map<Data.OsobljeDTO>(entity);
            return returns;
        }
        public List<Data.OsobljeDTO> GetOsoblje(OsobljeSearchRequest search)
        {
            var query = _db.Osobljes.Include(x => x.Korisnik).Include(x => x.Djelatnost).AsQueryable();
            if (!string.IsNullOrWhiteSpace(search?.Ime))
            {
                query =query.Include(x => x.Djelatnost).Where(x => x.Korisnik.Ime.ToLower().StartsWith(search.Ime.ToLower()));
            }
            if (!string.IsNullOrWhiteSpace(search?.Prezime))
            {
                query =query.Include(x => x.Djelatnost).Where(x => x.Korisnik.Prezime.ToLower().StartsWith(search.Prezime.ToLower()));
            }
            if (search.DjelatnostId > 0)
            {
                query =query.Include(x => x.Djelatnost).Where(x => x.DjelatnostId == search.DjelatnostId);
            }
            if (!string.IsNullOrWhiteSpace(search?.Email))
            {
                query =query.Where(x => x.Korisnik.Email == search.Email);
            }
            if (!string.IsNullOrWhiteSpace(search?.KorisnickoIme))
            {
                query =query.Where(x => x.Korisnik.KorisnickoIme == search.KorisnickoIme);
            }
            if (search.Aktivan != null)
            {
                query =query.Include(x => x.Djelatnost).Where(x => x.Korisnik.Aktivan == search.Aktivan);
            }
            var list = query.ToList();
            var returns = _mapper.Map<List<Data.OsobljeDTO>>(list);
            return returns;
        }

        public Data.KorisniciSistema GetPotvrda(PotvrdaSearchRequest search)
        {
            KorisniciSistema korisniciSistema = _db.KorisniciSistemas.Where(x => x.Email == search.Email).FirstOrDefault();
            if (korisniciSistema!=null)
            {
                return _mapper.Map<Data.KorisniciSistema>(korisniciSistema);
            }
            korisniciSistema = _db.KorisniciSistemas.Where(x => x.KorisnickoIme == search.KorisnickoIme).FirstOrDefault();
            var returns = _mapper.Map<Data.KorisniciSistema>(korisniciSistema);
            return returns;
        }
    }
}
