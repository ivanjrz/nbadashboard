using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    public partial class TeamHistory_DRB_update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DRB",
                table: "TeamHistory",
                newName: "RDB");

            migrationBuilder.UpdateData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 1,
                column: "Joined",
                value: new DateTime(2022, 5, 27, 0, 37, 2, 77, DateTimeKind.Local).AddTicks(50));

            migrationBuilder.UpdateData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 2,
                column: "Joined",
                value: new DateTime(2022, 5, 27, 0, 37, 2, 77, DateTimeKind.Local).AddTicks(220));

            migrationBuilder.UpdateData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 3,
                column: "Joined",
                value: new DateTime(2022, 5, 27, 0, 37, 2, 77, DateTimeKind.Local).AddTicks(230));

            migrationBuilder.UpdateData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 4,
                column: "Joined",
                value: new DateTime(2022, 5, 27, 0, 37, 2, 77, DateTimeKind.Local).AddTicks(240));

            migrationBuilder.UpdateData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 5,
                column: "Joined",
                value: new DateTime(2022, 5, 27, 0, 37, 2, 77, DateTimeKind.Local).AddTicks(250));

            migrationBuilder.UpdateData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 6,
                column: "Joined",
                value: new DateTime(2022, 5, 27, 0, 37, 2, 77, DateTimeKind.Local).AddTicks(260));

            migrationBuilder.UpdateData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 7,
                column: "Joined",
                value: new DateTime(2022, 5, 27, 0, 37, 2, 77, DateTimeKind.Local).AddTicks(280));

            migrationBuilder.UpdateData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 8,
                column: "Joined",
                value: new DateTime(2022, 5, 27, 0, 37, 2, 77, DateTimeKind.Local).AddTicks(290));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 1,
                column: "DateFounded",
                value: new DateTime(2022, 5, 27, 0, 37, 2, 76, DateTimeKind.Local).AddTicks(7930));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 2,
                column: "DateFounded",
                value: new DateTime(2022, 5, 27, 0, 37, 2, 76, DateTimeKind.Local).AddTicks(8800));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 3,
                column: "DateFounded",
                value: new DateTime(2022, 5, 27, 0, 37, 2, 76, DateTimeKind.Local).AddTicks(8820));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 4,
                column: "DateFounded",
                value: new DateTime(2022, 5, 27, 0, 37, 2, 76, DateTimeKind.Local).AddTicks(8830));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 5,
                column: "DateFounded",
                value: new DateTime(2022, 5, 27, 0, 37, 2, 76, DateTimeKind.Local).AddTicks(8850));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 6,
                column: "DateFounded",
                value: new DateTime(2022, 5, 27, 0, 37, 2, 76, DateTimeKind.Local).AddTicks(8860));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 7,
                column: "DateFounded",
                value: new DateTime(2022, 5, 27, 0, 37, 2, 76, DateTimeKind.Local).AddTicks(8870));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 8,
                column: "DateFounded",
                value: new DateTime(2022, 5, 27, 0, 37, 2, 76, DateTimeKind.Local).AddTicks(8880));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 9,
                column: "DateFounded",
                value: new DateTime(2022, 5, 27, 0, 37, 2, 76, DateTimeKind.Local).AddTicks(8890));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 10,
                column: "DateFounded",
                value: new DateTime(2022, 5, 27, 0, 37, 2, 76, DateTimeKind.Local).AddTicks(8910));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 11,
                column: "DateFounded",
                value: new DateTime(2022, 5, 27, 0, 37, 2, 76, DateTimeKind.Local).AddTicks(8920));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 12,
                column: "DateFounded",
                value: new DateTime(2022, 5, 27, 0, 37, 2, 76, DateTimeKind.Local).AddTicks(8930));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 13,
                column: "DateFounded",
                value: new DateTime(2022, 5, 27, 0, 37, 2, 76, DateTimeKind.Local).AddTicks(8940));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 14,
                column: "DateFounded",
                value: new DateTime(2022, 5, 27, 0, 37, 2, 76, DateTimeKind.Local).AddTicks(8960));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 15,
                column: "DateFounded",
                value: new DateTime(2022, 5, 27, 0, 37, 2, 76, DateTimeKind.Local).AddTicks(8970));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 16,
                column: "DateFounded",
                value: new DateTime(2022, 5, 27, 0, 37, 2, 76, DateTimeKind.Local).AddTicks(8980));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 17,
                column: "DateFounded",
                value: new DateTime(2022, 5, 27, 0, 37, 2, 76, DateTimeKind.Local).AddTicks(8990));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 18,
                column: "DateFounded",
                value: new DateTime(2022, 5, 27, 0, 37, 2, 76, DateTimeKind.Local).AddTicks(9000));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 19,
                column: "DateFounded",
                value: new DateTime(2022, 5, 27, 0, 37, 2, 76, DateTimeKind.Local).AddTicks(9010));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 20,
                column: "DateFounded",
                value: new DateTime(2022, 5, 27, 0, 37, 2, 76, DateTimeKind.Local).AddTicks(9020));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 21,
                column: "DateFounded",
                value: new DateTime(2022, 5, 27, 0, 37, 2, 76, DateTimeKind.Local).AddTicks(9030));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 22,
                column: "DateFounded",
                value: new DateTime(2022, 5, 27, 0, 37, 2, 76, DateTimeKind.Local).AddTicks(9050));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 23,
                column: "DateFounded",
                value: new DateTime(2022, 5, 27, 0, 37, 2, 76, DateTimeKind.Local).AddTicks(9060));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 24,
                column: "DateFounded",
                value: new DateTime(2022, 5, 27, 0, 37, 2, 76, DateTimeKind.Local).AddTicks(9070));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 25,
                column: "DateFounded",
                value: new DateTime(2022, 5, 27, 0, 37, 2, 76, DateTimeKind.Local).AddTicks(9080));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 26,
                column: "DateFounded",
                value: new DateTime(2022, 5, 27, 0, 37, 2, 76, DateTimeKind.Local).AddTicks(9090));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 27,
                column: "DateFounded",
                value: new DateTime(2022, 5, 27, 0, 37, 2, 76, DateTimeKind.Local).AddTicks(9100));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 28,
                column: "DateFounded",
                value: new DateTime(2022, 5, 27, 0, 37, 2, 76, DateTimeKind.Local).AddTicks(9110));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 29,
                column: "DateFounded",
                value: new DateTime(2022, 5, 27, 0, 37, 2, 76, DateTimeKind.Local).AddTicks(9120));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 30,
                column: "DateFounded",
                value: new DateTime(2022, 5, 27, 0, 37, 2, 76, DateTimeKind.Local).AddTicks(9130));

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 1,
                column: "RDB",
                value: 79.900000000000006);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 2,
                column: "RDB",
                value: 77.700000000000003);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 3,
                column: "RDB",
                value: 76.299999999999997);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 4,
                column: "RDB",
                value: 79.799999999999997);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 5,
                column: "RDB",
                value: 78.599999999999994);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 6,
                column: "RDB",
                value: 78.400000000000006);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 7,
                column: "RDB",
                value: 77.400000000000006);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 8,
                column: "RDB",
                value: 78.599999999999994);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 9,
                column: "RDB",
                value: 79.099999999999994);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 10,
                column: "RDB",
                value: 76.400000000000006);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 11,
                column: "RDB",
                value: 77.5);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 12,
                column: "RDB",
                value: 76.200000000000003);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 13,
                column: "RDB",
                value: 76.700000000000003);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 14,
                column: "RDB",
                value: 77.299999999999997);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 15,
                column: "RDB",
                value: 77.099999999999994);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 16,
                column: "RDB",
                value: 79.0);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 17,
                column: "RDB",
                value: 80.700000000000003);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 18,
                column: "RDB",
                value: 76.099999999999994);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 19,
                column: "RDB",
                value: 78.5);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 20,
                column: "RDB",
                value: 75.900000000000006);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 21,
                column: "RDB",
                value: 77.700000000000003);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 22,
                column: "RDB",
                value: 78.900000000000006);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 23,
                column: "RDB",
                value: 76.700000000000003);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 24,
                column: "RDB",
                value: 77.0);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 25,
                column: "RDB",
                value: 75.599999999999994);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 26,
                column: "RDB",
                value: 76.200000000000003);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 27,
                column: "RDB",
                value: 76.5);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 28,
                column: "RDB",
                value: 80.599999999999994);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 29,
                column: "RDB",
                value: 77.599999999999994);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 30,
                column: "RDB",
                value: 76.5);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 31,
                column: "RDB",
                value: 80.299999999999997);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 32,
                column: "RDB",
                value: 77.099999999999994);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 33,
                column: "RDB",
                value: 77.099999999999994);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 34,
                column: "RDB",
                value: 80.299999999999997);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 35,
                column: "RDB",
                value: 74.400000000000006);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 36,
                column: "RDB",
                value: 77.0);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 37,
                column: "RDB",
                value: 77.900000000000006);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 38,
                column: "RDB",
                value: 78.0);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 39,
                column: "RDB",
                value: 76.200000000000003);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 40,
                column: "RDB",
                value: 78.200000000000003);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 41,
                column: "RDB",
                value: 78.599999999999994);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 42,
                column: "RDB",
                value: 79.400000000000006);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 43,
                column: "RDB",
                value: 76.0);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 44,
                column: "RDB",
                value: 79.700000000000003);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 45,
                column: "RDB",
                value: 76.400000000000006);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 46,
                column: "RDB",
                value: 78.700000000000003);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 47,
                column: "RDB",
                value: 77.599999999999994);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 48,
                column: "RDB",
                value: 75.5);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 49,
                column: "RDB",
                value: 77.099999999999994);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 50,
                column: "RDB",
                value: 76.799999999999997);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 51,
                column: "RDB",
                value: 77.5);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 52,
                column: "RDB",
                value: 74.900000000000006);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 53,
                column: "RDB",
                value: 76.400000000000006);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 54,
                column: "RDB",
                value: 77.599999999999994);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 55,
                column: "RDB",
                value: 74.099999999999994);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 56,
                column: "RDB",
                value: 76.400000000000006);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 57,
                column: "RDB",
                value: 77.299999999999997);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 58,
                column: "RDB",
                value: 76.099999999999994);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 59,
                column: "RDB",
                value: 72.5);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 60,
                column: "RDB",
                value: 77.0);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 61,
                column: "RDB",
                value: 81.599999999999994);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 62,
                column: "RDB",
                value: 77.400000000000006);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 63,
                column: "RDB",
                value: 77.599999999999994);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 64,
                column: "RDB",
                value: 76.700000000000003);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 65,
                column: "RDB",
                value: 78.799999999999997);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 66,
                column: "RDB",
                value: 77.700000000000003);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 67,
                column: "RDB",
                value: 79.5);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 68,
                column: "RDB",
                value: 75.599999999999994);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 69,
                column: "RDB",
                value: 78.900000000000006);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 70,
                column: "RDB",
                value: 80.299999999999997);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 71,
                column: "RDB",
                value: 76.799999999999997);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 72,
                column: "RDB",
                value: 76.700000000000003);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 73,
                column: "RDB",
                value: 76.799999999999997);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 74,
                column: "RDB",
                value: 78.799999999999997);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 75,
                column: "RDB",
                value: 77.799999999999997);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 76,
                column: "RDB",
                value: 79.099999999999994);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 77,
                column: "RDB",
                value: 79.200000000000003);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 78,
                column: "RDB",
                value: 77.799999999999997);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 79,
                column: "RDB",
                value: 75.299999999999997);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 80,
                column: "RDB",
                value: 77.799999999999997);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 81,
                column: "RDB",
                value: 78.400000000000006);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 82,
                column: "RDB",
                value: 75.599999999999994);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 83,
                column: "RDB",
                value: 75.900000000000006);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 84,
                column: "RDB",
                value: 77.200000000000003);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 85,
                column: "RDB",
                value: 75.299999999999997);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 86,
                column: "RDB",
                value: 78.299999999999997);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 87,
                column: "RDB",
                value: 74.400000000000006);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 88,
                column: "RDB",
                value: 74.900000000000006);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 89,
                column: "RDB",
                value: 77.400000000000006);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 90,
                column: "RDB",
                value: 76.400000000000006);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 91,
                column: "RDB",
                value: 79.299999999999997);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 92,
                column: "RDB",
                value: 79.099999999999994);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 93,
                column: "RDB",
                value: 78.5);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 94,
                column: "RDB",
                value: 79.700000000000003);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 95,
                column: "RDB",
                value: 78.200000000000003);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 96,
                column: "RDB",
                value: 78.900000000000006);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 97,
                column: "RDB",
                value: 77.299999999999997);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 98,
                column: "RDB",
                value: 79.700000000000003);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 99,
                column: "RDB",
                value: 77.799999999999997);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 100,
                column: "RDB",
                value: 78.599999999999994);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 101,
                column: "RDB",
                value: 77.799999999999997);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 102,
                column: "RDB",
                value: 77.5);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 103,
                column: "RDB",
                value: 78.099999999999994);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 104,
                column: "RDB",
                value: 76.599999999999994);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 105,
                column: "RDB",
                value: 78.299999999999997);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 106,
                column: "RDB",
                value: 77.900000000000006);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 107,
                column: "RDB",
                value: 74.900000000000006);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 108,
                column: "RDB",
                value: 80.0);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 109,
                column: "RDB",
                value: 76.299999999999997);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 110,
                column: "RDB",
                value: 80.299999999999997);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 111,
                column: "RDB",
                value: 77.299999999999997);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 112,
                column: "RDB",
                value: 77.599999999999994);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 113,
                column: "RDB",
                value: 75.700000000000003);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 114,
                column: "RDB",
                value: 75.0);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 115,
                column: "RDB",
                value: 76.900000000000006);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 116,
                column: "RDB",
                value: 76.799999999999997);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 117,
                column: "RDB",
                value: 77.099999999999994);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 118,
                column: "RDB",
                value: 76.599999999999994);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 119,
                column: "RDB",
                value: 78.200000000000003);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 120,
                column: "RDB",
                value: 77.900000000000006);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 121,
                column: "RDB",
                value: 77.299999999999997);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 122,
                column: "RDB",
                value: 77.099999999999994);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 123,
                column: "RDB",
                value: 78.299999999999997);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 124,
                column: "RDB",
                value: 77.799999999999997);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 125,
                column: "RDB",
                value: 78.700000000000003);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 126,
                column: "RDB",
                value: 78.0);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 127,
                column: "RDB",
                value: 78.0);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 128,
                column: "RDB",
                value: 78.599999999999994);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 129,
                column: "RDB",
                value: 76.799999999999997);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 130,
                column: "RDB",
                value: 74.900000000000006);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 131,
                column: "RDB",
                value: 78.299999999999997);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 132,
                column: "RDB",
                value: 75.599999999999994);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 133,
                column: "RDB",
                value: 76.5);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 134,
                column: "RDB",
                value: 76.900000000000006);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 135,
                column: "RDB",
                value: 75.099999999999994);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 136,
                column: "RDB",
                value: 74.799999999999997);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 137,
                column: "RDB",
                value: 75.099999999999994);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 138,
                column: "RDB",
                value: 74.400000000000006);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 139,
                column: "RDB",
                value: 78.799999999999997);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 140,
                column: "RDB",
                value: 78.299999999999997);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 141,
                column: "RDB",
                value: 78.200000000000003);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 142,
                column: "RDB",
                value: 75.799999999999997);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 143,
                column: "RDB",
                value: 76.900000000000006);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 144,
                column: "RDB",
                value: 76.200000000000003);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 145,
                column: "RDB",
                value: 76.0);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 146,
                column: "RDB",
                value: 75.599999999999994);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 147,
                column: "RDB",
                value: 77.200000000000003);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 148,
                column: "RDB",
                value: 76.099999999999994);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 149,
                column: "RDB",
                value: 74.400000000000006);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 150,
                column: "RDB",
                value: 76.900000000000006);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "RDB",
                table: "TeamHistory",
                newName: "DRB");

            migrationBuilder.UpdateData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 1,
                column: "Joined",
                value: new DateTime(2022, 5, 24, 23, 14, 22, 405, DateTimeKind.Local).AddTicks(3990));

            migrationBuilder.UpdateData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 2,
                column: "Joined",
                value: new DateTime(2022, 5, 24, 23, 14, 22, 405, DateTimeKind.Local).AddTicks(4140));

            migrationBuilder.UpdateData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 3,
                column: "Joined",
                value: new DateTime(2022, 5, 24, 23, 14, 22, 405, DateTimeKind.Local).AddTicks(4150));

            migrationBuilder.UpdateData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 4,
                column: "Joined",
                value: new DateTime(2022, 5, 24, 23, 14, 22, 405, DateTimeKind.Local).AddTicks(4160));

            migrationBuilder.UpdateData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 5,
                column: "Joined",
                value: new DateTime(2022, 5, 24, 23, 14, 22, 405, DateTimeKind.Local).AddTicks(4170));

            migrationBuilder.UpdateData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 6,
                column: "Joined",
                value: new DateTime(2022, 5, 24, 23, 14, 22, 405, DateTimeKind.Local).AddTicks(4190));

            migrationBuilder.UpdateData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 7,
                column: "Joined",
                value: new DateTime(2022, 5, 24, 23, 14, 22, 405, DateTimeKind.Local).AddTicks(4200));

            migrationBuilder.UpdateData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 8,
                column: "Joined",
                value: new DateTime(2022, 5, 24, 23, 14, 22, 405, DateTimeKind.Local).AddTicks(4210));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 1,
                column: "DateFounded",
                value: new DateTime(2022, 5, 24, 23, 14, 22, 405, DateTimeKind.Local).AddTicks(2170));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 2,
                column: "DateFounded",
                value: new DateTime(2022, 5, 24, 23, 14, 22, 405, DateTimeKind.Local).AddTicks(2980));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 3,
                column: "DateFounded",
                value: new DateTime(2022, 5, 24, 23, 14, 22, 405, DateTimeKind.Local).AddTicks(3000));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 4,
                column: "DateFounded",
                value: new DateTime(2022, 5, 24, 23, 14, 22, 405, DateTimeKind.Local).AddTicks(3010));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 5,
                column: "DateFounded",
                value: new DateTime(2022, 5, 24, 23, 14, 22, 405, DateTimeKind.Local).AddTicks(3020));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 6,
                column: "DateFounded",
                value: new DateTime(2022, 5, 24, 23, 14, 22, 405, DateTimeKind.Local).AddTicks(3030));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 7,
                column: "DateFounded",
                value: new DateTime(2022, 5, 24, 23, 14, 22, 405, DateTimeKind.Local).AddTicks(3040));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 8,
                column: "DateFounded",
                value: new DateTime(2022, 5, 24, 23, 14, 22, 405, DateTimeKind.Local).AddTicks(3050));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 9,
                column: "DateFounded",
                value: new DateTime(2022, 5, 24, 23, 14, 22, 405, DateTimeKind.Local).AddTicks(3060));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 10,
                column: "DateFounded",
                value: new DateTime(2022, 5, 24, 23, 14, 22, 405, DateTimeKind.Local).AddTicks(3070));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 11,
                column: "DateFounded",
                value: new DateTime(2022, 5, 24, 23, 14, 22, 405, DateTimeKind.Local).AddTicks(3080));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 12,
                column: "DateFounded",
                value: new DateTime(2022, 5, 24, 23, 14, 22, 405, DateTimeKind.Local).AddTicks(3100));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 13,
                column: "DateFounded",
                value: new DateTime(2022, 5, 24, 23, 14, 22, 405, DateTimeKind.Local).AddTicks(3110));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 14,
                column: "DateFounded",
                value: new DateTime(2022, 5, 24, 23, 14, 22, 405, DateTimeKind.Local).AddTicks(3120));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 15,
                column: "DateFounded",
                value: new DateTime(2022, 5, 24, 23, 14, 22, 405, DateTimeKind.Local).AddTicks(3130));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 16,
                column: "DateFounded",
                value: new DateTime(2022, 5, 24, 23, 14, 22, 405, DateTimeKind.Local).AddTicks(3140));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 17,
                column: "DateFounded",
                value: new DateTime(2022, 5, 24, 23, 14, 22, 405, DateTimeKind.Local).AddTicks(3150));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 18,
                column: "DateFounded",
                value: new DateTime(2022, 5, 24, 23, 14, 22, 405, DateTimeKind.Local).AddTicks(3160));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 19,
                column: "DateFounded",
                value: new DateTime(2022, 5, 24, 23, 14, 22, 405, DateTimeKind.Local).AddTicks(3170));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 20,
                column: "DateFounded",
                value: new DateTime(2022, 5, 24, 23, 14, 22, 405, DateTimeKind.Local).AddTicks(3180));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 21,
                column: "DateFounded",
                value: new DateTime(2022, 5, 24, 23, 14, 22, 405, DateTimeKind.Local).AddTicks(3190));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 22,
                column: "DateFounded",
                value: new DateTime(2022, 5, 24, 23, 14, 22, 405, DateTimeKind.Local).AddTicks(3200));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 23,
                column: "DateFounded",
                value: new DateTime(2022, 5, 24, 23, 14, 22, 405, DateTimeKind.Local).AddTicks(3210));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 24,
                column: "DateFounded",
                value: new DateTime(2022, 5, 24, 23, 14, 22, 405, DateTimeKind.Local).AddTicks(3220));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 25,
                column: "DateFounded",
                value: new DateTime(2022, 5, 24, 23, 14, 22, 405, DateTimeKind.Local).AddTicks(3230));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 26,
                column: "DateFounded",
                value: new DateTime(2022, 5, 24, 23, 14, 22, 405, DateTimeKind.Local).AddTicks(3240));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 27,
                column: "DateFounded",
                value: new DateTime(2022, 5, 24, 23, 14, 22, 405, DateTimeKind.Local).AddTicks(3250));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 28,
                column: "DateFounded",
                value: new DateTime(2022, 5, 24, 23, 14, 22, 405, DateTimeKind.Local).AddTicks(3260));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 29,
                column: "DateFounded",
                value: new DateTime(2022, 5, 24, 23, 14, 22, 405, DateTimeKind.Local).AddTicks(3270));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 30,
                column: "DateFounded",
                value: new DateTime(2022, 5, 24, 23, 14, 22, 405, DateTimeKind.Local).AddTicks(3280));

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 1,
                column: "DRB",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 2,
                column: "DRB",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 3,
                column: "DRB",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 4,
                column: "DRB",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 5,
                column: "DRB",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 6,
                column: "DRB",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 7,
                column: "DRB",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 8,
                column: "DRB",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 9,
                column: "DRB",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 10,
                column: "DRB",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 11,
                column: "DRB",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 12,
                column: "DRB",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 13,
                column: "DRB",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 14,
                column: "DRB",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 15,
                column: "DRB",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 16,
                column: "DRB",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 17,
                column: "DRB",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 18,
                column: "DRB",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 19,
                column: "DRB",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 20,
                column: "DRB",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 21,
                column: "DRB",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 22,
                column: "DRB",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 23,
                column: "DRB",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 24,
                column: "DRB",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 25,
                column: "DRB",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 26,
                column: "DRB",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 27,
                column: "DRB",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 28,
                column: "DRB",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 29,
                column: "DRB",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 30,
                column: "DRB",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 31,
                column: "DRB",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 32,
                column: "DRB",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 33,
                column: "DRB",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 34,
                column: "DRB",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 35,
                column: "DRB",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 36,
                column: "DRB",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 37,
                column: "DRB",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 38,
                column: "DRB",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 39,
                column: "DRB",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 40,
                column: "DRB",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 41,
                column: "DRB",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 42,
                column: "DRB",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 43,
                column: "DRB",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 44,
                column: "DRB",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 45,
                column: "DRB",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 46,
                column: "DRB",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 47,
                column: "DRB",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 48,
                column: "DRB",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 49,
                column: "DRB",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 50,
                column: "DRB",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 51,
                column: "DRB",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 52,
                column: "DRB",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 53,
                column: "DRB",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 54,
                column: "DRB",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 55,
                column: "DRB",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 56,
                column: "DRB",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 57,
                column: "DRB",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 58,
                column: "DRB",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 59,
                column: "DRB",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 60,
                column: "DRB",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 61,
                column: "DRB",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 62,
                column: "DRB",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 63,
                column: "DRB",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 64,
                column: "DRB",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 65,
                column: "DRB",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 66,
                column: "DRB",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 67,
                column: "DRB",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 68,
                column: "DRB",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 69,
                column: "DRB",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 70,
                column: "DRB",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 71,
                column: "DRB",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 72,
                column: "DRB",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 73,
                column: "DRB",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 74,
                column: "DRB",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 75,
                column: "DRB",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 76,
                column: "DRB",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 77,
                column: "DRB",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 78,
                column: "DRB",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 79,
                column: "DRB",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 80,
                column: "DRB",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 81,
                column: "DRB",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 82,
                column: "DRB",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 83,
                column: "DRB",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 84,
                column: "DRB",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 85,
                column: "DRB",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 86,
                column: "DRB",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 87,
                column: "DRB",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 88,
                column: "DRB",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 89,
                column: "DRB",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 90,
                column: "DRB",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 91,
                column: "DRB",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 92,
                column: "DRB",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 93,
                column: "DRB",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 94,
                column: "DRB",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 95,
                column: "DRB",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 96,
                column: "DRB",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 97,
                column: "DRB",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 98,
                column: "DRB",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 99,
                column: "DRB",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 100,
                column: "DRB",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 101,
                column: "DRB",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 102,
                column: "DRB",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 103,
                column: "DRB",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 104,
                column: "DRB",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 105,
                column: "DRB",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 106,
                column: "DRB",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 107,
                column: "DRB",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 108,
                column: "DRB",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 109,
                column: "DRB",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 110,
                column: "DRB",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 111,
                column: "DRB",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 112,
                column: "DRB",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 113,
                column: "DRB",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 114,
                column: "DRB",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 115,
                column: "DRB",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 116,
                column: "DRB",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 117,
                column: "DRB",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 118,
                column: "DRB",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 119,
                column: "DRB",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 120,
                column: "DRB",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 121,
                column: "DRB",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 122,
                column: "DRB",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 123,
                column: "DRB",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 124,
                column: "DRB",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 125,
                column: "DRB",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 126,
                column: "DRB",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 127,
                column: "DRB",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 128,
                column: "DRB",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 129,
                column: "DRB",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 130,
                column: "DRB",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 131,
                column: "DRB",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 132,
                column: "DRB",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 133,
                column: "DRB",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 134,
                column: "DRB",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 135,
                column: "DRB",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 136,
                column: "DRB",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 137,
                column: "DRB",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 138,
                column: "DRB",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 139,
                column: "DRB",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 140,
                column: "DRB",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 141,
                column: "DRB",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 142,
                column: "DRB",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 143,
                column: "DRB",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 144,
                column: "DRB",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 145,
                column: "DRB",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 146,
                column: "DRB",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 147,
                column: "DRB",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 148,
                column: "DRB",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 149,
                column: "DRB",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "TeamHistory",
                keyColumn: "TeamHistoryId",
                keyValue: 150,
                column: "DRB",
                value: 0.0);
        }
    }
}
