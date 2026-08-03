namespace HMSShared.DTOs.Audit
{
    public class AuditLogDTO
    {
        public int AuditID { get; set; }

        public int? UserID { get; set; }

        public string Action { get; set; }

        public string Description { get; set; }

        public DateTime CreatedAt { get; set; }
    }
}