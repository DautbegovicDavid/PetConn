using System;
using System.Collections.Generic;
using System.Text;

namespace PetConn.Model.Requests
{
    public class KorisnikChangePass
    {       
        public string KorisnickoIme { get; set; }       
        public string pass { get; set; }
        public string NoviPass{ get; set; }
    }
}
