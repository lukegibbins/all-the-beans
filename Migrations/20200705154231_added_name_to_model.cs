using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace all_the_beans.Migrations
{
    public partial class added_name_to_model : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Bean",
                keyColumn: "Id",
                keyValue: new Guid("9611afc6-75a3-4c54-a0c8-1efd6e6b5642"));

            migrationBuilder.DeleteData(
                table: "Bean",
                keyColumn: "Id",
                keyValue: new Guid("a950fac4-1e0d-4619-8cb5-1f83df3062ec"));

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Bean",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Bean",
                columns: new[] { "Id", "Aroma", "Colour", "Cost", "Date", "Image", "Name" },
                values: new object[] { new Guid("85bccf51-1aa1-4f3d-916b-f3302f92dcfc"), "smells like chocolate", "black", 5.9900000000000002, new DateTime(2009, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://sample.com", null });

            migrationBuilder.InsertData(
                table: "Bean",
                columns: new[] { "Id", "Aroma", "Colour", "Cost", "Date", "Image", "Name" },
                values: new object[] { new Guid("7575c2b5-ce1e-4f4e-88d1-13b21aef738b"), "smells like flowers", "green", 3.2000000000000002, new DateTime(2010, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://sample.com", null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Bean",
                keyColumn: "Id",
                keyValue: new Guid("7575c2b5-ce1e-4f4e-88d1-13b21aef738b"));

            migrationBuilder.DeleteData(
                table: "Bean",
                keyColumn: "Id",
                keyValue: new Guid("85bccf51-1aa1-4f3d-916b-f3302f92dcfc"));

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Bean");

            migrationBuilder.InsertData(
                table: "Bean",
                columns: new[] { "Id", "Aroma", "Colour", "Cost", "Date", "Image" },
                values: new object[] { new Guid("a950fac4-1e0d-4619-8cb5-1f83df3062ec"), "smells like chocolate", "black", 5.9900000000000002, new DateTime(2009, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://sample.com" });

            migrationBuilder.InsertData(
                table: "Bean",
                columns: new[] { "Id", "Aroma", "Colour", "Cost", "Date", "Image" },
                values: new object[] { new Guid("9611afc6-75a3-4c54-a0c8-1efd6e6b5642"), "smells like flowers", "green", 3.2000000000000002, new DateTime(2010, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://sample.com" });
        }
    }
}
