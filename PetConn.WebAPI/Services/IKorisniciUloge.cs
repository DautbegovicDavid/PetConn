using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetConn.WebAPI.Services
{
    public interface IKorisniciUloge<TModel, TSearch, TUpdate, TInsert> : ICRUDService<TModel,TSearch,TUpdate,TInsert>
    {
        TModel DeleteByKorisnikID(int id);
    }
}
