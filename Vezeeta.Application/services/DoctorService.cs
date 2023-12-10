using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Vezeeta.Application.interfaces;
using Vezeeta.Domain;
using Vezeeta.Domain.enums;
using Vezeeta.Dto;

namespace Vezeeta.Application.services
{
    public class DoctorService : IDoctorService
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly UserManager<AppUser> userManager;

        public DoctorService(IUnitOfWork unitOfWork ,UserManager<AppUser> userManager )
        {
            this.unitOfWork = unitOfWork;
            this.userManager = userManager;
        }
        // login
        //public async Task<DoctorLogCheckModel> DoctorLogin(DoctorLoginDto doctorLoginDto)
        //{
        //    var user = await userManager.FindByEmailAsync( doctorLoginDto.Email );
        //    if( user is null )
        //        return new DoctorLogCheckModel { Message = "Email Is Not Found"};

        //    if(!await userManager.CheckPasswordAsync(user , doctorLoginDto.Password))
        //        return new DoctorLogCheckModel { Message = "Password Is Wrong" };

        //    return new DoctorLogCheckModel { Message = "Logged in Success Full", Check=true};
        //}

        public async Task<object> DoctorBookigns(string id, DateTime? dateTime, int page = 1, int pageSize = 5)
        {
            var requests =await unitOfWork.Requests.GetAllAsync();
            var doctorRequests = requests.Where(r => r.Time.Appointment.Doctor.AppUserId == id);

            if (doctorRequests.IsNullOrEmpty())
                return new { message = "This doctor has no Bookings." };

            if(!dateTime.HasValue)
            {
                var paginatedReqs = doctorRequests.Skip(pageSize *(page - 1)).Take(pageSize).ToList();

                return paginatedReqs.Select( r => new
                {
                    pateintName = r.Patient.AppUser.FirstName+" "+r.Patient.AppUser.LastName,
                    image = r.Patient.ImageUrl,
                    DateOfbirth = r.Patient.DateOfBirth,
                    gender = r.Patient.AppUser.Gender.ToString(),
                    Phone = r.Patient.AppUser.Phone,
                    Email = r.Patient.AppUser.Email,
                    AppoinmentDate = r.Time?.TimeOfAppointment

                });
            }
            else
            {
                var paginatedReqs = doctorRequests.Where(r =>r.Time.Appointment.AppointDate.Day == dateTime.Value.Day)
                    .Skip(pageSize * (page - 1)).Take(pageSize).ToList();

                return paginatedReqs.Select(r => new
                {
                    pateintName = r.Patient.AppUser.FirstName + " " + r.Patient.AppUser.LastName,
                    image = r.Patient.ImageUrl,
                    DateOfbirth = r.Patient.DateOfBirth,
                    gender = r.Patient.AppUser.Gender.ToString(),
                    Phone = r.Patient.AppUser.Phone,
                    Email = r.Patient.AppUser.Email,
                    AppoinmentDate = r.Time?.TimeOfAppointment

                });
            }
        }
        public async Task<bool> ConfirmBookigns(int id)
        {
            var bookingById = await unitOfWork.Requests.GetByIdAsync(id); 

            if(bookingById is null || bookingById.IsConfirmed == true)
            {
                return false;
            }
            else
            {
                bookingById.IsConfirmed = true;
                unitOfWork
                    .Complete();
                return true; 
            }
        }
        // time appoint ment
        public async Task<bool> AddAppointmentTime(string id ,AppointTimeCreateDto appointTimeCreateDto)
        {
            var doctors = await unitOfWork.Doctors.GetAllAsync();
            var doctor = doctors.FirstOrDefault(d => d.AppUserId == id);
            
            //var doctor = await unitOfWork.Doctors.GetByIdAsync(id);
            if(doctor is null)
                return false;

            var appointmetn = new Appointment 
            {
                DoctorId = doctor.Id ,
                Day = (Days)appointTimeCreateDto.AppointDate.DayOfWeek,
                AppointDate = appointTimeCreateDto.AppointDate,
            };
             await unitOfWork.Appointments.AddAsync(appointmetn);
            unitOfWork.Complete();

            foreach (var item in appointTimeCreateDto.Time)
            {
                var time = new Time
                {
                    AppointmentId = appointmetn.Id,
                    TimeOfAppointment = item
                };

                await unitOfWork.Times.AddAsync(time);
                unitOfWork.Complete();
            }

            
                
            return true;

        }

        public async Task<bool> UpdateTime(int id, DateTime time)
        {
            var timeById = await unitOfWork.Times.GetByIdAsync (id);

            if (timeById is null) return false;
            
            if (timeById.Request is not null) return false;
            
            timeById.TimeOfAppointment = time.TimeOfDay;
            unitOfWork.Complete();
            return true;
        }

        public async Task<bool> DeleteTime(int id)
        {
            var timeById = await unitOfWork.Times.GetByIdAsync(id);

            if (timeById is null) return false;

            if (timeById.Request is not null) return false;

            await unitOfWork.Times.DeleteAsync(id);
            unitOfWork.Complete();
            return true;
        }


    }
}
