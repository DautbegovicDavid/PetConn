using System;
using System.Collections.Generic;

#nullable disable

namespace PetConn.WebAPI.Database
{
    public partial class VrstaDoktora
    {
        public VrstaDoktora()
        {
            Doktors = new HashSet<Doktor>();
        }

        public int VrstaDoktoraId { get; set; }
        public string Naziv { get; set; }

        public virtual ICollection<Doktor> Doktors { get; set; }
    }
}
