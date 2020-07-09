using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace all_the_beans.Migrations
{
    public partial class seeddatebase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "3d651cdb-d104-4f88-b94b-c22cebf1548c", "36393a68-aa1c-4c25-8f87-3b581fa4480a" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "c239bcaa-1f8b-448e-a450-f3794358c94e", "d16938ed-5451-474f-b076-f2f4329544ab" });

            migrationBuilder.DeleteData(
                table: "Bean",
                keyColumn: "Id",
                keyValue: new Guid("59bda3dc-e9b1-42f2-b97c-855befd70699"));

            migrationBuilder.DeleteData(
                table: "Bean",
                keyColumn: "Id",
                keyValue: new Guid("ce00d69c-3bf8-4586-a021-2616a958a745"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "36393a68-aa1c-4c25-8f87-3b581fa4480a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d16938ed-5451-474f-b076-f2f4329544ab");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3d651cdb-d104-4f88-b94b-c22cebf1548c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c239bcaa-1f8b-448e-a450-f3794358c94e");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "776c24f9-9aa0-42c8-a13c-fef8a63aedc4", "78b6e98d-f4a8-4444-960a-c7d4a1734bdd", "Admin", "ADMIN" },
                    { "05182a6a-b6cd-4ecf-87f1-d226db6f17c0", "9abebcc9-cdb2-449d-bd40-dc4971b53db4", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "a011818e-618d-4d46-ae53-99d39b6f1fbc", 0, "ce859e24-a7c4-482b-a4dd-0780a3dd8d7e", "admin@admin.com", false, false, null, "admin@admin.com", "admin", "AQAAAAEAACcQAAAAEANMz7cEAMvn6xBFVipUu+SiG8TRhbpGXK7mho8Xd8xmndyQ08bhLOTTD8J2qi7Cyw==", null, false, "", false, "admin" },
                    { "94c1873d-6bb8-4426-8cd5-c007bc6f14d2", 0, "eee7c356-943f-4708-a707-b95e60c7069e", "user@user.com", false, false, null, "user@user.com", "user", "AQAAAAEAACcQAAAAEE2zVsPTqryIVW7s+XexrCESYXBW5MstGsbBO0WfGzHUIvC3iAQFU02YPoyTDSdfIg==", null, false, null, false, "user" }
                });

            migrationBuilder.InsertData(
                table: "Bean",
                columns: new[] { "Id", "Aroma", "Colour", "Cost", "Date", "Image", "Name" },
                values: new object[,]
                {
                    { new Guid("0f7bc910-7c78-4664-8011-116187efa656"), "Smoky", "Dark", 5.9900000000000002, new DateTime(2020, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "default-advert1.jpg", "Arabica" },
                    { new Guid("b40de992-49e7-43e9-bd0e-08f6b4bd8848"), "Medicinal", "green", 9.9900000000000002, new DateTime(2020, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "default-advert1.jpg", "Robusta" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "a011818e-618d-4d46-ae53-99d39b6f1fbc", "776c24f9-9aa0-42c8-a13c-fef8a63aedc4" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "94c1873d-6bb8-4426-8cd5-c007bc6f14d2", "05182a6a-b6cd-4ecf-87f1-d226db6f17c0" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "94c1873d-6bb8-4426-8cd5-c007bc6f14d2", "05182a6a-b6cd-4ecf-87f1-d226db6f17c0" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "a011818e-618d-4d46-ae53-99d39b6f1fbc", "776c24f9-9aa0-42c8-a13c-fef8a63aedc4" });

            migrationBuilder.DeleteData(
                table: "Bean",
                keyColumn: "Id",
                keyValue: new Guid("0f7bc910-7c78-4664-8011-116187efa656"));

            migrationBuilder.DeleteData(
                table: "Bean",
                keyColumn: "Id",
                keyValue: new Guid("b40de992-49e7-43e9-bd0e-08f6b4bd8848"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "05182a6a-b6cd-4ecf-87f1-d226db6f17c0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "776c24f9-9aa0-42c8-a13c-fef8a63aedc4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "94c1873d-6bb8-4426-8cd5-c007bc6f14d2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a011818e-618d-4d46-ae53-99d39b6f1fbc");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "36393a68-aa1c-4c25-8f87-3b581fa4480a", "7d997d08-edd9-431e-8acf-9c941f1b9d47", "Admin", "ADMIN" },
                    { "d16938ed-5451-474f-b076-f2f4329544ab", "dfd09878-f16f-4624-a456-3d13726f5af0", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "3d651cdb-d104-4f88-b94b-c22cebf1548c", 0, "2c90b7cf-7614-48ea-acac-8dcc81ea5c98", "admin@admin.com", false, false, null, null, null, "admin", null, false, null, false, "admin" },
                    { "c239bcaa-1f8b-448e-a450-f3794358c94e", 0, "bc476ca3-9206-4c19-872a-c214ef429b4a", "user@user.com", false, false, null, null, null, "user", null, false, null, false, "user" }
                });

            migrationBuilder.InsertData(
                table: "Bean",
                columns: new[] { "Id", "Aroma", "Colour", "Cost", "Date", "Image", "Name" },
                values: new object[,]
                {
                    { new Guid("59bda3dc-e9b1-42f2-b97c-855befd70699"), "smells like chocolate", "black", 5.9900000000000002, new DateTime(2009, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://sample.com", "Craigy's cocoa bean" },
                    { new Guid("ce00d69c-3bf8-4586-a021-2616a958a745"), "smells like flowers", "green", 3.2000000000000002, new DateTime(2010, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://sample.com", "Columbias finest" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "3d651cdb-d104-4f88-b94b-c22cebf1548c", "36393a68-aa1c-4c25-8f87-3b581fa4480a" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "c239bcaa-1f8b-448e-a450-f3794358c94e", "d16938ed-5451-474f-b076-f2f4329544ab" });
        }
    }
}
