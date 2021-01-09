
using Microsoft.AspNetCore.Authentication;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using PetConn.Model;
using PetConn.WebAPI.Services;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Claims;
using System.Text;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using System.Security.Claims;

namespace eProdaja.WebAPI.Security
{
    public class BasicAuthenticationHandler : AuthenticationHandler<AuthenticationSchemeOptions>//da bi .net mogao raditi auth i autor zahtjeva da naslijedimo ovyu klasu
    {
        private readonly IKorisniciService _userService;

        public BasicAuthenticationHandler(
            IOptionsMonitor<AuthenticationSchemeOptions> options,
            ILoggerFactory logger,
            UrlEncoder encoder,
            ISystemClock clock,
            IKorisniciService userService)
            : base(options, logger, encoder, clock)
        {
            _userService = userService;
        }

        protected override async Task<AuthenticateResult> HandleAuthenticateAsync()//overrrida metode koja dodje uz authHandler
        {
            if (!Request.Headers.ContainsKey("Authorization"))
                return AuthenticateResult.Fail("Missing Authorization Header");

            Korisnik user;
            try
            {
                var authHeader = AuthenticationHeaderValue.Parse(Request.Headers["Authorization"]);
                var credentialBytes = Convert.FromBase64String(authHeader.Parameter);
                var credentials = Encoding.UTF8.GetString(credentialBytes).Split(':');
                var username = credentials[0];
                var password = credentials[1];
                user = _userService.Authenticiraj(username, password);
            }
            catch
            {
                return AuthenticateResult.Fail("Invalid Authorization Header");
            }

            //var test = user.KorisniciUloges;

            if (user == null)
                return AuthenticateResult.Fail("Invalid Username or Password");

            //CLAIM nesto sto tvrdimo da posjedujemo,tvrdimo da je nase ime prezime xy itd
            var claims = new List<Claim> {
                new Claim(ClaimTypes.NameIdentifier, user.KorisnickoIme),
                new Claim(ClaimTypes.Name, user.Ime),
                

            };
            //identiFajeri

            foreach (var role in user.KorisniciUloges)//sys.nullRef exc
            {
                claims.Add(new Claim(ClaimTypes.Role, role.Uloga.Naziv));
            }

            //var claims = new List<Claim>();
            //claims.Add(new Claim(ClaimTypes.Name, result.UserFirstName));
            //claims.Add(new Claim(ClaimTypes.Sid, result.UserID.ToString()));
            //var identity = new ClaimsIdentity(claims, DefaultAuthenticationTypes.ApplicationCookie);
            //var claimsPrincipal = new ClaimsPrincipal(identity);
            //// Set current principal
            //Thread.CurrentPrincipal = claimsPrincipal

            var identity = new ClaimsIdentity(claims, Scheme.Name);
            var principal = new ClaimsPrincipal(identity);
            var ticket = new AuthenticationTicket(principal, Scheme.Name);

            return AuthenticateResult.Success(ticket);
        }
    }
}