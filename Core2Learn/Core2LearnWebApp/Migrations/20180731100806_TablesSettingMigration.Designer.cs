﻿// <auto-generated />
using Core2LearnWebApp.Data.EntityFramework;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace Core2LearnWebApp.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20180731100806_TablesSettingMigration")]
    partial class TablesSettingMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.3-rtm-10026")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Core2LearnWebApp.Models.Guest", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address");

                    b.Property<DateTime?>("BirthDay");

                    b.Property<string>("CarPlate");

                    b.Property<string>("City");

                    b.Property<string>("Country");

                    b.Property<string>("District");

                    b.Property<string>("Email");

                    b.Property<string>("FatherName");

                    b.Property<string>("Gender");

                    b.Property<int?>("GuestSequenceNo");

                    b.Property<string>("IdentityNumber");

                    b.Property<string>("IdentitySerialNo");

                    b.Property<string>("IdentityType");

                    b.Property<DateTime?>("InsertDateTime");

                    b.Property<string>("MartialStatus");

                    b.Property<string>("MotherName");

                    b.Property<string>("Name");

                    b.Property<string>("Phone");

                    b.Property<int>("RezervationId");

                    b.Property<string>("RezervationNote");

                    b.Property<string>("SurName");

                    b.Property<DateTime?>("UpdateDateTime");

                    b.HasKey("Id");

                    b.HasIndex("RezervationId");

                    b.ToTable("Guests");
                });

            modelBuilder.Entity("Core2LearnWebApp.Models.Payment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<double?>("BreakfastPrice");

                    b.Property<double?>("ChildPrice");

                    b.Property<double?>("DailyAdultPrice");

                    b.Property<double?>("DailyGuestPrice");

                    b.Property<double?>("DinnerPrice");

                    b.Property<double?>("DiscountPrice");

                    b.Property<double?>("ExtrasPrice");

                    b.Property<DateTime?>("InsertDateTime");

                    b.Property<double?>("LunchPrice");

                    b.Property<int>("RezervationId");

                    b.Property<double?>("RoomPrice");

                    b.Property<double?>("TotalAccommodationPrice");

                    b.Property<double?>("TotalBreakFastPrice");

                    b.Property<double?>("TotalChildPrice");

                    b.Property<double?>("TotalDinnerPrice");

                    b.Property<double?>("TotalLunchPrice");

                    b.Property<double?>("TotalPersonPrice");

                    b.Property<double>("TotalPrice");

                    b.Property<double?>("TotalRoomPrice");

                    b.Property<DateTime?>("UpdateDateTime");

                    b.HasKey("Id");

                    b.HasIndex("RezervationId");

                    b.ToTable("Payments");
                });

            modelBuilder.Entity("Core2LearnWebApp.Models.Rezervation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AccommodationType");

                    b.Property<DateTime?>("Arrivaldate");

                    b.Property<string>("BoardType");

                    b.Property<string>("Breakfast");

                    b.Property<DateTime?>("DepartureDate");

                    b.Property<string>("Dinner");

                    b.Property<DateTime?>("InsertDateTime");

                    b.Property<string>("Lunch");

                    b.Property<string>("RoomNo");

                    b.Property<string>("Status");

                    b.Property<int?>("TatolDays");

                    b.Property<int?>("TotalAdult");

                    b.Property<int?>("TotalChildren");

                    b.Property<int?>("TotalChildrenWithPrice");

                    b.Property<int?>("TotalPersons");

                    b.Property<DateTime?>("UpdateDateTime");

                    b.HasKey("Id");

                    b.ToTable("Rezervations");
                });

            modelBuilder.Entity("Core2LearnWebApp.Models.Guest", b =>
                {
                    b.HasOne("Core2LearnWebApp.Models.Rezervation", "Rezervation")
                        .WithMany("Guests")
                        .HasForeignKey("RezervationId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Core2LearnWebApp.Models.Payment", b =>
                {
                    b.HasOne("Core2LearnWebApp.Models.Rezervation", "Rezervation")
                        .WithMany("Payments")
                        .HasForeignKey("RezervationId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
