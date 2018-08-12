using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Core2LearnWebApp.Migrations
{
    public partial class ReletionReviewReverse : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddForeignKey(
                name: "FK_Payments_Rezervations_RezervationId",
                table: "Payments",
                column: "RezervationId",
                principalTable: "Rezervations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddForeignKey(
                name: "FK_Payments_Guests_GuestId",
                table: "Payments",
                column: "GuestId",
                principalTable: "Guests",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
