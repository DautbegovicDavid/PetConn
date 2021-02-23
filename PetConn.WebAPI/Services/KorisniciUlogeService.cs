using AutoMapper;
using PetConn.Model;
using PetConn.Model.Requests;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetConn.WebAPI.Services
{
    public class KorisniciUlogeService : BaseCRUDService<KorisniciUloge, KorisniciUlogeSearchRequest, KorisniciUlogeUpsertRequest, KorisniciUlogeUpsertRequest, Database.KorisniciUloge>
    {
        public KorisniciUlogeService(IMapper mapper, Database.firstTryContext context) : base(mapper, context)
        {
        }
        public override List<KorisniciUloge> Get(KorisniciUlogeSearchRequest request)
        {
            var query = _context.KorisniciUloges.AsQueryable();
            if (request.KorisnikId != 0)
                query = query.Where(w => w.KorisnikId == request.KorisnikId);
            if (request.UlogaId != 0)
                query = query.Where(w => w.UlogaId == request.UlogaId);
            query.ToList();
            return _mapper.Map<List<KorisniciUloge>>(query);
            
        }
    }
}
