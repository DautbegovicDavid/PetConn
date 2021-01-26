using System;
using System.Collections.Generic;
using System.Text;

namespace PetConn.Model.Requests
{
    public class PartneriUpsertRequest
    {
        public int PartnerId { get; set; }
        public int VrstaPartneraId { get; set; }
        public string Naziv { get; set; }
    }
}
