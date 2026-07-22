using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using HMSBusinessLayer;
using HMSDataAccessLayer;
using System.Collections.Generic;

namespace HMSApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientAPIController : ControllerBase
    {

        [HttpPost("Add", Name = "AddClient")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<ClientListDTO> AddClient(AddNewClientDTO dto)
        {
            if (dto == null)
                return BadRequest("Invalid Data");


            clsClientsBusiness client = new clsClientsBusiness();

            client.CreatedByUserID = dto.CreatedByUserID;
            client.FirstName = dto.FirstName;
            client.LastName = dto.LastName;
            client.BirthDate = dto.BirthDate;
            client.NationalityID = dto.NationalityID;
            client.PhoneNumber = dto.PhoneNumber;
            client.Gender = dto.Gender;

            if (!client.Save())
                return BadRequest("Failed to add client");

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

            client.CreatedByUserID = dto.CreatedByUserID;
            client.FirstName = dto.FirstName;
            client.LastName = dto.LastName;
            client.BirthDate = dto.BirthDate;
            client.NationalityID = dto.NationalityID;
            client.PhoneNumber = dto.PhoneNumber;
            client.Gender = dto.Gender;

            if (!client.Save())
                return BadRequest("Update Failed");

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