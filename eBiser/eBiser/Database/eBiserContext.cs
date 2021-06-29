using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;



namespace eBiser.Database
{
    public partial class eBiserContext : DbContext
    {
        public eBiserContext()
        {
        }

        public eBiserContext(DbContextOptions<eBiserContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AkcijePomoci> AkcijePomocis { get; set; }
        public virtual DbSet<Clanarina> Clanarinas { get; set; }
        public virtual DbSet<Clanovi> Clanovis { get; set; }
        public virtual DbSet<DjelatnostOsoblje> DjelatnostOsobljes { get; set; }
        public virtual DbSet<Donacije> Donacijes { get; set; }
        public virtual DbSet<Donatori> Donatoris { get; set; }
        public virtual DbSet<IzlaznaSredstva> IzlaznaSredstvas { get; set; }
        public virtual DbSet<IzlaznaSredstvaPhoto> IzlaznaSredstvaPhotos { get; set; }
        public virtual DbSet<KorisniciSistema> KorisniciSistemas { get; set; }
        public virtual DbSet<KorisnikSistemaTip> KorisnikSistemaTips { get; set; }
        public virtual DbSet<ObavijestKategorija> ObavijestKategorijas { get; set; }
        public virtual DbSet<ObavijestOcjena> ObavijestOcjenas { get; set; }
        public virtual DbSet<ObavijestPhoto> ObavijestPhotos { get; set; }
        public virtual DbSet<Obavijesti> Obavijestis { get; set; }
        public virtual DbSet<Osoblje> Osobljes { get; set; }
        public virtual DbSet<Projekti> Projektis { get; set; }
        public virtual DbSet<Sastanak> Sastanaks { get; set; }
        public virtual DbSet<UlaznaSredstva> UlaznaSredstvas { get; set; }
        public virtual DbSet<UlaznaSredstvaPhoto> UlaznaSredstvaPhotos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                #warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=.;Database=eBiser;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Bosnian_Latin_100_BIN");

            modelBuilder.Entity<AkcijePomoci>(entity =>
            {
                entity.ToTable("AkcijePomoci");

                entity.HasIndex(e => e.OsobljeId, "IX_AkcijePomoci_OsobljeId");

                entity.HasOne(d => d.Osoblje)
                    .WithMany(p => p.AkcijePomocis)
                    .HasForeignKey(d => d.OsobljeId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<Clanarina>(entity =>
            {
                entity.ToTable("Clanarina");

                entity.HasIndex(e => e.ClanId, "IX_Clanarina_ClanId");

                entity.HasOne(d => d.Clan)
                    .WithMany(p => p.Clanarinas)
                    .HasForeignKey(d => d.ClanId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<Clanovi>(entity =>
            {
                entity.ToTable("Clanovi");

                entity.HasIndex(e => e.KorisnikId, "IX_Clanovi_KorisnikId");

                entity.HasOne(d => d.Korisnik)
                    .WithMany(p => p.Clanovis)
                    .HasForeignKey(d => d.KorisnikId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<DjelatnostOsoblje>(entity =>
            {
                entity.ToTable("DjelatnostOsoblje");
            });

            modelBuilder.Entity<Donacije>(entity =>
            {
                entity.ToTable("Donacije");

                entity.HasIndex(e => e.KorisniciSistemaId, "IX_Donacije_KorisniciSistemaId");

                entity.Property(e => e.DatumOdgovra).HasDefaultValueSql("('0001-01-01T00:00:00.0000000')");

                entity.Property(e => e.DatumPrijave).HasDefaultValueSql("('0001-01-01T00:00:00.0000000')");

                entity.Property(e => e.NaCekanju)
                    .IsRequired()
                    .HasDefaultValueSql("(CONVERT([bit],(0)))");

                entity.Property(e => e.Odbijena)
                    .IsRequired()
                    .HasDefaultValueSql("(CONVERT([bit],(0)))");

                entity.HasOne(d => d.KorisniciSistema)
                    .WithMany(p => p.Donacijes)
                    .HasForeignKey(d => d.KorisniciSistemaId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<Donatori>(entity =>
            {
                entity.ToTable("Donatori");

                entity.HasIndex(e => e.KorisnikId, "IX_Donatori_KorisnikId");

                entity.HasOne(d => d.Korisnik)
                    .WithMany(p => p.Donatoris)
                    .HasForeignKey(d => d.KorisnikId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<IzlaznaSredstva>(entity =>
            {
                entity.ToTable("IzlaznaSredstva");

                entity.HasIndex(e => e.OsobljeId, "IX_IzlaznaSredstva_OsobljeId");

                entity.HasOne(d => d.Osoblje)
                    .WithMany(p => p.IzlaznaSredstvas)
                    .HasForeignKey(d => d.OsobljeId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<IzlaznaSredstvaPhoto>(entity =>
            {
                entity.ToTable("IzlaznaSredstvaPhoto");

                entity.HasIndex(e => e.IzlaznaSredstvaId, "IX_IzlaznaSredstvaPhoto_IzlaznaSredstvaId");

                entity.HasOne(d => d.IzlaznaSredstva)
                    .WithMany(p => p.IzlaznaSredstvaPhotos)
                    .HasForeignKey(d => d.IzlaznaSredstvaId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<KorisniciSistema>(entity =>
            {
                entity.HasKey(e => e.KorisnikId);

                entity.ToTable("KorisniciSistema");

                entity.HasIndex(e => e.KorisnikSistemaTipId, "IX_KorisniciSistema_KorisnikSistemaTipId");

                entity.Property(e => e.DatumRodjenja).HasDefaultValueSql("('0001-01-01T00:00:00.0000000')");

                entity.HasOne(d => d.KorisnikSistemaTip)
                    .WithMany(p => p.KorisniciSistemas)
                    .HasForeignKey(d => d.KorisnikSistemaTipId);
            });

            modelBuilder.Entity<KorisnikSistemaTip>(entity =>
            {
                entity.ToTable("KorisnikSistemaTip");
            });

            modelBuilder.Entity<ObavijestKategorija>(entity =>
            {
                entity.ToTable("ObavijestKategorija");
            });

            modelBuilder.Entity<ObavijestOcjena>(entity =>
            {
                entity.ToTable("ObavijestOcjena");

                entity.HasIndex(e => e.KorisniciSistemaId, "IX_ObavijestOcjena_KorisniciSistemaId");

                entity.HasIndex(e => e.ObavijestId, "IX_ObavijestOcjena_ObavijestId");

                entity.HasOne(d => d.KorisniciSistema)
                    .WithMany(p => p.ObavijestOcjenas)
                    .HasForeignKey(d => d.KorisniciSistemaId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Obavijest)
                    .WithMany(p => p.ObavijestOcjenas)
                    .HasForeignKey(d => d.ObavijestId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<ObavijestPhoto>(entity =>
            {
                entity.ToTable("obavijestPhoto");

                entity.HasIndex(e => e.ObavijestId, "IX_obavijestPhoto_ObavijestId");

                entity.HasOne(d => d.Obavijest)
                    .WithMany(p => p.ObavijestPhotos)
                    .HasForeignKey(d => d.ObavijestId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<Obavijesti>(entity =>
            {
                entity.ToTable("Obavijesti");

                entity.HasIndex(e => e.KategorijaId, "IX_Obavijesti_KategorijaId");

                entity.HasIndex(e => e.OsobljeId, "IX_Obavijesti_OsobljeId");

                entity.HasOne(d => d.Kategorija)
                    .WithMany(p => p.Obavijestis)
                    .HasForeignKey(d => d.KategorijaId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Osoblje)
                    .WithMany(p => p.Obavijestis)
                    .HasForeignKey(d => d.OsobljeId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<Osoblje>(entity =>
            {
                entity.ToTable("Osoblje");

                entity.HasIndex(e => e.DjelatnostId, "IX_Osoblje_DjelatnostId");

                entity.HasIndex(e => e.KorisnikId, "IX_Osoblje_KorisnikId");

                entity.HasOne(d => d.Djelatnost)
                    .WithMany(p => p.Osobljes)
                    .HasForeignKey(d => d.DjelatnostId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Korisnik)
                    .WithMany(p => p.Osobljes)
                    .HasForeignKey(d => d.KorisnikId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<Projekti>(entity =>
            {
                entity.ToTable("Projekti");

                entity.HasIndex(e => e.OsobljeId, "IX_Projekti_OsobljeId");

                entity.HasOne(d => d.Osoblje)
                    .WithMany(p => p.Projektis)
                    .HasForeignKey(d => d.OsobljeId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<Sastanak>(entity =>
            {
                entity.ToTable("Sastanak");

                entity.HasIndex(e => e.OsobljeId, "IX_Sastanak_OsobljeId");

                entity.Property(e => e.Zakazan)
                    .IsRequired()
                    .HasDefaultValueSql("(CONVERT([bit],(0)))");

                entity.HasOne(d => d.Osoblje)
                    .WithMany(p => p.Sastanaks)
                    .HasForeignKey(d => d.OsobljeId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<UlaznaSredstva>(entity =>
            {
                entity.ToTable("UlaznaSredstva");

                entity.HasIndex(e => e.OsobljeId, "IX_UlaznaSredstva_OsobljeId");

                entity.HasOne(d => d.Osoblje)
                    .WithMany(p => p.UlaznaSredstvas)
                    .HasForeignKey(d => d.OsobljeId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<UlaznaSredstvaPhoto>(entity =>
            {
                entity.ToTable("UlaznaSredstvaPhoto");

                entity.HasIndex(e => e.UlaznaSredstvaId, "IX_UlaznaSredstvaPhoto_UlaznaSredstvaId");

                entity.HasOne(d => d.UlaznaSredstva)
                    .WithMany(p => p.UlaznaSredstvaPhotos)
                    .HasForeignKey(d => d.UlaznaSredstvaId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
