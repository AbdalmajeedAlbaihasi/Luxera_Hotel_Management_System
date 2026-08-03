using HMSShared.DTOs.SecurityAlerts;
using Microsoft.Data.SqlClient;
using System.Data;

namespace HMSDataAccessLayer
{
    public class SecurityAlertDataAccess
    {

        public bool AddAlert(SecurityAlertDTO dto)
        {
            using SqlConnection connection =
                new SqlConnection(DBConnection._connectionString);

            using SqlCommand command =
                new SqlCommand("SP_AddSecurityAlert", connection);

            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@UserID",
                (object?)dto.UserID ?? DBNull.Value);

            command.Parameters.AddWithValue("@AlertType",
                dto.AlertType);

            command.Parameters.AddWithValue("@Description",
                dto.Description);

            command.Parameters.AddWithValue("@IPAddress",
                dto.IPAddress);

            connection.Open();

            return command.ExecuteNonQuery() > 0;
        }

        public List<SecurityAlertDTO> GetAllAlerts()
        {
            List<SecurityAlertDTO> list = new();

            using SqlConnection connection =
                new SqlConnection(DBConnection._connectionString);

            using SqlCommand command =
                new SqlCommand("SP_GetAllSecurityAlerts", connection);

            command.CommandType = CommandType.StoredProcedure;

            connection.Open();

            using SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                list.Add(new SecurityAlertDTO
                {
                    AlertID = (int)reader["AlertID"],
                    UserID = reader["UserID"] == DBNull.Value
                        ? null
                        : (int?)reader["UserID"],

                    AlertType = reader["AlertType"].ToString(),

                    Description = reader["Description"].ToString(),

                    IPAddress = reader["IPAddress"].ToString(),

                    CreatedAt = (DateTime)reader["CreatedAt"],

                    IsReviewed = (bool)reader["IsReviewed"]
                });
            }

            return list;
        }

        public List<SecurityAlertDTO> GetUnreadAlerts()
        {
            List<SecurityAlertDTO> list = new();

            using SqlConnection connection =
                new SqlConnection(DBConnection._connectionString);

            using SqlCommand command =
                new SqlCommand("SP_GetUnreadSecurityAlerts", connection);

            command.CommandType = CommandType.StoredProcedure;

            connection.Open();

            using SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                list.Add(new SecurityAlertDTO
                {
                    AlertID = (int)reader["AlertID"],
                    UserID = reader["UserID"] == DBNull.Value
                        ? null
                        : (int?)reader["UserID"],

                    AlertType = reader["AlertType"].ToString(),

                    Description = reader["Description"].ToString(),

                    IPAddress = reader["IPAddress"].ToString(),

                    CreatedAt = (DateTime)reader["CreatedAt"],

                    IsReviewed = (bool)reader["IsReviewed"]
                });
            }

            return list;
        }

        public bool MarkAsReviewed(int alertID)
        {
            using SqlConnection connection =
                new SqlConnection(DBConnection._connectionString);

            using SqlCommand command =
                new SqlCommand("SP_MarkAlertAsReviewed", connection);

            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@AlertID", alertID);

            connection.Open();

            return command.ExecuteNonQuery() > 0;
        }

    }
}