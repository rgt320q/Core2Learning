using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Core2LearnWebApp.Migrations
{
    public partial class TablesSettingMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "GuestMartialStatus",
                table: "Guests",
                newName: "MartialStatus");

            migrationBuilder.RenameColumn(
                name: "GuestEmail",
                table: "Guests",
                newName: "Email");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "MartialStatus",
                table: "Guests",
                newName: "GuestMartialStatus");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "Guests",
                newName: "GuestEmail");
        }
    }
}
