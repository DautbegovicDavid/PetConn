using System;
using System.Collections.Generic;

#nullable disable

namespace PetConn.WebAPI.Database
{
    public partial class Poruka
    {
        public int PorukaId { get; set; }
        public int PosiljalacId { get; set; }
        public int PrimalacId { get; set; }
        public string Sadrzaj { get; set; }
        public DateTime Datum { get; set; }

        public virtual Korisnik Posiljalac { get; set; }
        public virtual Korisnik Primalac { get; set; }
    }
}
