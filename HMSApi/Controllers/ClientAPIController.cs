using HMSApi.Services;
using HMSBusinessLayer;
using HMSShared.DTOs.Client;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;


namespace HMSApi.Controllers
{
    [Authorize(Policy = "CanManageHotel")]
    [Route("api/[controller]")]
    [ApiController]
    public class ClientAPIController : ControllerBase
    {

        private readonly AuditBusiness _auditBusiness;
        private readonly UserContextService _userContext;


        public ClientAPIController(
    AuditBusiness auditBusiness,
    UserContextService userContext)
        {
            _auditBusiness = auditBusiness;
            _userContext = userContext;
        }




        [HttpPost("Add", Name = "AddClient")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<ClientListDTO> AddClient(AddNewClientDTO dto)
        {
            if (dto == null)
                return BadRequest("Invalid Data");


            clsClientsBusiness client = new clsClientsBusiness();

            client.CreatedByUserID = _userContext.GetCurrentUserID();
            client.FirstName = dto.FirstName;
            client.LastName = dto.LastName;
            client.BirthDate = dto.BirthDate;
            client.NationalityID = dto.NationalityID;
            client.PhoneNumber = dto.PhoneNumber;
            client.Gender = dto.Gender;

            if (!client.Save())
                return BadRequest("Failed to add client");

            _auditBusiness.AddLog(
                            _userContext.GetCurrentUserID(),
                            "ADD_CLIENT",
                            $"Added client {client.FirstName} {client.LastName}"
                        );

            return CreatedAtRoute("GetClientById", new { Id = client.ClientID }, client.ClientListDto);
        }




        [HttpPut("Update/{Id}", Name = "UpdateClient")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult UpdateClient(int Id, UpdateClientDTO dto)
        {
            if (Id < 1 || dto == null)
                return BadRequest("Invalid Data");

            var client = clsClientsBusiness.Find(Id);

            if (client == null)
                return NotFound("Client Not Found");

            client.CreatedByUserID = _userContext.GetCurrentUserID();
            client.FirstName = dto.FirstName;
            client.LastName = dto.LastName;
            client.BirthDate = dto.BirthDate;
            client.NationalityID = dto.NationalityID;
            client.PhoneNumber = dto.PhoneNumber;
            client.Gender = dto.Gender;

            if (!client.Save())
                return BadRequest("Update Failed");

            _auditBusiness.AddLog(
                    _userContext.GetCurrentUserID(),
                    "UPDATE_CLIENT",
                    $"Updated client ID {Id}"
                );


            return Ok("Updated Successfully");
        }




        [HttpDelete("Delete/{Id}", Name = "DeleteClient")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult DeleteClient(int Id)
        {
            if (Id < 1)
                return BadRequest("Invalid ID");

            if (!clsClientsBusiness.DeleteClient(Id))
                return NotFound("Client Not Found");

            _auditBusiness.AddLog(
                    _userContext.GetCurrentUserID(),
                    "DELETE_CLIENT",
                    $"Deleted client ID {Id}"
                );

            return Ok("Deleted Successfully");
        }




        [HttpGet("Get/ClientNames", Name = "GetClientNamesAndIDs")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<IEnumerable<ClientNameAndIDDTO>> GetClientNamesAndIDs()
        {
            var list = clsClientsBusiness.GetClientNamesAndIDs();

            if (list == null || list.Count == 0)
                return NotFound("No Clients Found");

            return Ok(list);
        }



        [HttpGet("All", Name = "GetAllClients")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<IEnumerable<ClientListDTO>> GetAllClients()
        {
            var list = clsClientsBusiness.GetAllClients();

            if (list == null || list.Count == 0)
                return NotFound("No Clients Found");

            return Ok(list);
        }




        [HttpGet("{Id}", Name = "GetClientById")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<ClientListDTO> GetClientById(int Id)
        {
            if (Id < 1)
                return BadRequest("Invalid ID");

            var client = clsClientsBusiness.Find(Id);

            if (client == null)
                return NotFound("Client Not Found");

            return Ok(client.ClientListDto);
        }


    }
}