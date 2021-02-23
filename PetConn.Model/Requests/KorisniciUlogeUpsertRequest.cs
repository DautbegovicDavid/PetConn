using System;
using System.Collections.Generic;
using System.Text;

namespace PetConn.Model.Requests
{
    public class KorisniciUlogeUpsertRequest
    {        
        public int KorisnikId { get; set; }
        public int UlogaId { get; set; }
        public DateTime? DatumIzmjene { get; set; }       
    }
}
