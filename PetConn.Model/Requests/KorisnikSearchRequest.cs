using System;
using System.Collections.Generic;
using System.Text;

namespace PetConn.Model.Requests
{
    public class KorisnikSearchRequest
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string KorisnickoIme { get; set; }
        public int? UlogaId { get; set; }
        public int? VrstaPartneraId { get; set; }


    }
}
