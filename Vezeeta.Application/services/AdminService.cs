using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vezeeta.Application.interfaces;
using Vezeeta.Domain;
using Vezeeta.Domain.enums;
using Vezeeta.Dto;

namespace Vezeeta.Application.services
{
    public class AdminService : IAdminService
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly UserManager<AppUser> userManager;
        

        public AdminService(IUnitOfWork unitOfWork , UserManager<AppUser> userManager /*, RoleManager<IdentityRole> roleManager*/)
        {
            this.unitOfWork = unitOfWork;
            this.userManager = userManager;
            
        }

        //-----------------Dashpoard---------------
        public async Task<object> NumOfDoctors()
        {
            var numberOfDoctors = await unitOfWork.Doctors.Count();
            return new { Doctors = numberOfDoctors };
        }

        public async Task<object> NumOfPatients()
        {
            var numberOfPatients = await unitOfWork.Patients.Count();
            return new { Patients = numberOfPatients };
        }

        public async Task<object> NumOfRequests()
        {
            var Requests = await unitOfWork.Requests.GetAllRequestTypes();

            return Requests;
        }

        public async Task<IEnumerable<object>> Top5Specializations()
        {
            var requests = await unitOfWork.Requests.GetAllAsync();

            var Specializions = requests.GroupBy(req => req.Doctor.Specialization.Name,
                            r => r, (req, r) => new
                            {
                                FullName = req,
                                Requests = r.Count(),
                            }).Take(5).OrderByDescending(x => x.Requests).ToList();
            return  Specializions;
        }

        public async Task<IEnumerable<object>> Top10Doctors()
        {
            var requests = await unitOfWork.Requests.GetAllAsync();
            var ListRequests = requests.ToList();

            var Doctors = ListRequests.GroupBy(req => req.Doctor.Id,
                            r => r, (Doc, r) => new
                            {
                                Doctor = Doc,
                                Requests = r.Count(),
                            }).Take(10)
                            .OrderByDescending(x => x.Requests).ToList();
            Dictionary<Doctor, int> Top10 = new Dictionary<Doctor, int>();
            foreach (var item in Doctors)
            {
                var Doc = await unitOfWork.Doctors.GetByIdAsync(item.Doctor);
                Top10.Add(Doc, item.Requests);
            }


            return Top10.Select(d => new
            {
                FullName = d.Key.AppUser.FirstName + " " + d.Key.AppUser.LastName,
                Image = d.Key.ImageUrl,
                specialization = d.Key.Specialization.Name,
                Requests = d.Value
            });
        }

        //-------------------- Doctors---------------
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
                Gender = s.AppUser.Gender.ToString()
            });

            return doctors;
        }

        public async Task<object> GetDoctorById(int id)
        {
            var doctorById = await unitOfWork.Doctors.GetByIdAsync(id);
            
            var doctor = new
            {
                image = doctorById.ImageUrl,
                FullName = doctorById.AppUser.FirstName + " " + doctorById.AppUser.LastName,
                doctorById.AppUser.Email,
                doctorById.AppUser.Phone,
                Specialization = doctorById.Specialization.Name,
                Gender = doctorById.AppUser.Gender.ToString(),
                dateOfBirth= doctorById.DateOfBirth.ToString(),
            };

            return doctor;
        }

        public async Task<DoctorVerfyModel> AddNewDoctor( DoctorCreateUpDto doctorCreateUpDto)
        {
            if ( await userManager.FindByEmailAsync(doctorCreateUpDto.Email) is not null )
            {
                return new DoctorVerfyModel  { Message = "Email is found"};
            }

            var user = new AppUser
            {
                Email = doctorCreateUpDto.Email,
                FirstName = doctorCreateUpDto.FirstName,
                LastName = doctorCreateUpDto.LastName,
                UserName = doctorCreateUpDto.Email,
                Gender = doctorCreateUpDto.Gender,
                Phone = doctorCreateUpDto.Phone,
                AccountType = Domain.enums.AccountType.Doctor,

            };

            var result = await userManager.CreateAsync(user ,doctorCreateUpDto.Password );

            if (!result.Succeeded)
            {
                var errors = string.Empty;

                foreach (var error in result.Errors)
                    errors += $"{error.Description}, ";

                return new DoctorVerfyModel { Message = errors };
            }

            await userManager.AddToRoleAsync(user, AccountType.Doctor.ToString());

            Doctor doctor = new Doctor
            {
                ImageUrl = doctorCreateUpDto.Image,
                DateOfBirth = doctorCreateUpDto.DateOfBirth,
                SpecializationId= doctorCreateUpDto.SpecilzationId,
                AppUserId = user.Id,

            };

            await unitOfWork.Doctors.AddAsync( doctor );
            unitOfWork.Complete();

            return new DoctorVerfyModel { Message = "Doctor Created Successfully" , IsCreated = true };
        }

        public async Task<DoctorVerfyModel> EditDoctor(int id, DoctorCreateUpDto doctorCreateUpDto)
        {
            var doctor = await unitOfWork.Doctors.GetByIdAsync( id );
            if (doctor == null)
                return new DoctorVerfyModel { Message = "Id is not Found" };

            var doctorUser = await userManager.FindByIdAsync(doctor.AppUserId);
            
            doctorUser.Email = doctorCreateUpDto.Email;
            doctorUser.NormalizedEmail = doctorCreateUpDto.Email.ToUpper();

            doctorUser.Phone = doctorCreateUpDto.Phone;
            doctorUser.UserName = doctorCreateUpDto.Email;

            doctorUser.FirstName= doctorCreateUpDto.FirstName;
            doctorUser.LastName= doctorCreateUpDto.LastName;
            doctorUser.Gender = doctorCreateUpDto.Gender;
            PasswordHasher<AppUser> passwordHasher = new PasswordHasher<AppUser>();
            doctorUser.PasswordHash = passwordHasher.HashPassword(doctorUser, doctorCreateUpDto.Password);


            doctor.ImageUrl = doctorCreateUpDto.Image;
            doctor.SpecializationId = doctorCreateUpDto.SpecilzationId;
            doctor.DateOfBirth = doctorCreateUpDto.DateOfBirth;

            unitOfWork.Complete();

            return new DoctorVerfyModel { Message = "Updated succefully" ,IsCreated =true };
        }

        public async Task<DoctorVerfyModel> DelteDoctor(int id)
        {
            var doctor = await unitOfWork.Doctors.GetByIdAsync(id);
            if (doctor == null)
                return new DoctorVerfyModel { Message = "Id is not Found" };

            if (doctor.Appointments.Any(a => a.Times.Any(t => t.Request is not null)))
                return new DoctorVerfyModel { Message = " Doctor has Requests" };

            var doctorUser = await userManager.FindByIdAsync(doctor.AppUserId);
            if (doctorUser == null)
                return new DoctorVerfyModel { Message = " User Doctor is not found"};

            var result = await userManager.DeleteAsync(doctorUser);

            if (!result.Succeeded)
            {
                var errors = string.Empty;

                foreach (var error in result.Errors)
                    errors += $"{error.Description}, ";

                return new DoctorVerfyModel { Message = errors };
            }

            return new DoctorVerfyModel { Message = " User Doctor Delted Succefully" , IsCreated=true};
        }
        //------------------ patients--------------------
        public async Task<IEnumerable<object>> GetAllPatientsPaginted(int page = 1, int pageSize = 5, string search = null)
        {
            var patientsPaginated = await unitOfWork.Patients.GetAllPaginateFiltered(page, pageSize);
            var pateints = patientsPaginated.Select(s => new
            {
                image = s.ImageUrl,
                FullName = s.AppUser.FirstName + " " + s.AppUser.LastName,
                s.AppUser.Email,
                s.AppUser.Phone,
                Specialization = s.DateOfBirth,
                Gender = s.AppUser.Gender.ToString()
            });

            return pateints;
        }
        public async Task<object> GetPatientById(int id)
        {
            var patient = await unitOfWork.Patients.GetByIdAsync(id);
            if (patient == null)
                return new { message = "Id is Wrong" };
            
            IEnumerable<Request> requests = patient.Requests;
            if (requests.IsNullOrEmpty())
                return new
                {
                    details = new
                    {
                        Image = patient.ImageUrl,
                        fullName = patient.AppUser.FirstName + " " + patient.AppUser.LastName,
                        phone = patient.AppUser.Phone,
                        Gender = patient.AppUser.Gender.ToString(),
                        patient.AppUser.Email,
                        dateOfBirth = patient.DateOfBirth,
                    },

                    requests = "Hasn't any request"
                };

            var patientRequests = requests.Select(r => new
            {
                ImageDoctor = r.Time.Appointment.Doctor.ImageUrl,
                DoctorName = r.Time.Appointment.Doctor.AppUser.FirstName+" "
                +r.Time.Appointment.Doctor.AppUser.LastName,
                specialization = r.Time.Appointment.Doctor.Specialization.Name,
                day = r.Time.Appointment.Day.ToString(),
                time= r.Time.TimeOfAppointment.ToString(),
                price = r.Time.Appointment.Doctor.Price,
                discountCode = r.Discount is not null? r.Discount.DicountCode: "Not appliedt",
                finalPrice = r.FinalPrice is not null ? r.FinalPrice.ToString() : "not Applied discounts",
                requestStatus = r.RequestStatus.ToString(),
            });

            return new
            {
                details = new
                {
                    Image = patient.ImageUrl,
                    fullName = patient.AppUser.FirstName + " " + patient.AppUser.LastName,
                    phone = patient.AppUser.Phone,
                    Gender = patient.AppUser.Gender.ToString(),
                    patient.AppUser.Email,
                    dateOfBirth = patient.DateOfBirth,
                },

                requests = patientRequests
            };
        }
        //----------------- discount --------------------
        public async Task<DiscountCheckModel> AddDiscount(DiscountCreateUpDto discountCreateUpDto)
        {
            Discount newDiscount = new Discount
            {
                DicountCode = discountCreateUpDto.DicountCode,
                DiscountType = discountCreateUpDto.DiscountType,
                Value = discountCreateUpDto.Value,
                IsActive= discountCreateUpDto.IsActive,
                NuberOfCompReqs=discountCreateUpDto.NuberOfCompReqs,
            };
            var discount = await unitOfWork.Discounts.AddAsync(newDiscount);
            unitOfWork.Complete();
            if (discount == null)
            {
                return new DiscountCheckModel { Message = "Try Again It Didn't Creaed" };
            }

            else
                return new DiscountCheckModel { Message = "Created SuccessFully ", Satate = true };
        }

        public async Task<DiscountCheckModel> UpdateDiscount(int id ,DiscountCreateUpDto discountCreateUpDto)
        {
            var oldDisc = await unitOfWork.Discounts.GetByIdAsync(id);
            if (oldDisc is null) 
                return  new DiscountCheckModel { Message = "id Is Wrong" };
            
            if(oldDisc.Requests.IsNullOrEmpty() == false)
                return new DiscountCheckModel { Message = "Sorry this is applied on Requests" };

            oldDisc.DicountCode = discountCreateUpDto.DicountCode;
            oldDisc.DiscountType = discountCreateUpDto.DiscountType;
            oldDisc.Value = discountCreateUpDto.Value;
            oldDisc.IsActive = discountCreateUpDto.IsActive;
            oldDisc.NuberOfCompReqs = discountCreateUpDto.NuberOfCompReqs;
            //var discount =   unitOfWork.Discounts.UpdateAsync(newDiscount);
            unitOfWork.Complete();
            
                return new DiscountCheckModel { Message = "Updated SuccessFully ", Satate = true };
        }

        public async Task<DiscountCheckModel> DeleteDiscount(int id)
        {
            var oldDisc = await unitOfWork.Discounts.GetByIdAsync(id);
            if (oldDisc is null)
                return new DiscountCheckModel { Message = "ID is Wrong" };
            var result = await unitOfWork.Discounts.DeleteAsync(id);
            if (result== false )
                return new DiscountCheckModel { Message = "Try Again It Didn't deleted" };
            else
                unitOfWork.Complete();
            return new DiscountCheckModel { Message = "deleted SuccessFully ", Satate = true };
        }

        public async Task<DiscountCheckModel> DeActiveDiscount(int id)
        {
            var oldDisc = await unitOfWork.Discounts.GetByIdAsync(id);
            if (oldDisc is null)
                return new DiscountCheckModel { Message = "ID is Wrong" };
            var result = oldDisc.IsActive;
            if (result == false)
                return new DiscountCheckModel { Message = "it is already deActive" };
            
            else
                oldDisc.IsActive = false;
                unitOfWork.Complete();
            return new DiscountCheckModel { Message = "de Activated SuccessFully ", Satate = true };
        }
    }
}
