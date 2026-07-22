using HMSBusinessLayer;
using HMSDataAccessLayer;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace HMSDesktop.Services
{
    public class ReservationApiService : BaseApiService
    {
        public string LastError { get; private set; } = string.Empty;



        public async Task<bool> AddReservationAsync(AddNewReservationDTO dto)
        {
            return await PostAsync("ReservationAPI/Add", dto);
        }

        public async Task<bool> UpdateReservationAsync(int id, UpdateReservationDTO dto)
        {
            return await PutAsync($"ReservationAPI/Update/{id}", dto);
        }

        public async Task<bool> DeleteReservationAsync(int id)
        {
            return await DeleteAsync($"ReservationAPI/Delete/{id}");
        }

        public async Task<List<RoomNumberDTO>> GetRoomNumbersAsync()
        {
            return await GetAsync<List<RoomNumberDTO>>("ReservationAPI/RoomNumbers");
        }

        public async Task<List<ReservationListDTO>> GetAllReservationsAsync()
        {
            return await GetAsync<List<ReservationListDTO>>("ReservationAPI/All");
        }

        public async Task<ReservationListDTO> GetReservationByIdAsync(int id)
        {
            return await GetAsync<ReservationListDTO>($"ReservationAPI/{id}");
        }

        public async Task<List<clsReservationsBusiness.RoomTimelineRow>> GetHotelTimelineAsync(DateTime startDate, DateTime endDate)
        {
            string url = $"ReservationAPI/Timeline?startDate={startDate:yyyy-MM-dd}&endDate={endDate:yyyy-MM-dd}";
            return await GetAsync<List<clsReservationsBusiness.RoomTimelineRow>>(url);
        }

    }
}
