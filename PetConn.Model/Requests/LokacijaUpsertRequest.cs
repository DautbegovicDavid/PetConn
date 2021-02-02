using System;
using System.Collections.Generic;
using System.Text;

namespace PetConn.Model.Requests
{
    public class LokacijaUpsertRequest
    {
        
        public int GradId { get; set; }
        public string Naziv { get; set; }
        public string Adresa { get; set; }
    }
}
