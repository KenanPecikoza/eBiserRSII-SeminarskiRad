using eBiser.Data;
using Flurl.Http;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;


namespace eBiserMobileApp
{
    public class APIService
    {
        private string _route = null;
        public static string Token { get; set; }
        public static string KorisnikSistema { get; set; }
        public static int Id { get; set; }
        public static int KorisnikId { get; set; }


#if DEBUG
        private string apiUrl = "http://localhost:57869/api";
        //private string apiUrl = "http://10.0.2.2:8080/api";
        //private string apiUrl = "https://localhost:44312/api";
#endif
#if RELEASE
        private string apiUrl = "https://localhost:57869/api";


#endif


        public APIService(string route)
        {
            _route = route;
        }

        public async Task<T> Get<T>(object search)
        {
            var url = $"{apiUrl}/{_route}";
            if (search != null)
            {
                url += "?";
                url += await search.ToQueryString();
            }
            return await url.WithOAuthBearerToken(Token).GetJsonAsync<T>();
        }

        public async Task<T> GetProvjera<T>(object search)
        {
            var url = $"{apiUrl}/{_route}";
            if (search != null)
            {
                url += "?";
                url += await search.ToQueryString();
            }
            return await url.GetJsonAsync<T>();
        }

        public async Task<T> GetById<T>(object id)
        {
            var url = $"{apiUrl}/{_route}/{id}";

            return await url.WithOAuthBearerToken(Token).GetJsonAsync<T>(); ;
        }

        public async Task<T> Insert<T>(object request)
        {
            var url = $"{apiUrl}/{_route}";
            return await url.WithOAuthBearerToken(Token).PostJsonAsync(request).ReceiveJson<T>();
        }

        public async Task<T> SingUp<T>(object request)
        {
            var url = $"{apiUrl}/{_route}";
            return await url.PostJsonAsync(request).ReceiveJson<T>();
        }


        public async Task<T> Update<T>(int id, object request)
        {
            var url = $"{apiUrl}/{_route}/{id}";

            return await url.WithOAuthBearerToken(Token).PutJsonAsync(request).ReceiveJson<T>();
        }



        public async Task<T> Login<T>(object request)
        {
            var url = $"{apiUrl}/{_route}";
            try
            {
                 return await url.PostJsonAsync(request).ReceiveJson<T>();
            }
            catch (FlurlHttpException ex)
            {
                var ex1 = ex;
                await Application.Current.MainPage.DisplayAlert("Greška", "Niste authentificirani", "OK");
                throw;
            }

        }
    }
}
