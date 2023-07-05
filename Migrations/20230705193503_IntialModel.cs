using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EasyShop.Migrations
{
    /// <inheritdoc />
    public partial class IntialModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Supplier = table.Column<string>(type: "TEXT", nullable: true),
                    Category = table.Column<string>(type: "TEXT", nullable: true),
                    QuantityPerUnit = table.Column<string>(type: "TEXT", nullable: true),
                    PricePerUnit = table.Column<decimal>(type: "TEXT", nullable: true),
                    UnitsInStock = table.Column<decimal>(type: "TEXT", nullable: true),
                    Available = table.Column<bool>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Available", "Category", "Name", "PricePerUnit", "QuantityPerUnit", "Supplier", "UnitsInStock" },
                values: new object[,]
                {
                    { new Guid("9494116b-2b85-4d13-9e3e-6c1c08112bcc"), true, "Electronics", "Samsung Galaxy S21", 899.99m, "1 unit", "Samsung", 50m },
                    { new Guid("cbf9e4ca-8240-4d36-b4cd-6305ec0d81aa"), true, "Shoes", "Nike Air Max 270", 129.99m, "1 pair", "Nike", 200m },
                    { new Guid("eeef3728-4733-4825-b21a-b80a0773b278"), true, "Electronics", "iPhone 12", 999.99m, "1 unit", "Apple", 100m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
