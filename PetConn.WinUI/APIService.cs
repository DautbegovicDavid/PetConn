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
        public static string Uloga { get; set; }

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
        public async Task<T> GetbyID<T>(int ID)
        {
            var url = $"{Properties.Settings.Default.APIUrl}/{_route}/{ID}";
           
            return await url.WithBasicAuth(UserName, Password).GetJsonAsync<T>();
        }
        
        public async Task<T> Delete<T>(int ID)
        {
            var url = $"{Properties.Settings.Default.APIUrl}/{_route}/{ID}";

            return await url.WithBasicAuth(UserName, Password).DeleteAsync().ReceiveJson<T>();
        }
        public async Task<T> Insert<T>(object request)
        {
            var url = $"{Properties.Settings.Default.APIUrl}/{_route}";
            
            return await url.WithBasicAuth(UserName, Password).PostJsonAsync(request).ReceiveJson<T>();
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
        public async Task<T> GetVrstaPartneraID<T>(object request)
        {
            var url = $"{Properties.Settings.Default.APIUrl}/{_route}/byName";
            if (request != null)
            {
                url += "?";
                url += await request.ToQueryString();
            }
            return await url.WithBasicAuth(UserName, Password).GetJsonAsync<T>();

        }
        public async Task<T> GetPartnresIDs<T>(object request)
        {
            var url = $"{Properties.Settings.Default.APIUrl}/{_route}/IDsByVrstaPartneraID";
            if (request != null)
            {
                url += "?";
                url += await request.ToQueryString();
            }
            return await url.WithBasicAuth(UserName, Password).GetJsonAsync<T>();

        }
         
        public async Task<T> Update<T>(int id, object request)
        {
            
                var url = $"{Properties.Settings.Default.APIUrl}/{_route}/{id}";

                return await url.WithBasicAuth(UserName, Password).PutJsonAsync(request).ReceiveJson<T>();
          
        }
        public async Task<T> ChangePass<T>(object request)
        {

            var url = $"{Properties.Settings.Default.APIUrl}/{_route}";

            return await url.WithBasicAuth(UserName, Password).PutJsonAsync(request).ReceiveJson<T>();

        }
    }
}
