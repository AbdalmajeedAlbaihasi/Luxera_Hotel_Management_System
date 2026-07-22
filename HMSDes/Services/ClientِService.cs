using HMSDataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMSDesktop.Services
{
    public class ClientService
    {
        private readonly ClientApiService _api;

        public ClientService()
        {
            _api = new ClientApiService();
        }


        public string LastError => _api.LastError;


        public async Task<bool> AddClient(AddNewClientDTO dto)
        {
            if (dto == null)
                return false;
            return await _api.AddClientAsync(dto);
        }


        public async Task<bool> UpdateClient(int id, UpdateClientDTO dto)
        {
            if (id <= 0 || dto == null)
                return false;
            return await _api.UpdateClientAsync(id, dto);
        }


        public async Task<bool> DeleteClient(int id)
        {
            if (id <= 0)
                return false;
            return await _api.DeleteClientAsync(id);
        }


        public async Task<List<ClientListDTO>> GetClients()
        {
            return await _api.GetAllClientsAsync();
        }


        public async Task<ClientListDTO> GetById(int id)
        {
            return await _api.GetClientByIdAsync(id);
        }


        public async Task<List<ClientNameAndIDDTO>> GetClientNames()
        {
            return await _api.GetClientNamesAsync();
        }
    }

}
