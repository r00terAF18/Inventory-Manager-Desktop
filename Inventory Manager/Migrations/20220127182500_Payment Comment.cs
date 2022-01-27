using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Inventory_Manager.Migrations
{
    public partial class PaymentComment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Comments",
                table: "Payments",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Comments",
                table: "Payments");
        }
    }
}
