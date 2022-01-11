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

            migrationBuilder.InsertData(
                table: "Player",
                columns: new[] { "PlayerId", "Joined", "Name", "PhotoPath", "Team", "TeamId" },
                values: new object[] { 1, new DateTime(2022, 1, 8, 20, 40, 23, 905, DateTimeKind.Local).AddTicks(7690), "Trae Young", "/Photos/nba_anonymous.jpg", "Hawks", null });

            migrationBuilder.InsertData(
                table: "Player",
                columns: new[] { "PlayerId", "Joined", "Name", "PhotoPath", "Team", "TeamId" },
                values: new object[] { 2, new DateTime(2022, 1, 8, 20, 40, 23, 906, DateTimeKind.Local).AddTicks(200), "Jayson Tatum", "/Photos/nba_anonymous.jpg", "Celtics", null });

            migrationBuilder.InsertData(
                table: "Player",
                columns: new[] { "PlayerId", "Joined", "Name", "PhotoPath", "Team", "TeamId" },
                values: new object[] { 3, new DateTime(2022, 1, 8, 20, 40, 23, 906, DateTimeKind.Local).AddTicks(820), "Kevin Durant", "/Photos/nba_anonymous.jpg", "Nets", null });

            migrationBuilder.InsertData(
                table: "Player",
                columns: new[] { "PlayerId", "Joined", "Name", "PhotoPath", "Team", "TeamId" },
                values: new object[] { 4, new DateTime(2022, 1, 8, 20, 40, 23, 906, DateTimeKind.Local).AddTicks(890), "Stephen Curry", "/Photos/nba_anonymous.jpg", "Warriors", null });

            migrationBuilder.InsertData(
                table: "Player",
                columns: new[] { "PlayerId", "Joined", "Name", "PhotoPath", "Team", "TeamId" },
                values: new object[] { 5, new DateTime(2022, 1, 8, 20, 40, 23, 906, DateTimeKind.Local).AddTicks(910), "Zach LaVine", "/Photos/nba_anonymous.jpg", "Bulls", null });

            migrationBuilder.InsertData(
                table: "Player",
                columns: new[] { "PlayerId", "Joined", "Name", "PhotoPath", "Team", "TeamId" },
                values: new object[] { 6, new DateTime(2022, 1, 8, 20, 40, 23, 906, DateTimeKind.Local).AddTicks(920), "LeBron James", "/Photos/nba_anonymous.jpg", "Lakers", null });

            migrationBuilder.InsertData(
                table: "Player",
                columns: new[] { "PlayerId", "Joined", "Name", "PhotoPath", "Team", "TeamId" },
                values: new object[] { 7, new DateTime(2022, 1, 8, 20, 40, 23, 906, DateTimeKind.Local).AddTicks(930), "Julius Randle", "/Photos/nba_anonymous.jpg", "Knicks", null });

            migrationBuilder.InsertData(
                table: "Team",
                columns: new[] { "TeamId", "City", "DateFounded", "Name", "PhotoPath" },
                values: new object[] { 1, "Atlanta", new DateTime(2022, 1, 8, 20, 40, 23, 877, DateTimeKind.Local).AddTicks(1270), "Hawks", "/Photos/nba_anonymous.jpg" });

            migrationBuilder.InsertData(
                table: "Team",
                columns: new[] { "TeamId", "City", "DateFounded", "Name", "PhotoPath" },
                values: new object[] { 2, "Boston", new DateTime(2022, 1, 8, 20, 40, 23, 903, DateTimeKind.Local).AddTicks(6370), "Celtics", "/Photos/nba_anonymous.jpg" });

            migrationBuilder.InsertData(
                table: "Team",
                columns: new[] { "TeamId", "City", "DateFounded", "Name", "PhotoPath" },
                values: new object[] { 3, "Brooklyn", new DateTime(2022, 1, 8, 20, 40, 23, 903, DateTimeKind.Local).AddTicks(7360), "Nets", "/Photos/nba_anonymous.jpg" });

            migrationBuilder.InsertData(
                table: "Team",
                columns: new[] { "TeamId", "City", "DateFounded", "Name", "PhotoPath" },
                values: new object[] { 4, "Golden State", new DateTime(2022, 1, 8, 20, 40, 23, 903, DateTimeKind.Local).AddTicks(7430), "Warriors", "/Photos/nba_anonymous.jpg" });

            migrationBuilder.InsertData(
                table: "Team",
                columns: new[] { "TeamId", "City", "DateFounded", "Name", "PhotoPath" },
                values: new object[] { 5, "Chicago", new DateTime(2022, 1, 8, 20, 40, 23, 903, DateTimeKind.Local).AddTicks(7440), "Bulls", "/Photos/nba_anonymous.jpg" });

            migrationBuilder.InsertData(
                table: "Team",
                columns: new[] { "TeamId", "City", "DateFounded", "Name", "PhotoPath" },
                values: new object[] { 6, "Los Angeles", new DateTime(2022, 1, 8, 20, 40, 23, 903, DateTimeKind.Local).AddTicks(7450), "Lakers", "/Photos/nba_anonymous.jpg" });

            migrationBuilder.InsertData(
                table: "Team",
                columns: new[] { "TeamId", "City", "DateFounded", "Name", "PhotoPath" },
                values: new object[] { 7, "New York", new DateTime(2022, 1, 8, 20, 40, 23, 903, DateTimeKind.Local).AddTicks(7470), "Knicks", "/Photos/nba_anonymous.jpg" });

            migrationBuilder.CreateIndex(
                name: "IX_Player_TeamId",
                table: "Player",
                column: "TeamId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Player");

            migrationBuilder.DropTable(
                name: "Team");
        }
    }
}
