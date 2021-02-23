using System;
using System.Collections.Generic;
using System.Text;

namespace PetConn.Model.Requests
{
    public class UposlenikUpsertRequest
    {    
        public int PartnerId { get; set; }
        public int KorisnikId { get; set; }
        public DateTime? DatumIzmjene { get; set; }
       
    }
}
