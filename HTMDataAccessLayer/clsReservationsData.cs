using HMSDataAccessLayer;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace HMSDataAccessLayer
{
    // DTOs
    public class AddNewReservationDTO
    {
        public AddNewReservationDTO(int roomID, int clientId, int createdByUserID,
            DateTime checkInDate, DateTime checkOutDate, string status)
        {
            RoomID = roomID;
            ClientId = clientId;
            CreatedByUserID = createdByUserID;
            CheckInDate = checkInDate;
            CheckOutDate = checkOutDate;
            Status = status;
        }

        public int RoomID { get; set; }
        public int ClientId { get; set; }
        public int CreatedByUserID { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
        public string Status { get; set; }
    }

    public class ReservationListDTO
    {
        public ReservationListDTO(int reservationID, int roomID, string roomNumber,
            int clientId, string clientName, int userID, string createdByUser,
            DateTime checkInDate, DateTime checkOutDate, string status)
        {
            ReservationID = reservationID;
            RoomID = roomID;
            RoomNumber = roomNumber;
            ClientId = clientId;
            ClientName = clientName;
            UserID = userID;
            CreatedByUser = createdByUser;
            CheckInDate = checkInDate;
            CheckOutDate = checkOutDate;
            Status = status;
        }

        public int ReservationID { get; set; }
        public int RoomID { get; set; }
        public string RoomNumber { get; set; }
        public int ClientId { get; set; }
        public string ClientName { get; set; }
        public int UserID { get; set; }
        public string CreatedByUser { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
        public string Status { get; set; }
    }

    public class OneReservationListDTO
    {
        public OneReservationListDTO(int reservationID, int roomID, int clientId, int userID,
            DateTime checkInDate, DateTime checkOutDate, string status)
        {
            ReservationID = reservationID;
            RoomID = roomID;
            ClientId = clientId;
            UserID = userID;
            CheckInDate = checkInDate;
            CheckOutDate = checkOutDate;
            Status = status;
        }

        public int ReservationID { get; set; }
        public int RoomID { get; set; }
        public int ClientId { get; set; }
        public int UserID { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
        public string Status { get; set; }
    }

    public class UpdateReservationDTO
    {
        public UpdateReservationDTO(int reservationID, int roomID, int clientId, int createdByUserID,
            DateTime checkInDate, DateTime checkOutDate, string status)
        {
            ReservationID = reservationID;
            RoomID = roomID;
            ClientId = clientId;
            CreatedByUserID = createdByUserID;
            CheckInDate = checkInDate;
            CheckOutDate = checkOutDate;
            Status = status;
        }

        public int ReservationID { get; set; }
        public int RoomID { get; set; }
        public int ClientId { get; set; }
        public int CreatedByUserID { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
        public string Status { get; set; }
    }

    public class RoomNumberDTO
    {
        public RoomNumberDTO(int roomID, string roomNumber)
        {
            RoomID = roomID;
            RoomNumber = roomNumber;
        }

        public int RoomID { get; set; }
        public string RoomNumber { get; set; }
    }

    public class RoomTimelineDTO
    {
        public class RoomAvailabilityInfo
        {
            public int RoomID { get; set; }
            public string RoomNumber { get; set; }
            public string RoomType { get; set; }
            public decimal PricePerNight { get; set; }
            public string RoomCurrentStatus { get; set; }

            public int? ReservationID { get; set; }
            public string GuestName { get; set; }
            public DateTime? CheckInDate { get; set; }
            public DateTime? CheckOutDate { get; set; }
            public string ReservationStatus { get; set; }
        }
    }









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

        public static List<RoomTimelineDTO.RoomAvailabilityInfo> GetRoomTimelineData(DateTime startDate, DateTime endDate)
        {
            var dataList = new List<RoomTimelineDTO.RoomAvailabilityInfo>();

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
                        dataList.Add(new RoomTimelineDTO.RoomAvailabilityInfo
                        {
                            RoomID = (int)reader["RoomID"],
                            RoomNumber = reader["RoomNumber"].ToString(),
                            RoomType = reader["TypeName"].ToString(),
                            PricePerNight = (decimal)reader["PricePerNight"],
                            RoomCurrentStatus = reader["RoomCurrentStatus"].ToString(),

                            ReservationID = reader["ReservationID"] != DBNull.Value ? (int?)reader["ReservationID"] : null,
                            GuestName = reader["CustomerName"]?.ToString(),
                            CheckInDate = reader["CheckInDate"] != DBNull.Value ? (DateTime?)reader["CheckInDate"] : null,
                            CheckOutDate = reader["CheckOutDate"] != DBNull.Value ? (DateTime?)reader["CheckOutDate"] : null,
                            ReservationStatus = reader["ReservationStatus"]?.ToString()
                        });
                    }
                }
            }

            return dataList;
        }
    }
}