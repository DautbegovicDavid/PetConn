using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetConn.WebAPI.Services
{
    public interface IService<TModel,TSearch>
    {
        List<TModel> Get(TSearch request);
        TModel GetByID(int id);

    }
}
