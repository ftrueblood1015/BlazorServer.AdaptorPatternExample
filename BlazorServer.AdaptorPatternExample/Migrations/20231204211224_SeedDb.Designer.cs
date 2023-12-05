﻿// <auto-generated />
using System;
using BlazorServer.AdaptorPatternExample.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BlazorServer.AdaptorPatternExample.Migrations
{
    [DbContext(typeof(AdaptorPatternExampleContext))]
    [Migration("20231204211224_SeedDb")]
    partial class SeedDb
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.25");

            modelBuilder.Entity("BlazorServer.AdaptorPatternExample.Domain.Models.Fruit", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<double?>("Calories")
                        .IsRequired()
                        .HasColumnType("REAL");

                    b.Property<double?>("Carbohydrates")
                        .IsRequired()
                        .HasColumnType("REAL");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<int>("ExternalId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Family")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<double?>("Fat")
                        .IsRequired()
                        .HasColumnType("REAL");

                    b.Property<string>("Genus")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Order")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<double?>("Protein")
                        .IsRequired()
                        .HasColumnType("REAL");

                    b.Property<DateTime?>("RquestedDate")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<double?>("Sugar")
                        .IsRequired()
                        .HasColumnType("REAL");

                    b.HasKey("Id");

                    b.ToTable("Fruits");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Calories = 96.0,
                            Carbohydrates = 22.0,
                            Description = "Banana",
                            ExternalId = 2,
                            Family = "Musaceae",
                            Fat = 0.20000000000000001,
                            Genus = "Musa",
                            Name = "Banana",
                            Order = "Zingiberales",
                            Protein = 0.0,
                            RquestedDate = new DateTime(2023, 12, 4, 13, 12, 24, 746, DateTimeKind.Local).AddTicks(4253),
                            Sugar = 17.199999999999999
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
