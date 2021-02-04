using AutoMapper;
using Microsoft.EntityFrameworkCore;
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
            var query = _context.Poslovnicas.Include(i=>i.Partner.VrstaPartnera).AsQueryable();
            if (request.LokacijaId != 0 && request.PartnerId != 0)
                query = query.Where(w => w.LokacijaId == request.LokacijaId && w.PartnerId == request.PartnerId);
            if (request.LokacijaId != 0)
                query=query.Where(w =>  w.LokacijaId == request.LokacijaId);
            if (request.PartnerId != 0)
                query=query.Where(w=>w.PartnerId == request.PartnerId);
            var list = query.ToList();   
                //var list = _context.Poslovnicas.Where(w => w.PartnerId == request.PartnerId && w.LokacijaId==request.LokacijaId).ToList();
            return _mapper.Map<List<Poslovnica>>(list);
        }
    }
}
