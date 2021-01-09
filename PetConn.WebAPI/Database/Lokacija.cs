using System;
using System.Collections.Generic;

#nullable disable

namespace PetConn.WebAPI.Database
{
    public partial class Lokacija
    {
        public Lokacija()
        {
            Poslovnicas = new HashSet<Poslovnica>();
        }

        public int LokacijaId { get; set; }
        public int GradId { get; set; }
        public string Naziv { get; set; }
        public string Adresa { get; set; }

        public virtual Grad Grad { get; set; }
        public virtual ICollection<Poslovnica> Poslovnicas { get; set; }
    }
}
