using System;
using System.Collections.Generic;
using System.Text;

namespace PetConn.Model.Requests
{
    public class PoslovnicaSearchRequest
    {
        public int LokacijaId { get; set; }
        public int PartnerId { get; set; }
       
        public string Naziv { get; set; }
        public string Email { get; set; }
        public string Telefon { get; set; }
        public byte[] Slika { get; set; }
        public byte[] SlikaThumb { get; set; }
        public bool? Otvoreno { get; set; }
    }
}
