using HMSDataAccessLayer;
using System;
using System.Collections.Generic;

namespace HMSBusinessLayer
{
    public class clsClientsBusiness
    {
        //Members
        public enum enMode { AddNew = 0, Update = 1 }
        private enMode Mode = enMode.AddNew;

        public int ClientID { get; set; }
        public int CreatedByUserID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public int NationalityID { get; set; }
        public string PhoneNumber { get; set; }
        public string Gender { get; set; }
        public DateTime CreatedAt { get; set; }





        //Constructors 
        public clsClientsBusiness()
        {
            this.ClientID = -1;
            this.CreatedByUserID = -1;
            this.FirstName = "";
            this.LastName = "";
            this.BirthDate = DateTime.Now;
            this.NationalityID = -1;
            this.PhoneNumber = "";
            this.Gender = "";
            this.CreatedAt = DateTime.Now;

            this.Mode = enMode.AddNew;
        }


        public clsClientsBusiness(ClientListDTO dto, enMode cMode = enMode.Update)
        {
            this.ClientID = dto.ClientID;
            this.CreatedByUserID = dto.CreatedByUserID;
            this.FirstName = dto.FirstName;
            this.LastName = dto.LastName;
            this.BirthDate = dto.BirthDate;
            this.NationalityID = dto.NationalityID;
            this.PhoneNumber = dto.PhoneNumber;
            this.Gender = dto.Gender;
            this.CreatedAt = dto.CreatedAt;

            this.Mode = cMode;
        }


        public static clsClientsBusiness Find(int clientID)
        {
            ClientListDTO dto = clsClientsData.GetClientByID(clientID);

            if (dto != null)
                return new clsClientsBusiness(dto, enMode.Update);

            return null;
        }




        //Methods
        public ClientListDTO ClientListDto
        {
            get
            {
                return new ClientListDTO(
                    this.ClientID,
                    this.CreatedByUserID,
                    this.FirstName,
                    this.LastName,
                    this.BirthDate,
                    this.NationalityID,
                    this.PhoneNumber,
                    this.Gender,
                    this.CreatedAt
                );
            }
        }

        public AddNewClientDTO AddNewClientDto
        {
            get
            {
                return new AddNewClientDTO(
                    this.CreatedByUserID,
                    this.FirstName,
                    this.LastName,
                    this.BirthDate,
                    this.NationalityID,
                    this.PhoneNumber,
                    this.Gender
                );
            }
        }

        public UpdateClientDTO UpdateClientDto
        {
            get
            {
                return new UpdateClientDTO(
                    this.ClientID,
                    this.CreatedByUserID,
                    this.FirstName,
                    this.LastName,
                    this.BirthDate,
                    this.NationalityID,
                    this.PhoneNumber,
                    this.Gender
                );
            }
        }

        public static List<ClientListDTO> GetAllClients()
        {
            return clsClientsData.GetAllClients();
        }

        public static bool DeleteClient(int clientID)
        {
            return clsClientsData.DeleteClient(clientID);
        }

        private bool _AddNewClient()
        {
            this.ClientID = clsClientsData.AddNewClient(this.AddNewClientDto);
            return this.ClientID != -1;
        }

        private bool _UpdateClient()
        {
            return clsClientsData.UpdateClient(this.UpdateClientDto);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:

                    if (_AddNewClient())
                    {
                        Mode = enMode.Update;
                        return true;
                    }

                    return false;

                case enMode.Update:
                    return _UpdateClient();
            }

            return false;
        }

        public static List<ClientNameAndIDDTO> GetClientNamesAndIDs()
        {
            return clsClientsData.GetClientNamesAndIDs();
        }
    }
}