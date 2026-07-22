using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Collections.Generic;
using HMSDataAccessLayer;

namespace HMSDataAccessLayer
{
    public class AddNewPaymentDTO
    {
        public AddNewPaymentDTO(int reservationID, decimal amount, string paymentMethod)
        {
            ReservationID = reservationID;
            Amount = amount;
            PaymentMethod = paymentMethod;
        }

        public int ReservationID { get; set; }
        public decimal Amount { get; set; }
        public string PaymentMethod { get; set; }
    }

    public class PaymentListDTO
    {
        public PaymentListDTO(int paymentID, int reservationID, decimal amount, string paymentMethod, DateTime paymentDate)
        {
            PaymentID = paymentID;
            ReservationID = reservationID;
            Amount = amount;
            PaymentMethod = paymentMethod;
            PaymentDate = paymentDate;
        }

        public int PaymentID { get; set; }
        public int ReservationID { get; set; }
        public decimal Amount { get; set; }
        public string PaymentMethod { get; set; }
        public DateTime PaymentDate { get; set; }
    }

    public class UpdatePaymentDTO
    {
        public UpdatePaymentDTO(int paymentID, int reservationID, decimal amount, string paymentMethod)
        {
            PaymentID = paymentID;
            ReservationID = reservationID;
            Amount = amount;
            PaymentMethod = paymentMethod;
        }

        public int PaymentID { get; set; }
        public int ReservationID { get; set; }
        public decimal Amount { get; set; }
        public string PaymentMethod { get; set; }
    }

    public class clsPaymentsData
    {
        public static List<PaymentListDTO> GetAllPayments()
        {
            var list = new List<PaymentListDTO>();

            using (SqlConnection con = new SqlConnection(DBConnection._connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SP_GetAllPayments", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list.Add(new PaymentListDTO(
                                reader.GetInt32(reader.GetOrdinal("PaymentID")),
                                reader.GetInt32(reader.GetOrdinal("ReservationID")),
                                reader.GetDecimal(reader.GetOrdinal("Amount")),
                                reader.GetString(reader.GetOrdinal("PaymentMethod")),
                                reader.GetDateTime(reader.GetOrdinal("PaymentDate"))
                            ));
                        }
                    }
                }
            }

            return list;
        }

        public static PaymentListDTO GetPaymentByID(int paymentID)
        {
            using (SqlConnection con = new SqlConnection(DBConnection._connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SP_GetPaymentByID", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@PaymentID", paymentID);

                    con.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new PaymentListDTO(
                                reader.GetInt32(reader.GetOrdinal("PaymentID")),
                                reader.GetInt32(reader.GetOrdinal("ReservationID")),
                                reader.GetDecimal(reader.GetOrdinal("Amount")),
                                reader.GetString(reader.GetOrdinal("PaymentMethod")),
                                reader.GetDateTime(reader.GetOrdinal("PaymentDate"))
                            );
                        }
                    }
                }
            }

            return null;
        }

        public static List<PaymentListDTO> GetPaymentsByReservationID(int reservationID)
        {
            var list = new List<PaymentListDTO>();

            using (SqlConnection con = new SqlConnection(DBConnection._connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SP_GetPaymentsByReservationID", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ReservationID", reservationID);

                    con.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list.Add(new PaymentListDTO(
                                reader.GetInt32(reader.GetOrdinal("PaymentID")),
                                reader.GetInt32(reader.GetOrdinal("ReservationID")),
                                reader.GetDecimal(reader.GetOrdinal("Amount")),
                                reader.GetString(reader.GetOrdinal("PaymentMethod")),
                                reader.GetDateTime(reader.GetOrdinal("PaymentDate"))
                            ));
                        }
                    }
                }
            }

            return list;
        }

        public static int AddNewPayment(AddNewPaymentDTO dto)
        {
            using (SqlConnection con = new SqlConnection(DBConnection._connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SP_AddNewPayment", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@ReservationID", dto.ReservationID);
                    cmd.Parameters.AddWithValue("@Amount", dto.Amount);
                    cmd.Parameters.AddWithValue("@PaymentMethod", dto.PaymentMethod);

                    SqlParameter outputId = new SqlParameter("@NewPaymentID", SqlDbType.Int)
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

        public static bool UpdatePayment(UpdatePaymentDTO dto)
        {
            using (SqlConnection con = new SqlConnection(DBConnection._connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SP_UpdatePayment", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@PaymentID", dto.PaymentID);
                    cmd.Parameters.AddWithValue("@ReservationID", dto.ReservationID);
                    cmd.Parameters.AddWithValue("@Amount", dto.Amount);
                    cmd.Parameters.AddWithValue("@PaymentMethod", dto.PaymentMethod);

                    con.Open();

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public static bool DeletePayment(int paymentID)
        {
            using (SqlConnection con = new SqlConnection(DBConnection._connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SP_DeletePayment", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@PaymentID", paymentID);

                    con.Open();

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }
    }
}
