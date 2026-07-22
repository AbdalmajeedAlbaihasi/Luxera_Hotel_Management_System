using HMSDataAccessLayer;
using System;
using System.Collections.Generic;

namespace HMSBusinessLayer
{
    public class clsRoomsBusiness
    {
        //Members
        public enum enMode { AddNew = 0, Update = 1 }
        private enMode Mode = enMode.AddNew;

        public int RoomID { get; set; }
        public string RoomNumber { get; set; }
        public string RoomTypeName { get; set; }
        public int RoomTypeID { get; set; }
        public decimal PricePerNight { get; set; }
        public int Capacity { get; set; }
        public string Status { get; set; }




        //Constructors
        public clsRoomsBusiness(AddNewRoomDTO dto)
        {
            RoomNumber = dto.RoomNumber;
            RoomTypeID = dto.RoomTypeID;
            PricePerNight = dto.PricePerNight;
            Capacity = dto.Capacity;
            Status = dto.Status;
            Mode = enMode.AddNew;
        }

        public static clsRoomsBusiness Find(int roomID)
        {
            RoomListDTO dto = clsRoomsData.GetRoomByID(roomID);

            if (dto != null)
                return new clsRoomsBusiness(dto, 0, enMode.Update);

            return null;
        }

        public clsRoomsBusiness(RoomListDTO dto, int roomTypeID = 0, enMode cMode = enMode.AddNew)
        {
            this.RoomID = dto.RoomID;
            this.RoomNumber = dto.RoomNumber;
            this.RoomTypeName = dto.RoomTypeName;
            this.PricePerNight = dto.Price;
            this.Capacity = dto.Capacity;
            this.Status = dto.Status;
            this.RoomTypeID = dto.RoomTypeID;
            this.Mode = cMode;
        }




        //Methods
        public RoomListDTO RoomListDto
        {
            get
            {
                return new RoomListDTO(
                    this.RoomID,
                    this.RoomNumber,
                    this.RoomTypeID,
                    this.RoomTypeName,
                    this.PricePerNight,
                    this.Capacity,
                    this.Status
                );
            }
        }

        public AddNewRoomDTO AddNewRoomDto
        {
            get
            {
                return new AddNewRoomDTO(
                    this.RoomNumber,
                    this.RoomTypeID,
                    this.Status,
                    this.Capacity,
                    this.PricePerNight

                );
            }
        }

        public UpdateRoomDTO UpdateRoomDto
        {
            get
            {
                return new UpdateRoomDTO(
                    this.RoomID,
                    this.RoomNumber,
                    this.RoomTypeID,
                    this.Status,
                    this.Capacity,
                    this.PricePerNight
                );
            }
        }

        public static List<RoomListDTO> GetAllRooms()
        {
            return clsRoomsData.GetAllRooms();
        }

        public static bool DeleteRoom(int roomID)
        {
            return clsRoomsData.DeleteRoom(roomID);
        }

        public static bool IsRoomNumberExists(string roomNumber)
        {
            return clsRoomsData.IsRoomNumberExists(roomNumber);
        }

        private bool _AddNewRoom()
        {
            this.RoomID = clsRoomsData.AddNewRoom(AddNewRoomDto);
            return this.RoomID != -1;
        }

        private bool _UpdateRoom()
        {
            return clsRoomsData.UpdateRoom(UpdateRoomDto);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewRoom())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    return false;

                case enMode.Update:
                    return _UpdateRoom();
            }

            return false;
        }
    }
}
