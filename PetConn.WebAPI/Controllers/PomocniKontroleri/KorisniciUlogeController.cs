using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PetConn.Model;
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
    public class KorisniciUlogeController : BaseCRUDController<KorisniciUloge, KorisniciUlogeSearchRequest, KorisniciUlogeUpsertRequest, KorisniciUlogeUpsertRequest>
    {
        IKorisniciUloge<KorisniciUloge, KorisniciUlogeSearchRequest, KorisniciUlogeUpsertRequest, KorisniciUlogeUpsertRequest> _service;
        public KorisniciUlogeController(IKorisniciUloge<KorisniciUloge, KorisniciUlogeSearchRequest, KorisniciUlogeUpsertRequest, KorisniciUlogeUpsertRequest> service) : base(service)
        {
            _service = service;
        }
        
        [HttpDelete("byKorisnikID/{id}")]
        public KorisniciUloge deleteByKorID(int id)
        {
            return _service.DeleteByKorisnikID(id);
        }
        
    }
}
