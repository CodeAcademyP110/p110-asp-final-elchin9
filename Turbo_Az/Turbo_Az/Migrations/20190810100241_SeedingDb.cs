using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Turbo_Az.Migrations
{
    public partial class SeedingDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Advertisements",
                keyColumn: "Id",
                keyValue: 1,
                column: "AdYear",
                value: new DateTime(2019, 8, 10, 3, 2, 40, 363, DateTimeKind.Local));

            migrationBuilder.InsertData(
                table: "Advertisements",
                columns: new[] { "Id", "AdYear", "CarInfo", "CityId", "ColorId", "FuelId", "GradiuationYearId", "Hiking", "IsVip", "MachinePowerId", "ModelId", "PhotoURL", "Price", "SpeedId", "UpdateYear" },
                values: new object[,]
                {
                    { 2, new DateTime(2019, 8, 10, 3, 2, 40, 367, DateTimeKind.Local), "Biraz orasin-burasin vurmusam", 2, 3, 1, 1, 8000, false, 4, 3, "car2.jpg", 50000m, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, new DateTime(2019, 8, 10, 3, 2, 40, 367, DateTimeKind.Local), "Biraz orasin-burasin vurmusam", 3, 2, 2, 2, 76000, false, 4, 2, "car1.jpg", 17000m, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Advertisements",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Advertisements",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "Advertisements",
                keyColumn: "Id",
                keyValue: 1,
                column: "AdYear",
                value: new DateTime(2019, 8, 10, 2, 45, 0, 315, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                column: "Time",
                value: new DateTime(2019, 8, 10, 2, 45, 0, 319, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                column: "Time",
                value: new DateTime(2019, 8, 10, 2, 45, 0, 319, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 3,
                column: "Time",
                value: new DateTime(2019, 8, 10, 2, 45, 0, 319, DateTimeKind.Local));
        }
    }
}
