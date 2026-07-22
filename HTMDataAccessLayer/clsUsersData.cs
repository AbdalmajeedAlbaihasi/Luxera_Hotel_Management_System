using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Collections.Generic;
using System.Data.Common;
using HMSDataAccessLayer;

namespace HMSDataAccessLayer
{
    // DTOs
    public class UserLoginDTO
    {
        public UserLoginDTO(int userID, string Fname, string Lname, bool isActive, string roleName)
        {
            UserID = userID;
            this.FName = Fname;
            this.LName = Lname;
            IsActive = isActive;
            RoleName = roleName;
        }
        public int UserID { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string UserName { get; set; }
        public bool IsActive { get; set; }
        public string RoleName { get; set; }
    }

    public class LoginDTO
    {
        public LoginDTO(string username, string password)
        {
            UserName = username;
            Password = password;
        }
        public string UserName { get; set; }
        public string Password { get; set; }
    }

    public class UsernameDTO
    {
        public UsernameDTO(string userName)
        {
            UserName = userName;
        }
        public string UserName { get; set; }
    }

    public class AddNewUserDTO
    {
        public AddNewUserDTO(string username, string Password, bool isActive, string Fname, string Lname,
            DateTime BirthDate, string PhoneNumber, int NationalityID, string Gender, string RoleName, string ImagePath)
        {
            this.UserName = username;
            this.Password = Password;
            this.IsActive = isActive;
            this.FName = Fname;
            this.LName = Lname;
            this.BirthDate = BirthDate;
            this.PhoneNumber = PhoneNumber;
            this.NationalityID = NationalityID;
            this.Gender = Gender;
            this.RoleName = RoleName;
            this.ImagePath = ImagePath;
        }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public DateTime BirthDate { get; set; }
        public string PhoneNumber { get; set; }
        public int NationalityID { get; set; }
        public string Gender { get; set; }
        public string RoleName { get; set; }
        public string ImagePath { get; set; }
    }

    public class UserListDTO
    {
        public UserListDTO(int UserID, string username, bool isActive, DateTime CreatedAt, string Fname, string Lname,
            DateTime BirthDate, string PhoneNumber, int NationalityID, string NationalityName, string Gender, string RoleName)
        {
            this.UserID = UserID;
            this.UserName = username;
            this.IsActive = isActive;
            this.CreatedAt = CreatedAt;
            this.FName = Fname;
            this.LName = Lname;
            this.BirthDate = BirthDate;
            this.PhoneNumber = PhoneNumber;
            this.NationalityID = NationalityID;
            this.NationalityName = NationalityName;
            this.Gender = Gender;
            this.RoleName = RoleName;
        }
        public int UserID { get; set; }
        public string UserName { get; set; }
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
    }

    public class OneUserListDTO
    {
        public OneUserListDTO(int UserID, string username, string Password, bool isActive, string Fname, string Lname,
            DateTime BirthDate, string PhoneNumber, int NationalityID, string NationalityName, string Gender, string RoleName, string ImagePath)
        {
            this.UserID = UserID;
            this.UserName = username;
            this.Password = Password;
            this.IsActive = isActive;
            this.FName = Fname;
            this.LName = Lname;
            this.BirthDate = BirthDate;
            this.PhoneNumber = PhoneNumber;
            this.NationalityID = NationalityID;
            this.NationalityName = NationalityName;
            this.Gender = Gender;
            this.RoleName = RoleName;
            this.ImagePath = ImagePath;
        }
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public DateTime BirthDate { get; set; }
        public string PhoneNumber { get; set; }
        public int NationalityID { get; set; }
        public string NationalityName { get; set; }
        public string Gender { get; set; }
        public string RoleName { get; set; }
        public string ImagePath { get; set; }
    }

    public class UpdateUserDTO
    {
        public UpdateUserDTO(int UserID, string Username, string Password, bool isActive, string Fname, string Lname,
            DateTime BirthDate, string PhoneNumber, int NationalityID, string Gender, string RoleName, string ImagePath)
        {
            this.UserID = UserID;
            this.UserName = Username;
            this.Password = Password;
            this.IsActive = isActive;
            this.FName = Fname;
            this.LName = Lname;
            this.BirthDate = BirthDate;
            this.PhoneNumber = PhoneNumber;
            this.NationalityID = NationalityID;
            this.Gender = Gender;
            this.RoleName = RoleName;
            this.ImagePath = ImagePath;
        }
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public DateTime BirthDate { get; set; }
        public string PhoneNumber { get; set; }
        public int NationalityID { get; set; }
        public string Gender { get; set; }
        public string RoleName { get; set; }
        public string? ImagePath { get; set; }
    }





    public class clsUsersData
    {
        public static int AddNewUser(AddNewUserDTO DTO)
        {
            using (SqlConnection con = new SqlConnection(DBConnection._connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SP_AddNewUser", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@UserName", DTO.UserName);
                    cmd.Parameters.AddWithValue("@PasswordHash", DTO.Password);
                    cmd.Parameters.AddWithValue("@IsActive", DTO.IsActive);
                    cmd.Parameters.AddWithValue("@FName", DTO.FName);
                    cmd.Parameters.AddWithValue("@LName", DTO.LName);
                    cmd.Parameters.AddWithValue("@BirthDate", DTO.BirthDate);
                    cmd.Parameters.AddWithValue("@PhoneNumber", DTO.PhoneNumber);
                    cmd.Parameters.AddWithValue("@NationalityID", DTO.NationalityID);
                    cmd.Parameters.AddWithValue("@Gender", DTO.Gender);
                    cmd.Parameters.AddWithValue("@RoleName", DTO.RoleName);
                    cmd.Parameters.AddWithValue("@ImagePath", string.IsNullOrWhiteSpace(DTO.ImagePath) ? (object)DBNull.Value : DTO.ImagePath);

                    SqlParameter outputIdParam = new SqlParameter("@NewUserID", SqlDbType.Int) { Direction = ParameterDirection.Output };
                    cmd.Parameters.Add(outputIdParam);

                    con.Open();
                    cmd.ExecuteNonQuery();

                    return (outputIdParam.Value != DBNull.Value) ? (int)outputIdParam.Value : -1;
                }
            }
        }


        public static (bool Success, string Message) DeleteUser(int UserId)
        {
            using (SqlConnection con = new SqlConnection(DBConnection._connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SP_DeleteUser", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@UserID", UserId);
                    con.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return (Convert.ToInt32(reader["ResultCode"]) == 1, reader["Message"].ToString());
                        }
                    }
                }
            }
            return (false, "Unknown error");
        }


        public static OneUserListDTO GetUserByUsername(string username)
        {
            using (SqlConnection con = new SqlConnection(DBConnection._connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SP_GetUserByUsername", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Username", username);
                    con.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new OneUserListDTO(
                                reader.GetInt32(reader.GetOrdinal("UserID")),
                                reader["Username"]?.ToString() ?? "",
                                reader["PasswordHash"]?.ToString() ?? "",
                                reader.GetBoolean(reader.GetOrdinal("IsActive")),
                                reader["FirstName"]?.ToString() ?? "",
                                reader["LastName"]?.ToString() ?? "",
                                reader.IsDBNull(reader.GetOrdinal("BirthDate")) ? DateTime.Now : reader.GetDateTime(reader.GetOrdinal("BirthDate")),
                                reader["PhoneNumber"]?.ToString() ?? "",
                                reader.IsDBNull(reader.GetOrdinal("NationalityID")) ? 0 : reader.GetInt32(reader.GetOrdinal("NationalityID")),
                                reader["NationalityName"]?.ToString() ?? "",
                                reader["Gender"]?.ToString() ?? "",
                                reader["RoleName"]?.ToString() ?? "",
                                reader["ImagePath"]?.ToString() ?? ""
                            );
                        }
                    }
                }
            }
            return null;
        }


        public static OneUserListDTO GetUserByID(int ID)
        {
            using (SqlConnection con = new SqlConnection(DBConnection._connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SP_GetUserByID", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@UserID", ID);
                    con.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new OneUserListDTO(
                                reader.GetInt32(reader.GetOrdinal("UserID")),
                                reader["Username"]?.ToString() ?? "",
                                reader["PasswordHash"]?.ToString() ?? "",
                                reader.GetBoolean(reader.GetOrdinal("IsActive")),
                                reader["FirstName"]?.ToString() ?? "",
                                reader["LastName"]?.ToString() ?? "",
                                reader.IsDBNull(reader.GetOrdinal("BirthDate")) ? new DateTime(2000, 1, 1) : reader.GetDateTime(reader.GetOrdinal("BirthDate")),
                                reader["PhoneNumber"]?.ToString() ?? "",
                                reader.IsDBNull(reader.GetOrdinal("NationalityID")) ? 0 : reader.GetInt32(reader.GetOrdinal("NationalityID")),
                                reader["NationalityName"]?.ToString() ?? "",
                                reader["Gender"]?.ToString() ?? "",
                                reader["RoleName"]?.ToString() ?? "",
                                reader["ImagePath"]?.ToString() ?? ""
                            );
                        }
                    }
                }
            }
            return null;
        }


        public static List<UserListDTO> GetAllUsers()
        {
            var UsersList = new List<UserListDTO>();
            using (SqlConnection con = new SqlConnection(DBConnection._connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SP_GetAllUsers", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            UsersList.Add(new UserListDTO(
                                reader.GetInt32(reader.GetOrdinal("UserID")),
                                reader["Username"]?.ToString() ?? "",
                                reader.GetBoolean(reader.GetOrdinal("IsActive")),
                                reader.GetDateTime(reader.GetOrdinal("CreatedAt")),
                                reader["FirstName"]?.ToString() ?? "",
                                reader["LastName"]?.ToString() ?? "",
                                reader.IsDBNull(reader.GetOrdinal("BirthDate")) ? DateTime.Today : reader.GetDateTime(reader.GetOrdinal("BirthDate")),
                                reader["PhoneNumber"]?.ToString() ?? "",
                                reader.IsDBNull(reader.GetOrdinal("NationalityID")) ? 0 : reader.GetInt32(reader.GetOrdinal("NationalityID")),
                                reader["NationalityName"]?.ToString() ?? "",
                                reader["Gender"]?.ToString() ?? "",
                                reader["RoleName"]?.ToString() ?? ""
                            ));
                        }
                    }
                }
            }
            return UsersList;
        }


        public static bool UpdateUser(UpdateUserDTO Dto)
        {
            using (SqlConnection con = new SqlConnection(DBConnection._connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SP_UpdateUser", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@UserID", Dto.UserID);
                    cmd.Parameters.AddWithValue("@UserName", Dto.UserName);
                    cmd.Parameters.AddWithValue("@PasswordHash", Dto.Password);
                    cmd.Parameters.AddWithValue("@IsActive", Dto.IsActive);
                    cmd.Parameters.AddWithValue("@FName", Dto.FName);
                    cmd.Parameters.AddWithValue("@LName", Dto.LName);
                    cmd.Parameters.AddWithValue("@BirthDate", Dto.BirthDate);
                    cmd.Parameters.AddWithValue("@PhoneNumber", Dto.PhoneNumber);
                    cmd.Parameters.AddWithValue("@NationalityID", Dto.NationalityID);
                    cmd.Parameters.AddWithValue("@Gender", Dto.Gender);
                    cmd.Parameters.AddWithValue("@RoleName", Dto.RoleName);
                    cmd.Parameters.AddWithValue("@ImagePath", string.IsNullOrWhiteSpace(Dto.ImagePath) ? (object)DBNull.Value : Dto.ImagePath);
                    con.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }


        public static bool IsUsernameExists(string username)
        {
            using (SqlConnection con = new SqlConnection(DBConnection._connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SP_IsUsernameExists", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Username", username);
                    con.Open();
                    return Convert.ToInt32(cmd.ExecuteScalar()) == 1;
                }
            }
        }


        public static UserLoginDTO AuthenticateUser(string username, string password)
        {
            using (SqlConnection con = new SqlConnection(DBConnection._connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SP_AuthenticateUser", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@PasswordHash", password);
                    con.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new UserLoginDTO(
                                reader.GetInt32(reader.GetOrdinal("UserID")),
                                reader.GetString(reader.GetOrdinal("FirstName")),
                                reader.GetString(reader.GetOrdinal("LastName")),
                                reader.GetBoolean(reader.GetOrdinal("IsActive")),
                                reader.GetString(reader.GetOrdinal("RoleName"))
                            );
                        }
                    }
                }
            }
            return null;
        }
    }
}