using HMSDataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMSDesktop.Services
{
    public class RoomService
    {
        private readonly RoomApiService _api;

        public RoomService()
        {
            _api = new RoomApiService();
        }

        // ================= ROOMS =================
        public async Task<bool> AddRoom(AddNewRoomDTO dto)
        {
            if (dto == null)
                return false;
            return await _api.AddRoomAsync(dto);
        }

        public async Task<bool> UpdateRoom(UpdateRoomDTO dto)
        {
            if (dto.RoomID <= 0 || dto == null)
                return false;
            return await _api.UpdateRoomAsync(dto);
        }

        public async Task<bool> DeleteRoom(int id)
        {
            if (id <= 0)
                return false;
            return await _api.DeleteRoomAsync(id);
        }

        public async Task<List<RoomListDTO>> GetRooms()
        {
            return await _api.GetAllRoomsAsync();
        }

        public async Task<RoomListDTO> GetById(int id)
        {
            return await _api.GetByIdAsync(id);
        }



        // ================= ROOM TYPES =================
        public async Task<bool> AddRoomType(AddNewRoomTypeDTO dto)
        {
            if (dto == null)
                return false;
            return await _api.AddRoomTypeAsync(dto);
        }

        public async Task<bool> UpdateRoomType(int id, UpdateRoomTypeDTO dto)
        {
            if (id <= 0 || dto == null)
                return false;
            return await _api.UpdateRoomTypeAsync(id, dto);
        }

        public async Task<bool> DeleteRoomType(int id)
        {
            if (id <= 0)
                return false;
            return await _api.DeleteRoomTypeAsync(id);
        }

        public async Task<List<RoomTypeListDTO>> GetRoomTypes()
        {
            return await _api.GetAllRoomTypesAsync();
        }

        public async Task<RoomTypeListDTO> GetRoomTypeById(int id)
        {
            return await _api.GetRoomTypeByIdAsync(id);
        }
    }
}
