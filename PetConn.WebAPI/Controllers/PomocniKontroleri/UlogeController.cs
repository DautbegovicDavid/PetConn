using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PetConn.Model;
using PetConn.WebAPI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetConn.WebAPI.Controllers.PomocniKontroleri
{

    public class UlogeController : BaseController<Uloge, object>
    {
        public UlogeController(IService<Uloge, object> service) : base(service)
        {
        }
    }
}
