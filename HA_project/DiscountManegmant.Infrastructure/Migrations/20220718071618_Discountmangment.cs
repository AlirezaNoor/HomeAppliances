using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DiscountManegmant.Infrastructure.Migrations
{
    public partial class Discountmangment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CustomerDiscount",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    productId = table.Column<long>(type: "bigint", nullable: false),
                    DiscountRate = table.Column<int>(type: "int", nullable: false),
                    StartDiscount = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDiscount = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Reason = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    datetime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerDiscount", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CustomerDiscount");
        }
    }
}
