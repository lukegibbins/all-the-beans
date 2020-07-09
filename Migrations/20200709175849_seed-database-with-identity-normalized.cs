using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace all_the_beans.Migrations
{
    public partial class seeddatabasewithidentitynormalized : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { "c6ede810-d9dd-4a2f-9d4d-1efdf5cfdf30", "088bfb1c-94ae-4e5a-a4c0-e1333e239f32", "Admin", "ADMIN" },
                    { "46a1a034-a048-4daa-b71f-385b358e71b0", "f453848e-3862-43c8-8215-8bb3fe9fbeb2", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "82588896-0acf-401c-953f-69ac4910a587", 0, "3ef99be4-059a-488c-9dff-d1dfbbfb1a1f", "admin@admin.com", false, false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAENyLvXdvZCrUQvK9fxoLVKmFnutoAShzIFlS4JG64wk2PQPemACV3D74EG82Mk/TJg==", null, false, "9267c7a6-0534-46db-88b1-c393ea4a7f20", false, "admin@admin.com" },
                    { "97f62380-cb4a-4038-b7d0-e92592906228", 0, "cd7a4b07-639e-4ceb-b29a-06618327454d", "user@user.com", false, false, null, "USER@USER.COM", "USER@USER.COM", "AQAAAAEAACcQAAAAEBxX4yDA8M2SXmeDpwUx2aTD0SrqryT7oFvkqPCmxBGTSRePb1IIZCoziutiDW9Efg==", null, false, "11ba9ac8-94b9-4263-84dc-1f01965eb798", false, "user@user.com" }
                });

            migrationBuilder.InsertData(
                table: "Bean",
                columns: new[] { "Id", "Aroma", "Colour", "Cost", "Date", "Image", "Name" },
                values: new object[,]
                {
                    { new Guid("327747b2-96d0-42d0-a54a-921b2dd04871"), "Smoky", "Dark", 5.9900000000000002, new DateTime(2020, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "1594313819_def.jpg", "Arabica" },
                    { new Guid("60834e24-3dd7-4fbb-8f61-d6555ce1e1df"), "Medicinal", "green", 9.9900000000000002, new DateTime(2020, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "1594313817_def.jpg", "Robusta" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "82588896-0acf-401c-953f-69ac4910a587", "c6ede810-d9dd-4a2f-9d4d-1efdf5cfdf30" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "97f62380-cb4a-4038-b7d0-e92592906228", "46a1a034-a048-4daa-b71f-385b358e71b0" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "82588896-0acf-401c-953f-69ac4910a587", "c6ede810-d9dd-4a2f-9d4d-1efdf5cfdf30" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "97f62380-cb4a-4038-b7d0-e92592906228", "46a1a034-a048-4daa-b71f-385b358e71b0" });

            migrationBuilder.DeleteData(
                table: "Bean",
                keyColumn: "Id",
                keyValue: new Guid("327747b2-96d0-42d0-a54a-921b2dd04871"));

            migrationBuilder.DeleteData(
                table: "Bean",
                keyColumn: "Id",
                keyValue: new Guid("60834e24-3dd7-4fbb-8f61-d6555ce1e1df"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "46a1a034-a048-4daa-b71f-385b358e71b0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c6ede810-d9dd-4a2f-9d4d-1efdf5cfdf30");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "82588896-0acf-401c-953f-69ac4910a587");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "97f62380-cb4a-4038-b7d0-e92592906228");

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
    }
}
