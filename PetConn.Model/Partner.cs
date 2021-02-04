using System;
using System.Collections.Generic;
using System.Text;

namespace PetConn.Model
{
    public class Partner
    {
        public int PartnerId { get; set; }
        public VrstePartnera VrstaPartnera { get; set; }
        public int VrstaPartneraId { get; set; }
        public string Naziv { get; set; }
        public override string ToString()
        {
            if(VrstaPartnera!=null)// vjvj u apiju ili negdje je vrtio pa nije mogao vratiti
            return VrstaPartnera.Naziv +" _ "+ Naziv+"." ;
            return Naziv;
        }

    }
}
