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
   
    public class LjubimacController : BaseCRUDController<Ljubimac, object, LjubimacUpsertRequest, LjubimacUpsertRequest>
    {
        public LjubimacController(ICRUDService<Ljubimac, object, LjubimacUpsertRequest, LjubimacUpsertRequest> service) : base(service)
        {
        }
    }
}
