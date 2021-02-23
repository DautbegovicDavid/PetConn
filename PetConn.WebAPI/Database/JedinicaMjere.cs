using System;
using System.Collections.Generic;

#nullable disable

namespace PetConn.WebAPI.Database
{
    public partial class JedinicaMjere
    {
        public JedinicaMjere()
        {
            Proizvods = new HashSet<Proizvod>();
        }

        public int JedinicaMjereId { get; set; }
        public string Naziv { get; set; }

        public virtual ICollection<Proizvod> Proizvods { get; set; }
    }
}
