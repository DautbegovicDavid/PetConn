using AutoMapper;
using PetConn.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetConn.WebAPI.Services
{
    public class BaseCRUDService<TModel, TSearch, TUpdate, TInsert, TDatabase> : BaseService<TModel, TSearch, TDatabase>,  ICRUDService<TModel, TSearch, TUpdate, TInsert> where TDatabase:class
    {
       
        public BaseCRUDService(IMapper mapper, firstTryContext context) : base(mapper, context)
        {
        }

        public TModel Delete(int id)
        {
            var entity = _context.Set<TDatabase>().Find(id);
            _context.Set<TDatabase>().Remove(entity);
            _context.SaveChanges();
            return _mapper.Map<TModel>(entity);

        }
        public virtual TModel Insert(TInsert request)
        {
            var entity = _mapper.Map<TDatabase>(request);
            _context.Set<TDatabase>().Add(entity);
            _context.SaveChanges();
            return _mapper.Map<TModel>(entity);
        }
        public TModel Update(int id, TUpdate request)
        {
            var entity = _context.Set<TDatabase>().Find(id);
            _context.Set<TDatabase>().Attach(entity);
            _context.Set<TDatabase>().Update(entity);
            _mapper.Map(request, entity);
            _context.SaveChanges();
            return _mapper.Map<TModel>(entity);

        }
    }
}
