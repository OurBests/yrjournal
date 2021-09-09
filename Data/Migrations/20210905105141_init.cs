using Microsoft.EntityFrameworkCore.Migrations;

namespace yrjournal.Data.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Journal",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    PairName = table.Column<string>(type: "TEXT", nullable: true),
                    Quantity = table.Column<string>(type: "TEXT", nullable: true),
                    Type = table.Column<string>(type: "TEXT", nullable: true),
                    PL = table.Column<string>(type: "TEXT", nullable: true),
                    SignalTimeFrame = table.Column<string>(type: "TEXT", nullable: true),
                    MainSignal = table.Column<string>(type: "TEXT", nullable: true),
                    ConfirmationSignal = table.Column<string>(type: "TEXT", nullable: true),
                    EntryTimeFrame = table.Column<string>(type: "TEXT", nullable: true),
                    EntryPhase = table.Column<string>(type: "TEXT", nullable: true),
                    RR = table.Column<string>(type: "TEXT", nullable: true),
                    MoneyPercent = table.Column<string>(type: "TEXT", nullable: true),
                    RiskFree = table.Column<string>(type: "TEXT", nullable: true),
                    TrendFollowing = table.Column<string>(type: "TEXT", nullable: true),
                    Description = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Journal", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Journal");
        }
    }
}
