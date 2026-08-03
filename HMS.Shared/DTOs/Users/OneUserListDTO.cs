using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Shared.DTOs.Users
{
    public class OneUserListDTO
    {
        public OneUserListDTO(int UserID, string username, bool isActive, string Fname, string Lname,
            DateTime BirthDate, string PhoneNumber, int NationalityID, string NationalityName, string Gender, string RoleName, string ImagePath)
        {
            this.UserID = UserID;
            this.UserName = username;
            this.IsActive = isActive;
            this.FName = Fname;
            this.LName = Lname;
            this.BirthDate = BirthDate;
            this.PhoneNumber = PhoneNumber;
            this.NationalityID = NationalityID;
            this.NationalityName = NationalityName;
            this.Gender = Gender;
            this.RoleName = RoleName;
            this.ImagePath = ImagePath;
        }
        public int UserID { get; set; }
        public string UserName { get; set; }
        public bool IsActive { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public DateTime BirthDate { get; set; }
        public string PhoneNumber { get; set; }
        public int NationalityID { get; set; }
        public string NationalityName { get; set; }
        public string Gender { get; set; }
        public string RoleName { get; set; }
        public string ImagePath { get; set; }
    }
}
