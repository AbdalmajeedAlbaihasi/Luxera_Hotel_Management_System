using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMSShared.DTOs.Nationalities
{
    public class AddNewNationalityDTO
    {
        public AddNewNationalityDTO(string nationalityName)
        {
            NationalityName = nationalityName;
        }

        public string NationalityName { get; set; }
    }
}
