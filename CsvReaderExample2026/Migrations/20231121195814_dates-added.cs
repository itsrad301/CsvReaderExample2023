using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CsvReaderExample2023.Migrations
{
    /// <inheritdoc />
    public partial class datesadded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "SecondName",
                table: "Students",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Students",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<DateTime>(
                name: "RegistrationDate",
                table: "Students",
                type: "date",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentID",
                keyValue: "S00002529",
                column: "RegistrationDate",
                value: new DateTime(2022, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentID",
                keyValue: "S00023092",
                column: "RegistrationDate",
                value: new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentID",
                keyValue: "S00046565",
                column: "RegistrationDate",
                value: new DateTime(2021, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentID",
                keyValue: "S00078018",
                column: "RegistrationDate",
                value: new DateTime(2021, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentID",
                keyValue: "S00113203",
                column: "RegistrationDate",
                value: new DateTime(2021, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentID",
                keyValue: "S00114203",
                column: "RegistrationDate",
                value: new DateTime(2022, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentID",
                keyValue: "S00132212",
                column: "RegistrationDate",
                value: new DateTime(2021, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentID",
                keyValue: "S00156910",
                column: "RegistrationDate",
                value: new DateTime(2021, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentID",
                keyValue: "S00170776",
                column: "RegistrationDate",
                value: new DateTime(2021, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentID",
                keyValue: "S00213687",
                column: "RegistrationDate",
                value: new DateTime(2021, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentID",
                keyValue: "S00225481",
                column: "RegistrationDate",
                value: new DateTime(2021, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentID",
                keyValue: "S00241057",
                column: "RegistrationDate",
                value: new DateTime(2020, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentID",
                keyValue: "S00274643",
                column: "RegistrationDate",
                value: new DateTime(2020, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentID",
                keyValue: "S00278258",
                column: "RegistrationDate",
                value: new DateTime(2020, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentID",
                keyValue: "S00287450",
                column: "RegistrationDate",
                value: new DateTime(2021, 9, 18, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentID",
                keyValue: "S00303021",
                column: "RegistrationDate",
                value: new DateTime(2022, 3, 26, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentID",
                keyValue: "S00342403",
                column: "RegistrationDate",
                value: new DateTime(2021, 11, 28, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentID",
                keyValue: "S00360626",
                column: "RegistrationDate",
                value: new DateTime(2020, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentID",
                keyValue: "S00360809",
                column: "RegistrationDate",
                value: new DateTime(2021, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentID",
                keyValue: "S00380454",
                column: "RegistrationDate",
                value: new DateTime(2020, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentID",
                keyValue: "S00387552",
                column: "RegistrationDate",
                value: new DateTime(2021, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentID",
                keyValue: "S00389325",
                column: "RegistrationDate",
                value: new DateTime(2022, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentID",
                keyValue: "S00413210",
                column: "RegistrationDate",
                value: new DateTime(2021, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentID",
                keyValue: "S00430473",
                column: "RegistrationDate",
                value: new DateTime(2021, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentID",
                keyValue: "S00442638",
                column: "RegistrationDate",
                value: new DateTime(2022, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentID",
                keyValue: "S00449490",
                column: "RegistrationDate",
                value: new DateTime(2022, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentID",
                keyValue: "S00452407",
                column: "RegistrationDate",
                value: new DateTime(2020, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentID",
                keyValue: "S00472973",
                column: "RegistrationDate",
                value: new DateTime(2022, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentID",
                keyValue: "S00483498",
                column: "RegistrationDate",
                value: new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentID",
                keyValue: "S00540216",
                column: "RegistrationDate",
                value: new DateTime(2020, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentID",
                keyValue: "S00585868",
                column: "RegistrationDate",
                value: new DateTime(2020, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentID",
                keyValue: "S00586142",
                column: "RegistrationDate",
                value: new DateTime(2022, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentID",
                keyValue: "S00599865",
                column: "RegistrationDate",
                value: new DateTime(2020, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentID",
                keyValue: "S00633249",
                column: "RegistrationDate",
                value: new DateTime(2020, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentID",
                keyValue: "S00634533",
                column: "RegistrationDate",
                value: new DateTime(2021, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentID",
                keyValue: "S00636735",
                column: "RegistrationDate",
                value: new DateTime(2020, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentID",
                keyValue: "S00698845",
                column: "RegistrationDate",
                value: new DateTime(2021, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentID",
                keyValue: "S00757976",
                column: "RegistrationDate",
                value: new DateTime(2021, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentID",
                keyValue: "S00806042",
                column: "RegistrationDate",
                value: new DateTime(2021, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentID",
                keyValue: "S00838203",
                column: "RegistrationDate",
                value: new DateTime(2021, 12, 26, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentID",
                keyValue: "S00873144",
                column: "RegistrationDate",
                value: new DateTime(2021, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentID",
                keyValue: "S00880651",
                column: "RegistrationDate",
                value: new DateTime(2022, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentID",
                keyValue: "S00913453",
                column: "RegistrationDate",
                value: new DateTime(2020, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentID",
                keyValue: "S00932913",
                column: "RegistrationDate",
                value: new DateTime(2022, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentID",
                keyValue: "S00947280",
                column: "RegistrationDate",
                value: new DateTime(2022, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentID",
                keyValue: "S00967156",
                column: "RegistrationDate",
                value: new DateTime(2021, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentID",
                keyValue: "S00971382",
                column: "RegistrationDate",
                value: new DateTime(2021, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentID",
                keyValue: "S00978944",
                column: "RegistrationDate",
                value: new DateTime(2022, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RegistrationDate",
                table: "Students");

            migrationBuilder.AlterColumn<string>(
                name: "SecondName",
                table: "Students",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Students",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }
    }
}
