using AutoMapper;
using eBiser.Data.Requests;
using eBiser.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static eBiser.Data.Requests.KorisniciInserttRequest;
using static eBiser.Data.Requests.KorisniciUpdateRequest;

namespace eBiser.Helper
{
    public class Mapper : Profile
    {
        public Mapper()
        {

            CreateMap<Obavijesti, ObavijestInsertRequest>().ReverseMap();
            CreateMap<Obavijesti, Data.Obavijest>()
                .ForMember(d=> d.Kategorija, opt=> opt.MapFrom(src=> src.Kategorija.NazivKategorije));
            CreateMap<Clanarina, Data.Clanarina>()
                .ForMember(d => d.Ime, opt => opt.MapFrom(src => src.Clan.Korisnik.Ime))
                .ForMember(d => d.Prezime, opt => opt.MapFrom(src => src.Clan.Korisnik.Prezime))
                .ForMember(d => d.ImeIPrezime, opt => opt.MapFrom(src => src.Clan.Korisnik.Ime + " " + src.Clan.Korisnik.Prezime)).ReverseMap();
            CreateMap<Clanarina, ClanarinaUpsertRequest>().ReverseMap();
            CreateMap<Projekti, ProjektiUpsertRequest>().ReverseMap();
            CreateMap<Projekti, Data.Projekti>();
            CreateMap<AkcijePomoci, AkcijePomociUpsertRequest>().ReverseMap();


            CreateMap<AkcijePomoci, Data.AkcijePomoci>()
                .ForMember(x => x.Progres, opt => opt.MapFrom(src => (src.Skupljeno == 0 ? 1 : src.Skupljeno) / (src.TraženaCifra == 0 ? 1 : src.TraženaCifra)));
            CreateMap<Sastanak, SastanakUpsertRequest>().ReverseMap();
            CreateMap<Sastanak, Data.Sastanak>()
                .ForMember(d => d.ImeIPrezime, opt => opt.MapFrom(src => src.Osoblje.Korisnik.Ime + " " + src.Osoblje.Korisnik.Prezime));
            CreateMap<DjelatnostOsoblje, Data.DjelatnostOsoblje>();
            CreateMap<ObavijestKategorija, Data.ObavijestKategorija>();
            CreateMap<UlaznaSredstva, UlaznaSredstvaUpsertRequest>().ReverseMap();
            CreateMap<UlaznaSredstva, Data.UlaznaSredstva>();    
            CreateMap<IzlaznaSredstva, IzlaznaSredstvaUpsertRequest>().ReverseMap();
            CreateMap<IzlaznaSredstva, Data.IzlaznaSredstva>();      
            
            CreateMap<Donacije, DonacijeUpsertRequest>().ReverseMap();
            CreateMap<Donacije, Data.Donacije>()
                .ForMember(x=> x.ImeDonatora,opt=> opt.MapFrom(src=> src.KorisniciSistema.Ime))
                .ForMember(x=> x.ImeIPrezimeDonatora,opt=> opt.MapFrom(src=> src.KorisniciSistema.Ime+ src.KorisniciSistema.Prezime))
                .ForMember(x=> x.PrezimeDonatora,opt=> opt.MapFrom(src=> src.KorisniciSistema.Prezime));      


            CreateMap<ObavijestOcjena, ObavijestOcjenaUpsertRequest>().ReverseMap();
            CreateMap<ObavijestOcjena, Data.ObavijestOcjena>()
                .ForMember(x=> x.ImeiPrezime, opt=> opt.MapFrom(src=> src.KorisniciSistema.Ime+" "+src.KorisniciSistema.Prezime ));



            //autorizacija
            CreateMap<KorisniciSistema, KorisniciInserttRequest>().ReverseMap();
            CreateMap<KorisniciSistema, KorisniciUpdateRequest>().ReverseMap();
            CreateMap<KorisniciSistema, Data.KorisniciSistema>()
                .ForMember(d => d.ImeIPrezime, opt => opt.MapFrom(src => src.Ime + " " + src.Prezime)).ReverseMap();
            CreateMap<Clanovi, ClanUpdateRequest>().ReverseMap();
            CreateMap<Clanovi, ClanUpsertRequest>().ReverseMap();
            CreateMap<Clanovi, Data.ClanDTO>()
                .ForMember(d => d.Ime,opt=> opt.MapFrom(src=> src.Korisnik.Ime))
                .ForMember(d => d.Prezime, opt=> opt.MapFrom(src=> src.Korisnik.Prezime))
                .ForMember(d => d.Photo, opt=> opt.MapFrom(src=> src.Korisnik.Photo))
                .ForMember(d => d.PhotoThumb, opt=> opt.MapFrom(src=> src.Korisnik.PhotoThumb))
                .ForMember(d => d.KorisnickoIme, opt=> opt.MapFrom(src=> src.Korisnik.KorisnickoIme))
                .ForMember(d => d.Aktivan, opt=> opt.MapFrom(src=> src.Korisnik.Aktivan))
                .ForMember(d => d.Verifikovan, opt=> opt.MapFrom(src=> src.Korisnik.Verifikovan))
                .ForMember(d => d.DatumRegistracije, opt=> opt.MapFrom(src=> src.Korisnik.DatumRegistracije))
                .ForMember(d => d.DatumIzmjene, opt=> opt.MapFrom(src=> src.Korisnik.DatumIzmjene))
                .ForMember(d => d.DatumRodjenja, opt=> opt.MapFrom(src=> src.Korisnik.DatumRodjenja))
                .ForMember(d => d.Email, opt=> opt.MapFrom(src=> src.Korisnik.Email))
                .ForMember(d => d.KorisnikSistemaTipId, opt=> opt.MapFrom(src=> src.Korisnik.KorisnikSistemaTipId))
                .ForMember(d => d.ImeIPrezime, opt => opt.MapFrom(src => src.Korisnik.Ime + " " + src.Korisnik.Prezime)).ReverseMap();





            CreateMap<Osoblje, OsobljeUpsertRequest>().ReverseMap();
            CreateMap<Osoblje, OsobljeUpdateRequest>().ReverseMap();
            CreateMap<Osoblje, Data.OsobljeDTO>()
                .ForMember(d => d.Ime, opt => opt.MapFrom(src => src.Korisnik.Ime))
                .ForMember(d => d.Prezime, opt => opt.MapFrom(src => src.Korisnik.Prezime))
                .ForMember(d => d.Photo, opt => opt.MapFrom(src => src.Korisnik.Photo))
                .ForMember(d => d.PhotoThumb, opt => opt.MapFrom(src => src.Korisnik.PhotoThumb))
                .ForMember(d => d.KorisnickoIme, opt => opt.MapFrom(src => src.Korisnik.KorisnickoIme))
                .ForMember(d => d.Aktivan, opt => opt.MapFrom(src => src.Korisnik.Aktivan))
                .ForMember(d => d.Verifikovan, opt => opt.MapFrom(src => src.Korisnik.Verifikovan))
                .ForMember(d => d.DatumRegistracije, opt => opt.MapFrom(src => src.Korisnik.DatumRegistracije))
                .ForMember(d => d.DatumIzmjene, opt => opt.MapFrom(src => src.Korisnik.DatumIzmjene))
                .ForMember(d => d.DatumRodjenja, opt => opt.MapFrom(src => src.Korisnik.DatumRodjenja))
                .ForMember(d => d.Email, opt => opt.MapFrom(src => src.Korisnik.Email))
                .ForMember(d => d.KorisnikSistemaTipId, opt => opt.MapFrom(src => src.Korisnik.KorisnikSistemaTipId))
                .ForMember(d => d.NazivDjelatnosti , opt => opt.MapFrom(src => src.Djelatnost.NazivDjelatnosti))
                .ForMember(d => d.ImeIPrezime, opt => opt.MapFrom(src => src.Korisnik.Ime + " " + src.Korisnik.Prezime)).ReverseMap();




            CreateMap<Donatori, DonatorUpsertRequest>().ReverseMap();
            CreateMap<Donatori, DonatorUpdateRequest>().ReverseMap();
            CreateMap<Donatori, Data.DonatorDTO>()
                .ForMember(d => d.Ime, opt => opt.MapFrom(src => src.Korisnik.Ime))
                .ForMember(d => d.Prezime, opt => opt.MapFrom(src => src.Korisnik.Prezime))
                .ForMember(d => d.Photo, opt => opt.MapFrom(src => src.Korisnik.Photo))
                .ForMember(d => d.PhotoThumb, opt => opt.MapFrom(src => src.Korisnik.PhotoThumb))
                .ForMember(d => d.KorisnickoIme, opt => opt.MapFrom(src => src.Korisnik.KorisnickoIme))
                .ForMember(d => d.Aktivan, opt => opt.MapFrom(src => src.Korisnik.Aktivan))
                .ForMember(d => d.Verifikovan, opt => opt.MapFrom(src => src.Korisnik.Verifikovan))
                .ForMember(d => d.DatumRegistracije, opt => opt.MapFrom(src => src.Korisnik.DatumRegistracije))
                .ForMember(d => d.DatumIzmjene, opt => opt.MapFrom(src => src.Korisnik.DatumIzmjene))
                .ForMember(d => d.DatumRodjenja, opt => opt.MapFrom(src => src.Korisnik.DatumRodjenja))
                .ForMember(d => d.Email, opt => opt.MapFrom(src => src.Korisnik.Email))
                .ForMember(d => d.KorisnikSistemaTipId, opt => opt.MapFrom(src => src.Korisnik.KorisnikSistemaTipId))
                .ForMember(d => d.ImeIPrezime, opt => opt.MapFrom(src => src.Korisnik.Ime + " " + src.Korisnik.Prezime)).ReverseMap();




        }
    }
}
