using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Shared.DTOs.Reservations
{
    public class OneReservationListDTO
    {
        public OneReservationListDTO(int reservationID, int roomID, int clientId, int userID,
            DateTime checkInDate, DateTime checkOutDate, string status)
        {
            ReservationID = reservationID;
            RoomID = roomID;
            ClientId = clientId;
            UserID = userID;
            CheckInDate = checkInDate;
            CheckOutDate = checkOutDate;
            Status = status;
        }

        public int ReservationID { get; set; }
        public int RoomID { get; set; }
        public int ClientId { get; set; }
        public int UserID { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
        public string Status { get; set; }
    }
}
