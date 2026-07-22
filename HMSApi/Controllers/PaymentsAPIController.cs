using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using HMSBusinessLayer;
using HMSDataAccessLayer;
using System;
using System.Collections.Generic;

namespace HMSApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentAPIController : ControllerBase
    {
        [HttpGet("All", Name = "GetAllPayments")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<IEnumerable<PaymentListDTO>> GetAllPayments()
        {
            var list = clsPaymentsBusiness.GetAllPayments();

            if (list == null || list.Count == 0)
                return NotFound("No Payments");

            return Ok(list);
        }

        [HttpGet("{Id}", Name = "GetPaymentById")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<PaymentListDTO> GetPaymentById(int Id)
        {
            if (Id < 1)
                return BadRequest("Invalid ID");

            var payment = clsPaymentsBusiness.Find(Id);

            if (payment == null)
                return NotFound("Payment Not Found");

            return Ok(payment.PaymentListDto);
        }

        [HttpGet("ByReservation/{reservationId}", Name = "GetPaymentsByReservationId")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<IEnumerable<PaymentListDTO>> GetPaymentsByReservationId(int reservationId)
        {
            if (reservationId < 1)
                return BadRequest("Invalid Reservation ID");

            var list = clsPaymentsBusiness.GetByReservationID(reservationId);

            if (list == null || list.Count == 0)
                return NotFound("No Payments Found For This Reservation");

            return Ok(list);
        }

        [HttpPost("Add", Name = "AddPayment")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<PaymentListDTO> AddPayment(AddNewPaymentDTO dto)
        {
            if (dto == null)
                return BadRequest("Invalid Data");

            if (dto.Amount <= 0)
                return BadRequest("Amount must be greater than zero");

            clsPaymentsBusiness payment = new clsPaymentsBusiness(
                new PaymentListDTO(
                    0,
                    dto.ReservationID,
                    dto.Amount,
                    dto.PaymentMethod,
                    DateTime.Now
                )
            );

            if (!payment.Save())
                return BadRequest("Failed to add payment");

            return CreatedAtRoute("GetPaymentById", new { Id = payment.PaymentID }, payment.PaymentListDto);
        }

        [HttpPut("Update/{Id}", Name = "UpdatePayment")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult UpdatePayment(int Id, UpdatePaymentDTO dto)
        {
            if (Id < 1 || dto == null)
                return BadRequest("Invalid Data");

            if (dto.Amount <= 0)
                return BadRequest("Amount must be greater than zero");

            var payment = clsPaymentsBusiness.Find(Id);

            if (payment == null)
                return NotFound("Payment Not Found");

            payment.ReservationID = dto.ReservationID;
            payment.Amount = dto.Amount;
            payment.PaymentMethod = dto.PaymentMethod;

            if (!payment.Save())
                return BadRequest("Update Failed");

            return Ok("Updated Successfully");
        }

        [HttpDelete("Delete/{Id}", Name = "DeletePayment")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult DeletePayment(int Id)
        {
            if (Id < 1)
                return BadRequest("Invalid ID");

            if (!clsPaymentsBusiness.DeletePayment(Id))
                return NotFound("Payment Not Found");

            return Ok("Deleted Successfully");
        }
    }
}
