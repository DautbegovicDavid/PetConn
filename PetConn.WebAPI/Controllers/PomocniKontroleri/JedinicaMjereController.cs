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
    [Route("api/[controller]")]
    [ApiController]
    public class JedinicaMjereController : BaseCRUDController<JedinicaMjere, object, JedinicaMjereUpsertRequest, JedinicaMjereUpsertRequest>
    {
        public JedinicaMjereController(ICRUDService<JedinicaMjere, object, JedinicaMjereUpsertRequest, JedinicaMjereUpsertRequest> service) : base(service)
        {
        }
    }
}
