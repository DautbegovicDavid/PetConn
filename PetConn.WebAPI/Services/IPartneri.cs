using PetConn.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetConn.WebAPI.Services
{
    public interface IPartneri<TModel, TSearch, TUpdate, TInsert> : ICRUDService<TModel,TSearch,TUpdate,TInsert>
    {
        List<int> getIDsByVrstaPartneraID(TSearch request);
    }
}
