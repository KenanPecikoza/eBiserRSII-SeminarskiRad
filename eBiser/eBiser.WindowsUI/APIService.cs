using Flurl.Http;
using Flurl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eBiser.Data;

namespace eBiser.WindowsUI

{
    public class APIService
    {
        private string _route = null;

        public APIService(string route )
        {
            _route = route;
        }
        public static string Token { get; set; }
        public static int KorisnikId { get; set; }
        public static int Id { get; set; }
        
        public async Task<T> Get<T>(object search)
        {
            var url = $"{WindowsUI.Properties.Settings.Default.APIUrl}/{_route}";
            if (search!=null)
            {
                url += "?";
                url += await search.ToQueryString();
            }
            return await url.WithOAuthBearerToken(Token).GetJsonAsync<T>(); 
        }
        public async Task<T> GetById<T>(object id)
        {
            var url = $"{WindowsUI.Properties.Settings.Default.APIUrl}/{_route}/{id}";

            return  await url.WithOAuthBearerToken(Token).GetJsonAsync<T>(); ;
        }

        public async Task<T> Insert<T>(object request)
        {
            var url = $"{WindowsUI.Properties.Settings.Default.APIUrl}/{_route}";
            return await url.WithOAuthBearerToken(Token).PostJsonAsync(request).ReceiveJson<T>();
        }

        public async Task<T> Update<T>(int id, object request)
        {
            var url = $"{WindowsUI.Properties.Settings.Default.APIUrl}/{_route}/{id}";
            
            return await url.WithOAuthBearerToken(Token).PutJsonAsync(request).ReceiveJson<T>(); 
        }
        public async Task<T> Login<T>(object request)
        {
            var url = $"{WindowsUI.Properties.Settings.Default.APIUrl}/{_route}";
            return await url.PostJsonAsync(request).ReceiveJson<T>();
        }

    }
}
