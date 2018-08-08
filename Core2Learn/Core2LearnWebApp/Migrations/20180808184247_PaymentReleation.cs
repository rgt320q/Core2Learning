using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Core2LearnWebApp.Migrations
{
    public partial class PaymentReleation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Rezervations",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AccommodationType = table.Column<string>(nullable: true),
                    Arrivaldate = table.Column<DateTime>(nullable: true),
                    BoardType = table.Column<string>(nullable: true),
                    Breakfast = table.Column<string>(nullable: true),
                    DepartureDate = table.Column<DateTime>(nullable: true),
                    Dinner = table.Column<string>(nullable: true),
                    InsertDateTime = table.Column<DateTime>(nullable: true),
                    Lunch = table.Column<string>(nullable: true),
                    RoomNo = table.Column<string>(nullable: true),
                    Status = table.Column<string>(nullable: true),
                    TatolDays = table.Column<int>(nullable: true),
                    TotalAdult = table.Column<int>(nullable: true),
                    TotalChildren = table.Column<int>(nullable: true),
                    TotalChildrenWithPrice = table.Column<int>(nullable: true),
                    TotalPersons = table.Column<int>(nullable: true),
                    UpdateDateTime = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rezervations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Guests",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Address = table.Column<string>(nullable: true),
                    BirthDay = table.Column<DateTime>(nullable: true),
                    CarPlate = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    Country = table.Column<string>(nullable: true),
                    District = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    FatherName = table.Column<string>(nullable: true),
                    Gender = table.Column<string>(nullable: true),
                    GuestSequenceNo = table.Column<int>(nullable: true),
                    IdentityNumber = table.Column<string>(nullable: true),
                    IdentitySerialNo = table.Column<string>(nullable: true),
                    IdentityType = table.Column<string>(nullable: true),
                    InsertDateTime = table.Column<DateTime>(nullable: true),
                    MartialStatus = table.Column<string>(nullable: true),
                    MotherName = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: false),
                    Phone = table.Column<string>(nullable: true),
                    RezervationId = table.Column<int>(nullable: true),
                    RezervationNote = table.Column<string>(nullable: true),
                    SurName = table.Column<string>(nullable: true),
                    UpdateDateTime = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Guests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Guests_Rezervations_RezervationId",
                        column: x => x.RezervationId,
                        principalTable: "Rezervations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Payments",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BreakfastPrice = table.Column<double>(nullable: true),
                    ChildPrice = table.Column<double>(nullable: true),
                    DailyAdultPrice = table.Column<double>(nullable: true),
                    DailyGuestPrice = table.Column<double>(nullable: true),
                    DinnerPrice = table.Column<double>(nullable: true),
                    DiscountPrice = table.Column<double>(nullable: true),
                    ExtrasPrice = table.Column<double>(nullable: true),
                    GuestId = table.Column<int>(nullable: true),
                    InsertDateTime = table.Column<DateTime>(nullable: true),
                    LunchPrice = table.Column<double>(nullable: true),
                    RoomPrice = table.Column<double>(nullable: true),
                    TotalAccommodationPrice = table.Column<double>(nullable: true),
                    TotalBreakFastPrice = table.Column<double>(nullable: true),
                    TotalChildPrice = table.Column<double>(nullable: true),
                    TotalDinnerPrice = table.Column<double>(nullable: true),
                    TotalLunchPrice = table.Column<double>(nullable: true),
                    TotalPersonPrice = table.Column<double>(nullable: true),
                    TotalPrice = table.Column<double>(nullable: false),
                    TotalRoomPrice = table.Column<double>(nullable: true),
                    UpdateDateTime = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Payments_Guests_GuestId",
                        column: x => x.GuestId,
                        principalTable: "Guests",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Guests_RezervationId",
                table: "Guests",
                column: "RezervationId");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_GuestId",
                table: "Payments",
                column: "GuestId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Payments");

            migrationBuilder.DropTable(
                name: "Guests");

            migrationBuilder.DropTable(
                name: "Rezervations");
        }
    }
}
