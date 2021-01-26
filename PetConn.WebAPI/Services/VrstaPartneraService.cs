using AutoMapper;
using PetConn.Model;
using PetConn.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetConn.WebAPI.Services
{
    public class VrstaPartneraService : IVrstaPartneraService
    {
        protected readonly IMapper _mapper;
        protected readonly firstTryContext _context;
        public VrstaPartneraService(IMapper mapper, firstTryContext context)
        {
            _mapper = mapper;
            _context = context;
        }
        public List<VrstePartnera> Get(object request)
        {
            var list = _context.VrstaPartneras.ToList();
            return _mapper.Map<List<VrstePartnera>>(list);
        }

        public VrstePartnera GetByID(int id)
        {
            var entity = _context.VrstaPartneras.Find(id);
            return _mapper.Map<VrstePartnera>(entity);
        }

        public int getByName(Model.Requests.VrstaPartnera request)
        {
            var entity = _context.VrstaPartneras.Where(w => w.Naziv == request.Naziv).FirstOrDefault();
            if(entity!=null)
            return entity.VrstaPartneraId;
            return 0;
        }

    }
}
