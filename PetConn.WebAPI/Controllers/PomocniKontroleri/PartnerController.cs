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
    
    public class PartnerController : BaseCRUDController<Partner, PartneriSearchRequest, PartneriUpsertRequest, PartneriUpsertRequest>
    {

        IPartneri<Partner, PartneriSearchRequest, PartneriUpsertRequest, PartneriUpsertRequest> _service;


        public PartnerController(IPartneri<Partner, PartneriSearchRequest, PartneriUpsertRequest, PartneriUpsertRequest> service) : base(service)
        {
            _service = service;
        }
        [Route("IDsByVrstaPartneraID")]        
        [HttpGet]
        public List<int> getIDsByVrstaPartneraID([FromQuery] PartneriSearchRequest request)
        {
            
                return _service.getIDsByVrstaPartneraID(request);
        }
        



    }
}
