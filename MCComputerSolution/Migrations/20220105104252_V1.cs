using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MCComputerSolution.Migrations
{
    public partial class V1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    OId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomerName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OrderDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OrderQty = table.Column<int>(type: "int", nullable: false),
                    UnitPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Discount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TotalAmt = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    SysCreatedBy = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
                    SysCreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SysDeletedBy = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
                    SysDeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SysUpdatedBy = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
                    SysUpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.OId);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AvbQty = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    SysCreatedBy = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
                    SysCreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SysDeletedBy = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
                    SysDeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SysUpdatedBy = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
                    SysUpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
