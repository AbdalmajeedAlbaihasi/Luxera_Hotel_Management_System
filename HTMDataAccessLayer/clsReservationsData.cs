using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using HMSShared.DTOs.Reservations;

namespace HMSDataAccessLayer
{
    public class clsReservationsData
    {
        public static List<ReservationListDTO> GetAllReservations()
        {
            var list = new List<ReservationListDTO>();

            using (SqlConnection con = new SqlConnection(DBConnection._connectionString))
            using (SqlCommand cmd = new SqlCommand("SP_GetAllReservations", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new ReservationListDTO(
                            reader.GetInt32(reader.GetOrdinal("ReservationID")),
                            reader.GetInt32(reader.GetOrdinal("RoomID")),
                            reader["RoomNumber"]?.ToString() ?? "",
                            reader.GetInt32(reader.GetOrdinal("ClientId")),
                            reader["ClientName"]?.ToString() ?? "",
                            reader.GetInt32(reader.GetOrdinal("UserID")),
                            reader["CreatedByUser"]?.ToString() ?? "",
                            reader.IsDBNull(reader.GetOrdinal("CheckInDate")) ? DateTime.MinValue : reader.GetDateTime(reader.GetOrdinal("CheckInDate")),
                            reader.IsDBNull(reader.GetOrdinal("CheckOutDate")) ? DateTime.MinValue : reader.GetDateTime(reader.GetOrdinal("CheckOutDate")),
                            reader.IsDBNull(reader.GetOrdinal("Status")) ? string.Empty : reader.GetString(reader.GetOrdinal("Status"))
                        ));
                    }
                }
            }

            return list;
        }

        public static OneReservationListDTO GetReservationByID(int reservationID)
        {
            using (SqlConnection con = new SqlConnection(DBConnection._connectionString))
            using (SqlCommand cmd = new SqlCommand("SP_GetReservationByID", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ReservationID", reservationID);

                con.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new OneReservationListDTO(
                            reader.GetInt32(reader.GetOrdinal("ReservationID")),
                            reader.GetInt32(reader.GetOrdinal("RoomID")),
                            reader.GetInt32(reader.GetOrdinal("ClientId")),
                            reader.GetInt32(reader.GetOrdinal("UserID")),
                            reader.GetDateTime(reader.GetOrdinal("CheckInDate")),
                            reader.GetDateTime(reader.GetOrdinal("CheckOutDate")),
                            reader.GetString(reader.GetOrdinal("Status"))
                        );
                    }
                }
            }

            return null;
        }

        public static int AddNewReservation(AddNewReservationDTO dto)
        {
            using (SqlConnection con = new SqlConnection(DBConnection._connectionString))
            using (SqlCommand cmd = new SqlCommand("SP_AddNewReservation", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@RoomID", dto.RoomID);
                cmd.Parameters.AddWithValue("@ClientId", dto.ClientId);
                cmd.Parameters.AddWithValue("@UserID", dto.CreatedByUserID);
                cmd.Parameters.AddWithValue("@CheckInDate", dto.CheckInDate);
                cmd.Parameters.AddWithValue("@CheckOutDate", dto.CheckOutDate);
                cmd.Parameters.AddWithValue("@Status", dto.Status);

                SqlParameter outputId = new SqlParameter("@NewReservationID", SqlDbType.Int)
                {
                    Direction = ParameterDirection.Output
                };

                cmd.Parameters.Add(outputId);

                con.Open();
                cmd.ExecuteNonQuery();

                return outputId.Value != DBNull.Value ? (int)outputId.Value : -1;
            }
        }

        public static bool UpdateReservation(UpdateReservationDTO dto)
        {
            using (SqlConnection con = new SqlConnection(DBConnection._connectionString))
            using (SqlCommand cmd = new SqlCommand("SP_UpdateReservation", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@ReservationID", dto.ReservationID);
                cmd.Parameters.AddWithValue("@RoomID", dto.RoomID);
                cmd.Parameters.AddWithValue("@ClientId", dto.ClientId);
                cmd.Parameters.AddWithValue("@UserID", dto.CreatedByUserID);
                cmd.Parameters.AddWithValue("@CheckInDate", dto.CheckInDate);
                cmd.Parameters.AddWithValue("@CheckOutDate", dto.CheckOutDate);
                cmd.Parameters.AddWithValue("@Status", dto.Status);

                con.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public static bool DeleteReservation(int reservationID)
        {
            using (SqlConnection con = new SqlConnection(DBConnection._connectionString))
            using (SqlCommand cmd = new SqlCommand("SP_DeleteReservation", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ReservationID", reservationID);

                con.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public static bool IsRoomAvailable(int roomID, DateTime checkInDate, DateTime checkOutDate)
        {
            using (SqlConnection con = new SqlConnection(DBConnection._connectionString))
            using (SqlCommand cmd = new SqlCommand("SP_IsRoomAvailable", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@RoomID", roomID);
                cmd.Parameters.AddWithValue("@CheckInDate", checkInDate);
                cmd.Parameters.AddWithValue("@CheckOutDate", checkOutDate);

                con.Open();

                object result = cmd.ExecuteScalar();
                return result != null && Convert.ToInt32(result) == 1;
            }
        }

        public static bool IsRoomAvailableForUpdate(int reservationID, int roomID, DateTime checkInDate, DateTime checkOutDate)
        {
            using (SqlConnection con = new SqlConnection(DBConnection._connectionString))
            using (SqlCommand cmd = new SqlCommand("SP_IsRoomAvailableForUpdate", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@ReservationID", reservationID);
                cmd.Parameters.AddWithValue("@RoomID", roomID);
                cmd.Parameters.AddWithValue("@CheckInDate", checkInDate);
                cmd.Parameters.AddWithValue("@CheckOutDate", checkOutDate);

                con.Open();

                object result = cmd.ExecuteScalar();
                return result != null && Convert.ToInt32(result) == 1;
            }
        }

        public static List<RoomNumberDTO> GetRoomNumbers()
        {
            var list = new List<RoomNumberDTO>();

            using (SqlConnection con = new SqlConnection(DBConnection._connectionString))
            using (SqlCommand cmd = new SqlCommand("SP_GetRoomNumbers", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                con.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new RoomNumberDTO(
                            reader.GetInt32(reader.GetOrdinal("RoomID")),
                            reader.GetString(reader.GetOrdinal("RoomNumber"))
                        ));
                    }
                }
            }

            return list;
        }

        public static List<RoomAvailabilityInfoDTO> GetRoomTimelineData(DateTime startDate, DateTime endDate)
        {
            var dataList = new List<RoomAvailabilityInfoDTO>();

            using (SqlConnection con = new SqlConnection(DBConnection._connectionString))
            using (SqlCommand cmd = new SqlCommand("SP_GetHotelRoomTimeline", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@StartDate", startDate);
                cmd.Parameters.AddWithValue("@EndDate", endDate);

                con.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        dataList.Add(new RoomAvailabilityInfoDTO
                        {
                            RoomID = (int)reader["RoomID"],
                            RoomNumber = reader["RoomNumber"]?.ToString() ?? "",
                            RoomType = reader["TypeName"]?.ToString() ?? "",
                            PricePerNight = reader["PricePerNight"] != DBNull.Value
                                            ? Convert.ToDecimal(reader["PricePerNight"])
                                            : 0,
                            RoomCurrentStatus = reader["RoomCurrentStatus"]?.ToString() ?? "",

                            ReservationID = reader["ReservationID"] != DBNull.Value ? (int?)reader["ReservationID"] : null,
                            GuestName = reader["CustomerName"]?.ToString(),
                            CheckInDate = reader["CheckInDate"] != DBNull.Value ? (DateTime?)reader["CheckInDate"] : null,
                            CheckOutDate = reader["CheckOutDate"] != DBNull.Value ? (DateTime?)reader["CheckOutDate"] : null,
                            ReservationStatus = reader["ReservationStatus"]?.ToString() ?? "",
                        });
                    }
                }
            }

            return dataList;
        }
    }
}

