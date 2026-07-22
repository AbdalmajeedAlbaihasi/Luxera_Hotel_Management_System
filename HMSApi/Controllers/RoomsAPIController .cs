using HMSBusinessLayer;
using HMSDataAccessLayer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HMSApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomAPIController : ControllerBase
    {
        [HttpGet("All")]
        public ActionResult<IEnumerable<RoomListDTO>> GetAllRooms()
        {
            var list = clsRoomsBusiness.GetAllRooms();

            if (list == null || list.Count == 0)
                return NotFound("No Rooms");

            return Ok(list);
        }




        [HttpGet("{id}")]
        public ActionResult<RoomListDTO> GetRoomById(int id)
        {
            if (id < 1)
                return BadRequest("Invalid ID");

            var room = clsRoomsBusiness.Find(id);

            if (room == null)
                return NotFound("Room Not Found");

            return Ok(room.RoomListDto);
        }




        [HttpPost("Add")]
        public ActionResult AddRoom([FromBody] AddNewRoomDTO dto)
        {
            if (dto == null)
                return BadRequest("Invalid Data");

            if (clsRoomsBusiness.IsRoomNumberExists(dto.RoomNumber))
                return Conflict("Room Number already exists");

            clsRoomsBusiness room = new clsRoomsBusiness(dto);

            if (!room.Save())
                return BadRequest("Failed To Add");

            return Ok();
        }




        [HttpPut("Update/{id}")]
        public async Task<ActionResult> UpdateRoom(int id, [FromBody] UpdateRoomDTO dto)
        {
            if (id < 1)
                return BadRequest(new { Error = "Invalid ID" });

            if (dto == null)
                return BadRequest(new { Error = "Request body is null or could not be deserialized" });


            if (dto.RoomID != 0 && dto.RoomID != id)
                return BadRequest(new { Error = "Route id does not match payload RoomID" });

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var room = clsRoomsBusiness.Find(id);
            if (room == null)
                return NotFound(new { Error = "Room Not Found" });

            try
            {

                if (!string.Equals(room.RoomNumber, dto.RoomNumber, StringComparison.OrdinalIgnoreCase)
                    && clsRoomsBusiness.IsRoomNumberExists(dto.RoomNumber))
                {
                    return BadRequest(new { Error = "Room Number already exists" });
                }

                room.RoomID = id;
                room.RoomNumber = dto.RoomNumber;
                room.RoomTypeID = dto.RoomTypeID;
                room.PricePerNight = dto.PricePerNight;
                room.Status = dto.Status;
                room.Capacity = dto.Capacity;

                bool saved = room.Save();
                if (!saved)
                    return BadRequest(new { Error = "Update Failed (business layer returned false)" });

                return Ok(new { Message = "Updated Successfully" });
            }
            catch (Exception ex)
            {
                return BadRequest(new { Error = "Exception during update", Details = ex.Message });
            }
        }




        [HttpDelete("Delete/{Id}")]
        public ActionResult DeleteRoom(int Id)
        {
            if (Id < 1)
                return BadRequest("Invalid ID");

            try
            {
                bool deleted = clsRoomsBusiness.DeleteRoom(Id);

                if (!deleted)
                    return BadRequest("Cannot delete room because it has reservations");

                return Ok("Deleted Successfully");
            }
            catch (SqlException ex)
            {
                return BadRequest("Cannot delete room because it is linked to reservations");
            }
        }
    }
}