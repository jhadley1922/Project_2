using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Project_2.Migrations
{
    public partial class Reset : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Timeslots",
                columns: table => new
                {
                    TimeslotId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DateTime = table.Column<DateTime>(nullable: false),
                    Available = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Timeslots", x => x.TimeslotId);
                });

            migrationBuilder.CreateTable(
                name: "Appointments",
                columns: table => new
                {
                    AppointmentId = table.Column<long>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    GroupName = table.Column<string>(nullable: false),
                    SizeOfGroup = table.Column<int>(nullable: false),
                    TimeslotId = table.Column<int>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    Phone = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Appointments", x => x.AppointmentId);
                    table.ForeignKey(
                        name: "FK_Appointments_Timeslots_TimeslotId",
                        column: x => x.TimeslotId,
                        principalTable: "Timeslots",
                        principalColumn: "TimeslotId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeslotId", "Available", "DateTime" },
                values: new object[] { 1, true, new DateTime(2022, 3, 20, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeslotId", "Available", "DateTime" },
                values: new object[] { 66, true, new DateTime(2022, 3, 25, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeslotId", "Available", "DateTime" },
                values: new object[] { 65, true, new DateTime(2022, 3, 24, 20, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeslotId", "Available", "DateTime" },
                values: new object[] { 64, true, new DateTime(2022, 3, 24, 19, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeslotId", "Available", "DateTime" },
                values: new object[] { 63, true, new DateTime(2022, 3, 24, 18, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeslotId", "Available", "DateTime" },
                values: new object[] { 62, true, new DateTime(2022, 3, 24, 17, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeslotId", "Available", "DateTime" },
                values: new object[] { 61, true, new DateTime(2022, 3, 24, 16, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeslotId", "Available", "DateTime" },
                values: new object[] { 60, true, new DateTime(2022, 3, 24, 15, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeslotId", "Available", "DateTime" },
                values: new object[] { 59, true, new DateTime(2022, 3, 24, 14, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeslotId", "Available", "DateTime" },
                values: new object[] { 58, true, new DateTime(2022, 3, 24, 13, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeslotId", "Available", "DateTime" },
                values: new object[] { 57, true, new DateTime(2022, 3, 24, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeslotId", "Available", "DateTime" },
                values: new object[] { 56, true, new DateTime(2022, 3, 24, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeslotId", "Available", "DateTime" },
                values: new object[] { 55, true, new DateTime(2022, 3, 24, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeslotId", "Available", "DateTime" },
                values: new object[] { 54, true, new DateTime(2022, 3, 24, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeslotId", "Available", "DateTime" },
                values: new object[] { 53, true, new DateTime(2022, 3, 24, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeslotId", "Available", "DateTime" },
                values: new object[] { 52, true, new DateTime(2022, 3, 23, 20, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeslotId", "Available", "DateTime" },
                values: new object[] { 51, true, new DateTime(2022, 3, 23, 19, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeslotId", "Available", "DateTime" },
                values: new object[] { 50, true, new DateTime(2022, 3, 23, 18, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeslotId", "Available", "DateTime" },
                values: new object[] { 49, true, new DateTime(2022, 3, 23, 17, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeslotId", "Available", "DateTime" },
                values: new object[] { 48, true, new DateTime(2022, 3, 23, 16, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeslotId", "Available", "DateTime" },
                values: new object[] { 67, true, new DateTime(2022, 3, 25, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeslotId", "Available", "DateTime" },
                values: new object[] { 47, true, new DateTime(2022, 3, 23, 15, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeslotId", "Available", "DateTime" },
                values: new object[] { 68, true, new DateTime(2022, 3, 25, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeslotId", "Available", "DateTime" },
                values: new object[] { 70, true, new DateTime(2022, 3, 25, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeslotId", "Available", "DateTime" },
                values: new object[] { 89, true, new DateTime(2022, 3, 26, 18, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeslotId", "Available", "DateTime" },
                values: new object[] { 88, true, new DateTime(2022, 3, 26, 17, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeslotId", "Available", "DateTime" },
                values: new object[] { 87, true, new DateTime(2022, 3, 26, 16, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeslotId", "Available", "DateTime" },
                values: new object[] { 86, true, new DateTime(2022, 3, 26, 15, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeslotId", "Available", "DateTime" },
                values: new object[] { 85, true, new DateTime(2022, 3, 26, 14, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeslotId", "Available", "DateTime" },
                values: new object[] { 84, true, new DateTime(2022, 3, 26, 13, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeslotId", "Available", "DateTime" },
                values: new object[] { 83, true, new DateTime(2022, 3, 26, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeslotId", "Available", "DateTime" },
                values: new object[] { 82, true, new DateTime(2022, 3, 26, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeslotId", "Available", "DateTime" },
                values: new object[] { 81, true, new DateTime(2022, 3, 26, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeslotId", "Available", "DateTime" },
                values: new object[] { 80, true, new DateTime(2022, 3, 26, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeslotId", "Available", "DateTime" },
                values: new object[] { 79, true, new DateTime(2022, 3, 26, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeslotId", "Available", "DateTime" },
                values: new object[] { 78, true, new DateTime(2022, 3, 25, 20, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeslotId", "Available", "DateTime" },
                values: new object[] { 77, true, new DateTime(2022, 3, 25, 19, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeslotId", "Available", "DateTime" },
                values: new object[] { 76, true, new DateTime(2022, 3, 25, 18, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeslotId", "Available", "DateTime" },
                values: new object[] { 75, true, new DateTime(2022, 3, 25, 17, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeslotId", "Available", "DateTime" },
                values: new object[] { 74, true, new DateTime(2022, 3, 25, 16, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeslotId", "Available", "DateTime" },
                values: new object[] { 73, true, new DateTime(2022, 3, 25, 15, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeslotId", "Available", "DateTime" },
                values: new object[] { 72, true, new DateTime(2022, 3, 25, 14, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeslotId", "Available", "DateTime" },
                values: new object[] { 71, true, new DateTime(2022, 3, 25, 13, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeslotId", "Available", "DateTime" },
                values: new object[] { 69, true, new DateTime(2022, 3, 25, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeslotId", "Available", "DateTime" },
                values: new object[] { 90, true, new DateTime(2022, 3, 26, 19, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeslotId", "Available", "DateTime" },
                values: new object[] { 46, true, new DateTime(2022, 3, 23, 14, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeslotId", "Available", "DateTime" },
                values: new object[] { 44, true, new DateTime(2022, 3, 23, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeslotId", "Available", "DateTime" },
                values: new object[] { 20, true, new DateTime(2022, 3, 21, 14, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeslotId", "Available", "DateTime" },
                values: new object[] { 19, true, new DateTime(2022, 3, 21, 13, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeslotId", "Available", "DateTime" },
                values: new object[] { 18, true, new DateTime(2022, 3, 21, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeslotId", "Available", "DateTime" },
                values: new object[] { 17, true, new DateTime(2022, 3, 21, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeslotId", "Available", "DateTime" },
                values: new object[] { 16, true, new DateTime(2022, 3, 21, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeslotId", "Available", "DateTime" },
                values: new object[] { 15, true, new DateTime(2022, 3, 21, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeslotId", "Available", "DateTime" },
                values: new object[] { 14, true, new DateTime(2022, 3, 21, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeslotId", "Available", "DateTime" },
                values: new object[] { 13, true, new DateTime(2022, 3, 20, 20, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeslotId", "Available", "DateTime" },
                values: new object[] { 12, true, new DateTime(2022, 3, 20, 19, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeslotId", "Available", "DateTime" },
                values: new object[] { 11, true, new DateTime(2022, 3, 20, 18, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeslotId", "Available", "DateTime" },
                values: new object[] { 10, true, new DateTime(2022, 3, 20, 17, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeslotId", "Available", "DateTime" },
                values: new object[] { 9, true, new DateTime(2022, 3, 20, 16, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeslotId", "Available", "DateTime" },
                values: new object[] { 8, true, new DateTime(2022, 3, 20, 15, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeslotId", "Available", "DateTime" },
                values: new object[] { 7, true, new DateTime(2022, 3, 20, 14, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeslotId", "Available", "DateTime" },
                values: new object[] { 6, true, new DateTime(2022, 3, 20, 13, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeslotId", "Available", "DateTime" },
                values: new object[] { 5, true, new DateTime(2022, 3, 20, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeslotId", "Available", "DateTime" },
                values: new object[] { 4, true, new DateTime(2022, 3, 20, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeslotId", "Available", "DateTime" },
                values: new object[] { 3, true, new DateTime(2022, 3, 20, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeslotId", "Available", "DateTime" },
                values: new object[] { 2, true, new DateTime(2022, 3, 20, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeslotId", "Available", "DateTime" },
                values: new object[] { 21, true, new DateTime(2022, 3, 21, 15, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeslotId", "Available", "DateTime" },
                values: new object[] { 45, true, new DateTime(2022, 3, 23, 13, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeslotId", "Available", "DateTime" },
                values: new object[] { 22, true, new DateTime(2022, 3, 21, 16, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeslotId", "Available", "DateTime" },
                values: new object[] { 24, true, new DateTime(2022, 3, 21, 18, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeslotId", "Available", "DateTime" },
                values: new object[] { 43, true, new DateTime(2022, 3, 23, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeslotId", "Available", "DateTime" },
                values: new object[] { 42, true, new DateTime(2022, 3, 23, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeslotId", "Available", "DateTime" },
                values: new object[] { 41, true, new DateTime(2022, 3, 23, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeslotId", "Available", "DateTime" },
                values: new object[] { 40, true, new DateTime(2022, 3, 23, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeslotId", "Available", "DateTime" },
                values: new object[] { 39, true, new DateTime(2022, 3, 22, 20, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeslotId", "Available", "DateTime" },
                values: new object[] { 38, true, new DateTime(2022, 3, 22, 19, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeslotId", "Available", "DateTime" },
                values: new object[] { 37, true, new DateTime(2022, 3, 22, 18, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeslotId", "Available", "DateTime" },
                values: new object[] { 36, true, new DateTime(2022, 3, 22, 17, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeslotId", "Available", "DateTime" },
                values: new object[] { 35, true, new DateTime(2022, 3, 22, 16, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeslotId", "Available", "DateTime" },
                values: new object[] { 34, true, new DateTime(2022, 3, 22, 15, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeslotId", "Available", "DateTime" },
                values: new object[] { 33, true, new DateTime(2022, 3, 22, 14, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeslotId", "Available", "DateTime" },
                values: new object[] { 32, true, new DateTime(2022, 3, 22, 13, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeslotId", "Available", "DateTime" },
                values: new object[] { 31, true, new DateTime(2022, 3, 22, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeslotId", "Available", "DateTime" },
                values: new object[] { 30, true, new DateTime(2022, 3, 22, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeslotId", "Available", "DateTime" },
                values: new object[] { 29, true, new DateTime(2022, 3, 22, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeslotId", "Available", "DateTime" },
                values: new object[] { 28, true, new DateTime(2022, 3, 22, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeslotId", "Available", "DateTime" },
                values: new object[] { 27, true, new DateTime(2022, 3, 22, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeslotId", "Available", "DateTime" },
                values: new object[] { 26, true, new DateTime(2022, 3, 21, 20, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeslotId", "Available", "DateTime" },
                values: new object[] { 25, true, new DateTime(2022, 3, 21, 19, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeslotId", "Available", "DateTime" },
                values: new object[] { 23, true, new DateTime(2022, 3, 21, 17, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeslotId", "Available", "DateTime" },
                values: new object[] { 91, true, new DateTime(2022, 3, 26, 20, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_TimeslotId",
                table: "Appointments",
                column: "TimeslotId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Appointments");

            migrationBuilder.DropTable(
                name: "Timeslots");
        }
    }
}
