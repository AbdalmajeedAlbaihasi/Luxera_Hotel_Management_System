using HMSDataAccessLayer;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMSDesktop.Services
{
    public class ClientApiService : BaseApiService
    {
        public string LastError { get; private set; } = string.Empty;


        public async Task<bool> AddClientAsync(AddNewClientDTO dto)
        {
            return await PostAsync("ClientAPI/Add", dto);
        }


        public async Task<bool> UpdateClientAsync(int id, UpdateClientDTO dto)
        {
            var json = JsonConvert.SerializeObject(dto);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var res = await client.PutAsync($"ClientAPI/Update/{id}", content);
            var body = await res.Content.ReadAsStringAsync();

            if (!res.IsSuccessStatusCode)
            {
                LastError = body;
                return false;
            }
            LastError = string.Empty;
            return true;
        }


        public async Task<bool> DeleteClientAsync(int id)
        {
            return await DeleteAsync($"ClientAPI/Delete/{id}");
        }


        public async Task<List<ClientListDTO>> GetAllClientsAsync()
        {
            return await GetAsync<List<ClientListDTO>>("ClientAPI/All");
        }


        public async Task<ClientListDTO> GetClientByIdAsync(int id)
        {
            return await GetAsync<ClientListDTO>($"ClientAPI/{id}");
        }


        public async Task<List<ClientNameAndIDDTO>> GetClientNamesAsync()
        {
            return await GetAsync<List<ClientNameAndIDDTO>>("ClientAPI/Get/ClientNames");
        }


    }
}
