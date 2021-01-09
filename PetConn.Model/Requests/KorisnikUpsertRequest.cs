using System;
using System.Collections.Generic;
using System.Text;

namespace PetConn.Model.Requests
{
    public class KorisnikUpsertRequest
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Email { get; set; }
        public string KorisnickoIme { get; set; }
        public string Telefon { get; set; }
        public string Password { get; set; }
        public string PasswordConfirmation { get; set; }

    }
}
