using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PetConn.Model.HelpModels;
using PetConn.Model.Requests;

using PetConn.WebAPI.Services;

namespace PetConn.WebAPI.Controllers
{

    public class DrzavaController : BaseCRUDController<Drzava, DrzavaUpsert, DrzavaUpsert, DrzavaUpsert>
    {
        public DrzavaController(ICRUDService<Drzava, DrzavaUpsert, DrzavaUpsert, DrzavaUpsert> service) : base(service)
        {
        }
    }
}
