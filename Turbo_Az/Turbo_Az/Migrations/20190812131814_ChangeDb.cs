using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Turbo_Az.Migrations
{
    public partial class ChangeDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Firstname",
                table: "AspNetUsers",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Lastname",
                table: "AspNetUsers",
                maxLength: 100,
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Advertisements",
                keyColumn: "Id",
                keyValue: 1,
                column: "AdYear",
                value: new DateTime(2019, 8, 12, 6, 18, 13, 423, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Advertisements",
                keyColumn: "Id",
                keyValue: 2,
                column: "AdYear",
                value: new DateTime(2019, 8, 12, 6, 18, 13, 427, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Advertisements",
                keyColumn: "Id",
                keyValue: 3,
                column: "AdYear",
                value: new DateTime(2019, 8, 12, 6, 18, 13, 427, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                column: "Time",
                value: new DateTime(2019, 8, 12, 6, 18, 13, 428, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                column: "Time",
                value: new DateTime(2019, 8, 12, 6, 18, 13, 429, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 3,
                column: "Time",
                value: new DateTime(2019, 8, 12, 6, 18, 13, 429, DateTimeKind.Local));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Firstname",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Lastname",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "Advertisements",
                keyColumn: "Id",
                keyValue: 1,
                column: "AdYear",
                value: new DateTime(2019, 8, 10, 3, 2, 40, 363, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Advertisements",
                keyColumn: "Id",
                keyValue: 2,
                column: "AdYear",
                value: new DateTime(2019, 8, 10, 3, 2, 40, 367, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Advertisements",
                keyColumn: "Id",
                keyValue: 3,
                column: "AdYear",
                value: new DateTime(2019, 8, 10, 3, 2, 40, 367, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                column: "Time",
                value: new DateTime(2019, 8, 10, 3, 2, 40, 368, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                column: "Time",
                value: new DateTime(2019, 8, 10, 3, 2, 40, 369, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 3,
                column: "Time",
                value: new DateTime(2019, 8, 10, 3, 2, 40, 369, DateTimeKind.Local));
        }
    }
}
