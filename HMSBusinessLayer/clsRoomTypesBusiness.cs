using HMSDataAccessLayer;
using System.Collections.Generic;

namespace HMSBusinessLayer
{
    public class clsRoomTypesBusiness
    {
        //Members
        public enum enMode { AddNew = 0, Update = 1 }
        private enMode Mode = enMode.AddNew;

        public int RoomTypeID { get; set; }
        public string TypeName { get; set; }
        public decimal Price { get; set; }
        public int Capacity { get; set; }




        //Constructors
        public clsRoomTypesBusiness(RoomTypeListDTO dto, enMode cMode = enMode.AddNew)
        {
            this.RoomTypeID = dto.RoomTypeID;
            this.TypeName = dto.TypeName;
            this.Mode = cMode;
        }

        public clsRoomTypesBusiness(AddNewRoomTypeDTO dto, enMode cMode = enMode.AddNew)
        {
            this.TypeName = dto.TypeName;
            this.Mode = cMode;
        }




        //Methods
        public RoomTypeListDTO RoomTypeListDto
        {
            get
            {
                return new RoomTypeListDTO(
                    this.RoomTypeID,
                    this.TypeName
                );
            }
        }

        public AddNewRoomTypeDTO AddNewRoomTypeDto
        {
            get
            {
                return new AddNewRoomTypeDTO(
                    this.TypeName
                );
            }
        }

        public UpdateRoomTypeDTO UpdateRoomTypeDto
        {
            get
            {
                return new UpdateRoomTypeDTO(
                    this.RoomTypeID,
                    this.TypeName
                );
            }
        }

        public static List<RoomTypeListDTO> GetAllRoomTypes()
        {
            return clsRoomTypesData.GetAllRoomTypes();
        }

        public static clsRoomTypesBusiness Find(int roomTypeID)
        {
            RoomTypeListDTO dto = clsRoomTypesData.GetRoomTypeByID(roomTypeID);

            if (dto != null)
                return new clsRoomTypesBusiness(dto, enMode.Update);

            return null;
        }

        public static clsRoomTypesBusiness FindByName(string typeName)
        {
            RoomTypeListDTO dto = clsRoomTypesData.GetRoomTypeByName(typeName);

            if (dto != null)
                return new clsRoomTypesBusiness(dto, enMode.Update);

            return null;
        }

        public static bool DeleteRoomType(int roomTypeID)
        {
            return clsRoomTypesData.DeleteRoomType(roomTypeID);
        }

        public static bool IsRoomTypeNameExists(string typeName)
        {
            return clsRoomTypesData.IsRoomTypeNameExists(typeName);
        }

        private bool _AddNewRoomType()
        {
            this.RoomTypeID = clsRoomTypesData.AddNewRoomType(AddNewRoomTypeDto);
            return this.RoomTypeID != -1;
        }

        private bool _UpdateRoomType()
        {
            return clsRoomTypesData.UpdateRoomType(UpdateRoomTypeDto);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewRoomType())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    return false;

                case enMode.Update:
                    return _UpdateRoomType();
            }

            return false;
        }
    }
}
