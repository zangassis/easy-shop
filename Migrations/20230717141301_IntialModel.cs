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
                    { new Guid("46bbb389-0c7d-410b-a728-b227a8153494"), true, "Shoes", "Athletic Running Tennis Shoes", 129.99m, "1 pair", "BestShoes", 200m },
                    { new Guid("baf743c6-65ad-4f9b-a756-94dc234900d5"), true, "Electronics", "Wireless Mouse ABX", 999.99m, "1 unit", "ABX", 100m },
                    { new Guid("dfe6d01b-5af4-46c4-aa8a-3884cc4fe764"), true, "Electronics", "Computer Monitor FHD 1080P", 899.99m, "1 unit", "NewHD", 50m }
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
