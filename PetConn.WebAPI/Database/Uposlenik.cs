using System;
using System.Collections.Generic;

#nullable disable

namespace PetConn.WebAPI.Database
{
    public partial class Uposlenik
    {
        public Uposlenik()
        {
            Fakturas = new HashSet<Faktura>();
        }

        public int UposlenikId { get; set; }
        public int PartnerId { get; set; }
        public int KorisnikId { get; set; }
        public DateTime? DatumIzmjene { get; set; }

        public virtual Korisnik Korisnik { get; set; }
        public virtual Partneri Partner { get; set; }
        public virtual ICollection<Faktura> Fakturas { get; set; }
    }
}
