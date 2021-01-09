using System;
using System.Collections.Generic;

#nullable disable

namespace PetConn.WebAPI.Database
{
    public partial class KorisniciUloge
    {
        public int KorisnikUlogaId { get; set; }
        public int KorisnikId { get; set; }
        public int UlogaId { get; set; }
        public DateTime? DatumIzmjene { get; set; }

        public virtual Korisnik Korisnik { get; set; }
        public virtual Uloga Uloga { get; set; }
    }
}
