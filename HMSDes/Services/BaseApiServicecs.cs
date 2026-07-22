using HMSDesktop.User_Control;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMSDesktop.Services
{
    public class BaseApiService
    {

        // ==============================
        // Production Server Configuration
        // إعدادات السيرفر الخارجي (الاستضافة)
        // ==============================


        protected static readonly HttpClient client;

        static BaseApiService()
        {
            var handler = new HttpClientHandler
            {
                ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => true
            };

            client = new HttpClient(handler)
            {
                BaseAddress = new Uri("http://luxera-hms-api.runasp.net/api/")
            };
        }





        // ==============================
        // Local Development Server
        // إعدادات السيرفر المحلي للتطوير
        // ==============================

        //protected static readonly HttpClient client = new HttpClient
        //{
        //    BaseAddress = new Uri("https://localhost:7152/api/")
        //};

        protected async Task<T?> GetAsync<T>(string url)
        {
            var res = await client.GetAsync(url);
            var responseBody = await res.Content.ReadAsStringAsync();

            if (res.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<T>(responseBody);
            }

            if (res.StatusCode == System.Net.HttpStatusCode.NotFound)
            {
                return default;
            }

            MessageBox.Show($"Error: {res.StatusCode}\n{responseBody}",
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);

            return default;
        }

        protected async Task<bool> PostAsync<T>(string url, T data)
        {
            var json = JsonConvert.SerializeObject(data);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var res = await client.PostAsync(url, content);
            return res.IsSuccessStatusCode;
        }


        protected async Task<bool> PutAsync<T>(string url, T data)
        {
            var json = JsonConvert.SerializeObject(data);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var res = await client.PutAsync(url, content);

            return res.IsSuccessStatusCode;
        }

        protected async Task<bool> DeleteAsync(string url)
        {
            var res = await client.DeleteAsync(url);
            return res.IsSuccessStatusCode;
        }
    }
}