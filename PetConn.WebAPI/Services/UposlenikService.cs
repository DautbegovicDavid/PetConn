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
    public class UposlenikService : BaseCRUDService<Uposlenik, UposlenikSearchRequest, UposlenikUpsertRequest, UposlenikUpsertRequest, Database.Uposlenik>, IUposlenik<Uposlenik, UposlenikSearchRequest, UposlenikUpsertRequest, UposlenikUpsertRequest>
    {
        public UposlenikService(IMapper mapper, Database.firstTryContext context) : base(mapper, context)
        {
        }
        public  override List<Uposlenik> Get(UposlenikSearchRequest request)
        {
            var query =_context.Uposleniks.Include(i => i.Partner).Include(i => i.Korisnik).AsQueryable();
            if (request.KorisnikId != 0)
                query=query.Where(w => w.KorisnikId == request.KorisnikId);
            query.ToList();
            return _mapper.Map<List<Uposlenik>>(query);
        }
        public List<Uposlenik> GetByRole(int id)
        {
            List<int> listKorisniciUloge = _context.KorisniciUloges.Where(w => w.UlogaId == id).Select(s => s.KorisnikId).ToList(); 
            var query= _context.Uposleniks.Include(i => i.Partner).Include(i => i.Korisnik).AsQueryable();
            query = query.Where(item => listKorisniciUloge.Contains(item.KorisnikId));
            return _mapper.Map<List<Uposlenik>>(query);
                
        }
    }
}
