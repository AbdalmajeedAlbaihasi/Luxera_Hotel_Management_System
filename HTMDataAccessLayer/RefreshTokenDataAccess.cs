using Microsoft.Data.SqlClient;
using System;
using System.Data;
using HMSShared.DTOs.RefreshTokens;

namespace HMSDataAccessLayer
{
    public class RefreshTokenDataAccess
    {

        public bool AddRefreshToken(RefreshTokenDTO refreshToken)
        {
            bool result = false;


            using (SqlConnection connection = new SqlConnection(DBConnection._connectionString))
            {

                using (SqlCommand command = new SqlCommand("SP_InsertRefreshToken", connection))
                {

                    command.CommandType = CommandType.StoredProcedure;


                    command.Parameters.AddWithValue("@UserID", refreshToken.UserID);

                    command.Parameters.AddWithValue("@Token", refreshToken.Token);

                    command.Parameters.AddWithValue("@ExpirationDate",
                        refreshToken.ExpirationDate);


                    connection.Open();


                    int rows = command.ExecuteNonQuery();


                    if (rows > 0)
                    {
                        result = true;
                    }

                }

            }


            return result;
        }



        public RefreshTokenDTO GetRefreshToken(string token)
        {

            RefreshTokenDTO refreshToken = null;


            using (SqlConnection connection =
                new SqlConnection(DBConnection._connectionString))
            {


                using (SqlCommand command =
                    new SqlCommand("SP_GetRefreshToken", connection))
                {


                    command.CommandType = CommandType.StoredProcedure;


                    command.Parameters.AddWithValue("@Token", token);



                    connection.Open();



                    using (SqlDataReader reader = command.ExecuteReader())
                    {

                        if (reader.Read())
                        {

                            refreshToken = new RefreshTokenDTO
                            {

                                RefreshTokenID =
                                Convert.ToInt32(reader["RefreshTokenID"]),


                                UserID =
                                Convert.ToInt32(reader["UserID"]),


                                Token =
                                reader["Token"].ToString(),


                                CreatedAt =
                                Convert.ToDateTime(reader["CreatedAt"]),


                                ExpirationDate =
                                Convert.ToDateTime(reader["ExpirationDate"]),


                                RevokedAt =
                                reader["RevokedAt"] == DBNull.Value
                                ? null
                                : Convert.ToDateTime(reader["RevokedAt"]),


                                IsRevoked =
                                Convert.ToBoolean(reader["IsRevoked"])

                            };

                        }

                    }

                }

            }



            return refreshToken;

        }




        public bool RevokeRefreshToken(string token)
        {

            bool result = false;


            using (SqlConnection connection =
                new SqlConnection(DBConnection._connectionString))
            {


                using (SqlCommand command =
                    new SqlCommand("SP_RevokeRefreshToken", connection))
                {


                    command.CommandType = CommandType.StoredProcedure;


                    command.Parameters.AddWithValue("@Token", token);



                    connection.Open();


                    int rows = command.ExecuteNonQuery();


                    if (rows > 0)
                    {
                        result = true;
                    }


                }

            }


            return result;

        }





    }
}