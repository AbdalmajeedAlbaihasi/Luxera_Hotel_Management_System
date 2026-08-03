using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMSShared.DTOs.Roles
{
    public class AddNewRoleDTO
    {
        public AddNewRoleDTO(string roleName)
        {
            RoleName = roleName;
        }

        public string RoleName { get; set; }
    }
}
