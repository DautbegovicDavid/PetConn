using PetConn.Model;
using PetConn.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetConn.WebAPI.Services
{
    public interface IUposlenik<TModel, TSearch, TUpdate, TInsert> : ICRUDService<TModel, TSearch, TUpdate, TInsert>
    {
        List<TModel> GetByRole(int id);
        //Uposlenik GetByKorisnikID(int id);

    }
}
