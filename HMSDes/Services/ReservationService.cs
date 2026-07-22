using HMSBusinessLayer;
using HMSDataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMSDesktop.Services
{
    public class ReservationService
    {
        private readonly ReservationApiService _api;
        public string LastError => _api.LastError;

        public ReservationService()
        {
            _api = new ReservationApiService();
        }

        public async Task<bool> AddReservation(AddNewReservationDTO dto)
        {
            if (dto == null)
                return false;
            return await _api.AddReservationAsync(dto);
        }

        public async Task<bool> UpdateReservation(int id, UpdateReservationDTO dto)
        {
            if (id <= 0 || dto == null)
                return false;
            return await _api.UpdateReservationAsync(id, dto);
        }

        public async Task<bool> DeleteReservation(int id)
        {
            if (id <= 0)
                return false;
            return await _api.DeleteReservationAsync(id);
        }

        public async Task<List<RoomNumberDTO>> GetRoomNumbers()
        {
            return await _api.GetRoomNumbersAsync();
        }

        public async Task<List<ReservationListDTO>> GetReservations()
        {
            return await _api.GetAllReservationsAsync();
        }

        public async Task<ReservationListDTO> GetById(int id)
        {
            if (id <= 0)
                return null;
            return await _api.GetReservationByIdAsync(id);
        }

        public async Task<List<clsReservationsBusiness.RoomTimelineRow>> GetHotelTimeline(DateTime startDate, DateTime endDate)
        {
            return await _api.GetHotelTimelineAsync(startDate, endDate);
        }
    }
}
