using HMSShared.DTOs.Users;
using HMSApi.DTOs;
using HMSApi.Services;
using HMSBusinessLayer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace HMSApi.Controllers
{
    [Authorize(Policy = "CanManageUsers")]
    [Route("api/[controller]")]
    [ApiController]
    public class UserAPIController : ControllerBase
    {

        private readonly AuditBusiness _auditBusiness;
        private readonly UserContextService _userContext;


        public UserAPIController(
            AuditBusiness auditBusiness,
            UserContextService userContext)
        {
            _auditBusiness = auditBusiness;
            _userContext = userContext;
        }



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



            _auditBusiness.AddLog(
                _userContext.GetCurrentUserID(),
                "ADD_USER",
                $"Added user {user.UserName}"
            );



            return CreatedAtRoute(
                "GetUserById",
                new { Id = user.UserID },
                user.UserListDto
            );
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
                return BadRequest(new { Error = "Request body is null" });



            dto.UserID = Id;



            if (!ModelState.IsValid)
                return BadRequest(ModelState);



            try
            {

                var user = clsUsersBusiness.Find(Id);



                if (user == null)
                    return NotFound(new { Error = "User Not Found" });



                if (string.IsNullOrWhiteSpace(dto.ImagePath))
                    dto.ImagePath = user.ImagePath;




                var existingUser =
                    clsUsersBusiness.FindByUsername(dto.UserName);



                if (existingUser != null &&
                    existingUser.UserID != Id)
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
                    return BadRequest(
                        new { Error = "Update Failed" }
                    );





                _auditBusiness.AddLog(
                    _userContext.GetCurrentUserID(),
                    "UPDATE_USER",
                    $"Updated user ID {Id}"
                );





                return Ok(new
                {
                    Message = "Updated Successfully"
                });

            }
            catch (Exception ex)
            {

                return BadRequest(new
                {
                    Code = "EXCEPTION",
                    Error = ex.Message
                });

            }

        }







        [HttpDelete("Delete/{id}", Name = "DeleteUser")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult DeleteUser(int id)
        {


            if (id < 1)
                return BadRequest(new { Error = "Invalid ID" });



            var result = clsUsersBusiness.DeleteUser(id);



            if (!result.Success)
            {
                return BadRequest(
                    new { Error = result.Message }
                );
            }




            _auditBusiness.AddLog(
                _userContext.GetCurrentUserID(),
                "DELETE_USER",
                $"Deleted user ID {id}"
            );



            return Ok(new
            {
                Message = result.Message
            });

        }


    }
}