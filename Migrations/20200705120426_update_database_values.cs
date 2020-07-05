using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace all_the_beans.Migrations
{
    public partial class update_database_values : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Bean",
                keyColumn: "Id",
                keyValue: new Guid("54094434-14bb-4295-b8ad-9eb8cc6816e8"));

            migrationBuilder.DeleteData(
                table: "Bean",
                keyColumn: "Id",
                keyValue: new Guid("df1a227b-dcb6-45a3-b67f-91b5871df524"));

            migrationBuilder.InsertData(
                table: "Bean",
                columns: new[] { "Id", "Aroma", "Colour", "Cost", "Date", "Image" },
                values: new object[] { new Guid("a950fac4-1e0d-4619-8cb5-1f83df3062ec"), "smells like chocolate", "black", 5.9900000000000002, new DateTime(2009, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://sample.com" });

            migrationBuilder.InsertData(
                table: "Bean",
                columns: new[] { "Id", "Aroma", "Colour", "Cost", "Date", "Image" },
                values: new object[] { new Guid("9611afc6-75a3-4c54-a0c8-1efd6e6b5642"), "smells like flowers", "green", 3.2000000000000002, new DateTime(2010, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://sample.com" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Bean",
                keyColumn: "Id",
                keyValue: new Guid("9611afc6-75a3-4c54-a0c8-1efd6e6b5642"));

            migrationBuilder.DeleteData(
                table: "Bean",
                keyColumn: "Id",
                keyValue: new Guid("a950fac4-1e0d-4619-8cb5-1f83df3062ec"));

            migrationBuilder.InsertData(
                table: "Bean",
                columns: new[] { "Id", "Aroma", "Colour", "Cost", "Date", "Image" },
                values: new object[] { new Guid("df1a227b-dcb6-45a3-b67f-91b5871df524"), "smells like chocolate", "black", 5.9900000000000002, new DateTime(2009, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://sample.com" });

            migrationBuilder.InsertData(
                table: "Bean",
                columns: new[] { "Id", "Aroma", "Colour", "Cost", "Date", "Image" },
                values: new object[] { new Guid("54094434-14bb-4295-b8ad-9eb8cc6816e8"), "smells like chocolate", "black", 3.2000000000000002, new DateTime(2009, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://sample.com" });
        }
    }
}
