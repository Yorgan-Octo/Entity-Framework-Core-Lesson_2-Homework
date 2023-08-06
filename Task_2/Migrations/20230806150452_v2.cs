using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Task_2.Migrations
{
    public partial class v2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "products",
                columns: table => new
                {
                    ProductId = table.Column<int>(nullable: false),
                    ProductAlterId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 15, nullable: false),
                    Cost = table.Column<double>(nullable: false),
                    Description = table.Column<string>(maxLength: 50, nullable: true),
                    Quantity = table.Column<int>(nullable: false),
                    WentOnSale = table.Column<DateTime>(type: "Date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_products", x => new { x.ProductId, x.ProductAlterId });
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "products");
        }
    }
}
