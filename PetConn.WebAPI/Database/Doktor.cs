using System;
using System.Collections.Generic;

#nullable disable

namespace PetConn.WebAPI.Database
{
    public partial class Doktor
    {
        public Doktor()
        {
            Pregleds = new HashSet<Pregled>();
        }

        public int DoktorId { get; set; }
        public int KorisnikId { get; set; }
        public DateTime? Datum { get; set; }
        public int RadniStaz { get; set; }
        public int VrstaDoktoraId { get; set; }
        public int TitulaId { get; set; }

        public virtual Korisnik Korisnik { get; set; }
        public virtual Titula Titula { get; set; }
        public virtual VrstaDoktora VrstaDoktora { get; set; }
        public virtual ICollection<Pregled> Pregleds { get; set; }
    }
}
