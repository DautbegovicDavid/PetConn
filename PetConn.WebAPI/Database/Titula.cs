using System;
using System.Collections.Generic;

#nullable disable

namespace PetConn.WebAPI.Database
{
    public partial class Titula
    {
        public Titula()
        {
            Doktors = new HashSet<Doktor>();
        }

        public int TitulaId { get; set; }
        public string Naziv { get; set; }

        public virtual ICollection<Doktor> Doktors { get; set; }
    }
}
