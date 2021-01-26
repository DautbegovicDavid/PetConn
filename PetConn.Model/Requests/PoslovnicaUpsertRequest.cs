using System;
using System.Collections.Generic;
using System.Text;

namespace PetConn.Model.Requests
{
    public class PoslovnicaUpsertRequest
    {
        public int LokacijaId { get; set; }
        public int PartnerId { get; set; }
        public TimeSpan? RadnoVrijemeOd { get; set; }
        public TimeSpan? RadnoVrijemeDo { get; set; }
        public string Naziv { get; set; }
        public string Email { get; set; }
        public string Telefon { get; set; }
        public byte[] Slika { get; set; }
        public byte[] SlikaThumb { get; set; }
        public bool? Otvoreno { get; set; }
    }
}
