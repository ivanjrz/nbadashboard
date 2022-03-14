using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Team",
                columns: table => new
                {
                    TeamId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    City = table.Column<string>(type: "TEXT", nullable: true),
                    Arena = table.Column<string>(type: "TEXT", nullable: true),
                    DateFounded = table.Column<DateTime>(type: "TEXT", nullable: false),
                    PhotoPath = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Team", x => x.TeamId);
                });

            migrationBuilder.CreateTable(
                name: "Player",
                columns: table => new
                {
                    PlayerId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Team = table.Column<string>(type: "TEXT", nullable: true),
                    Joined = table.Column<DateTime>(type: "TEXT", nullable: false),
                    PhotoPath = table.Column<string>(type: "TEXT", nullable: true),
                    TeamId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Player", x => x.PlayerId);
                    table.ForeignKey(
                        name: "FK_Player_Team_TeamId",
                        column: x => x.TeamId,
                        principalTable: "Team",
                        principalColumn: "TeamId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TeamHistory",
                columns: table => new
                {
                    TeamHistoryId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Team = table.Column<string>(type: "TEXT", nullable: true),
                    Season = table.Column<string>(type: "TEXT", nullable: true),
                    WinRecord = table.Column<int>(type: "INTEGER", nullable: false),
                    LossRecord = table.Column<int>(type: "INTEGER", nullable: false),
                    MOV = table.Column<double>(type: "REAL", nullable: false),
                    SOS = table.Column<double>(type: "REAL", nullable: false),
                    ORTg = table.Column<double>(type: "REAL", nullable: false),
                    DRTg = table.Column<double>(type: "REAL", nullable: false),
                    NRTg = table.Column<double>(type: "REAL", nullable: false),
                    FTr = table.Column<double>(type: "REAL", nullable: false),
                    ThreePAr = table.Column<double>(type: "REAL", nullable: false),
                    OEFGPct = table.Column<double>(type: "REAL", nullable: false),
                    DEFGPct = table.Column<double>(type: "REAL", nullable: false),
                    ORB = table.Column<double>(type: "REAL", nullable: false),
                    DRB = table.Column<double>(type: "REAL", nullable: false),
                    TeamId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeamHistory", x => x.TeamHistoryId);
                    table.ForeignKey(
                        name: "FK_TeamHistory_Team_TeamId",
                        column: x => x.TeamId,
                        principalTable: "Team",
                        principalColumn: "TeamId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Player",
                columns: new[] { "PlayerId", "Joined", "Name", "PhotoPath", "Team", "TeamId" },
                values: new object[] { 1, new DateTime(2022, 3, 13, 18, 4, 12, 915, DateTimeKind.Local).AddTicks(3700), "Trae Young", "/Photos/nba_anonymous.jpg", "Hawks", null });

            migrationBuilder.InsertData(
                table: "Player",
                columns: new[] { "PlayerId", "Joined", "Name", "PhotoPath", "Team", "TeamId" },
                values: new object[] { 2, new DateTime(2022, 3, 13, 18, 4, 12, 915, DateTimeKind.Local).AddTicks(6100), "Jayson Tatum", "/Photos/nba_anonymous.jpg", "Celtics", null });

            migrationBuilder.InsertData(
                table: "Player",
                columns: new[] { "PlayerId", "Joined", "Name", "PhotoPath", "Team", "TeamId" },
                values: new object[] { 3, new DateTime(2022, 3, 13, 18, 4, 12, 915, DateTimeKind.Local).AddTicks(6710), "Kevin Durant", "/Photos/nba_anonymous.jpg", "Nets", null });

            migrationBuilder.InsertData(
                table: "Player",
                columns: new[] { "PlayerId", "Joined", "Name", "PhotoPath", "Team", "TeamId" },
                values: new object[] { 4, new DateTime(2022, 3, 13, 18, 4, 12, 915, DateTimeKind.Local).AddTicks(6780), "Stephen Curry", "/Photos/nba_anonymous.jpg", "Warriors", null });

            migrationBuilder.InsertData(
                table: "Player",
                columns: new[] { "PlayerId", "Joined", "Name", "PhotoPath", "Team", "TeamId" },
                values: new object[] { 5, new DateTime(2022, 3, 13, 18, 4, 12, 915, DateTimeKind.Local).AddTicks(6800), "Zach LaVine", "/Photos/nba_anonymous.jpg", "Bulls", null });

            migrationBuilder.InsertData(
                table: "Player",
                columns: new[] { "PlayerId", "Joined", "Name", "PhotoPath", "Team", "TeamId" },
                values: new object[] { 6, new DateTime(2022, 3, 13, 18, 4, 12, 915, DateTimeKind.Local).AddTicks(6810), "LeBron James", "/Photos/nba_anonymous.jpg", "Lakers", null });

            migrationBuilder.InsertData(
                table: "Player",
                columns: new[] { "PlayerId", "Joined", "Name", "PhotoPath", "Team", "TeamId" },
                values: new object[] { 7, new DateTime(2022, 3, 13, 18, 4, 12, 915, DateTimeKind.Local).AddTicks(6820), "Julius Randle", "/Photos/nba_anonymous.jpg", "Knicks", null });

            migrationBuilder.InsertData(
                table: "Team",
                columns: new[] { "TeamId", "Arena", "City", "DateFounded", "Name", "PhotoPath" },
                values: new object[] { 1, null, "Atlanta", new DateTime(2022, 3, 13, 18, 4, 12, 888, DateTimeKind.Local).AddTicks(160), "Hawks", "/Photos/nba_anonymous.jpg" });

            migrationBuilder.InsertData(
                table: "Team",
                columns: new[] { "TeamId", "Arena", "City", "DateFounded", "Name", "PhotoPath" },
                values: new object[] { 2, null, "Boston", new DateTime(2022, 3, 13, 18, 4, 12, 913, DateTimeKind.Local).AddTicks(1750), "Celtics", "/Photos/nba_anonymous.jpg" });

            migrationBuilder.InsertData(
                table: "Team",
                columns: new[] { "TeamId", "Arena", "City", "DateFounded", "Name", "PhotoPath" },
                values: new object[] { 3, null, "Brooklyn", new DateTime(2022, 3, 13, 18, 4, 12, 913, DateTimeKind.Local).AddTicks(2880), "Nets", "/Photos/nba_anonymous.jpg" });

            migrationBuilder.InsertData(
                table: "Team",
                columns: new[] { "TeamId", "Arena", "City", "DateFounded", "Name", "PhotoPath" },
                values: new object[] { 4, null, "Golden State", new DateTime(2022, 3, 13, 18, 4, 12, 913, DateTimeKind.Local).AddTicks(2950), "Warriors", "/Photos/nba_anonymous.jpg" });

            migrationBuilder.InsertData(
                table: "Team",
                columns: new[] { "TeamId", "Arena", "City", "DateFounded", "Name", "PhotoPath" },
                values: new object[] { 5, null, "Chicago", new DateTime(2022, 3, 13, 18, 4, 12, 913, DateTimeKind.Local).AddTicks(2970), "Bulls", "/Photos/nba_anonymous.jpg" });

            migrationBuilder.InsertData(
                table: "Team",
                columns: new[] { "TeamId", "Arena", "City", "DateFounded", "Name", "PhotoPath" },
                values: new object[] { 6, null, "Los Angeles", new DateTime(2022, 3, 13, 18, 4, 12, 913, DateTimeKind.Local).AddTicks(2980), "Lakers", "/Photos/nba_anonymous.jpg" });

            migrationBuilder.InsertData(
                table: "Team",
                columns: new[] { "TeamId", "Arena", "City", "DateFounded", "Name", "PhotoPath" },
                values: new object[] { 7, null, "New York", new DateTime(2022, 3, 13, 18, 4, 12, 913, DateTimeKind.Local).AddTicks(3000), "Knicks", "/Photos/nba_anonymous.jpg" });

            migrationBuilder.InsertData(
                table: "TeamHistory",
                columns: new[] { "TeamHistoryId", "DEFGPct", "DRB", "DRTg", "FTr", "LossRecord", "MOV", "NRTg", "OEFGPct", "ORB", "ORTg", "SOS", "Season", "Team", "TeamId", "ThreePAr", "WinRecord" },
                values: new object[] { 1, 0.51500000000000001, 78.799999999999997, 106.3, 0.27600000000000002, 19, 5.79, 0.0, 0.54200000000000004, 24.5, 112.0, 0.48999999999999999, "2019-2020", "Lakers", null, 0.35799999999999998, 52 });

            migrationBuilder.InsertData(
                table: "TeamHistory",
                columns: new[] { "TeamHistoryId", "DEFGPct", "DRB", "DRTg", "FTr", "LossRecord", "MOV", "NRTg", "OEFGPct", "ORB", "ORTg", "SOS", "Season", "Team", "TeamId", "ThreePAr", "WinRecord" },
                values: new object[] { 2, 0.52300000000000002, 79.5, 109.5, 0.29899999999999999, 29, 2.9500000000000002, 0.0, 0.54700000000000004, 20.300000000000001, 112.5, 0.34999999999999998, "2019-2020", "Heat", null, 0.41899999999999998, 44 });

            migrationBuilder.CreateIndex(
                name: "IX_Player_TeamId",
                table: "Player",
                column: "TeamId");

            migrationBuilder.CreateIndex(
                name: "IX_TeamHistory_TeamId",
                table: "TeamHistory",
                column: "TeamId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Player");

            migrationBuilder.DropTable(
                name: "TeamHistory");

            migrationBuilder.DropTable(
                name: "Team");
        }
    }
}
