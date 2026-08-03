namespace HMSApi.DTOs
{
    public class LoginResponseDTO
    {
        public string Token { get; set; }

        public int UserID { get; set; }

        public string FullName { get; set; }

        public string Role { get; set; }

        public LoginResponseDTO(
            string token,
            int userID,
            string fullName,
            string role)
        {
            Token = token;
            UserID = userID;
            FullName = fullName;
            Role = role;
        }
    }
}