using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ComicBook.Api.Migrations
{
    public partial class ChangedDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ComicBooks",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "DateOfCreation", "ReleaseDate" },
                values: new object[] { new DateTime(2020, 7, 12, 19, 3, 48, 585, DateTimeKind.Local).AddTicks(1767), new DateTime(2020, 7, 12, 19, 3, 48, 586, DateTimeKind.Local).AddTicks(5031) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ComicBooks",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "DateOfCreation", "ReleaseDate" },
                values: new object[] { new DateTime(2020, 7, 12, 13, 29, 17, 549, DateTimeKind.Local).AddTicks(8990), new DateTime(2020, 7, 12, 13, 29, 17, 550, DateTimeKind.Local).AddTicks(7826) });
        }
    }
}
