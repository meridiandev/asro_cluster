using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace asro_api.Migrations
{
    public partial class InitialDatabaseMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "thReports_1",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TeatcherFullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EventForm = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EventLevel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EventData = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EventFullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EventHours = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EventDocument = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EventWho = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EventNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReportTimeAddIs = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsLockReport = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_thReports_1", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "thReports_1");
        }
    }
}
