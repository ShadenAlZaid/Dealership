using Microsoft.EntityFrameworkCore.Migrations;

namespace Dealership.Data.Migrations
{
    public partial class @new : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cars_VehicleTypes_VehicleTypeId",
                table: "Cars");

            migrationBuilder.DropForeignKey(
                name: "FK_Motorcycles_VehicleTypes_VehicleTypeId",
                table: "Motorcycles");

            migrationBuilder.DropForeignKey(
                name: "FK_Trucks_VehicleTypes_VehicleTypeId",
                table: "Trucks");

            migrationBuilder.AlterColumn<int>(
                name: "VehicleTypeId",
                table: "Trucks",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "VehicleTypeId",
                table: "Motorcycles",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "VehicleTypeId",
                table: "Cars",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_VehicleTypes_VehicleTypeId",
                table: "Cars",
                column: "VehicleTypeId",
                principalTable: "VehicleTypes",
                principalColumn: "VehicleTypeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Motorcycles_VehicleTypes_VehicleTypeId",
                table: "Motorcycles",
                column: "VehicleTypeId",
                principalTable: "VehicleTypes",
                principalColumn: "VehicleTypeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Trucks_VehicleTypes_VehicleTypeId",
                table: "Trucks",
                column: "VehicleTypeId",
                principalTable: "VehicleTypes",
                principalColumn: "VehicleTypeId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cars_VehicleTypes_VehicleTypeId",
                table: "Cars");

            migrationBuilder.DropForeignKey(
                name: "FK_Motorcycles_VehicleTypes_VehicleTypeId",
                table: "Motorcycles");

            migrationBuilder.DropForeignKey(
                name: "FK_Trucks_VehicleTypes_VehicleTypeId",
                table: "Trucks");

            migrationBuilder.AlterColumn<int>(
                name: "VehicleTypeId",
                table: "Trucks",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "VehicleTypeId",
                table: "Motorcycles",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "VehicleTypeId",
                table: "Cars",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_VehicleTypes_VehicleTypeId",
                table: "Cars",
                column: "VehicleTypeId",
                principalTable: "VehicleTypes",
                principalColumn: "VehicleTypeId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Motorcycles_VehicleTypes_VehicleTypeId",
                table: "Motorcycles",
                column: "VehicleTypeId",
                principalTable: "VehicleTypes",
                principalColumn: "VehicleTypeId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Trucks_VehicleTypes_VehicleTypeId",
                table: "Trucks",
                column: "VehicleTypeId",
                principalTable: "VehicleTypes",
                principalColumn: "VehicleTypeId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
