using System;
using System.Collections.Generic;

#nullable disable

namespace PetConn.WebAPI.Database
{
    public partial class Uloga
    {
        public Uloga()
        {
            KorisniciUloges = new HashSet<KorisniciUloge>();
        }

        public int UlogaId { get; set; }
        public string Naziv { get; set; }
        public DateTime? DatumIzmjene { get; set; }

        public virtual ICollection<KorisniciUloge> KorisniciUloges { get; set; }
    }
}
