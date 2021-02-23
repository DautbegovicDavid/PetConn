using System;
using System.Collections.Generic;

#nullable disable

namespace PetConn.WebAPI.Database
{
    public partial class Narudzba
    {
        public Narudzba()
        {
            Fakturas = new HashSet<Faktura>();
            NarudzbaStavkes = new HashSet<NarudzbaStavke>();
        }

        public int NarudzbaId { get; set; }
        public int KupacId { get; set; }
        public DateTime Datum { get; set; }
        public bool Status { get; set; }
        public bool? Otkazano { get; set; }

        public virtual Kupac Kupac { get; set; }
        public virtual ICollection<Faktura> Fakturas { get; set; }
        public virtual ICollection<NarudzbaStavke> NarudzbaStavkes { get; set; }
    }
}
