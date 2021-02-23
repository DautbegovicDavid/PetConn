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

        public virtual DbSet<Doktor> Doktors { get; set; }
        public virtual DbSet<Drzava> Drzavas { get; set; }
        public virtual DbSet<Faktura> Fakturas { get; set; }
        public virtual DbSet<Grad> Grads { get; set; }
        public virtual DbSet<JedinicaMjere> JedinicaMjeres { get; set; }
        public virtual DbSet<KorisniciUloge> KorisniciUloges { get; set; }
        public virtual DbSet<Korisnik> Korisniks { get; set; }
        public virtual DbSet<Kupac> Kupacs { get; set; }
        public virtual DbSet<Ljubimac> Ljubimacs { get; set; }
        public virtual DbSet<Lokacija> Lokacijas { get; set; }
        public virtual DbSet<Nalaz> Nalazs { get; set; }
        public virtual DbSet<Narudzba> Narudzbas { get; set; }
        public virtual DbSet<NarudzbaStavke> NarudzbaStavkes { get; set; }
        public virtual DbSet<Partneri> Partneris { get; set; }
        public virtual DbSet<Poslovnica> Poslovnicas { get; set; }
        public virtual DbSet<Pregled> Pregleds { get; set; }
        public virtual DbSet<Proizvod> Proizvods { get; set; }
        public virtual DbSet<Proizvodjac> Proizvodjacs { get; set; }
        public virtual DbSet<RasaZivotinje> RasaZivotinjes { get; set; }
        public virtual DbSet<Termin> Termins { get; set; }
        public virtual DbSet<TipZivotinje> TipZivotinjes { get; set; }
        public virtual DbSet<Titula> Titulas { get; set; }
        public virtual DbSet<Uloga> Ulogas { get; set; }
        public virtual DbSet<Uposlenik> Uposleniks { get; set; }
        public virtual DbSet<VlasnikZivotinje> VlasnikZivotinjes { get; set; }
        public virtual DbSet<VrstaDoktora> VrstaDoktoras { get; set; }
        public virtual DbSet<VrstaPartnera> VrstaPartneras { get; set; }
        public virtual DbSet<VrstaProizvodum> VrstaProizvoda { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=.;Database=firstTry;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Bosnian_Latin_100_BIN");

            modelBuilder.Entity<Doktor>(entity =>
            {
                entity.ToTable("Doktor");

                entity.Property(e => e.DoktorId).HasColumnName("doktorID");

                entity.Property(e => e.Datum)
                    .HasColumnType("datetime")
                    .HasColumnName("datum");

                entity.Property(e => e.KorisnikId).HasColumnName("korisnikID");

                entity.Property(e => e.RadniStaz).HasColumnName("radniStaz");

                entity.Property(e => e.TitulaId).HasColumnName("titulaID");

                entity.Property(e => e.VrstaDoktoraId).HasColumnName("vrstaDoktoraID");

                entity.HasOne(d => d.Korisnik)
                    .WithMany(p => p.Doktors)
                    .HasForeignKey(d => d.KorisnikId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_doktor_korisnik");

                entity.HasOne(d => d.Titula)
                    .WithMany(p => p.Doktors)
                    .HasForeignKey(d => d.TitulaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_doktor_titula");

                entity.HasOne(d => d.VrstaDoktora)
                    .WithMany(p => p.Doktors)
                    .HasForeignKey(d => d.VrstaDoktoraId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_doktor_vrstaDoktora");
            });

            modelBuilder.Entity<Drzava>(entity =>
            {
                entity.ToTable("Drzava");

                entity.HasIndex(e => e.Naziv, "UQ__Drzava__F07241F3895A5BA1")
                    .IsUnique();

                entity.Property(e => e.DrzavaId).HasColumnName("drzavaID");

                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("naziv");
            });

            modelBuilder.Entity<Faktura>(entity =>
            {
                entity.ToTable("Faktura");

                entity.Property(e => e.FakturaId).HasColumnName("fakturaID");

                entity.Property(e => e.DatumIzdavanja)
                    .HasColumnType("datetime")
                    .HasColumnName("datumIzdavanja");

                entity.Property(e => e.NarudzbaId).HasColumnName("narudzbaID");

                entity.Property(e => e.Otkazano).HasColumnName("otkazano");

                entity.Property(e => e.PoslovnicaId).HasColumnName("poslovnicaID");

                entity.Property(e => e.UposlenikId).HasColumnName("uposlenikID");

                entity.HasOne(d => d.Narudzba)
                    .WithMany(p => p.Fakturas)
                    .HasForeignKey(d => d.NarudzbaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_faktura_narudzba");

                entity.HasOne(d => d.Poslovnica)
                    .WithMany(p => p.Fakturas)
                    .HasForeignKey(d => d.PoslovnicaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_faktura_poslovnica");

                entity.HasOne(d => d.Uposlenik)
                    .WithMany(p => p.Fakturas)
                    .HasForeignKey(d => d.UposlenikId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_faktura_uposlenik");
            });

            modelBuilder.Entity<Grad>(entity =>
            {
                entity.ToTable("Grad");

                entity.Property(e => e.GradId).HasColumnName("gradID");

                entity.Property(e => e.DrzavaId).HasColumnName("drzavaID");

                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("naziv");

                entity.Property(e => e.PostanskiBroj)
                    .HasMaxLength(50)
                    .HasColumnName("postanskiBroj");

                entity.HasOne(d => d.Drzava)
                    .WithMany(p => p.Grads)
                    .HasForeignKey(d => d.DrzavaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_drzava");
            });

            modelBuilder.Entity<JedinicaMjere>(entity =>
            {
                entity.ToTable("JedinicaMjere");

                entity.Property(e => e.JedinicaMjereId).HasColumnName("jedinicaMjereID");

                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("naziv");
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

            modelBuilder.Entity<Kupac>(entity =>
            {
                entity.ToTable("Kupac");

                entity.Property(e => e.KupacId).HasColumnName("kupacID");

                entity.Property(e => e.Brojac).HasColumnName("brojac");

                entity.Property(e => e.Datum)
                    .HasColumnType("datetime")
                    .HasColumnName("datum");

                entity.Property(e => e.KorisnikId).HasColumnName("korisnikID");

                entity.HasOne(d => d.Korisnik)
                    .WithMany(p => p.Kupacs)
                    .HasForeignKey(d => d.KorisnikId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_kupac_korisnik");
            });

            modelBuilder.Entity<Ljubimac>(entity =>
            {
                entity.ToTable("Ljubimac");

                entity.Property(e => e.LjubimacId).HasColumnName("ljubimacID");

                entity.Property(e => e.DatumRodjenja)
                    .HasColumnType("date")
                    .HasColumnName("datumRodjenja");

                entity.Property(e => e.Ime)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("ime");

                entity.Property(e => e.RasaZivotinjeId).HasColumnName("rasaZivotinjeID");

                entity.Property(e => e.Starost).HasColumnName("starost");

                entity.Property(e => e.Sterilisan).HasColumnName("sterilisan");

                entity.Property(e => e.TipZivotinjeId).HasColumnName("tipZivotinjeID");

                entity.HasOne(d => d.RasaZivotinje)
                    .WithMany(p => p.Ljubimacs)
                    .HasForeignKey(d => d.RasaZivotinjeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_ljubimac_rasaZivotinje");

                entity.HasOne(d => d.TipZivotinje)
                    .WithMany(p => p.Ljubimacs)
                    .HasForeignKey(d => d.TipZivotinjeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_ljubimac_tipZivotinje");
            });

            modelBuilder.Entity<Lokacija>(entity =>
            {
                entity.ToTable("Lokacija");

                entity.Property(e => e.LokacijaId).HasColumnName("lokacijaID");

                entity.Property(e => e.Adresa)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("adresa");

                entity.Property(e => e.GradId).HasColumnName("gradID");

                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("naziv");

                entity.HasOne(d => d.Grad)
                    .WithMany(p => p.Lokacijas)
                    .HasForeignKey(d => d.GradId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_grad");
            });

            modelBuilder.Entity<Nalaz>(entity =>
            {
                entity.ToTable("Nalaz");

                entity.Property(e => e.NalazId).HasColumnName("nalazID");

                entity.Property(e => e.Opis)
                    .HasMaxLength(150)
                    .HasColumnName("opis");
            });

            modelBuilder.Entity<Narudzba>(entity =>
            {
                entity.ToTable("Narudzba");

                entity.Property(e => e.NarudzbaId).HasColumnName("narudzbaID");

                entity.Property(e => e.Datum)
                    .HasColumnType("datetime")
                    .HasColumnName("datum");

                entity.Property(e => e.KupacId).HasColumnName("kupacID");

                entity.Property(e => e.Otkazano).HasColumnName("otkazano");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.HasOne(d => d.Kupac)
                    .WithMany(p => p.Narudzbas)
                    .HasForeignKey(d => d.KupacId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_narudzba_korisnik");
            });

            modelBuilder.Entity<NarudzbaStavke>(entity =>
            {
                entity.ToTable("NarudzbaStavke");

                entity.Property(e => e.NarudzbaStavkeId).HasColumnName("narudzbaStavkeID");

                entity.Property(e => e.Kolicina).HasColumnName("kolicina");

                entity.Property(e => e.NarudzbaId).HasColumnName("narudzbaID");

                entity.Property(e => e.ProizvodId).HasColumnName("proizvodID");

                entity.HasOne(d => d.Narudzba)
                    .WithMany(p => p.NarudzbaStavkes)
                    .HasForeignKey(d => d.NarudzbaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_narudzbaStavke_narudzba");

                entity.HasOne(d => d.Proizvod)
                    .WithMany(p => p.NarudzbaStavkes)
                    .HasForeignKey(d => d.ProizvodId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_narudzbaStavke_proizvod");
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

            modelBuilder.Entity<Pregled>(entity =>
            {
                entity.ToTable("Pregled");

                entity.Property(e => e.PregledId).HasColumnName("pregledID");

                entity.Property(e => e.DoktorId).HasColumnName("doktorID");

                entity.Property(e => e.NalazId).HasColumnName("nalazID");

                entity.Property(e => e.Opis)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("opis");

                entity.Property(e => e.TerminId).HasColumnName("terminID");

                entity.Property(e => e.Vrijeme)
                    .HasColumnType("datetime")
                    .HasColumnName("vrijeme");

                entity.HasOne(d => d.Doktor)
                    .WithMany(p => p.Pregleds)
                    .HasForeignKey(d => d.DoktorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_pregled_doktor");

                entity.HasOne(d => d.Nalaz)
                    .WithMany(p => p.Pregleds)
                    .HasForeignKey(d => d.NalazId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_pregled_nalaz");

                entity.HasOne(d => d.Termin)
                    .WithMany(p => p.Pregleds)
                    .HasForeignKey(d => d.TerminId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_pregled_termin");
            });

            modelBuilder.Entity<Proizvod>(entity =>
            {
                entity.ToTable("Proizvod");

                entity.Property(e => e.ProizvodId).HasColumnName("proizvodID");

                entity.Property(e => e.Cijena)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("cijena");

                entity.Property(e => e.JedinicaMjereId).HasColumnName("jedinicaMjereID");

                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .HasMaxLength(70)
                    .HasColumnName("naziv");

                entity.Property(e => e.Opis)
                    .HasMaxLength(100)
                    .HasColumnName("opis");

                entity.Property(e => e.ProizvodjacId).HasColumnName("proizvodjacID");

                entity.Property(e => e.Slika).HasColumnName("slika");

                entity.Property(e => e.SlikaThumb).HasColumnName("slikaThumb");

                entity.Property(e => e.Stanje).HasColumnName("stanje");

                entity.Property(e => e.VrstaProizvodaId).HasColumnName("vrstaProizvodaID");

                entity.HasOne(d => d.JedinicaMjere)
                    .WithMany(p => p.Proizvods)
                    .HasForeignKey(d => d.JedinicaMjereId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_proizvod_jedinicaMjere");

                entity.HasOne(d => d.Proizvodjac)
                    .WithMany(p => p.Proizvods)
                    .HasForeignKey(d => d.ProizvodjacId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_proizvod_proizvodjac");

                entity.HasOne(d => d.VrstaProizvoda)
                    .WithMany(p => p.Proizvods)
                    .HasForeignKey(d => d.VrstaProizvodaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_proizvod_vrstaProizvoda");
            });

            modelBuilder.Entity<Proizvodjac>(entity =>
            {
                entity.ToTable("Proizvodjac");

                entity.Property(e => e.ProizvodjacId).HasColumnName("proizvodjacID");

                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("naziv");
            });

            modelBuilder.Entity<RasaZivotinje>(entity =>
            {
                entity.ToTable("RasaZivotinje");

                entity.Property(e => e.RasaZivotinjeId).HasColumnName("rasaZivotinjeID");

                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasColumnName("naziv");
            });

            modelBuilder.Entity<Termin>(entity =>
            {
                entity.ToTable("Termin");

                entity.Property(e => e.TerminId).HasColumnName("terminID");

                entity.Property(e => e.Hitno).HasColumnName("hitno");

                entity.Property(e => e.LjubimacId).HasColumnName("ljubimacID");

                entity.Property(e => e.PoslovnicaId).HasColumnName("poslovnicaID");

                entity.Property(e => e.Vrijeme)
                    .HasColumnType("datetime")
                    .HasColumnName("vrijeme");

                entity.HasOne(d => d.Ljubimac)
                    .WithMany(p => p.Termins)
                    .HasForeignKey(d => d.LjubimacId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_termin_ljubimac");

                entity.HasOne(d => d.Poslovnica)
                    .WithMany(p => p.Termins)
                    .HasForeignKey(d => d.PoslovnicaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_termin_poslovnica");
            });

            modelBuilder.Entity<TipZivotinje>(entity =>
            {
                entity.ToTable("TipZivotinje");

                entity.Property(e => e.TipZivotinjeId).HasColumnName("tipZivotinjeID");

                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("naziv");
            });

            modelBuilder.Entity<Titula>(entity =>
            {
                entity.ToTable("Titula");

                entity.Property(e => e.TitulaId).HasColumnName("titulaID");

                entity.Property(e => e.Naziv)
                    .HasMaxLength(70)
                    .HasColumnName("naziv");
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

                entity.Property(e => e.UposlenikId).HasColumnName("uposlenikID");

                entity.Property(e => e.DatumIzmjene)
                    .HasColumnType("date")
                    .HasColumnName("datumIzmjene");

                entity.Property(e => e.KorisnikId).HasColumnName("korisnikID");

                entity.Property(e => e.PartnerId).HasColumnName("partnerID");

                entity.HasOne(d => d.Korisnik)
                    .WithMany(p => p.Uposleniks)
                    .HasForeignKey(d => d.KorisnikId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_korisnik_uposlenik");

                entity.HasOne(d => d.Partner)
                    .WithMany(p => p.Uposleniks)
                    .HasForeignKey(d => d.PartnerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_partner_uposlenik");
            });

            modelBuilder.Entity<VlasnikZivotinje>(entity =>
            {
                entity.ToTable("VlasnikZivotinje");

                entity.Property(e => e.VlasnikZivotinjeId).HasColumnName("vlasnikZivotinjeID");

                entity.Property(e => e.DatumRegistracije)
                    .HasColumnType("datetime")
                    .HasColumnName("datumRegistracije");

                entity.Property(e => e.KorisnikId).HasColumnName("korisnikID");

                entity.HasOne(d => d.Korisnik)
                    .WithMany(p => p.VlasnikZivotinjes)
                    .HasForeignKey(d => d.KorisnikId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_vlasnikZivotinje_korisnik");
            });

            modelBuilder.Entity<VrstaDoktora>(entity =>
            {
                entity.ToTable("VrstaDoktora");

                entity.Property(e => e.VrstaDoktoraId).HasColumnName("vrstaDoktoraID");

                entity.Property(e => e.Naziv)
                    .HasMaxLength(70)
                    .HasColumnName("naziv");
            });

            modelBuilder.Entity<VrstaPartnera>(entity =>
            {
                entity.ToTable("VrstaPartnera");

                entity.Property(e => e.VrstaPartneraId).HasColumnName("vrstaPartneraID");

                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("naziv");
            });

            modelBuilder.Entity<VrstaProizvodum>(entity =>
            {
                entity.HasKey(e => e.VrstaProizvodaId)
                    .HasName("pk_vrstaProizvoda");

                entity.Property(e => e.VrstaProizvodaId).HasColumnName("vrstaProizvodaID");

                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("naziv");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
