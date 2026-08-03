using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMSShared.DTOs.Rooms
{
    public class AddNewRoomDTO
    {
        public AddNewRoomDTO(string roomNumber, int roomTypeID, string status, int capacity, decimal pricePerNight)
        {
            RoomNumber = roomNumber;
            RoomTypeID = roomTypeID;
            Status = status;
            Capacity = capacity;
            PricePerNight = pricePerNight;
        }

        public string RoomNumber { get; set; }
        public int RoomTypeID { get; set; }
        public string Status { get; set; }
        public int Capacity { get; set; }
        public decimal PricePerNight { get; set; }

    }
}
