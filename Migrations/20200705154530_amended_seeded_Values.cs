using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace all_the_beans.Migrations
{
    public partial class amended_seeded_Values : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Bean",
                keyColumn: "Id",
                keyValue: new Guid("7575c2b5-ce1e-4f4e-88d1-13b21aef738b"));

            migrationBuilder.DeleteData(
                table: "Bean",
                keyColumn: "Id",
                keyValue: new Guid("85bccf51-1aa1-4f3d-916b-f3302f92dcfc"));

            migrationBuilder.InsertData(
                table: "Bean",
                columns: new[] { "Id", "Aroma", "Colour", "Cost", "Date", "Image", "Name" },
                values: new object[] { new Guid("cab03eaf-4d4c-430b-a2b1-9b4e5ff476f6"), "smells like chocolate", "black", 5.9900000000000002, new DateTime(2009, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://sample.com", "Craigy's cocoa bean" });

            migrationBuilder.InsertData(
                table: "Bean",
                columns: new[] { "Id", "Aroma", "Colour", "Cost", "Date", "Image", "Name" },
                values: new object[] { new Guid("ca396eb5-dfd7-45ae-8fb5-44ab3605b9e8"), "smells like flowers", "green", 3.2000000000000002, new DateTime(2010, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://sample.com", "Columbias finest" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                table: "Bean",
                columns: new[] { "Id", "Aroma", "Colour", "Cost", "Date", "Image", "Name" },
                values: new object[] { new Guid("85bccf51-1aa1-4f3d-916b-f3302f92dcfc"), "smells like chocolate", "black", 5.9900000000000002, new DateTime(2009, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://sample.com", null });

            migrationBuilder.InsertData(
                table: "Bean",
                columns: new[] { "Id", "Aroma", "Colour", "Cost", "Date", "Image", "Name" },
                values: new object[] { new Guid("7575c2b5-ce1e-4f4e-88d1-13b21aef738b"), "smells like flowers", "green", 3.2000000000000002, new DateTime(2010, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://sample.com", null });
        }
    }
}
