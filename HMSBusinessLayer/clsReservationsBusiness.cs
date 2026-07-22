using HMSDataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HMSBusinessLayer
{
    public class clsReservationsBusiness
    {
        //member 
        public enum enMode { AddNew = 0, Update = 1 }
        private enMode Mode = enMode.AddNew;

        public int ReservationID { get; set; }
        public int RoomID { get; set; }
        public int ClientId { get; set; }
        public int CreatedByUserID { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
        public string Status { get; set; }





        //constructor
        public clsReservationsBusiness()
        {
            Mode = enMode.AddNew;
            ReservationID = -1;
            RoomID = 0;
            ClientId = 0;
            CreatedByUserID = 0;
            CheckInDate = DateTime.Now;
            CheckOutDate = DateTime.Now;
            Status = "";
        }

        public clsReservationsBusiness(ReservationListDTO dto, enMode cMode = enMode.AddNew)
        {
            ReservationID = dto.ReservationID;
            RoomID = dto.RoomID;
            ClientId = dto.ClientId;
            CreatedByUserID = dto.UserID;
            CheckInDate = dto.CheckInDate;
            CheckOutDate = dto.CheckOutDate;
            Status = dto.Status;
            Mode = cMode;
        }

        public clsReservationsBusiness(OneReservationListDTO dto, enMode cMode = enMode.Update)
        {
            ReservationID = dto.ReservationID;
            RoomID = dto.RoomID;
            ClientId = dto.ClientId;
            CreatedByUserID = dto.UserID;
            CheckInDate = dto.CheckInDate;
            CheckOutDate = dto.CheckOutDate;
            Status = dto.Status;
            Mode = cMode;
        }





        //classes
        public class RoomTimelineRow
        {
            public int RoomID { get; set; }
            public string RoomNumber { get; set; }
            public string RoomType { get; set; }
            public string RoomCurrentStatus { get; set; }
            public Dictionary<DateTime, DayStatusInfo> Days { get; set; }
                = new Dictionary<DateTime, DayStatusInfo>();
        }

        public class DayStatusInfo
        {
            public string Status { get; set; }
            public string GuestName { get; set; }
            public int? ReservationID { get; set; }
        }




        //methods
        public static clsReservationsBusiness Find(int reservationID)
        {
            var dto = clsReservationsData.GetReservationByID(reservationID);

            if (dto == null)
                return null;

            return new clsReservationsBusiness(dto, enMode.Update);
        }

        public ReservationListDTO ReservationListDto
        {
            get
            {
                return new ReservationListDTO(
                    ReservationID,
                    RoomID,
                    "",
                    ClientId,
                    "",
                    CreatedByUserID,
                    "",
                    CheckInDate,
                    CheckOutDate,
                    Status
                );
            }
        }

        public AddNewReservationDTO AddNewReservationDto
        {
            get
            {
                return new AddNewReservationDTO(
                    RoomID,
                    ClientId,
                    CreatedByUserID,
                    CheckInDate,
                    CheckOutDate,
                    Status
                );
            }
        }

        public UpdateReservationDTO UpdateReservationDto
        {
            get
            {
                return new UpdateReservationDTO(
                    ReservationID,
                    RoomID,
                    ClientId,
                    CreatedByUserID,
                    CheckInDate,
                    CheckOutDate,
                    Status
                );
            }
        }

        public static List<ReservationListDTO> GetAllReservations()
        {
            return clsReservationsData.GetAllReservations();
        }

        public static bool DeleteReservation(int reservationID)
        {
            return clsReservationsData.DeleteReservation(reservationID);
        }

        public static List<RoomNumberDTO> GetRoomNumbers()
        {
            return clsReservationsData.GetRoomNumbers();
        }

        public static bool IsRoomAvailable(int roomID, DateTime checkIn, DateTime checkOut)
        {
            return clsReservationsData.IsRoomAvailable(roomID, checkIn, checkOut);
        }

        public static bool IsRoomAvailableForUpdate(int reservationID, int roomID, DateTime checkIn, DateTime checkOut)
        {
            return clsReservationsData.IsRoomAvailableForUpdate(reservationID, roomID, checkIn, checkOut);
        }

        private bool _AddNewReservation()
        {
            ReservationID = clsReservationsData.AddNewReservation(AddNewReservationDto);
            return ReservationID != -1;
        }

        private bool _UpdateReservation()
        {
            return clsReservationsData.UpdateReservation(UpdateReservationDto);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewReservation())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    return false;

                case enMode.Update:
                    return _UpdateReservation();
            }

            return false;
        }

        public static List<RoomTimelineRow> GetHotelTimeline(DateTime startDate, DateTime endDate)
        {
            var rawData = clsReservationsData.GetRoomTimelineData(startDate, endDate);

            return rawData
                .GroupBy(x => x.RoomID)
                .Select(g => new RoomTimelineRow
                {
                    RoomID = g.Key,
                    RoomNumber = g.First().RoomNumber,
                    RoomType = g.First().RoomType,
                    RoomCurrentStatus = g.First().RoomCurrentStatus,
                    Days = MapDays(g.ToList(), startDate, endDate)
                })
                .ToList();
        }

        private static Dictionary<DateTime, DayStatusInfo> MapDays( List<RoomTimelineDTO.RoomAvailabilityInfo> data,
                                                                    DateTime start, DateTime end)
        {
            var dict = new Dictionary<DateTime, DayStatusInfo>();

            for (DateTime d = start.Date; d <= end.Date; d = d.AddDays(1))
            {
                var res = data.FirstOrDefault(r =>
                    r.CheckInDate.HasValue &&
                    d >= r.CheckInDate.Value.Date &&
                    d < r.CheckOutDate.Value.Date
                );

                if (res != null)
                {
                    dict[d] = new DayStatusInfo
                    {
                        Status = "Reserved",
                        GuestName = res.GuestName,
                        ReservationID = res.ReservationID
                    };
                }
                else
                {
                    dict[d] = new DayStatusInfo
                    {
                        Status = data.FirstOrDefault()?.RoomCurrentStatus ?? "Available",
                        GuestName = "",
                        ReservationID = null
                    };
                }
            }

            return dict;
        }
    }
}