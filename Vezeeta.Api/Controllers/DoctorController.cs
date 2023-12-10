using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using Vezeeta.Application.services;
using Vezeeta.Domain;
using Vezeeta.Dto;

namespace Vezeeta.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles ="Doctor")]
    public class DoctorController : ControllerBase
    {
        private readonly IDoctorService doctorService;

        public DoctorController(IDoctorService doctorService)
        {
            this.doctorService = doctorService;
        }
        ////---------login-----------------
        //[HttpPost("DoctorLogin")]
        //public async Task<IActionResult> LoginDoctor([FromBody]DoctorLoginDto doctorLoginDto)
        //{
        //    if(!ModelState.IsValid) 
        //        return BadRequest(ModelState);

        //    var result = await doctorService.DoctorLogin(doctorLoginDto);
        //    if (!result.Check)
        //        return BadRequest(result.Message);
            
        //    return Ok(result.Check);
        //}
        //----------------bookigns--------------
        [HttpGet("DoctorBookigns")]
        public async Task<IActionResult> DoctorBookigns( DateTime? dateTime , int page= 1, int pageSize =5)
        {
            var Userid = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var Bookings = await doctorService.DoctorBookigns(Userid, dateTime, page, pageSize);

            return Ok(Bookings);
        }
        //---------------- confirm Booking -------------
        [HttpPost("ConfirmBooking/{id}")]
        public async Task<IActionResult> ConfirmBooking(int id)
        {
            var BookingState = await doctorService.ConfirmBookigns(id);
            if(BookingState == false)
            {
                return BadRequest(new { message = "Wrong id or It is confirmed" });
            }

            return Ok(BookingState);
        }
        // -------------- adding appointment and time ------------

        [HttpPost("AddTimeAppointment")]
        public async Task<IActionResult> AddTimeAppointment([FromForm]AppointTimeCreateDto appointTimeCreateDto)
        {
            if(!ModelState.IsValid)
                return BadRequest(ModelState);
            var Userid = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var Bookings = await doctorService.AddAppointmentTime(Userid, appointTimeCreateDto);

            return Ok(Bookings);
        }
        //------------uodate---------
        [HttpPut("UpdateTime/{id}")]
        public async Task<IActionResult> UpdateTime(int id, DateTime time)
        {

            var state = await doctorService.UpdateTime(id,time);

            if(state == false) return BadRequest( state );
            
            return Ok(state);
        }
        // ------------delete
        [HttpDelete("DeleteTimeAppointment/{id}")]
        public async Task<IActionResult> DeleteTime(int id)
        {

            var state = await doctorService.DeleteTime(id);

            if (state == false) return BadRequest(state);

            return Ok(state);
        }
    }
}
