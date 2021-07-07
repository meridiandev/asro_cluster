﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using asro_api.Data;

namespace asro_api.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20210707191840_InitialDatabaseMigration")]
    partial class InitialDatabaseMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.7")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("asro_api.Data.Models.thReports_1", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("EventData")
                        .HasColumnType("datetime2");

                    b.Property<string>("EventDocument")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EventForm")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EventFullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EventHours")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EventLevel")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EventNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EventWho")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsLockReport")
                        .HasColumnType("bit");

                    b.Property<DateTime>("ReportTimeAddIs")
                        .HasColumnType("datetime2");

                    b.Property<string>("TeatcherFullName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("thReports_1");
                });
#pragma warning restore 612, 618
        }
    }
}
