using System;
using System.Collections.Generic;

namespace HMSShared.DTOs.Reservations
{
    public class RoomTimelineRowDTO
    {
        public int RoomID { get; set; }

        public string RoomNumber { get; set; } = string.Empty;

        public string RoomType { get; set; } = string.Empty;

        public string RoomCurrentStatus { get; set; } = string.Empty;

        public Dictionary<DateTime, DayStatusInfoDTO> Days { get; set; }
            = new Dictionary<DateTime, DayStatusInfoDTO>();
    }
}