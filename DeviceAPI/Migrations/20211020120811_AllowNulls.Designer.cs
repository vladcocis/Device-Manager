﻿// <auto-generated />
using System;
using DeviceAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DeviceAPI.Migrations
{
    [DbContext(typeof(DeviceUserContext))]
    [Migration("20211020120811_AllowNulls")]
    partial class AllowNulls
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DeviceAPI.Models.DeviceDetail", b =>
                {
                    b.Property<int>("DeviceDetailID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DeviceName")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("DeviceType")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Manufacturer")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("OS")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("OSVersion")
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Processor")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("RAM")
                        .HasColumnType("nvarchar(2)");

                    b.Property<int?>("UserID")
                        .HasColumnType("int");

                    b.HasKey("DeviceDetailID");

                    b.ToTable("DeviceDetails");
                });

            modelBuilder.Entity("DeviceAPI.Models.User", b =>
                {
                    b.Property<int>("UserID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Location")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("UserID");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
