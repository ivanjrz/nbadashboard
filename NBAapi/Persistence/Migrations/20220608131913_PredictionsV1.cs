using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    public partial class PredictionsV1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SinglePrediction_SeriesPredictionSummary_SeriesPredictionSummaryId",
                table: "SinglePrediction");

            migrationBuilder.AlterColumn<int>(
                name: "SeriesPredictionSummaryId",
                table: "SinglePrediction",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 1,
                column: "Joined",
                value: new DateTime(2022, 6, 8, 6, 19, 9, 952, DateTimeKind.Local).AddTicks(5970));

            migrationBuilder.UpdateData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 2,
                column: "Joined",
                value: new DateTime(2022, 6, 8, 6, 19, 9, 952, DateTimeKind.Local).AddTicks(6150));

            migrationBuilder.UpdateData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 3,
                column: "Joined",
                value: new DateTime(2022, 6, 8, 6, 19, 9, 952, DateTimeKind.Local).AddTicks(6160));

            migrationBuilder.UpdateData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 4,
                column: "Joined",
                value: new DateTime(2022, 6, 8, 6, 19, 9, 952, DateTimeKind.Local).AddTicks(6170));

            migrationBuilder.UpdateData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 5,
                column: "Joined",
                value: new DateTime(2022, 6, 8, 6, 19, 9, 952, DateTimeKind.Local).AddTicks(6190));

            migrationBuilder.UpdateData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 6,
                column: "Joined",
                value: new DateTime(2022, 6, 8, 6, 19, 9, 952, DateTimeKind.Local).AddTicks(6200));

            migrationBuilder.UpdateData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 7,
                column: "Joined",
                value: new DateTime(2022, 6, 8, 6, 19, 9, 952, DateTimeKind.Local).AddTicks(6210));

            migrationBuilder.UpdateData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 8,
                column: "Joined",
                value: new DateTime(2022, 6, 8, 6, 19, 9, 952, DateTimeKind.Local).AddTicks(6230));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 1,
                column: "DateFounded",
                value: new DateTime(2022, 6, 8, 6, 19, 9, 952, DateTimeKind.Local).AddTicks(1880));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 2,
                column: "DateFounded",
                value: new DateTime(2022, 6, 8, 6, 19, 9, 952, DateTimeKind.Local).AddTicks(2890));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 3,
                column: "DateFounded",
                value: new DateTime(2022, 6, 8, 6, 19, 9, 952, DateTimeKind.Local).AddTicks(2910));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 4,
                column: "DateFounded",
                value: new DateTime(2022, 6, 8, 6, 19, 9, 952, DateTimeKind.Local).AddTicks(2950));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 5,
                column: "DateFounded",
                value: new DateTime(2022, 6, 8, 6, 19, 9, 952, DateTimeKind.Local).AddTicks(2960));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 6,
                column: "DateFounded",
                value: new DateTime(2022, 6, 8, 6, 19, 9, 952, DateTimeKind.Local).AddTicks(2990));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 7,
                column: "DateFounded",
                value: new DateTime(2022, 6, 8, 6, 19, 9, 952, DateTimeKind.Local).AddTicks(3000));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 8,
                column: "DateFounded",
                value: new DateTime(2022, 6, 8, 6, 19, 9, 952, DateTimeKind.Local).AddTicks(3010));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 9,
                column: "DateFounded",
                value: new DateTime(2022, 6, 8, 6, 19, 9, 952, DateTimeKind.Local).AddTicks(3030));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 10,
                column: "DateFounded",
                value: new DateTime(2022, 6, 8, 6, 19, 9, 952, DateTimeKind.Local).AddTicks(3040));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 11,
                column: "DateFounded",
                value: new DateTime(2022, 6, 8, 6, 19, 9, 952, DateTimeKind.Local).AddTicks(3070));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 12,
                column: "DateFounded",
                value: new DateTime(2022, 6, 8, 6, 19, 9, 952, DateTimeKind.Local).AddTicks(3100));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 13,
                column: "DateFounded",
                value: new DateTime(2022, 6, 8, 6, 19, 9, 952, DateTimeKind.Local).AddTicks(3110));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 14,
                column: "DateFounded",
                value: new DateTime(2022, 6, 8, 6, 19, 9, 952, DateTimeKind.Local).AddTicks(3200));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 15,
                column: "DateFounded",
                value: new DateTime(2022, 6, 8, 6, 19, 9, 952, DateTimeKind.Local).AddTicks(3220));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 16,
                column: "DateFounded",
                value: new DateTime(2022, 6, 8, 6, 19, 9, 952, DateTimeKind.Local).AddTicks(3250));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 17,
                column: "DateFounded",
                value: new DateTime(2022, 6, 8, 6, 19, 9, 952, DateTimeKind.Local).AddTicks(3260));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 18,
                column: "DateFounded",
                value: new DateTime(2022, 6, 8, 6, 19, 9, 952, DateTimeKind.Local).AddTicks(3280));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 19,
                column: "DateFounded",
                value: new DateTime(2022, 6, 8, 6, 19, 9, 952, DateTimeKind.Local).AddTicks(3300));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 20,
                column: "DateFounded",
                value: new DateTime(2022, 6, 8, 6, 19, 9, 952, DateTimeKind.Local).AddTicks(3310));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 21,
                column: "DateFounded",
                value: new DateTime(2022, 6, 8, 6, 19, 9, 952, DateTimeKind.Local).AddTicks(3330));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 22,
                column: "DateFounded",
                value: new DateTime(2022, 6, 8, 6, 19, 9, 952, DateTimeKind.Local).AddTicks(3340));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 23,
                column: "DateFounded",
                value: new DateTime(2022, 6, 8, 6, 19, 9, 952, DateTimeKind.Local).AddTicks(3350));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 24,
                column: "DateFounded",
                value: new DateTime(2022, 6, 8, 6, 19, 9, 952, DateTimeKind.Local).AddTicks(3360));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 25,
                column: "DateFounded",
                value: new DateTime(2022, 6, 8, 6, 19, 9, 952, DateTimeKind.Local).AddTicks(3380));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 26,
                column: "DateFounded",
                value: new DateTime(2022, 6, 8, 6, 19, 9, 952, DateTimeKind.Local).AddTicks(3390));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 27,
                column: "DateFounded",
                value: new DateTime(2022, 6, 8, 6, 19, 9, 952, DateTimeKind.Local).AddTicks(3400));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 28,
                column: "DateFounded",
                value: new DateTime(2022, 6, 8, 6, 19, 9, 952, DateTimeKind.Local).AddTicks(3410));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 29,
                column: "DateFounded",
                value: new DateTime(2022, 6, 8, 6, 19, 9, 952, DateTimeKind.Local).AddTicks(3430));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 30,
                column: "DateFounded",
                value: new DateTime(2022, 6, 8, 6, 19, 9, 952, DateTimeKind.Local).AddTicks(3440));

            migrationBuilder.AddForeignKey(
                name: "FK_SinglePrediction_SeriesPredictionSummary_SeriesPredictionSummaryId",
                table: "SinglePrediction",
                column: "SeriesPredictionSummaryId",
                principalTable: "SeriesPredictionSummary",
                principalColumn: "SeriesPredictionSummaryId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SinglePrediction_SeriesPredictionSummary_SeriesPredictionSummaryId",
                table: "SinglePrediction");

            migrationBuilder.AlterColumn<int>(
                name: "SeriesPredictionSummaryId",
                table: "SinglePrediction",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.UpdateData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 1,
                column: "Joined",
                value: new DateTime(2022, 6, 7, 0, 4, 8, 473, DateTimeKind.Local).AddTicks(1330));

            migrationBuilder.UpdateData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 2,
                column: "Joined",
                value: new DateTime(2022, 6, 7, 0, 4, 8, 473, DateTimeKind.Local).AddTicks(1550));

            migrationBuilder.UpdateData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 3,
                column: "Joined",
                value: new DateTime(2022, 6, 7, 0, 4, 8, 473, DateTimeKind.Local).AddTicks(1560));

            migrationBuilder.UpdateData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 4,
                column: "Joined",
                value: new DateTime(2022, 6, 7, 0, 4, 8, 473, DateTimeKind.Local).AddTicks(1580));

            migrationBuilder.UpdateData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 5,
                column: "Joined",
                value: new DateTime(2022, 6, 7, 0, 4, 8, 473, DateTimeKind.Local).AddTicks(1590));

            migrationBuilder.UpdateData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 6,
                column: "Joined",
                value: new DateTime(2022, 6, 7, 0, 4, 8, 473, DateTimeKind.Local).AddTicks(1600));

            migrationBuilder.UpdateData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 7,
                column: "Joined",
                value: new DateTime(2022, 6, 7, 0, 4, 8, 473, DateTimeKind.Local).AddTicks(1610));

            migrationBuilder.UpdateData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 8,
                column: "Joined",
                value: new DateTime(2022, 6, 7, 0, 4, 8, 473, DateTimeKind.Local).AddTicks(1620));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 1,
                column: "DateFounded",
                value: new DateTime(2022, 6, 7, 0, 4, 8, 472, DateTimeKind.Local).AddTicks(4860));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 2,
                column: "DateFounded",
                value: new DateTime(2022, 6, 7, 0, 4, 8, 472, DateTimeKind.Local).AddTicks(7940));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 3,
                column: "DateFounded",
                value: new DateTime(2022, 6, 7, 0, 4, 8, 472, DateTimeKind.Local).AddTicks(7970));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 4,
                column: "DateFounded",
                value: new DateTime(2022, 6, 7, 0, 4, 8, 472, DateTimeKind.Local).AddTicks(8030));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 5,
                column: "DateFounded",
                value: new DateTime(2022, 6, 7, 0, 4, 8, 472, DateTimeKind.Local).AddTicks(8040));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 6,
                column: "DateFounded",
                value: new DateTime(2022, 6, 7, 0, 4, 8, 472, DateTimeKind.Local).AddTicks(8080));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 7,
                column: "DateFounded",
                value: new DateTime(2022, 6, 7, 0, 4, 8, 472, DateTimeKind.Local).AddTicks(8090));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 8,
                column: "DateFounded",
                value: new DateTime(2022, 6, 7, 0, 4, 8, 472, DateTimeKind.Local).AddTicks(8100));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 9,
                column: "DateFounded",
                value: new DateTime(2022, 6, 7, 0, 4, 8, 472, DateTimeKind.Local).AddTicks(8120));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 10,
                column: "DateFounded",
                value: new DateTime(2022, 6, 7, 0, 4, 8, 472, DateTimeKind.Local).AddTicks(8130));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 11,
                column: "DateFounded",
                value: new DateTime(2022, 6, 7, 0, 4, 8, 472, DateTimeKind.Local).AddTicks(8180));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 12,
                column: "DateFounded",
                value: new DateTime(2022, 6, 7, 0, 4, 8, 472, DateTimeKind.Local).AddTicks(8210));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 13,
                column: "DateFounded",
                value: new DateTime(2022, 6, 7, 0, 4, 8, 472, DateTimeKind.Local).AddTicks(8230));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 14,
                column: "DateFounded",
                value: new DateTime(2022, 6, 7, 0, 4, 8, 472, DateTimeKind.Local).AddTicks(8300));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 15,
                column: "DateFounded",
                value: new DateTime(2022, 6, 7, 0, 4, 8, 472, DateTimeKind.Local).AddTicks(8330));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 16,
                column: "DateFounded",
                value: new DateTime(2022, 6, 7, 0, 4, 8, 472, DateTimeKind.Local).AddTicks(8370));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 17,
                column: "DateFounded",
                value: new DateTime(2022, 6, 7, 0, 4, 8, 472, DateTimeKind.Local).AddTicks(8380));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 18,
                column: "DateFounded",
                value: new DateTime(2022, 6, 7, 0, 4, 8, 472, DateTimeKind.Local).AddTicks(8400));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 19,
                column: "DateFounded",
                value: new DateTime(2022, 6, 7, 0, 4, 8, 472, DateTimeKind.Local).AddTicks(8420));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 20,
                column: "DateFounded",
                value: new DateTime(2022, 6, 7, 0, 4, 8, 472, DateTimeKind.Local).AddTicks(8440));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 21,
                column: "DateFounded",
                value: new DateTime(2022, 6, 7, 0, 4, 8, 472, DateTimeKind.Local).AddTicks(8450));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 22,
                column: "DateFounded",
                value: new DateTime(2022, 6, 7, 0, 4, 8, 472, DateTimeKind.Local).AddTicks(8460));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 23,
                column: "DateFounded",
                value: new DateTime(2022, 6, 7, 0, 4, 8, 472, DateTimeKind.Local).AddTicks(8470));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 24,
                column: "DateFounded",
                value: new DateTime(2022, 6, 7, 0, 4, 8, 472, DateTimeKind.Local).AddTicks(8490));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 25,
                column: "DateFounded",
                value: new DateTime(2022, 6, 7, 0, 4, 8, 472, DateTimeKind.Local).AddTicks(8500));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 26,
                column: "DateFounded",
                value: new DateTime(2022, 6, 7, 0, 4, 8, 472, DateTimeKind.Local).AddTicks(8510));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 27,
                column: "DateFounded",
                value: new DateTime(2022, 6, 7, 0, 4, 8, 472, DateTimeKind.Local).AddTicks(8520));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 28,
                column: "DateFounded",
                value: new DateTime(2022, 6, 7, 0, 4, 8, 472, DateTimeKind.Local).AddTicks(8540));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 29,
                column: "DateFounded",
                value: new DateTime(2022, 6, 7, 0, 4, 8, 472, DateTimeKind.Local).AddTicks(8590));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 30,
                column: "DateFounded",
                value: new DateTime(2022, 6, 7, 0, 4, 8, 472, DateTimeKind.Local).AddTicks(8610));

            migrationBuilder.AddForeignKey(
                name: "FK_SinglePrediction_SeriesPredictionSummary_SeriesPredictionSummaryId",
                table: "SinglePrediction",
                column: "SeriesPredictionSummaryId",
                principalTable: "SeriesPredictionSummary",
                principalColumn: "SeriesPredictionSummaryId");
        }
    }
}
