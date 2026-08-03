using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMSShared.DTOs.Roles
{
    public class UpdateRoleDTO
    {
        public UpdateRoleDTO(int roleID, string roleName)
        {
            RoleID = roleID;
            RoleName = roleName;
        }

        public int RoleID { get; set; }
        public string RoleName { get; set; }
    }
}
