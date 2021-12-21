using Microsoft.EntityFrameworkCore.Migrations;

namespace Dealerhsip.Data.Migrations
{
    public partial class DTO : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cars_VehicleColors_VehicleColorId",
                table: "Cars");

            migrationBuilder.DropForeignKey(
                name: "FK_Cars_VehicleModels_VehicleModelId",
                table: "Cars");

            migrationBuilder.DropForeignKey(
                name: "FK_Motorcycles_VehicleColors_VehicleColorId",
                table: "Motorcycles");

            migrationBuilder.DropForeignKey(
                name: "FK_Motorcycles_VehicleModels_VehicleModelId",
                table: "Motorcycles");

            migrationBuilder.DropForeignKey(
                name: "FK_Trucks_VehicleColors_VehicleColorId",
                table: "Trucks");

            migrationBuilder.DropForeignKey(
                name: "FK_Trucks_VehicleModels_VehicleModelId",
                table: "Trucks");

            migrationBuilder.AlterColumn<int>(
                name: "VehicleModelId",
                table: "Trucks",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "VehicleColorId",
                table: "Trucks",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "VehicleModelId",
                table: "Motorcycles",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "VehicleColorId",
                table: "Motorcycles",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "VehicleModelId",
                table: "Cars",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "VehicleColorId",
                table: "Cars",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "VehicleDTO",
                columns: table => new
                {
                    VehicleDTOId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VehicleTypeId = table.Column<int>(type: "int", nullable: true),
                    VehicleColorId = table.Column<int>(type: "int", nullable: true),
                    VehicleModelId = table.Column<int>(type: "int", nullable: true),
                    ModelId = table.Column<int>(type: "int", nullable: false),
                    ModelName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ColorId = table.Column<int>(type: "int", nullable: false),
                    ColorName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleDTO", x => x.VehicleDTOId);
                    table.ForeignKey(
                        name: "FK_VehicleDTO_VehicleColors_VehicleColorId",
                        column: x => x.VehicleColorId,
                        principalTable: "VehicleColors",
                        principalColumn: "VehicleColorId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_VehicleDTO_VehicleModels_VehicleModelId",
                        column: x => x.VehicleModelId,
                        principalTable: "VehicleModels",
                        principalColumn: "VehicleModelId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_VehicleDTO_VehicleTypes_VehicleTypeId",
                        column: x => x.VehicleTypeId,
                        principalTable: "VehicleTypes",
                        principalColumn: "VehicleTypeId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_VehicleDTO_VehicleColorId",
                table: "VehicleDTO",
                column: "VehicleColorId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleDTO_VehicleModelId",
                table: "VehicleDTO",
                column: "VehicleModelId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleDTO_VehicleTypeId",
                table: "VehicleDTO",
                column: "VehicleTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_VehicleColors_VehicleColorId",
                table: "Cars",
                column: "VehicleColorId",
                principalTable: "VehicleColors",
                principalColumn: "VehicleColorId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_VehicleModels_VehicleModelId",
                table: "Cars",
                column: "VehicleModelId",
                principalTable: "VehicleModels",
                principalColumn: "VehicleModelId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Motorcycles_VehicleColors_VehicleColorId",
                table: "Motorcycles",
                column: "VehicleColorId",
                principalTable: "VehicleColors",
                principalColumn: "VehicleColorId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Motorcycles_VehicleModels_VehicleModelId",
                table: "Motorcycles",
                column: "VehicleModelId",
                principalTable: "VehicleModels",
                principalColumn: "VehicleModelId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Trucks_VehicleColors_VehicleColorId",
                table: "Trucks",
                column: "VehicleColorId",
                principalTable: "VehicleColors",
                principalColumn: "VehicleColorId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Trucks_VehicleModels_VehicleModelId",
                table: "Trucks",
                column: "VehicleModelId",
                principalTable: "VehicleModels",
                principalColumn: "VehicleModelId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cars_VehicleColors_VehicleColorId",
                table: "Cars");

            migrationBuilder.DropForeignKey(
                name: "FK_Cars_VehicleModels_VehicleModelId",
                table: "Cars");

            migrationBuilder.DropForeignKey(
                name: "FK_Motorcycles_VehicleColors_VehicleColorId",
                table: "Motorcycles");

            migrationBuilder.DropForeignKey(
                name: "FK_Motorcycles_VehicleModels_VehicleModelId",
                table: "Motorcycles");

            migrationBuilder.DropForeignKey(
                name: "FK_Trucks_VehicleColors_VehicleColorId",
                table: "Trucks");

            migrationBuilder.DropForeignKey(
                name: "FK_Trucks_VehicleModels_VehicleModelId",
                table: "Trucks");

            migrationBuilder.DropTable(
                name: "VehicleDTO");

            migrationBuilder.AlterColumn<int>(
                name: "VehicleModelId",
                table: "Trucks",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "VehicleColorId",
                table: "Trucks",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "VehicleModelId",
                table: "Motorcycles",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "VehicleColorId",
                table: "Motorcycles",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "VehicleModelId",
                table: "Cars",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "VehicleColorId",
                table: "Cars",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_VehicleColors_VehicleColorId",
                table: "Cars",
                column: "VehicleColorId",
                principalTable: "VehicleColors",
                principalColumn: "VehicleColorId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_VehicleModels_VehicleModelId",
                table: "Cars",
                column: "VehicleModelId",
                principalTable: "VehicleModels",
                principalColumn: "VehicleModelId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Motorcycles_VehicleColors_VehicleColorId",
                table: "Motorcycles",
                column: "VehicleColorId",
                principalTable: "VehicleColors",
                principalColumn: "VehicleColorId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Motorcycles_VehicleModels_VehicleModelId",
                table: "Motorcycles",
                column: "VehicleModelId",
                principalTable: "VehicleModels",
                principalColumn: "VehicleModelId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Trucks_VehicleColors_VehicleColorId",
                table: "Trucks",
                column: "VehicleColorId",
                principalTable: "VehicleColors",
                principalColumn: "VehicleColorId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Trucks_VehicleModels_VehicleModelId",
                table: "Trucks",
                column: "VehicleModelId",
                principalTable: "VehicleModels",
                principalColumn: "VehicleModelId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
