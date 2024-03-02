using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Triditech.Data.Migrations
{
    /// <inheritdoc />
    public partial class DomainTablesAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Product ID")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Category name")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                },
                comment: "Product category");

            migrationBuilder.CreateTable(
                name: "Vendors",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "Vendor identifier"),
                    PhoneNumber = table.Column<string>(type: "nvarchar(16)", maxLength: 16, nullable: false, comment: "Vendor's phone"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false, comment: "User Identifier")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vendors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Vendors_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                },
                comment: "Vendor of products");

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "Product ID"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Product's name"),
                    Description = table.Column<string>(type: "nvarchar(1500)", maxLength: 1500, nullable: false, comment: "Product Description"),
                    Quantity = table.Column<int>(type: "int", nullable: false, comment: "Product Quantity"),
                    Industry = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false, comment: "Product's industry"),
                    Material = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false, comment: "The material of the Product"),
                    Process = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false, comment: "The process of making of the Product"),
                    Weight = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Product's weight"),
                    CategoryId = table.Column<int>(type: "int", nullable: false, comment: "Product's category's ID"),
                    PriceEuro = table.Column<decimal>(type: "decimal(18,2)", nullable: false, comment: "Product's price in EURO"),
                    VendorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "Product's vendor's ID")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_Vendors_VendorId",
                        column: x => x.VendorId,
                        principalTable: "Vendors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                },
                comment: "Product table");

            migrationBuilder.CreateTable(
                name: "ProductImages",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "Image's ID"),
                    ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "Image's Product's ID"),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "Image's URL")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductImages_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                },
                comment: "Images for the products");

            migrationBuilder.CreateIndex(
                name: "IX_ProductImages_ProductId",
                table: "ProductImages",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_VendorId",
                table: "Products",
                column: "VendorId");

            migrationBuilder.CreateIndex(
                name: "IX_Vendors_PhoneNumber",
                table: "Vendors",
                column: "PhoneNumber",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Vendors_UserId",
                table: "Vendors",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductImages");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Vendors");
        }
    }
}
