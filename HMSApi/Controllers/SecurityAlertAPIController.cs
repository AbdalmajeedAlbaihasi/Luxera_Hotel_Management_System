using HMSBusinessLayer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace HMSApi.Controllers
{
    [Authorize(Policy = "CanManageUsers")]
    [ApiController]
    [Route("api/[controller]")]
    public class SecurityAlertAPIController : ControllerBase
    {
        private readonly SecurityAlertBusiness _business;

        public SecurityAlertAPIController(
            SecurityAlertBusiness business)
        {
            _business = business;
        }

        [HttpGet("All")]
        public IActionResult GetAll()
        {
            return Ok(_business.GetAllAlerts());
        }

        [HttpGet("Unread")]
        public IActionResult GetUnread()
        {
            return Ok(_business.GetUnreadAlerts());
        }

        [HttpPut("Review/{id}")]
        public IActionResult Review(int id)
        {
            if (!_business.MarkAsReviewed(id))
                return NotFound();

            return Ok();
        }
    }
}