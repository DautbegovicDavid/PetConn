using System;
using System.Collections.Generic;

#nullable disable

namespace PetConn.WebAPI.Database
{
    public partial class TipZivotinje
    {
        public TipZivotinje()
        {
            Ljubimacs = new HashSet<Ljubimac>();
        }

        public int TipZivotinjeId { get; set; }
        public string Naziv { get; set; }

        public virtual ICollection<Ljubimac> Ljubimacs { get; set; }
    }
}
