using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace all_the_beans.Migrations
{
    public partial class seeddatabasewithidentitynormalizedrolesretry : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "13e5e8fe-e906-4aa8-a17b-e9e1c37ea9eb", "13e5e8fe-e906-4aa8-a17b-e9e1c37ea9eb" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "2cfa095f-f6eb-49c1-9f7b-c24562ae5953", "2cfa095f-f6eb-49c1-9f7b-c24562ae5953" });

            migrationBuilder.DeleteData(
                table: "Bean",
                keyColumn: "Id",
                keyValue: new Guid("13179f47-d582-495a-854c-c4198d9ad3a0"));

            migrationBuilder.DeleteData(
                table: "Bean",
                keyColumn: "Id",
                keyValue: new Guid("4d0231bc-86b2-454f-b1af-8443bad5e53a"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "13e5e8fe-e906-4aa8-a17b-e9e1c37ea9eb");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2cfa095f-f6eb-49c1-9f7b-c24562ae5953");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "13e5e8fe-e906-4aa8-a17b-e9e1c37ea9eb");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2cfa095f-f6eb-49c1-9f7b-c24562ae5953");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[,]
                {
                    { "13e5e8fe-e906-4aa8-a17b-e9e1c37ea9eb", "7f9a944e-6890-41a9-a7c5-40d25732180c", "Admin", "ADMIN" },
                    { "2cfa095f-f6eb-49c1-9f7b-c24562ae5953", "5aed07f2-2627-470d-b24d-909045f1dbdb", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "13e5e8fe-e906-4aa8-a17b-e9e1c37ea9eb", 0, "7065b3b7-2b1c-44c6-b0d6-41b9f13b7947", "admin@admin.com", false, false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAEAOSrkz7HmF9BsjsGWlUdo5VxPSGQ0Cvf0jY1m4fv4KxGAHJbhEdBQ3FPobsoEk9cQ==", null, false, "548aa376-2803-4b1a-a259-8bf6d7d50351", false, "admin@admin.com" },
                    { "2cfa095f-f6eb-49c1-9f7b-c24562ae5953", 0, "1eb5cc11-eb37-4844-81d6-5df040c9fd33", "user@user.com", false, false, null, "USER@USER.COM", "USER@USER.COM", "AQAAAAEAACcQAAAAEJq5fct2BtjxxpFToCZbiUex0FNmK25lVQbZlFN1U/2O9RRxPQKUc6UopxS5OVmv5A==", null, false, "5e057a0a-6654-4a4f-80ba-04a831eaf5b2", false, "user@user.com" }
                });

            migrationBuilder.InsertData(
                table: "Bean",
                columns: new[] { "Id", "Aroma", "Colour", "Cost", "Date", "Image", "Name" },
                values: new object[,]
                {
                    { new Guid("4d0231bc-86b2-454f-b1af-8443bad5e53a"), "Smoky", "Dark", 5.9900000000000002, new DateTime(2020, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "1594313819_def.jpg", "Arabica" },
                    { new Guid("13179f47-d582-495a-854c-c4198d9ad3a0"), "Medicinal", "green", 9.9900000000000002, new DateTime(2020, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "1594313817_def.jpg", "Robusta" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "13e5e8fe-e906-4aa8-a17b-e9e1c37ea9eb", "13e5e8fe-e906-4aa8-a17b-e9e1c37ea9eb" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "2cfa095f-f6eb-49c1-9f7b-c24562ae5953", "2cfa095f-f6eb-49c1-9f7b-c24562ae5953" });
        }
    }
}
