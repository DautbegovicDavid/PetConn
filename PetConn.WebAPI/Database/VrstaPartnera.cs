using System;
using System.Collections.Generic;

#nullable disable

namespace PetConn.WebAPI.Database
{
    public partial class VrstaPartnera
    {
        public VrstaPartnera()
        {
            Partneris = new HashSet<Partneri>();
        }

        public int VrstaPartneraId { get; set; }
        public string Naziv { get; set; }

        public virtual ICollection<Partneri> Partneris { get; set; }
    }
}
