using HMSDataAccessLayer;
using HMSShared.DTOs.Audit;


namespace HMSBusinessLayer
{

    public class AuditBusiness
    {

        private readonly AuditDataAccess _auditDataAccess;



        public AuditBusiness()
        {
            _auditDataAccess = new AuditDataAccess();
        }





        public bool AddLog(
            int? userID,
            string action,
            string description)
        {


            AuditLogDTO audit = new AuditLogDTO
            {

                UserID = userID,

                Action = action,

                Description = description

            };


            return _auditDataAccess.AddAuditLog(audit);

        }


    }

}