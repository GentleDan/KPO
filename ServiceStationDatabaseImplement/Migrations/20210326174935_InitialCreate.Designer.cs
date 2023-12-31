﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ServiceStationDatabaseImplement;

namespace ServiceStationDatabaseImplement.Migrations
{
    [DbContext(typeof(ServiceStationDatabase))]
    [Migration("20210326174935_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ServiceStationDatabaseImplement.Models.Car", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CarName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Cars");
                });

            modelBuilder.Entity("ServiceStationDatabaseImplement.Models.CarSparePart", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CarId")
                        .HasColumnType("int");

                    b.Property<int>("SparePartId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CarId");

                    b.HasIndex("SparePartId");

                    b.ToTable("CarSpareParts");
                });

            modelBuilder.Entity("ServiceStationDatabaseImplement.Models.ServiceRecording", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CarId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DatePassed")
                        .HasColumnType("datetime2");

                    b.Property<int>("TechnicalMaintenanceId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CarId");

                    b.HasIndex("TechnicalMaintenanceId");

                    b.HasIndex("UserId");

                    b.ToTable("ServiceRecordings");
                });

            modelBuilder.Entity("ServiceStationDatabaseImplement.Models.SparePart", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("SparePartName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("SparePartPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("SpareParts");
                });

            modelBuilder.Entity("ServiceStationDatabaseImplement.Models.TechnicalMaintenance", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Sum")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("TechnicalMaintenanceName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("TechnicalMaintenances");
                });

            modelBuilder.Entity("ServiceStationDatabaseImplement.Models.TechnicalMaintenanceCar", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CarId")
                        .HasColumnType("int");

                    b.Property<int>("TechnicalMaintenanceId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CarId");

                    b.HasIndex("TechnicalMaintenanceId");

                    b.ToTable("TechnicalMaintenanceCars");
                });

            modelBuilder.Entity("ServiceStationDatabaseImplement.Models.TechnicalMaintenanceWork", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Count")
                        .HasColumnType("int");

                    b.Property<int>("TechnicalMaintenanceId")
                        .HasColumnType("int");

                    b.Property<int>("WorkId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TechnicalMaintenanceId");

                    b.HasIndex("WorkId");

                    b.ToTable("TechnicalMaintenanceWorks");
                });

            modelBuilder.Entity("ServiceStationDatabaseImplement.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FIO")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Position")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("ServiceStationDatabaseImplement.Models.Work", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("WorkName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("WorkPrice")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Works");
                });

            modelBuilder.Entity("ServiceStationDatabaseImplement.Models.WorkDuration", b =>
                {
                    b.Property<int>("WorkId")
                        .HasColumnType("int");

                    b.Property<int>("Duration")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("WorkId");

                    b.HasIndex("UserId");

                    b.ToTable("WorkDurations");
                });

            modelBuilder.Entity("ServiceStationDatabaseImplement.Models.WorkSparePart", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Count")
                        .HasColumnType("int");

                    b.Property<int>("SparePartId")
                        .HasColumnType("int");

                    b.Property<int>("WorkId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SparePartId");

                    b.HasIndex("WorkId");

                    b.ToTable("WorkSpareParts");
                });

            modelBuilder.Entity("ServiceStationDatabaseImplement.Models.Car", b =>
                {
                    b.HasOne("ServiceStationDatabaseImplement.Models.User", "User")
                        .WithMany("Cars")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ServiceStationDatabaseImplement.Models.CarSparePart", b =>
                {
                    b.HasOne("ServiceStationDatabaseImplement.Models.Car", "Car")
                        .WithMany("CarSpareParts")
                        .HasForeignKey("CarId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ServiceStationDatabaseImplement.Models.SparePart", "SparePart")
                        .WithMany("CarSpareParts")
                        .HasForeignKey("SparePartId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ServiceStationDatabaseImplement.Models.ServiceRecording", b =>
                {
                    b.HasOne("ServiceStationDatabaseImplement.Models.Car", "Car")
                        .WithMany("ServiceRecordings")
                        .HasForeignKey("CarId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ServiceStationDatabaseImplement.Models.TechnicalMaintenance", "TechnicalMaintenance")
                        .WithMany("ServiceRecordings")
                        .HasForeignKey("TechnicalMaintenanceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ServiceStationDatabaseImplement.Models.User", "User")
                        .WithMany("ServiceRecordings")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ServiceStationDatabaseImplement.Models.SparePart", b =>
                {
                    b.HasOne("ServiceStationDatabaseImplement.Models.User", "User")
                        .WithMany("SpareParts")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ServiceStationDatabaseImplement.Models.TechnicalMaintenance", b =>
                {
                    b.HasOne("ServiceStationDatabaseImplement.Models.User", "User")
                        .WithMany("TechnicalMaintenances")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ServiceStationDatabaseImplement.Models.TechnicalMaintenanceCar", b =>
                {
                    b.HasOne("ServiceStationDatabaseImplement.Models.Car", "Car")
                        .WithMany("TechnicalMaintenanceCars")
                        .HasForeignKey("CarId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ServiceStationDatabaseImplement.Models.TechnicalMaintenance", "TechnicalMaintenance")
                        .WithMany("TechnicalMaintenanceCars")
                        .HasForeignKey("TechnicalMaintenanceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ServiceStationDatabaseImplement.Models.TechnicalMaintenanceWork", b =>
                {
                    b.HasOne("ServiceStationDatabaseImplement.Models.TechnicalMaintenance", "TechnicalMaintenance")
                        .WithMany("TechnicalMaintenanceWorks")
                        .HasForeignKey("TechnicalMaintenanceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ServiceStationDatabaseImplement.Models.Work", "Work")
                        .WithMany("TechnicalMaintenanceWorks")
                        .HasForeignKey("WorkId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ServiceStationDatabaseImplement.Models.Work", b =>
                {
                    b.HasOne("ServiceStationDatabaseImplement.Models.User", "User")
                        .WithMany("Works")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ServiceStationDatabaseImplement.Models.WorkDuration", b =>
                {
                    b.HasOne("ServiceStationDatabaseImplement.Models.User", "User")
                        .WithMany("WorkDurations")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ServiceStationDatabaseImplement.Models.Work", "Work")
                        .WithOne("WorkDuration")
                        .HasForeignKey("ServiceStationDatabaseImplement.Models.WorkDuration", "WorkId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ServiceStationDatabaseImplement.Models.WorkSparePart", b =>
                {
                    b.HasOne("ServiceStationDatabaseImplement.Models.SparePart", "SparePart")
                        .WithMany("SparePartWorks")
                        .HasForeignKey("SparePartId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ServiceStationDatabaseImplement.Models.Work", "Work")
                        .WithMany("WorkSpareParts")
                        .HasForeignKey("WorkId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
