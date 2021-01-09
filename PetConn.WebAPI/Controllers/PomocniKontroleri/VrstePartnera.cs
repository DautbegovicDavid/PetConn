using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PetConn.WebAPI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetConn.WebAPI.Controllers.PomocniKontroleri
{

    public class VrstePartnera : BaseController<Model.VrstePartnera, object>
    {
        public VrstePartnera(IService<Model.VrstePartnera, object> service) : base(service)
        {
        }
    }
}
