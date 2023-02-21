﻿// <auto-generated />
using System;
using System.Collections.Generic;
using FindYourPartyBackend.Data.Models.DbModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace FindYourPartyBackend.Migrations
{
    [DbContext(typeof(ApiDbContext))]
    [Migration("20230221154321_BaseDbContextCreated")]
    partial class BaseDbContextCreated
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("FindYourPartyBackend.Data.Models.DbModels.Club", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int?>("ClubSize")
                        .HasColumnType("integer");

                    b.Property<List<string>>("ClubType")
                        .HasColumnType("jsonb");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<List<string>>("Links")
                        .HasColumnType("jsonb");

                    b.Property<List<string>>("MusicType")
                        .HasColumnType("jsonb");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<int?>("NumberOfRooms")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Clubs");
                });

            modelBuilder.Entity("FindYourPartyBackend.Data.Models.DbModels.ClubAddress", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("integer");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Number")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("ClubAddress");
                });

            modelBuilder.Entity("FindYourPartyBackend.Data.Models.DbModels.ClubOpeningHours", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("integer");

                    b.Property<string>("Friday")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Monday")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Saturday")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Sunday")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Thursday")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Tuesday")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Wednesday")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("ClubOpeningHours");
                });

            modelBuilder.Entity("FindYourPartyBackend.Data.Models.DbModels.Event", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("ClubId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("Date")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("EventHours")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("ClubId");

                    b.ToTable("Events");
                });

            modelBuilder.Entity("FindYourPartyBackend.Data.Models.DbModels.ClubAddress", b =>
                {
                    b.HasOne("FindYourPartyBackend.Data.Models.DbModels.Club", "Club")
                        .WithOne("Address")
                        .HasForeignKey("FindYourPartyBackend.Data.Models.DbModels.ClubAddress", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Club");
                });

            modelBuilder.Entity("FindYourPartyBackend.Data.Models.DbModels.ClubOpeningHours", b =>
                {
                    b.HasOne("FindYourPartyBackend.Data.Models.DbModels.Club", "Club")
                        .WithOne("OpeningHours")
                        .HasForeignKey("FindYourPartyBackend.Data.Models.DbModels.ClubOpeningHours", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Club");
                });

            modelBuilder.Entity("FindYourPartyBackend.Data.Models.DbModels.Event", b =>
                {
                    b.HasOne("FindYourPartyBackend.Data.Models.DbModels.Club", "Club")
                        .WithMany("Events")
                        .HasForeignKey("ClubId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Club");
                });

            modelBuilder.Entity("FindYourPartyBackend.Data.Models.DbModels.Club", b =>
                {
                    b.Navigation("Address")
                        .IsRequired();

                    b.Navigation("Events");

                    b.Navigation("OpeningHours")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
