using eBiser.Helper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace eBiser.Database
{
    public partial class eBiserContext 
    {
        
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder)
        {






            modelBuilder.Entity<KorisnikSistemaTip>().HasData(new KorisnikSistemaTip
            {
                Id = 1,
                Naziv = "Osoblje"
            });
            modelBuilder.Entity<KorisnikSistemaTip>().HasData(new KorisnikSistemaTip
            {
                Id = 2,
                Naziv = "Clan"
            });
            modelBuilder.Entity<KorisnikSistemaTip>().HasData(new KorisnikSistemaTip
            {
                Id = 3,
                Naziv = "Donator"
            });

            modelBuilder.Entity<DjelatnostOsoblje>().HasData(new DjelatnostOsoblje
            {
                Id = 1,
                NazivDjelatnosti = "Administrativno-Finansijski asistent"
            });

            modelBuilder.Entity<DjelatnostOsoblje>().HasData(new DjelatnostOsoblje
            {
                Id = 2,
                NazivDjelatnosti = "Predsjednik"
            });
            var korisnici = new KorisniciSistema
            {
                KorisnikId = 2,
                KorisnickoIme = "Clan",
                KorisnikSistemaTipId = 2,
                Aktivan = true,
                Email = "Clan@Clan.com",
                DatumRodjenja = DateTime.Now,
                DatumRegistracije = DateTime.Now,
                Verifikovan = true,
                Ime = "ClanIme",
                Prezime = "ClanPrezime",
                Photo = File.ReadAllBytes("TestPhoto/Racun1.jpg"),
                PhotoThumb = File.ReadAllBytes("TestPhoto/Racun1.jpg"),
                PasswordSalt = HashGenerator.GenerateSalt()
            };
            korisnici.PasswordHash = HashGenerator.GenerateHash(korisnici.PasswordSalt, "Clan");



            modelBuilder.Entity<KorisniciSistema>().HasData(korisnici);
            modelBuilder.Entity<Clanovi>().HasData(new Clanovi
            {
                Id = 1,
                KorisnikId = 2,
                BrojTelefona = "062111333",
                Dijagnoza = "Nema",
            });

            var osoblje = new KorisniciSistema
            {
                KorisnikId = 1,
                KorisnickoIme = "Osoblje",
                KorisnikSistemaTipId = 1,
                Aktivan = true,
                Email = "osoblje@osoblje.com",
                DatumRodjenja = DateTime.Now,
                DatumRegistracije = DateTime.Now,
                Verifikovan = true,
                Ime = "OsobljeIme",
                Prezime = "OsobljePrezime",
                Photo = File.ReadAllBytes("TestPhoto/racun2.jpg"),
                PhotoThumb = File.ReadAllBytes("TestPhoto/racun2.jpg"),
                PasswordSalt = HashGenerator.GenerateSalt()
            };
            osoblje.PasswordHash = HashGenerator.GenerateHash(osoblje.PasswordSalt, "Osoblje");


            modelBuilder.Entity<KorisniciSistema>().HasData(osoblje);
            modelBuilder.Entity<Osoblje>().HasData(new Osoblje
            {
                Id = 1,
                KorisnikId = 1,
                DjelatnostId = 1,
                DatumPocetkaAngazmana = DateTime.Now
            });

            var donator = new KorisniciSistema
            {
                KorisnikId = 3,
                KorisnickoIme = "Donator",
                KorisnikSistemaTipId = 3,
                Aktivan = true,
                Email = "donator@donator.com",
                DatumRodjenja = DateTime.Now,
                DatumRegistracije = DateTime.Now,
                Verifikovan = true,
                Ime = "DonatorIme",
                Prezime = "DonatorPrezime",
                Photo = File.ReadAllBytes("TestPhoto/donator.jpg"),
                PhotoThumb = File.ReadAllBytes("TestPhoto/donator.jpg"),
                PasswordSalt = HashGenerator.GenerateSalt()
            };
            donator.PasswordHash = HashGenerator.GenerateHash(donator.PasswordSalt, "Donator");

            modelBuilder.Entity<KorisniciSistema>().HasData(donator);
            modelBuilder.Entity<Donatori>().HasData(new Donatori
            {
                Id = 1,
                KorisnikId = 3,
                OpisProfila = "Opis profila za donatora",
                BrojTelefona="123456789"
            });


            modelBuilder.Entity<AkcijePomoci>().HasData(new AkcijePomoci
            {
                Id = 1,
                OsobljeId = 1,
                Aktivno = true,
                TraženaCifra = 5000,
                Skupljeno = 2500,
                Ime = "AkcijaPomociIme",
                Prezime = "AkcijaPomociPrezime",
                Fotografija = File.ReadAllBytes("TestPhoto/akcijapomoci1.jpg"),
            });

            modelBuilder.Entity<AkcijePomoci>().HasData(new AkcijePomoci
            {
                Id = 2,
                OsobljeId = 1,
                Aktivno = true,
                TraženaCifra = 5000,
                Skupljeno = 1000,
                Ime = "AkcijaPomociIme",
                Prezime = "AkcijaPomociPrezime",
                Fotografija = File.ReadAllBytes("TestPhoto/akcijapomoci2.jpg"),
            });


            modelBuilder.Entity<IzlaznaSredstva>().HasData(new IzlaznaSredstva
            {
                OsobljeId = 1,
                Datum = DateTime.Now,
                Količina = 440,
                Opis = "Izlazna sredstva opis(račun za struju)",
                Naslov = "Računi",
                Id = 1,

            });

            modelBuilder.Entity<IzlaznaSredstvaPhoto>().HasData(new IzlaznaSredstvaPhoto
            {
                Id = 1,
                IzlaznaSredstvaId = 1,
                Photo = File.ReadAllBytes("TestPhoto/Racun1.jpg"),

            });
            modelBuilder.Entity<IzlaznaSredstvaPhoto>().HasData(new IzlaznaSredstvaPhoto
            {
                Id = 2,
                IzlaznaSredstvaId = 1,
                Photo = File.ReadAllBytes("TestPhoto/racun2.jpg"),

            });

            modelBuilder.Entity<UlaznaSredstva>().HasData(new UlaznaSredstva
            {
                OsobljeId = 1,
                Datum = DateTime.Now,
                Količina = 1220,
                Opis = "Ulazna sredstva opis(donacija)",
                Naslov = "Donacija",
                Id = 1
            });
            modelBuilder.Entity<UlaznaSredstvaPhoto>().HasData(new UlaznaSredstvaPhoto
            {
                Id = 1,
                UlaznaSredstvaId = 1,
                Photo = File.ReadAllBytes("TestPhoto/Donacija1.jpg"),
            });
            modelBuilder.Entity<UlaznaSredstvaPhoto>().HasData(new UlaznaSredstvaPhoto
            {
                Id = 2,
                UlaznaSredstvaId = 1,
                Photo = File.ReadAllBytes("TestPhoto/Donacija2.jpg"),
            });



            modelBuilder.Entity<ObavijestKategorija>().HasData(new ObavijestKategorija
            {
                Id = 1,
                NazivKategorije = "Aktivnosti"
            });

            modelBuilder.Entity<ObavijestKategorija>().HasData(new ObavijestKategorija
            {
                Id = 2,
                NazivKategorije = "Projekti"
            });

            modelBuilder.Entity<ObavijestKategorija>().HasData(new ObavijestKategorija
            {
                Id = 3,
                NazivKategorije = "Realizacija projekata"
            });

            modelBuilder.Entity<ObavijestKategorija>().HasData(new ObavijestKategorija
            {
                Id = 4,
                NazivKategorije = "Volonterske akcije"
            });

            modelBuilder.Entity<Obavijesti>().HasData(new Obavijesti
            {
                Id = 1,
                Naslov = "Obavijest1",
                Aktivna = true,
                DatumObjave = DateTime.Now,
                VrijediDo = DateTime.Now,
                OsobljeId = 1,
                Sadržaj = "sadžraj prve obavijesti",
                KategorijaId = 1,
            });

            modelBuilder.Entity<ObavijestOcjena>().HasData(new ObavijestOcjena
            {
                Id = 1,
                DatumOcjene = DateTime.Now,
                KorisniciSistemaId = 1,
                ObavijestId = 1,
                Ocjena = 5,
            });
            modelBuilder.Entity<ObavijestOcjena>().HasData(new ObavijestOcjena
            {
                Id = 2,
                DatumOcjene = DateTime.Now,
                KorisniciSistemaId = 1,
                ObavijestId = 1,
                Ocjena = 2,
            });
            modelBuilder.Entity<ObavijestPhoto>().HasData(new ObavijestPhoto
            {
                Id = 1,
                ObavijestId = 1,
                Photo = File.ReadAllBytes("TestPhoto/obavijest1photo1.jpg"),
            });




            modelBuilder.Entity<Obavijesti>().HasData(new Obavijesti
            {
                Id = 2,
                Naslov = "Obavijest2",
                Aktivna = true,
                DatumObjave = DateTime.Now,
                VrijediDo = DateTime.Now,
                OsobljeId = 1,
                Sadržaj = "sadžraj druge obavijesti",
                KategorijaId = 2,
            });

            modelBuilder.Entity<ObavijestOcjena>().HasData(new ObavijestOcjena
            {
                Id = 3,
                DatumOcjene = DateTime.Now,
                KorisniciSistemaId = 1,
                ObavijestId = 2,
                Ocjena = 5,
            });
            modelBuilder.Entity<ObavijestOcjena>().HasData(new ObavijestOcjena
            {
                Id = 4,
                DatumOcjene = DateTime.Now,
                KorisniciSistemaId = 1,
                ObavijestId = 2,
                Ocjena = 2,
            });
            modelBuilder.Entity<ObavijestPhoto>().HasData(new ObavijestPhoto
            {
                Id = 2,
                ObavijestId = 2,
                Photo = File.ReadAllBytes("TestPhoto/obavijest2photo2.jpg"),
            });
            modelBuilder.Entity<ObavijestPhoto>().HasData(new ObavijestPhoto
            {
                Id = 3,
                ObavijestId = 2,
                Photo = File.ReadAllBytes("TestPhoto/obavijes2photo1.jpg"),
            });

            modelBuilder.Entity<ObavijestPhoto>().HasData(new ObavijestPhoto
            {
                Id = 4,
                ObavijestId = 2,
                Photo = File.ReadAllBytes("TestPhoto/obavijes2photo2.jpg"),
            });

            modelBuilder.Entity<Obavijesti>().HasData(new Obavijesti
            {
                Id = 3,
                Naslov = "Obavijest3",
                Aktivna = true,
                DatumObjave = DateTime.Now,
                VrijediDo = DateTime.Now,
                OsobljeId = 1,
                Sadržaj = "sadžraj treće obavijesti",
                KategorijaId = 3,
            });

            modelBuilder.Entity<ObavijestOcjena>().HasData(new ObavijestOcjena
            {
                Id = 5,
                DatumOcjene = DateTime.Now,
                KorisniciSistemaId = 1,
                ObavijestId = 3,
                Ocjena = 5,
            });
            modelBuilder.Entity<ObavijestOcjena>().HasData(new ObavijestOcjena
            {
                Id = 6,
                DatumOcjene = DateTime.Now,
                KorisniciSistemaId = 1,
                ObavijestId = 3,
                Ocjena = 2,
            });
            modelBuilder.Entity<ObavijestPhoto>().HasData(new ObavijestPhoto
            {
                Id = 5,
                ObavijestId = 3,
                Photo = File.ReadAllBytes("TestPhoto/obavijest3photo1.jpg"),
            });
            modelBuilder.Entity<ObavijestPhoto>().HasData(new ObavijestPhoto
            {
                Id = 6,
                ObavijestId = 3,
                Photo = File.ReadAllBytes("TestPhoto/obavijest3photo2.jpg"),
            });




            modelBuilder.Entity<Obavijesti>().HasData(new Obavijesti
            {
                Id = 4,
                Naslov = "Obavijest4",
                Aktivna = true,
                DatumObjave = DateTime.Now,
                VrijediDo = DateTime.Now,
                OsobljeId = 1,
                Sadržaj = "sadžraj četvrte obavijesti",
                KategorijaId = 4,
            });

            modelBuilder.Entity<ObavijestOcjena>().HasData(new ObavijestOcjena
            {
                Id = 7,
                DatumOcjene = DateTime.Now,
                KorisniciSistemaId = 1,
                ObavijestId = 4,
                Ocjena = 5,
            });
            modelBuilder.Entity<ObavijestOcjena>().HasData(new ObavijestOcjena
            {
                Id = 8,
                DatumOcjene = DateTime.Now,
                KorisniciSistemaId = 1,
                ObavijestId = 4,
                Ocjena = 2,
            });

            modelBuilder.Entity<ObavijestPhoto>().HasData(new ObavijestPhoto
            {
                Id = 7,
                ObavijestId = 4,
                Photo = File.ReadAllBytes("TestPhoto/obavijes4photo1.jpg"),
            });

            modelBuilder.Entity<ObavijestPhoto>().HasData(new ObavijestPhoto
            {
                Id = 8,
                ObavijestId = 4,
                Photo = File.ReadAllBytes("TestPhoto/obavijest5photo2.jpg"),
            });


            modelBuilder.Entity<Obavijesti>().HasData(new Obavijesti
            {
                Id = 5,
                Naslov = "Obavijest4",
                Aktivna = true,
                DatumObjave = DateTime.Now,
                VrijediDo = DateTime.Now,
                OsobljeId = 1,
                Sadržaj = "sadžraj pete obavijesti",
                KategorijaId = 4,
            });

            modelBuilder.Entity<ObavijestOcjena>().HasData(new ObavijestOcjena
            {
                Id = 9,
                DatumOcjene = DateTime.Now,
                KorisniciSistemaId = 1,
                ObavijestId = 5,
                Ocjena = 5,
            });
            modelBuilder.Entity<ObavijestOcjena>().HasData(new ObavijestOcjena
            {
                Id = 10,
                DatumOcjene = DateTime.Now,
                KorisniciSistemaId = 1,
                ObavijestId = 5,
                Ocjena = 4,
            });

            modelBuilder.Entity<ObavijestPhoto>().HasData(new ObavijestPhoto
            {
                Id = 9,
                ObavijestId = 5,
                Photo = File.ReadAllBytes("TestPhoto/obavijes4photo1.jpg"),
            });

            modelBuilder.Entity<ObavijestPhoto>().HasData(new ObavijestPhoto
            {
                Id = 10,
                ObavijestId = 5,
                Photo = File.ReadAllBytes("TestPhoto/obavijest5photo2.jpg"),
            });


            modelBuilder.Entity<Obavijesti>().HasData(new Obavijesti
            {
                Id = 6,
                Naslov = "Obavijest4",
                Aktivna = true,
                DatumObjave = DateTime.Now,
                VrijediDo = DateTime.Now,
                OsobljeId = 1,
                Sadržaj = "sadžraj šeste obavijesti",
                KategorijaId = 4,
            });

            modelBuilder.Entity<ObavijestOcjena>().HasData(new ObavijestOcjena
            {
                Id = 11,
                DatumOcjene = DateTime.Now,
                KorisniciSistemaId = 1,
                ObavijestId = 6,
                Ocjena = 5,
            });
            modelBuilder.Entity<ObavijestOcjena>().HasData(new ObavijestOcjena
            {
                Id = 12,
                DatumOcjene = DateTime.Now,
                KorisniciSistemaId = 1,
                ObavijestId = 6,
                Ocjena = 5,
            });

            modelBuilder.Entity<ObavijestPhoto>().HasData(new ObavijestPhoto
            {
                Id = 11,
                ObavijestId = 6,
                Photo = File.ReadAllBytes("TestPhoto/obavijes4photo1.jpg"),
            });

            modelBuilder.Entity<ObavijestPhoto>().HasData(new ObavijestPhoto
            {
                Id = 12,
                ObavijestId = 6,
                Photo = File.ReadAllBytes("TestPhoto/obavijest5photo2.jpg"),
            });






























            modelBuilder.Entity<Sastanak>().HasData(new Sastanak
            {
                Id = 1,
                OsobljeId = 1,
                DatumOdrzavanja = DateTime.Now,
                Zakazan = true,
                Odrzan = true,
                Naslov="Naslov sastanka",
                Zapisnik = "Zapisnik sa sastanka održanog ....",
            });

            modelBuilder.Entity<Sastanak>().HasData(new Sastanak
            {
                Id = 2,
                OsobljeId = 1,
                DatumOdrzavanja = DateTime.Now,
                Zakazan = true,
                Odrzan = false,
                Naslov="Zakazani sastanak",
                Zapisnik = "",
            });

            modelBuilder.Entity<Projekti>().HasData(new Projekti
            {
                Id = 1,
                OsobljeId = 1,
                Prihvaćen = true,
                RokIzvrsenja = "3 mjeseca",
                CijenaProjekta = 1222,
                OdobrenaSredstva = 1200,
                DatumPrijave = DateTime.Now.Date,
                DatumIzvrsenja=DateTime.Now.Date,
                NazivProjekta="Projekat1"
            });






            modelBuilder.Entity<Donacije>().HasData(new Donacije
            {
                Id = 1,
                KorisniciSistemaId = 1,
                DatumOdgovra = DateTime.Now,
                DatumPrijave = DateTime.Now,
                NaCekanju = false,
                Odbijena = false,
                Prihvacena = true,
                Naziv = "novčana pomoć u iznosu od 1200€",
                OpisDonacije = "želim pomoći radu udruženja",
                Obrazlozenje = "zahvaljujemo vam se na donaciji",
            });


            modelBuilder.Entity<Donacije>().HasData(new Donacije
            {
                Id = 2,
                KorisniciSistemaId = 2,
                DatumOdgovra = DateTime.Now,
                DatumPrijave = DateTime.Now,
                NaCekanju = false,
                Odbijena = false,
                Prihvacena = true,
                Naziv = "novčana pomoć u iznosu od 200€",
                OpisDonacije = "želim pomoći radu udruženja",
                Obrazlozenje = "zahvaljujemo vam se na donaciji",
            });

            modelBuilder.Entity<Donacije>().HasData(new Donacije
            {
                Id = 3,
                KorisniciSistemaId = 3,
                DatumOdgovra = DateTime.Now,
                DatumPrijave = DateTime.Now,
                NaCekanju = false,
                Odbijena = false,
                Prihvacena = true,
                Naziv = "novčana pomoć u iznosu od 100€",
                OpisDonacije = "želim pomoći radu udruženja",
                Obrazlozenje = "zahvaljujemo vam se na donaciji",
            });

            modelBuilder.Entity<Clanarina>().HasData(new Clanarina
            {
                Id = 1,
                ClanId = 1,
                DatumUplate = DateTime.Now,
                Godina = 2021,
                Mjesec = 2,
                Iznos = 2,
            });

            modelBuilder.Entity<Clanarina>().HasData(new Clanarina
            {
                Id = 2,
                ClanId = 1,
                DatumUplate = DateTime.Now,
                Godina = 2021,
                Mjesec = 3,
                Iznos = 2,
            });




        }
    
    
    }
}
