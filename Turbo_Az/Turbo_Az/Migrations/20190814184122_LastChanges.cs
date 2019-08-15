using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Turbo_Az.Migrations
{
    public partial class LastChanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Advertisements",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.UpdateData(
                table: "Advertisements",
                keyColumn: "Id",
                keyValue: 1,
                column: "AdYear",
                value: new DateTime(2019, 8, 14, 11, 41, 21, 21, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Advertisements",
                keyColumn: "Id",
                keyValue: 2,
                column: "AdYear",
                value: new DateTime(2019, 8, 14, 11, 41, 21, 24, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Advertisements",
                keyColumn: "Id",
                keyValue: 3,
                column: "AdYear",
                value: new DateTime(2019, 8, 14, 11, 41, 21, 24, DateTimeKind.Local));

            migrationBuilder.InsertData(
                table: "Advertisements",
                columns: new[] { "Id", "AdYear", "CarInfo", "CityId", "ColorId", "FuelId", "GradiuationYearId", "Hiking", "IsVip", "MachinePowerId", "ModelId", "PhotoURL", "Price", "SpeedId", "UpdateYear" },
                values: new object[] { 5, new DateTime(2019, 8, 14, 11, 41, 21, 24, DateTimeKind.Local), "Biraz orasin-burasin vurmusam", 1, 1, 1, 1, 12000, true, 4, 3, "car2.jpg", 25000m, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                column: "Time",
                value: new DateTime(2019, 8, 14, 11, 41, 21, 25, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                column: "Time",
                value: new DateTime(2019, 8, 14, 11, 41, 21, 25, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 3,
                column: "Time",
                value: new DateTime(2019, 8, 14, 11, 41, 21, 25, DateTimeKind.Local));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Advertisements",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.UpdateData(
                table: "Advertisements",
                keyColumn: "Id",
                keyValue: 1,
                column: "AdYear",
                value: new DateTime(2019, 8, 14, 11, 38, 23, 165, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Advertisements",
                keyColumn: "Id",
                keyValue: 2,
                column: "AdYear",
                value: new DateTime(2019, 8, 14, 11, 38, 23, 169, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Advertisements",
                keyColumn: "Id",
                keyValue: 3,
                column: "AdYear",
                value: new DateTime(2019, 8, 14, 11, 38, 23, 169, DateTimeKind.Local));

            migrationBuilder.InsertData(
                table: "Advertisements",
                columns: new[] { "Id", "AdYear", "CarInfo", "CityId", "ColorId", "FuelId", "GradiuationYearId", "Hiking", "IsVip", "MachinePowerId", "ModelId", "PhotoURL", "Price", "SpeedId", "UpdateYear" },
                values: new object[] { 4, new DateTime(2019, 8, 14, 11, 38, 23, 169, DateTimeKind.Local), "Biraz orasin-burasin vurmusam", 1, 1, 1, 1, 12000, true, 4, 3, "car2.jpg", 25000m, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                column: "Time",
                value: new DateTime(2019, 8, 14, 11, 38, 23, 170, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                column: "Time",
                value: new DateTime(2019, 8, 14, 11, 38, 23, 170, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 3,
                column: "Time",
                value: new DateTime(2019, 8, 14, 11, 38, 23, 170, DateTimeKind.Local));
        }
    }
}
