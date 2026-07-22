using HMSDataAccessLayer;
using System.Collections.Generic;

namespace HMSBusinessLayer
{
    public class clsNationalitiesBusiness
    {
        public enum enMode { AddNew = 0, Update = 1 }
        private enMode Mode = enMode.AddNew;

        public int NationalityID { get; set; }
        public string NationalityName { get; set; }

        public NationalityListDTO NationalityListDto
        {
            get
            {
                return new NationalityListDTO(this.NationalityID, this.NationalityName);
            }
        }

        public AddNewNationalityDTO AddNewNationalityDto
        {
            get
            {
                return new AddNewNationalityDTO(this.NationalityName);
            }
        }

        public UpdateNationalityDTO UpdateNationalityDto
        {
            get
            {
                return new UpdateNationalityDTO(this.NationalityID, this.NationalityName);
            }
        }

        public clsNationalitiesBusiness(NationalityListDTO dto, enMode cMode = enMode.AddNew)
        {
            this.NationalityID = dto.NationalityID;
            this.NationalityName = dto.NationalityName;
            this.Mode = cMode;
        }

        public static List<NationalityListDTO> GetAllNationalities()
        {
            return clsNationalitiesData.GetAllNationalities();
        }

        public static clsNationalitiesBusiness Find(int nationalityID)
        {
            NationalityListDTO dto = clsNationalitiesData.GetNationalityByID(nationalityID);

            if (dto != null)
                return new clsNationalitiesBusiness(dto, enMode.Update);

            return null;
        }

        public static clsNationalitiesBusiness FindByName(string nationalityName)
        {
            NationalityListDTO dto = clsNationalitiesData.GetNationalityByName(nationalityName);

            if (dto != null)
                return new clsNationalitiesBusiness(dto, enMode.Update);

            return null;
        }

        public static bool DeleteNationality(int nationalityID)
        {
            return clsNationalitiesData.DeleteNationality(nationalityID);
        }

        public static bool IsNationalityNameExists(string nationalityName)
        {
            return clsNationalitiesData.IsNationalityNameExists(nationalityName);
        }

        private bool _AddNewNationality()
        {
            this.NationalityID = clsNationalitiesData.AddNewNationality(AddNewNationalityDto);
            return this.NationalityID != -1;
        }

        private bool _UpdateNationality()
        {
            return clsNationalitiesData.UpdateNationality(UpdateNationalityDto);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewNationality())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    return false;

                case enMode.Update:
                    return _UpdateNationality();
            }

            return false;
        }
    }
}
