using System;
using System.Collections.Generic;

#nullable disable

namespace PetConn.WebAPI.Database
{
    public partial class NarudzbaStavke
    {
        public int NarudzbaStavkeId { get; set; }
        public int NarudzbaId { get; set; }
        public int ProizvodId { get; set; }
        public int Kolicina { get; set; }

        public virtual Narudzba Narudzba { get; set; }
        public virtual Proizvod Proizvod { get; set; }
    }
}
