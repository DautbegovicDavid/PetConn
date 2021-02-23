using System;
using System.Collections.Generic;
using System.Text;

namespace PetConn.Model
{
    public class Uposlenik
    {
        public int UposlenikId { get; set; }
        public int PartnerId { get; set; }
        public DateTime? DatumIzmjene { get; set; }
        public virtual Korisnik Korisnik { get; set; }
        public virtual Partner Partner { get; set; }
        public int KorisnikId { get; set; }


    }
}
