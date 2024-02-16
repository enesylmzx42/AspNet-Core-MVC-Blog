using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    public partial class aaaaa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("9b0bf0ac-f112-4add-aabd-f8addbc4d078"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("a89e17d0-f1de-40fc-99ec-77dae8dd96f9"));

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { new Guid("9b0bf0ac-f112-4add-aabd-f8addbc4d078"), new Guid("4c569a9a-5f41-478f-9d17-69ac5b02ae0b"), "it tortoan tincidgna justo, lacinia eget conlentesque nec, egestas non nisi.", "Admin Test", new DateTime(2024, 2, 8, 17, 15, 52, 954, DateTimeKind.Local).AddTicks(9547), null, null, new Guid("f71f4b9a-aa60-461d-b398-de31001bf214"), false, null, null, "kuantum fln", new Guid("cb94223b-ccb8-4f2f-93d7-0df96a7f065c"), 15 },
                    { new Guid("a89e17d0-f1de-40fc-99ec-77dae8dd96f9"), new Guid("d23e4f79-9600-4b5e-b3e9-756cdcacd2b1"), "vallis at tellus. Praesent sapien massa, convallis a pellentesque nec, egestas non nisi.", "Admin Test", new DateTime(2024, 2, 8, 17, 15, 52, 954, DateTimeKind.Local).AddTicks(9563), null, null, new Guid("d16a6ec7-8c50-4ab0-89a5-02b9a551f0fa"), false, null, null, "özel görelilik ama çok özel", new Guid("3aa42229-1c0f-4630-8c1a-db879ecd0427"), 15 }
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("16ea936c-7a28-4c30-86a2-9a9704b6115e"),
                column: "ConcurrencyStamp",
                value: "52c2c3b3-810f-4b92-8ec7-4dca8c172bab");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("7cb750cf-3612-4fb4-9f7d-a38ba8f16bf4"),
                column: "ConcurrencyStamp",
                value: "1a1a8aa3-0a6e-4d1d-b6d2-648724e107e4");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("edf6c246-41d8-475f-8d92-41dddac3aefb"),
                column: "ConcurrencyStamp",
                value: "688f8951-20b6-4ee3-af2e-8413fa963252");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3aa42229-1c0f-4630-8c1a-db879ecd0427"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f3f2a534-9951-456e-bb76-ca9fc2759c6c", "AQAAAAEAACcQAAAAEOQaEEkPNvLSJUEzmyXl1Mz01JDLO8Gl9cLcoZxVmpO0oe4Av3K172GfFvugXeo3NA==", "407cf3db-cf80-44e4-bdd5-f2c2081ae49f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("cb94223b-ccb8-4f2f-93d7-0df96a7f065c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "df1b194e-af3e-4991-85bf-a4ae4b5c768a", "AQAAAAEAACcQAAAAECHCDFY2QHTr8yXf7DvxdOplbVumUdwMiwddZbjsc4+NPzkIvD6yhH8PRJvLCseZwg==", "7376f553-b6c6-408e-92a3-6a8ad9ae6ddd" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4c569a9a-5f41-478f-9d17-69ac5b02ae0b"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 8, 17, 15, 52, 955, DateTimeKind.Local).AddTicks(866));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d23e4f79-9600-4b5e-b3e9-756cdcacd2b1"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 8, 17, 15, 52, 955, DateTimeKind.Local).AddTicks(869));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("d16a6ec7-8c50-4ab0-89a5-02b9a551f0fa"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 8, 17, 15, 52, 955, DateTimeKind.Local).AddTicks(960));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("f71f4b9a-aa60-461d-b398-de31001bf214"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 8, 17, 15, 52, 955, DateTimeKind.Local).AddTicks(957));
        }
    }
}
