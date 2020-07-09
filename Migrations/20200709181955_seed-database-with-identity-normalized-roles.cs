using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace all_the_beans.Migrations
{
    public partial class seeddatabasewithidentitynormalizedroles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
