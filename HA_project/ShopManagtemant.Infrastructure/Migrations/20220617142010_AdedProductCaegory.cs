using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShopManagtemant.Infrastructure.Migrations
{
    public partial class AdedProductCaegory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Productcategory",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Discription = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Picture = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    Alt = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    ImageTitle = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Keywords = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    MetaDiscription = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Slug = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    datetime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Productcategory", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Productcategory");
        }
    }
}
