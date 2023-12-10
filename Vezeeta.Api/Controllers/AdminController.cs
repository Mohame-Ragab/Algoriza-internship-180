using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using Vezeeta.Application.interfaces;
using Vezeeta.Application.services;
using Vezeeta.Dto;

namespace Vezeeta.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles ="Admin")]
    public class AdminController : ControllerBase
    {
        private readonly IAdminService adminService;

        public AdminController(IAdminService adminService)
        {
            this.adminService = adminService;
        }

        // -----------------Dashboard-------------------
        [HttpGet("NumOfDoctors")]
        public async Task<IActionResult> NumOfDoctors()
        {
            var numberOfDoctors = await adminService.NumOfDoctors();
            return Ok(numberOfDoctors);
        }

        [HttpGet("NumOfPatients")]
        public async Task<IActionResult> NumOfPatients()
        {
            var numberOfPatients = await adminService.NumOfPatients();
            return Ok(numberOfPatients);
        }

        [HttpGet("NumOfRequests")]
        public async Task<IActionResult> NumOfRequests()
        {
            var Requests = await adminService.NumOfRequests();
            return Ok(Requests);
        }

        [HttpGet("Top5Specializations")]
        public async Task<IActionResult> Top5Specializations()
        {
            var Top5Spec = await adminService.Top5Specializations();
            return Ok(Top5Spec);
        }

        [HttpGet("Top10Doctors")]
        public async Task<IActionResult> Top10Doctors()
        {
            var Top10Docs = await adminService.Top10Doctors();
            return Ok(Top10Docs);
        }

        //----------------Doctors--------------------------
        [HttpGet("GetAllDoctors")]
        public async Task<IActionResult> GetAllDoctorsPaginted(int page = 1, int pageSize = 5, string search = null)
        {
            var doctorPaginated = await adminService.GetAllDoctorsPaginted(page, pageSize, search);

            return Ok(doctorPaginated);
        }

        [HttpGet("GetDoctorById/{id:int}")]
        public async Task<IActionResult> GetDoctorById(int id)
        {
            var doctorById = await adminService.GetDoctorById(id);
            if (doctorById is null)
                return BadRequest("Id is Wrong or Doctor Not Found");

            return Ok(doctorById);
        }

        [HttpPost("AddDoctor")]
        public async Task<IActionResult> AddDoctor([FromBody] DoctorCreateUpDto doctorCreateUpDto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var result = await adminService.AddNewDoctor(doctorCreateUpDto);
            if (!result.IsCreated)
                return BadRequest(result);

            return Ok(result);
        }

        [HttpPut("EditdDoctor/{id}")]
        public async Task<IActionResult> EditDoctor(int id ,[FromBody] DoctorCreateUpDto doctorCreateUpDto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var result = await adminService.EditDoctor(id ,doctorCreateUpDto);
            if (!result.IsCreated)
                return BadRequest(result.Message);

            return Ok(result.Message);
        }

        [HttpDelete("DeleteDoctor/{id}")]
        public async Task<IActionResult> DelteDoctor(int id)
        {
            var result = await adminService.DelteDoctor(id);
            if (!result.IsCreated)
                return BadRequest(result.Message);

            return Ok(result.Message);
        }
        //--------------patients--------------------
        [HttpGet("GetAllPatients")]
        public async Task<IActionResult> GetAllPatientsPaginted(int page = 1, int pageSize = 5, string search = null)
        {
            var PatentsPaginated = await adminService.GetAllPatientsPaginted(page, pageSize, search);

            return Ok(PatentsPaginated);
        }

        [HttpGet("GetPatientById/{id}")]
        public async Task<IActionResult> GetPatientById(int id)
        {
            var PatentsPaginated = await adminService.GetPatientById(id);

            return Ok(PatentsPaginated);
        }

        //---------------Set Discount-------------------
        [HttpPost("AddDiscount")]
        public async Task<IActionResult> AddDiscount(DiscountCreateUpDto discountCreateUpDto)
        {
            if(!ModelState.IsValid)
                return BadRequest(ModelState);
            
            var result = await adminService.AddDiscount(discountCreateUpDto);
            if(result.Satate== false)
                return BadRequest(result.Message);
            
            return Ok(result);

        }

        [HttpPut("UpdateDiscount/{id}")]
        public async Task<IActionResult> UpdateDiscount(int id ,DiscountCreateUpDto discountCreateUpDto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var result = await adminService.UpdateDiscount(id ,discountCreateUpDto);
            if (result.Satate == false)
                return BadRequest(result.Message);

            return Ok(result);
        }

        [HttpDelete("DeletDiscount/{id}")]
        public async Task<IActionResult> DeleteDiscount(int id)
        {
            var result = await adminService.DeleteDiscount(id);
            if (result.Satate == false)
                return BadRequest(result.Message);

            return Ok(result);
        }

        [HttpPost("DeActiveDiscount/{id}")]
        public async Task<IActionResult> DeActiveDiscount(int id)
        {
            var result = await adminService.DeActiveDiscount(id);
            if (result.Satate == false)
                return BadRequest(result.Message);

            return Ok(result);
        }
    }
}
