using HMSDataAccessLayer;
using HMSDesktop.Services;
using HMSDesktop.User_Control;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMSDesktop.Services
{
    public class NationalitiesApiService : BaseApiService
    {
        public async Task<List<NationalityListDTO>> GetAllNationalities()
        {
            var res = await client.GetAsync("NationalityAPI/All");
            if (res.IsSuccessStatusCode)
            {
                var json = await res.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<List<NationalityListDTO>>(json);
            }
            return new List<NationalityListDTO>();
        }

    }
}
