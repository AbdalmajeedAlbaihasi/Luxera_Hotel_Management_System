using Microsoft.Data.SqlClient;
using System.Data;
using HMSShared.DTOs.Audit;


namespace HMSDataAccessLayer
{
    public class AuditDataAccess
    {


        public bool AddAuditLog(AuditLogDTO audit)
        {

            bool result = false;


            using (SqlConnection connection =
                new SqlConnection(DBConnection._connectionString))
            {


                using (SqlCommand command =
                    new SqlCommand("SP_AddAuditLog", connection))
                {

                    command.CommandType =
                        CommandType.StoredProcedure;


                    command.Parameters.AddWithValue(
                        "@UserID",
                        audit.UserID ?? (object)DBNull.Value);


                    command.Parameters.AddWithValue(
                        "@Action",
                        audit.Action);


                    command.Parameters.AddWithValue(
                        "@Description",
                        audit.Description);



                    connection.Open();


                    int rows =
                        command.ExecuteNonQuery();



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