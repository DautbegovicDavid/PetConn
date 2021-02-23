using System;
using System.Collections.Generic;

#nullable disable

namespace PetConn.WebAPI.Database
{
    public partial class Kupac
    {
        public Kupac()
        {
            Narudzbas = new HashSet<Narudzba>();
        }

        public int KupacId { get; set; }
        public int KorisnikId { get; set; }
        public DateTime Datum { get; set; }
        public int? Brojac { get; set; }

        public virtual Korisnik Korisnik { get; set; }
        public virtual ICollection<Narudzba> Narudzbas { get; set; }
    }
}
