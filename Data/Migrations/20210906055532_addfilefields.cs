using Microsoft.EntityFrameworkCore.Migrations;

namespace yrjournal.Data.Migrations
{
    public partial class addfilefields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "File",
                table: "Journal",
                type: "TEXT",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "File",
                table: "Journal");
        }
    }
}
