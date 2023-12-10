using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vezeeta.Context.Migrations
{
    /// <inheritdoc />
    public partial class UpdateRequest : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Requests_Doctors_DoctorId",
                table: "Requests");

            migrationBuilder.DropForeignKey(
                name: "FK_Requests_Times_TimeId",
                table: "Requests");

            migrationBuilder.DropIndex(
                name: "IX_Requests_TimeId",
                table: "Requests");

            migrationBuilder.AlterColumn<int>(
                name: "TimeId",
                table: "Requests",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "DoctorId",
                table: "Requests",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DicountCode",
                table: "Discounts",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

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
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8c18c10f-2530-4a0a-aa85-49a38c0cae4e", "AQAAAAIAAYagAAAAEISM6wA6R4JtmFb6mdIgaE85tLxsxAWIcbwBr3z3WopmhoaFpsX4N7o9FqslubYCrw==", "e7993315-7d4d-414f-8e32-f9be55e217eb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "Doctor02",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3ddb1400-b543-4db5-a80c-3775fdeb5fd3", "AQAAAAIAAYagAAAAEPwUqhrbYDTbj6r9n+YwXnuQRh2yIi5UseFF3S2qfqC88DpSsdtulr2e1cG2CmDBJg==", "b3993fa1-cd6b-4a9d-aaf9-482ba7fa0f6d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "Doctor03",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bd9453dd-64b0-4c57-a6ce-7303b1571742", "AQAAAAIAAYagAAAAECFSbfjJAJzswvfZ4Ns+v4Q7mNV1GnRzN36X6bDyZ8Edh8CqR7BkR9dn8GCbEHh2Jg==", "40da798e-255f-4ce4-9967-cb18248809f3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "Doctor04",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ffbc0677-1834-4e07-b5a4-a01352dafd08", "AQAAAAIAAYagAAAAEHZZuFndnPZnAFZfuQ+MluTKstz4jPHq43ItFFi1aCy3EAZ4uvGvlMqtL40SdcGb/Q==", "7f530140-089e-4750-87df-78b308b5132b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "Doctor05",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "81774291-8440-40e0-8b24-799881488bd0", "AQAAAAIAAYagAAAAEO76Uyn1q9XJYCuDhgsdUmme7KeQusXrIRGSr5THwk5mhODoluxcVqq+q8Lxq3g9Ng==", "2bc97fb8-5b75-41da-bf76-631ad14e31d6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "Patient01",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ebf27670-2333-471b-8afe-6f4319345e6f", "AQAAAAIAAYagAAAAEMQafEphjj6oZsI6xSxhFD1eXY15mpsX+pDUNt7RgqRQF8OdhRIyt1UMNIGnHMdLsg==", "f9001d0c-73a5-4762-b68e-a58a02aae2fb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "Patient02",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "68d46ecd-3b88-42a1-b6fc-93d377e43290", "AQAAAAIAAYagAAAAEJgZcMkgwF6sgPj7QfXPRtMKIahHaouICVvZMKVPljQrbp5OBmt5nzoCrmUK7/AVJA==", "26ad3816-4b12-4c6c-a3d9-c007a5dd855d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "Patient03",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "82b40187-8426-4c44-9260-aa4371ff35d4", "AQAAAAIAAYagAAAAEGVdACY+o8GwRrxz3paGnj2qP3g7xXspy2Ll6KteX2Gr9i0LIFXb8yjAIrzTBvEFEA==", "36597696-ff67-4936-9491-db553b98315a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "Patient04",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bfeffc6d-8588-47e9-b6ce-9ab37239a341", "AQAAAAIAAYagAAAAEFZ/jxrvheDFBut+clA9mP+vR7heVjK9rZio+9Avtd8Zd1dc1cJiyTuzHwOeRHve8Q==", "87f29876-35b0-406c-a2c1-9d2165fee687" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "Patient05",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5e16906e-b741-4c96-a243-bf87ac662493", "AQAAAAIAAYagAAAAEJNRuPREOv7uOJRBK7LiSMInRUMz1MuXNB3DbnBWKQNRCnkwnTi82JU0PxksfWBXqw==", "9be43ad3-4a11-4565-a756-76e2424e3da0" });

            migrationBuilder.UpdateData(
                table: "Requests",
                keyColumn: "Id",
                keyValue: 1,
                column: "DoctorId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Requests",
                keyColumn: "Id",
                keyValue: 2,
                column: "DoctorId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Requests",
                keyColumn: "Id",
                keyValue: 3,
                column: "DoctorId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Requests",
                keyColumn: "Id",
                keyValue: 4,
                column: "DoctorId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Requests",
                keyColumn: "Id",
                keyValue: 5,
                column: "DoctorId",
                value: 3);

            migrationBuilder.CreateIndex(
                name: "IX_Requests_TimeId",
                table: "Requests",
                column: "TimeId",
                unique: true,
                filter: "[TimeId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Discounts_DicountCode",
                table: "Discounts",
                column: "DicountCode",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Requests_Doctors_DoctorId",
                table: "Requests",
                column: "DoctorId",
                principalTable: "Doctors",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Requests_Times_TimeId",
                table: "Requests",
                column: "TimeId",
                principalTable: "Times",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Requests_Doctors_DoctorId",
                table: "Requests");

            migrationBuilder.DropForeignKey(
                name: "FK_Requests_Times_TimeId",
                table: "Requests");

            migrationBuilder.DropIndex(
                name: "IX_Requests_TimeId",
                table: "Requests");

            migrationBuilder.DropIndex(
                name: "IX_Discounts_DicountCode",
                table: "Discounts");

            migrationBuilder.AlterColumn<int>(
                name: "TimeId",
                table: "Requests",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DoctorId",
                table: "Requests",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "DicountCode",
                table: "Discounts",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db12554843e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e47dabbd-7f10-46d7-a0f1-902ecad691f7", "AQAAAAIAAYagAAAAEKQmCQBu/FP1xZkewsI8ZW/gzfobhnX1r7125rOgOGhBxbPrKgrPGkL93lsETk8gQw==", "19a29855-48ef-4c4d-b796-1809ccb6ba44" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "Doctor01",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9f431d6f-48ac-46fd-83fb-cbe45ecee7b9", "AQAAAAIAAYagAAAAEM55EqyCZa1W/B8/jGnz41sKuqb4Hn5i4ISOIOqto5AgOcJYX5njPqcBOinuwvlqZA==", "00a12084-7136-44a4-a88f-f12fd03e8231" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "Doctor02",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d9d4d126-56f5-428d-be0d-f4c857b40002", "AQAAAAIAAYagAAAAEHUIZ0x2Tr3nZLtUofNln9mDF/d2EPPXj4kxOSni0flmC+lClhwLOLhst0GFILyrZQ==", "4234f282-7743-4555-9380-8e2b1ac5bf76" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "Doctor03",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e9597a9a-644b-4ff2-8cbb-8dda22a6e447", "AQAAAAIAAYagAAAAEHiH2EY3VIqVs2+EShWyxdAF7kICGSeBdMl67onYA+mOfzykGIMVcO2kcUjIC29Onw==", "484ab764-103c-405a-8d99-5d742bba28fa" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "Doctor04",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "77b37962-2a3b-4fed-ae84-f222d9e27351", "AQAAAAIAAYagAAAAEEzgLuyePQbWQpfxtOJGHZl4gKK3WsIErxUF5BAC/ZMghsdjB1XixeAH8nRlEt8XkA==", "1b7482c0-75b0-4b63-a9f4-fd4da0bed650" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "Doctor05",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "44d9517c-3aa8-46b5-9ce1-05a3e5a8ce6e", "AQAAAAIAAYagAAAAEPTakrThZsTNljQUgIspkO9/bwWL65DUSavqkmVI00r+zfllG4F6/UwVJNCcyAhNIg==", "72e6ad22-d4ea-476f-babe-d67955586c5a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "Patient01",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2f687158-f0f9-4334-ba78-1ca3c6dde6a2", "AQAAAAIAAYagAAAAEPZmu7/jAzKOvwvtn8P6UkCWGZp45KbqhIaso3zcfMhFwUwIeaXOlh8aNuOhmDsWGQ==", "0d865d24-0c22-47b3-bd89-efa22a952c5a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "Patient02",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "936c004e-0a84-49cf-8ae7-6ed243bb6d13", "AQAAAAIAAYagAAAAEFgauCjBii1w0q0QcT1DGtCrHvUKLtmSfVUhoVY+4bB7TNbdBUYmMQYc4nEPwvKg1w==", "3cac2cec-188f-4a25-b83e-552fb90d0c84" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "Patient03",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "31ff0e78-9ea9-45fe-8c7a-e444c1080d91", "AQAAAAIAAYagAAAAEL2t2T4ryZkOvoVJ8SCf+vZHhYfWOwvi4j93w5hRDBCYe60f+XBJb8FwomyCMZj3WA==", "44453093-6a79-4a4c-9225-8b871055d2af" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "Patient04",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "57b1f50e-ca29-4065-93b3-ce7356f0d50a", "AQAAAAIAAYagAAAAEG/XAFOivj1ZuBDN7kvDM8ltdgQR1SeP/CkeTvEVWLjjiXaydaOJPXxJM6Oklh6kew==", "15c1c10c-0a7c-41af-82b1-2717b9a4ddca" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "Patient05",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b164bbe2-1854-4bdb-8f82-f7cfa38194da", "AQAAAAIAAYagAAAAELIvrdZ1xjkV5Q9cOdDCHn+xHP+lBqAghZUXOxKCiTDql51wMDDj2T3IKk5f6srYfQ==", "78afb3b3-8cd7-458a-8add-9a9f7b63e562" });

            migrationBuilder.UpdateData(
                table: "Requests",
                keyColumn: "Id",
                keyValue: 1,
                column: "DoctorId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Requests",
                keyColumn: "Id",
                keyValue: 2,
                column: "DoctorId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Requests",
                keyColumn: "Id",
                keyValue: 3,
                column: "DoctorId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Requests",
                keyColumn: "Id",
                keyValue: 4,
                column: "DoctorId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Requests",
                keyColumn: "Id",
                keyValue: 5,
                column: "DoctorId",
                value: null);

            migrationBuilder.CreateIndex(
                name: "IX_Requests_TimeId",
                table: "Requests",
                column: "TimeId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Requests_Doctors_DoctorId",
                table: "Requests",
                column: "DoctorId",
                principalTable: "Doctors",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Requests_Times_TimeId",
                table: "Requests",
                column: "TimeId",
                principalTable: "Times",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
