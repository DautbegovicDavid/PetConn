using System;
using System.Collections.Generic;
using System.Text;

namespace PetConn.Model.Requests
{
    public class LjubimacUpsertRequest
    {
        public int LjubimacId { get; set; }
        public string Ime { get; set; }
        public int Starost { get; set; }
        public bool Sterilisan { get; set; }
        public DateTime? DatumRodjenja { get; set; }
        public int TipZivotinjeId { get; set; }
        public int RasaZivotinjeId { get; set; }
    }
}
