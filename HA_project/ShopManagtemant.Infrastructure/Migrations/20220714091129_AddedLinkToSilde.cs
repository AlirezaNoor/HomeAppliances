using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShopManagtemant.Infrastructure.Migrations
{
    public partial class AddedLinkToSilde : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Link",
                table: "Slider",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Link",
                table: "Slider");
        }
    }
}
