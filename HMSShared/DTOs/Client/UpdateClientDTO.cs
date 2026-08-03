using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMSShared.DTOs.Client
{
    public class UpdateClientDTO
    {
        public UpdateClientDTO(int clientID, int createdByUserID, string firstName, string lastName, DateTime birthDate, int nationalityID, string phoneNumber, string gender)
        {
            ClientID = clientID;
            CreatedByUserID = createdByUserID;
            FirstName = firstName;
            LastName = lastName;
            BirthDate = birthDate;
            NationalityID = nationalityID;
            PhoneNumber = phoneNumber;
            Gender = gender;
        }

        public int ClientID { get; set; }
        public int CreatedByUserID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public int NationalityID { get; set; }
        public string PhoneNumber { get; set; }
        public string Gender { get; set; }
    }
}
