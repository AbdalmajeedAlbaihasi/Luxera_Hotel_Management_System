using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Collections.Generic;
using HMSDataAccessLayer;

namespace HMSDataAccessLayer
{
    public class AddNewNationalityDTO
    {
        public AddNewNationalityDTO(string nationalityName)
        {
            NationalityName = nationalityName;
        }

        public string NationalityName { get; set; }
    }

    public class NationalityListDTO
    {
        public NationalityListDTO(int nationalityID, string nationalityName)
        {
            NationalityID = nationalityID;
            NationalityName = nationalityName;
        }

        public int NationalityID { get; set; }
        public string NationalityName { get; set; }
    }

    public class UpdateNationalityDTO
    {
        public UpdateNationalityDTO(int nationalityID, string nationalityName)
        {
            NationalityID = nationalityID;
            NationalityName = nationalityName;
        }

        public int NationalityID { get; set; }
        public string NationalityName { get; set; }
    }

    public class clsNationalitiesData
    {
        public static List<NationalityListDTO> GetAllNationalities()
        {
            var list = new List<NationalityListDTO>();

            using (SqlConnection con = new SqlConnection(DBConnection._connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SP_GetAllNationalities", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list.Add(new NationalityListDTO(
                                reader.GetInt32(reader.GetOrdinal("NationalityID")),
                                reader.GetString(reader.GetOrdinal("NationalityName"))
                            ));
                        }
                    }
                }
            }

            return list;
        }

        public static NationalityListDTO GetNationalityByID(int nationalityID)
        {
            using (SqlConnection con = new SqlConnection(DBConnection._connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SP_GetNationalityByID", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@NationalityID", nationalityID);

                    con.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new NationalityListDTO(
                                reader.GetInt32(reader.GetOrdinal("NationalityID")),
                                reader.GetString(reader.GetOrdinal("NationalityName"))
                            );
                        }
                    }
                }
            }

            return null;
        }

        public static NationalityListDTO GetNationalityByName(string nationalityName)
        {
            using (SqlConnection con = new SqlConnection(DBConnection._connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SP_GetNationalityByName", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@NationalityName", nationalityName);

                    con.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new NationalityListDTO(
                                reader.GetInt32(reader.GetOrdinal("NationalityID")),
                                reader.GetString(reader.GetOrdinal("NationalityName"))
                            );
                        }
                    }
                }
            }

            return null;
        }

        public static int AddNewNationality(AddNewNationalityDTO dto)
        {
            using (SqlConnection con = new SqlConnection(DBConnection._connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SP_AddNewNationality", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@NationalityName", dto.NationalityName);

                    SqlParameter outputId = new SqlParameter("@NewNationalityID", SqlDbType.Int)
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

        public static bool UpdateNationality(UpdateNationalityDTO dto)
        {
            using (SqlConnection con = new SqlConnection(DBConnection._connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SP_UpdateNationality", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@NationalityID", dto.NationalityID);
                    cmd.Parameters.AddWithValue("@NationalityName", dto.NationalityName);

                    con.Open();

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public static bool DeleteNationality(int nationalityID)
        {
            using (SqlConnection con = new SqlConnection(DBConnection._connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SP_DeleteNationality", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@NationalityID", nationalityID);

                    con.Open();

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public static bool IsNationalityNameExists(string nationalityName)
        {
            using (SqlConnection con = new SqlConnection(DBConnection._connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SP_IsNationalityNameExists", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@NationalityName", nationalityName);

                    con.Open();

                    object result = cmd.ExecuteScalar();
                    return result != null && Convert.ToInt32(result) == 1;
                }
            }
        }
    }
}
