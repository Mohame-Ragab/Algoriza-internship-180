using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Vezeeta.Context.Migrations
{
    /// <inheritdoc />
    public partial class UpdateSeedingData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db12554843e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4fe5a982-14a0-446a-a8e0-2c58aab0003c", "AQAAAAIAAYagAAAAECyHPWQq5acnyea/6Nqq32fttANGtEWVLxy9dOndiGZvKZQ8E0ib5SwoXb3Qo/lLjQ==", "7177123a-e344-4bec-9b5f-610c1cffc5b6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "Doctor01",
                columns: new[] { "ConcurrencyStamp", "LastName", "NormalizedEmail", "PasswordHash", "SecurityStamp" },
                values: new object[] { "64e4294d-a3ba-4e05-a7de-f02985f98f66", "Num 01", "DOCTOR01@GMAIL.COM", "AQAAAAIAAYagAAAAEJwH83hUOS16HkOxwLRak5SlUklvWayx5EAOoHPsVxmOG8w3ojXjxN1Tz+7xJNDGyg==", "e33e8853-279d-437c-9520-30f67079c564" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "Doctor02",
                columns: new[] { "ConcurrencyStamp", "LastName", "NormalizedEmail", "PasswordHash", "SecurityStamp" },
                values: new object[] { "084094f0-8e01-436c-a2c8-e6cf7c3f41bc", "Num 02", "DOCTOR02@GMAIL.COM", "AQAAAAIAAYagAAAAEMmSQvtTWXW5EgJ8TaSrkFSIAsk/0++/+Aib35tHjHkrLPPw8e6iMQTb9nF44+HwdA==", "a69ef763-0603-481f-b9ec-b51ece335267" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "Doctor03",
                columns: new[] { "ConcurrencyStamp", "LastName", "NormalizedEmail", "PasswordHash", "SecurityStamp" },
                values: new object[] { "891392a5-c259-49af-8535-7a3b950196ee", "Num 03", "DOCTOR03@GMAIL.COM", "AQAAAAIAAYagAAAAEOpJLn4hak1UOzYFG2pEMLoUPjgu6RP9fKAD7AtIGey5hptQ73p24KSqnkkYCmwPiw==", "a3acbd71-0f7c-450b-b2be-b0f14c2698da" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "Doctor04",
                columns: new[] { "ConcurrencyStamp", "LastName", "NormalizedEmail", "PasswordHash", "SecurityStamp" },
                values: new object[] { "141eeb4a-243f-47a9-aeb3-a5312e89333b", "Num 04", "DOCTOR04@GMAIL.COM", "AQAAAAIAAYagAAAAEJcyJ6QGEHt6GGCBtCbb9cBg1huxIJt7oG2M/icFAQo1v7hjUidu2H07/b4ajzJeoA==", "617a1a07-526a-434c-ad67-667a51c43ae4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "Doctor05",
                columns: new[] { "ConcurrencyStamp", "LastName", "NormalizedEmail", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d3e658c2-d964-4689-9140-f77bc5260e9e", "Num 05", "DOCTOR05@GMAIL.COM", "AQAAAAIAAYagAAAAEDpX1uKeZIVNZpZfj7hIwU1biWzTig9F52PE5Ke78hFMWk2nNf+i2wJ6e0bNhuDOJw==", "4b614d93-08f1-464a-935a-70673de1931f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "Patient01",
                columns: new[] { "ConcurrencyStamp", "Email", "Gender", "LastName", "NormalizedEmail", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "5a51095c-7afb-4761-97d2-35a79c255e5a", "pateint01@gmail.com", 0, "Num 01", "PATEINT01@GMAIL.COM", "AQAAAAIAAYagAAAAEEQjSzWy43cvUYCZl5MapBMi+VlQyXw087QLzWkjR5+zBcjV/v1z4vO2KfOVC4QmVw==", "f2376447-04e5-4fe3-9d81-32be70c8eee9", "pateint01@gmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "Patient02",
                columns: new[] { "ConcurrencyStamp", "Email", "FirstName", "LastName", "NormalizedEmail", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "ab31eead-ba75-4c2a-b685-7e3228be1e4d", "pateint02@gmail.com", "Patient", "Num 02", "PATEINT02@GMAIL.COM", "AQAAAAIAAYagAAAAEFrNy4zNFBX4bxKaFoDFZVGKXgkzbmy0BtL0QjhbXgol++gEPLdq8EjawlUjfsxw8g==", "06c3b657-e12f-47bc-839a-2ae76b3fe87f", "pateint02@gmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "Patient03",
                columns: new[] { "ConcurrencyStamp", "Email", "Gender", "LastName", "NormalizedEmail", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "69656d46-dac5-4e8e-b2ac-d910fa82a22a", "pateint03@gmail.com", 1, "Num 03", "PATEINT03@GMAIL.COM", "AQAAAAIAAYagAAAAEC8EjPkQKwVOhrHnrWgrjKBycQv8wX04B83hD/JgufjPqbAvhQ/bgEZHVosLK3IrQg==", "9c9ed0f7-26a2-4cbe-98d2-f5269919050d", "pateint03@gmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "Patient04",
                columns: new[] { "ConcurrencyStamp", "Email", "Gender", "LastName", "NormalizedEmail", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "7da9800d-b1a0-4887-83c3-2ff920d5a4ce", "pateint04@gmail.com", 1, "Num 04", "PATEINT04@GMAIL.COM", "AQAAAAIAAYagAAAAEG9/fkG2pnmt99RXqeEvv+l6QaVBe2aVJL79Vxbjkz4N69elIFu2nwWFlPxBZziZ6A==", "13498e1f-4ec1-4892-b3af-cab17d9bb6ad", "pateint04@gmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "Patient05",
                columns: new[] { "ConcurrencyStamp", "Email", "Gender", "LastName", "NormalizedEmail", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "90ec9a9e-546f-401b-9e7a-dd9feade70b5", "pateint05@gmail.com", 1, "Num 05", "PATEINT05@GMAIL.COM", "AQAAAAIAAYagAAAAEMC1ArD9YVqjF5s8tUNOmOsh6gzPsH8/TjOZexFV9b6yD55MlxFx8fGELuzwvud9Yg==", "531c4970-c0cc-4894-be76-0f015910f09d", "pateint05@gmail.com" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AccountType", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "Gender", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "Phone", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "Doctor06", 0, 1, "cc79f09a-dcc1-42ba-b92c-f4f12515fcac", "doctor06@gmail.com", false, "Doctor", 0, "Num 06", false, null, "DOCTOR06@GMAIL.COM", null, "AQAAAAIAAYagAAAAEL1DsBqw1fd+LM9pXr182nPcPta2xkOEQYePm8or7NclzxnhYbFuRMioc1+5xL0pKA==", "1234567890", null, false, "3138b007-54bb-41ca-bc98-70fcd5d1ef71", false, "doctor06@gmail.com" },
                    { "Doctor07", 0, 1, "7eadecf2-14e6-4dd5-b0a9-d9f6650dc696", "doctor07@gmail.com", false, "Doctor", 0, "Num 07", false, null, "DOCTOR07@GMAIL.COM", null, "AQAAAAIAAYagAAAAEFaMiZzVTnGdaifCQUjpYv90Eb+ljOQ7F7utqf1zzJswSA4mty+BTPZCNe+CQI2pXw==", "1234567890", null, false, "16835943-3923-477c-9edc-ebe8e6db0435", false, "doctor07@gmail.com" },
                    { "Doctor08", 0, 1, "9efad617-0f8d-47e1-b001-e5bf07118564", "doctor08@gmail.com", false, "Doctor", 0, "Num 08", false, null, "DOCTOR08@GMAIL.COM", null, "AQAAAAIAAYagAAAAEDNdxgGP5N6fUdFjWOKGkbXvjEj81biGLgNvjvyqs5dEq7Ak24anhzfHosrssedIag==", "1234567890", null, false, "1fa56e60-86e1-4abe-bcbf-e7c971864840", false, "doctor08@gmail.com" },
                    { "Doctor09", 0, 1, "2d98e588-56aa-488c-b918-3c26b63dc1cc", "doctor09@gmail.com", false, "Doctor", 0, "Num 09", false, null, "DOCTOR09@GMAIL.COM", null, "AQAAAAIAAYagAAAAECpeHuuPDsryUg3NeWx8wiBybGIXy21GiFw1LFSq0K92vxqgTgWBivhk5zmTmV8anw==", "1234567890", null, false, "e1f95e8f-0a00-4871-8658-73174b61adfc", false, "doctor09@gmail.com" },
                    { "Doctor10", 0, 1, "8913dacf-0f61-4818-8b08-d0b1a1f92286", "doctor10@gmail.com", false, "Doctor", 0, "Num 10", false, null, "DOCTOR10@GMAIL.COM", null, "AQAAAAIAAYagAAAAEGi4fbR8UUw4L7ONfmyUQ+RXd5uxqUiTZaZ8GetbShkXIsHEP4M44zcVSJvO/dp46g==", "1234567890", null, false, "29fc483b-2e5e-4c9e-a4fc-451114e63373", false, "doctor10@gmail.com" },
                    { "Patient06", 0, 2, "028db063-dacb-4428-b6b2-6eae255904c7", "pateint06@gmail.com", false, "Patient", 1, "Num 06", false, null, "PATEINT06@GMAIL.COM", null, "AQAAAAIAAYagAAAAELoBtYbMG2gSq2BqEkIt93yPxX8Rgh9hjshd0yhW+00trWKNsMs25W92d92Nxax1JA==", "1234567890", null, false, "df8f6ad4-dd2e-4ba4-a629-7c89402c6a9e", false, "pateint06@gmail.com" },
                    { "Patient07", 0, 2, "4ec145f0-715e-4a6d-968b-9ecc81c2ae8b", "pateint07@gmail.com", false, "Patient", 0, "Num 07", false, null, "PATEINT07@GMAIL.COM", null, "AQAAAAIAAYagAAAAEI7KPj6JO8KF/8LCcOM8ZY8JnVlsxQxuDBMJ2GJkhJhtvhSzBA+Z5xgM6weS2huQhQ==", "1234567890", null, false, "2be64d2b-150f-48a4-ac52-6e54ab8219da", false, "pateint07@gmail.com" },
                    { "Patient08", 0, 2, "0bb2aa7b-2ece-4e83-bc0a-bb0380b246b9", "pateint08@gmail.com", false, "Patient", 0, "Num 08", false, null, "PATEINT08@GMAIL.COM", null, "AQAAAAIAAYagAAAAEHx2CfV+NUgwU3S9gUqcnS/omQLleu3yg4w++a2WfMpaCp19RrLKoRk+cmXjHPw2ag==", "1234567890", null, false, "efdad141-bf98-46a1-98ed-86464e5b5cb8", false, "pateint08@gmail.com" },
                    { "Patient09", 0, 2, "f081d828-93d9-48c3-af00-b74f37e47da8", "pateint09@gmail.com", false, "Patient", 0, "Num 09", false, null, "PATEINT09@GMAIL.COM", null, "AQAAAAIAAYagAAAAEO61CnLcamuMop7q5pNPCer+KWE6E12KZNPLAN1dwEJ8DrY710rddKNx68OCShn8+A==", "1234567890", null, false, "4f09ecb4-3040-44e1-982f-239c8e1a8fc0", false, "pateint09@gmail.com" },
                    { "Patient10", 0, 2, "2ddae163-50b6-4b7a-876d-41d0347bb208", "pateint10@gmail.com", false, "Patient", 0, "Num 10", false, null, "PATEINT10@GMAIL.COM", null, "AQAAAAIAAYagAAAAEPghPbfCXO28ZeMwrOI+gFXRDxFzfuEtMI2ygbmey1KgRiLBW7OXq6GvSmiJ0LlA5g==", "1234567890", null, false, "a624e055-7965-4618-a71d-29559ffc45c3", false, "pateint10@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "13eae602-128b-49d8-9231-90114931379d", "Doctor06" },
                    { "13eae602-128b-49d8-9231-90114931379d", "Doctor07" },
                    { "13eae602-128b-49d8-9231-90114931379d", "Doctor08" },
                    { "13eae602-128b-49d8-9231-90114931379d", "Doctor09" },
                    { "13eae602-128b-49d8-9231-90114931379d", "Doctor10" },
                    { "004470dd-c3ba-46e5-bd3e-5016d48807f5", "Patient06" },
                    { "004470dd-c3ba-46e5-bd3e-5016d48807f5", "Patient07" },
                    { "004470dd-c3ba-46e5-bd3e-5016d48807f5", "Patient08" },
                    { "004470dd-c3ba-46e5-bd3e-5016d48807f5", "Patient09" },
                    { "004470dd-c3ba-46e5-bd3e-5016d48807f5", "Patient10" }
                });

            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "Id", "AppUserId", "DateOfBirth", "ImageUrl", "Price", "SpecializationId" },
                values: new object[,]
                {
                    { 6, "Doctor06", new DateTime(1996, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "ImageDocror6Url", 140.0, 5 },
                    { 7, "Doctor07", new DateTime(1997, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "ImageDocror7Url", 190.0, 5 },
                    { 8, "Doctor08", new DateTime(1998, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "ImageDocror8Url", 95.0, 5 },
                    { 9, "Doctor09", new DateTime(1999, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "ImageDocror9Url", 80.0, 5 },
                    { 10, "Doctor10", new DateTime(1990, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "ImageDocror0Url", 135.0, 5 }
                });

            migrationBuilder.InsertData(
                table: "Patients",
                columns: new[] { "Id", "AppUserId", "DateOfBirth", "ImageUrl" },
                values: new object[,]
                {
                    { 6, "Patient06", new DateTime(1998, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "ImagePatient06Url" },
                    { 7, "Patient07", new DateTime(1997, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "ImagePatient07Url" },
                    { 8, "Patient08", new DateTime(1996, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "ImagePatient08Url" },
                    { 9, "Patient09", new DateTime(1995, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "ImagePatient09Url" },
                    { 10, "Patient10", new DateTime(1994, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "ImagePatient10Url" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "13eae602-128b-49d8-9231-90114931379d", "Doctor06" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "13eae602-128b-49d8-9231-90114931379d", "Doctor07" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "13eae602-128b-49d8-9231-90114931379d", "Doctor08" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "13eae602-128b-49d8-9231-90114931379d", "Doctor09" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "13eae602-128b-49d8-9231-90114931379d", "Doctor10" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "004470dd-c3ba-46e5-bd3e-5016d48807f5", "Patient06" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "004470dd-c3ba-46e5-bd3e-5016d48807f5", "Patient07" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "004470dd-c3ba-46e5-bd3e-5016d48807f5", "Patient08" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "004470dd-c3ba-46e5-bd3e-5016d48807f5", "Patient09" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "004470dd-c3ba-46e5-bd3e-5016d48807f5", "Patient10" });

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "Doctor06");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "Doctor07");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "Doctor08");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "Doctor09");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "Doctor10");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "Patient06");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "Patient07");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "Patient08");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "Patient09");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "Patient10");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db12554843e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1cd31656-a709-4cff-9672-454ab0fd25ce", "AQAAAAIAAYagAAAAEJ18OteSZcog7lMdK/qQ2oaFEZ79djnkYFCTysPOfxCSNX1+51ldOC2QxBL8GJJ8Uw==", "65cbbea2-49bd-4772-b22e-3a6a54456fdb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "Doctor01",
                columns: new[] { "ConcurrencyStamp", "LastName", "NormalizedEmail", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8c18c10f-2530-4a0a-aa85-49a38c0cae4e", "Num 1", null, "AQAAAAIAAYagAAAAEISM6wA6R4JtmFb6mdIgaE85tLxsxAWIcbwBr3z3WopmhoaFpsX4N7o9FqslubYCrw==", "e7993315-7d4d-414f-8e32-f9be55e217eb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "Doctor02",
                columns: new[] { "ConcurrencyStamp", "LastName", "NormalizedEmail", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3ddb1400-b543-4db5-a80c-3775fdeb5fd3", "Num 2", null, "AQAAAAIAAYagAAAAEPwUqhrbYDTbj6r9n+YwXnuQRh2yIi5UseFF3S2qfqC88DpSsdtulr2e1cG2CmDBJg==", "b3993fa1-cd6b-4a9d-aaf9-482ba7fa0f6d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "Doctor03",
                columns: new[] { "ConcurrencyStamp", "LastName", "NormalizedEmail", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bd9453dd-64b0-4c57-a6ce-7303b1571742", "Num 3", null, "AQAAAAIAAYagAAAAECFSbfjJAJzswvfZ4Ns+v4Q7mNV1GnRzN36X6bDyZ8Edh8CqR7BkR9dn8GCbEHh2Jg==", "40da798e-255f-4ce4-9967-cb18248809f3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "Doctor04",
                columns: new[] { "ConcurrencyStamp", "LastName", "NormalizedEmail", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ffbc0677-1834-4e07-b5a4-a01352dafd08", "Num 4", null, "AQAAAAIAAYagAAAAEHZZuFndnPZnAFZfuQ+MluTKstz4jPHq43ItFFi1aCy3EAZ4uvGvlMqtL40SdcGb/Q==", "7f530140-089e-4750-87df-78b308b5132b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "Doctor05",
                columns: new[] { "ConcurrencyStamp", "LastName", "NormalizedEmail", "PasswordHash", "SecurityStamp" },
                values: new object[] { "81774291-8440-40e0-8b24-799881488bd0", "Num 5", null, "AQAAAAIAAYagAAAAEO76Uyn1q9XJYCuDhgsdUmme7KeQusXrIRGSr5THwk5mhODoluxcVqq+q8Lxq3g9Ng==", "2bc97fb8-5b75-41da-bf76-631ad14e31d6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "Patient01",
                columns: new[] { "ConcurrencyStamp", "Email", "Gender", "LastName", "NormalizedEmail", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "ebf27670-2333-471b-8afe-6f4319345e6f", "Patient01@gmail.com", 1, "Num 1", "PATIENT01@GMAIL.COM", "AQAAAAIAAYagAAAAEMQafEphjj6oZsI6xSxhFD1eXY15mpsX+pDUNt7RgqRQF8OdhRIyt1UMNIGnHMdLsg==", "f9001d0c-73a5-4762-b68e-a58a02aae2fb", "Patient01@gmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "Patient02",
                columns: new[] { "ConcurrencyStamp", "Email", "FirstName", "LastName", "NormalizedEmail", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "68d46ecd-3b88-42a1-b6fc-93d377e43290", "Patient02@gmail.com", "Patientr", "Num 2", null, "AQAAAAIAAYagAAAAEJgZcMkgwF6sgPj7QfXPRtMKIahHaouICVvZMKVPljQrbp5OBmt5nzoCrmUK7/AVJA==", "26ad3816-4b12-4c6c-a3d9-c007a5dd855d", "Patient02@gmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "Patient03",
                columns: new[] { "ConcurrencyStamp", "Email", "Gender", "LastName", "NormalizedEmail", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "82b40187-8426-4c44-9260-aa4371ff35d4", "Patient03@gmail.com", 0, "Num 3", null, "AQAAAAIAAYagAAAAEGVdACY+o8GwRrxz3paGnj2qP3g7xXspy2Ll6KteX2Gr9i0LIFXb8yjAIrzTBvEFEA==", "36597696-ff67-4936-9491-db553b98315a", "Patient03@gmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "Patient04",
                columns: new[] { "ConcurrencyStamp", "Email", "Gender", "LastName", "NormalizedEmail", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "bfeffc6d-8588-47e9-b6ce-9ab37239a341", "Patient04@gmail.com", 0, "Num 4", null, "AQAAAAIAAYagAAAAEFZ/jxrvheDFBut+clA9mP+vR7heVjK9rZio+9Avtd8Zd1dc1cJiyTuzHwOeRHve8Q==", "87f29876-35b0-406c-a2c1-9d2165fee687", "Patient04@gmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "Patient05",
                columns: new[] { "ConcurrencyStamp", "Email", "Gender", "LastName", "NormalizedEmail", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "5e16906e-b741-4c96-a243-bf87ac662493", "Patient05@gmail.com", 0, "Num 5", null, "AQAAAAIAAYagAAAAEJNRuPREOv7uOJRBK7LiSMInRUMz1MuXNB3DbnBWKQNRCnkwnTi82JU0PxksfWBXqw==", "9be43ad3-4a11-4565-a756-76e2424e3da0", "Patient05@gmail.com" });
        }
    }
}
