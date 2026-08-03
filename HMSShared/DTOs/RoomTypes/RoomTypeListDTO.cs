using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMSShared.DTOs.RoomTypes
{
    public class RoomTypeListDTO
    {
        public RoomTypeListDTO(int roomTypeID, string typeName)
        {
            RoomTypeID = roomTypeID;
            TypeName = typeName;
        }

        public int RoomTypeID { get; set; }
        public string TypeName { get; set; }
    }
}
