using AutoMapper;
using PetConn.Model;
using PetConn.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetConn.WebAPI.Services
{
    public class PoslovnicaService : BaseCRUDService<Poslovnica, PoslovnicaSearchRequest, PoslovnicaUpsertRequest, PoslovnicaUpsertRequest, Database.Poslovnica>
    {
        public PoslovnicaService(IMapper mapper, Database.firstTryContext context) : base(mapper, context)
        {
        }
        public override List<Poslovnica> Get(PoslovnicaSearchRequest request)
        {
            
            var list = _context.Poslovnicas.Where(w => w.PartnerId == request.PartnerId).ToList();
            return _mapper.Map<List<Poslovnica>>(list);
        }
    }
}
