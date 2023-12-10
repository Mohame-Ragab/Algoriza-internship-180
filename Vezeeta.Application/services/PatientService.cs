using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vezeeta.Application.interfaces;
using Vezeeta.Domain.enums;
using Vezeeta.Domain;
using Vezeeta.Dto;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.VisualBasic;
using System.Net.Http;
using System.Security.Claims;
using Microsoft.AspNetCore.Http;

namespace Vezeeta.Application.services
{
    public class PatientService : IPatientService
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly UserManager<AppUser> userManager;
        private readonly SignInManager<AppUser> signInManager;
        private readonly IHttpContextAccessor httpContext;

        public PatientService(IUnitOfWork unitOfWork , UserManager<AppUser> userManager , SignInManager<AppUser> signInManager,IHttpContextAccessor httpContext )
        {
            this.unitOfWork = unitOfWork;
            this.userManager = userManager;
            this.signInManager = signInManager;
            this.httpContext = httpContext;
        }

        public async Task<PatientVerfyModel> RegisterPatient(PatientCrtUpDto patientCrtUpDto)
        {
            if (await userManager.FindByEmailAsync(patientCrtUpDto.Email) is not null)
            {
                return new PatientVerfyModel { Message = "Email is found" };
            }

            var user = new AppUser
            {
                Email = patientCrtUpDto.Email,
                FirstName = patientCrtUpDto.FirstName,
                LastName = patientCrtUpDto.LastName,
                UserName = patientCrtUpDto.Email,
                Gender = patientCrtUpDto.Gender,
                Phone = patientCrtUpDto.Phone,
                AccountType = AccountType.Patient,
            };

            var result = await userManager.CreateAsync(user, patientCrtUpDto.Password);

            if (!result.Succeeded)
            {
                var errors = string.Empty;

                foreach (var error in result.Errors)
                    errors += $"{error.Description}, ";

                return new PatientVerfyModel { Message = errors };
            }

            await userManager.AddToRoleAsync(user, AccountType.Patient.ToString());

            Patient patient = new Patient
            {
                ImageUrl = patientCrtUpDto.Image??"Not Found",
                DateOfBirth = patientCrtUpDto.DateOfBirth,
                AppUserId = user.Id,

            };

            await unitOfWork.Patients.AddAsync(patient);
            unitOfWork.Complete();

            return new PatientVerfyModel { Message = "Patient Created Successfully", State = true };

        }

        public async Task<PatientVerfyModel> Login(PatientLoginDto patientLogin)
        {
            
            var user = await userManager.FindByEmailAsync(patientLogin.Email);
            if (user is null)
                return new PatientVerfyModel { Message = "Email Is Not Found" };

            if (!await userManager.CheckPasswordAsync(user, patientLogin.Password))
                return new PatientVerfyModel { Message = "Password Is Wrong" };

            var result = await signInManager.PasswordSignInAsync(user, patientLogin.Password, false, false);
            
            if (!result.Succeeded)
            {
                

                return new PatientVerfyModel { Message = "There is sumthing Wrong on Login" };
            }

                   //httpContext.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);


            return new PatientVerfyModel { Message = "Logged in Success Full", State = true };
        }

        public async Task<IEnumerable<object>> GetAllDoctorsPaginted(int page = 1, int pageSize = 5, string search = null)
        {
            var doctorPaginated = await unitOfWork.Doctors.GetAllPaginateFiltered(page, pageSize);
            var doctors = doctorPaginated.Select(s => new
            {
                image = s.ImageUrl,
                FullName = s.AppUser.FirstName + " " + s.AppUser.LastName,
                s.AppUser.Email,
                s.AppUser.Phone,
                Specialization = s.Specialization.Name,
                Gender = s.AppUser.Gender.ToString(),
                price = s.Price,
                Appointments = s.Appointments?.Select(a => new
                {
                    day = a.AppointDate,
                    times = a.Times?.Where(t => t.Request is null).Select(t => new
                    {
                        t.Id,
                        time =t.TimeOfAppointment
                    })
                })
            }) ;

            return doctors;
        }

        public async Task<PatientVerfyModel> Booking(string id ,RequestCrtDto requestCrt)
        {
            var patients = await unitOfWork.Patients.GetAllAsync();
            var patient = patients.FirstOrDefault( p => p.AppUserId == id);

            if (patient is null)
                return new PatientVerfyModel { Message = "Wrong Patient id" };

            var time = await unitOfWork.Times.GetByIdAsync(requestCrt.TimeId);
            if (time is null || time.Request is not null)
                return new PatientVerfyModel { Message = "Wrong Time id or it is Booked" };

            var discounts = await unitOfWork.Discounts.GetAllAsync();
            var discount = await discounts.FirstOrDefaultAsync(d => d.DicountCode == requestCrt.DiscountCode);
            


            if (discount is null || patient.Requests.Any(r => r.DiscountId == discount.Id))
            {
                Request request = new Request
                {
                    Price =time.Appointment.Doctor.Price??0,
                    TimeId = requestCrt.TimeId,
                    PatientId=patient.Id,
                    RequestStatus= RequestStatus.Pending,
                    DoctorId = time.Appointment.DoctorId
                    
                };
                await unitOfWork.Requests.AddAsync(request);
                
            }
            else
            {
                Request request = new Request
                {
                    Price =(double) time.Appointment.Doctor.Price  ,
                    TimeId = requestCrt.TimeId,
                    PatientId = patient.Id,
                    RequestStatus = RequestStatus.Pending,
                    FinalPrice = discount.DiscountType == DiscountType.Value?
                                    (double)time.Appointment.Doctor.Price - discount.Value :
                                    (double)time.Appointment.Doctor.Price - discount.Value/100

                };
                await unitOfWork.Requests.AddAsync(request);
            }
            unitOfWork.Complete();
            return new PatientVerfyModel { Message = "Booking done " ,State =true };
        }

        public async Task<IEnumerable<object>> PateintBookings(string id)
        {
            var patients = await unitOfWork.Patients.GetAllAsync();
            var patient = patients.FirstOrDefault(p => p.AppUserId == id);

            var requests = await unitOfWork.Requests.GetAllAsync();
            var PatientRequests = await requests.Where( r => r.PatientId == patient.Id ).ToListAsync();
            if (PatientRequests.IsNullOrEmpty())
                return PatientRequests;

            return PatientRequests.Select(r => new PatientRequestDto
            {
                Image = r.Doctor.ImageUrl,
                DoctorName = r.Doctor.AppUser.FirstName+" "+r.Doctor.AppUser.LastName,
                Specilization = r.Doctor.Specialization.Name,
                Day = r.Time?.Appointment.AppointDate,
                time =r.Time?.TimeOfAppointment,
                Price= r.Price,
                DiscountCode=r.Discount?.DicountCode,
                FinalPrice=r.FinalPrice,
                Status=r.RequestStatus.ToString(),

            });
        }

        public async Task<PatientVerfyModel> CancelBooking(int id)
        {
            var request = await unitOfWork.Requests.GetByIdAsync(id);

            if (request is null)
                return new PatientVerfyModel { Message = " Wrong ID " };
            
            if (request.RequestStatus == RequestStatus.Canceled)
                return new PatientVerfyModel { Message = " It Was Cancelled " };

            request.RequestStatus = RequestStatus.Canceled;
            request.TimeId = null;
            unitOfWork.Complete();
            return new PatientVerfyModel { Message = "It Cancelled SuccessFully ", State =true};

        }

    }
}
