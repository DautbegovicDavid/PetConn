using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace PetConn.WebAPI.Database
{
    public partial class firstTryContext : DbContext
    {
        public firstTryContext()
        {
        }

        public firstTryContext(DbContextOptions<firstTryContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Drzava> Drzavas { get; set; }
        public virtual DbSet<Grad> Grads { get; set; }
        public virtual DbSet<KorisniciUloge> KorisniciUloges { get; set; }
        public virtual DbSet<Korisnik> Korisniks { get; set; }
        public virtual DbSet<Lokacija> Lokacijas { get; set; }
        public virtual DbSet<Partneri> Partneris { get; set; }
        public virtual DbSet<Poslovnica> Poslovnicas { get; set; }
        public virtual DbSet<Uloga> Ulogas { get; set; }
        public virtual DbSet<Uposlenik> Uposleniks { get; set; }
        public virtual DbSet<VrstaPartnera> VrstaPartneras { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=.;Database=firstTry;Trusted_Connection=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Bosnian_Latin_100_BIN");

            modelBuilder.Entity<Drzava>(entity =>
            {
                entity.ToTable("Drzava");

                entity.Property(e => e.DrzavaId).HasColumnName("drzavaID");

                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .HasMaxLength(1)
                    .HasColumnName("naziv");
            });

            modelBuilder.Entity<Grad>(entity =>
            {
                entity.ToTable("Grad");

                entity.Property(e => e.GradId).HasColumnName("gradID");

                entity.Property(e => e.DrzavaId).HasColumnName("drzavaID");

                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .HasMaxLength(1)
                    .HasColumnName("naziv");

                entity.Property(e => e.PostanskiBroj)
                    .HasMaxLength(1)
                    .HasColumnName("postanskiBroj");

                entity.HasOne(d => d.Drzava)
                    .WithMany(p => p.Grads)
                    .HasForeignKey(d => d.DrzavaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_drzava");
            });

            modelBuilder.Entity<KorisniciUloge>(entity =>
            {
                entity.HasKey(e => e.KorisnikUlogaId)
                    .HasName("pk_korisnici_uloge");

                entity.ToTable("KorisniciUloge");

                entity.Property(e => e.KorisnikUlogaId).HasColumnName("korisnikUlogaID");

                entity.Property(e => e.DatumIzmjene)
                    .HasColumnType("date")
                    .HasColumnName("datumIzmjene");

                entity.Property(e => e.KorisnikId).HasColumnName("korisnikID");

                entity.Property(e => e.UlogaId).HasColumnName("ulogaID");

                entity.HasOne(d => d.Korisnik)
                    .WithMany(p => p.KorisniciUloges)
                    .HasForeignKey(d => d.KorisnikId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_korisnik");

                entity.HasOne(d => d.Uloga)
                    .WithMany(p => p.KorisniciUloges)
                    .HasForeignKey(d => d.UlogaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_uloga");
            });

            modelBuilder.Entity<Korisnik>(entity =>
            {
                entity.ToTable("Korisnik");

                entity.Property(e => e.KorisnikId).HasColumnName("korisnikID");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("email");

                entity.Property(e => e.Ime)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("ime");

                entity.Property(e => e.KorisnickoIme)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("korisnickoIme");

                entity.Property(e => e.LozinkaHash)
                    .HasMaxLength(50)
                    .HasColumnName("lozinkaHash");

                entity.Property(e => e.LozinkaSalt)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("lozinkaSalt");

                entity.Property(e => e.Prezime)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("prezime");

                entity.Property(e => e.Telefon)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("telefon");
            });

            modelBuilder.Entity<Lokacija>(entity =>
            {
                entity.ToTable("Lokacija");

                entity.Property(e => e.LokacijaId).HasColumnName("lokacijaID");

                entity.Property(e => e.Adresa)
                    .HasMaxLength(1)
                    .HasColumnName("adresa");

                entity.Property(e => e.GradId).HasColumnName("gradID");

                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .HasMaxLength(1)
                    .HasColumnName("naziv");

                entity.HasOne(d => d.Grad)
                    .WithMany(p => p.Lokacijas)
                    .HasForeignKey(d => d.GradId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_grad");
            });

            modelBuilder.Entity<Partneri>(entity =>
            {
                entity.HasKey(e => e.PartnerId)
                    .HasName("PK__Partneri__6E8AD154C7537702");

                entity.ToTable("Partneri");

                entity.Property(e => e.PartnerId).HasColumnName("partnerID");

                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("naziv");

                entity.Property(e => e.VrstaPartneraId).HasColumnName("vrstaPartneraID");

                entity.HasOne(d => d.VrstaPartnera)
                    .WithMany(p => p.Partneris)
                    .HasForeignKey(d => d.VrstaPartneraId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_vrsta_partnera");
            });

            modelBuilder.Entity<Poslovnica>(entity =>
            {
                entity.ToTable("Poslovnica");

                entity.Property(e => e.PoslovnicaId).HasColumnName("poslovnicaID");

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .HasColumnName("email");

                entity.Property(e => e.LokacijaId).HasColumnName("lokacijaID");

                entity.Property(e => e.Naziv)
                    .HasMaxLength(100)
                    .HasColumnName("naziv");

                entity.Property(e => e.Otvoreno).HasColumnName("otvoreno");

                entity.Property(e => e.PartnerId).HasColumnName("partnerID");

                entity.Property(e => e.RadnoVrijemeDo).HasColumnName("radnoVrijemeDo");

                entity.Property(e => e.RadnoVrijemeOd).HasColumnName("radnoVrijemeOd");

                entity.Property(e => e.Slika).HasColumnName("slika");

                entity.Property(e => e.SlikaThumb).HasColumnName("slikaThumb");

                entity.Property(e => e.Telefon)
                    .HasMaxLength(100)
                    .HasColumnName("telefon");

                entity.HasOne(d => d.Lokacija)
                    .WithMany(p => p.Poslovnicas)
                    .HasForeignKey(d => d.LokacijaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_lokacija");

                entity.HasOne(d => d.Partner)
                    .WithMany(p => p.Poslovnicas)
                    .HasForeignKey(d => d.PartnerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_vlasnik_partner");
            });

            modelBuilder.Entity<Uloga>(entity =>
            {
                entity.ToTable("Uloga");

                entity.Property(e => e.UlogaId).HasColumnName("ulogaID");

                entity.Property(e => e.DatumIzmjene)
                    .HasColumnType("datetime")
                    .HasColumnName("datumIzmjene");

                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("naziv");
            });

            modelBuilder.Entity<Uposlenik>(entity =>
            {
                entity.ToTable("Uposlenik");

                entity.Property(e => e.UposlenikId)
                    .ValueGeneratedNever()
                    .HasColumnName("uposlenikID");

                entity.Property(e => e.DatumIzmjene)
                    .HasColumnType("date")
                    .HasColumnName("datumIzmjene");

                entity.Property(e => e.PartnerId).HasColumnName("partnerID");

                entity.HasOne(d => d.Partner)
                    .WithMany(p => p.Uposleniks)
                    .HasForeignKey(d => d.PartnerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_partner");

                entity.HasOne(d => d.UposlenikNavigation)
                    .WithOne(p => p.Uposlenik)
                    .HasForeignKey<Uposlenik>(d => d.UposlenikId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Uposlenik__uposl__4222D4EF");
            });

            modelBuilder.Entity<VrstaPartnera>(entity =>
            {
                entity.ToTable("VrstaPartnera");

                entity.Property(e => e.VrstaPartneraId).HasColumnName("vrstaPartneraID");

                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .HasMaxLength(1)
                    .HasColumnName("naziv");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
