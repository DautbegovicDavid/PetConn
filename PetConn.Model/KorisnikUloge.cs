using System;
using System.Collections.Generic;
using System.Text;

namespace PetConn.Model
{
    public class KorisnikUloge
    {


        public int KorisnikUlogaId { get; set; }
        public int KorisnikId { get; set; }
        public int UlogaId { get; set; }
        public DateTime? DatumIzmjene { get; set; }

        public virtual Korisnik Korisnik { get; set; }
        public virtual Uloge Uloga { get; set; }



    }
}
