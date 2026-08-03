using Microsoft.Data.SqlClient;
using System;
using System.Data;
using HMSShared.DTOs.Payments;


namespace HMSDataAccessLayer
{
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
