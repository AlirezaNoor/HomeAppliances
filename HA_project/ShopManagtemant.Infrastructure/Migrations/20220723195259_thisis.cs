using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShopManagtemant.Infrastructure.Migrations
{
    public partial class thisis : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsInStock",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "UnitPrice",
                table: "Product");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsInStock",
                table: "Product",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<double>(
                name: "UnitPrice",
                table: "Product",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }
    }
}
