using AutoMapper;
using PetConn.Model.HelpModels;
using PetConn.Model.Requests;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetConn.WebAPI.Services
{
    public class LokacijaService : BaseCRUDService<Lokacija, LokacijaSearchRequest, LokacijaUpsertRequest, LokacijaUpsertRequest, Database.Lokacija>
    {
        public LokacijaService(IMapper mapper, Database.firstTryContext context) : base(mapper, context)
        {
        }
        public override List<Lokacija> Get(LokacijaSearchRequest request)
        {
            var query = _context.Lokacijas.AsQueryable();
            if (request.GradId != 0)
                query = query.Where(w => w.GradId == request.GradId);
            
            return _mapper.Map<List<Lokacija>>(query.ToList());
        }
    }
}
