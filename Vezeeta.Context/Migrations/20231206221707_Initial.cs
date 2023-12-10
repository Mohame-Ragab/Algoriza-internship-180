using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Vezeeta.Context.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AccountType = table.Column<int>(type: "int", nullable: false),
                    Gender = table.Column<int>(type: "int", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Discounts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DicountCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DiscountType = table.Column<int>(type: "int", nullable: false),
                    Value = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    NuberOfCompReqs = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Discounts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Specializations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Specializations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Patients",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AppUserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patients", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Patients_AspNetUsers_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Doctors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: true),
                    SpecializationId = table.Column<int>(type: "int", nullable: false),
                    AppUserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doctors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Doctors_AspNetUsers_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Doctors_Specializations_SpecializationId",
                        column: x => x.SpecializationId,
                        principalTable: "Specializations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Appointments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DoctorId = table.Column<int>(type: "int", nullable: false),
                    Day = table.Column<int>(type: "int", nullable: false),
                    AppointDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Appointments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Appointments_Doctors_DoctorId",
                        column: x => x.DoctorId,
                        principalTable: "Doctors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Times",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsBooked = table.Column<bool>(type: "bit", nullable: false),
                    AppointmentId = table.Column<int>(type: "int", nullable: false),
                    TimeOfAppointment = table.Column<TimeSpan>(type: "time", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Times", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Times_Appointments_AppointmentId",
                        column: x => x.AppointmentId,
                        principalTable: "Appointments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Requests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Price = table.Column<double>(type: "float", nullable: false),
                    FinalPrice = table.Column<double>(type: "float", nullable: true),
                    RequestStatus = table.Column<int>(type: "int", nullable: false),
                    IsConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TimeId = table.Column<int>(type: "int", nullable: false),
                    DiscountId = table.Column<int>(type: "int", nullable: true),
                    PatientId = table.Column<int>(type: "int", nullable: false),
                    DoctorId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Requests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Requests_Discounts_DiscountId",
                        column: x => x.DiscountId,
                        principalTable: "Discounts",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Requests_Doctors_DoctorId",
                        column: x => x.DoctorId,
                        principalTable: "Doctors",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Requests_Patients_PatientId",
                        column: x => x.PatientId,
                        principalTable: "Patients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Requests_Times_TimeId",
                        column: x => x.TimeId,
                        principalTable: "Times",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "004470dd-c3ba-46e5-bd3e-5016d48807f5", "3", "Patient", "PATIENT" },
                    { "13eae602-128b-49d8-9231-90114931379d", "2", "Doctor", "DOCTOR" },
                    { "fab4fac1-c546-41de-aebc-a14da6895711", "1", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AccountType", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "Gender", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "Phone", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "b74ddd14-6340-4840-95c2-db12554843e5", 0, 0, "e47dabbd-7f10-46d7-a0f1-902ecad691f7", "admin@gmail.com", false, "Admin", 0, "Veezeta", false, null, null, null, "AQAAAAIAAYagAAAAEKQmCQBu/FP1xZkewsI8ZW/gzfobhnX1r7125rOgOGhBxbPrKgrPGkL93lsETk8gQw==", "1234567890", null, false, "19a29855-48ef-4c4d-b796-1809ccb6ba44", false, "Admin" },
                    { "Doctor01", 0, 1, "9f431d6f-48ac-46fd-83fb-cbe45ecee7b9", "doctor01@gmail.com", false, "Doctor", 0, "Num 1", false, null, null, null, "AQAAAAIAAYagAAAAEM55EqyCZa1W/B8/jGnz41sKuqb4Hn5i4ISOIOqto5AgOcJYX5njPqcBOinuwvlqZA==", "1234567890", null, false, "00a12084-7136-44a4-a88f-f12fd03e8231", false, "doctor01@gmail.com" },
                    { "Doctor02", 0, 1, "d9d4d126-56f5-428d-be0d-f4c857b40002", "doctor02@gmail.com", false, "Doctor", 0, "Num 2", false, null, null, null, "AQAAAAIAAYagAAAAEHUIZ0x2Tr3nZLtUofNln9mDF/d2EPPXj4kxOSni0flmC+lClhwLOLhst0GFILyrZQ==", "1234567890", null, false, "4234f282-7743-4555-9380-8e2b1ac5bf76", false, "doctor02@gmail.com" },
                    { "Doctor03", 0, 1, "e9597a9a-644b-4ff2-8cbb-8dda22a6e447", "doctor03@gmail.com", false, "Doctor", 0, "Num 3", false, null, null, null, "AQAAAAIAAYagAAAAEHiH2EY3VIqVs2+EShWyxdAF7kICGSeBdMl67onYA+mOfzykGIMVcO2kcUjIC29Onw==", "1234567890", null, false, "484ab764-103c-405a-8d99-5d742bba28fa", false, "doctor03@gmail.com" },
                    { "Doctor04", 0, 1, "77b37962-2a3b-4fed-ae84-f222d9e27351", "doctor04@gmail.com", false, "Doctor", 0, "Num 4", false, null, null, null, "AQAAAAIAAYagAAAAEEzgLuyePQbWQpfxtOJGHZl4gKK3WsIErxUF5BAC/ZMghsdjB1XixeAH8nRlEt8XkA==", "1234567890", null, false, "1b7482c0-75b0-4b63-a9f4-fd4da0bed650", false, "doctor04@gmail.com" },
                    { "Doctor05", 0, 1, "44d9517c-3aa8-46b5-9ce1-05a3e5a8ce6e", "doctor05@gmail.com", false, "Doctor", 0, "Num 5", false, null, null, null, "AQAAAAIAAYagAAAAEPTakrThZsTNljQUgIspkO9/bwWL65DUSavqkmVI00r+zfllG4F6/UwVJNCcyAhNIg==", "1234567890", null, false, "72e6ad22-d4ea-476f-babe-d67955586c5a", false, "doctor05@gmail.com" },
                    { "Patient01", 0, 2, "2f687158-f0f9-4334-ba78-1ca3c6dde6a2", "Patient01@gmail.com", false, "Patient", 1, "Num 1", false, null, "PATIENT01@GMAIL.COM", null, "AQAAAAIAAYagAAAAEPZmu7/jAzKOvwvtn8P6UkCWGZp45KbqhIaso3zcfMhFwUwIeaXOlh8aNuOhmDsWGQ==", "1234567890", null, false, "0d865d24-0c22-47b3-bd89-efa22a952c5a", false, "Patient01@gmail.com" },
                    { "Patient02", 0, 2, "936c004e-0a84-49cf-8ae7-6ed243bb6d13", "Patient02@gmail.com", false, "Patientr", 1, "Num 2", false, null, null, null, "AQAAAAIAAYagAAAAEFgauCjBii1w0q0QcT1DGtCrHvUKLtmSfVUhoVY+4bB7TNbdBUYmMQYc4nEPwvKg1w==", "1234567890", null, false, "3cac2cec-188f-4a25-b83e-552fb90d0c84", false, "Patient02@gmail.com" },
                    { "Patient03", 0, 2, "31ff0e78-9ea9-45fe-8c7a-e444c1080d91", "Patient03@gmail.com", false, "Patient", 0, "Num 3", false, null, null, null, "AQAAAAIAAYagAAAAEL2t2T4ryZkOvoVJ8SCf+vZHhYfWOwvi4j93w5hRDBCYe60f+XBJb8FwomyCMZj3WA==", "1234567890", null, false, "44453093-6a79-4a4c-9225-8b871055d2af", false, "Patient03@gmail.com" },
                    { "Patient04", 0, 2, "57b1f50e-ca29-4065-93b3-ce7356f0d50a", "Patient04@gmail.com", false, "Patient", 0, "Num 4", false, null, null, null, "AQAAAAIAAYagAAAAEG/XAFOivj1ZuBDN7kvDM8ltdgQR1SeP/CkeTvEVWLjjiXaydaOJPXxJM6Oklh6kew==", "1234567890", null, false, "15c1c10c-0a7c-41af-82b1-2717b9a4ddca", false, "Patient04@gmail.com" },
                    { "Patient05", 0, 2, "b164bbe2-1854-4bdb-8f82-f7cfa38194da", "Patient05@gmail.com", false, "Patient", 0, "Num 5", false, null, null, null, "AQAAAAIAAYagAAAAELIvrdZ1xjkV5Q9cOdDCHn+xHP+lBqAghZUXOxKCiTDql51wMDDj2T3IKk5f6srYfQ==", "1234567890", null, false, "78afb3b3-8cd7-458a-8add-9a9f7b63e562", false, "Patient05@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "Specializations",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Pathology" },
                    { 2, "Surgery" },
                    { 3, "Cardiology" },
                    { 4, "Radiology" },
                    { 5, "Urology" },
                    { 6, "Pediatrics" },
                    { 7, "Dermatology" },
                    { 8, "Oncology" },
                    { 9, "Nephrology" },
                    { 10, "Gastroenterology" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "fab4fac1-c546-41de-aebc-a14da6895711", "b74ddd14-6340-4840-95c2-db12554843e5" },
                    { "13eae602-128b-49d8-9231-90114931379d", "Doctor01" },
                    { "13eae602-128b-49d8-9231-90114931379d", "Doctor02" },
                    { "13eae602-128b-49d8-9231-90114931379d", "Doctor03" },
                    { "13eae602-128b-49d8-9231-90114931379d", "Doctor04" },
                    { "13eae602-128b-49d8-9231-90114931379d", "Doctor05" },
                    { "004470dd-c3ba-46e5-bd3e-5016d48807f5", "Patient01" },
                    { "004470dd-c3ba-46e5-bd3e-5016d48807f5", "Patient02" },
                    { "004470dd-c3ba-46e5-bd3e-5016d48807f5", "Patient03" },
                    { "004470dd-c3ba-46e5-bd3e-5016d48807f5", "Patient04" },
                    { "004470dd-c3ba-46e5-bd3e-5016d48807f5", "Patient05" }
                });

            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "Id", "AppUserId", "DateOfBirth", "ImageUrl", "Price", "SpecializationId" },
                values: new object[,]
                {
                    { 1, "Doctor01", new DateTime(1998, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "ImageDocror1Url", 100.0, 1 },
                    { 2, "Doctor02", new DateTime(1997, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "ImageDocror2Url", 110.0, 2 },
                    { 3, "Doctor03", new DateTime(1996, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "ImageDocror3Url", 105.0, 3 },
                    { 4, "Doctor04", new DateTime(1995, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "ImageDocror4Url", 120.0, 4 },
                    { 5, "Doctor05", new DateTime(1994, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "ImageDocror5Url", 90.0, 5 }
                });

            migrationBuilder.InsertData(
                table: "Patients",
                columns: new[] { "Id", "AppUserId", "DateOfBirth", "ImageUrl" },
                values: new object[,]
                {
                    { 1, "Patient01", new DateTime(2000, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "ImagePatient1Url" },
                    { 2, "Patient02", new DateTime(2005, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "ImagePatient2Url" },
                    { 3, "Patient03", new DateTime(2016, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "ImagePatient3Url" },
                    { 4, "Patient04", new DateTime(2017, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "ImagePatient4Url" },
                    { 5, "Patient05", new DateTime(1999, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "ImagePatient5Url" }
                });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "Id", "AppointDate", "Day", "DoctorId" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, 1 },
                    { 2, new DateTime(2023, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 1 },
                    { 3, new DateTime(2023, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 2 },
                    { 4, new DateTime(2023, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 2 },
                    { 5, new DateTime(2023, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, 3 },
                    { 6, new DateTime(2023, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 3 },
                    { 7, new DateTime(2023, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, 4 },
                    { 8, new DateTime(2023, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 4 },
                    { 9, new DateTime(2023, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 5 },
                    { 10, new DateTime(2023, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 5 }
                });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "Id", "AppointmentId", "IsBooked", "TimeOfAppointment" },
                values: new object[,]
                {
                    { 1, 1, false, new TimeSpan(0, 0, 0, 0, 0) },
                    { 2, 2, false, new TimeSpan(0, 0, 0, 0, 0) },
                    { 3, 3, false, new TimeSpan(0, 0, 0, 0, 0) },
                    { 4, 4, false, new TimeSpan(0, 0, 0, 0, 0) },
                    { 5, 5, false, new TimeSpan(0, 0, 0, 0, 0) }
                });

            migrationBuilder.InsertData(
                table: "Requests",
                columns: new[] { "Id", "DiscountId", "DoctorId", "FinalPrice", "IsConfirmed", "PatientId", "Price", "RequestStatus", "TimeId" },
                values: new object[,]
                {
                    { 1, null, null, null, false, 1, 100.0, 0, 1 },
                    { 2, null, null, null, false, 1, 105.0, 0, 2 },
                    { 3, null, null, null, false, 2, 110.0, 0, 3 },
                    { 4, null, null, null, false, 2, 120.0, 0, 4 },
                    { 5, null, null, null, false, 3, 90.0, 0, 5 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_DoctorId",
                table: "Appointments",
                column: "DoctorId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Doctors_AppUserId",
                table: "Doctors",
                column: "AppUserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Doctors_SpecializationId",
                table: "Doctors",
                column: "SpecializationId");

            migrationBuilder.CreateIndex(
                name: "IX_Patients_AppUserId",
                table: "Patients",
                column: "AppUserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Requests_DiscountId",
                table: "Requests",
                column: "DiscountId");

            migrationBuilder.CreateIndex(
                name: "IX_Requests_DoctorId",
                table: "Requests",
                column: "DoctorId");

            migrationBuilder.CreateIndex(
                name: "IX_Requests_PatientId",
                table: "Requests",
                column: "PatientId");

            migrationBuilder.CreateIndex(
                name: "IX_Requests_TimeId",
                table: "Requests",
                column: "TimeId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Times_AppointmentId",
                table: "Times",
                column: "AppointmentId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Requests");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Discounts");

            migrationBuilder.DropTable(
                name: "Patients");

            migrationBuilder.DropTable(
                name: "Times");

            migrationBuilder.DropTable(
                name: "Appointments");

            migrationBuilder.DropTable(
                name: "Doctors");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Specializations");
        }
    }
}
