using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Collections.Generic;
using HMSDataAccessLayer;

namespace HMSDataAccessLayer
{
    public class AddNewRoleDTO
    {
        public AddNewRoleDTO(string roleName)
        {
            RoleName = roleName;
        }

        public string RoleName { get; set; }
    }

    public class RoleListDTO
    {
        public RoleListDTO(int roleID, string roleName)
        {
            RoleID = roleID;
            RoleName = roleName;
        }

        public int RoleID { get; set; }
        public string RoleName { get; set; }
    }

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

    public class clsRolesData
    {
        public static List<RoleListDTO> GetAllRoles()
        {
            var list = new List<RoleListDTO>();

            using (SqlConnection con = new SqlConnection(DBConnection._connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SP_GetAllRoles", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list.Add(new RoleListDTO(
                                reader.GetInt32(reader.GetOrdinal("RoleID")),
                                reader.GetString(reader.GetOrdinal("RoleName"))
                            ));
                        }
                    }
                }
            }

            return list;
        }

        public static RoleListDTO GetRoleByID(int roleID)
        {
            using (SqlConnection con = new SqlConnection(DBConnection._connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SP_GetRoleByID", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@RoleID", roleID);

                    con.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new RoleListDTO(
                                reader.GetInt32(reader.GetOrdinal("RoleID")),
                                reader.GetString(reader.GetOrdinal("RoleName"))
                            );
                        }
                    }
                }
            }

            return null;
        }

        public static RoleListDTO GetRoleByName(string roleName)
        {
            using (SqlConnection con = new SqlConnection(DBConnection._connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SP_GetRoleByName", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@RoleName", roleName);

                    con.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new RoleListDTO(
                                reader.GetInt32(reader.GetOrdinal("RoleID")),
                                reader.GetString(reader.GetOrdinal("RoleName"))
                            );
                        }
                    }
                }
            }

            return null;
        }

        public static int AddNewRole(AddNewRoleDTO dto)
        {
            using (SqlConnection con = new SqlConnection(DBConnection._connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SP_AddNewRole", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@RoleName", dto.RoleName);

                    SqlParameter outputId = new SqlParameter("@NewRoleID", SqlDbType.Int)
                    {
                        Direction = ParameterDirection.Output
                    };

                    cmd.Parameters.Add(outputId);

                    con.Open();
                    cmd.ExecuteNonQuery();

                    return outputId.Value != DBNull.Value ? (int)outputId.Value : -1;
                }
            }
        }

        public static bool UpdateRole(UpdateRoleDTO dto)
        {
            using (SqlConnection con = new SqlConnection(DBConnection._connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SP_UpdateRole", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@RoleID", dto.RoleID);
                    cmd.Parameters.AddWithValue("@RoleName", dto.RoleName);

                    con.Open();

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public static bool DeleteRole(int roleID)
        {
            using (SqlConnection con = new SqlConnection(DBConnection._connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SP_DeleteRole", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@RoleID", roleID);

                    con.Open();

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public static bool IsRoleNameExists(string roleName)
        {
            using (SqlConnection con = new SqlConnection(DBConnection._connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SP_IsRoleNameExists", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@RoleName", roleName);

                    con.Open();

                    object result = cmd.ExecuteScalar();
                    return result != null && Convert.ToInt32(result) == 1;
                }
            }
        }
    }
}
