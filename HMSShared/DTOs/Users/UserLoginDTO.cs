using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMSShared.DTOs.Users
{
    public class UserLoginDTO
    {
        public UserLoginDTO(int userID, string userName, bool isActive, string roleName, string passwordHash)
        {
            UserID = userID;
            UserName = userName;
            IsActive = isActive;
            RoleName = roleName;
            PasswordHash = passwordHash;
        }

        public UserLoginDTO(int userID, string userName, string roleName)
        {
            UserID = userID;
            UserName = userName;
            RoleName = roleName;
        }

        public int UserID { get; set; }
        public string UserName { get; set; }
        public bool IsActive { get; set; }
        public string RoleName { get; set; }
        public string PasswordHash { get; set; }
    }
}
