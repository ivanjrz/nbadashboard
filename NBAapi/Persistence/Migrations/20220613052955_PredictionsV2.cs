using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    public partial class PredictionsV2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 1,
                column: "Joined",
                value: new DateTime(2022, 6, 12, 22, 29, 51, 61, DateTimeKind.Local).AddTicks(3120));

            migrationBuilder.UpdateData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 2,
                column: "Joined",
                value: new DateTime(2022, 6, 12, 22, 29, 51, 61, DateTimeKind.Local).AddTicks(3280));

            migrationBuilder.UpdateData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 3,
                column: "Joined",
                value: new DateTime(2022, 6, 12, 22, 29, 51, 61, DateTimeKind.Local).AddTicks(3290));

            migrationBuilder.UpdateData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 4,
                column: "Joined",
                value: new DateTime(2022, 6, 12, 22, 29, 51, 61, DateTimeKind.Local).AddTicks(3300));

            migrationBuilder.UpdateData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 5,
                column: "Joined",
                value: new DateTime(2022, 6, 12, 22, 29, 51, 61, DateTimeKind.Local).AddTicks(3310));

            migrationBuilder.UpdateData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 6,
                column: "Joined",
                value: new DateTime(2022, 6, 12, 22, 29, 51, 61, DateTimeKind.Local).AddTicks(3320));

            migrationBuilder.UpdateData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 7,
                column: "Joined",
                value: new DateTime(2022, 6, 12, 22, 29, 51, 61, DateTimeKind.Local).AddTicks(3340));

            migrationBuilder.UpdateData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 8,
                column: "Joined",
                value: new DateTime(2022, 6, 12, 22, 29, 51, 61, DateTimeKind.Local).AddTicks(3350));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 1,
                column: "DateFounded",
                value: new DateTime(2022, 6, 12, 22, 29, 51, 61, DateTimeKind.Local).AddTicks(770));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 2,
                column: "DateFounded",
                value: new DateTime(2022, 6, 12, 22, 29, 51, 61, DateTimeKind.Local).AddTicks(1770));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 3,
                column: "DateFounded",
                value: new DateTime(2022, 6, 12, 22, 29, 51, 61, DateTimeKind.Local).AddTicks(1790));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 4,
                column: "DateFounded",
                value: new DateTime(2022, 6, 12, 22, 29, 51, 61, DateTimeKind.Local).AddTicks(1800));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 5,
                column: "DateFounded",
                value: new DateTime(2022, 6, 12, 22, 29, 51, 61, DateTimeKind.Local).AddTicks(1820));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 6,
                column: "DateFounded",
                value: new DateTime(2022, 6, 12, 22, 29, 51, 61, DateTimeKind.Local).AddTicks(1830));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 7,
                column: "DateFounded",
                value: new DateTime(2022, 6, 12, 22, 29, 51, 61, DateTimeKind.Local).AddTicks(1840));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 8,
                column: "DateFounded",
                value: new DateTime(2022, 6, 12, 22, 29, 51, 61, DateTimeKind.Local).AddTicks(1860));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 9,
                column: "DateFounded",
                value: new DateTime(2022, 6, 12, 22, 29, 51, 61, DateTimeKind.Local).AddTicks(1870));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 10,
                column: "DateFounded",
                value: new DateTime(2022, 6, 12, 22, 29, 51, 61, DateTimeKind.Local).AddTicks(1880));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 11,
                column: "DateFounded",
                value: new DateTime(2022, 6, 12, 22, 29, 51, 61, DateTimeKind.Local).AddTicks(2010));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 12,
                column: "DateFounded",
                value: new DateTime(2022, 6, 12, 22, 29, 51, 61, DateTimeKind.Local).AddTicks(2020));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 13,
                column: "DateFounded",
                value: new DateTime(2022, 6, 12, 22, 29, 51, 61, DateTimeKind.Local).AddTicks(2030));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 14,
                column: "DateFounded",
                value: new DateTime(2022, 6, 12, 22, 29, 51, 61, DateTimeKind.Local).AddTicks(2100));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 15,
                column: "DateFounded",
                value: new DateTime(2022, 6, 12, 22, 29, 51, 61, DateTimeKind.Local).AddTicks(2120));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 16,
                column: "DateFounded",
                value: new DateTime(2022, 6, 12, 22, 29, 51, 61, DateTimeKind.Local).AddTicks(2130));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 17,
                column: "DateFounded",
                value: new DateTime(2022, 6, 12, 22, 29, 51, 61, DateTimeKind.Local).AddTicks(2140));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 18,
                column: "DateFounded",
                value: new DateTime(2022, 6, 12, 22, 29, 51, 61, DateTimeKind.Local).AddTicks(2160));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 19,
                column: "DateFounded",
                value: new DateTime(2022, 6, 12, 22, 29, 51, 61, DateTimeKind.Local).AddTicks(2170));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 20,
                column: "DateFounded",
                value: new DateTime(2022, 6, 12, 22, 29, 51, 61, DateTimeKind.Local).AddTicks(2180));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 21,
                column: "DateFounded",
                value: new DateTime(2022, 6, 12, 22, 29, 51, 61, DateTimeKind.Local).AddTicks(2200));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 22,
                column: "DateFounded",
                value: new DateTime(2022, 6, 12, 22, 29, 51, 61, DateTimeKind.Local).AddTicks(2210));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 23,
                column: "DateFounded",
                value: new DateTime(2022, 6, 12, 22, 29, 51, 61, DateTimeKind.Local).AddTicks(2220));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 24,
                column: "DateFounded",
                value: new DateTime(2022, 6, 12, 22, 29, 51, 61, DateTimeKind.Local).AddTicks(2230));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 25,
                column: "DateFounded",
                value: new DateTime(2022, 6, 12, 22, 29, 51, 61, DateTimeKind.Local).AddTicks(2250));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 26,
                column: "DateFounded",
                value: new DateTime(2022, 6, 12, 22, 29, 51, 61, DateTimeKind.Local).AddTicks(2260));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 27,
                column: "DateFounded",
                value: new DateTime(2022, 6, 12, 22, 29, 51, 61, DateTimeKind.Local).AddTicks(2280));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 28,
                column: "DateFounded",
                value: new DateTime(2022, 6, 12, 22, 29, 51, 61, DateTimeKind.Local).AddTicks(2290));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 29,
                column: "DateFounded",
                value: new DateTime(2022, 6, 12, 22, 29, 51, 61, DateTimeKind.Local).AddTicks(2300));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 30,
                column: "DateFounded",
                value: new DateTime(2022, 6, 12, 22, 29, 51, 61, DateTimeKind.Local).AddTicks(2310));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
        }
    }
}
