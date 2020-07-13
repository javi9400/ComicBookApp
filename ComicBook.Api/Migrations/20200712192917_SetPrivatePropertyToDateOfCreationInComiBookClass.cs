using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ComicBook.Api.Migrations
{
    public partial class SetPrivatePropertyToDateOfCreationInComiBookClass : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ComicBooks",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "DateOfCreation", "ReleaseDate" },
                values: new object[] { new DateTime(2020, 7, 12, 13, 29, 17, 549, DateTimeKind.Local).AddTicks(8990), new DateTime(2020, 7, 12, 13, 29, 17, 550, DateTimeKind.Local).AddTicks(7826) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ComicBooks",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "DateOfCreation", "ReleaseDate" },
                values: new object[] { new DateTime(2020, 7, 11, 23, 2, 42, 543, DateTimeKind.Local).AddTicks(2444), new DateTime(2020, 7, 11, 23, 2, 42, 542, DateTimeKind.Local).AddTicks(1480) });
        }
    }
}
