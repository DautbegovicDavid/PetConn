using System;
using System.Collections.Generic;

#nullable disable

namespace PetConn.WebAPI.Database
{
    public partial class Uposlenik
    {
        public int UposlenikId { get; set; }
        public int PartnerId { get; set; }
        public DateTime? DatumIzmjene { get; set; }

        public virtual Partneri Partner { get; set; }
        public virtual Korisnik UposlenikNavigation { get; set; }
    }
}
