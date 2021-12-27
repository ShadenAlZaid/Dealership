using Microsoft.EntityFrameworkCore.Migrations;

namespace Dealership.Data.Migrations
{
    public partial class vehicleid : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_VehicleModels_VehicleTypeId",
                table: "VehicleModels",
                column: "VehicleTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_VehicleModels_VehicleTypes_VehicleTypeId",
                table: "VehicleModels",
                column: "VehicleTypeId",
                principalTable: "VehicleTypes",
                principalColumn: "VehicleTypeId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_VehicleModels_VehicleTypes_VehicleTypeId",
                table: "VehicleModels");

            migrationBuilder.DropIndex(
                name: "IX_VehicleModels_VehicleTypeId",
                table: "VehicleModels");
        }
    }
}
