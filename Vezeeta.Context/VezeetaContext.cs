using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Vezeeta.Domain;
using Vezeeta.Domain.enums;

namespace Vezeeta.Context
{
    public class VezeetaContext : IdentityDbContext<AppUser>
    {
        public VezeetaContext(DbContextOptions<VezeetaContext> options) :
            base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            SeedRoles(builder);
            SeedAdmin(builder);
            SeedingData.SpecilizaationData(builder);
            SeedingData.DoctorsData(builder);
            SeedingData.PateintsData(builder);
            SeedingData.AppointmentData(builder);
            SeedingData.RequestData(builder);


        }

        private void SeedRoles(ModelBuilder builder)
        {
            builder.Entity<IdentityRole>().HasData(
                new IdentityRole() { Id = "fab4fac1-c546-41de-aebc-a14da6895711", Name = "Admin", ConcurrencyStamp = "1", NormalizedName = "Admin".ToUpper() },
                new IdentityRole() { Id = "13eae602-128b-49d8-9231-90114931379d", Name = "Doctor", ConcurrencyStamp = "2", NormalizedName = "Doctor".ToUpper() },
                new IdentityRole() { Id = "004470dd-c3ba-46e5-bd3e-5016d48807f5", Name = "Patient", ConcurrencyStamp = "3", NormalizedName = "Patient".ToUpper() }
                );
        }

        private void SeedAdmin(ModelBuilder builder)
        {
            AppUser user = new AppUser()
            {
                Id = "b74ddd14-6340-4840-95c2-db12554843e5",
                UserName = "Admin",
                Email = "admin@gmail.com",
                NormalizedEmail = "admin@gmail.com".ToUpper(),
                FirstName = "Admin",
                LastName = "Veezeta",
                Phone = "1234567890",
                AccountType = AccountType.Admin,
                Gender = Gender.Male
            };

            PasswordHasher<AppUser> passwordHasher = new PasswordHasher<AppUser>();
            user.PasswordHash =passwordHasher.HashPassword(user, "Admin@2584");

            builder.Entity<AppUser>().HasData(user);

            builder.Entity<IdentityUserRole<string>>().HasData(
               new IdentityUserRole<string>() { RoleId = "fab4fac1-c546-41de-aebc-a14da6895711", UserId = "b74ddd14-6340-4840-95c2-db12554843e5" }
               );
        }

        public virtual DbSet<Doctor> Doctors { get; set; }
        public virtual DbSet<Patient> Patients { get; set; }
        public virtual DbSet<Appointment> Appointments { get; set; }
        public virtual DbSet<Specialization> Specializations { get; set; }
        public virtual DbSet<Discount> Discounts { get; set; }
        public virtual DbSet<Request> Requests { get; set; }
        public virtual DbSet<Time> Times { get; set; }

    }
}