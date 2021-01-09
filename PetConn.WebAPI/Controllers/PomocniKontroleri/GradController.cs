using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using PetConn.Model.Requests;
using PetConn.Model.HelpModels;
using PetConn.WebAPI.Services;

namespace PetConn.WebAPI.Controllers.PomocniKontroleri
{
    [Route("api/[controller]")]
    [ApiController]
    public class GradController : BaseCRUDController<Grad, GradUpsert, GradUpsert, GradUpsert>
    {
        public GradController(ICRUDService<Grad, GradUpsert, GradUpsert, GradUpsert> service) : base(service)
        {
        }
    }
}
