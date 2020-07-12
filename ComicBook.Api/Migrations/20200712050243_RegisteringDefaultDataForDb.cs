using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ComicBook.Api.Migrations
{
    public partial class RegisteringDefaultDataForDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ComicBooks",
                columns: new[] { "Id", "DateOfCreation", "Description", "Issue", "ReleaseDate", "Title" },
                values: new object[] { 1L, new DateTime(2020, 7, 11, 23, 2, 42, 543, DateTimeKind.Local).AddTicks(2444), "Test comic for pollo", 69, new DateTime(2020, 7, 11, 23, 2, 42, 542, DateTimeKind.Local).AddTicks(1480), "Venganza del toro vince part 1" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ComicBooks",
                keyColumn: "Id",
                keyValue: 1L);
        }
    }
}
