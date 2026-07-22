using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using HMSBusinessLayer;
using HMSDataAccessLayer;
using System.Collections.Generic;

namespace HMSApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoleAPIController : ControllerBase
    {
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
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
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
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
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
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult IsRoleNameExists(string roleName)
        {
            if (string.IsNullOrWhiteSpace(roleName))
                return BadRequest("Invalid Role Name");

            bool exists = clsRolesBusiness.IsRoleNameExists(roleName);

            return Ok(new { Exists = exists });
        }

        [HttpPost("Add", Name = "AddRole")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<RoleListDTO> AddRole(AddNewRoleDTO dto)
        {
            if (dto == null)
                return BadRequest("Invalid Data");

            if (clsRolesBusiness.IsRoleNameExists(dto.RoleName))
                return BadRequest("Role Name already exists");

            clsRolesBusiness role = new clsRolesBusiness(
                new RoleListDTO(0, dto.RoleName)
            );

            if (!role.Save())
                return BadRequest("Failed to add role");

            return CreatedAtRoute("GetRoleById", new { Id = role.RoleID }, role.RoleListDto);
        }

        [HttpPut("Update/{Id}", Name = "UpdateRole")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult UpdateRole(int Id, UpdateRoleDTO dto)
        {
            if (Id < 1 || dto == null)
                return BadRequest("Invalid Data");

            var role = clsRolesBusiness.Find(Id);

            if (role == null)
                return NotFound("Role Not Found");

            var existing = clsRolesBusiness.FindByName(dto.RoleName);
            if (existing != null && existing.RoleID != Id)
                return BadRequest("Role Name already exists");

            role.RoleName = dto.RoleName;

            if (!role.Save())
                return BadRequest("Update Failed");

            return Ok("Updated Successfully");
        }

        [HttpDelete("Delete/{Id}", Name = "DeleteRole")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult DeleteRole(int Id)
        {
            if (Id < 1)
                return BadRequest("Invalid ID");

            if (!clsRolesBusiness.DeleteRole(Id))
                return NotFound("Role Not Found");

            return Ok("Deleted Successfully");
        }
    }
}
