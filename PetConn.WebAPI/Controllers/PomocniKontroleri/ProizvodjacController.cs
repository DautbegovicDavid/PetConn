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
    public class ProizvodjacController : BaseCRUDController<Proizvodjac, object, ProizvodjacUpsertRequest, ProizvodjacUpsertRequest>
    {
        public ProizvodjacController(ICRUDService<Proizvodjac, object, ProizvodjacUpsertRequest, ProizvodjacUpsertRequest> service) : base(service)
        {
        }
    }
}
