using HMSDataAccessLayer;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Net.Http;
using System.Text;

namespace HMSDesktop.Services
{
    public class RoomApiService : BaseApiService
    {
        public string LastError { get; private set; } = string.Empty;

        // ================= ROOMS =================

        public async Task<bool> AddRoomAsync(AddNewRoomDTO dto)
        {
            return await PostAsync("RoomAPI/Add", dto);
        }

        public async Task<List<RoomListDTO>> GetAllRoomsAsync()
        {
            return await GetAsync<List<RoomListDTO>>("RoomAPI/All");
        }

        public async Task<RoomListDTO> GetByIdAsync(int id)
        {
            return await GetAsync<RoomListDTO>($"RoomAPI/{id}");
        }

        public async Task<bool> UpdateRoomAsync(UpdateRoomDTO dto)
        {
            LastError = string.Empty;

            var json = Newtonsoft.Json.JsonConvert.SerializeObject(dto);
            var content = new StringContent(json, Encoding.UTF8, "application/json");


            var res = await client.PutAsync($"RoomAPI/Update/{dto.RoomID}", content);
            var bodye = await res.Content.ReadAsStringAsync();

            Console.WriteLine("STATUS: " + res.StatusCode);
            Console.WriteLine("BODY: " + bodye);

            if (res.IsSuccessStatusCode)
                return true;

            try
            {
                var body = await res.Content.ReadAsStringAsync();
                LastError = $"Status: {(int)res.StatusCode} {res.ReasonPhrase}. Body: {body}";
            }
            catch (Exception ex)
            {
                LastError = $"Status: {(int)res.StatusCode} {res.ReasonPhrase}. Failed reading body: {ex.Message}";
            }

            return false;
        }

        public async Task<bool> DeleteRoomAsync(int id)
        {
            return await DeleteAsync($"RoomAPI/Delete/{id}");
        }

        public async Task<bool> IsRoomNumberExistsAsync(string roomNumber)
        {
            return await GetAsync<bool>($"RoomAPI/Exists/{roomNumber}");
        }




        // ================= ROOM TYPES =================

        public async Task<bool> AddRoomTypeAsync(AddNewRoomTypeDTO dto)
        {
            return await PostAsync("RoomTypeAPI/Add", dto);
        }

        public async Task<List<RoomTypeListDTO>> GetAllRoomTypesAsync()
        {
            return await GetAsync<List<RoomTypeListDTO>>("RoomTypeAPI/All");
        }

        public async Task<RoomTypeListDTO> GetRoomTypeByIdAsync(int id)
        {
            return await GetAsync<RoomTypeListDTO>($"RoomTypeAPI/{id}");
        }

        public async Task<bool> UpdateRoomTypeAsync(int id, UpdateRoomTypeDTO dto)
        {
            return await PutAsync($"RoomTypeAPI/Update/{id}", dto);
        }

        public async Task<bool> DeleteRoomTypeAsync(int id)
        {
            return await DeleteAsync($"RoomTypeAPI/Delete/{id}");
        }

        public async Task<bool> IsRoomTypeNameExistsAsync(string typeName)
        {
            return await GetAsync<bool>($"RoomTypeAPI/Exists/{typeName}");
        }
    }
}