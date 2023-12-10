using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.Security.Claims;
using Vezeeta.Application.services;
using Vezeeta.Dto;

namespace Vezeeta.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles ="Patient")]
    public class PatientController : ControllerBase
    {
        private readonly IPatientService patientService;

        public PatientController(IPatientService patientService )
        {
            this.patientService = patientService;
        }

        [HttpPost("Register")]
        [AllowAnonymous]
        public async Task<IActionResult> Register([FromBody] PatientCrtUpDto patientCrtUpDto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);    
            
            var result = await patientService.RegisterPatient(patientCrtUpDto);
            if (!result.State)
                return BadRequest(result);
            return Ok(result);

        }
        
        [HttpPost("Login")]
        [AllowAnonymous]
        public async Task<IActionResult> Login([FromBody] PatientLoginDto patientLogin)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var result = await patientService.Login(patientLogin);
            if (!result.State)
                return BadRequest(result);

            return Ok(result);

        }

        [HttpGet("GetAllDoctors")]
        public async Task<IActionResult> GetAllDoctorsPaginated(int page=1 , int pageSize= 5 ,string search = null)
        {
            

            var result = await patientService.GetAllDoctorsPaginted(page,pageSize,search);
            return Ok(result);

        }

        [HttpPost("Booking")]
        public async Task<IActionResult> Booking([FromBody] RequestCrtDto requestCrt)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var Userid = User.FindFirstValue(ClaimTypes.NameIdentifier);

            var result = await patientService.Booking(Userid ,requestCrt);
            if (!result.State)
                return BadRequest(result);

            return Ok(result);

        }

        [HttpGet("PateintRequests")]
        public async Task<IActionResult> PateintRequests()
        {
            var Userid = User.FindFirstValue(ClaimTypes.NameIdentifier);

            var result = await patientService.PateintBookings(Userid);
            if (result.IsNullOrEmpty())
                return BadRequest("The Patient Has No Bookings");

            return Ok(result);

        }

        [HttpDelete("CancelRequests/{id}")]
        public async Task<IActionResult> Cancel(int id)
        {
            var result = await patientService.CancelBooking(id);
            if (result.State == false)
                return BadRequest(result.Message);

            return Ok(result);

        }
    }
    
}
