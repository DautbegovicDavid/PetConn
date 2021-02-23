using System;
using System.Collections.Generic;

#nullable disable

namespace PetConn.WebAPI.Database
{
    public partial class Proizvodjac
    {
        public Proizvodjac()
        {
            Proizvods = new HashSet<Proizvod>();
        }

        public int ProizvodjacId { get; set; }
        public string Naziv { get; set; }

        public virtual ICollection<Proizvod> Proizvods { get; set; }
    }
}
