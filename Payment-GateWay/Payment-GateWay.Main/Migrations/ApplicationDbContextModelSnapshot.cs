﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Payment_GateWay.Main.Data;

#nullable disable

namespace Payment_Gateway.main.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Shared.Models.UserPlan", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("PlanType")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<long?>("Price")
                        .HasColumnType("bigint");

                    b.Property<string>("User")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 5,
                            PlanType = "Premium",
                            Price = 5L,
                            User = "palnUserName"
                        },
                        new
                        {
                            Id = 10,
                            PlanType = "Premium",
                            Price = 10L,
                            User = "palnUserName"
                        },
                        new
                        {
                            Id = 15,
                            PlanType = "Premium",
                            Price = 15L,
                            User = "palnUserName"
                        },
                        new
                        {
                            Id = 20,
                            PlanType = "Premium",
                            Price = 20L,
                            User = "palnUserName"
                        },
                        new
                        {
                            Id = 25,
                            PlanType = "Premium",
                            Price = 25L,
                            User = "palnUserName"
                        },
                        new
                        {
                            Id = 30,
                            PlanType = "Premium",
                            Price = 30L,
                            User = "palnUserName"
                        },
                        new
                        {
                            Id = 35,
                            PlanType = "Premium",
                            Price = 35L,
                            User = "palnUserName"
                        },
                        new
                        {
                            Id = 40,
                            PlanType = "Premium",
                            Price = 40L,
                            User = "palnUserName"
                        },
                        new
                        {
                            Id = 45,
                            PlanType = "Premium",
                            Price = 45L,
                            User = "palnUserName"
                        },
                        new
                        {
                            Id = 50,
                            PlanType = "Premium",
                            Price = 50L,
                            User = "palnUserName"
                        },
                        new
                        {
                            Id = 55,
                            PlanType = "Premium",
                            Price = 55L,
                            User = "palnUserName"
                        },
                        new
                        {
                            Id = 60,
                            PlanType = "Premium",
                            Price = 60L,
                            User = "palnUserName"
                        },
                        new
                        {
                            Id = 65,
                            PlanType = "Premium",
                            Price = 65L,
                            User = "palnUserName"
                        },
                        new
                        {
                            Id = 70,
                            PlanType = "Premium",
                            Price = 70L,
                            User = "palnUserName"
                        },
                        new
                        {
                            Id = 75,
                            PlanType = "Premium",
                            Price = 75L,
                            User = "palnUserName"
                        },
                        new
                        {
                            Id = 80,
                            PlanType = "Premium",
                            Price = 80L,
                            User = "palnUserName"
                        },
                        new
                        {
                            Id = 85,
                            PlanType = "Premium",
                            Price = 85L,
                            User = "palnUserName"
                        },
                        new
                        {
                            Id = 90,
                            PlanType = "Premium",
                            Price = 90L,
                            User = "palnUserName"
                        },
                        new
                        {
                            Id = 95,
                            PlanType = "Premium",
                            Price = 95L,
                            User = "palnUserName"
                        },
                        new
                        {
                            Id = 100,
                            PlanType = "Premium",
                            Price = 100L,
                            User = "palnUserName"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
