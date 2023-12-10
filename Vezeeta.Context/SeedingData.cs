using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vezeeta.Domain;
using Vezeeta.Domain.enums;

namespace Vezeeta.Context
{
    public class SeedingData
    {
        public static void SpecilizaationData(ModelBuilder builder)
        {
            builder.Entity<Specialization>().HasData(
                new Specialization { Id = 1 , Name = "Pathology" },
                new Specialization { Id = 2, Name = "Surgery" },
                new Specialization { Id = 3, Name = "Cardiology" },
                new Specialization { Id = 4, Name = "Radiology" },
                new Specialization { Id = 5, Name = "Urology" },
                new Specialization { Id = 6, Name = "Pediatrics" },
                new Specialization { Id = 7, Name = "Dermatology" },
                new Specialization { Id = 8, Name = "Oncology" },
                new Specialization { Id = 9, Name = "Nephrology" },
                new Specialization { Id = 10, Name = "Gastroenterology" }

                );
        }

        public static void DoctorsData(ModelBuilder builder)
        {
            List<AppUser> users = new List<AppUser>
            {
                new  AppUser{ Id = "Doctor01", UserName = "doctor01@gmail.com", Email = "doctor01@gmail.com", NormalizedEmail = "doctor01@gmail.com".ToUpper(), FirstName = "Doctor", LastName = "Num 01", Phone = "1234567890", AccountType = AccountType.Doctor, Gender = Gender.Male },
                new  AppUser{ Id = "Doctor02", UserName = "doctor02@gmail.com", Email = "doctor02@gmail.com", NormalizedEmail = "doctor02@gmail.com".ToUpper(), FirstName = "Doctor", LastName = "Num 02", Phone = "1234567890", AccountType = AccountType.Doctor, Gender = Gender.Male },
                new  AppUser{ Id = "Doctor03", UserName = "doctor03@gmail.com", Email = "doctor03@gmail.com", NormalizedEmail = "doctor03@gmail.com".ToUpper(), FirstName = "Doctor", LastName = "Num 03", Phone = "1234567890", AccountType = AccountType.Doctor, Gender = Gender.Male },
                new  AppUser{ Id = "Doctor04", UserName = "doctor04@gmail.com", Email = "doctor04@gmail.com", NormalizedEmail = "doctor04@gmail.com".ToUpper(), FirstName = "Doctor", LastName = "Num 04", Phone = "1234567890", AccountType = AccountType.Doctor, Gender = Gender.Male },
                new  AppUser{ Id = "Doctor05", UserName = "doctor05@gmail.com", Email = "doctor05@gmail.com", NormalizedEmail = "doctor05@gmail.com".ToUpper(), FirstName = "Doctor", LastName = "Num 05", Phone = "1234567890", AccountType = AccountType.Doctor, Gender = Gender.Male },
                new  AppUser{ Id = "Doctor06", UserName = "doctor06@gmail.com", Email = "doctor06@gmail.com", NormalizedEmail = "doctor06@gmail.com".ToUpper(), FirstName = "Doctor", LastName = "Num 06", Phone = "1234567890", AccountType = AccountType.Doctor, Gender = Gender.Male },
                new  AppUser{ Id = "Doctor07", UserName = "doctor07@gmail.com", Email = "doctor07@gmail.com", NormalizedEmail = "doctor07@gmail.com".ToUpper(), FirstName = "Doctor", LastName = "Num 07", Phone = "1234567890", AccountType = AccountType.Doctor, Gender = Gender.Male },
                new  AppUser{ Id = "Doctor08", UserName = "doctor08@gmail.com", Email = "doctor08@gmail.com", NormalizedEmail = "doctor08@gmail.com".ToUpper(), FirstName = "Doctor", LastName = "Num 08", Phone = "1234567890", AccountType = AccountType.Doctor, Gender = Gender.Male },
                new  AppUser{ Id = "Doctor09", UserName = "doctor09@gmail.com", Email = "doctor09@gmail.com", NormalizedEmail = "doctor09@gmail.com".ToUpper(), FirstName = "Doctor", LastName = "Num 09", Phone = "1234567890", AccountType = AccountType.Doctor, Gender = Gender.Male },
                new  AppUser{ Id = "Doctor10", UserName = "doctor10@gmail.com", Email = "doctor10@gmail.com", NormalizedEmail = "doctor10@gmail.com".ToUpper(), FirstName = "Doctor", LastName = "Num 10", Phone = "1234567890", AccountType = AccountType.Doctor, Gender = Gender.Male },
            };

            PasswordHasher<AppUser> passwordHasher = new PasswordHasher<AppUser>();
            foreach (var user in users)
            {
                user.PasswordHash = passwordHasher.HashPassword(user, "Doctor@01");
            }

            builder.Entity<AppUser>().HasData(users);

            builder.Entity<IdentityUserRole<string>>().HasData(
               new IdentityUserRole<string>() { RoleId = "13eae602-128b-49d8-9231-90114931379d", UserId = "Doctor01" },
               new IdentityUserRole<string>() { RoleId = "13eae602-128b-49d8-9231-90114931379d", UserId = "Doctor02" },
               new IdentityUserRole<string>() { RoleId = "13eae602-128b-49d8-9231-90114931379d", UserId = "Doctor03" },
               new IdentityUserRole<string>() { RoleId = "13eae602-128b-49d8-9231-90114931379d", UserId = "Doctor04" },
               new IdentityUserRole<string>() { RoleId = "13eae602-128b-49d8-9231-90114931379d", UserId = "Doctor05" },
               new IdentityUserRole<string>() { RoleId = "13eae602-128b-49d8-9231-90114931379d", UserId = "Doctor06" },
               new IdentityUserRole<string>() { RoleId = "13eae602-128b-49d8-9231-90114931379d", UserId = "Doctor07" },
               new IdentityUserRole<string>() { RoleId = "13eae602-128b-49d8-9231-90114931379d", UserId = "Doctor08" },
               new IdentityUserRole<string>() { RoleId = "13eae602-128b-49d8-9231-90114931379d", UserId = "Doctor09" },
               new IdentityUserRole<string>() { RoleId = "13eae602-128b-49d8-9231-90114931379d", UserId = "Doctor10" }

               );
            builder.Entity<Doctor>().HasData(
                new Doctor() { Id = 1, ImageUrl = "ImageDocror1Url", DateOfBirth = new DateTime(1998, 4, 20), AppUserId = "Doctor01", SpecializationId = 1, Price =100 },
                new Doctor() { Id = 2, ImageUrl = "ImageDocror2Url", DateOfBirth = new DateTime(1997, 4, 20), AppUserId = "Doctor02", SpecializationId = 2, Price = 110 },
                new Doctor() { Id = 3, ImageUrl = "ImageDocror3Url", DateOfBirth = new DateTime(1996, 4, 20), AppUserId = "Doctor03", SpecializationId = 3, Price = 105},
                new Doctor() { Id = 4, ImageUrl = "ImageDocror4Url", DateOfBirth = new DateTime(1995, 4, 20), AppUserId = "Doctor04", SpecializationId = 4, Price = 120},
                new Doctor() { Id = 5, ImageUrl = "ImageDocror5Url", DateOfBirth = new DateTime(1994, 4, 20), AppUserId = "Doctor05", SpecializationId = 5, Price = 90 },
                new Doctor() { Id = 6, ImageUrl = "ImageDocror6Url", DateOfBirth = new DateTime(1996, 4, 20), AppUserId = "Doctor06", SpecializationId = 5, Price = 140 },
                new Doctor() { Id = 7, ImageUrl = "ImageDocror7Url", DateOfBirth = new DateTime(1997, 4, 20), AppUserId = "Doctor07", SpecializationId = 5, Price = 190 },
                new Doctor() { Id = 8, ImageUrl = "ImageDocror8Url", DateOfBirth = new DateTime(1998, 4, 20), AppUserId = "Doctor08", SpecializationId = 5, Price = 95 },
                new Doctor() { Id = 9, ImageUrl = "ImageDocror9Url", DateOfBirth = new DateTime(1999, 4, 20), AppUserId = "Doctor09", SpecializationId = 5, Price = 80 },
                new Doctor() { Id = 10,ImageUrl = "ImageDocror0Url", DateOfBirth = new DateTime(1990, 4, 20), AppUserId = "Doctor10", SpecializationId = 5, Price = 135 }


                );
        }
        public static void PateintsData(ModelBuilder builder)
        {
            List<AppUser> users = new List<AppUser>
            {
                new  AppUser{ Id = "Patient01", UserName = "pateint01@gmail.com", Email = "pateint01@gmail.com", NormalizedEmail = "pateint01@gmail.com".ToUpper(), FirstName = "Patient", LastName = "Num 01", Phone = "1234567890", AccountType = AccountType.Patient, Gender = Gender.Male },
                new  AppUser{ Id = "Patient02", UserName = "pateint02@gmail.com", Email = "pateint02@gmail.com", NormalizedEmail = "pateint02@gmail.com".ToUpper(), FirstName = "Patient", LastName = "Num 02", Phone = "1234567890", AccountType = AccountType.Patient, Gender = Gender.Female },
                new  AppUser{ Id = "Patient03", UserName = "pateint03@gmail.com", Email = "pateint03@gmail.com", NormalizedEmail = "pateint03@gmail.com".ToUpper(), FirstName = "Patient", LastName = "Num 03", Phone = "1234567890", AccountType = AccountType.Patient, Gender = Gender.Female },
                new  AppUser{ Id = "Patient04", UserName = "pateint04@gmail.com", Email = "pateint04@gmail.com", NormalizedEmail = "pateint04@gmail.com".ToUpper(), FirstName = "Patient", LastName = "Num 04", Phone = "1234567890", AccountType = AccountType.Patient, Gender = Gender.Female },
                new  AppUser{ Id = "Patient05", UserName = "pateint05@gmail.com", Email = "pateint05@gmail.com", NormalizedEmail = "pateint05@gmail.com".ToUpper(), FirstName = "Patient", LastName = "Num 05", Phone = "1234567890", AccountType = AccountType.Patient, Gender = Gender.Female },
                new  AppUser{ Id = "Patient06", UserName = "pateint06@gmail.com", Email = "pateint06@gmail.com", NormalizedEmail = "pateint06@gmail.com".ToUpper(), FirstName = "Patient", LastName = "Num 06", Phone = "1234567890", AccountType = AccountType.Patient, Gender = Gender.Female },
                new  AppUser{ Id = "Patient07", UserName = "pateint07@gmail.com", Email = "pateint07@gmail.com", NormalizedEmail = "pateint07@gmail.com".ToUpper(), FirstName = "Patient", LastName = "Num 07", Phone = "1234567890", AccountType = AccountType.Patient, Gender = Gender.Male },
                new  AppUser{ Id = "Patient08", UserName = "pateint08@gmail.com", Email = "pateint08@gmail.com", NormalizedEmail = "pateint08@gmail.com".ToUpper(), FirstName = "Patient", LastName = "Num 08", Phone = "1234567890", AccountType = AccountType.Patient, Gender = Gender.Male },
                new  AppUser{ Id = "Patient09", UserName = "pateint09@gmail.com", Email = "pateint09@gmail.com", NormalizedEmail = "pateint09@gmail.com".ToUpper(), FirstName = "Patient", LastName = "Num 09", Phone = "1234567890", AccountType = AccountType.Patient, Gender = Gender.Male },
                new  AppUser{ Id = "Patient10", UserName = "pateint10@gmail.com", Email = "pateint10@gmail.com", NormalizedEmail = "pateint10@gmail.com".ToUpper(), FirstName = "Patient", LastName = "Num 10", Phone = "1234567890", AccountType = AccountType.Patient, Gender = Gender.Male },

            };

            PasswordHasher<AppUser> passwordHasher = new PasswordHasher<AppUser>();
            foreach (var user in users)
            {
                user.PasswordHash = passwordHasher.HashPassword(user, "Patient@01");
            }

            builder.Entity<AppUser>().HasData(users);

            builder.Entity<IdentityUserRole<string>>().HasData(
               new IdentityUserRole<string>() { RoleId = "004470dd-c3ba-46e5-bd3e-5016d48807f5", UserId = "Patient01" },
               new IdentityUserRole<string>() { RoleId = "004470dd-c3ba-46e5-bd3e-5016d48807f5", UserId = "Patient02" },
               new IdentityUserRole<string>() { RoleId = "004470dd-c3ba-46e5-bd3e-5016d48807f5", UserId = "Patient03" },
               new IdentityUserRole<string>() { RoleId = "004470dd-c3ba-46e5-bd3e-5016d48807f5", UserId = "Patient04" },
               new IdentityUserRole<string>() { RoleId = "004470dd-c3ba-46e5-bd3e-5016d48807f5", UserId = "Patient05" },
               new IdentityUserRole<string>() { RoleId = "004470dd-c3ba-46e5-bd3e-5016d48807f5", UserId = "Patient06" },
               new IdentityUserRole<string>() { RoleId = "004470dd-c3ba-46e5-bd3e-5016d48807f5", UserId = "Patient07" },
               new IdentityUserRole<string>() { RoleId = "004470dd-c3ba-46e5-bd3e-5016d48807f5", UserId = "Patient08" },
               new IdentityUserRole<string>() { RoleId = "004470dd-c3ba-46e5-bd3e-5016d48807f5", UserId = "Patient09" },
               new IdentityUserRole<string>() { RoleId = "004470dd-c3ba-46e5-bd3e-5016d48807f5", UserId = "Patient10" }

               );
            builder.Entity<Patient>().HasData(
                new Patient() { Id = 1, ImageUrl = "ImagePatient1Url", DateOfBirth = new DateTime(2000, 4, 20), AppUserId = "Patient01", },
                new Patient() { Id = 2, ImageUrl = "ImagePatient2Url", DateOfBirth = new DateTime(2005, 4, 20), AppUserId = "Patient02", },
                new Patient() { Id = 3, ImageUrl = "ImagePatient3Url", DateOfBirth = new DateTime(2016, 4, 20), AppUserId = "Patient03", },
                new Patient() { Id = 4, ImageUrl = "ImagePatient4Url", DateOfBirth = new DateTime(2017, 4, 20), AppUserId = "Patient04", },
                new Patient() { Id = 5, ImageUrl = "ImagePatient5Url", DateOfBirth = new DateTime(1999, 4, 20), AppUserId = "Patient05", },
                new Patient() { Id = 6, ImageUrl = "ImagePatient06Url", DateOfBirth = new DateTime(1998, 4, 20), AppUserId = "Patient06", },
                new Patient() { Id = 7, ImageUrl = "ImagePatient07Url", DateOfBirth = new DateTime(1997, 4, 20), AppUserId = "Patient07", },
                new Patient() { Id = 8, ImageUrl = "ImagePatient08Url", DateOfBirth = new DateTime(1996, 4, 20), AppUserId = "Patient08", },
                new Patient() { Id = 9, ImageUrl = "ImagePatient09Url", DateOfBirth = new DateTime(1995, 4, 20), AppUserId = "Patient09", },
                new Patient() { Id = 10,ImageUrl = "ImagePatient10Url", DateOfBirth = new DateTime(1994, 4, 20), AppUserId = "Patient10", }


                );
        }
        public static void AppointmentData(ModelBuilder builder)
        {
            builder.Entity<Appointment>().HasData(
                    new Appointment { Id = 1 , DoctorId=1 , Day = Days.Saturday, AppointDate=new DateTime(2023,10,6) },
                    new Appointment { Id = 2, DoctorId = 1, Day = Days.Sunday , AppointDate=new DateTime(2023,10,6) },
                    new Appointment { Id = 3, DoctorId = 2, Day = Days.Monday, AppointDate = new DateTime(2023, 10, 6) },
                    new Appointment { Id = 4, DoctorId = 2, Day = Days.Tuesday, AppointDate = new DateTime(2023, 10, 6) },
                    new Appointment { Id = 5, DoctorId = 3, Day = Days.Saturday, AppointDate = new DateTime(2023, 10, 6) },
                    new Appointment { Id = 6, DoctorId = 3, Day = Days.Monday, AppointDate = new DateTime(2023, 10, 6) },
                    new Appointment { Id = 7, DoctorId = 4, Day = Days.Saturday, AppointDate = new DateTime(2023, 10, 6) },
                    new Appointment { Id = 8, DoctorId = 4, Day = Days.Monday, AppointDate = new DateTime(2023, 10, 6) },
                    new Appointment { Id = 9, DoctorId = 5, Day = Days.Wednesday, AppointDate = new DateTime(2023, 10, 6) },
                    new Appointment { Id = 10, DoctorId = 5, Day = Days.Thursday, AppointDate = new DateTime(2023, 10, 6) }

                );

            builder.Entity<Time>().HasData(
                    new Time { Id = 1, AppointmentId = 1, IsBooked = false, TimeOfAppointment = new DateTime(2023, 12, 7).TimeOfDay },
                    new Time { Id = 2, AppointmentId = 2, IsBooked = false, TimeOfAppointment = new DateTime(2023, 12, 7).TimeOfDay },
                    new Time { Id = 3, AppointmentId = 3, IsBooked = false, TimeOfAppointment = new DateTime(2023, 12, 7).TimeOfDay },
                    new Time { Id = 4, AppointmentId = 4, IsBooked = false, TimeOfAppointment = new DateTime(2023, 12, 7).TimeOfDay },
                    new Time { Id = 5, AppointmentId = 5, IsBooked = false, TimeOfAppointment = new DateTime(2023, 12, 7).TimeOfDay }
                );
        }

        public static void RequestData(ModelBuilder builder)
        {
            builder.Entity<Request>().HasData(
                    new Request { Id = 1, Price = 100 ,DoctorId = 1, PatientId = 1 , TimeId = 1, RequestStatus = RequestStatus.Pending, IsConfirmed = false },
                    new Request { Id = 2, Price = 105,  DoctorId = 1, PatientId = 1, TimeId = 2, RequestStatus = RequestStatus.Pending, IsConfirmed = false },
                    new Request { Id = 3, Price = 110,  DoctorId = 2, PatientId = 2, TimeId = 3, RequestStatus = RequestStatus.Pending, IsConfirmed = false },
                    new Request { Id = 4, Price = 120,  DoctorId = 2, PatientId = 2, TimeId = 4, RequestStatus = RequestStatus.Pending, IsConfirmed = false },
                    new Request { Id = 5, Price = 90,   DoctorId = 3, PatientId = 3, TimeId = 5, RequestStatus = RequestStatus.Pending, IsConfirmed = false }
                    
                );
        }
    }
}
