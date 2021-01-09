using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eProdaja.Model;
using Flurl.Http;

namespace PetConn.WinUI
{
    public class APIService
    {
        private readonly string _route;
        public static string Password { get; set; }
        public static string UserName { get; set; }

        public APIService(string route)
        {
            _route = route;
        }
        public async Task<T> Get<T>(object request)
        {
            var url = $"{Properties.Settings.Default.APIUrl}/{_route}";
            if(request!=null)
            {
                url += "?";
                url += await request.ToQueryString();
            }
            return await url.WithBasicAuth(UserName, Password).GetJsonAsync<T>();
        }
        public async Task<T> Insert<T>(object request)
        {
            var url = $"{Properties.Settings.Default.APIUrl}/{_route}";
            
            return await url.PostJsonAsync(request).ReceiveJson<T>();
        }
        public async Task<T> GetPartner<T>(object request)
        {
            var url = $"{Properties.Settings.Default.APIUrl}/{_route}/partner";
            if (request != null)
            {
                url += "?";
                url += await request.ToQueryString();
            }
            return await url.WithBasicAuth(UserName, Password).GetJsonAsync<T>();
            
        }
    }
}
