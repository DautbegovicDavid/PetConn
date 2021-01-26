using PetConn.Model;
using PetConn.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetConn.WebAPI.Services
{
    public interface IVrstaPartneraService
    {
        List<VrstePartnera> Get(object request);
        VrstePartnera GetByID(int id);
        int getByName(VrstaPartnera request);
    }
}
