using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PetConn.WebAPI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetConn.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaseCRUDController<TModel, TSearch, TUpdate, TInsert> : BaseController<TModel, TSearch>
    {
        protected readonly ICRUDService<TModel, TSearch, TUpdate, TInsert> _service;
        public BaseCRUDController(ICRUDService<TModel, TSearch,TUpdate,TInsert> service) : base(service)
        {
            _service = service;
        }
        [HttpPost]
        public TModel Insert(TInsert request)
        {
            return _service.Insert(request);
        }
        [HttpPut("{id}")]
        public TModel Update(int id,[FromBody]TUpdate request)
        {
            return _service.Update(id,request);
        }
        [HttpDelete("{id}")]
        public TModel Delete(int id)
        {
            return _service.Delete(id);
        }
    }
}
