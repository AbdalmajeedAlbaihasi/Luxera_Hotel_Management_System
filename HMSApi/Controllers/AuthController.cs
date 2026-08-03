using Microsoft.AspNetCore.RateLimiting;
using HMSApi.Services;
using HMSBusinessLayer;
using HMSShared.DTOs.RefreshTokens;
using HMSShared.DTOs.Users;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace HMSApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {

        private readonly JwtService _jwtService;
        private readonly RefreshTokenBusiness _refreshTokenBusiness;
        private readonly AuditBusiness _auditBusiness;
        private readonly SecurityAlertBusiness _securityAlertBusiness;

        public AuthController(
    JwtService jwtService,
    RefreshTokenBusiness refreshTokenBusiness,
    AuditBusiness auditBusiness,
    SecurityAlertBusiness securityAlertBusiness)
        {

            _jwtService = jwtService;

            _refreshTokenBusiness = refreshTokenBusiness;

            _auditBusiness = auditBusiness;
            _securityAlertBusiness = securityAlertBusiness;
        }



        [AllowAnonymous]
        [EnableRateLimiting("LoginPolicy")]
        [HttpPost("Login")]
        public ActionResult Login([FromBody] LoginDTO dto)
        {

            if (dto == null ||
                string.IsNullOrWhiteSpace(dto.UserName) ||
                string.IsNullOrWhiteSpace(dto.Password))
            {
                return BadRequest("Invalid Login Data");
            }



            var user =
                clsUsersBusiness.AuthenticateUser(
                    dto.UserName,
                    dto.Password);



            if (user == null)
            {
                _securityAlertBusiness.AddAlert(
                            null,
                            "LOGIN_FAILED",
                            $"Failed login for username {dto.UserName}",
                            HttpContext.Connection.RemoteIpAddress?.ToString()
                        );

                return Unauthorized("Invalid Username or Password");
            }



            // Generate Access Token
            string accessToken =
                _jwtService.GenerateToken(user);

            _securityAlertBusiness.AddAlert(
                        user.UserID,
                        "LOGIN_SUCCESS",
                        $"{user.UserName} logged in.",
                        HttpContext.Connection.RemoteIpAddress?.ToString()
                    );

            // Generate and Save Refresh Token
            var refreshToken =
                _refreshTokenBusiness.CreateRefreshToken(user.UserID);



            if (refreshToken == null)
            {
                return StatusCode(500, "Failed to create refresh token.");
            }



            _auditBusiness.AddLog(
                            user.UserID,
                            "LOGIN",
                            "User logged into system"
                        );

            


            return Ok(new
            {
                AccessToken = accessToken,

                RefreshToken = refreshToken.Token,

                UserID = user.UserID,

                UserName = user.UserName,

                Role = user.RoleName
            });

        }




        [AllowAnonymous]
        [HttpPost("refresh-token")]
        public ActionResult RefreshToken(
            [FromBody] RefreshTokenRequestDTO dto)
        {

            if (dto == null ||
                string.IsNullOrWhiteSpace(dto.RefreshToken))
            {
                return BadRequest("Refresh Token is required.");
            }



            // Get User From Refresh Token
            var user =
                _refreshTokenBusiness.GetUserFromRefreshToken(
                    dto.RefreshToken);



            if (user == null)
            {
                _securityAlertBusiness.AddAlert(
                    null,
                    "INVALID_REFRESH_TOKEN",
                    "Invalid Refresh Token detected.",
                    HttpContext.Connection.RemoteIpAddress?.ToString()
                );
                return Unauthorized(
                    "Invalid or expired refresh token.");
            }




            // Rotate Refresh Token
            var newRefreshToken =
                _refreshTokenBusiness.RotateRefreshToken(
                    dto.RefreshToken);



            if (newRefreshToken == null)
            {
                _securityAlertBusiness.AddAlert(
                    null,
                    "INVALID_REFRESH_TOKEN",
                    "Invalid Refresh Token detected.",
                    HttpContext.Connection.RemoteIpAddress?.ToString()
                );
                return Unauthorized(
                    "Failed to rotate refresh token.");
            }




            // Generate New Access Token
            string newAccessToken =
                _jwtService.GenerateToken(user);



            return Ok(new
            {
                AccessToken = newAccessToken,

                RefreshToken = newRefreshToken.Token
            });

        }





        [AllowAnonymous]
        [HttpPost("logout")]
        public ActionResult Logout(
            [FromBody] LogoutRequestDTO dto)
        {

            if (dto == null ||
                string.IsNullOrWhiteSpace(dto.RefreshToken))
            {
                return BadRequest("Refresh Token is required.");
            }

            var user =
                _refreshTokenBusiness.GetUserFromRefreshToken(
                    dto.RefreshToken);


            if (user != null)
            {
                _auditBusiness.AddLog(
                    user.UserID,
                    "LOGOUT",
                    "User logged out"
                );
            }


            bool result =
                _refreshTokenBusiness.RevokeToken(
                    dto.RefreshToken);




            if (!result)
            {
                return BadRequest("Logout failed.");
            }

            

            _securityAlertBusiness.AddAlert(
                    user.UserID,
                    "LOGOUT",
                    "User logged out.",
                    HttpContext.Connection.RemoteIpAddress?.ToString()
                );


            return Ok(new
            {
                Message = "Logout successfully."
            });

        }


    }
}