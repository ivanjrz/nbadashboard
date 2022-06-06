using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    public partial class AddedPredictionsV2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SeriesPredictionSummary",
                columns: table => new
                {
                    SeriesPredictionSummaryId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DateAdded = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Features = table.Column<int>(type: "INTEGER", nullable: false),
                    Loss = table.Column<double>(type: "REAL", nullable: false),
                    Accuracy = table.Column<double>(type: "REAL", nullable: false),
                    Recall = table.Column<double>(type: "REAL", nullable: false),
                    Optimizer = table.Column<string>(type: "TEXT", nullable: true),
                    Epochs = table.Column<int>(type: "INTEGER", nullable: false),
                    TrainSize = table.Column<int>(type: "INTEGER", nullable: false),
                    TestSize = table.Column<int>(type: "INTEGER", nullable: false),
                    Technique = table.Column<string>(type: "TEXT", nullable: true),
                    Comments = table.Column<string>(type: "TEXT", maxLength: 255, nullable: true),
                    Team = table.Column<string>(type: "TEXT", nullable: true),
                    TeamId = table.Column<int>(type: "INTEGER", nullable: false),
                    NBA_API_TeamId = table.Column<double>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SeriesPredictionSummary", x => x.SeriesPredictionSummaryId);
                });

            migrationBuilder.CreateTable(
                name: "SinglePrediction",
                columns: table => new
                {
                    SinglePredictionId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    TeamId = table.Column<int>(type: "INTEGER", nullable: false),
                    NBA_API_PlayerId = table.Column<double>(type: "REAL", nullable: false),
                    Win = table.Column<int>(type: "INTEGER", nullable: false),
                    SeriesPredictionSummaryId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SinglePrediction", x => x.SinglePredictionId);
                    table.ForeignKey(
                        name: "FK_SinglePrediction_SeriesPredictionSummary_SeriesPredictionSummaryId",
                        column: x => x.SeriesPredictionSummaryId,
                        principalTable: "SeriesPredictionSummary",
                        principalColumn: "SeriesPredictionSummaryId");
                });

            migrationBuilder.UpdateData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 1,
                column: "Joined",
                value: new DateTime(2022, 6, 4, 22, 13, 34, 268, DateTimeKind.Local).AddTicks(2730));

            migrationBuilder.UpdateData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 2,
                column: "Joined",
                value: new DateTime(2022, 6, 4, 22, 13, 34, 268, DateTimeKind.Local).AddTicks(2940));

            migrationBuilder.UpdateData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 3,
                column: "Joined",
                value: new DateTime(2022, 6, 4, 22, 13, 34, 268, DateTimeKind.Local).AddTicks(2950));

            migrationBuilder.UpdateData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 4,
                column: "Joined",
                value: new DateTime(2022, 6, 4, 22, 13, 34, 268, DateTimeKind.Local).AddTicks(2960));

            migrationBuilder.UpdateData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 5,
                column: "Joined",
                value: new DateTime(2022, 6, 4, 22, 13, 34, 268, DateTimeKind.Local).AddTicks(2980));

            migrationBuilder.UpdateData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 6,
                column: "Joined",
                value: new DateTime(2022, 6, 4, 22, 13, 34, 268, DateTimeKind.Local).AddTicks(2990));

            migrationBuilder.UpdateData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 7,
                column: "Joined",
                value: new DateTime(2022, 6, 4, 22, 13, 34, 268, DateTimeKind.Local).AddTicks(3000));

            migrationBuilder.UpdateData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 8,
                column: "Joined",
                value: new DateTime(2022, 6, 4, 22, 13, 34, 268, DateTimeKind.Local).AddTicks(3010));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 1,
                column: "DateFounded",
                value: new DateTime(2022, 6, 4, 22, 13, 34, 267, DateTimeKind.Local).AddTicks(7480));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 2,
                column: "DateFounded",
                value: new DateTime(2022, 6, 4, 22, 13, 34, 268, DateTimeKind.Local).AddTicks(80));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 3,
                column: "DateFounded",
                value: new DateTime(2022, 6, 4, 22, 13, 34, 268, DateTimeKind.Local).AddTicks(100));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 4,
                column: "DateFounded",
                value: new DateTime(2022, 6, 4, 22, 13, 34, 268, DateTimeKind.Local).AddTicks(140));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 5,
                column: "DateFounded",
                value: new DateTime(2022, 6, 4, 22, 13, 34, 268, DateTimeKind.Local).AddTicks(210));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 6,
                column: "DateFounded",
                value: new DateTime(2022, 6, 4, 22, 13, 34, 268, DateTimeKind.Local).AddTicks(230));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 7,
                column: "DateFounded",
                value: new DateTime(2022, 6, 4, 22, 13, 34, 268, DateTimeKind.Local).AddTicks(240));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 8,
                column: "DateFounded",
                value: new DateTime(2022, 6, 4, 22, 13, 34, 268, DateTimeKind.Local).AddTicks(260));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 9,
                column: "DateFounded",
                value: new DateTime(2022, 6, 4, 22, 13, 34, 268, DateTimeKind.Local).AddTicks(270));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 10,
                column: "DateFounded",
                value: new DateTime(2022, 6, 4, 22, 13, 34, 268, DateTimeKind.Local).AddTicks(280));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 11,
                column: "DateFounded",
                value: new DateTime(2022, 6, 4, 22, 13, 34, 268, DateTimeKind.Local).AddTicks(320));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 12,
                column: "DateFounded",
                value: new DateTime(2022, 6, 4, 22, 13, 34, 268, DateTimeKind.Local).AddTicks(340));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 13,
                column: "DateFounded",
                value: new DateTime(2022, 6, 4, 22, 13, 34, 268, DateTimeKind.Local).AddTicks(350));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 14,
                column: "DateFounded",
                value: new DateTime(2022, 6, 4, 22, 13, 34, 268, DateTimeKind.Local).AddTicks(360));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 15,
                column: "DateFounded",
                value: new DateTime(2022, 6, 4, 22, 13, 34, 268, DateTimeKind.Local).AddTicks(380));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 16,
                column: "DateFounded",
                value: new DateTime(2022, 6, 4, 22, 13, 34, 268, DateTimeKind.Local).AddTicks(410));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 17,
                column: "DateFounded",
                value: new DateTime(2022, 6, 4, 22, 13, 34, 268, DateTimeKind.Local).AddTicks(420));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 18,
                column: "DateFounded",
                value: new DateTime(2022, 6, 4, 22, 13, 34, 268, DateTimeKind.Local).AddTicks(440));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 19,
                column: "DateFounded",
                value: new DateTime(2022, 6, 4, 22, 13, 34, 268, DateTimeKind.Local).AddTicks(460));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 20,
                column: "DateFounded",
                value: new DateTime(2022, 6, 4, 22, 13, 34, 268, DateTimeKind.Local).AddTicks(470));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 21,
                column: "DateFounded",
                value: new DateTime(2022, 6, 4, 22, 13, 34, 268, DateTimeKind.Local).AddTicks(490));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 22,
                column: "DateFounded",
                value: new DateTime(2022, 6, 4, 22, 13, 34, 268, DateTimeKind.Local).AddTicks(500));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 23,
                column: "DateFounded",
                value: new DateTime(2022, 6, 4, 22, 13, 34, 268, DateTimeKind.Local).AddTicks(510));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 24,
                column: "DateFounded",
                value: new DateTime(2022, 6, 4, 22, 13, 34, 268, DateTimeKind.Local).AddTicks(530));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 25,
                column: "DateFounded",
                value: new DateTime(2022, 6, 4, 22, 13, 34, 268, DateTimeKind.Local).AddTicks(540));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 26,
                column: "DateFounded",
                value: new DateTime(2022, 6, 4, 22, 13, 34, 268, DateTimeKind.Local).AddTicks(550));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 27,
                column: "DateFounded",
                value: new DateTime(2022, 6, 4, 22, 13, 34, 268, DateTimeKind.Local).AddTicks(560));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 28,
                column: "DateFounded",
                value: new DateTime(2022, 6, 4, 22, 13, 34, 268, DateTimeKind.Local).AddTicks(570));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 29,
                column: "DateFounded",
                value: new DateTime(2022, 6, 4, 22, 13, 34, 268, DateTimeKind.Local).AddTicks(600));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 30,
                column: "DateFounded",
                value: new DateTime(2022, 6, 4, 22, 13, 34, 268, DateTimeKind.Local).AddTicks(610));

            migrationBuilder.CreateIndex(
                name: "IX_SinglePrediction_SeriesPredictionSummaryId",
                table: "SinglePrediction",
                column: "SeriesPredictionSummaryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SinglePrediction");

            migrationBuilder.DropTable(
                name: "SeriesPredictionSummary");

            migrationBuilder.UpdateData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 1,
                column: "Joined",
                value: new DateTime(2022, 6, 4, 21, 43, 51, 404, DateTimeKind.Local).AddTicks(2840));

            migrationBuilder.UpdateData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 2,
                column: "Joined",
                value: new DateTime(2022, 6, 4, 21, 43, 51, 404, DateTimeKind.Local).AddTicks(3000));

            migrationBuilder.UpdateData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 3,
                column: "Joined",
                value: new DateTime(2022, 6, 4, 21, 43, 51, 404, DateTimeKind.Local).AddTicks(3020));

            migrationBuilder.UpdateData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 4,
                column: "Joined",
                value: new DateTime(2022, 6, 4, 21, 43, 51, 404, DateTimeKind.Local).AddTicks(3030));

            migrationBuilder.UpdateData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 5,
                column: "Joined",
                value: new DateTime(2022, 6, 4, 21, 43, 51, 404, DateTimeKind.Local).AddTicks(3040));

            migrationBuilder.UpdateData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 6,
                column: "Joined",
                value: new DateTime(2022, 6, 4, 21, 43, 51, 404, DateTimeKind.Local).AddTicks(3050));

            migrationBuilder.UpdateData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 7,
                column: "Joined",
                value: new DateTime(2022, 6, 4, 21, 43, 51, 404, DateTimeKind.Local).AddTicks(3060));

            migrationBuilder.UpdateData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 8,
                column: "Joined",
                value: new DateTime(2022, 6, 4, 21, 43, 51, 404, DateTimeKind.Local).AddTicks(3070));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 1,
                column: "DateFounded",
                value: new DateTime(2022, 6, 4, 21, 43, 51, 404, DateTimeKind.Local).AddTicks(830));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 2,
                column: "DateFounded",
                value: new DateTime(2022, 6, 4, 21, 43, 51, 404, DateTimeKind.Local).AddTicks(1740));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 3,
                column: "DateFounded",
                value: new DateTime(2022, 6, 4, 21, 43, 51, 404, DateTimeKind.Local).AddTicks(1760));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 4,
                column: "DateFounded",
                value: new DateTime(2022, 6, 4, 21, 43, 51, 404, DateTimeKind.Local).AddTicks(1780));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 5,
                column: "DateFounded",
                value: new DateTime(2022, 6, 4, 21, 43, 51, 404, DateTimeKind.Local).AddTicks(1790));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 6,
                column: "DateFounded",
                value: new DateTime(2022, 6, 4, 21, 43, 51, 404, DateTimeKind.Local).AddTicks(1800));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 7,
                column: "DateFounded",
                value: new DateTime(2022, 6, 4, 21, 43, 51, 404, DateTimeKind.Local).AddTicks(1820));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 8,
                column: "DateFounded",
                value: new DateTime(2022, 6, 4, 21, 43, 51, 404, DateTimeKind.Local).AddTicks(1830));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 9,
                column: "DateFounded",
                value: new DateTime(2022, 6, 4, 21, 43, 51, 404, DateTimeKind.Local).AddTicks(1840));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 10,
                column: "DateFounded",
                value: new DateTime(2022, 6, 4, 21, 43, 51, 404, DateTimeKind.Local).AddTicks(1850));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 11,
                column: "DateFounded",
                value: new DateTime(2022, 6, 4, 21, 43, 51, 404, DateTimeKind.Local).AddTicks(1870));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 12,
                column: "DateFounded",
                value: new DateTime(2022, 6, 4, 21, 43, 51, 404, DateTimeKind.Local).AddTicks(1880));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 13,
                column: "DateFounded",
                value: new DateTime(2022, 6, 4, 21, 43, 51, 404, DateTimeKind.Local).AddTicks(1890));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 14,
                column: "DateFounded",
                value: new DateTime(2022, 6, 4, 21, 43, 51, 404, DateTimeKind.Local).AddTicks(1910));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 15,
                column: "DateFounded",
                value: new DateTime(2022, 6, 4, 21, 43, 51, 404, DateTimeKind.Local).AddTicks(1920));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 16,
                column: "DateFounded",
                value: new DateTime(2022, 6, 4, 21, 43, 51, 404, DateTimeKind.Local).AddTicks(1930));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 17,
                column: "DateFounded",
                value: new DateTime(2022, 6, 4, 21, 43, 51, 404, DateTimeKind.Local).AddTicks(1940));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 18,
                column: "DateFounded",
                value: new DateTime(2022, 6, 4, 21, 43, 51, 404, DateTimeKind.Local).AddTicks(1960));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 19,
                column: "DateFounded",
                value: new DateTime(2022, 6, 4, 21, 43, 51, 404, DateTimeKind.Local).AddTicks(1970));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 20,
                column: "DateFounded",
                value: new DateTime(2022, 6, 4, 21, 43, 51, 404, DateTimeKind.Local).AddTicks(1980));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 21,
                column: "DateFounded",
                value: new DateTime(2022, 6, 4, 21, 43, 51, 404, DateTimeKind.Local).AddTicks(1990));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 22,
                column: "DateFounded",
                value: new DateTime(2022, 6, 4, 21, 43, 51, 404, DateTimeKind.Local).AddTicks(2000));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 23,
                column: "DateFounded",
                value: new DateTime(2022, 6, 4, 21, 43, 51, 404, DateTimeKind.Local).AddTicks(2010));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 24,
                column: "DateFounded",
                value: new DateTime(2022, 6, 4, 21, 43, 51, 404, DateTimeKind.Local).AddTicks(2030));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 25,
                column: "DateFounded",
                value: new DateTime(2022, 6, 4, 21, 43, 51, 404, DateTimeKind.Local).AddTicks(2040));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 26,
                column: "DateFounded",
                value: new DateTime(2022, 6, 4, 21, 43, 51, 404, DateTimeKind.Local).AddTicks(2060));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 27,
                column: "DateFounded",
                value: new DateTime(2022, 6, 4, 21, 43, 51, 404, DateTimeKind.Local).AddTicks(2070));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 28,
                column: "DateFounded",
                value: new DateTime(2022, 6, 4, 21, 43, 51, 404, DateTimeKind.Local).AddTicks(2080));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 29,
                column: "DateFounded",
                value: new DateTime(2022, 6, 4, 21, 43, 51, 404, DateTimeKind.Local).AddTicks(2100));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 30,
                column: "DateFounded",
                value: new DateTime(2022, 6, 4, 21, 43, 51, 404, DateTimeKind.Local).AddTicks(2110));
        }
    }
}
