using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMSShared.DTOs.Rooms
{
    public class RoomListDTO
    {
        public RoomListDTO(int roomID, string roomNumber, int roomTypeID, string roomTypeName, decimal price, int capacity, string status)
        {
            RoomID = roomID;
            RoomNumber = roomNumber;
            RoomTypeID = roomTypeID;
            RoomTypeName = roomTypeName;
            Price = price;
            Capacity = capacity;
            Status = status;
        }

        public int RoomID { get; set; }
        public string RoomNumber { get; set; }
        public int RoomTypeID { get; set; }
        public string RoomTypeName { get; set; }
        public decimal Price { get; set; }
        public int Capacity { get; set; }
        public string Status { get; set; }
    }
}
