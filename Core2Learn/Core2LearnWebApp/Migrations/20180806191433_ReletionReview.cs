using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Core2LearnWebApp.Migrations
{
    public partial class ReletionReview : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Payments_Rezervations_RezervationId",
                table: "Payments");

            migrationBuilder.RenameColumn(
                name: "RezervationId",
                table: "Payments",
                newName: "GuestId");

            migrationBuilder.RenameIndex(
                name: "IX_Payments_RezervationId",
                table: "Payments",
                newName: "IX_Payments_GuestId");

            migrationBuilder.AlterColumn<string>(
                name: "SurName",
                table: "Rezervations",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Rezervations",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DepartureDate",
                table: "Rezervations",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Arrivaldate",
                table: "Rezervations",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AddForeignKey(
                name: "FK_Payments_Guests_GuestId",
                table: "Payments",
                column: "GuestId",
                principalTable: "Guests",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Payments_Guests_GuestId",
                table: "Payments");

            migrationBuilder.RenameColumn(
                name: "GuestId",
                table: "Payments",
                newName: "RezervationId");

            migrationBuilder.RenameIndex(
                name: "IX_Payments_GuestId",
                table: "Payments",
                newName: "IX_Payments_RezervationId");

            migrationBuilder.AlterColumn<string>(
                name: "SurName",
                table: "Rezervations",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Rezervations",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DepartureDate",
                table: "Rezervations",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Arrivaldate",
                table: "Rezervations",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Payments_Rezervations_RezervationId",
                table: "Payments",
                column: "RezervationId",
                principalTable: "Rezervations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
