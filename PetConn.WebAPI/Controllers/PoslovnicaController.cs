using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PetConn.Model;
using PetConn.Model.Requests;
using PetConn.WebAPI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetConn.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PoslovnicaController : BaseCRUDController<Poslovnica, PoslovnicaSearchRequest, PoslovnicaUpsertRequest, PoslovnicaUpsertRequest>
    {
        
        public PoslovnicaController(ICRUDService<Poslovnica, PoslovnicaSearchRequest, PoslovnicaUpsertRequest, PoslovnicaUpsertRequest> service) : base(service)
        {
            
        }
        
        
    }
}
