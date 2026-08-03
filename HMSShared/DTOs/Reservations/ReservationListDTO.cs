using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMSShared.DTOs.Reservations
{
    public class ReservationListDTO
    {
        public ReservationListDTO(int reservationID, int roomID, string roomNumber,
            int clientId, string clientName, int userID, string createdByUser,
            DateTime checkInDate, DateTime checkOutDate, string status)
        {
            ReservationID = reservationID;
            RoomID = roomID;
            RoomNumber = roomNumber;
            ClientId = clientId;
            ClientName = clientName;
            UserID = userID;
            CreatedByUser = createdByUser;
            CheckInDate = checkInDate;
            CheckOutDate = checkOutDate;
            Status = status;
        }

        public int ReservationID { get; set; }
        public int RoomID { get; set; }
        public string RoomNumber { get; set; }
        public int ClientId { get; set; }
        public string ClientName { get; set; }
        public int UserID { get; set; }
        public string CreatedByUser { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
        public string Status { get; set; }
    }
}
