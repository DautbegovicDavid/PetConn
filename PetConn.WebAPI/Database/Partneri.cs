using System;
using System.Collections.Generic;

#nullable disable

namespace PetConn.WebAPI.Database
{
    public partial class Partneri
    {
        public Partneri()
        {
            Poslovnicas = new HashSet<Poslovnica>();
            Uposleniks = new HashSet<Uposlenik>();
        }

        public int PartnerId { get; set; }
        public int VrstaPartneraId { get; set; }
        public string Naziv { get; set; }

        public virtual VrstaPartnera VrstaPartnera { get; set; }
        public virtual ICollection<Poslovnica> Poslovnicas { get; set; }
        public virtual ICollection<Uposlenik> Uposleniks { get; set; }
    }
}
