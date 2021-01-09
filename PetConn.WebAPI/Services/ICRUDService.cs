using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetConn.WebAPI.Services
{
    public interface ICRUDService<TModel, TSearch,TUpdate,TInsert> : IService<TModel,TSearch>
    {
        TModel Insert(TInsert request);
        TModel Update(int id,TUpdate request);
        TModel Delete(int id);

    }
}
