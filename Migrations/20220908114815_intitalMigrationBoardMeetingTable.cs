using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PUCARS.API.Migrations
{
    public partial class intitalMigrationBoardMeetingTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "boardMeetings",
                columns: table => new
                {
                    BoardMeetingId = table.Column<uint>(type: "int unsigned", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    HeldDate = table.Column<DateOnly>(type: "date", nullable: false),
                    HeldTime = table.Column<TimeOnly>(type: "time(6)", nullable: false),
                    HeldPalce = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PeriodEnded = table.Column<DateOnly>(type: "date", nullable: false),
                    ClosedForm = table.Column<DateOnly>(type: "date", nullable: false),
                    ClosedTo = table.Column<DateOnly>(type: "date", nullable: false),
                    AccountsEnded = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_boardMeetings", x => x.BoardMeetingId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "boardMeetings");
        }
    }
}
