using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using HMSBusinessLayer;
using HMSDataAccessLayer;
using System.Collections.Generic;

namespace HMSApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomTypeAPIController : ControllerBase
    {
        [HttpGet("All")]
        public ActionResult<IEnumerable<RoomTypeListDTO>> GetAllRoomTypes()
        {
            var list = clsRoomTypesBusiness.GetAllRoomTypes();

            if (list == null || list.Count == 0)
                return NotFound("No Room Types");

            return Ok(list);
        }




        [HttpGet("{id}")]
        public ActionResult<RoomTypeListDTO> GetRoomTypeById(int id)
        {
            if (id < 1)
                return BadRequest("Invalid ID");

            var roomType = clsRoomTypesBusiness.Find(id);

            if (roomType == null)
                return NotFound("Room Type Not Found");

            return Ok(roomType.RoomTypeListDto);
        }




        [HttpGet("ByName/{typeName}")]
        public ActionResult<RoomTypeListDTO> GetRoomTypeByName(string typeName)
        {
            if (string.IsNullOrWhiteSpace(typeName))
                return BadRequest("Invalid Type Name");

            var roomType = clsRoomTypesBusiness.FindByName(typeName);

            if (roomType == null)
                return NotFound("Room Type Not Found");

            return Ok(roomType.RoomTypeListDto);
        }




        [HttpPost("Add")]
        public ActionResult AddRoomType([FromBody] AddNewRoomTypeDTO dto)
        {
            if (dto == null)
                return BadRequest("Invalid Data");

            if (clsRoomTypesBusiness.IsRoomTypeNameExists(dto.TypeName))
                return Conflict("Room Type Name already exists");

            clsRoomTypesBusiness roomType = new clsRoomTypesBusiness(dto);

            if (!roomType.Save())
                return BadRequest("Failed To Add");

            return Ok();
        }




        [HttpPut("Update/{id}")]
        public ActionResult UpdateRoomType(int id, [FromBody] UpdateRoomTypeDTO dto)
        {
            if (id < 1 || dto == null)
                return BadRequest("Invalid Data");

            var roomType = clsRoomTypesBusiness.Find(id);

            if (roomType == null)
                return NotFound("Room Type Not Found");

            var existing = clsRoomTypesBusiness.FindByName(dto.TypeName);

            if (existing != null && existing.RoomTypeID != id)
                return BadRequest("Room Type Name already exists");

            roomType.RoomTypeID = id;
            roomType.TypeName = dto.TypeName;

            if (!roomType.Save())
                return BadRequest("Update Failed");

            return Ok();
        }




        [HttpDelete("Delete/{id}")]
        public ActionResult DeleteRoomType(int id)
        {
            if (id < 1)
                return BadRequest("Invalid ID");

            if (!clsRoomTypesBusiness.DeleteRoomType(id))
                return NotFound("Room Type Not Found");

            return Ok();
        }
    }
}