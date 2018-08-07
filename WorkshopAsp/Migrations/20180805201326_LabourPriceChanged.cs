using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace WorkshopAsp.Migrations
{
    public partial class LabourPriceChanged : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "LaborPrice",
                table: "Activities",
                type: "money",
                nullable: false,
                oldClrType: typeof(decimal));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "LaborPrice",
                table: "Activities",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "money");
        }
    }
}
