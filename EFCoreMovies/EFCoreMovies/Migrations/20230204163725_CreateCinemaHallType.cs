using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCoreMovies.Migrations
{
    public partial class CreateCinemaHallType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "InCinemas",
                table: "Movies",
                newName: "InCinema");

            migrationBuilder.AddColumn<int>(
                name: "CinemaHallType",
                table: "CinemaHalls",
                type: "int",
                nullable: false,
                defaultValue: 1);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfBirth",
                table: "Actors",
                type: "date",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "date",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CinemaHallType",
                table: "CinemaHalls");

            migrationBuilder.RenameColumn(
                name: "InCinema",
                table: "Movies",
                newName: "InCinemas");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfBirth",
                table: "Actors",
                type: "date",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "date");
        }
    }
}
