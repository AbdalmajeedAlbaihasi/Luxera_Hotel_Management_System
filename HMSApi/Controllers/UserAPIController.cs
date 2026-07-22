using HMSBusinessLayer;
using HMSDataAccessLayer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace HMSApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserAPIController : ControllerBase
    {
        [HttpGet("All", Name = "GetAllUsers")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<IEnumerable<UserListDTO>> GetAllUsers()
        {
            var list = clsUsersBusiness.GetAllUsers();

            if (list == null || list.Count == 0)
                return NotFound("No Users");

            return Ok(list);
        }



        [HttpGet("{Id}", Name = "GetUserById")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<OneUserListDTO> GetUserById(int Id)
        {
            if (Id < 1)
                return BadRequest(new { Error = "Invalid ID" });

            var user = clsUsersBusiness.Find(Id);

            if (user == null)
                return NotFound(new { Error = "User not found" });

            return Ok(user.OneUserListDTO);
        }



        [HttpGet("ByUsername/{username}", Name = "GetUserByUsername")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<OneUserListDTO> GetUserByUsername(string username)
        {
            if (string.IsNullOrWhiteSpace(username))
                return BadRequest("Invalid Username");

            var user = clsUsersBusiness.FindByUsername(username);

            if (user == null)
                return NotFound("User Not Found");

            return Ok(user.OneUserListDTO);
        }



        [HttpPost("Add", Name = "AddUser")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult AddUser([FromBody] AddNewUserDTO dto)
        {
            if (dto == null)
                return BadRequest("Invalid Data");

            if (clsUsersBusiness.IsUsernameExists(dto.UserName))
                return BadRequest("Username already exists");

            clsUsersBusiness user = new clsUsersBusiness(
                new AddNewUserDTO(
                    dto.UserName,
                    dto.Password,
                    dto.IsActive,
                    dto.FName,
                    dto.LName,
                    dto.BirthDate,
                    dto.PhoneNumber,
                    dto.NationalityID,
                    dto.Gender,
                    dto.RoleName,
                    dto.ImagePath
                )
            );

            if (!user.Save())
                return BadRequest("Failed to add user");

            return CreatedAtRoute("GetUserById", new { Id = user.UserID }, user.UserListDto);
        }



        [HttpPut("Update/{Id}", Name = "UpdateUser")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult UpdateUser(int Id, [FromBody] UpdateUserDTO dto)
        {
            if (Id < 1)
                return BadRequest(new { Error = "Invalid ID" });
            if (dto == null)
                return BadRequest(new { Error = "Request body is null or could not be deserialized" });
            dto.UserID = Id;


            if (dto.UserID != 0 && dto.UserID != Id)
                return BadRequest(new { Error = "Route ID does not match DTO.UserID" });

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            try
            {
                var user = clsUsersBusiness.Find(Id);

                if (user == null)
                    return NotFound(new { Error = "User Not Found" });

                if (string.IsNullOrWhiteSpace(dto.ImagePath))
                    dto.ImagePath = user.ImagePath;

                var existingUser = clsUsersBusiness.FindByUsername(dto.UserName);
                if (existingUser != null && existingUser.UserID != Id)
                {
                    return BadRequest(new
                    {
                        Code = "DUPLICATE_USERNAME",
                        Error = "Username already exists"
                    });
                }

                user.UserName = dto.UserName;
                user.Password = dto.Password;
                user.IsActive = dto.IsActive;
                user.FName = dto.FName;
                user.LName = dto.LName;
                user.BirthDate = dto.BirthDate;
                user.PhoneNumber = dto.PhoneNumber;
                user.NationalityID = dto.NationalityID;
                user.Gender = dto.Gender;
                user.RoleName = dto.RoleName;
                user.ImagePath = dto.ImagePath;

                if (!user.Save())
                    return BadRequest(new { Error = "Update Failed (business layer returned false)" });

                return Ok(new { Message = "Updated Successfully" });
            }
            catch (Exception ex)
            {
                return BadRequest(new
                {
                    Code = "EXCEPTION",
                    Error = "Exception during update",
                    Details = ex.Message
                });
            }
        }



        [HttpDelete("Delete/{id}", Name = "DeleteUser")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult DeleteUser(int id)
        {
            var result = clsUsersBusiness.DeleteUser(id);

            if (id < 1)
                return BadRequest(new { Error = "Invalid ID" });

            if (!result.Success)
            {
                return BadRequest(new { Error = result.Message });
            }

            return Ok(new { Message = result.Message });
        }



        [HttpPost("Login", Name = "Login")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult Login([FromBody] LoginDTO dto)
        {
            if (dto == null || string.IsNullOrWhiteSpace(dto.UserName) || string.IsNullOrWhiteSpace(dto.Password))
                return BadRequest("Invalid Login Data");

            var user = clsUsersBusiness.AuthenticateUser(dto.UserName, dto.Password);

            if (user == null)
                return Unauthorized("Invalid Username or Password");

            return Ok(new UserLoginDTO(
                user.UserID,
                user.FName,
                user.LName,
                user.IsActive,
                user.RoleName
            ));
        }
    }
}