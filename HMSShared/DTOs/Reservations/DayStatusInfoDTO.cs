namespace HMSShared.DTOs.Reservations
{
    public class DayStatusInfoDTO
    {
        public string Status { get; set; } = string.Empty;

        public string GuestName { get; set; } = string.Empty;

        public int? ReservationID { get; set; }
    }
}