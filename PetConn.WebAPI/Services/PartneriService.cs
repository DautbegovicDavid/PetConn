﻿    using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PetConn.Model;
using PetConn.Model.Requests;
using PetConn.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetConn.WebAPI.Services
{
    public class PartneriService: BaseCRUDService<Partner,PartneriSearchRequest, PartneriUpsertRequest, PartneriUpsertRequest,Partneri>, IPartneri<Partner, PartneriSearchRequest, PartneriUpsertRequest, PartneriUpsertRequest>
    {
        public PartneriService(IMapper mapper, firstTryContext context) : base(mapper, context)
        {
        }

        public List<int> getIDsByVrstaPartneraID(PartneriSearchRequest request)
        {
            List<int> IDs = _context.Partneris.Where(w => w.VrstaPartneraId == request.VrstaPartneraId).Select(s => s.PartnerId).ToList();
            if (IDs.Count == 0)
                IDs.Add(-1);

            return IDs;
        }
        public override List<Partner> Get([FromQuery]PartneriSearchRequest request)
        {
            var query = _context.Partneris.Include(i=>i.VrstaPartnera).AsQueryable();

            if (request.VrstaPartneraId != 0 && request.PartnerId==0)
                query = query.Where(w => w.VrstaPartneraId == request.VrstaPartneraId);
            if (request.VrstaPartneraId == 0 && request.PartnerId != 0)
                query = query.Where(w => w.PartnerId == request.PartnerId);

            return _mapper.Map<List<Partner>>(query.ToList());     
        }

    }
}
