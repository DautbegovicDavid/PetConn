using System;
using System.Collections.Generic;
using System.Text;

namespace PetConn.Model.Requests
{
    public class GradUpsert
    {
        public int DrzavaId { get; set; }

        public string Naziv { get; set; }
        public string PostanskiBroj { get; set; }
    }
}
