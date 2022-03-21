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
                values: new object[] { 1, new DateTime(2022, 3, 21, 11, 58, 2, 632, DateTimeKind.Local).AddTicks(7110), "Trae Young", "/Photos/nba_anonymous.jpg", "Hawks", null });

            migrationBuilder.InsertData(
                table: "Player",
                columns: new[] { "PlayerId", "Joined", "Name", "PhotoPath", "Team", "TeamId" },
                values: new object[] { 2, new DateTime(2022, 3, 21, 11, 58, 2, 633, DateTimeKind.Local).AddTicks(80), "Jayson Tatum", "/Photos/nba_anonymous.jpg", "Celtics", null });

            migrationBuilder.InsertData(
                table: "Player",
                columns: new[] { "PlayerId", "Joined", "Name", "PhotoPath", "Team", "TeamId" },
                values: new object[] { 3, new DateTime(2022, 3, 21, 11, 58, 2, 633, DateTimeKind.Local).AddTicks(720), "Kevin Durant", "/Photos/nba_anonymous.jpg", "Nets", null });

            migrationBuilder.InsertData(
                table: "Player",
                columns: new[] { "PlayerId", "Joined", "Name", "PhotoPath", "Team", "TeamId" },
                values: new object[] { 4, new DateTime(2022, 3, 21, 11, 58, 2, 633, DateTimeKind.Local).AddTicks(830), "Stephen Curry", "/Photos/nba_anonymous.jpg", "Warriors", null });

            migrationBuilder.InsertData(
                table: "Player",
                columns: new[] { "PlayerId", "Joined", "Name", "PhotoPath", "Team", "TeamId" },
                values: new object[] { 5, new DateTime(2022, 3, 21, 11, 58, 2, 633, DateTimeKind.Local).AddTicks(850), "Zach LaVine", "/Photos/nba_anonymous.jpg", "Bulls", null });

            migrationBuilder.InsertData(
                table: "Player",
                columns: new[] { "PlayerId", "Joined", "Name", "PhotoPath", "Team", "TeamId" },
                values: new object[] { 6, new DateTime(2022, 3, 21, 11, 58, 2, 633, DateTimeKind.Local).AddTicks(860), "LeBron James", "/Photos/nba_anonymous.jpg", "Lakers", null });

            migrationBuilder.InsertData(
                table: "Player",
                columns: new[] { "PlayerId", "Joined", "Name", "PhotoPath", "Team", "TeamId" },
                values: new object[] { 7, new DateTime(2022, 3, 21, 11, 58, 2, 633, DateTimeKind.Local).AddTicks(870), "Anthony Davis", "/Photos/nba_anonymous.jpg", "Lakers", null });

            migrationBuilder.InsertData(
                table: "Player",
                columns: new[] { "PlayerId", "Joined", "Name", "PhotoPath", "Team", "TeamId" },
                values: new object[] { 8, new DateTime(2022, 3, 21, 11, 58, 2, 633, DateTimeKind.Local).AddTicks(890), "Julius Randle", "/Photos/nba_anonymous.jpg", "Knicks", null });

            migrationBuilder.InsertData(
                table: "Team",
                columns: new[] { "TeamId", "Arena", "City", "DateFounded", "Name", "PhotoPath" },
                values: new object[] { 18, null, "Minnesota", new DateTime(2022, 3, 21, 11, 58, 2, 630, DateTimeKind.Local).AddTicks(780), "Timberwolves", "/Photos/nba_anonymous.jpg" });

            migrationBuilder.InsertData(
                table: "Team",
                columns: new[] { "TeamId", "Arena", "City", "DateFounded", "Name", "PhotoPath" },
                values: new object[] { 19, null, "New Orleans", new DateTime(2022, 3, 21, 11, 58, 2, 630, DateTimeKind.Local).AddTicks(790), "Pelicans", "/Photos/nba_anonymous.jpg" });

            migrationBuilder.InsertData(
                table: "Team",
                columns: new[] { "TeamId", "Arena", "City", "DateFounded", "Name", "PhotoPath" },
                values: new object[] { 20, null, "New York", new DateTime(2022, 3, 21, 11, 58, 2, 630, DateTimeKind.Local).AddTicks(800), "Knicks", "/Photos/nba_anonymous.jpg" });

            migrationBuilder.InsertData(
                table: "Team",
                columns: new[] { "TeamId", "Arena", "City", "DateFounded", "Name", "PhotoPath" },
                values: new object[] { 21, null, "Oklahoma City", new DateTime(2022, 3, 21, 11, 58, 2, 630, DateTimeKind.Local).AddTicks(810), "Thunder", "/Photos/nba_anonymous.jpg" });

            migrationBuilder.InsertData(
                table: "Team",
                columns: new[] { "TeamId", "Arena", "City", "DateFounded", "Name", "PhotoPath" },
                values: new object[] { 22, null, "Orlando", new DateTime(2022, 3, 21, 11, 58, 2, 630, DateTimeKind.Local).AddTicks(820), "Magic", "/Photos/nba_anonymous.jpg" });

            migrationBuilder.InsertData(
                table: "Team",
                columns: new[] { "TeamId", "Arena", "City", "DateFounded", "Name", "PhotoPath" },
                values: new object[] { 23, null, "Philadelphia", new DateTime(2022, 3, 21, 11, 58, 2, 630, DateTimeKind.Local).AddTicks(840), "76ers", "/Photos/nba_anonymous.jpg" });

            migrationBuilder.InsertData(
                table: "Team",
                columns: new[] { "TeamId", "Arena", "City", "DateFounded", "Name", "PhotoPath" },
                values: new object[] { 27, null, "San Antonio", new DateTime(2022, 3, 21, 11, 58, 2, 630, DateTimeKind.Local).AddTicks(2510), "Spurs", "/Photos/nba_anonymous.jpg" });

            migrationBuilder.InsertData(
                table: "Team",
                columns: new[] { "TeamId", "Arena", "City", "DateFounded", "Name", "PhotoPath" },
                values: new object[] { 25, null, "Portland", new DateTime(2022, 3, 21, 11, 58, 2, 630, DateTimeKind.Local).AddTicks(2480), "Trail Blazers", "/Photos/nba_anonymous.jpg" });

            migrationBuilder.InsertData(
                table: "Team",
                columns: new[] { "TeamId", "Arena", "City", "DateFounded", "Name", "PhotoPath" },
                values: new object[] { 26, null, "Sacramento", new DateTime(2022, 3, 21, 11, 58, 2, 630, DateTimeKind.Local).AddTicks(2500), "Kings", "/Photos/nba_anonymous.jpg" });

            migrationBuilder.InsertData(
                table: "Team",
                columns: new[] { "TeamId", "Arena", "City", "DateFounded", "Name", "PhotoPath" },
                values: new object[] { 17, null, "Milwaukee", new DateTime(2022, 3, 21, 11, 58, 2, 630, DateTimeKind.Local).AddTicks(770), "Bucks", "/Photos/nba_anonymous.jpg" });

            migrationBuilder.InsertData(
                table: "Team",
                columns: new[] { "TeamId", "Arena", "City", "DateFounded", "Name", "PhotoPath" },
                values: new object[] { 28, null, "Toronto", new DateTime(2022, 3, 21, 11, 58, 2, 630, DateTimeKind.Local).AddTicks(2520), "Raptos", "/Photos/nba_anonymous.jpg" });

            migrationBuilder.InsertData(
                table: "Team",
                columns: new[] { "TeamId", "Arena", "City", "DateFounded", "Name", "PhotoPath" },
                values: new object[] { 29, null, "Utah", new DateTime(2022, 3, 21, 11, 58, 2, 630, DateTimeKind.Local).AddTicks(2540), "Jazz", "/Photos/nba_anonymous.jpg" });

            migrationBuilder.InsertData(
                table: "Team",
                columns: new[] { "TeamId", "Arena", "City", "DateFounded", "Name", "PhotoPath" },
                values: new object[] { 30, null, "Washington", new DateTime(2022, 3, 21, 11, 58, 2, 630, DateTimeKind.Local).AddTicks(2550), "Wizards", "/Photos/nba_anonymous.jpg" });

            migrationBuilder.InsertData(
                table: "Team",
                columns: new[] { "TeamId", "Arena", "City", "DateFounded", "Name", "PhotoPath" },
                values: new object[] { 24, null, "Phoenix", new DateTime(2022, 3, 21, 11, 58, 2, 630, DateTimeKind.Local).AddTicks(850), "Suns", "/Photos/nba_anonymous.jpg" });

            migrationBuilder.InsertData(
                table: "Team",
                columns: new[] { "TeamId", "Arena", "City", "DateFounded", "Name", "PhotoPath" },
                values: new object[] { 16, null, "Miami", new DateTime(2022, 3, 21, 11, 58, 2, 630, DateTimeKind.Local).AddTicks(750), "Heat", "/Photos/nba_anonymous.jpg" });

            migrationBuilder.InsertData(
                table: "Team",
                columns: new[] { "TeamId", "Arena", "City", "DateFounded", "Name", "PhotoPath" },
                values: new object[] { 12, null, "Indiana", new DateTime(2022, 3, 21, 11, 58, 2, 630, DateTimeKind.Local).AddTicks(690), "Pacers", "/Photos/nba_anonymous.jpg" });

            migrationBuilder.InsertData(
                table: "Team",
                columns: new[] { "TeamId", "Arena", "City", "DateFounded", "Name", "PhotoPath" },
                values: new object[] { 14, null, "Los Angeles", new DateTime(2022, 3, 21, 11, 58, 2, 630, DateTimeKind.Local).AddTicks(730), "Lakers", "/Photos/nba_anonymous.jpg" });

            migrationBuilder.InsertData(
                table: "Team",
                columns: new[] { "TeamId", "Arena", "City", "DateFounded", "Name", "PhotoPath" },
                values: new object[] { 13, null, "Los Angeles", new DateTime(2022, 3, 21, 11, 58, 2, 630, DateTimeKind.Local).AddTicks(700), "Clippers", "/Photos/nba_anonymous.jpg" });

            migrationBuilder.InsertData(
                table: "Team",
                columns: new[] { "TeamId", "Arena", "City", "DateFounded", "Name", "PhotoPath" },
                values: new object[] { 11, null, "Houston", new DateTime(2022, 3, 21, 11, 58, 2, 630, DateTimeKind.Local).AddTicks(670), "Rockets", "/Photos/nba_anonymous.jpg" });

            migrationBuilder.InsertData(
                table: "Team",
                columns: new[] { "TeamId", "Arena", "City", "DateFounded", "Name", "PhotoPath" },
                values: new object[] { 10, null, "Golden State", new DateTime(2022, 3, 21, 11, 58, 2, 630, DateTimeKind.Local).AddTicks(660), "Warriors", "/Photos/nba_anonymous.jpg" });

            migrationBuilder.InsertData(
                table: "Team",
                columns: new[] { "TeamId", "Arena", "City", "DateFounded", "Name", "PhotoPath" },
                values: new object[] { 9, null, "Detroit", new DateTime(2022, 3, 21, 11, 58, 2, 630, DateTimeKind.Local).AddTicks(650), "Pistons", "/Photos/nba_anonymous.jpg" });

            migrationBuilder.InsertData(
                table: "Team",
                columns: new[] { "TeamId", "Arena", "City", "DateFounded", "Name", "PhotoPath" },
                values: new object[] { 8, null, "Denver", new DateTime(2022, 3, 21, 11, 58, 2, 630, DateTimeKind.Local).AddTicks(640), "Nuggets", "/Photos/nba_anonymous.jpg" });

            migrationBuilder.InsertData(
                table: "Team",
                columns: new[] { "TeamId", "Arena", "City", "DateFounded", "Name", "PhotoPath" },
                values: new object[] { 7, null, "Dallas", new DateTime(2022, 3, 21, 11, 58, 2, 630, DateTimeKind.Local).AddTicks(620), "Mavericks", "/Photos/nba_anonymous.jpg" });

            migrationBuilder.InsertData(
                table: "Team",
                columns: new[] { "TeamId", "Arena", "City", "DateFounded", "Name", "PhotoPath" },
                values: new object[] { 6, null, "Cleveland", new DateTime(2022, 3, 21, 11, 58, 2, 630, DateTimeKind.Local).AddTicks(610), "Cavaliers", "/Photos/nba_anonymous.jpg" });

            migrationBuilder.InsertData(
                table: "Team",
                columns: new[] { "TeamId", "Arena", "City", "DateFounded", "Name", "PhotoPath" },
                values: new object[] { 5, null, "Chicago", new DateTime(2022, 3, 21, 11, 58, 2, 630, DateTimeKind.Local).AddTicks(590), "Bulls", "/Photos/nba_anonymous.jpg" });

            migrationBuilder.InsertData(
                table: "Team",
                columns: new[] { "TeamId", "Arena", "City", "DateFounded", "Name", "PhotoPath" },
                values: new object[] { 4, null, "Charlotte", new DateTime(2022, 3, 21, 11, 58, 2, 629, DateTimeKind.Local).AddTicks(8990), "Hornets", "/Photos/nba_anonymous.jpg" });

            migrationBuilder.InsertData(
                table: "Team",
                columns: new[] { "TeamId", "Arena", "City", "DateFounded", "Name", "PhotoPath" },
                values: new object[] { 3, null, "Brooklyn", new DateTime(2022, 3, 21, 11, 58, 2, 629, DateTimeKind.Local).AddTicks(8880), "Nets", "/Photos/nba_anonymous.jpg" });

            migrationBuilder.InsertData(
                table: "Team",
                columns: new[] { "TeamId", "Arena", "City", "DateFounded", "Name", "PhotoPath" },
                values: new object[] { 2, null, "Boston", new DateTime(2022, 3, 21, 11, 58, 2, 629, DateTimeKind.Local).AddTicks(7330), "Celtics", "/Photos/nba_anonymous.jpg" });

            migrationBuilder.InsertData(
                table: "Team",
                columns: new[] { "TeamId", "Arena", "City", "DateFounded", "Name", "PhotoPath" },
                values: new object[] { 1, null, "Atlanta", new DateTime(2022, 3, 21, 11, 58, 2, 600, DateTimeKind.Local).AddTicks(110), "Hawks", "/Photos/nba_anonymous.jpg" });

            migrationBuilder.InsertData(
                table: "Team",
                columns: new[] { "TeamId", "Arena", "City", "DateFounded", "Name", "PhotoPath" },
                values: new object[] { 15, null, "Memphis", new DateTime(2022, 3, 21, 11, 58, 2, 630, DateTimeKind.Local).AddTicks(740), "Grizzlies", "/Photos/nba_anonymous.jpg" });

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
