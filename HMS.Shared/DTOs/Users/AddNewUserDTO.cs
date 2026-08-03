using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Shared.DTOs.Users
{
    public class AddNewUserDTO
    {
        public AddNewUserDTO(string username, string Password, bool isActive, string Fname, string Lname,
            DateTime BirthDate, string PhoneNumber, int NationalityID, string Gender, string RoleName, string ImagePath)
        {
            this.UserName = username;
            this.Password = Password;
            this.IsActive = isActive;
            this.FName = Fname;
            this.LName = Lname;
            this.BirthDate = BirthDate;
            this.PhoneNumber = PhoneNumber;
            this.NationalityID = NationalityID;
            this.Gender = Gender;
            this.RoleName = RoleName;
            this.ImagePath = ImagePath;
        }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public DateTime BirthDate { get; set; }
        public string PhoneNumber { get; set; }
        public int NationalityID { get; set; }
        public string Gender { get; set; }
        public string RoleName { get; set; }
        public string ImagePath { get; set; }
    }
}
