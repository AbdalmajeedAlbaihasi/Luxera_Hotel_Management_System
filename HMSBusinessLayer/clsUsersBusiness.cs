using HMSDataAccessLayer;
using BCrypt.Net;
using System;
using System.Collections.Generic;

namespace HMSBusinessLayer
{
    public class clsUsersBusiness
    {
        //Members
        public enum enMode { Addnew = 0, Update = 1 };
        private enMode Mode = enMode.Addnew;

        public int UserID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedAt { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public DateTime BirthDate { get; set; }
        public string PhoneNumber { get; set; }
        public int NationalityID { get; set; }
        public string NationalityName { get; set; }
        public string Gender { get; set; }
        public string RoleName { get; set; }
        public string ImagePath { get; set; }




        //Properties
        public UserListDTO UserListDto
        {
            get
            {
                return new UserListDTO(
                    this.UserID,
                    this.UserName,
                    this.IsActive,
                    this.CreatedAt,
                    this.FName,
                    this.LName,
                    this.BirthDate,
                    this.PhoneNumber,
                    this.NationalityID,
                    this.NationalityName,
                    this.Gender,
                    this.RoleName
                );
            }
        }


        public OneUserListDTO OneUserListDTO
        {
            get
            {
                return new OneUserListDTO(
                    this.UserID,
                    this.UserName,
                    this.Password,
                    this.IsActive,
                    this.FName,
                    this.LName,
                    this.BirthDate,
                    this.PhoneNumber,
                    this.NationalityID,
                    this.NationalityName,
                    this.Gender,
                    this.RoleName,
                    this.ImagePath
                );
            }
        }


        public AddNewUserDTO AddNewUserDto
        {
            get
            {
                return new AddNewUserDTO(
                    this.UserName,
                    this.Password,
                    this.IsActive,
                    this.FName,
                    this.LName,
                    this.BirthDate,
                    this.PhoneNumber,
                    this.NationalityID,
                    this.Gender,
                    this.RoleName,
                    this.ImagePath
                );
            }
        }


        public UpdateUserDTO UpdateUserDto
        {
            get
            {
                return new UpdateUserDTO(
                    this.UserID,
                    this.UserName,
                    this.Password,
                    this.IsActive,
                    this.FName,
                    this.LName,
                    this.BirthDate,
                    this.PhoneNumber,
                    this.NationalityID,
                    this.Gender,
                    this.RoleName,
                    this.ImagePath
                );
            }
        }





        //Constructors
        public clsUsersBusiness()
        {
            this.UserID = -1;
            this.UserName = "";
            this.Password = "";
            this.IsActive = true;
            this.FName = "";
            this.LName = "";
            this.BirthDate = DateTime.Now;
            this.PhoneNumber = "";
            this.NationalityID = -1;
            this.Gender = "";
            this.RoleName = "";
            this.ImagePath = "";
            this.Mode = enMode.Addnew;
        }


        public clsUsersBusiness(AddNewUserDTO DTO, enMode cMode = enMode.Addnew)
        {
            this.UserName = DTO.UserName;
            this.Password = DTO.Password;
            this.IsActive = DTO.IsActive;
            this.FName = DTO.FName;
            this.LName = DTO.LName;
            this.BirthDate = DTO.BirthDate;
            this.PhoneNumber = DTO.PhoneNumber;
            this.NationalityID = DTO.NationalityID;
            this.Gender = DTO.Gender;
            this.RoleName = DTO.RoleName;
            this.ImagePath = DTO.ImagePath;

            this.Mode = cMode;
        }


        public clsUsersBusiness(UserListDTO DTO)
        {
            this.UserID = DTO.UserID;
            this.UserName = DTO.UserName;
            this.IsActive = DTO.IsActive;
            this.CreatedAt = DTO.CreatedAt;
            this.FName = DTO.FName;
            this.LName = DTO.LName;
            this.BirthDate = DTO.BirthDate;
            this.PhoneNumber = DTO.PhoneNumber;
            this.NationalityID = DTO.NationalityID;
            this.NationalityName = DTO.NationalityName;
            this.Gender = DTO.Gender;
            this.RoleName = DTO.RoleName;
            this.Mode = enMode.Update;
        }


        public clsUsersBusiness(OneUserListDTO DTO)
        {
            this.UserID = DTO.UserID;
            this.UserName = DTO.UserName;
            this.Password = DTO.Password;
            this.IsActive = DTO.IsActive;
            this.FName = DTO.FName;
            this.LName = DTO.LName;
            this.BirthDate = DTO.BirthDate;
            this.PhoneNumber = DTO.PhoneNumber;
            this.NationalityID = DTO.NationalityID;
            this.NationalityName = DTO.NationalityName;
            this.Gender = DTO.Gender;
            this.RoleName = DTO.RoleName;
            this.ImagePath = DTO.ImagePath;
            this.Mode = enMode.Update;
        }




        //Methods
        public static UserLoginDTO AuthenticateUser(string username, string password)
        {
            return clsUsersData.AuthenticateUser(username, password);
        }


        public static (bool Success, string Message) DeleteUser(int userId)
        {
            return clsUsersData.DeleteUser(userId);
        }


        public static List<UserListDTO> GetAllUsers()
        {
            return clsUsersData.GetAllUsers();
        }


        public static bool IsUsernameExists(string username)
        {
            return clsUsersData.IsUsernameExists(username);
        }


        public static clsUsersBusiness Find(int ID)
        {
            OneUserListDTO DTO = clsUsersData.GetUserByID(ID);
            if (DTO != null)
                return new clsUsersBusiness(DTO);
            else
                return null;
        }


        public static clsUsersBusiness FindByUsername(string username)
        {
            OneUserListDTO DTO = clsUsersData.GetUserByUsername(username);
            if (DTO != null)
                return new clsUsersBusiness(DTO);
            else
                return null;
        }


        private bool _AddNewUser()
        {
            this.UserID = clsUsersData.AddNewUser(AddNewUserDto);
            return (this.UserID != -1);
        }


        private bool _UpdateUser()
        {
            return clsUsersData.UpdateUser(UpdateUserDto);
        }


        public bool Save()
        {
            switch (Mode)
            {
                case enMode.Addnew:
                    if (_AddNewUser())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    return false;

                case enMode.Update:
                    return _UpdateUser();
            }
            return false;
        }


    }
}