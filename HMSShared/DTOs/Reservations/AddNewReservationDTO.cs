using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMSShared.DTOs.Reservations
{
    public class AddNewReservationDTO
    {
        public AddNewReservationDTO(int roomID, int clientId, int createdByUserID,
            DateTime checkInDate, DateTime checkOutDate, string status)
        {
            RoomID = roomID;
            ClientId = clientId;
            CreatedByUserID = createdByUserID;
            CheckInDate = checkInDate;
            CheckOutDate = checkOutDate;
            Status = status;
        }

        public int RoomID { get; set; }
        public int ClientId { get; set; }
        public int CreatedByUserID { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
        public string Status { get; set; }
    }
}
