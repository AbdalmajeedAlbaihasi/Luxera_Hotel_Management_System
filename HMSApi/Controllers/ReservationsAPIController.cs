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
    public class ReservationAPIController : ControllerBase
    {

        [HttpGet("All")]
        public ActionResult<IEnumerable<ReservationListDTO>> GetAllReservations()
        {
            var list = clsReservationsBusiness.GetAllReservations();

            if (list == null || list.Count == 0)
                return NotFound("No Reservations");

            return Ok(list);
        }




        [HttpGet("{id}")]
        public ActionResult<OneReservationListDTO> GetReservationById(int id)
        {
            if (id < 1)
                return BadRequest("Invalid ID");

            var reservation = clsReservationsBusiness.Find(id);

            if (reservation == null)
                return NotFound("Reservation Not Found");

            return Ok(reservation.ReservationListDto);
        }




        [HttpPost("Add")]
        public ActionResult AddReservation(AddNewReservationDTO dto)
        {
            try
            {
                if (dto == null)
                    return BadRequest("DTO is null");

                if (dto.CheckOutDate <= dto.CheckInDate)
                    return BadRequest("Invalid dates");

                bool available = clsReservationsBusiness.IsRoomAvailable(
                    dto.RoomID,
                    dto.CheckInDate,
                    dto.CheckOutDate);

                if (!available)
                    return BadRequest("Room not available");

                clsReservationsBusiness reservation = new clsReservationsBusiness();

                reservation.RoomID = dto.RoomID;
                reservation.ClientId = dto.ClientId;
                reservation.CreatedByUserID = dto.CreatedByUserID;
                reservation.CheckInDate = dto.CheckInDate;
                reservation.CheckOutDate = dto.CheckOutDate;
                reservation.Status = dto.Status;

                bool saved = reservation.Save();

                if (!saved)
                    return BadRequest("Save Failed");

                return Ok(reservation.ReservationListDto);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }




        [HttpPut("Update/{id}")]
        public ActionResult UpdateReservation(int id, UpdateReservationDTO dto)
        {
            if (id < 1 || dto == null)
                return BadRequest("Invalid Data");

            if (dto.CheckOutDate <= dto.CheckInDate)
                return BadRequest("Invalid Dates");

            var reservation = clsReservationsBusiness.Find(id);

            if (reservation == null)
                return NotFound("Reservation Not Found");

            if (!clsReservationsBusiness.IsRoomAvailableForUpdate(
                id,
                dto.RoomID,
                dto.CheckInDate,
                dto.CheckOutDate))
                return BadRequest("Room not available");


            reservation.RoomID = dto.RoomID;
            reservation.ClientId = dto.ClientId;
            reservation.CreatedByUserID = dto.CreatedByUserID; 
            reservation.CheckInDate = dto.CheckInDate;
            reservation.CheckOutDate = dto.CheckOutDate;
            reservation.Status = dto.Status;

            if (!reservation.Save())
                return BadRequest("Update Failed");

            return Ok("Updated Successfully");
        }




        [HttpDelete("Delete/{id}")]
        public ActionResult DeleteReservation(int id)
        {
            if (id < 1)
                return BadRequest("Invalid ID");

            if (!clsReservationsBusiness.DeleteReservation(id))
                return NotFound("Reservation Not Found");

            return Ok("Deleted Successfully");
        }




        [HttpGet("RoomNumbers")]
        public ActionResult<IEnumerable<RoomNumberDTO>> GetRoomNumbers()
        {
            var list = clsReservationsBusiness.GetRoomNumbers();

            if (list == null || list.Count == 0)
                return NotFound("No Rooms");

            return Ok(list);
        }




        [HttpGet("Timeline")]
        public ActionResult GetHotelTimeline(DateTime startDate, DateTime endDate)
        {
            if (startDate == DateTime.MinValue || endDate == DateTime.MinValue)
                return BadRequest("Invalid dates");

            if (endDate < startDate)
                return BadRequest("End date must be after start date");


            var list = clsReservationsBusiness.GetHotelTimeline(startDate, endDate);

            return Ok(list);
        }
    }
}