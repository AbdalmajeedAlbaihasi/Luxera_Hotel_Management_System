using HMSDataAccessLayer;
using HMSShared.DTOs.SecurityAlerts;

namespace HMSBusinessLayer
{
    public class SecurityAlertBusiness
    {
        private readonly SecurityAlertDataAccess _data;

        public SecurityAlertBusiness()
        {
            _data = new SecurityAlertDataAccess();
        }

        public bool AddAlert(
            int? userID,
            string type,
            string description,
            string ip)
        {
            return _data.AddAlert(new SecurityAlertDTO
            {
                UserID = userID,
                AlertType = type,
                Description = description,
                IPAddress = ip
            });
        }

        public List<SecurityAlertDTO> GetAllAlerts()
        {
            return _data.GetAllAlerts();
        }

        public List<SecurityAlertDTO> GetUnreadAlerts()
        {
            return _data.GetUnreadAlerts();
        }

        public bool MarkAsReviewed(int id)
        {
            return _data.MarkAsReviewed(id);
        }
    }
}