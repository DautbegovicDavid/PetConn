using System;
using System.Collections.Generic;
using System.Text;

namespace PetConn.Model.Requests
{
    public class PartneriSearchRequest
    {
        public int PartnerId { get; set; }
        public int VrstaPartneraId { get; set; }
        public string Naziv { get; set; }
    }
}
