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
        public virtual ICollection<Uposlenik> Uposleniks { get; set; }
        public virtual ICollection<VlasnikZivotinje> VlasnikZivotinjes { get; set; }
    }
}
