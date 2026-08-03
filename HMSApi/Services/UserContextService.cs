using System.Security.Claims;

namespace HMSApi.Services
{
    public class UserContextService
    {

        private readonly IHttpContextAccessor _httpContextAccessor;


        public UserContextService(
            IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }



        public int GetCurrentUserID()
        {

            var userID =
                _httpContextAccessor
                .HttpContext?
                .User
                .FindFirst(
                    ClaimTypes.NameIdentifier)
                ?.Value;


            if (userID == null)
                throw new Exception("User ID not found");


            return int.Parse(userID);

        }

    }
}