using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShopManagtemant.Infrastructure.Migrations
{
    public partial class _1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    UnitPrice = table.Column<double>(type: "float", nullable: false),
                    Shortdiscription = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: false),
                    Discription = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    IsInStock = table.Column<bool>(type: "bit", nullable: false),
                    code = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Picture = table.Column<string>(type: "nvarchar(900)", maxLength: 900, nullable: false),
                    PictureAlt = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    PictureTitle = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    slug = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Keywords = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Metadiscrption = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    CategoryId = table.Column<long>(type: "bigint", nullable: false),
                    datetime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Product_Productcategory_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Productcategory",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Product_CategoryId",
                table: "Product",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Product");
        }
    }
}
