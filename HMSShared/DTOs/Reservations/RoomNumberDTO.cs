using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMSShared.DTOs.Reservations
{
    public class RoomNumberDTO
    {
        public RoomNumberDTO(int roomID, string roomNumber)
        {
            RoomID = roomID;
            RoomNumber = roomNumber;
        }

        public int RoomID { get; set; }
        public string RoomNumber { get; set; }
    }

}
