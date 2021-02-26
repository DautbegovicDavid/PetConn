using PetConn.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetConn.WebAPI.Services
{
    public interface IKorisniciService
    {
        List<Model.Korisnik> Get(KorisnikSearchRequest request);
        Model.Korisnik GetByID(int id);
        Model.Korisnik Update(int id, KorisnikUpsertRequest request);
        Model.Korisnik Insert(KorisnikUpsertRequest request);
        Model.Korisnik Authenticiraj(string user, string pass);
        Model.Korisnik Delete(int id);
        Model.Partner getPartnerID(KorisnikSearchRequest request);
        List<int> getUlogeIDs(int korisnikID);
        int GetID(KorisnikSearchRequest k);
        List<Model.Korisnik> GetKorisniciBezRole();



    }
}
