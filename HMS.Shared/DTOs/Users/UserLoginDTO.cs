using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Shared.DTOs.Users
{
    public class UserLoginDTO
    {
        public UserLoginDTO(int userID, string Fname, string Lname, bool isActive, string roleName, string passwordHash)
        {
            UserID = userID;
            this.FName = Fname;
            this.LName = Lname;
            IsActive = isActive;
            RoleName = roleName;
            PasswordHash = passwordHash;
        }
        public int UserID { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public bool IsActive { get; set; }
        public string RoleName { get; set; }
        public string PasswordHash { get; set; }
    }
}
