using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMSShared.DTOs.RefreshTokens
{
    public class RefreshTokenDTO
    {
        public int RefreshTokenID { get; set; }

        public int UserID { get; set; }

        public string Token { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime ExpirationDate { get; set; }

        public DateTime? RevokedAt { get; set; }

        public bool IsRevoked { get; set; }
    }
}