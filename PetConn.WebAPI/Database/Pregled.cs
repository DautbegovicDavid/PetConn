using System;
using System.Collections.Generic;

#nullable disable

namespace PetConn.WebAPI.Database
{
    public partial class Pregled
    {
        public int PregledId { get; set; }
        public DateTime Vrijeme { get; set; }
        public string Opis { get; set; }
        public int TerminId { get; set; }
        public int NalazId { get; set; }
        public int DoktorId { get; set; }

        public virtual Doktor Doktor { get; set; }
        public virtual Nalaz Nalaz { get; set; }
        public virtual Termin Termin { get; set; }
    }
}
