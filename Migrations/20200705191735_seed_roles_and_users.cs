using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace all_the_beans.Migrations
{
    public partial class seed_roles_and_users : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Bean",
                keyColumn: "Id",
                keyValue: new Guid("ca396eb5-dfd7-45ae-8fb5-44ab3605b9e8"));

            migrationBuilder.DeleteData(
                table: "Bean",
                keyColumn: "Id",
                keyValue: new Guid("cab03eaf-4d4c-430b-a2b1-9b4e5ff476f6"));

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                table: "Bean",
                columns: new[] { "Id", "Aroma", "Colour", "Cost", "Date", "Image", "Name" },
                values: new object[] { new Guid("cab03eaf-4d4c-430b-a2b1-9b4e5ff476f6"), "smells like chocolate", "black", 5.9900000000000002, new DateTime(2009, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://sample.com", "Craigy's cocoa bean" });

            migrationBuilder.InsertData(
                table: "Bean",
                columns: new[] { "Id", "Aroma", "Colour", "Cost", "Date", "Image", "Name" },
                values: new object[] { new Guid("ca396eb5-dfd7-45ae-8fb5-44ab3605b9e8"), "smells like flowers", "green", 3.2000000000000002, new DateTime(2010, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://sample.com", "Columbias finest" });
        }
    }
}
