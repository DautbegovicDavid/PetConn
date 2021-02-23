using System;
using System.Collections.Generic;

#nullable disable

namespace PetConn.WebAPI.Database
{
    public partial class Termin
    {
        public Termin()
        {
            Pregleds = new HashSet<Pregled>();
        }

        public int TerminId { get; set; }
        public DateTime Vrijeme { get; set; }
        public int LjubimacId { get; set; }
        public int PoslovnicaId { get; set; }
        public bool? Hitno { get; set; }

        public virtual Ljubimac Ljubimac { get; set; }
        public virtual Poslovnica Poslovnica { get; set; }
        public virtual ICollection<Pregled> Pregleds { get; set; }
    }
}
