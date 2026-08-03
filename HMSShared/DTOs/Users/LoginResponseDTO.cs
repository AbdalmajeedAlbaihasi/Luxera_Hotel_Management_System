namespace HMSShared.DTOs.Users
{
    public class LoginResponseDTO
    {
        public string AccessToken { get; set; }

        public string RefreshToken { get; set; }

        public int UserID { get; set; }

        public string UserName { get; set; }

        public string Role { get; set; }
    }
}