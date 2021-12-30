using Microsoft.EntityFrameworkCore.Migrations;

namespace Dealership.Data.Migrations
{
    public partial class dataseeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "VehicleModels",
                keyColumn: "VehicleModelId",
                keyValue: 1,
                column: "VehicleTypeId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "VehicleModels",
                keyColumn: "VehicleModelId",
                keyValue: 2,
                column: "VehicleTypeId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "VehicleModels",
                keyColumn: "VehicleModelId",
                keyValue: 3,
                column: "VehicleTypeId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "VehicleModels",
                keyColumn: "VehicleModelId",
                keyValue: 4,
                column: "VehicleTypeId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "VehicleModels",
                keyColumn: "VehicleModelId",
                keyValue: 5,
                column: "VehicleTypeId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "VehicleModels",
                keyColumn: "VehicleModelId",
                keyValue: 6,
                column: "VehicleTypeId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "VehicleModels",
                keyColumn: "VehicleModelId",
                keyValue: 7,
                column: "VehicleTypeId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "VehicleModels",
                keyColumn: "VehicleModelId",
                keyValue: 8,
                column: "VehicleTypeId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "VehicleModels",
                keyColumn: "VehicleModelId",
                keyValue: 9,
                column: "VehicleTypeId",
                value: 3);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "VehicleModels",
                keyColumn: "VehicleModelId",
                keyValue: 1,
                column: "VehicleTypeId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "VehicleModels",
                keyColumn: "VehicleModelId",
                keyValue: 2,
                column: "VehicleTypeId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "VehicleModels",
                keyColumn: "VehicleModelId",
                keyValue: 3,
                column: "VehicleTypeId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "VehicleModels",
                keyColumn: "VehicleModelId",
                keyValue: 4,
                column: "VehicleTypeId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "VehicleModels",
                keyColumn: "VehicleModelId",
                keyValue: 5,
                column: "VehicleTypeId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "VehicleModels",
                keyColumn: "VehicleModelId",
                keyValue: 6,
                column: "VehicleTypeId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "VehicleModels",
                keyColumn: "VehicleModelId",
                keyValue: 7,
                column: "VehicleTypeId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "VehicleModels",
                keyColumn: "VehicleModelId",
                keyValue: 8,
                column: "VehicleTypeId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "VehicleModels",
                keyColumn: "VehicleModelId",
                keyValue: 9,
                column: "VehicleTypeId",
                value: 0);
        }
    }
}
