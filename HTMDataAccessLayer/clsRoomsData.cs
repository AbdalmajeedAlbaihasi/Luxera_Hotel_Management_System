using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Collections.Generic;
using HMSDataAccessLayer;

namespace HMSDataAccessLayer
{
    //DTOs
    public class AddNewRoomDTO
    {
        public AddNewRoomDTO(string roomNumber, int roomTypeID, string status, int capacity, decimal pricePerNight)
        {
            RoomNumber = roomNumber;
            RoomTypeID = roomTypeID;
            Status = status;
            Capacity = capacity;
            PricePerNight = pricePerNight;
        }

        public string RoomNumber { get; set; }
        public int RoomTypeID { get; set; }
        public string Status { get; set; }
        public int Capacity { get; set; }
        public decimal PricePerNight { get; set; }

    }

    public class RoomListDTO
    {
        public RoomListDTO(int roomID, string roomNumber, int roomTypeID, string roomTypeName, decimal price, int capacity, string status)
        {
            RoomID = roomID;
            RoomNumber = roomNumber;
            RoomTypeID = roomTypeID;
            RoomTypeName = roomTypeName;
            Price = price;
            Capacity = capacity;
            Status = status;
        }

        public int RoomID { get; set; }
        public string RoomNumber { get; set; }
        public int RoomTypeID { get; set; }
        public string RoomTypeName { get; set; }
        public decimal Price { get; set; }
        public int Capacity { get; set; }
        public string Status { get; set; }
    }

    public class UpdateRoomDTO
    {
        public UpdateRoomDTO(int roomID, string roomNumber, int roomTypeID, string status, int capacity, decimal pricePerNight)
        {
            RoomID = roomID;
            RoomNumber = roomNumber;
            RoomTypeID = roomTypeID;
            Status = status;
            Capacity = capacity;
            PricePerNight = pricePerNight;

        }

        public int RoomID { get; set; }
        public string RoomNumber { get; set; }
        public int RoomTypeID { get; set; }
        public string Status { get; set; }
        public int Capacity { get; set; }
        public decimal PricePerNight { get; set; }
    }





    public class clsRoomsData
    {
        public static List<RoomListDTO> GetAllRooms()
        {
            var list = new List<RoomListDTO>();

            using (SqlConnection con = new SqlConnection(DBConnection._connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SP_GetAllRooms", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list.Add(new RoomListDTO(
                                reader.GetInt32(reader.GetOrdinal("RoomID")),
                                reader.GetString(reader.GetOrdinal("RoomNumber")),
                                reader.GetInt32(reader.GetOrdinal("RoomTypeID")),
                                reader.GetString(reader.GetOrdinal("TypeName")),
                                reader.GetDecimal(reader.GetOrdinal("PricePerNight")),
                                reader.GetInt32(reader.GetOrdinal("Capacity")),
                                reader.GetString(reader.GetOrdinal("Status"))
                            ));
                        }
                    }
                }
            }

            return list;
        }

        public static RoomListDTO GetRoomByID(int roomID)
        {
            using (SqlConnection con = new SqlConnection(DBConnection._connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SP_GetRoomByID", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@RoomID", roomID);

                    con.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new RoomListDTO(
                                reader.GetInt32(reader.GetOrdinal("RoomID")),
                                reader.GetString(reader.GetOrdinal("RoomNumber")),
                                reader.GetInt32(reader.GetOrdinal("RoomTypeID")),
                                reader.GetString(reader.GetOrdinal("TypeName")),
                                reader.GetDecimal(reader.GetOrdinal("PricePerNight")),
                                reader.GetInt32(reader.GetOrdinal("Capacity")),
                                reader.GetString(reader.GetOrdinal("Status"))
                            );
                        }
                    }
                }
            }

            return null;
        }

        public static int AddNewRoom(AddNewRoomDTO dto)
        {
            using (SqlConnection con = new SqlConnection(DBConnection._connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SP_AddNewRoom", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@RoomNumber", dto.RoomNumber);
                    cmd.Parameters.AddWithValue("@RoomTypeID", dto.RoomTypeID);
                    cmd.Parameters.AddWithValue("@Status", dto.Status);
                    cmd.Parameters.AddWithValue("@Capacity", dto.Capacity);
                    cmd.Parameters.AddWithValue("@PricePerNight", dto.PricePerNight);

                    SqlParameter outputId = new SqlParameter("@NewRoomID", SqlDbType.Int)
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

        public static bool UpdateRoom(UpdateRoomDTO dto)
        {
            using (SqlConnection con = new SqlConnection(DBConnection._connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SP_UpdateRoom", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@RoomNumber", dto.RoomNumber);
                    cmd.Parameters.AddWithValue("@RoomID", dto.RoomID);
                    cmd.Parameters.AddWithValue("@RoomTypeID", dto.RoomTypeID);
                    cmd.Parameters.AddWithValue("@Status", dto.Status);
                    cmd.Parameters.AddWithValue("@Capacity", dto.Capacity);
                    cmd.Parameters.AddWithValue("@PricePerNight", dto.PricePerNight);

                    con.Open();


                    cmd.ExecuteNonQuery();
                    return true;
                }
            }
        }

        public static bool DeleteRoom(int roomID)
        {
            using (SqlConnection con = new SqlConnection(DBConnection._connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SP_DeleteRoom", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@RoomID", roomID);

                    con.Open();

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public static bool IsRoomNumberExists(string roomNumber)
        {
            using (SqlConnection con = new SqlConnection(DBConnection._connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SP_IsRoomNumberExists", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@RoomNumber", roomNumber);

                    con.Open();

                    object result = cmd.ExecuteScalar();
                    return result != null && Convert.ToInt32(result) == 1;
                }
            }
        }
    }
}
