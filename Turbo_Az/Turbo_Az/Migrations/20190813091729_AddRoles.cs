using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Turbo_Az.Migrations
{
    public partial class AddRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Advertisements",
                keyColumn: "Id",
                keyValue: 1,
                column: "AdYear",
                value: new DateTime(2019, 8, 13, 2, 17, 28, 258, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Advertisements",
                keyColumn: "Id",
                keyValue: 2,
                column: "AdYear",
                value: new DateTime(2019, 8, 13, 2, 17, 28, 261, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Advertisements",
                keyColumn: "Id",
                keyValue: 3,
                column: "AdYear",
                value: new DateTime(2019, 8, 13, 2, 17, 28, 261, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                column: "Time",
                value: new DateTime(2019, 8, 13, 2, 17, 28, 262, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                column: "Time",
                value: new DateTime(2019, 8, 13, 2, 17, 28, 262, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 3,
                column: "Time",
                value: new DateTime(2019, 8, 13, 2, 17, 28, 262, DateTimeKind.Local));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}
