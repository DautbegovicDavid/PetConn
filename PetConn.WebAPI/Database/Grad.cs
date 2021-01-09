using System;
using System.Collections.Generic;

#nullable disable

namespace PetConn.WebAPI.Database
{
    public partial class Grad
    {
        public Grad()
        {
            Lokacijas = new HashSet<Lokacija>();
        }

        public int GradId { get; set; }
        public int DrzavaId { get; set; }
        public string Naziv { get; set; }
        public string PostanskiBroj { get; set; }

        public virtual Drzava Drzava { get; set; }
        public virtual ICollection<Lokacija> Lokacijas { get; set; }
    }
}
