using System;
using System.Collections.Generic;

#nullable disable

namespace PetConn.WebAPI.Database
{
    public partial class Prijatelji
    {
        public int KorisnikJedanId { get; set; }
        public int KorisnikDvaId { get; set; }
        public DateTime? Datum { get; set; }

        public virtual Korisnik KorisnikDva { get; set; }
        public virtual Korisnik KorisnikJedan { get; set; }
    }
}
