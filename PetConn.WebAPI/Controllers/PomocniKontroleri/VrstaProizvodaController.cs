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
    public class VrstaProizvodaController : BaseCRUDController<VrstaProizvoda, object, VrstaProizvodaUpsertRequest, VrstaProizvodaUpsertRequest>
    {
        public VrstaProizvodaController(ICRUDService<VrstaProizvoda, object, VrstaProizvodaUpsertRequest, VrstaProizvodaUpsertRequest> service) : base(service)
        {
        }
    }
}
