using System;
using System.Collections.Generic;

#nullable disable

namespace PetConn.WebAPI.Database
{
    public partial class Korisnik
    {
        public Korisnik()
        {
            Doktors = new HashSet<Doktor>();
            KorisniciUloges = new HashSet<KorisniciUloge>();
            Kupacs = new HashSet<Kupac>();
            PorukaPosiljalacs = new HashSet<Poruka>();
            PorukaPrimalacs = new HashSet<Poruka>();
            PrijateljiKorisnikDvas = new HashSet<Prijatelji>();
            PrijateljiKorisnikJedans = new HashSet<Prijatelji>();
            Uposleniks = new HashSet<Uposlenik>();
            VlasnikZivotinjes = new HashSet<VlasnikZivotinje>();
        }

        public int KorisnikId { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Email { get; set; }
        public string KorisnickoIme { get; set; }
        public string Telefon { get; set; }
        public string LozinkaHash { get; set; }
        public string LozinkaSalt { get; set; }

        public virtual ICollection<Doktor> Doktors { get; set; }
        public virtual ICollection<KorisniciUloge> KorisniciUloges { get; set; }
        public virtual ICollection<Kupac> Kupacs { get; set; }
        public virtual ICollection<Poruka> PorukaPosiljalacs { get; set; }
        public virtual ICollection<Poruka> PorukaPrimalacs { get; set; }
        public virtual ICollection<Prijatelji> PrijateljiKorisnikDvas { get; set; }
        public virtual ICollection<Prijatelji> PrijateljiKorisnikJedans { get; set; }
        public virtual ICollection<Uposlenik> Uposleniks { get; set; }
        public virtual ICollection<VlasnikZivotinje> VlasnikZivotinjes { get; set; }
    }
}
