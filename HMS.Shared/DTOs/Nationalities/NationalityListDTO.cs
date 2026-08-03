using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Shared.DTOs.Nationalities
{
    public class NationalityListDTO
    {
        public NationalityListDTO(int nationalityID, string nationalityName)
        {
            NationalityID = nationalityID;
            NationalityName = nationalityName;
        }

        public int NationalityID { get; set; }
        public string NationalityName { get; set; }
    }
}
