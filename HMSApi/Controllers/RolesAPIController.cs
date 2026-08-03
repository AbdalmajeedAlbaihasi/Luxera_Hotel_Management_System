using HMSApi.Services;
using HMSBusinessLayer;
using HMSShared.DTOs.Roles;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace HMSApi.Controllers
{
    [Authorize(Policy = "CanManageHotel")]
    [Route("api/[controller]")]
    [ApiController]
    public class RoleAPIController : ControllerBase
    {

        private readonly AuditBusiness _auditBusiness;
        private readonly UserContextService _userContext;


        public RoleAPIController(
            AuditBusiness auditBusiness,
            UserContextService userContext)
        {
            _auditBusiness = auditBusiness;
            _userContext = userContext;
        }



        [HttpGet("All", Name = "GetAllRoles")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<IEnumerable<RoleListDTO>> GetAllRoles()
        {
            var list = clsRolesBusiness.GetAllRoles();

            if (list == null || list.Count == 0)
                return NotFound("No Roles");

            return Ok(list);
        }



        [HttpGet("{Id}", Name = "GetRoleById")]
        public ActionResult<RoleListDTO> GetRoleById(int Id)
        {
            if (Id < 1)
                return BadRequest("Invalid ID");


            var role = clsRolesBusiness.Find(Id);


            if (role == null)
                return NotFound("Role Not Found");


            return Ok(role.RoleListDto);
        }



        [HttpGet("ByName/{roleName}", Name = "GetRoleByName")]
        public ActionResult<RoleListDTO> GetRoleByName(string roleName)
        {
            if (string.IsNullOrWhiteSpace(roleName))
                return BadRequest("Invalid Role Name");


            var role = clsRolesBusiness.FindByName(roleName);


            if (role == null)
                return NotFound("Role Not Found");


            return Ok(role.RoleListDto);
        }



        [HttpGet("Exists/{roleName}", Name = "IsRoleNameExists")]
        public ActionResult IsRoleNameExists(string roleName)
        {
            if (string.IsNullOrWhiteSpace(roleName))
                return BadRequest("Invalid Role Name");


            bool exists = clsRolesBusiness.IsRoleNameExists(roleName);


            return Ok(new { Exists = exists });
        }





        [HttpPost("Add", Name = "AddRole")]
        public ActionResult<RoleListDTO> AddRole(AddNewRoleDTO dto)
        {

            if (dto == null)
                return BadRequest("Invalid Data");


            if (clsRolesBusiness.IsRoleNameExists(dto.RoleName))
                return BadRequest("Role Name already exists");


            clsRolesBusiness role =
                new clsRolesBusiness(
                    new RoleListDTO(0, dto.RoleName)
                );


            if (!role.Save())
                return BadRequest("Failed to add role");



            _auditBusiness.AddLog(
                _userContext.GetCurrentUserID(),
                "ADD_ROLE",
                $"Added role {role.RoleName}"
            );



            return CreatedAtRoute(
                "GetRoleById",
                new { Id = role.RoleID },
                role.RoleListDto);
        }





        [HttpPut("Update/{Id}", Name = "UpdateRole")]
        public ActionResult UpdateRole(int Id, UpdateRoleDTO dto)
        {

            if (Id < 1 || dto == null)
                return BadRequest("Invalid Data");


            var role = clsRolesBusiness.Find(Id);


            if (role == null)
                return NotFound("Role Not Found");



            var existing =
                clsRolesBusiness.FindByName(dto.RoleName);


            if (existing != null && existing.RoleID != Id)
                return BadRequest("Role Name already exists");



            role.RoleName = dto.RoleName;



            if (!role.Save())
                return BadRequest("Update Failed");



            _auditBusiness.AddLog(
                _userContext.GetCurrentUserID(),
                "UPDATE_ROLE",
                $"Updated role ID {Id}"
            );



            return Ok("Updated Successfully");
        }





        [HttpDelete("Delete/{Id}", Name = "DeleteRole")]
        public ActionResult DeleteRole(int Id)
        {

            if (Id < 1)
                return BadRequest("Invalid ID");



            if (!clsRolesBusiness.DeleteRole(Id))
                return NotFound("Role Not Found");



            _auditBusiness.AddLog(
                _userContext.GetCurrentUserID(),
                "DELETE_ROLE",
                $"Deleted role ID {Id}"
            );



            return Ok("Deleted Successfully");
        }

    }
}