namespace HMSShared.DTOs.SecurityAlerts
{
    public class SecurityAlertDTO
    {
        public int AlertID { get; set; }

        public int? UserID { get; set; }

        public string AlertType { get; set; }

        public string Description { get; set; }

        public string IPAddress { get; set; }

        public DateTime CreatedAt { get; set; }

        public bool IsReviewed { get; set; }
    }
}