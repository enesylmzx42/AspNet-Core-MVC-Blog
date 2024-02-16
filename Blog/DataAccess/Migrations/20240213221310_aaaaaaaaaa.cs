using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    public partial class aaaaaaaaaa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("212661f2-8866-49eb-b0e5-8cbcc5b995f3"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("38927039-eff1-467d-8da3-f2d62be7361d"));

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "Title", "UserId", "ViewCount" },
                values: new object[,]
                {
                    { new Guid("1f1623c0-c182-43b1-8346-4834cacf9789"), new Guid("d23e4f79-9600-4b5e-b3e9-756cdcacd2b1"), "vallis at tellus. Praesent sapien massa, convallis a pellentesque nec, egestas non nisi.", "Admin Test", new DateTime(2024, 2, 14, 1, 13, 9, 514, DateTimeKind.Local).AddTicks(9710), null, null, new Guid("d16a6ec7-8c50-4ab0-89a5-02b9a551f0fa"), false, null, null, "özel görelilik ama çok özel", new Guid("3aa42229-1c0f-4630-8c1a-db879ecd0427"), 15 },
                    { new Guid("2db3d156-9a5e-48a7-ad6d-7b4a646fe01c"), new Guid("4c569a9a-5f41-478f-9d17-69ac5b02ae0b"), "it tortoan tincidgna justo, lacinia eget conlentesque nec, egestas non nisi.", "Admin Test", new DateTime(2024, 2, 14, 1, 13, 9, 514, DateTimeKind.Local).AddTicks(9701), null, null, new Guid("f71f4b9a-aa60-461d-b398-de31001bf214"), false, null, null, "kuantum fln", new Guid("cb94223b-ccb8-4f2f-93d7-0df96a7f065c"), 15 }
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("16ea936c-7a28-4c30-86a2-9a9704b6115e"),
                column: "ConcurrencyStamp",
                value: "af9c7e5d-9e9c-4af3-95c0-0ac8d425d458");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("7cb750cf-3612-4fb4-9f7d-a38ba8f16bf4"),
                column: "ConcurrencyStamp",
                value: "b73a89a5-28bb-436b-8eb8-e64f02b5a767");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("edf6c246-41d8-475f-8d92-41dddac3aefb"),
                column: "ConcurrencyStamp",
                value: "382e48bf-c8de-4436-a040-1f228f48734d");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3aa42229-1c0f-4630-8c1a-db879ecd0427"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3409751b-5197-4755-ab80-2f6a6e0c81e5", "AQAAAAEAACcQAAAAEE4w8VcZ2oqVxygssiyfZoLob3uMKvBOTQYWE1/j/TXiQ+9w4ybAFvR6Aaa8SrOU1g==", "fe43259e-23c6-4f90-8921-9e46e2faa863" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("cb94223b-ccb8-4f2f-93d7-0df96a7f065c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "16b17dc2-f240-41f9-87f8-f4c6cdd47508", "AQAAAAEAACcQAAAAEPNpulbgpk5rVjS73J/W0+Zq249FJNSA45RYNmI11W+eIEHh3QbhjZIS90UjCtqsnQ==", "29ab4afb-5f88-4fda-8226-ed95c2431248" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4c569a9a-5f41-478f-9d17-69ac5b02ae0b"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 14, 1, 13, 9, 515, DateTimeKind.Local).AddTicks(947));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d23e4f79-9600-4b5e-b3e9-756cdcacd2b1"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 14, 1, 13, 9, 515, DateTimeKind.Local).AddTicks(949));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("d16a6ec7-8c50-4ab0-89a5-02b9a551f0fa"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 14, 1, 13, 9, 515, DateTimeKind.Local).AddTicks(1047));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("f71f4b9a-aa60-461d-b398-de31001bf214"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 14, 1, 13, 9, 515, DateTimeKind.Local).AddTicks(1044));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("1f1623c0-c182-43b1-8346-4834cacf9789"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("2db3d156-9a5e-48a7-ad6d-7b4a646fe01c"));

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "Title", "UserId", "ViewCount" },
                values: new object[,]
                {
                    { new Guid("212661f2-8866-49eb-b0e5-8cbcc5b995f3"), new Guid("4c569a9a-5f41-478f-9d17-69ac5b02ae0b"), "it tortoan tincidgna justo, lacinia eget conlentesque nec, egestas non nisi.", "Admin Test", new DateTime(2024, 2, 12, 0, 36, 7, 644, DateTimeKind.Local).AddTicks(4747), null, null, new Guid("f71f4b9a-aa60-461d-b398-de31001bf214"), false, null, null, "kuantum fln", new Guid("cb94223b-ccb8-4f2f-93d7-0df96a7f065c"), 15 },
                    { new Guid("38927039-eff1-467d-8da3-f2d62be7361d"), new Guid("d23e4f79-9600-4b5e-b3e9-756cdcacd2b1"), "vallis at tellus. Praesent sapien massa, convallis a pellentesque nec, egestas non nisi.", "Admin Test", new DateTime(2024, 2, 12, 0, 36, 7, 644, DateTimeKind.Local).AddTicks(4753), null, null, new Guid("d16a6ec7-8c50-4ab0-89a5-02b9a551f0fa"), false, null, null, "özel görelilik ama çok özel", new Guid("3aa42229-1c0f-4630-8c1a-db879ecd0427"), 15 }
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("16ea936c-7a28-4c30-86a2-9a9704b6115e"),
                column: "ConcurrencyStamp",
                value: "a2b53fcf-4ed9-443a-a3a8-7752def54e18");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("7cb750cf-3612-4fb4-9f7d-a38ba8f16bf4"),
                column: "ConcurrencyStamp",
                value: "ac9bcaf2-7f64-427a-89b0-09b0f79a2ce9");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("edf6c246-41d8-475f-8d92-41dddac3aefb"),
                column: "ConcurrencyStamp",
                value: "7f69c53d-f730-4ab3-abe6-27b45039d160");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3aa42229-1c0f-4630-8c1a-db879ecd0427"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "40e7e527-7a43-4b71-a0ed-e9a4460d1466", "AQAAAAEAACcQAAAAEGJfAgJWSE/LQr8NqgYqWh2utN0NxrtfxNASHN8xDaUZrSosf1/5jJLHxKUgTU+fpA==", "a0f6802a-9b25-475c-b3df-b580307c9d25" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("cb94223b-ccb8-4f2f-93d7-0df96a7f065c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f9e3ca33-cb0d-415f-b80c-dd2d0d41ef8d", "AQAAAAEAACcQAAAAEAeh9tijHWDBydECpsiv75aaLnwzF8QSFHIl+CqXK8D5JjMlZ1CrNPayl5Y+3V6fYw==", "cea62343-f7dd-4457-b2b8-7c359923f17f" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4c569a9a-5f41-478f-9d17-69ac5b02ae0b"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 12, 0, 36, 7, 644, DateTimeKind.Local).AddTicks(6062));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d23e4f79-9600-4b5e-b3e9-756cdcacd2b1"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 12, 0, 36, 7, 644, DateTimeKind.Local).AddTicks(6065));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("d16a6ec7-8c50-4ab0-89a5-02b9a551f0fa"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 12, 0, 36, 7, 644, DateTimeKind.Local).AddTicks(6170));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("f71f4b9a-aa60-461d-b398-de31001bf214"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 12, 0, 36, 7, 644, DateTimeKind.Local).AddTicks(6167));
        }
    }
}
