using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace all_the_beans.Migrations
{
    public partial class fixedimagefilenames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { "0c4d91b4-f625-42b2-8e20-c1c16b30e8c4", "ce822efa-82f7-439b-ae99-de7389cdb516", "Admin", "ADMIN" },
                    { "18e71363-2bf5-43c5-8a53-e35d6b2169e8", "e4a8b8e2-05f0-4bde-9db8-aecc04222373", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "91b6b79b-a407-43b4-919f-bdf334859d51", 0, "5e11beb6-edd0-4f38-89ba-d93bc6f15f01", "admin@admin.com", false, false, null, "admin@admin.com", "admin", "AQAAAAEAACcQAAAAEGhd4/89biozxTL6kJnEdgypFFDHzYjkiXegs8IIZPOReuhwU4WDgMOD+BfYbBJflA==", null, false, "", false, "admin" },
                    { "88f67aa5-0cac-4b61-acb5-f22017ab13f5", 0, "d1729ad5-26bf-4d8b-82ec-1e96cab481fe", "user@user.com", false, false, null, "user@user.com", "user", "AQAAAAEAACcQAAAAEMc3CN8yaHIZwc1qsAGmjBmUeuxn3HkYE1FzRnNL08LM5GjGdrhpd4JkXgvb0+sWBQ==", null, false, null, false, "user" }
                });

            migrationBuilder.InsertData(
                table: "Bean",
                columns: new[] { "Id", "Aroma", "Colour", "Cost", "Date", "Image", "Name" },
                values: new object[,]
                {
                    { new Guid("9dd52b5f-3ba2-4db7-9cfc-336b3667668c"), "Smoky", "Dark", 5.9900000000000002, new DateTime(2020, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "1594313819_def.jpg", "Arabica" },
                    { new Guid("d69d7a97-f716-49b1-9aa2-eb742a064720"), "Medicinal", "green", 9.9900000000000002, new DateTime(2020, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "1594313817_def.jpg", "Robusta" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "91b6b79b-a407-43b4-919f-bdf334859d51", "0c4d91b4-f625-42b2-8e20-c1c16b30e8c4" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "88f67aa5-0cac-4b61-acb5-f22017ab13f5", "18e71363-2bf5-43c5-8a53-e35d6b2169e8" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "88f67aa5-0cac-4b61-acb5-f22017ab13f5", "18e71363-2bf5-43c5-8a53-e35d6b2169e8" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "91b6b79b-a407-43b4-919f-bdf334859d51", "0c4d91b4-f625-42b2-8e20-c1c16b30e8c4" });

            migrationBuilder.DeleteData(
                table: "Bean",
                keyColumn: "Id",
                keyValue: new Guid("9dd52b5f-3ba2-4db7-9cfc-336b3667668c"));

            migrationBuilder.DeleteData(
                table: "Bean",
                keyColumn: "Id",
                keyValue: new Guid("d69d7a97-f716-49b1-9aa2-eb742a064720"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0c4d91b4-f625-42b2-8e20-c1c16b30e8c4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "18e71363-2bf5-43c5-8a53-e35d6b2169e8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "88f67aa5-0cac-4b61-acb5-f22017ab13f5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "91b6b79b-a407-43b4-919f-bdf334859d51");

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
    }
}
