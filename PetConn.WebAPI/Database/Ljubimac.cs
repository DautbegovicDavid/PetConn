using System;
using System.Collections.Generic;

#nullable disable

namespace PetConn.WebAPI.Database
{
    public partial class Ljubimac
    {
        public Ljubimac()
        {
            Termins = new HashSet<Termin>();
        }

        public int LjubimacId { get; set; }
        public string Ime { get; set; }
        public int Starost { get; set; }
        public bool Sterilisan { get; set; }
        public DateTime? DatumRodjenja { get; set; }
        public int TipZivotinjeId { get; set; }
        public int RasaZivotinjeId { get; set; }

        public virtual RasaZivotinje RasaZivotinje { get; set; }
        public virtual TipZivotinje TipZivotinje { get; set; }
        public virtual ICollection<Termin> Termins { get; set; }
    }
}
