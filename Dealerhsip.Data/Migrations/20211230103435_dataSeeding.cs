using Microsoft.EntityFrameworkCore.Migrations;

namespace Dealership.Data.Migrations
{
    public partial class dataSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "VehicleColors",
                columns: new[] { "VehicleColorId", "Name" },
                values: new object[,]
                {
                    { 1, "Black" },
                    { 2, "White" },
                    { 3, "Red" },
                    { 4, "Blue" },
                    { 5, "Silver" }
                });

            migrationBuilder.InsertData(
                table: "VehicleModels",
                columns: new[] { "VehicleModelId", "Name", "VehicleTypeId" },
                values: new object[,]
                {
                    { 9, "Ranger", 0 },
                    { 8, "Tornado", 0 },
                    { 7, "Silverado", 0 },
                    { 6, "Hurricane", 0 },
                    { 4, "Valkryie", 0 },
                    { 3, "Expedition", 0 },
                    { 2, "Explorer", 0 },
                    { 1, "Taurus", 0 },
                    { 5, "GoldWing", 0 }
                });

            migrationBuilder.InsertData(
                table: "VehicleTypes",
                columns: new[] { "VehicleTypeId", "Name" },
                values: new object[,]
                {
                    { 2, "Motorcycle" },
                    { 1, "Car" },
                    { 3, "Truck" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "VehicleColors",
                keyColumn: "VehicleColorId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "VehicleColors",
                keyColumn: "VehicleColorId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "VehicleColors",
                keyColumn: "VehicleColorId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "VehicleColors",
                keyColumn: "VehicleColorId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "VehicleColors",
                keyColumn: "VehicleColorId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "VehicleModels",
                keyColumn: "VehicleModelId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "VehicleModels",
                keyColumn: "VehicleModelId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "VehicleModels",
                keyColumn: "VehicleModelId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "VehicleModels",
                keyColumn: "VehicleModelId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "VehicleModels",
                keyColumn: "VehicleModelId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "VehicleModels",
                keyColumn: "VehicleModelId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "VehicleModels",
                keyColumn: "VehicleModelId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "VehicleModels",
                keyColumn: "VehicleModelId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "VehicleModels",
                keyColumn: "VehicleModelId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "VehicleTypes",
                keyColumn: "VehicleTypeId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "VehicleTypes",
                keyColumn: "VehicleTypeId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "VehicleTypes",
                keyColumn: "VehicleTypeId",
                keyValue: 3);
        }
    }
}
