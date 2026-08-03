using Microsoft.Data.SqlClient;
using System;
using HMSShared.DTOs.Users;
using System.Data;

namespace HMSDataAccessLayer
{
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
                    cmd.Parameters.AddWithValue(
                        "@PasswordHash",
                        string.IsNullOrWhiteSpace(Dto.Password)
                            ? (object)DBNull.Value
                            : Dto.Password
                    );
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



        public static UserLoginDTO AuthenticateUser(string username)
        {
            using (SqlConnection con = new SqlConnection(DBConnection._connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SP_AuthenticateUser", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Username", username);
                    con.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new UserLoginDTO(
                                reader.GetInt32(reader.GetOrdinal("UserID")),
                                reader.GetString(reader.GetOrdinal("userName")),
                                reader.GetBoolean(reader.GetOrdinal("IsActive")),
                                reader.GetString(reader.GetOrdinal("RoleName")),
                                reader.GetString(reader.GetOrdinal("PasswordHash"))
                            );
                        }
                    }
                }
            }
            return null;
        }
    }
}