using System;
using System.Collections.Generic;

#nullable disable

namespace PetConn.WebAPI.Database
{
    public partial class VlasnikZivotinje
    {
        public int VlasnikZivotinjeId { get; set; }
        public int KorisnikId { get; set; }
        public DateTime? DatumRegistracije { get; set; }

        public virtual Korisnik Korisnik { get; set; }
    }
}
