using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    public partial class Identity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    UserName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "INTEGER", nullable: false),
                    PasswordHash = table.Column<string>(type: "TEXT", nullable: true),
                    SecurityStamp = table.Column<string>(type: "TEXT", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "TEXT", nullable: true),
                    PhoneNumber = table.Column<string>(type: "TEXT", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "INTEGER", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "INTEGER", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "TEXT", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "INTEGER", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    RoleId = table.Column<string>(type: "TEXT", nullable: false),
                    ClaimType = table.Column<string>(type: "TEXT", nullable: true),
                    ClaimValue = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    ClaimType = table.Column<string>(type: "TEXT", nullable: true),
                    ClaimValue = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "TEXT", nullable: false),
                    ProviderKey = table.Column<string>(type: "TEXT", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "TEXT", nullable: true),
                    UserId = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    RoleId = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    LoginProvider = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Value = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 1,
                column: "Joined",
                value: new DateTime(2022, 6, 30, 23, 34, 58, 659, DateTimeKind.Local).AddTicks(6230));

            migrationBuilder.UpdateData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 2,
                column: "Joined",
                value: new DateTime(2022, 6, 30, 23, 34, 58, 659, DateTimeKind.Local).AddTicks(6400));

            migrationBuilder.UpdateData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 3,
                column: "Joined",
                value: new DateTime(2022, 6, 30, 23, 34, 58, 659, DateTimeKind.Local).AddTicks(6410));

            migrationBuilder.UpdateData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 4,
                column: "Joined",
                value: new DateTime(2022, 6, 30, 23, 34, 58, 659, DateTimeKind.Local).AddTicks(6420));

            migrationBuilder.UpdateData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 5,
                column: "Joined",
                value: new DateTime(2022, 6, 30, 23, 34, 58, 659, DateTimeKind.Local).AddTicks(6430));

            migrationBuilder.UpdateData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 6,
                column: "Joined",
                value: new DateTime(2022, 6, 30, 23, 34, 58, 659, DateTimeKind.Local).AddTicks(6440));

            migrationBuilder.UpdateData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 7,
                column: "Joined",
                value: new DateTime(2022, 6, 30, 23, 34, 58, 659, DateTimeKind.Local).AddTicks(6450));

            migrationBuilder.UpdateData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 8,
                column: "Joined",
                value: new DateTime(2022, 6, 30, 23, 34, 58, 659, DateTimeKind.Local).AddTicks(6470));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 1,
                column: "DateFounded",
                value: new DateTime(2022, 6, 30, 23, 34, 58, 659, DateTimeKind.Local).AddTicks(3060));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 2,
                column: "DateFounded",
                value: new DateTime(2022, 6, 30, 23, 34, 58, 659, DateTimeKind.Local).AddTicks(4060));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 3,
                column: "DateFounded",
                value: new DateTime(2022, 6, 30, 23, 34, 58, 659, DateTimeKind.Local).AddTicks(4080));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 4,
                column: "DateFounded",
                value: new DateTime(2022, 6, 30, 23, 34, 58, 659, DateTimeKind.Local).AddTicks(4110));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 5,
                column: "DateFounded",
                value: new DateTime(2022, 6, 30, 23, 34, 58, 659, DateTimeKind.Local).AddTicks(4130));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 6,
                column: "DateFounded",
                value: new DateTime(2022, 6, 30, 23, 34, 58, 659, DateTimeKind.Local).AddTicks(4150));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 7,
                column: "DateFounded",
                value: new DateTime(2022, 6, 30, 23, 34, 58, 659, DateTimeKind.Local).AddTicks(4160));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 8,
                column: "DateFounded",
                value: new DateTime(2022, 6, 30, 23, 34, 58, 659, DateTimeKind.Local).AddTicks(4170));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 9,
                column: "DateFounded",
                value: new DateTime(2022, 6, 30, 23, 34, 58, 659, DateTimeKind.Local).AddTicks(4190));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 10,
                column: "DateFounded",
                value: new DateTime(2022, 6, 30, 23, 34, 58, 659, DateTimeKind.Local).AddTicks(4200));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 11,
                column: "DateFounded",
                value: new DateTime(2022, 6, 30, 23, 34, 58, 659, DateTimeKind.Local).AddTicks(4230));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 12,
                column: "DateFounded",
                value: new DateTime(2022, 6, 30, 23, 34, 58, 659, DateTimeKind.Local).AddTicks(4250));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 13,
                column: "DateFounded",
                value: new DateTime(2022, 6, 30, 23, 34, 58, 659, DateTimeKind.Local).AddTicks(4270));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 14,
                column: "DateFounded",
                value: new DateTime(2022, 6, 30, 23, 34, 58, 659, DateTimeKind.Local).AddTicks(4280));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 15,
                column: "DateFounded",
                value: new DateTime(2022, 6, 30, 23, 34, 58, 659, DateTimeKind.Local).AddTicks(4290));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 16,
                column: "DateFounded",
                value: new DateTime(2022, 6, 30, 23, 34, 58, 659, DateTimeKind.Local).AddTicks(4320));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 17,
                column: "DateFounded",
                value: new DateTime(2022, 6, 30, 23, 34, 58, 659, DateTimeKind.Local).AddTicks(4330));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 18,
                column: "DateFounded",
                value: new DateTime(2022, 6, 30, 23, 34, 58, 659, DateTimeKind.Local).AddTicks(4340));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 19,
                column: "DateFounded",
                value: new DateTime(2022, 6, 30, 23, 34, 58, 659, DateTimeKind.Local).AddTicks(4360));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 20,
                column: "DateFounded",
                value: new DateTime(2022, 6, 30, 23, 34, 58, 659, DateTimeKind.Local).AddTicks(4370));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 21,
                column: "DateFounded",
                value: new DateTime(2022, 6, 30, 23, 34, 58, 659, DateTimeKind.Local).AddTicks(4390));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 22,
                column: "DateFounded",
                value: new DateTime(2022, 6, 30, 23, 34, 58, 659, DateTimeKind.Local).AddTicks(4400));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 23,
                column: "DateFounded",
                value: new DateTime(2022, 6, 30, 23, 34, 58, 659, DateTimeKind.Local).AddTicks(4420));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 24,
                column: "DateFounded",
                value: new DateTime(2022, 6, 30, 23, 34, 58, 659, DateTimeKind.Local).AddTicks(4430));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 25,
                column: "DateFounded",
                value: new DateTime(2022, 6, 30, 23, 34, 58, 659, DateTimeKind.Local).AddTicks(4440));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 26,
                column: "DateFounded",
                value: new DateTime(2022, 6, 30, 23, 34, 58, 659, DateTimeKind.Local).AddTicks(4460));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 27,
                column: "DateFounded",
                value: new DateTime(2022, 6, 30, 23, 34, 58, 659, DateTimeKind.Local).AddTicks(4470));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 28,
                column: "DateFounded",
                value: new DateTime(2022, 6, 30, 23, 34, 58, 659, DateTimeKind.Local).AddTicks(4480));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 29,
                column: "DateFounded",
                value: new DateTime(2022, 6, 30, 23, 34, 58, 659, DateTimeKind.Local).AddTicks(4490));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 30,
                column: "DateFounded",
                value: new DateTime(2022, 6, 30, 23, 34, 58, 659, DateTimeKind.Local).AddTicks(4510));

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

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
    }
}
