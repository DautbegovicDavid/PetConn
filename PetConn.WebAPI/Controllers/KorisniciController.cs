using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PetConn.Model;
using PetConn.Model.Requests;
using PetConn.WebAPI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetConn.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KorisniciController : ControllerBase
    {
        private readonly IKorisniciService _service;
        public KorisniciController(IKorisniciService service)
        {
            _service = service;
            
        }

        [HttpPost]
        public Korisnik Insert(KorisnikUpsertRequest request)
        {
            return _service.Insert(request);
        }
        [HttpGet("{id}")]
        public Task<ActionResult<Korisnik>> GetByID(int id)
        {
            var korisnik = _service.GetByID(id);
            ActionResult<Korisnik> result = NotFound();

            if (korisnik != null)
            {
                result = Ok(korisnik);
            }
            return Task.FromResult(result); //_service.GetByID(id);
        }
        [HttpPut("{id}")]
        public Korisnik Update(int id, [FromBody] KorisnikUpsertRequest request)//zasto from body
        {
            return _service.Update(id, request);
        }

        [HttpDelete("{id}")]
        public Korisnik Delete(int id)//zasto from body
        {
            return _service.Delete(id);
        }
        [HttpGet]
        public List<Korisnik> get([FromQuery]KorisnikSearchRequest request)
        {
            return _service.Get(request);
        }
        [HttpPut("changePass")]
        public bool ChangePass([FromBody] KorisnikChangePass request)
        {
            return _service.ChangePass(request);
        }
        [HttpGet("korisniciBezRole")]

        public List<Korisnik> getKorisniciBezRole()
        {
            return _service.GetKorisniciBezRole();
        }
        [HttpGet("partner")]
        public Partner getpartnerID([FromQuery]KorisnikSearchRequest request)
        {
            return _service.getPartnerID(request);
        }
        [HttpGet("uloga")]
        public Partner getUloga([FromQuery] KorisnikSearchRequest request)
        {
            return _service.getPartnerID(request);
        }
        [HttpGet("getCredentials")]
        public string getCR()
        {
            string authHeader = HttpContext.Request.Headers["Authorization"];

            if(authHeader!=null && authHeader.StartsWith("Basic"))
            {
                Encoding encoding = Encoding.GetEncoding("iso-8859-1");

                var encodedUsernamePassword = authHeader.Substring("Basic ".Length).Trim();
                string usernamePassword = encoding.GetString(Convert.FromBase64String(encodedUsernamePassword));
                int separatorIndex = usernamePassword.IndexOf(":");
                string userName = usernamePassword.Substring(0, separatorIndex);
                string password = usernamePassword.Substring(separatorIndex + 1);


                return new string("Succes");
            }
            else
            {
                throw new Exception("The authorization header is either empty or isn't Basic.");
            }
        }
        [HttpGet("getUlogaIDs/{id}")]
        public List<int> getUlogeIDs(int id)
        {
            return _service.getUlogeIDs(id);
        }
        [HttpGet("getID")]
        public int getID([FromQuery]KorisnikSearchRequest req)
        {
            return _service.GetID(req);
        }
       



    }
}
