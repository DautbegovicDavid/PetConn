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
    public class KorisniciController : ControllerBase
    {
        private readonly IKorisniciService _service;
        public KorisniciController(IKorisniciService service)
        {
            _service = service;
        }

        [HttpPost]
        public Korisnik Insert(KorisnikUpsertRequest request)
        {
            return _service.Insert(request);
        }

        [HttpPut("{id}")]
        public Korisnik Update(int id, [FromBody] KorisnikUpsertRequest request)//zasto from body
        {
            return _service.Update(id, request);
        }

        [HttpDelete("{id}")]
        public Korisnik Delete(int id)//zasto from body
        {
            return _service.Delete(id);
        }
        [HttpGet]
        public List<Korisnik> get([FromQuery]KorisnikSearchRequest request)
        {
            return _service.Get(request);
        }
        [HttpGet("partner")]
        public Partner getpartnerID([FromQuery]KorisnikSearchRequest request)
        {
            return _service.getPartnerID(request);
        }



    }
}
