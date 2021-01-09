using System;
using System.Collections.Generic;

#nullable disable

namespace PetConn.WebAPI.Database
{
    public partial class Poslovnica
    {
        public int PoslovnicaId { get; set; }
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

        public virtual Lokacija Lokacija { get; set; }
        public virtual Partneri Partner { get; set; }
    }
}
