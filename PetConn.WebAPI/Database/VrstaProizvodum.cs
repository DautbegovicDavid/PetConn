using System;
using System.Collections.Generic;

#nullable disable

namespace PetConn.WebAPI.Database
{
    public partial class VrstaProizvodum
    {
        public VrstaProizvodum()
        {
            Proizvods = new HashSet<Proizvod>();
        }

        public int VrstaProizvodaId { get; set; }
        public string Naziv { get; set; }

        public virtual ICollection<Proizvod> Proizvods { get; set; }
    }
}
