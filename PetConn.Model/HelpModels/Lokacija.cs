﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PetConn.Model.HelpModels
{
    public class Lokacija
    {
        public int LokacijaId { get; set; }
        public int GradId { get; set; }
        public string Naziv { get; set; }
        public string Adresa { get; set; }
    }
}
