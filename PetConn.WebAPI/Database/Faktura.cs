using System;
using System.Collections.Generic;

#nullable disable

namespace PetConn.WebAPI.Database
{
    public partial class Faktura
    {
        public int FakturaId { get; set; }
        public DateTime DatumIzdavanja { get; set; }
        public int NarudzbaId { get; set; }
        public bool? Otkazano { get; set; }
        public int PoslovnicaId { get; set; }
        public int UposlenikId { get; set; }

        public virtual Narudzba Narudzba { get; set; }
        public virtual Poslovnica Poslovnica { get; set; }
        public virtual Uposlenik Uposlenik { get; set; }
    }
}
