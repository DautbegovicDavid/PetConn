using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PetConn.Model.HelpModels;
using PetConn.Model.Requests;
using PetConn.WebAPI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetConn.WebAPI.Controllers.PomocniKontroleri
{
    
    public class LokacijaController : BaseCRUDController<Lokacija, LokacijaSearchRequest, LokacijaUpsertRequest, LokacijaUpsertRequest>
    {
        public LokacijaController(ICRUDService<Lokacija, LokacijaSearchRequest, LokacijaUpsertRequest, LokacijaUpsertRequest> service) : base(service)
        {
        }
        
    }
}
