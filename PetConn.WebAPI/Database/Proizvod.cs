using System;
using System.Collections.Generic;

#nullable disable

namespace PetConn.WebAPI.Database
{
    public partial class Proizvod
    {
        public Proizvod()
        {
            NarudzbaStavkes = new HashSet<NarudzbaStavke>();
        }

        public int ProizvodId { get; set; }
        public string Naziv { get; set; }
        public decimal Cijena { get; set; }
        public string Opis { get; set; }
        public bool? Stanje { get; set; }
        public byte[] Slika { get; set; }
        public byte[] SlikaThumb { get; set; }
        public int VrstaProizvodaId { get; set; }
        public int JedinicaMjereId { get; set; }
        public int ProizvodjacId { get; set; }

        public virtual JedinicaMjere JedinicaMjere { get; set; }
        public virtual Proizvodjac Proizvodjac { get; set; }
        public virtual VrstaProizvodum VrstaProizvoda { get; set; }
        public virtual ICollection<NarudzbaStavke> NarudzbaStavkes { get; set; }
    }
}
