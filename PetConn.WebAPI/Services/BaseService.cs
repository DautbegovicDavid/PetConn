using AutoMapper;
using PetConn.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace PetConn.WebAPI.Services
{
    public class BaseService<TModel, TSearch, TDatabase> : IService<TModel, TSearch> where TDatabase:class
    {
        protected readonly IMapper _mapper;
        protected readonly firstTryContext _context;
        public BaseService(IMapper mapper, firstTryContext context)
        {
            _mapper = mapper;
            _context = context;
        }

        public virtual List<TModel> Get(TSearch request)
        {
            var list = _context.Set<TDatabase>().ToList();
            return _mapper.Map<List<TModel>>(list);
        }

        public TModel GetByID(int id)
        {
            var entity = _context.Set<TDatabase>().Find(id);
            return _mapper.Map<TModel>(entity);
            
        }

       
    }
}
