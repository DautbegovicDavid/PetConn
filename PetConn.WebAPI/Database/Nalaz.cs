using System;
using System.Collections.Generic;

#nullable disable

namespace PetConn.WebAPI.Database
{
    public partial class Nalaz
    {
        public Nalaz()
        {
            Pregleds = new HashSet<Pregled>();
        }

        public int NalazId { get; set; }
        public string Opis { get; set; }

        public virtual ICollection<Pregled> Pregleds { get; set; }
    }
}
