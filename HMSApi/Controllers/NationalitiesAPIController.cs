using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using HMSBusinessLayer;
using HMSDataAccessLayer;
using System.Collections.Generic;

namespace HMSApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NationalityAPIController : ControllerBase
    {
        [HttpGet("All", Name = "GetAllNationalities")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<IEnumerable<NationalityListDTO>> GetAllNationalities()
        {
            var list = clsNationalitiesBusiness.GetAllNationalities();

            if (list == null || list.Count == 0)
                return NotFound("No Nationalities");

            return Ok(list);
        }

        [HttpGet("{Id}", Name = "GetNationalityById")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<NationalityListDTO> GetNationalityById(int Id)
        {
            if (Id < 1)
                return BadRequest("Invalid ID");

            var nationality = clsNationalitiesBusiness.Find(Id);

            if (nationality == null)
                return NotFound("Nationality Not Found");

            return Ok(nationality.NationalityListDto);
        }

        [HttpGet("ByName/{nationalityName}", Name = "GetNationalityByName")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<NationalityListDTO> GetNationalityByName(string nationalityName)
        {
            if (string.IsNullOrWhiteSpace(nationalityName))
                return BadRequest("Invalid Nationality Name");

            var nationality = clsNationalitiesBusiness.FindByName(nationalityName);

            if (nationality == null)
                return NotFound("Nationality Not Found");

            return Ok(nationality.NationalityListDto);
        }

        [HttpGet("Exists/{nationalityName}", Name = "IsNationalityNameExists")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult IsNationalityNameExists(string nationalityName)
        {
            if (string.IsNullOrWhiteSpace(nationalityName))
                return BadRequest("Invalid Nationality Name");

            bool exists = clsNationalitiesBusiness.IsNationalityNameExists(nationalityName);

            return Ok(new { Exists = exists });
        }

        [HttpPost("Add", Name = "AddNationality")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<NationalityListDTO> AddNationality(AddNewNationalityDTO dto)
        {
            if (dto == null)
                return BadRequest("Invalid Data");

            if (clsNationalitiesBusiness.IsNationalityNameExists(dto.NationalityName))
                return BadRequest("Nationality Name already exists");

            clsNationalitiesBusiness nationality = new clsNationalitiesBusiness(
                new NationalityListDTO(0, dto.NationalityName)
            );

            if (!nationality.Save())
                return BadRequest("Failed to add nationality");

            return CreatedAtRoute("GetNationalityById", new { Id = nationality.NationalityID }, nationality.NationalityListDto);
        }

        [HttpPut("Update/{Id}", Name = "UpdateNationality")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult UpdateNationality(int Id, UpdateNationalityDTO dto)
        {
            if (Id < 1 || dto == null)
                return BadRequest("Invalid Data");

            var nationality = clsNationalitiesBusiness.Find(Id);

            if (nationality == null)
                return NotFound("Nationality Not Found");

            var existing = clsNationalitiesBusiness.FindByName(dto.NationalityName);
            if (existing != null && existing.NationalityID != Id)
                return BadRequest("Nationality Name already exists");

            nationality.NationalityName = dto.NationalityName;

            if (!nationality.Save())
                return BadRequest("Update Failed");

            return Ok("Updated Successfully");
        }

        [HttpDelete("Delete/{Id}", Name = "DeleteNationality")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult DeleteNationality(int Id)
        {
            if (Id < 1)
                return BadRequest("Invalid ID");

            if (!clsNationalitiesBusiness.DeleteNationality(Id))
                return NotFound("Nationality Not Found");

            return Ok("Deleted Successfully");
        }
    }
}
