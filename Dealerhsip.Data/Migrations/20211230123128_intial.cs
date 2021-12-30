using Microsoft.EntityFrameworkCore.Migrations;

namespace Dealership.Data.Migrations
{
    public partial class intial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "VehicleColors",
                columns: table => new
                {
                    VehicleColorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleColors", x => x.VehicleColorId);
                });

            migrationBuilder.CreateTable(
                name: "VehicleTypes",
                columns: table => new
                {
                    VehicleTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleTypes", x => x.VehicleTypeId);
                });

            migrationBuilder.CreateTable(
                name: "VehicleModels",
                columns: table => new
                {
                    VehicleModelId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VehicleTypeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleModels", x => x.VehicleModelId);
                    table.ForeignKey(
                        name: "FK_VehicleModels_VehicleTypes_VehicleTypeId",
                        column: x => x.VehicleTypeId,
                        principalTable: "VehicleTypes",
                        principalColumn: "VehicleTypeId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Cars",
                columns: table => new
                {
                    CarId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VehicleTypeId = table.Column<int>(type: "int", nullable: false),
                    VehicleColorId = table.Column<int>(type: "int", nullable: false),
                    VehicleModelId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cars", x => x.CarId);
                    table.ForeignKey(
                        name: "FK_Cars_VehicleColors_VehicleColorId",
                        column: x => x.VehicleColorId,
                        principalTable: "VehicleColors",
                        principalColumn: "VehicleColorId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Cars_VehicleModels_VehicleModelId",
                        column: x => x.VehicleModelId,
                        principalTable: "VehicleModels",
                        principalColumn: "VehicleModelId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Cars_VehicleTypes_VehicleTypeId",
                        column: x => x.VehicleTypeId,
                        principalTable: "VehicleTypes",
                        principalColumn: "VehicleTypeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Motorcycles",
                columns: table => new
                {
                    MotorcycleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VehicleTypeId = table.Column<int>(type: "int", nullable: false),
                    VehicleColorId = table.Column<int>(type: "int", nullable: false),
                    VehicleModelId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Motorcycles", x => x.MotorcycleId);
                    table.ForeignKey(
                        name: "FK_Motorcycles_VehicleColors_VehicleColorId",
                        column: x => x.VehicleColorId,
                        principalTable: "VehicleColors",
                        principalColumn: "VehicleColorId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Motorcycles_VehicleModels_VehicleModelId",
                        column: x => x.VehicleModelId,
                        principalTable: "VehicleModels",
                        principalColumn: "VehicleModelId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Motorcycles_VehicleTypes_VehicleTypeId",
                        column: x => x.VehicleTypeId,
                        principalTable: "VehicleTypes",
                        principalColumn: "VehicleTypeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Trucks",
                columns: table => new
                {
                    TruckId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VehicleTypeId = table.Column<int>(type: "int", nullable: false),
                    VehicleColorId = table.Column<int>(type: "int", nullable: false),
                    VehicleModelId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trucks", x => x.TruckId);
                    table.ForeignKey(
                        name: "FK_Trucks_VehicleColors_VehicleColorId",
                        column: x => x.VehicleColorId,
                        principalTable: "VehicleColors",
                        principalColumn: "VehicleColorId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Trucks_VehicleModels_VehicleModelId",
                        column: x => x.VehicleModelId,
                        principalTable: "VehicleModels",
                        principalColumn: "VehicleModelId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Trucks_VehicleTypes_VehicleTypeId",
                        column: x => x.VehicleTypeId,
                        principalTable: "VehicleTypes",
                        principalColumn: "VehicleTypeId",
                        onDelete: ReferentialAction.Cascade);
                });

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
                table: "VehicleTypes",
                columns: new[] { "VehicleTypeId", "Name" },
                values: new object[,]
                {
                    { 1, "Car" },
                    { 2, "Motorcycle" },
                    { 3, "Truck" }
                });

            migrationBuilder.InsertData(
                table: "VehicleModels",
                columns: new[] { "VehicleModelId", "Name", "VehicleTypeId" },
                values: new object[,]
                {
                    { 1, "Taurus", 1 },
                    { 2, "Explorer", 1 },
                    { 3, "Expedition", 1 },
                    { 4, "Valkryie", 2 },
                    { 5, "GoldWing", 2 },
                    { 6, "Hurricane", 2 },
                    { 7, "Silverado", 3 },
                    { 8, "Tornado", 3 },
                    { 9, "Ranger", 3 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cars_VehicleColorId",
                table: "Cars",
                column: "VehicleColorId");

            migrationBuilder.CreateIndex(
                name: "IX_Cars_VehicleModelId",
                table: "Cars",
                column: "VehicleModelId");

            migrationBuilder.CreateIndex(
                name: "IX_Cars_VehicleTypeId",
                table: "Cars",
                column: "VehicleTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Motorcycles_VehicleColorId",
                table: "Motorcycles",
                column: "VehicleColorId");

            migrationBuilder.CreateIndex(
                name: "IX_Motorcycles_VehicleModelId",
                table: "Motorcycles",
                column: "VehicleModelId");

            migrationBuilder.CreateIndex(
                name: "IX_Motorcycles_VehicleTypeId",
                table: "Motorcycles",
                column: "VehicleTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Trucks_VehicleColorId",
                table: "Trucks",
                column: "VehicleColorId");

            migrationBuilder.CreateIndex(
                name: "IX_Trucks_VehicleModelId",
                table: "Trucks",
                column: "VehicleModelId");

            migrationBuilder.CreateIndex(
                name: "IX_Trucks_VehicleTypeId",
                table: "Trucks",
                column: "VehicleTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleModels_VehicleTypeId",
                table: "VehicleModels",
                column: "VehicleTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cars");

            migrationBuilder.DropTable(
                name: "Motorcycles");

            migrationBuilder.DropTable(
                name: "Trucks");

            migrationBuilder.DropTable(
                name: "VehicleColors");

            migrationBuilder.DropTable(
                name: "VehicleModels");

            migrationBuilder.DropTable(
                name: "VehicleTypes");
        }
    }
}
