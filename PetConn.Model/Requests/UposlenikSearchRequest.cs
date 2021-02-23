using System;
using System.Collections.Generic;
using System.Text;

namespace PetConn.Model.Requests
{
    public class UposlenikSearchRequest
    {
        public int UposlenikId { get; set; }
        public int PartnerId { get; set; }
        public DateTime? DatumIzmjene { get; set; }       
        public int KorisnikId { get; set; }
    }
}
