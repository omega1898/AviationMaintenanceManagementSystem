using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AviationMaintenanceManagementSystem.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    CustomerId = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    Address = table.Column<string>(maxLength: 100, nullable: false),
                    Phone = table.Column<string>(maxLength: 12, nullable: false),
                    Email = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.CustomerId);
                });

            migrationBuilder.CreateTable(
                name: "Inventories",
                columns: table => new
                {
                    PartNumber = table.Column<string>(nullable: false),
                    Nomenclature = table.Column<string>(maxLength: 100, nullable: false),
                    Quantity = table.Column<int>(nullable: false),
                    PricePerUnit = table.Column<decimal>(nullable: false),
                    Manufacturer = table.Column<string>(maxLength: 50, nullable: false),
                    DeliveryStatus = table.Column<string>(maxLength: 100, nullable: false),
                    AssignedJobNumber = table.Column<string>(nullable: true),
                    AssignedWorkCenter = table.Column<string>(nullable: true),
                    RecievedDate = table.Column<DateTime>(nullable: false),
                    ReceivedBy = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inventories", x => x.PartNumber);
                });

            migrationBuilder.CreateTable(
                name: "WorkCenters",
                columns: table => new
                {
                    WorkCenterId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    Supervisor = table.Column<string>(maxLength: 50, nullable: false),
                    PhoneExtension = table.Column<string>(maxLength: 12, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkCenters", x => x.WorkCenterId);
                });

            migrationBuilder.CreateTable(
                name: "WorkOrders",
                columns: table => new
                {
                    JobNumber = table.Column<string>(nullable: false),
                    Discrepancy = table.Column<string>(maxLength: 500, nullable: false),
                    CorrectiveAction = table.Column<string>(maxLength: 500, nullable: false),
                    Notes = table.Column<string>(maxLength: 500, nullable: true),
                    Date = table.Column<DateTime>(nullable: false),
                    Time = table.Column<DateTime>(nullable: false),
                    EquipmentStatus = table.Column<string>(nullable: false),
                    WorkCenterId = table.Column<int>(nullable: false),
                    SerialNumber = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkOrders", x => x.JobNumber);
                    table.ForeignKey(
                        name: "FK_WorkOrders_WorkCenters_WorkCenterId",
                        column: x => x.WorkCenterId,
                        principalTable: "WorkCenters",
                        principalColumn: "WorkCenterId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_WorkOrders_WorkCenterId",
                table: "WorkOrders",
                column: "WorkCenterId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Inventories");

            migrationBuilder.DropTable(
                name: "WorkOrders");

            migrationBuilder.DropTable(
                name: "WorkCenters");
        }
    }
}
