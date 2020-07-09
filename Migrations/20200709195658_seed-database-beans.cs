using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace all_the_beans.Migrations
{
    public partial class seeddatabasebeans : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "fe0c3868-b71e-4129-bd2f-e8a6178165ac", "8177d045-4bb0-4d05-81cc-215661ff1af6" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "36db4065-8e1f-442f-bdf1-b03a592296c1");

            migrationBuilder.DeleteData(
                table: "Bean",
                keyColumn: "Id",
                keyValue: new Guid("9a25f824-c812-4566-b77e-5fbfbfa451bd"));

            migrationBuilder.DeleteData(
                table: "Bean",
                keyColumn: "Id",
                keyValue: new Guid("f1adf04d-45ed-4706-913d-e1b8b4a52641"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8177d045-4bb0-4d05-81cc-215661ff1af6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fe0c3868-b71e-4129-bd2f-e8a6178165ac");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f916f7de-f988-45ab-9e31-8652996c3bca", "72115431-db0a-4474-bf9d-667f4adf8e25", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "9904e825-53d4-4819-b4c6-d6b16f086ece", 0, "237e6a3c-3972-4839-bd71-13a1b228b9b9", "admin@admin.com", false, false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAELv9NT9hN0i99dLgHOhB2ltn1t98efBVToA52f4bTHAmF4AL97c58W9feOVSzw1f/w==", null, false, "6e254b2c-1905-4075-88c4-6e204da7be9d", false, "admin@admin.com" },
                    { "e1c9206b-936e-4743-9ef6-346a0dda71a4", 0, "86180d46-d4c0-4a43-89fb-137fd0edf6a9", "user@user.com", false, false, null, "USER@USER.COM", "USER@USER.COM", "AQAAAAEAACcQAAAAELTkVRGMBakVNld8Bfhns74A/926VyIDntJYrJveVkVAwl16KnWaoy/jUXqoWpqDmg==", null, false, "a4f806f9-b92a-4602-a736-960919e02af3", false, "user@user.com" }
                });

            migrationBuilder.InsertData(
                table: "Bean",
                columns: new[] { "Id", "Aroma", "Colour", "Cost", "Date", "Image", "Name" },
                values: new object[,]
                {
                    { new Guid("6979ccab-edc7-4562-ade1-7ebc11e2baed"), "Smoky", "Dark", 5.9900000000000002, new DateTime(2020, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "1594313819_def.jpg", "Arabica" },
                    { new Guid("464aeefa-95bf-4ed7-920c-aa7cac7fe59c"), "Medicinal", "Very dark", 9.9900000000000002, new DateTime(2020, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "1594313817_def.jpg", "Robusta" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "9904e825-53d4-4819-b4c6-d6b16f086ece", "f916f7de-f988-45ab-9e31-8652996c3bca" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "9904e825-53d4-4819-b4c6-d6b16f086ece", "f916f7de-f988-45ab-9e31-8652996c3bca" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e1c9206b-936e-4743-9ef6-346a0dda71a4");

            migrationBuilder.DeleteData(
                table: "Bean",
                keyColumn: "Id",
                keyValue: new Guid("464aeefa-95bf-4ed7-920c-aa7cac7fe59c"));

            migrationBuilder.DeleteData(
                table: "Bean",
                keyColumn: "Id",
                keyValue: new Guid("6979ccab-edc7-4562-ade1-7ebc11e2baed"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f916f7de-f988-45ab-9e31-8652996c3bca");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9904e825-53d4-4819-b4c6-d6b16f086ece");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8177d045-4bb0-4d05-81cc-215661ff1af6", "72115431-db0a-4474-bf9d-667f4adf8e25", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "fe0c3868-b71e-4129-bd2f-e8a6178165ac", 0, "4dc40078-6a6b-4cb5-a042-08cb30318236", "admin@admin.com", false, false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAEEtM5XQpYXa4lcxTUTHN+YiLuDX7CZ6AF9esSQdPAU4HK+Sz8uRqNKWjdK6/HP006Q==", null, false, "e809d707-b7ec-43a3-b232-b5781f852c56", false, "admin@admin.com" },
                    { "36db4065-8e1f-442f-bdf1-b03a592296c1", 0, "ccd5e50e-ca0e-45f9-b9b1-bb33dcf34034", "user@user.com", false, false, null, "USER@USER.COM", "USER@USER.COM", "AQAAAAEAACcQAAAAEDiHx7Nfmkddz3dIK86+Diw1+mhG8LPf/ypbvp/VhBfGZ4emXpGA1//2Yw8qFoj30g==", null, false, "5e7cb259-8d37-4f0f-b0ec-79af484df05e", false, "user@user.com" }
                });

            migrationBuilder.InsertData(
                table: "Bean",
                columns: new[] { "Id", "Aroma", "Colour", "Cost", "Date", "Image", "Name" },
                values: new object[,]
                {
                    { new Guid("9a25f824-c812-4566-b77e-5fbfbfa451bd"), "Smoky", "Dark", 5.9900000000000002, new DateTime(2020, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "1594313819_def.jpg", "Arabica" },
                    { new Guid("f1adf04d-45ed-4706-913d-e1b8b4a52641"), "Medicinal", "green", 9.9900000000000002, new DateTime(2020, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "1594313817_def.jpg", "Robusta" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "fe0c3868-b71e-4129-bd2f-e8a6178165ac", "8177d045-4bb0-4d05-81cc-215661ff1af6" });
        }
    }
}
