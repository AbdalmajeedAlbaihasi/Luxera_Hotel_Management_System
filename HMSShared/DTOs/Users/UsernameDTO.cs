using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMSShared.DTOs.Users
{
    public class UsernameDTO
    {
        public UsernameDTO(string userName)
        {
            UserName = userName;
        }
        public string UserName { get; set; }
    }
}
