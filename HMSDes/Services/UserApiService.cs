using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json.Serialization;
using Newtonsoft.Json;
using HMSDataAccessLayer;
using Newtonsoft.Json.Linq;
using System.Text;
using Newtonsoft.Json.Linq;

namespace HMSDesktop.Services
{
    public class UserApiService : BaseApiService
    {
        public string LastError { get; private set; } = string.Empty;

        public async Task<List<UserListDTO>> GetAllUsersAsync()
        {
            return await GetAsync<List<UserListDTO>>("UserAPI/All");
        }


        public async Task<OneUserListDTO> GetByIdAsync(int id)
        {
            return await GetAsync<OneUserListDTO>($"UserAPI/{id}");
        }


        public async Task<OneUserListDTO> GetByUserNameAsync(string username)
        {
            return await GetAsync<OneUserListDTO>($"UserAPI/ByUsername/{username}");
        }


        public async Task<bool> AddUserAsync(AddNewUserDTO dto)
        {
            return await PostAsync("UserAPI/Add", dto);
        }


        public async Task<bool> UpdateUserAsync(int id, UpdateUserDTO dto)
        {
            dto.UserID = id;
            var json = JsonConvert.SerializeObject(dto);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var res = await client.PutAsync($"UserAPI/Update/{id}", content);

            var responseBody = await res.Content.ReadAsStringAsync();

            if (!res.IsSuccessStatusCode)
            {
                try
                {
                    var obj = JObject.Parse(responseBody);

                    LastError =
                        obj["Error"]?.ToString() ??
                        obj["Details"]?.ToString() ??
                        responseBody;
                }
                catch
                {
                    LastError = responseBody;
                }

                return false;
            }

            LastError = string.Empty;
            return true;
        }


        public async Task<bool> DeleteUserAsync(int id)
        {
            var res = await client.DeleteAsync($"UserAPI/Delete/{id}");
            var body = await res.Content.ReadAsStringAsync();

            if (!res.IsSuccessStatusCode)
            {
                try
                {
                    var obj = JObject.Parse(body);
                    LastError = obj["Error"]?.ToString() ?? body;
                }
                catch
                {
                    LastError = body;
                }

                return false;
            }

            try
            {
                var obj = JObject.Parse(body);
                LastError = obj["Message"]?.ToString() ?? "Deleted successfully";
            }
            catch
            {
                LastError = body;
            }

            return true;
        }


        public async Task<UserLoginDTO> LoginAsync(LoginDTO dto)
        {
            var content = new StringContent(JsonConvert.SerializeObject(dto), Encoding.UTF8, "application/json");

            var res = await client.PostAsync("UserAPI/Login", content);

            var json = await res.Content.ReadAsStringAsync();


            if (res.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<UserLoginDTO>(json);
            }

            return null;
        }


    }
}
