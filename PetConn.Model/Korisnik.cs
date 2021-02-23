using System;
using System.Collections.Generic;
using System.Text;

namespace PetConn.Model
{
    public class Korisnik
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Email { get; set; }
        public string KorisnickoIme { get; set; }
        public string Telefon { get; set; }
        public virtual ICollection<KorisnikUloge> KorisniciUloges { get; set; }
        public override string ToString()
        {
            return Ime + " " + Prezime + " " + KorisnickoIme;
        }




    }
}
