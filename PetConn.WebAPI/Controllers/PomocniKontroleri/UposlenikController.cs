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

    public class UposlenikController : BaseCRUDController<Uposlenik, UposlenikSearchRequest, UposlenikUpsertRequest, UposlenikUpsertRequest>
    {
        IUposlenik<Uposlenik, UposlenikSearchRequest, UposlenikUpsertRequest, UposlenikUpsertRequest> _service;
        public UposlenikController(IUposlenik<Uposlenik, UposlenikSearchRequest, UposlenikUpsertRequest, UposlenikUpsertRequest> service) : base(service)
        {
            _service = service;
        }
        [HttpGet("getByRoles/{id}")]
        
        public List<Uposlenik> GetByRole(int id)
        {
            return _service.GetByRole(id);

        }


    }
}
