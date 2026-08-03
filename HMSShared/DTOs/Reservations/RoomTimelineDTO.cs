using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMSShared.DTOs.Reservations
{
    public class RoomTimelineDTO
    {
        public class RoomAvailabilityInfo
        {
            public int RoomID { get; set; }
            public string RoomNumber { get; set; }
            public string RoomType { get; set; }
            public decimal PricePerNight { get; set; }
            public string RoomCurrentStatus { get; set; }

            public int? ReservationID { get; set; }
            public string GuestName { get; set; }
            public DateTime? CheckInDate { get; set; }
            public DateTime? CheckOutDate { get; set; }
            public string ReservationStatus { get; set; }
        }
    }
}
