using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Collections.Generic;
using HMSDataAccessLayer;

namespace HMSDataAccessLayer
{
    // DTOs
    public class ClientNameAndIDDTO
    {
        public ClientNameAndIDDTO(int clientID, string firstName, string lastName)
        {
            ClientID = clientID;
            FirstName = firstName;
            LastName = lastName;
        }
        public int ClientID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    public class AddNewClientDTO
    {
        public AddNewClientDTO(int createdByUserID, string firstName, string lastName, DateTime birthDate, int nationalityID, string phoneNumber, string gender)
        {
            CreatedByUserID = createdByUserID;
            FirstName = firstName;
            LastName = lastName;
            BirthDate = birthDate;
            NationalityID = nationalityID;
            PhoneNumber = phoneNumber;
            Gender = gender;
        }

        public int CreatedByUserID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public int NationalityID { get; set; }
        public string PhoneNumber { get; set; }
        public string Gender { get; set; }
    }

    public class ClientListDTO
    {
        public ClientListDTO(int clientID, int createdByUserID, string firstName, string lastName, DateTime birthDate, int nationalityID, string phoneNumber, string gender, DateTime createdAt)
        {
            ClientID = clientID;
            CreatedByUserID = createdByUserID;
            FirstName = firstName;
            LastName = lastName;
            BirthDate = birthDate;
            NationalityID = nationalityID;
            PhoneNumber = phoneNumber;
            Gender = gender;
            CreatedAt = createdAt;
        }

        public int ClientID { get; set; }
        public int CreatedByUserID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public int NationalityID { get; set; }
        public string PhoneNumber { get; set; }
        public string Gender { get; set; }
        public DateTime CreatedAt { get; set; }
    }

    public class UpdateClientDTO
    {
        public UpdateClientDTO(int clientID, int createdByUserID, string firstName, string lastName, DateTime birthDate, int nationalityID, string phoneNumber, string gender)
        {
            ClientID = clientID;
            CreatedByUserID = createdByUserID;
            FirstName = firstName;
            LastName = lastName;
            BirthDate = birthDate;
            NationalityID = nationalityID;
            PhoneNumber = phoneNumber;
            Gender = gender;
        }

        public int ClientID { get; set; }
        public int CreatedByUserID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public int NationalityID { get; set; }
        public string PhoneNumber { get; set; }
        public string Gender { get; set; }
    }




    public class clsClientsData
    {
        public static List<ClientListDTO> GetAllClients()
        {
            var list = new List<ClientListDTO>();

            using (SqlConnection con = new SqlConnection(DBConnection._connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SP_GetAllClients", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list.Add(new ClientListDTO(
                                reader.GetInt32(reader.GetOrdinal("ClientID")),
                                reader.GetInt32(reader.GetOrdinal("UserID")),
                                reader.GetString(reader.GetOrdinal("FirstName")),
                                reader.GetString(reader.GetOrdinal("LastName")),
                                reader.GetDateTime(reader.GetOrdinal("BirthDate")),
                                reader.GetInt32(reader.GetOrdinal("NationalityID")),
                                reader.GetString(reader.GetOrdinal("PhoneNumber")),
                                reader.GetString(reader.GetOrdinal("Gender")),
                                reader.GetDateTime(reader.GetOrdinal("CreatedAt"))
                            ));
                        }
                    }
                }
            }

            return list;
        }

        public static ClientListDTO GetClientByID(int clientID)
        {
            using (SqlConnection con = new SqlConnection(DBConnection._connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SP_GetClientByID", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ClientID", clientID);

                    con.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new ClientListDTO(
                                reader.GetInt32(reader.GetOrdinal("ClientID")),
                                reader.GetInt32(reader.GetOrdinal("UserID")),
                                reader.GetString(reader.GetOrdinal("FirstName")),
                                reader.GetString(reader.GetOrdinal("LastName")),
                                reader.GetDateTime(reader.GetOrdinal("BirthDate")),
                                reader.GetInt32(reader.GetOrdinal("NationalityID")),
                                reader.GetString(reader.GetOrdinal("PhoneNumber")),
                                reader.GetString(reader.GetOrdinal("Gender")),
                                reader.GetDateTime(reader.GetOrdinal("CreatedAt"))
                            );
                        }
                    }
                }
            }

            return null;
        }

        public static List<ClientNameAndIDDTO> GetClientNamesAndIDs()
        {
            var list = new List<ClientNameAndIDDTO>();
            using (SqlConnection con = new SqlConnection(DBConnection._connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SP_GetClientNamesAndIDs", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list.Add(new ClientNameAndIDDTO(
                                reader.GetInt32(reader.GetOrdinal("ClientID")),
                                reader.GetString(reader.GetOrdinal("FirstName")),
                                reader.GetString(reader.GetOrdinal("LastName"))
                            ));
                        }
                    }
                }
            }
            return list;
        }

        public static int AddNewClient(AddNewClientDTO dto)
        {
            using (SqlConnection con = new SqlConnection(DBConnection._connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SP_AddNewClient", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@UserID", dto.CreatedByUserID);
                    cmd.Parameters.AddWithValue("@FirstName", dto.FirstName);
                    cmd.Parameters.AddWithValue("@LastName", dto.LastName);
                    cmd.Parameters.AddWithValue("@BirthDate", dto.BirthDate);
                    cmd.Parameters.AddWithValue("@NationalityID", dto.NationalityID);
                    cmd.Parameters.AddWithValue("@PhoneNumber", dto.PhoneNumber);
                    cmd.Parameters.AddWithValue("@Gender", dto.Gender);

                    SqlParameter outputId = new SqlParameter("@NewClientID", SqlDbType.Int)
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

        public static bool UpdateClient(UpdateClientDTO dto)
        {
            using (SqlConnection con = new SqlConnection(DBConnection._connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SP_UpdateClient", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@ClientID", dto.ClientID);
                    cmd.Parameters.AddWithValue("@UserID", dto.CreatedByUserID);
                    cmd.Parameters.AddWithValue("@FirstName", dto.FirstName);
                    cmd.Parameters.AddWithValue("@LastName", dto.LastName);
                    cmd.Parameters.AddWithValue("@BirthDate", dto.BirthDate);
                    cmd.Parameters.AddWithValue("@NationalityID", dto.NationalityID);
                    cmd.Parameters.AddWithValue("@PhoneNumber", dto.PhoneNumber);
                    cmd.Parameters.AddWithValue("@Gender", dto.Gender);

                    con.Open();

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public static bool DeleteClient(int clientID)
        {
            using (SqlConnection con = new SqlConnection(DBConnection._connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SP_DeleteClient", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ClientID", clientID);

                    con.Open();

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }
    }
}