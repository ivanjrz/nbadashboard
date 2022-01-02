using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NBAapi.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 1,
                column: "Joined",
                value: new DateTime(2022, 1, 1, 18, 52, 42, 618, DateTimeKind.Local).AddTicks(3950));

            migrationBuilder.UpdateData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 2,
                column: "Joined",
                value: new DateTime(2022, 1, 1, 18, 52, 42, 618, DateTimeKind.Local).AddTicks(6460));

            migrationBuilder.UpdateData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 3,
                column: "Joined",
                value: new DateTime(2022, 1, 1, 18, 52, 42, 618, DateTimeKind.Local).AddTicks(7280));

            migrationBuilder.UpdateData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 4,
                column: "Joined",
                value: new DateTime(2022, 1, 1, 18, 52, 42, 618, DateTimeKind.Local).AddTicks(7350));

            migrationBuilder.UpdateData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 5,
                column: "Joined",
                value: new DateTime(2022, 1, 1, 18, 52, 42, 618, DateTimeKind.Local).AddTicks(7360));

            migrationBuilder.UpdateData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 6,
                column: "Joined",
                value: new DateTime(2022, 1, 1, 18, 52, 42, 618, DateTimeKind.Local).AddTicks(7370));

            migrationBuilder.UpdateData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 7,
                column: "Joined",
                value: new DateTime(2022, 1, 1, 18, 52, 42, 618, DateTimeKind.Local).AddTicks(7390));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 1,
                column: "DateFounded",
                value: new DateTime(2022, 1, 1, 18, 52, 42, 596, DateTimeKind.Local).AddTicks(6210));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 2,
                column: "DateFounded",
                value: new DateTime(2022, 1, 1, 18, 52, 42, 615, DateTimeKind.Local).AddTicks(9750));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 3,
                column: "DateFounded",
                value: new DateTime(2022, 1, 1, 18, 52, 42, 616, DateTimeKind.Local).AddTicks(690));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 4,
                column: "DateFounded",
                value: new DateTime(2022, 1, 1, 18, 52, 42, 616, DateTimeKind.Local).AddTicks(760));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 5,
                column: "DateFounded",
                value: new DateTime(2022, 1, 1, 18, 52, 42, 616, DateTimeKind.Local).AddTicks(780));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 6,
                column: "DateFounded",
                value: new DateTime(2022, 1, 1, 18, 52, 42, 616, DateTimeKind.Local).AddTicks(790));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 7,
                column: "DateFounded",
                value: new DateTime(2022, 1, 1, 18, 52, 42, 616, DateTimeKind.Local).AddTicks(800));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 1,
                column: "Joined",
                value: new DateTime(2022, 1, 1, 18, 4, 4, 346, DateTimeKind.Local).AddTicks(8070));

            migrationBuilder.UpdateData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 2,
                column: "Joined",
                value: new DateTime(2022, 1, 1, 18, 4, 4, 347, DateTimeKind.Local).AddTicks(760));

            migrationBuilder.UpdateData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 3,
                column: "Joined",
                value: new DateTime(2022, 1, 1, 18, 4, 4, 347, DateTimeKind.Local).AddTicks(1490));

            migrationBuilder.UpdateData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 4,
                column: "Joined",
                value: new DateTime(2022, 1, 1, 18, 4, 4, 347, DateTimeKind.Local).AddTicks(1560));

            migrationBuilder.UpdateData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 5,
                column: "Joined",
                value: new DateTime(2022, 1, 1, 18, 4, 4, 347, DateTimeKind.Local).AddTicks(1570));

            migrationBuilder.UpdateData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 6,
                column: "Joined",
                value: new DateTime(2022, 1, 1, 18, 4, 4, 347, DateTimeKind.Local).AddTicks(1580));

            migrationBuilder.UpdateData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 7,
                column: "Joined",
                value: new DateTime(2022, 1, 1, 18, 4, 4, 347, DateTimeKind.Local).AddTicks(1600));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 1,
                column: "DateFounded",
                value: new DateTime(2022, 1, 1, 18, 4, 4, 324, DateTimeKind.Local).AddTicks(3420));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 2,
                column: "DateFounded",
                value: new DateTime(2022, 1, 1, 18, 4, 4, 344, DateTimeKind.Local).AddTicks(3690));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 3,
                column: "DateFounded",
                value: new DateTime(2022, 1, 1, 18, 4, 4, 344, DateTimeKind.Local).AddTicks(4620));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 4,
                column: "DateFounded",
                value: new DateTime(2022, 1, 1, 18, 4, 4, 344, DateTimeKind.Local).AddTicks(4700));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 5,
                column: "DateFounded",
                value: new DateTime(2022, 1, 1, 18, 4, 4, 344, DateTimeKind.Local).AddTicks(4710));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 6,
                column: "DateFounded",
                value: new DateTime(2022, 1, 1, 18, 4, 4, 344, DateTimeKind.Local).AddTicks(4720));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 7,
                column: "DateFounded",
                value: new DateTime(2022, 1, 1, 18, 4, 4, 344, DateTimeKind.Local).AddTicks(4740));
        }
    }
}
