using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PetConn.WebAPI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetConn.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize]
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
        //[Authorize(Roles = "Menadzer")]



        
        [HttpGet("{id}")]
        public TModel GetByID(int id)
        {
            return _service.GetByID(id);
        }
         
    }
}
