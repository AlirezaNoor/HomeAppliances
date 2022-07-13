using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShopManagtemant.Infrastructure.Migrations
{
    public partial class AddSlder1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Slider",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    slidePicture = table.Column<string>(type: "nvarchar(max)", maxLength: 10000, nullable: false),
                    headingTitle = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    title = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    discription = table.Column<string>(type: "nvarchar(800)", maxLength: 800, nullable: false),
                    Btntitle = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    ISRemove = table.Column<bool>(type: "bit", nullable: false),
                    datetime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Slider", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Slider");
        }
    }
}
