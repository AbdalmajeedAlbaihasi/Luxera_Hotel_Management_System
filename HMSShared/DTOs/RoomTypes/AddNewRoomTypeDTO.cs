using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMSShared.DTOs.RoomTypes
{
    public class AddNewRoomTypeDTO
    {
        public AddNewRoomTypeDTO(string typeName)
        {
            TypeName = typeName;
        }

        public string TypeName { get; set; }
    }
}
