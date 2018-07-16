using Microsoft.EntityFrameworkCore.Migrations;

namespace Workshop.DAL.Migrations
{
    public partial class ChangeNavigationProperties : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Car",
                table: "Orders",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Order",
                table: "Activities",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Car",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "Order",
                table: "Activities");
        }
    }
}
