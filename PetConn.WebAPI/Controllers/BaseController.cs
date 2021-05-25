using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PetConn.WebAPI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Threading.Tasks;

namespace PetConn.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
#if ProducesConsumes
    [Produces(MediaTypeNames.Application.Json)]
    [Consumes(MediaTypeNames.Application.Json)]
#endif


    public class BaseController<TModel, TSearch> : ControllerBase
    {
        private readonly IService<TModel,TSearch> _service;
        public BaseController(IService<TModel, TSearch> service)
        {
            _service = service;
        }
        [HttpGet]
        public  List<TModel> Get([FromQuery]TSearch request)
        {
            return  _service.Get(request);
        }
        [Authorize(Roles = "Admin,Uposlenik")]
        [HttpGet("{id}")]
        public Task<ActionResult<TModel>> GetByID(int id)
        {
            var product = _service.GetByID(id);
            ActionResult<TModel> result= NotFound();

            if(product!=null)
            {
                result = Ok(product);
            }
            return Task.FromResult(result); //_service.GetByID(id);
        }
         
    }
}
