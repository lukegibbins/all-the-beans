using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace all_the_beans.Migrations
{
    public partial class seeddatabasewithidentity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { "289dc8e0-6545-476d-9938-f8a91a5b4c06", "3bf0caca-56b8-4cb9-9e70-f9d9d6743fdc", "Admin", "ADMIN" },
                    { "d2cdd69e-8570-40b5-b9e7-66311f4ff58b", "72386aba-08b0-4def-af4c-fcb5be9f1e35", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "c063670f-98da-4a2c-ad75-4afc3368a5e8", 0, "b856493f-a3f7-4974-b539-aea8f6f15303", "admin@admin.com", false, false, null, "ADMIN@ADMIN.COM", "ADMIN", "AQAAAAEAACcQAAAAEKUpJAmks9KlW5ipgtIe3s9uFC7a6c7Zx3P2ggEBWxy2sPgT2N8gvlyhMIMucELahg==", null, false, null, false, "admin@admin.com" },
                    { "3fdfcb9b-d459-4e0b-9cdb-e98d63177b3e", 0, "8f0d2f14-c710-4221-ae2c-eeefdbc82473", "user@user.com", false, false, null, "USER@USER.COM", "USER", "AQAAAAEAACcQAAAAEMFzcJsi+mqCtGrY38HJrSlmuNJySVS5Ea6dkBWxiU8idNaJiM4kzTiW7ojgiA6jsw==", null, false, null, false, "user@user.com" }
                });

            migrationBuilder.InsertData(
                table: "Bean",
                columns: new[] { "Id", "Aroma", "Colour", "Cost", "Date", "Image", "Name" },
                values: new object[,]
                {
                    { new Guid("a1ca9024-387a-44e6-9b75-bbe2364b72da"), "Smoky", "Dark", 5.9900000000000002, new DateTime(2020, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "1594313819_def.jpg", "Arabica" },
                    { new Guid("c3f1e87a-cb2d-43e7-80b3-d7801b9b7d87"), "Medicinal", "green", 9.9900000000000002, new DateTime(2020, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "1594313817_def.jpg", "Robusta" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "c063670f-98da-4a2c-ad75-4afc3368a5e8", "289dc8e0-6545-476d-9938-f8a91a5b4c06" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "3fdfcb9b-d459-4e0b-9cdb-e98d63177b3e", "d2cdd69e-8570-40b5-b9e7-66311f4ff58b" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "3fdfcb9b-d459-4e0b-9cdb-e98d63177b3e", "d2cdd69e-8570-40b5-b9e7-66311f4ff58b" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "c063670f-98da-4a2c-ad75-4afc3368a5e8", "289dc8e0-6545-476d-9938-f8a91a5b4c06" });

            migrationBuilder.DeleteData(
                table: "Bean",
                keyColumn: "Id",
                keyValue: new Guid("a1ca9024-387a-44e6-9b75-bbe2364b72da"));

            migrationBuilder.DeleteData(
                table: "Bean",
                keyColumn: "Id",
                keyValue: new Guid("c3f1e87a-cb2d-43e7-80b3-d7801b9b7d87"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "289dc8e0-6545-476d-9938-f8a91a5b4c06");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d2cdd69e-8570-40b5-b9e7-66311f4ff58b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3fdfcb9b-d459-4e0b-9cdb-e98d63177b3e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c063670f-98da-4a2c-ad75-4afc3368a5e8");

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
    }
}
