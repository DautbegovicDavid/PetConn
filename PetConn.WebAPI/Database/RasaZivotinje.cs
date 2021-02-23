using System;
using System.Collections.Generic;

#nullable disable

namespace PetConn.WebAPI.Database
{
    public partial class RasaZivotinje
    {
        public RasaZivotinje()
        {
            Ljubimacs = new HashSet<Ljubimac>();
        }

        public int RasaZivotinjeId { get; set; }
        public string Naziv { get; set; }

        public virtual ICollection<Ljubimac> Ljubimacs { get; set; }
    }
}
