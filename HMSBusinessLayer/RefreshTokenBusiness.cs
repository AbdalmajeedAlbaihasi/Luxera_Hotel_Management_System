using HMSDataAccessLayer;
using HMSShared.DTOs.RefreshTokens;
using HMSShared.DTOs.Users;
using System;
using System.Security.Cryptography;

namespace HMSBusinessLayer
{
    public class RefreshTokenBusiness
    {
        private readonly RefreshTokenDataAccess _refreshTokenDataAccess;

        public RefreshTokenBusiness()
        {
            _refreshTokenDataAccess = new RefreshTokenDataAccess();
        }

        // إنشاء Refresh Token عشوائي
        public string GenerateRefreshToken()
        {
            byte[] randomBytes = new byte[64];

            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(randomBytes);
            }

            return Convert.ToBase64String(randomBytes);
        }

        // إنشاء وحفظ Refresh Token
        public RefreshTokenDTO CreateRefreshToken(int userID)
        {
            RefreshTokenDTO refreshToken = new RefreshTokenDTO
            {
                UserID = userID,
                Token = GenerateRefreshToken(),
                CreatedAt = DateTime.Now,
                ExpirationDate = DateTime.Now.AddDays(30),
                IsRevoked = false
            };

            bool saved = _refreshTokenDataAccess.AddRefreshToken(refreshToken);

            if (!saved)
                return null;

            return refreshToken;
        }

        // جلب Refresh Token
        public RefreshTokenDTO GetRefreshToken(string token)
        {
            return _refreshTokenDataAccess.GetRefreshToken(token);
        }

        // التحقق من صلاحية Refresh Token
        public bool ValidateRefreshToken(string token)
        {
            RefreshTokenDTO refreshToken = GetRefreshToken(token);

            if (refreshToken == null)
                return false;

            if (refreshToken.IsRevoked)
                return false;

            if (refreshToken.ExpirationDate < DateTime.Now)
                return false;

            return true;
        }

        // Logout
        public bool RevokeToken(string token)
        {
            return _refreshTokenDataAccess.RevokeRefreshToken(token);
        }

        // حفظ Refresh Token
        public bool SaveRefreshToken(RefreshTokenDTO refreshToken)
        {
            return _refreshTokenDataAccess.AddRefreshToken(refreshToken);
        }

        // الحصول على المستخدم من Refresh Token
        public UserLoginDTO GetUserFromRefreshToken(string token)
        {
            RefreshTokenDTO refreshToken = GetRefreshToken(token);

            if (refreshToken == null)
                return null;

            if (refreshToken.IsRevoked)
                return null;

            if (refreshToken.ExpirationDate < DateTime.Now)
                return null;

            var user = clsUsersBusiness.Find(refreshToken.UserID);

            if (user == null)
                return null;

            return new UserLoginDTO(
                user.UserID,
                user.UserName,
                user.RoleName
            );
        }

        // ==============================
        // Refresh Token Rotation
        // ==============================
        public RefreshTokenDTO RotateRefreshToken(string oldToken)
        {
            RefreshTokenDTO currentToken = GetRefreshToken(oldToken);

            if (currentToken == null)
                return null;

            if (currentToken.IsRevoked)
                return null;

            if (currentToken.ExpirationDate < DateTime.Now)
                return null;

            bool revoked = RevokeToken(oldToken);

            if (!revoked)
                return null;

            return CreateRefreshToken(currentToken.UserID);
        }
    }
}