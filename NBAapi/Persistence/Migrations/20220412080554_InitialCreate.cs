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
                values: new object[] { 1, new DateTime(2022, 4, 12, 1, 5, 53, 166, DateTimeKind.Local).AddTicks(5220), "Trae Young", "/Photos/nba_anonymous.jpg", "Hawks", null });

            migrationBuilder.InsertData(
                table: "Player",
                columns: new[] { "PlayerId", "Joined", "Name", "PhotoPath", "Team", "TeamId" },
                values: new object[] { 2, new DateTime(2022, 4, 12, 1, 5, 53, 166, DateTimeKind.Local).AddTicks(8270), "Jayson Tatum", "/Photos/nba_anonymous.jpg", "Celtics", null });

            migrationBuilder.InsertData(
                table: "Player",
                columns: new[] { "PlayerId", "Joined", "Name", "PhotoPath", "Team", "TeamId" },
                values: new object[] { 3, new DateTime(2022, 4, 12, 1, 5, 53, 166, DateTimeKind.Local).AddTicks(8860), "Kevin Durant", "/Photos/nba_anonymous.jpg", "Nets", null });

            migrationBuilder.InsertData(
                table: "Player",
                columns: new[] { "PlayerId", "Joined", "Name", "PhotoPath", "Team", "TeamId" },
                values: new object[] { 4, new DateTime(2022, 4, 12, 1, 5, 53, 166, DateTimeKind.Local).AddTicks(8930), "Stephen Curry", "/Photos/nba_anonymous.jpg", "Warriors", null });

            migrationBuilder.InsertData(
                table: "Player",
                columns: new[] { "PlayerId", "Joined", "Name", "PhotoPath", "Team", "TeamId" },
                values: new object[] { 5, new DateTime(2022, 4, 12, 1, 5, 53, 166, DateTimeKind.Local).AddTicks(8950), "Zach LaVine", "/Photos/nba_anonymous.jpg", "Bulls", null });

            migrationBuilder.InsertData(
                table: "Player",
                columns: new[] { "PlayerId", "Joined", "Name", "PhotoPath", "Team", "TeamId" },
                values: new object[] { 6, new DateTime(2022, 4, 12, 1, 5, 53, 166, DateTimeKind.Local).AddTicks(8960), "LeBron James", "/Photos/nba_anonymous.jpg", "Lakers", null });

            migrationBuilder.InsertData(
                table: "Player",
                columns: new[] { "PlayerId", "Joined", "Name", "PhotoPath", "Team", "TeamId" },
                values: new object[] { 7, new DateTime(2022, 4, 12, 1, 5, 53, 166, DateTimeKind.Local).AddTicks(8970), "Anthony Davis", "/Photos/nba_anonymous.jpg", "Lakers", null });

            migrationBuilder.InsertData(
                table: "Player",
                columns: new[] { "PlayerId", "Joined", "Name", "PhotoPath", "Team", "TeamId" },
                values: new object[] { 8, new DateTime(2022, 4, 12, 1, 5, 53, 166, DateTimeKind.Local).AddTicks(8990), "Julius Randle", "/Photos/nba_anonymous.jpg", "Knicks", null });

            migrationBuilder.InsertData(
                table: "Team",
                columns: new[] { "TeamId", "Arena", "City", "DateFounded", "Name", "PhotoPath" },
                values: new object[] { 18, null, "Minnesota", new DateTime(2022, 4, 12, 1, 5, 53, 164, DateTimeKind.Local).AddTicks(4870), "Timberwolves", "/Photos/nba_anonymous.jpg" });

            migrationBuilder.InsertData(
                table: "Team",
                columns: new[] { "TeamId", "Arena", "City", "DateFounded", "Name", "PhotoPath" },
                values: new object[] { 19, null, "New Orleans", new DateTime(2022, 4, 12, 1, 5, 53, 164, DateTimeKind.Local).AddTicks(4880), "Pelicans", "/Photos/nba_anonymous.jpg" });

            migrationBuilder.InsertData(
                table: "Team",
                columns: new[] { "TeamId", "Arena", "City", "DateFounded", "Name", "PhotoPath" },
                values: new object[] { 20, null, "New York", new DateTime(2022, 4, 12, 1, 5, 53, 164, DateTimeKind.Local).AddTicks(4890), "Knicks", "/Photos/nba_anonymous.jpg" });

            migrationBuilder.InsertData(
                table: "Team",
                columns: new[] { "TeamId", "Arena", "City", "DateFounded", "Name", "PhotoPath" },
                values: new object[] { 21, null, "Oklahoma City", new DateTime(2022, 4, 12, 1, 5, 53, 164, DateTimeKind.Local).AddTicks(4900), "Thunder", "/Photos/nba_anonymous.jpg" });

            migrationBuilder.InsertData(
                table: "Team",
                columns: new[] { "TeamId", "Arena", "City", "DateFounded", "Name", "PhotoPath" },
                values: new object[] { 23, null, "Philadelphia", new DateTime(2022, 4, 12, 1, 5, 53, 164, DateTimeKind.Local).AddTicks(4930), "76ers", "/Photos/nba_anonymous.jpg" });

            migrationBuilder.InsertData(
                table: "Team",
                columns: new[] { "TeamId", "Arena", "City", "DateFounded", "Name", "PhotoPath" },
                values: new object[] { 24, null, "Phoenix", new DateTime(2022, 4, 12, 1, 5, 53, 164, DateTimeKind.Local).AddTicks(4940), "Suns", "/Photos/nba_anonymous.jpg" });

            migrationBuilder.InsertData(
                table: "Team",
                columns: new[] { "TeamId", "Arena", "City", "DateFounded", "Name", "PhotoPath" },
                values: new object[] { 28, null, "Toronto", new DateTime(2022, 4, 12, 1, 5, 53, 164, DateTimeKind.Local).AddTicks(4990), "Raptos", "/Photos/nba_anonymous.jpg" });

            migrationBuilder.InsertData(
                table: "Team",
                columns: new[] { "TeamId", "Arena", "City", "DateFounded", "Name", "PhotoPath" },
                values: new object[] { 26, null, "Sacramento", new DateTime(2022, 4, 12, 1, 5, 53, 164, DateTimeKind.Local).AddTicks(4960), "Kings", "/Photos/nba_anonymous.jpg" });

            migrationBuilder.InsertData(
                table: "Team",
                columns: new[] { "TeamId", "Arena", "City", "DateFounded", "Name", "PhotoPath" },
                values: new object[] { 27, null, "San Antonio", new DateTime(2022, 4, 12, 1, 5, 53, 164, DateTimeKind.Local).AddTicks(4970), "Spurs", "/Photos/nba_anonymous.jpg" });

            migrationBuilder.InsertData(
                table: "Team",
                columns: new[] { "TeamId", "Arena", "City", "DateFounded", "Name", "PhotoPath" },
                values: new object[] { 17, null, "Milwaukee", new DateTime(2022, 4, 12, 1, 5, 53, 164, DateTimeKind.Local).AddTicks(4860), "Bucks", "/Photos/nba_anonymous.jpg" });

            migrationBuilder.InsertData(
                table: "Team",
                columns: new[] { "TeamId", "Arena", "City", "DateFounded", "Name", "PhotoPath" },
                values: new object[] { 29, null, "Utah", new DateTime(2022, 4, 12, 1, 5, 53, 164, DateTimeKind.Local).AddTicks(5000), "Jazz", "/Photos/nba_anonymous.jpg" });

            migrationBuilder.InsertData(
                table: "Team",
                columns: new[] { "TeamId", "Arena", "City", "DateFounded", "Name", "PhotoPath" },
                values: new object[] { 30, null, "Washington", new DateTime(2022, 4, 12, 1, 5, 53, 164, DateTimeKind.Local).AddTicks(5010), "Wizards", "/Photos/nba_anonymous.jpg" });

            migrationBuilder.InsertData(
                table: "Team",
                columns: new[] { "TeamId", "Arena", "City", "DateFounded", "Name", "PhotoPath" },
                values: new object[] { 25, null, "Portland", new DateTime(2022, 4, 12, 1, 5, 53, 164, DateTimeKind.Local).AddTicks(4950), "Trail Blazers", "/Photos/nba_anonymous.jpg" });

            migrationBuilder.InsertData(
                table: "Team",
                columns: new[] { "TeamId", "Arena", "City", "DateFounded", "Name", "PhotoPath" },
                values: new object[] { 16, null, "Miami", new DateTime(2022, 4, 12, 1, 5, 53, 164, DateTimeKind.Local).AddTicks(4840), "Heat", "/Photos/nba_anonymous.jpg" });

            migrationBuilder.InsertData(
                table: "Team",
                columns: new[] { "TeamId", "Arena", "City", "DateFounded", "Name", "PhotoPath" },
                values: new object[] { 22, null, "Orlando", new DateTime(2022, 4, 12, 1, 5, 53, 164, DateTimeKind.Local).AddTicks(4920), "Magic", "/Photos/nba_anonymous.jpg" });

            migrationBuilder.InsertData(
                table: "Team",
                columns: new[] { "TeamId", "Arena", "City", "DateFounded", "Name", "PhotoPath" },
                values: new object[] { 14, null, "Los Angeles", new DateTime(2022, 4, 12, 1, 5, 53, 164, DateTimeKind.Local).AddTicks(4820), "Lakers", "/Photos/nba_anonymous.jpg" });

            migrationBuilder.InsertData(
                table: "Team",
                columns: new[] { "TeamId", "Arena", "City", "DateFounded", "Name", "PhotoPath" },
                values: new object[] { 15, null, "Memphis", new DateTime(2022, 4, 12, 1, 5, 53, 164, DateTimeKind.Local).AddTicks(4830), "Grizzlies", "/Photos/nba_anonymous.jpg" });

            migrationBuilder.InsertData(
                table: "Team",
                columns: new[] { "TeamId", "Arena", "City", "DateFounded", "Name", "PhotoPath" },
                values: new object[] { 1, null, "Atlanta", new DateTime(2022, 4, 12, 1, 5, 53, 143, DateTimeKind.Local).AddTicks(5190), "Hawks", "/Photos/nba_anonymous.jpg" });

            migrationBuilder.InsertData(
                table: "Team",
                columns: new[] { "TeamId", "Arena", "City", "DateFounded", "Name", "PhotoPath" },
                values: new object[] { 2, null, "Boston", new DateTime(2022, 4, 12, 1, 5, 53, 164, DateTimeKind.Local).AddTicks(2000), "Celtics", "/Photos/nba_anonymous.jpg" });

            migrationBuilder.InsertData(
                table: "Team",
                columns: new[] { "TeamId", "Arena", "City", "DateFounded", "Name", "PhotoPath" },
                values: new object[] { 3, null, "Brooklyn", new DateTime(2022, 4, 12, 1, 5, 53, 164, DateTimeKind.Local).AddTicks(3120), "Nets", "/Photos/nba_anonymous.jpg" });

            migrationBuilder.InsertData(
                table: "Team",
                columns: new[] { "TeamId", "Arena", "City", "DateFounded", "Name", "PhotoPath" },
                values: new object[] { 5, null, "Chicago", new DateTime(2022, 4, 12, 1, 5, 53, 164, DateTimeKind.Local).AddTicks(3220), "Bulls", "/Photos/nba_anonymous.jpg" });

            migrationBuilder.InsertData(
                table: "Team",
                columns: new[] { "TeamId", "Arena", "City", "DateFounded", "Name", "PhotoPath" },
                values: new object[] { 6, null, "Cleveland", new DateTime(2022, 4, 12, 1, 5, 53, 164, DateTimeKind.Local).AddTicks(3230), "Cavaliers", "/Photos/nba_anonymous.jpg" });

            migrationBuilder.InsertData(
                table: "Team",
                columns: new[] { "TeamId", "Arena", "City", "DateFounded", "Name", "PhotoPath" },
                values: new object[] { 7, null, "Dallas", new DateTime(2022, 4, 12, 1, 5, 53, 164, DateTimeKind.Local).AddTicks(3240), "Mavericks", "/Photos/nba_anonymous.jpg" });

            migrationBuilder.InsertData(
                table: "Team",
                columns: new[] { "TeamId", "Arena", "City", "DateFounded", "Name", "PhotoPath" },
                values: new object[] { 4, null, "Charlotte", new DateTime(2022, 4, 12, 1, 5, 53, 164, DateTimeKind.Local).AddTicks(3200), "Hornets", "/Photos/nba_anonymous.jpg" });

            migrationBuilder.InsertData(
                table: "Team",
                columns: new[] { "TeamId", "Arena", "City", "DateFounded", "Name", "PhotoPath" },
                values: new object[] { 9, null, "Detroit", new DateTime(2022, 4, 12, 1, 5, 53, 164, DateTimeKind.Local).AddTicks(3270), "Pistons", "/Photos/nba_anonymous.jpg" });

            migrationBuilder.InsertData(
                table: "Team",
                columns: new[] { "TeamId", "Arena", "City", "DateFounded", "Name", "PhotoPath" },
                values: new object[] { 10, null, "Golden State", new DateTime(2022, 4, 12, 1, 5, 53, 164, DateTimeKind.Local).AddTicks(3280), "Warriors", "/Photos/nba_anonymous.jpg" });

            migrationBuilder.InsertData(
                table: "Team",
                columns: new[] { "TeamId", "Arena", "City", "DateFounded", "Name", "PhotoPath" },
                values: new object[] { 11, null, "Houston", new DateTime(2022, 4, 12, 1, 5, 53, 164, DateTimeKind.Local).AddTicks(3300), "Rockets", "/Photos/nba_anonymous.jpg" });

            migrationBuilder.InsertData(
                table: "Team",
                columns: new[] { "TeamId", "Arena", "City", "DateFounded", "Name", "PhotoPath" },
                values: new object[] { 12, null, "Indiana", new DateTime(2022, 4, 12, 1, 5, 53, 164, DateTimeKind.Local).AddTicks(4790), "Pacers", "/Photos/nba_anonymous.jpg" });

            migrationBuilder.InsertData(
                table: "Team",
                columns: new[] { "TeamId", "Arena", "City", "DateFounded", "Name", "PhotoPath" },
                values: new object[] { 13, null, "Los Angeles", new DateTime(2022, 4, 12, 1, 5, 53, 164, DateTimeKind.Local).AddTicks(4810), "Clippers", "/Photos/nba_anonymous.jpg" });

            migrationBuilder.InsertData(
                table: "Team",
                columns: new[] { "TeamId", "Arena", "City", "DateFounded", "Name", "PhotoPath" },
                values: new object[] { 8, null, "Denver", new DateTime(2022, 4, 12, 1, 5, 53, 164, DateTimeKind.Local).AddTicks(3250), "Nuggets", "/Photos/nba_anonymous.jpg" });

            migrationBuilder.InsertData(
                table: "TeamHistory",
                columns: new[] { "TeamHistoryId", "DEFGPct", "DRB", "DRTg", "FTr", "LossRecord", "MOV", "NRTg", "OEFGPct", "ORB", "ORTg", "SOS", "Season", "Team", "TeamId", "ThreePAr", "WinRecord" },
                values: new object[] { 65, 0.52100000000000002, 0.0, 107.59999999999999, 0.29299999999999998, 23, 5.5800000000000001, 0.0, 0.54100000000000004, 23.199999999999999, 113.2, -0.31, "2020-2021", "76ers", null, 0.34699999999999998, 49 });

            migrationBuilder.InsertData(
                table: "TeamHistory",
                columns: new[] { "TeamHistoryId", "DEFGPct", "DRB", "DRTg", "FTr", "LossRecord", "MOV", "NRTg", "OEFGPct", "ORB", "ORTg", "SOS", "Season", "Team", "TeamId", "ThreePAr", "WinRecord" },
                values: new object[] { 58, 0.54300000000000004, 0.0, 114.8, 0.25800000000000001, 47, -7.9699999999999998, 0.0, 0.51500000000000001, 21.600000000000001, 107.2, 0.27000000000000002, "2019-2020", "Hawks", null, 0.39800000000000002, 20 });

            migrationBuilder.InsertData(
                table: "TeamHistory",
                columns: new[] { "TeamHistoryId", "DEFGPct", "DRB", "DRTg", "FTr", "LossRecord", "MOV", "NRTg", "OEFGPct", "ORB", "ORTg", "SOS", "Season", "Team", "TeamId", "ThreePAr", "WinRecord" },
                values: new object[] { 64, 0.53600000000000003, 0.0, 111.40000000000001, 0.23300000000000001, 26, 5.8899999999999997, 0.0, 0.56599999999999995, 23.300000000000001, 117.2, -0.32000000000000001, "2020-2021", "Bucks", null, 0.40400000000000003, 46 });

            migrationBuilder.InsertData(
                table: "TeamHistory",
                columns: new[] { "TeamHistoryId", "DEFGPct", "DRB", "DRTg", "FTr", "LossRecord", "MOV", "NRTg", "OEFGPct", "ORB", "ORTg", "SOS", "Season", "Team", "TeamId", "ThreePAr", "WinRecord" },
                values: new object[] { 63, 0.53400000000000003, 0.0, 111.3, 0.21199999999999999, 21, 5.8200000000000003, 0.0, 0.56399999999999995, 20.800000000000001, 117.2, -0.14999999999999999, "2020-2021", "Suns", null, 0.39200000000000002, 51 });

            migrationBuilder.InsertData(
                table: "TeamHistory",
                columns: new[] { "TeamHistoryId", "DEFGPct", "DRB", "DRTg", "FTr", "LossRecord", "MOV", "NRTg", "OEFGPct", "ORB", "ORTg", "SOS", "Season", "Team", "TeamId", "ThreePAr", "WinRecord" },
                values: new object[] { 62, 0.53100000000000003, 0.0, 111.2, 0.222, 25, 6.1799999999999997, 0.0, 0.56399999999999995, 22.699999999999999, 117.59999999999999, -0.16, "2020-2021", "Clippers", null, 0.40000000000000002, 47 });

            migrationBuilder.InsertData(
                table: "TeamHistory",
                columns: new[] { "TeamHistoryId", "DEFGPct", "DRB", "DRTg", "FTr", "LossRecord", "MOV", "NRTg", "OEFGPct", "ORB", "ORTg", "SOS", "Season", "Team", "TeamId", "ThreePAr", "WinRecord" },
                values: new object[] { 61, 0.50700000000000001, 0.0, 108.3, 0.24399999999999999, 20, 9.25, 0.0, 0.56299999999999994, 24.5, 117.59999999999999, -0.28999999999999998, "2020-2021", "Jazz", null, 0.48799999999999999, 52 });

            migrationBuilder.InsertData(
                table: "TeamHistory",
                columns: new[] { "TeamHistoryId", "DEFGPct", "DRB", "DRTg", "FTr", "LossRecord", "MOV", "NRTg", "OEFGPct", "ORB", "ORTg", "SOS", "Season", "Team", "TeamId", "ThreePAr", "WinRecord" },
                values: new object[] { 60, 0.55300000000000005, 0.0, 113.8, 0.26400000000000001, 50, -8.7100000000000009, 0.0, 0.497, 21.5, 105.2, 0.58999999999999997, "2019-2020", "Warriors", null, 0.35499999999999998, 15 });

            migrationBuilder.InsertData(
                table: "TeamHistory",
                columns: new[] { "TeamHistoryId", "DEFGPct", "DRB", "DRTg", "FTr", "LossRecord", "MOV", "NRTg", "OEFGPct", "ORB", "ORTg", "SOS", "Season", "Team", "TeamId", "ThreePAr", "WinRecord" },
                values: new object[] { 59, 0.56000000000000005, 0.0, 115.40000000000001, 0.22700000000000001, 46, -7.8899999999999997, 0.0, 0.52200000000000002, 24.600000000000001, 107.5, 0.12, "2019-2020", "Cavaliers", null, 0.36199999999999999, 19 });

            migrationBuilder.InsertData(
                table: "TeamHistory",
                columns: new[] { "TeamHistoryId", "DEFGPct", "DRB", "DRTg", "FTr", "LossRecord", "MOV", "NRTg", "OEFGPct", "ORB", "ORTg", "SOS", "Season", "Team", "TeamId", "ThreePAr", "WinRecord" },
                values: new object[] { 57, 0.54600000000000004, 0.0, 113.3, 0.252, 42, -6.75, 0.0, 0.504, 23.899999999999999, 106.3, -0.28000000000000003, "2019-2020", "Hornets", null, 0.39900000000000002, 23 });

            migrationBuilder.InsertData(
                table: "TeamHistory",
                columns: new[] { "TeamHistoryId", "DEFGPct", "DRB", "DRTg", "FTr", "LossRecord", "MOV", "NRTg", "OEFGPct", "ORB", "ORTg", "SOS", "Season", "Team", "TeamId", "ThreePAr", "WinRecord" },
                values: new object[] { 49, 0.53000000000000003, 0.0, 114.8, 0.24199999999999999, 39, -1.1499999999999999, 0.0, 0.53300000000000003, 22.399999999999999, 113.7, 0.54000000000000004, "2019-2020", "Trail Blazers", null, 0.374, 35 });

            migrationBuilder.InsertData(
                table: "TeamHistory",
                columns: new[] { "TeamHistoryId", "DEFGPct", "DRB", "DRTg", "FTr", "LossRecord", "MOV", "NRTg", "OEFGPct", "ORB", "ORTg", "SOS", "Season", "Team", "TeamId", "ThreePAr", "WinRecord" },
                values: new object[] { 55, 0.55800000000000005, 0.0, 115.5, 0.27000000000000002, 47, -4.6699999999999999, 0.0, 0.52300000000000002, 22.199999999999999, 110.90000000000001, -0.56999999999999995, "2019-2020", "Wizards", null, 0.35799999999999998, 25 });

            migrationBuilder.InsertData(
                table: "TeamHistory",
                columns: new[] { "TeamHistoryId", "DEFGPct", "DRB", "DRTg", "FTr", "LossRecord", "MOV", "NRTg", "OEFGPct", "ORB", "ORTg", "SOS", "Season", "Team", "TeamId", "ThreePAr", "WinRecord" },
                values: new object[] { 54, 0.54100000000000004, 0.0, 112.2, 0.27700000000000002, 45, -4.2999999999999998, 0.0, 0.51400000000000001, 22.100000000000001, 108.09999999999999, 0.28000000000000003, "2019-2020", "Timberwolves", null, 0.433, 19 });

            migrationBuilder.InsertData(
                table: "TeamHistory",
                columns: new[] { "TeamHistoryId", "DEFGPct", "DRB", "DRTg", "FTr", "LossRecord", "MOV", "NRTg", "OEFGPct", "ORB", "ORTg", "SOS", "Season", "Team", "TeamId", "ThreePAr", "WinRecord" },
                values: new object[] { 53, 0.54100000000000004, 0.0, 112.7, 0.26100000000000001, 46, -3.5600000000000001, 0.0, 0.52900000000000003, 22.600000000000001, 109.0, -0.81999999999999995, "2019-2020", "Pistons", null, 0.38100000000000001, 20 });

            migrationBuilder.InsertData(
                table: "TeamHistory",
                columns: new[] { "TeamHistoryId", "DEFGPct", "DRB", "DRTg", "FTr", "LossRecord", "MOV", "NRTg", "OEFGPct", "ORB", "ORTg", "SOS", "Season", "Team", "TeamId", "ThreePAr", "WinRecord" },
                values: new object[] { 52, 0.54600000000000004, 0.0, 109.8, 0.23100000000000001, 43, -3.0800000000000001, 0.0, 0.51500000000000001, 22.800000000000001, 106.7, -0.93000000000000005, "2019-2020", "Bulls", null, 0.39600000000000002, 22 });

            migrationBuilder.InsertData(
                table: "TeamHistory",
                columns: new[] { "TeamHistoryId", "DEFGPct", "DRB", "DRTg", "FTr", "LossRecord", "MOV", "NRTg", "OEFGPct", "ORB", "ORTg", "SOS", "Season", "Team", "TeamId", "ThreePAr", "WinRecord" },
                values: new object[] { 51, 0.54300000000000004, 0.0, 112.2, 0.23000000000000001, 41, -2.04, 0.0, 0.53400000000000003, 21.899999999999999, 110.2, 0.46000000000000002, "2019-2020", "Kings", null, 0.39500000000000002, 31 });

            migrationBuilder.InsertData(
                table: "TeamHistory",
                columns: new[] { "TeamHistoryId", "DEFGPct", "DRB", "DRTg", "FTr", "LossRecord", "MOV", "NRTg", "OEFGPct", "ORB", "ORTg", "SOS", "Season", "Team", "TeamId", "ThreePAr", "WinRecord" },
                values: new object[] { 50, 0.53200000000000003, 0.0, 111.90000000000001, 0.25600000000000001, 42, -1.29, 0.0, 0.53900000000000003, 24.199999999999999, 110.7, 0.73999999999999999, "2019-2020", "Pelicans", null, 0.40300000000000002, 30 });

            migrationBuilder.InsertData(
                table: "TeamHistory",
                columns: new[] { "TeamHistoryId", "DEFGPct", "DRB", "DRTg", "FTr", "LossRecord", "MOV", "NRTg", "OEFGPct", "ORB", "ORTg", "SOS", "Season", "Team", "TeamId", "ThreePAr", "WinRecord" },
                values: new object[] { 48, 0.52100000000000002, 0.0, 110.3, 0.23999999999999999, 39, -1.0700000000000001, 0.0, 0.52800000000000002, 23.0, 109.2, 0.16, "2019-2020", "Grizzlies", null, 0.34599999999999997, 34 });

            migrationBuilder.InsertData(
                table: "TeamHistory",
                columns: new[] { "TeamHistoryId", "DEFGPct", "DRB", "DRTg", "FTr", "LossRecord", "MOV", "NRTg", "OEFGPct", "ORB", "ORTg", "SOS", "Season", "Team", "TeamId", "ThreePAr", "WinRecord" },
                values: new object[] { 47, 0.54200000000000004, 0.0, 113.5, 0.26200000000000001, 39, -1.1100000000000001, 0.0, 0.53100000000000003, 20.100000000000001, 112.40000000000001, 0.46000000000000002, "2019-2020", "Spurs", null, 0.318, 32 });

            migrationBuilder.InsertData(
                table: "TeamHistory",
                columns: new[] { "TeamHistoryId", "DEFGPct", "DRB", "DRTg", "FTr", "LossRecord", "MOV", "NRTg", "OEFGPct", "ORB", "ORTg", "SOS", "Season", "Team", "TeamId", "ThreePAr", "WinRecord" },
                values: new object[] { 66, 0.54500000000000004, 0.0, 112.09999999999999, 0.219, 25, 4.9299999999999997, 0.0, 0.55700000000000005, 24.699999999999999, 117.09999999999999, -0.11, "2020-2021", "Nuggets", null, 0.38300000000000001, 47 });

            migrationBuilder.InsertData(
                table: "TeamHistory",
                columns: new[] { "TeamHistoryId", "DEFGPct", "DRB", "DRTg", "FTr", "LossRecord", "MOV", "NRTg", "OEFGPct", "ORB", "ORTg", "SOS", "Season", "Team", "TeamId", "ThreePAr", "WinRecord" },
                values: new object[] { 56, 0.54100000000000004, 0.0, 113.0, 0.26300000000000001, 45, -6.4500000000000002, 0.0, 0.501, 25.800000000000001, 106.5, -0.26000000000000001, "2019-2020", "Knicks", null, 0.318, 21 });

            migrationBuilder.InsertData(
                table: "TeamHistory",
                columns: new[] { "TeamHistoryId", "DEFGPct", "DRB", "DRTg", "FTr", "LossRecord", "MOV", "NRTg", "OEFGPct", "ORB", "ORTg", "SOS", "Season", "Team", "TeamId", "ThreePAr", "WinRecord" },
                values: new object[] { 67, 0.53100000000000003, 0.0, 113.8, 0.25800000000000001, 24, 4.5, 0.0, 0.57499999999999996, 21.399999999999999, 118.3, -0.27000000000000002, "2020-2021", "Nets", null, 0.41299999999999998, 48 });

            migrationBuilder.InsertData(
                table: "TeamHistory",
                columns: new[] { "TeamHistoryId", "DEFGPct", "DRB", "DRTg", "FTr", "LossRecord", "MOV", "NRTg", "OEFGPct", "ORB", "ORTg", "SOS", "Season", "Team", "TeamId", "ThreePAr", "WinRecord" },
                values: new object[] { 86, 0.55600000000000005, 0.0, 115.0, 0.254, 49, -5.5599999999999996, 0.0, 0.52000000000000002, 22.699999999999999, 109.5, 0.31, "2020-2021", "Timberwolves", null, 0.41299999999999998, 23 });

            migrationBuilder.InsertData(
                table: "TeamHistory",
                columns: new[] { "TeamHistoryId", "DEFGPct", "DRB", "DRTg", "FTr", "LossRecord", "MOV", "NRTg", "OEFGPct", "ORB", "ORTg", "SOS", "Season", "Team", "TeamId", "ThreePAr", "WinRecord" },
                values: new object[] { 69, 0.53400000000000003, 0.0, 113.0, 0.24199999999999999, 30, 2.2599999999999998, 0.0, 0.55000000000000004, 21.100000000000001, 115.40000000000001, -0.01, "2020-2021", "Mavericks", null, 0.436, 42 });

            migrationBuilder.InsertData(
                table: "TeamHistory",
                columns: new[] { "TeamHistoryId", "DEFGPct", "DRB", "DRTg", "FTr", "LossRecord", "MOV", "NRTg", "OEFGPct", "ORB", "ORTg", "SOS", "Season", "Team", "TeamId", "ThreePAr", "WinRecord" },
                values: new object[] { 88, 0.55600000000000005, 0.0, 114.40000000000001, 0.26100000000000001, 50, -8.4399999999999995, 0.0, 0.50800000000000001, 23.600000000000001, 105.8, 0.25, "2020-2021", "Cavaliers", null, 0.34699999999999998, 22 });

            migrationBuilder.InsertData(
                table: "TeamHistory",
                columns: new[] { "TeamHistoryId", "DEFGPct", "DRB", "DRTg", "FTr", "LossRecord", "MOV", "NRTg", "OEFGPct", "ORB", "ORTg", "SOS", "Season", "Team", "TeamId", "ThreePAr", "WinRecord" },
                values: new object[] { 87, 0.55500000000000005, 0.0, 114.90000000000001, 0.252, 55, -7.9000000000000004, 0.0, 0.52100000000000002, 19.800000000000001, 107.09999999999999, 0.40000000000000002, "2020-2021", "Rockets", null, 0.45900000000000002, 17 });

            migrationBuilder.InsertData(
                table: "TeamHistory",
                columns: new[] { "TeamHistoryId", "DEFGPct", "DRB", "DRTg", "FTr", "LossRecord", "MOV", "NRTg", "OEFGPct", "ORB", "ORTg", "SOS", "Season", "Team", "TeamId", "ThreePAr", "WinRecord" },
                values: new object[] { 46, 0.53500000000000003, 0.0, 109.5, 0.25600000000000001, 40, -1.01, 0.0, 0.50600000000000001, 22.300000000000001, 108.5, 0.089999999999999997, "2019-2020", "Magic", null, 0.36399999999999999, 33 });

            migrationBuilder.InsertData(
                table: "TeamHistory",
                columns: new[] { "TeamHistoryId", "DEFGPct", "DRB", "DRTg", "FTr", "LossRecord", "MOV", "NRTg", "OEFGPct", "ORB", "ORTg", "SOS", "Season", "Team", "TeamId", "ThreePAr", "WinRecord" },
                values: new object[] { 85, 0.54100000000000004, 0.0, 112.5, 0.27300000000000002, 52, -4.4699999999999998, 0.0, 0.51900000000000002, 21.899999999999999, 108.0, 0.089999999999999997, "2020-2021", "Pistons", null, 0.38500000000000001, 20 });

            migrationBuilder.InsertData(
                table: "TeamHistory",
                columns: new[] { "TeamHistoryId", "DEFGPct", "DRB", "DRTg", "FTr", "LossRecord", "MOV", "NRTg", "OEFGPct", "ORB", "ORTg", "SOS", "Season", "Team", "TeamId", "ThreePAr", "WinRecord" },
                values: new object[] { 84, 0.55700000000000005, 0.0, 117.2, 0.248, 41, -3.6800000000000002, 0.0, 0.54900000000000004, 21.300000000000001, 113.59999999999999, 0.23000000000000001, "2020-2021", "Kings", null, 0.376, 31 });

            migrationBuilder.InsertData(
                table: "TeamHistory",
                columns: new[] { "TeamHistoryId", "DEFGPct", "DRB", "DRTg", "FTr", "LossRecord", "MOV", "NRTg", "OEFGPct", "ORB", "ORTg", "SOS", "Season", "Team", "TeamId", "ThreePAr", "WinRecord" },
                values: new object[] { 83, 0.55000000000000004, 0.0, 112.8, 0.23799999999999999, 39, -1.9299999999999999, 0.0, 0.53200000000000003, 23.5, 110.90000000000001, -0.01, "2020-2021", "Hornets", null, 0.42199999999999999, 33 });

            migrationBuilder.InsertData(
                table: "TeamHistory",
                columns: new[] { "TeamHistoryId", "DEFGPct", "DRB", "DRTg", "FTr", "LossRecord", "MOV", "NRTg", "OEFGPct", "ORB", "ORTg", "SOS", "Season", "Team", "TeamId", "ThreePAr", "WinRecord" },
                values: new object[] { 82, 0.53900000000000003, 0.0, 113.0, 0.28799999999999998, 38, -1.8300000000000001, 0.0, 0.53100000000000003, 21.300000000000001, 111.2, -0.01, "2020-2021", "Wizards", null, 0.31900000000000001, 34 });

            migrationBuilder.InsertData(
                table: "TeamHistory",
                columns: new[] { "TeamHistoryId", "DEFGPct", "DRB", "DRTg", "FTr", "LossRecord", "MOV", "NRTg", "OEFGPct", "ORB", "ORTg", "SOS", "Season", "Team", "TeamId", "ThreePAr", "WinRecord" },
                values: new object[] { 81, 0.54100000000000004, 0.0, 112.8, 0.24299999999999999, 39, -1.74, 0.0, 0.51700000000000002, 20.0, 111.0, 0.14999999999999999, "2020-2021", "Spurs", null, 0.314, 33 });

            migrationBuilder.InsertData(
                table: "TeamHistory",
                columns: new[] { "TeamHistoryId", "DEFGPct", "DRB", "DRTg", "FTr", "LossRecord", "MOV", "NRTg", "OEFGPct", "ORB", "ORTg", "SOS", "Season", "Team", "TeamId", "ThreePAr", "WinRecord" },
                values: new object[] { 80, 0.53800000000000003, 0.0, 112.0, 0.19700000000000001, 41, -0.89000000000000001, 0.0, 0.54700000000000004, 22.300000000000001, 111.09999999999999, -0.050000000000000003, "2020-2021", "Bulls", null, 0.38300000000000001, 31 });

            migrationBuilder.InsertData(
                table: "TeamHistory",
                columns: new[] { "TeamHistoryId", "DEFGPct", "DRB", "DRTg", "FTr", "LossRecord", "MOV", "NRTg", "OEFGPct", "ORB", "ORTg", "SOS", "Season", "Team", "TeamId", "ThreePAr", "WinRecord" },
                values: new object[] { 79, 0.54300000000000004, 0.0, 112.5, 0.24099999999999999, 45, -0.46999999999999997, 0.0, 0.52900000000000003, 20.800000000000001, 112.0, -0.070000000000000007, "2020-2021", "Raptors", null, 0.44400000000000001, 27 });

            migrationBuilder.InsertData(
                table: "TeamHistory",
                columns: new[] { "TeamHistoryId", "DEFGPct", "DRB", "DRTg", "FTr", "LossRecord", "MOV", "NRTg", "OEFGPct", "ORB", "ORTg", "SOS", "Season", "Team", "TeamId", "ThreePAr", "WinRecord" },
                values: new object[] { 78, 0.55000000000000004, 0.0, 113.8, 0.29299999999999998, 41, -0.28999999999999998, 0.0, 0.53700000000000003, 26.300000000000001, 113.5, 0.10000000000000001, "2020-2021", "Pelicans", null, 0.34200000000000003, 31 });

            migrationBuilder.InsertData(
                table: "TeamHistory",
                columns: new[] { "TeamHistoryId", "DEFGPct", "DRB", "DRTg", "FTr", "LossRecord", "MOV", "NRTg", "OEFGPct", "ORB", "ORTg", "SOS", "Season", "Team", "TeamId", "ThreePAr", "WinRecord" },
                values: new object[] { 77, 0.53100000000000003, 0.0, 112.40000000000001, 0.22700000000000001, 38, -0.040000000000000001, 0.0, 0.54200000000000004, 20.199999999999999, 112.40000000000001, -0.080000000000000002, "2020-2021", "Pacers", null, 0.372, 34 });

            migrationBuilder.InsertData(
                table: "TeamHistory",
                columns: new[] { "TeamHistoryId", "DEFGPct", "DRB", "DRTg", "FTr", "LossRecord", "MOV", "NRTg", "OEFGPct", "ORB", "ORTg", "SOS", "Season", "Team", "TeamId", "ThreePAr", "WinRecord" },
                values: new object[] { 76, 0.54200000000000004, 0.0, 111.2, 0.252, 32, 0.029999999999999999, 0.0, 0.54600000000000004, 19.399999999999999, 111.2, -0.089999999999999997, "2020-2021", "Heat", null, 0.432, 40 });

            migrationBuilder.InsertData(
                table: "TeamHistory",
                columns: new[] { "TeamHistoryId", "DEFGPct", "DRB", "DRTg", "FTr", "LossRecord", "MOV", "NRTg", "OEFGPct", "ORB", "ORTg", "SOS", "Season", "Team", "TeamId", "ThreePAr", "WinRecord" },
                values: new object[] { 75, 0.53500000000000003, 0.0, 111.0, 0.23200000000000001, 34, 1.03, 0.0, 0.52800000000000002, 24.199999999999999, 112.0, 0.040000000000000001, "2020-2021", "Grizzlies", null, 0.34200000000000003, 38 });

            migrationBuilder.InsertData(
                table: "TeamHistory",
                columns: new[] { "TeamHistoryId", "DEFGPct", "DRB", "DRTg", "FTr", "LossRecord", "MOV", "NRTg", "OEFGPct", "ORB", "ORTg", "SOS", "Season", "Team", "TeamId", "ThreePAr", "WinRecord" },
                values: new object[] { 74, 0.52200000000000002, 0.0, 110.09999999999999, 0.23899999999999999, 33, 1.0600000000000001, 0.0, 0.55100000000000005, 17.899999999999999, 111.09999999999999, 0.040000000000000001, "2020-2021", "Warriors", null, 0.439, 39 });

            migrationBuilder.InsertData(
                table: "TeamHistory",
                columns: new[] { "TeamHistoryId", "DEFGPct", "DRB", "DRTg", "FTr", "LossRecord", "MOV", "NRTg", "OEFGPct", "ORB", "ORTg", "SOS", "Season", "Team", "TeamId", "ThreePAr", "WinRecord" },
                values: new object[] { 73, 0.53900000000000003, 0.0, 112.5, 0.23400000000000001, 36, 1.46, 0.0, 0.54300000000000004, 24.300000000000001, 114.0, -0.14000000000000001, "2020-2021", "Celtics", null, 0.40899999999999997, 36 });

            migrationBuilder.InsertData(
                table: "TeamHistory",
                columns: new[] { "TeamHistoryId", "DEFGPct", "DRB", "DRTg", "FTr", "LossRecord", "MOV", "NRTg", "OEFGPct", "ORB", "ORTg", "SOS", "Season", "Team", "TeamId", "ThreePAr", "WinRecord" },
                values: new object[] { 72, 0.54600000000000004, 0.0, 116.0, 0.23799999999999999, 30, 1.79, 0.0, 0.54000000000000004, 23.0, 117.8, 0.01, "2020-2021", "Trail Blazers", null, 0.44800000000000001, 42 });

            migrationBuilder.InsertData(
                table: "TeamHistory",
                columns: new[] { "TeamHistoryId", "DEFGPct", "DRB", "DRTg", "FTr", "LossRecord", "MOV", "NRTg", "OEFGPct", "ORB", "ORTg", "SOS", "Season", "Team", "TeamId", "ThreePAr", "WinRecord" },
                values: new object[] { 71, 0.53000000000000003, 0.0, 113.3, 0.27800000000000002, 31, 2.3199999999999998, 0.0, 0.53900000000000003, 24.399999999999999, 115.7, -0.17999999999999999, "2020-2021", "Hawks", null, 0.38200000000000001, 41 });

            migrationBuilder.InsertData(
                table: "TeamHistory",
                columns: new[] { "TeamHistoryId", "DEFGPct", "DRB", "DRTg", "FTr", "LossRecord", "MOV", "NRTg", "OEFGPct", "ORB", "ORTg", "SOS", "Season", "Team", "TeamId", "ThreePAr", "WinRecord" },
                values: new object[] { 70, 0.50900000000000001, 0.0, 108.2, 0.24199999999999999, 31, 2.3100000000000001, 0.0, 0.52400000000000002, 21.899999999999999, 110.59999999999999, -0.17999999999999999, "2020-2021", "Knicks", null, 0.34699999999999998, 41 });

            migrationBuilder.InsertData(
                table: "TeamHistory",
                columns: new[] { "TeamHistoryId", "DEFGPct", "DRB", "DRTg", "FTr", "LossRecord", "MOV", "NRTg", "OEFGPct", "ORB", "ORTg", "SOS", "Season", "Team", "TeamId", "ThreePAr", "WinRecord" },
                values: new object[] { 68, 0.52600000000000002, 0.0, 107.09999999999999, 0.27100000000000002, 30, 2.79, 0.0, 0.53600000000000003, 22.5, 109.90000000000001, -0.029999999999999999, "2020-2021", "Lakers", null, 0.36299999999999999, 42 });

            migrationBuilder.InsertData(
                table: "TeamHistory",
                columns: new[] { "TeamHistoryId", "DEFGPct", "DRB", "DRTg", "FTr", "LossRecord", "MOV", "NRTg", "OEFGPct", "ORB", "ORTg", "SOS", "Season", "Team", "TeamId", "ThreePAr", "WinRecord" },
                values: new object[] { 45, 0.51100000000000001, 0.0, 109.5, 0.26700000000000002, 37, -0.56999999999999995, 0.0, 0.52000000000000002, 23.199999999999999, 108.90000000000001, -0.44, "2019-2020", "Nets", null, 0.42299999999999999, 35 });

            migrationBuilder.InsertData(
                table: "TeamHistory",
                columns: new[] { "TeamHistoryId", "DEFGPct", "DRB", "DRTg", "FTr", "LossRecord", "MOV", "NRTg", "OEFGPct", "ORB", "ORTg", "SOS", "Season", "Team", "TeamId", "ThreePAr", "WinRecord" },
                values: new object[] { 26, 0.54100000000000004, 0.0, 113.90000000000001, 0.255, 53, -6.0199999999999996, 0.0, 0.52200000000000002, 24.699999999999999, 108.09999999999999, -0.040000000000000001, "2018-2019", "Hawks", null, 0.40300000000000002, 29 });

            migrationBuilder.InsertData(
                table: "TeamHistory",
                columns: new[] { "TeamHistoryId", "DEFGPct", "DRB", "DRTg", "FTr", "LossRecord", "MOV", "NRTg", "OEFGPct", "ORB", "ORTg", "SOS", "Season", "Team", "TeamId", "ThreePAr", "WinRecord" },
                values: new object[] { 43, 0.51800000000000002, 0.0, 108.8, 0.28999999999999998, 28, 1.99, 0.0, 0.53000000000000003, 19.300000000000001, 110.8, 0.34000000000000002, "2019-2020", "Thuder", null, 0.35299999999999998, 44 });

            migrationBuilder.InsertData(
                table: "TeamHistory",
                columns: new[] { "TeamHistoryId", "DEFGPct", "DRB", "DRTg", "FTr", "LossRecord", "MOV", "NRTg", "OEFGPct", "ORB", "ORTg", "SOS", "Season", "Team", "TeamId", "ThreePAr", "WinRecord" },
                values: new object[] { 19, 0.53800000000000003, 0.0, 112.5, 0.25700000000000001, 43, -1.1000000000000001, 0.0, 0.51400000000000001, 21.699999999999999, 111.40000000000001, -0.22, "2018-2019", "Hornets", null, 0.378, 39 });

            migrationBuilder.InsertData(
                table: "TeamHistory",
                columns: new[] { "TeamHistoryId", "DEFGPct", "DRB", "DRTg", "FTr", "LossRecord", "MOV", "NRTg", "OEFGPct", "ORB", "ORTg", "SOS", "Season", "Team", "TeamId", "ThreePAr", "WinRecord" },
                values: new object[] { 18, 0.53300000000000003, 0.0, 111.5, 0.24399999999999999, 43, -1.1200000000000001, 0.0, 0.52400000000000002, 23.100000000000001, 110.40000000000001, 0.31, "2018-2019", "Kings", null, 0.32100000000000001, 39 });

            migrationBuilder.InsertData(
                table: "TeamHistory",
                columns: new[] { "TeamHistoryId", "DEFGPct", "DRB", "DRTg", "FTr", "LossRecord", "MOV", "NRTg", "OEFGPct", "ORB", "ORTg", "SOS", "Season", "Team", "TeamId", "ThreePAr", "WinRecord" },
                values: new object[] { 17, 0.51000000000000001, 0.0, 107.59999999999999, 0.247, 43, -0.23000000000000001, 0.0, 0.51500000000000001, 24.800000000000001, 107.3, -0.22, "2018-2019", "Heat", null, 0.36799999999999999, 39 });

            migrationBuilder.InsertData(
                table: "TeamHistory",
                columns: new[] { "TeamHistoryId", "DEFGPct", "DRB", "DRTg", "FTr", "LossRecord", "MOV", "NRTg", "OEFGPct", "ORB", "ORTg", "SOS", "Season", "Team", "TeamId", "ThreePAr", "WinRecord" },
                values: new object[] { 16, 0.52600000000000002, 0.0, 109.2, 0.26200000000000001, 41, -0.23999999999999999, 0.0, 0.50900000000000001, 24.800000000000001, 109.0, -0.31, "2018-2019", "Pistons", null, 0.39400000000000002, 41 });

            migrationBuilder.InsertData(
                table: "TeamHistory",
                columns: new[] { "TeamHistoryId", "DEFGPct", "DRB", "DRTg", "FTr", "LossRecord", "MOV", "NRTg", "OEFGPct", "ORB", "ORTg", "SOS", "Season", "Team", "TeamId", "ThreePAr", "WinRecord" },
                values: new object[] { 15, 0.51200000000000001, 0.0, 109.7, 0.28399999999999997, 40, -0.070000000000000007, 0.0, 0.52000000000000002, 23.800000000000001, 109.59999999999999, -0.33000000000000002, "2018-2019", "Nets", null, 0.40300000000000002, 42 });

            migrationBuilder.InsertData(
                table: "TeamHistory",
                columns: new[] { "TeamHistoryId", "DEFGPct", "DRB", "DRTg", "FTr", "LossRecord", "MOV", "NRTg", "OEFGPct", "ORB", "ORTg", "SOS", "Season", "Team", "TeamId", "ThreePAr", "WinRecord" },
                values: new object[] { 14, 0.51500000000000001, 0.0, 108.09999999999999, 0.216, 40, 0.70999999999999996, 0.0, 0.51800000000000002, 22.0, 108.90000000000001, -0.42999999999999999, "2018-2019", "Magic", null, 0.35999999999999999, 42 });

            migrationBuilder.InsertData(
                table: "TeamHistory",
                columns: new[] { "TeamHistoryId", "DEFGPct", "DRB", "DRTg", "FTr", "LossRecord", "MOV", "NRTg", "OEFGPct", "ORB", "ORTg", "SOS", "Season", "Team", "TeamId", "ThreePAr", "WinRecord" },
                values: new object[] { 13, 0.51400000000000001, 0.0, 111.5, 0.32600000000000001, 34, 0.84999999999999998, 0.0, 0.52900000000000003, 22.0, 112.40000000000001, 0.23000000000000001, "2018-2019", "Clippers", null, 0.29499999999999998, 48 });

            migrationBuilder.InsertData(
                table: "TeamHistory",
                columns: new[] { "TeamHistoryId", "DEFGPct", "DRB", "DRTg", "FTr", "LossRecord", "MOV", "NRTg", "OEFGPct", "ORB", "ORTg", "SOS", "Season", "Team", "TeamId", "ThreePAr", "WinRecord" },
                values: new object[] { 12, 0.52800000000000002, 0.0, 111.2, 0.23699999999999999, 34, 1.6799999999999999, 0.0, 0.53400000000000003, 21.0, 112.90000000000001, 0.12, "2018-2019", "Spurs", null, 0.28599999999999998, 48 });

            migrationBuilder.InsertData(
                table: "TeamHistory",
                columns: new[] { "TeamHistoryId", "DEFGPct", "DRB", "DRTg", "FTr", "LossRecord", "MOV", "NRTg", "OEFGPct", "ORB", "ORTg", "SOS", "Season", "Team", "TeamId", "ThreePAr", "WinRecord" },
                values: new object[] { 11, 0.51200000000000001, 0.0, 110.0, 0.312, 31, 2.7000000000000002, 0.0, 0.53200000000000003, 24.5, 112.59999999999999, -0.44, "2018-2019", "76ers", null, 0.34200000000000003, 51 });

            migrationBuilder.InsertData(
                table: "TeamHistory",
                columns: new[] { "TeamHistoryId", "DEFGPct", "DRB", "DRTg", "FTr", "LossRecord", "MOV", "NRTg", "OEFGPct", "ORB", "ORTg", "SOS", "Season", "Team", "TeamId", "ThreePAr", "WinRecord" },
                values: new object[] { 10, 0.52300000000000002, 0.0, 107.0, 0.26600000000000001, 33, 3.3999999999999999, 0.0, 0.51400000000000001, 26.0, 110.3, 0.14999999999999999, "2018-2019", "Thunder", null, 0.34699999999999998, 49 });

            migrationBuilder.InsertData(
                table: "TeamHistory",
                columns: new[] { "TeamHistoryId", "DEFGPct", "DRB", "DRTg", "FTr", "LossRecord", "MOV", "NRTg", "OEFGPct", "ORB", "ORTg", "SOS", "Season", "Team", "TeamId", "ThreePAr", "WinRecord" },
                values: new object[] { 9, 0.51600000000000001, 0.0, 106.5, 0.24199999999999999, 34, 3.3300000000000001, 0.0, 0.53000000000000003, 21.899999999999999, 109.90000000000001, -0.56999999999999995, "2018-2019", "Pacers", null, 0.29199999999999998, 48 });

            migrationBuilder.InsertData(
                table: "TeamHistory",
                columns: new[] { "TeamHistoryId", "DEFGPct", "DRB", "DRTg", "FTr", "LossRecord", "MOV", "NRTg", "OEFGPct", "ORB", "ORTg", "SOS", "Season", "Team", "TeamId", "ThreePAr", "WinRecord" },
                values: new object[] { 8, 0.52100000000000002, 0.0, 108.90000000000001, 0.23200000000000001, 28, 3.9500000000000002, 0.0, 0.52700000000000002, 26.600000000000001, 113.0, 0.23999999999999999, "2018-2019", "Nuggets", null, 0.34799999999999998, 54 });

            migrationBuilder.InsertData(
                table: "TeamHistory",
                columns: new[] { "TeamHistoryId", "DEFGPct", "DRB", "DRTg", "FTr", "LossRecord", "MOV", "NRTg", "OEFGPct", "ORB", "ORTg", "SOS", "Season", "Team", "TeamId", "ThreePAr", "WinRecord" },
                values: new object[] { 7, 0.51600000000000001, 0.0, 110.5, 0.25800000000000001, 29, 4.2000000000000002, 0.0, 0.52800000000000002, 26.600000000000001, 114.7, 0.23999999999999999, "2018-2019", "Trail Blazers", null, 0.33900000000000002, 53 });

            migrationBuilder.InsertData(
                table: "TeamHistory",
                columns: new[] { "TeamHistoryId", "DEFGPct", "DRB", "DRTg", "FTr", "LossRecord", "MOV", "NRTg", "OEFGPct", "ORB", "ORTg", "SOS", "Season", "Team", "TeamId", "ThreePAr", "WinRecord" },
                values: new object[] { 6, 0.51400000000000001, 0.0, 107.8, 0.215, 33, 4.4400000000000004, 0.0, 0.53400000000000003, 21.600000000000001, 112.2, -0.54000000000000004, "2018-2019", "Celtics", null, 0.38100000000000001, 49 });

            migrationBuilder.InsertData(
                table: "TeamHistory",
                columns: new[] { "TeamHistoryId", "DEFGPct", "DRB", "DRTg", "FTr", "LossRecord", "MOV", "NRTg", "OEFGPct", "ORB", "ORTg", "SOS", "Season", "Team", "TeamId", "ThreePAr", "WinRecord" },
                values: new object[] { 5, 0.52500000000000002, 0.0, 110.7, 0.27900000000000003, 29, 4.7699999999999996, 0.0, 0.54200000000000004, 22.800000000000001, 115.5, 0.19, "2018-2019", "Rockets", null, 0.51900000000000002, 53 });

            migrationBuilder.InsertData(
                table: "TeamHistory",
                columns: new[] { "TeamHistoryId", "DEFGPct", "DRB", "DRTg", "FTr", "LossRecord", "MOV", "NRTg", "OEFGPct", "ORB", "ORTg", "SOS", "Season", "Team", "TeamId", "ThreePAr", "WinRecord" },
                values: new object[] { 4, 0.50700000000000001, 0.0, 105.7, 0.29499999999999998, 32, 5.2599999999999998, 0.0, 0.53800000000000003, 22.899999999999999, 110.90000000000001, 0.029999999999999999, "2018-2019", "Jazz", null, 0.39400000000000002, 50 });

            migrationBuilder.InsertData(
                table: "TeamHistory",
                columns: new[] { "TeamHistoryId", "DEFGPct", "DRB", "DRTg", "FTr", "LossRecord", "MOV", "NRTg", "OEFGPct", "ORB", "ORTg", "SOS", "Season", "Team", "TeamId", "ThreePAr", "WinRecord" },
                values: new object[] { 3, 0.50900000000000001, 0.0, 107.09999999999999, 0.247, 24, 6.0899999999999999, 0.0, 0.54300000000000004, 21.899999999999999, 113.09999999999999, -0.59999999999999998, "2018-2019", "Raptors", null, 0.379, 58 });

            migrationBuilder.InsertData(
                table: "TeamHistory",
                columns: new[] { "TeamHistoryId", "DEFGPct", "DRB", "DRTg", "FTr", "LossRecord", "MOV", "NRTg", "OEFGPct", "ORB", "ORTg", "SOS", "Season", "Team", "TeamId", "ThreePAr", "WinRecord" },
                values: new object[] { 2, 0.50800000000000001, 0.0, 109.5, 0.22700000000000001, 25, 6.46, 0.0, 0.56499999999999995, 22.5, 115.90000000000001, -0.040000000000000001, "2018-2019", "Warriors", null, 0.38400000000000001, 57 });

            migrationBuilder.InsertData(
                table: "TeamHistory",
                columns: new[] { "TeamHistoryId", "DEFGPct", "DRB", "DRTg", "FTr", "LossRecord", "MOV", "NRTg", "OEFGPct", "ORB", "ORTg", "SOS", "Season", "Team", "TeamId", "ThreePAr", "WinRecord" },
                values: new object[] { 1, 0.503, 0.0, 105.2, 0.255, 22, 8.8699999999999992, 0.0, 0.55000000000000004, 20.800000000000001, 113.8, -0.81999999999999995, "2018-2019", "Bucks", null, 0.41899999999999998, 60 });

            migrationBuilder.InsertData(
                table: "TeamHistory",
                columns: new[] { "TeamHistoryId", "DEFGPct", "DRB", "DRTg", "FTr", "LossRecord", "MOV", "NRTg", "OEFGPct", "ORB", "ORTg", "SOS", "Season", "Team", "TeamId", "ThreePAr", "WinRecord" },
                values: new object[] { 20, 0.53200000000000003, 0.0, 112.59999999999999, 0.254, 49, -1.3300000000000001, 0.0, 0.52900000000000003, 24.100000000000001, 111.40000000000001, 0.23000000000000001, "2018-2019", "Pelicans", null, 0.32400000000000001, 33 });

            migrationBuilder.InsertData(
                table: "TeamHistory",
                columns: new[] { "TeamHistoryId", "DEFGPct", "DRB", "DRTg", "FTr", "LossRecord", "MOV", "NRTg", "OEFGPct", "ORB", "ORTg", "SOS", "Season", "Team", "TeamId", "ThreePAr", "WinRecord" },
                values: new object[] { 44, 0.53900000000000003, 0.0, 111.40000000000001, 0.27100000000000002, 39, 0.22, 0.0, 0.53200000000000003, 22.199999999999999, 111.7, 0.34999999999999998, "2019-2020", "Suns", null, 0.36099999999999999, 34 });

            migrationBuilder.InsertData(
                table: "TeamHistory",
                columns: new[] { "TeamHistoryId", "DEFGPct", "DRB", "DRTg", "FTr", "LossRecord", "MOV", "NRTg", "OEFGPct", "ORB", "ORTg", "SOS", "Season", "Team", "TeamId", "ThreePAr", "WinRecord" },
                values: new object[] { 21, 0.52200000000000002, 0.0, 110.7, 0.29099999999999998, 49, -1.28, 0.0, 0.51900000000000002, 22.699999999999999, 109.40000000000001, 0.41999999999999998, "2018-2019", "Mavericks", null, 0.42199999999999999, 33 });

            migrationBuilder.InsertData(
                table: "TeamHistory",
                columns: new[] { "TeamHistoryId", "DEFGPct", "DRB", "DRTg", "FTr", "LossRecord", "MOV", "NRTg", "OEFGPct", "ORB", "ORTg", "SOS", "Season", "Team", "TeamId", "ThreePAr", "WinRecord" },
                values: new object[] { 23, 0.51600000000000001, 0.0, 109.5, 0.25700000000000001, 45, -1.72, 0.0, 0.52700000000000002, 22.199999999999999, 107.8, 0.39000000000000001, "2018-2019", "Lakers", null, 0.34200000000000003, 37 });

            migrationBuilder.InsertData(
                table: "TeamHistory",
                columns: new[] { "TeamHistoryId", "DEFGPct", "DRB", "DRTg", "FTr", "LossRecord", "MOV", "NRTg", "OEFGPct", "ORB", "ORTg", "SOS", "Season", "Team", "TeamId", "ThreePAr", "WinRecord" },
                values: new object[] { 42, 0.51100000000000001, 0.0, 108.0, 0.216, 28, 1.96, 0.0, 0.53400000000000003, 20.0, 110.0, -0.33000000000000002, "2019-2020", "Pacers", null, 0.317, 45 });

            migrationBuilder.InsertData(
                table: "TeamHistory",
                columns: new[] { "TeamHistoryId", "DEFGPct", "DRB", "DRTg", "FTr", "LossRecord", "MOV", "NRTg", "OEFGPct", "ORB", "ORTg", "SOS", "Season", "Team", "TeamId", "ThreePAr", "WinRecord" },
                values: new object[] { 41, 0.53300000000000003, 0.0, 111.0, 0.23499999999999999, 27, 2.1099999999999999, 0.0, 0.53500000000000003, 24.800000000000001, 113.09999999999999, 0.23999999999999999, "2019-2020", "Nuggets", null, 0.34399999999999997, 46 });

            migrationBuilder.InsertData(
                table: "TeamHistory",
                columns: new[] { "TeamHistoryId", "DEFGPct", "DRB", "DRTg", "FTr", "LossRecord", "MOV", "NRTg", "OEFGPct", "ORB", "ORTg", "SOS", "Season", "Team", "TeamId", "ThreePAr", "WinRecord" },
                values: new object[] { 40, 0.52300000000000002, 0.0, 109.0, 0.255, 30, 2.3799999999999999, 0.0, 0.53400000000000003, 23.899999999999999, 111.3, -0.13, "2019-2020", "76ers", null, 0.35999999999999999, 43 });

            migrationBuilder.InsertData(
                table: "TeamHistory",
                columns: new[] { "TeamHistoryId", "DEFGPct", "DRB", "DRTg", "FTr", "LossRecord", "MOV", "NRTg", "OEFGPct", "ORB", "ORTg", "SOS", "Season", "Team", "TeamId", "ThreePAr", "WinRecord" },
                values: new object[] { 39, 0.51800000000000002, 0.0, 109.90000000000001, 0.26800000000000002, 28, 2.4700000000000002, 0.0, 0.54900000000000004, 21.600000000000001, 112.3, 0.050000000000000003, "2019-2020", "Jazz", null, 0.41399999999999998, 44 });

            migrationBuilder.InsertData(
                table: "TeamHistory",
                columns: new[] { "TeamHistoryId", "DEFGPct", "DRB", "DRTg", "FTr", "LossRecord", "MOV", "NRTg", "OEFGPct", "ORB", "ORTg", "SOS", "Season", "Team", "TeamId", "ThreePAr", "WinRecord" },
                values: new object[] { 38, 0.52900000000000003, 0.0, 110.09999999999999, 0.28799999999999998, 28, 2.96, 0.0, 0.53700000000000003, 21.0, 112.90000000000001, 0.17000000000000001, "2019-2020", "Rockets", null, 0.501, 44 });

            migrationBuilder.InsertData(
                table: "TeamHistory",
                columns: new[] { "TeamHistoryId", "DEFGPct", "DRB", "DRTg", "FTr", "LossRecord", "MOV", "NRTg", "OEFGPct", "ORB", "ORTg", "SOS", "Season", "Team", "TeamId", "ThreePAr", "WinRecord" },
                values: new object[] { 37, 0.52300000000000002, 0.0, 109.5, 0.29899999999999999, 29, 2.9500000000000002, 0.0, 0.54700000000000004, 20.300000000000001, 112.5, -0.34999999999999998, "2019-2020", "Heat", null, 0.41899999999999998, 44 });

            migrationBuilder.InsertData(
                table: "TeamHistory",
                columns: new[] { "TeamHistoryId", "DEFGPct", "DRB", "DRTg", "FTr", "LossRecord", "MOV", "NRTg", "OEFGPct", "ORB", "ORTg", "SOS", "Season", "Team", "TeamId", "ThreePAr", "WinRecord" },
                values: new object[] { 36, 0.52500000000000002, 0.0, 111.7, 0.26400000000000001, 32, 4.9500000000000002, 0.0, 0.54500000000000004, 23.199999999999999, 116.7, -0.070000000000000007, "2019-2020", "Mavericks", null, 0.45700000000000002, 43 });

            migrationBuilder.InsertData(
                table: "TeamHistory",
                columns: new[] { "TeamHistoryId", "DEFGPct", "DRB", "DRTg", "FTr", "LossRecord", "MOV", "NRTg", "OEFGPct", "ORB", "ORTg", "SOS", "Season", "Team", "TeamId", "ThreePAr", "WinRecord" },
                values: new object[] { 35, 0.51500000000000001, 0.0, 106.3, 0.27600000000000002, 19, 5.79, 0.0, 0.54200000000000004, 24.5, 112.0, 0.48999999999999999, "2019-2020", "Lakers", null, 0.35799999999999998, 52 });

            migrationBuilder.InsertData(
                table: "TeamHistory",
                columns: new[] { "TeamHistoryId", "DEFGPct", "DRB", "DRTg", "FTr", "LossRecord", "MOV", "NRTg", "OEFGPct", "ORB", "ORTg", "SOS", "Season", "Team", "TeamId", "ThreePAr", "WinRecord" },
                values: new object[] { 34, 0.502, 0.0, 105.0, 0.26400000000000001, 19, 6.2400000000000002, 0.0, 0.53600000000000003, 21.300000000000001, 111.09999999999999, -0.26000000000000001, "2019-2020", "Raptors", null, 0.42099999999999999, 53 });

            migrationBuilder.InsertData(
                table: "TeamHistory",
                columns: new[] { "TeamHistoryId", "DEFGPct", "DRB", "DRTg", "FTr", "LossRecord", "MOV", "NRTg", "OEFGPct", "ORB", "ORTg", "SOS", "Season", "Team", "TeamId", "ThreePAr", "WinRecord" },
                values: new object[] { 33, 0.50600000000000001, 0.0, 107.59999999999999, 0.29499999999999998, 23, 6.4400000000000004, 0.0, 0.53500000000000003, 23.5, 113.90000000000001, 0.20999999999999999, "2019-2020", "Clippers", null, 0.375, 49 });

            migrationBuilder.InsertData(
                table: "TeamHistory",
                columns: new[] { "TeamHistoryId", "DEFGPct", "DRB", "DRTg", "FTr", "LossRecord", "MOV", "NRTg", "OEFGPct", "ORB", "ORTg", "SOS", "Season", "Team", "TeamId", "ThreePAr", "WinRecord" },
                values: new object[] { 32, 0.50900000000000001, 0.0, 107.0, 0.25900000000000001, 24, 6.3099999999999996, 0.0, 0.53100000000000003, 23.899999999999999, 113.3, -0.46999999999999997, "2019-2020", "Celtics", null, 0.38600000000000001, 48 });

            migrationBuilder.InsertData(
                table: "TeamHistory",
                columns: new[] { "TeamHistoryId", "DEFGPct", "DRB", "DRTg", "FTr", "LossRecord", "MOV", "NRTg", "OEFGPct", "ORB", "ORTg", "SOS", "Season", "Team", "TeamId", "ThreePAr", "WinRecord" },
                values: new object[] { 31, 0.48899999999999999, 0.0, 102.90000000000001, 0.27100000000000002, 17, 10.08, 0.0, 0.55200000000000005, 20.699999999999999, 112.40000000000001, -0.67000000000000004, "2019-2020", "Bucks", null, 0.42799999999999999, 56 });

            migrationBuilder.InsertData(
                table: "TeamHistory",
                columns: new[] { "TeamHistoryId", "DEFGPct", "DRB", "DRTg", "FTr", "LossRecord", "MOV", "NRTg", "OEFGPct", "ORB", "ORTg", "SOS", "Season", "Team", "TeamId", "ThreePAr", "WinRecord" },
                values: new object[] { 30, 0.56399999999999995, 0.0, 117.59999999999999, 0.23599999999999999, 63, -9.6099999999999994, 0.0, 0.503, 23.699999999999999, 107.7, 0.22, "2018-2019", "Cavaliers", null, 0.33200000000000002, 19 });

            migrationBuilder.InsertData(
                table: "TeamHistory",
                columns: new[] { "TeamHistoryId", "DEFGPct", "DRB", "DRTg", "FTr", "LossRecord", "MOV", "NRTg", "OEFGPct", "ORB", "ORTg", "SOS", "Season", "Team", "TeamId", "ThreePAr", "WinRecord" },
                values: new object[] { 29, 0.54500000000000004, 0.0, 115.09999999999999, 0.25900000000000001, 63, -9.3399999999999999, 0.0, 0.51400000000000001, 20.5, 105.90000000000001, 0.72999999999999998, "2018-2019", "Suns", null, 0.33500000000000002, 19 });

            migrationBuilder.InsertData(
                table: "TeamHistory",
                columns: new[] { "TeamHistoryId", "DEFGPct", "DRB", "DRTg", "FTr", "LossRecord", "MOV", "NRTg", "OEFGPct", "ORB", "ORTg", "SOS", "Season", "Team", "TeamId", "ThreePAr", "WinRecord" },
                values: new object[] { 28, 0.53300000000000003, 0.0, 113.7, 0.27000000000000002, 65, -9.2100000000000009, 0.0, 0.48999999999999999, 22.100000000000001, 104.5, 0.28000000000000003, "2018-2019", "Knicks", null, 0.33400000000000002, 17 });

            migrationBuilder.InsertData(
                table: "TeamHistory",
                columns: new[] { "TeamHistoryId", "DEFGPct", "DRB", "DRTg", "FTr", "LossRecord", "MOV", "NRTg", "OEFGPct", "ORB", "ORTg", "SOS", "Season", "Team", "TeamId", "ThreePAr", "WinRecord" },
                values: new object[] { 27, 0.54100000000000004, 0.0, 113.2, 0.23499999999999999, 60, -8.4100000000000001, 0.0, 0.505, 19.399999999999999, 104.8, 0.10000000000000001, "2018-2019", "Bulls", null, 0.29499999999999998, 22 });

            migrationBuilder.InsertData(
                table: "TeamHistory",
                columns: new[] { "TeamHistoryId", "DEFGPct", "DRB", "DRTg", "FTr", "LossRecord", "MOV", "NRTg", "OEFGPct", "ORB", "ORTg", "SOS", "Season", "Team", "TeamId", "ThreePAr", "WinRecord" },
                values: new object[] { 89, 0.54700000000000004, 0.0, 114.5, 0.23999999999999999, 51, -9.3100000000000005, 0.0, 0.48999999999999999, 21.600000000000001, 105.09999999999999, 0.28999999999999998, "2020-2021", "Magic", null, 0.35599999999999998, 21 });

            migrationBuilder.InsertData(
                table: "TeamHistory",
                columns: new[] { "TeamHistoryId", "DEFGPct", "DRB", "DRTg", "FTr", "LossRecord", "MOV", "NRTg", "OEFGPct", "ORB", "ORTg", "SOS", "Season", "Team", "TeamId", "ThreePAr", "WinRecord" },
                values: new object[] { 25, 0.54600000000000004, 0.0, 113.90000000000001, 0.26600000000000001, 50, -2.8999999999999999, 0.0, 0.53100000000000003, 21.300000000000001, 111.09999999999999, -0.40000000000000002, "2018-2019", "Wizards", null, 0.37, 32 });

            migrationBuilder.InsertData(
                table: "TeamHistory",
                columns: new[] { "TeamHistoryId", "DEFGPct", "DRB", "DRTg", "FTr", "LossRecord", "MOV", "NRTg", "OEFGPct", "ORB", "ORTg", "SOS", "Season", "Team", "TeamId", "ThreePAr", "WinRecord" },
                values: new object[] { 24, 0.52100000000000002, 0.0, 108.8, 0.27200000000000002, 49, -2.6000000000000001, 0.0, 0.50800000000000001, 20.0, 106.09999999999999, 0.51000000000000001, "2018-2019", "Grizzlies", null, 0.34200000000000003, 33 });

            migrationBuilder.InsertData(
                table: "TeamHistory",
                columns: new[] { "TeamHistoryId", "DEFGPct", "DRB", "DRTg", "FTr", "LossRecord", "MOV", "NRTg", "OEFGPct", "ORB", "ORTg", "SOS", "Season", "Team", "TeamId", "ThreePAr", "WinRecord" },
                values: new object[] { 22, 0.53800000000000003, 0.0, 112.90000000000001, 0.26700000000000002, 46, -1.5, 0.0, 0.51100000000000001, 24.600000000000001, 111.40000000000001, 0.47999999999999998, "2018-2019", "Timberwolves", null, 0.315, 36 });

            migrationBuilder.InsertData(
                table: "TeamHistory",
                columns: new[] { "TeamHistoryId", "DEFGPct", "DRB", "DRTg", "FTr", "LossRecord", "MOV", "NRTg", "OEFGPct", "ORB", "ORTg", "SOS", "Season", "Team", "TeamId", "ThreePAr", "WinRecord" },
                values: new object[] { 90, 0.54700000000000004, 0.0, 114.0, 0.24199999999999999, 50, -10.640000000000001, 0.0, 0.50900000000000001, 21.199999999999999, 103.5, 0.51000000000000001, "2020-2021", "Thunder", null, 0.39900000000000002, 22 });

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
