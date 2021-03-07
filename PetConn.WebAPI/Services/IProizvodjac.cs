using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetConn.WebAPI.Services
{
    interface IProizvodjac<TModel, TSearch, TUpdate, TInsert> : ICRUDService<TModel,TSearch,TUpdate,TInsert>
    {
    }
}
