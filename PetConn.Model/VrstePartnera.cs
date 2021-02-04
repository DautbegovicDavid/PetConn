using System;
using System.Collections.Generic;
using System.Text;

namespace PetConn.Model
{
    public class VrstePartnera
    {
        public int VrstaPartneraId { get; set; }
        public string Naziv { get; set; }
        public override string ToString()
        {
            return Naziv;
        }
    }
}
