using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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
    public class VrstePartnera : ControllerBase
    {

        private readonly IVrstaPartneraService _service;
        public VrstePartnera(IVrstaPartneraService service)
        {
            _service = service;           
        }
        [HttpGet]
        public List<Model.VrstePartnera> Get([FromQuery] object request)
        {
            return _service.Get(request);
        }
        //[Authorize(Roles = "Menadzer")]
        [HttpGet("{id}")]
        public Model.VrstePartnera GetByID(int id)
        {
            return _service.GetByID(id);
        }
        [Route("byName")]
        [HttpGet]
        public int GetByName([FromQuery] VrstaPartnera request)
        {
            return _service.getByName(request);
        }

    }
}
