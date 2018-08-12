using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Core2LearnWebApp.Migrations
{
    public partial class RezervationAddGuest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "BirthDay",
                table: "Rezervations",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Rezervations",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Rezervations",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Phone",
                table: "Rezervations",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RezervationNote",
                table: "Rezervations",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SurName",
                table: "Rezervations",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BirthDay",
                table: "Rezervations");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Rezervations");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Rezervations");

            migrationBuilder.DropColumn(
                name: "Phone",
                table: "Rezervations");

            migrationBuilder.DropColumn(
                name: "RezervationNote",
                table: "Rezervations");

            migrationBuilder.DropColumn(
                name: "SurName",
                table: "Rezervations");
        }
    }
}
