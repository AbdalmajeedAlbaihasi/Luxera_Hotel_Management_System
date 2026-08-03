using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Shared.DTOs.Nationalities
{
    public class UpdateNationalityDTO
    {
        public UpdateNationalityDTO(int nationalityID, string nationalityName)
        {
            NationalityID = nationalityID;
            NationalityName = nationalityName;
        }

        public int NationalityID { get; set; }
        public string NationalityName { get; set; }
    }
}
