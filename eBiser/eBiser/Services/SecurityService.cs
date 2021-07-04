using AutoMapper;
using eBiser.Data.Requests;
using eBiser.Configuration;
using eBiser.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static eBiser.Data.Requests.KorisniciInserttRequest;

namespace eBiser.Services
{
    public class SecurityService : ISecurityService
    {
        private readonly eBiserContext _db;
        private readonly IMapper _mapper;
        private readonly IOptions<AppSettings> _options;
        public SecurityService(eBiserContext db, IOptions<AppSettings> options, IMapper mapper)
        {
            _db = db;
            _options = options;
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
        // login samo za osoblje
        public Data.KorisniciSistema Login(KorisnikLoginRequest request)
        {

            var users = _db.KorisniciSistemas.ToList();
            var entity = _db.KorisniciSistemas.Include(x => x.KorisnikSistemaTip).FirstOrDefault(x=> x.KorisnickoIme==request.KorisnickoIme);
            if (entity==null)
            {
                entity = _db.KorisniciSistemas.Include(x => x.KorisnikSistemaTip).FirstOrDefault(x => x.Email == request.KorisnickoIme);
            }
            #region User existence check
            if (entity == null)
            {
                throw new ArgumentNullException("Wrong username or password");
            }
            var hash = GenerateHash(entity.PasswordSalt, request.Password);
            if (hash != entity.PasswordHash)
            {
                throw new Exception("Wrong password or password");
            }
            #endregion

            #region Token
            var key = Encoding.ASCII.GetBytes(_options.Value.Secret);
            var _claims = new[]
            {
                new Claim(ClaimTypes.NameIdentifier, entity.KorisnikId.ToString()),
                new Claim("user_type", entity.KorisnikSistemaTip.Naziv.ToString()),
                new Claim(ClaimTypes.Name, entity.KorisnickoIme),
                new Claim(ClaimTypes.Role, entity.KorisnikSistemaTip.Naziv)
            };

            var sCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256);
            var token = new JwtSecurityToken
                (issuer: null,
                    audience: null,
                    claims: _claims,
                    notBefore: DateTime.Now,
                    expires: DateTime.UtcNow.AddDays(7),
                    signingCredentials: sCredentials
                );

            var osoba = _mapper.Map<Data.KorisniciSistema>(entity);
            var access_token = new JwtSecurityTokenHandler().WriteToken(token);

            var clanDB = _db.Clanovis.Where(x => x.KorisnikId == osoba.KorisnikId).FirstOrDefault();
            if (clanDB != null)
            {
                Data.ClanDTO clan = _mapper.Map<Data.ClanDTO>(clanDB);
                clan.Token = access_token;
                return clan;
            }
            var osobljeDB = _db.Osobljes.Where(x => x.KorisnikId == osoba.KorisnikId).FirstOrDefault();
            if (osobljeDB != null)
            {
                Data.OsobljeDTO osoblje = _mapper.Map<Data.OsobljeDTO>(osobljeDB);
                osoblje.Token = access_token;

                return osoblje;
            }
            var donatorDB = _db.Donatoris.Where(x => x.KorisnikId == osoba.KorisnikId).FirstOrDefault();
            if (donatorDB != null)
            {
                Data.DonatorDTO donator = _mapper.Map<Data.DonatorDTO>(donatorDB);
                donator.Token = access_token;
                return donator;
            }

            osoba.Token = access_token;
            osoba.KorisnikId = entity.KorisnikId;
            return osoba;
            #endregion
        }

        public Data.KorisniciSistema RestartPassword(int id,RestartPasswordRequest request)
        {
            var users = _db.KorisniciSistemas.ToList();
            var entity = _db.KorisniciSistemas.Include(x => x.KorisnikSistemaTip).FirstOrDefault(x => x.KorisnikId == id);

            var hash = GenerateHash(entity.PasswordSalt, request.Password);
            if (hash != entity.PasswordHash)
            {
                throw new Exception("Wrong password ");
            }
            else if (request.NewPassword!= request.NewPasswordPotvrda)
            {
                throw new Exception("Wrong password ");

            }
            else
            {
                 entity.PasswordHash = GenerateHash(entity.PasswordSalt, request.NewPassword);
                _db.SaveChanges();
            }

            var osoba = _mapper.Map<Data.KorisniciSistema>(entity);
            return osoba;
        }
    }
}