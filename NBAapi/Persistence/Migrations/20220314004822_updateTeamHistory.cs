using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class updateTeamHistory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Arena",
                table: "Team",
                type: "TEXT",
                nullable: true);

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

            migrationBuilder.UpdateData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 1,
                column: "Joined",
                value: new DateTime(2022, 3, 13, 17, 48, 21, 223, DateTimeKind.Local).AddTicks(2500));

            migrationBuilder.UpdateData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 2,
                column: "Joined",
                value: new DateTime(2022, 3, 13, 17, 48, 21, 223, DateTimeKind.Local).AddTicks(5020));

            migrationBuilder.UpdateData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 3,
                column: "Joined",
                value: new DateTime(2022, 3, 13, 17, 48, 21, 223, DateTimeKind.Local).AddTicks(5610));

            migrationBuilder.UpdateData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 4,
                column: "Joined",
                value: new DateTime(2022, 3, 13, 17, 48, 21, 223, DateTimeKind.Local).AddTicks(5680));

            migrationBuilder.UpdateData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 5,
                column: "Joined",
                value: new DateTime(2022, 3, 13, 17, 48, 21, 223, DateTimeKind.Local).AddTicks(5700));

            migrationBuilder.UpdateData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 6,
                column: "Joined",
                value: new DateTime(2022, 3, 13, 17, 48, 21, 223, DateTimeKind.Local).AddTicks(5710));

            migrationBuilder.UpdateData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 7,
                column: "Joined",
                value: new DateTime(2022, 3, 13, 17, 48, 21, 223, DateTimeKind.Local).AddTicks(5730));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 1,
                column: "DateFounded",
                value: new DateTime(2022, 3, 13, 17, 48, 21, 195, DateTimeKind.Local).AddTicks(7760));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 2,
                column: "DateFounded",
                value: new DateTime(2022, 3, 13, 17, 48, 21, 221, DateTimeKind.Local).AddTicks(2680));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 3,
                column: "DateFounded",
                value: new DateTime(2022, 3, 13, 17, 48, 21, 221, DateTimeKind.Local).AddTicks(3890));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 4,
                column: "DateFounded",
                value: new DateTime(2022, 3, 13, 17, 48, 21, 221, DateTimeKind.Local).AddTicks(3980));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 5,
                column: "DateFounded",
                value: new DateTime(2022, 3, 13, 17, 48, 21, 221, DateTimeKind.Local).AddTicks(4000));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 6,
                column: "DateFounded",
                value: new DateTime(2022, 3, 13, 17, 48, 21, 221, DateTimeKind.Local).AddTicks(4020));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 7,
                column: "DateFounded",
                value: new DateTime(2022, 3, 13, 17, 48, 21, 221, DateTimeKind.Local).AddTicks(4030));

            migrationBuilder.InsertData(
                table: "TeamHistory",
                columns: new[] { "TeamHistoryId", "DEFGPct", "DRB", "DRTg", "FTr", "LossRecord", "MOV", "NRTg", "OEFGPct", "ORB", "ORTg", "SOS", "Season", "Team", "TeamId", "ThreePAr", "WinRecord" },
                values: new object[] { 1, 0.51500000000000001, 78.799999999999997, 106.3, 0.27600000000000002, 19, 5.79, 0.0, 0.54200000000000004, 24.5, 112.0, 0.48999999999999999, "2019-2020", "Lakers", null, 0.35799999999999998, 52 });

            migrationBuilder.InsertData(
                table: "TeamHistory",
                columns: new[] { "TeamHistoryId", "DEFGPct", "DRB", "DRTg", "FTr", "LossRecord", "MOV", "NRTg", "OEFGPct", "ORB", "ORTg", "SOS", "Season", "Team", "TeamId", "ThreePAr", "WinRecord" },
                values: new object[] { 2, 0.52300000000000002, 79.5, 109.5, 0.29899999999999999, 29, 2.9500000000000002, 0.0, 0.54700000000000004, 20.300000000000001, 112.5, 0.34999999999999998, "2019-2020", "Heat", null, 0.41899999999999998, 44 });

            migrationBuilder.CreateIndex(
                name: "IX_TeamHistory_TeamId",
                table: "TeamHistory",
                column: "TeamId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TeamHistory");

            migrationBuilder.DropColumn(
                name: "Arena",
                table: "Team");

            migrationBuilder.UpdateData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 1,
                column: "Joined",
                value: new DateTime(2022, 1, 8, 20, 40, 23, 905, DateTimeKind.Local).AddTicks(7690));

            migrationBuilder.UpdateData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 2,
                column: "Joined",
                value: new DateTime(2022, 1, 8, 20, 40, 23, 906, DateTimeKind.Local).AddTicks(200));

            migrationBuilder.UpdateData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 3,
                column: "Joined",
                value: new DateTime(2022, 1, 8, 20, 40, 23, 906, DateTimeKind.Local).AddTicks(820));

            migrationBuilder.UpdateData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 4,
                column: "Joined",
                value: new DateTime(2022, 1, 8, 20, 40, 23, 906, DateTimeKind.Local).AddTicks(890));

            migrationBuilder.UpdateData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 5,
                column: "Joined",
                value: new DateTime(2022, 1, 8, 20, 40, 23, 906, DateTimeKind.Local).AddTicks(910));

            migrationBuilder.UpdateData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 6,
                column: "Joined",
                value: new DateTime(2022, 1, 8, 20, 40, 23, 906, DateTimeKind.Local).AddTicks(920));

            migrationBuilder.UpdateData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 7,
                column: "Joined",
                value: new DateTime(2022, 1, 8, 20, 40, 23, 906, DateTimeKind.Local).AddTicks(930));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 1,
                column: "DateFounded",
                value: new DateTime(2022, 1, 8, 20, 40, 23, 877, DateTimeKind.Local).AddTicks(1270));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 2,
                column: "DateFounded",
                value: new DateTime(2022, 1, 8, 20, 40, 23, 903, DateTimeKind.Local).AddTicks(6370));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 3,
                column: "DateFounded",
                value: new DateTime(2022, 1, 8, 20, 40, 23, 903, DateTimeKind.Local).AddTicks(7360));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 4,
                column: "DateFounded",
                value: new DateTime(2022, 1, 8, 20, 40, 23, 903, DateTimeKind.Local).AddTicks(7430));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 5,
                column: "DateFounded",
                value: new DateTime(2022, 1, 8, 20, 40, 23, 903, DateTimeKind.Local).AddTicks(7440));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 6,
                column: "DateFounded",
                value: new DateTime(2022, 1, 8, 20, 40, 23, 903, DateTimeKind.Local).AddTicks(7450));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 7,
                column: "DateFounded",
                value: new DateTime(2022, 1, 8, 20, 40, 23, 903, DateTimeKind.Local).AddTicks(7470));
        }
    }
}
