using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Collections.Generic;
using HMSDataAccessLayer;

namespace HMSDataAccessLayer
{
    //DTOs
    public class AddNewRoomTypeDTO
    {
        public AddNewRoomTypeDTO(string typeName)
        {
            TypeName = typeName;
        }

        public string TypeName { get; set; }
    }

    public class RoomTypeListDTO
    {
        public RoomTypeListDTO(int roomTypeID, string typeName)
        {
            RoomTypeID = roomTypeID;
            TypeName = typeName;
        }

        public int RoomTypeID { get; set; }
        public string TypeName { get; set; }
    }

    public class UpdateRoomTypeDTO
    {
        public UpdateRoomTypeDTO(int roomTypeID, string typeName)
        {
            RoomTypeID = roomTypeID;
            TypeName = typeName;
        }

        public int RoomTypeID { get; set; }
        public string TypeName { get; set; }
    }







    public class clsRoomTypesData
    {
        public static List<RoomTypeListDTO> GetAllRoomTypes()
        {
            var list = new List<RoomTypeListDTO>();

            using (SqlConnection con = new SqlConnection(DBConnection._connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SP_GetAllRoomTypes", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list.Add(new RoomTypeListDTO(
                                reader.GetInt32(reader.GetOrdinal("RoomTypeID")),
                                reader.GetString(reader.GetOrdinal("TypeName"))
                            ));
                        }
                    }
                }
            }

            return list;
        }

        public static RoomTypeListDTO GetRoomTypeByID(int roomTypeID)
        {
            using (SqlConnection con = new SqlConnection(DBConnection._connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SP_GetRoomTypeByID", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@RoomTypeID", roomTypeID);

                    con.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new RoomTypeListDTO(
                                reader.GetInt32(reader.GetOrdinal("RoomTypeID")),
                                reader.GetString(reader.GetOrdinal("TypeName"))
                            );
                        }
                    }
                }
            }

            return null;
        }

        public static RoomTypeListDTO GetRoomTypeByName(string typeName)
        {
            using (SqlConnection con = new SqlConnection(DBConnection._connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SP_GetRoomTypeByName", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@TypeName", typeName);

                    con.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new RoomTypeListDTO(
                                reader.GetInt32(reader.GetOrdinal("RoomTypeID")),
                                reader.GetString(reader.GetOrdinal("TypeName"))
                            );
                        }
                    }
                }
            }

            return null;
        }

        public static int AddNewRoomType(AddNewRoomTypeDTO dto)
        {
            using (SqlConnection con = new SqlConnection(DBConnection._connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SP_AddNewRoomType", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@TypeName", dto.TypeName);

                    SqlParameter outputId = new SqlParameter("@NewRoomTypeID", SqlDbType.Int)
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

        public static bool UpdateRoomType(UpdateRoomTypeDTO dto)
        {
            using (SqlConnection con = new SqlConnection(DBConnection._connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SP_UpdateRoomType", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@RoomTypeID", dto.RoomTypeID);
                    cmd.Parameters.AddWithValue("@TypeName", dto.TypeName);

                    con.Open();

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public static bool DeleteRoomType(int roomTypeID)
        {
            using (SqlConnection con = new SqlConnection(DBConnection._connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SP_DeleteRoomType", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@RoomTypeID", roomTypeID);

                    con.Open();

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public static bool IsRoomTypeNameExists(string typeName)
        {
            using (SqlConnection con = new SqlConnection(DBConnection._connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SP_IsRoomTypeNameExists", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@TypeName", typeName);

                    con.Open();

                    object result = cmd.ExecuteScalar();
                    return result != null && Convert.ToInt32(result) == 1;
                }
            }
        }
    }
}
