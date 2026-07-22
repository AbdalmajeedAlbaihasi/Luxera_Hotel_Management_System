using HMSDataAccessLayer;
using System.Collections.Generic;

namespace HMSBusinessLayer
{
    public class clsRolesBusiness
    {
        public enum enMode { AddNew = 0, Update = 1 }
        private enMode Mode = enMode.AddNew;

        public int RoleID { get; set; }
        public string RoleName { get; set; }

        public RoleListDTO RoleListDto
        {
            get
            {
                return new RoleListDTO(this.RoleID, this.RoleName);
            }
        }

        public AddNewRoleDTO AddNewRoleDto
        {
            get
            {
                return new AddNewRoleDTO(this.RoleName);
            }
        }

        public UpdateRoleDTO UpdateRoleDto
        {
            get
            {
                return new UpdateRoleDTO(this.RoleID, this.RoleName);
            }
        }

        public clsRolesBusiness(RoleListDTO dto, enMode cMode = enMode.AddNew)
        {
            this.RoleID = dto.RoleID;
            this.RoleName = dto.RoleName;
            this.Mode = cMode;
        }

        public static List<RoleListDTO> GetAllRoles()
        {
            return clsRolesData.GetAllRoles();
        }

        public static clsRolesBusiness Find(int roleID)
        {
            RoleListDTO dto = clsRolesData.GetRoleByID(roleID);

            if (dto != null)
                return new clsRolesBusiness(dto, enMode.Update);

            return null;
        }

        public static clsRolesBusiness FindByName(string roleName)
        {
            RoleListDTO dto = clsRolesData.GetRoleByName(roleName);

            if (dto != null)
                return new clsRolesBusiness(dto, enMode.Update);

            return null;
        }

        public static bool DeleteRole(int roleID)
        {
            return clsRolesData.DeleteRole(roleID);
        }

        public static bool IsRoleNameExists(string roleName)
        {
            return clsRolesData.IsRoleNameExists(roleName);
        }

        private bool _AddNewRole()
        {
            this.RoleID = clsRolesData.AddNewRole(AddNewRoleDto);
            return this.RoleID != -1;
        }

        private bool _UpdateRole()
        {
            return clsRolesData.UpdateRole(UpdateRoleDto);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewRole())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    return false;

                case enMode.Update:
                    return _UpdateRole();
            }

            return false;
        }
    }
}
