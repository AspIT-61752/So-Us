﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SoUs.DataAccess;

#nullable disable

namespace SoUs.DataAccess.Migrations
{
    [DbContext(typeof(SoUsDbContext))]
    partial class SoUsDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("AssignmentEmployee", b =>
                {
                    b.Property<int>("AssignmentsAssignmentId")
                        .HasColumnType("int");

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.HasKey("AssignmentsAssignmentId", "EmployeeId");

                    b.HasIndex("EmployeeId");

                    b.ToTable("AssignmentEmployee");
                });

            modelBuilder.Entity("EmployeeRole", b =>
                {
                    b.Property<int>("EmployeesEmployeeId")
                        .HasColumnType("int");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("EmployeesEmployeeId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("EmployeeRole");
                });

            modelBuilder.Entity("SoUs.Entity.Address", b =>
                {
                    b.Property<int>("AddressId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AddressId"));

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Zip")
                        .HasColumnType("int");

                    b.HasKey("AddressId");

                    b.ToTable("Addresses");

                    b.HasData(
                        new
                        {
                            AddressId = 1,
                            City = "Vejle",
                            State = "Region Syddanmark",
                            Street = "Boulevarden 48",
                            Zip = 7100
                        });
                });

            modelBuilder.Entity("SoUs.Entity.Assignment", b =>
                {
                    b.Property<int>("AssignmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AssignmentId"));

                    b.Property<bool>("IsComplete")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ResidentId")
                        .HasColumnType("int");

                    b.Property<DateTime>("TimeEnd")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("TimeStart")
                        .HasColumnType("datetime2");

                    b.HasKey("AssignmentId");

                    b.HasIndex("ResidentId");

                    b.ToTable("Assignments");

                    b.HasData(
                        new
                        {
                            AssignmentId = 1,
                            IsComplete = false,
                            Name = "Hjælp til at komme ud af sengen",
                            ResidentId = 1,
                            TimeEnd = new DateTime(2024, 6, 4, 12, 8, 14, 626, DateTimeKind.Local).AddTicks(8647),
                            TimeStart = new DateTime(2024, 6, 4, 11, 53, 14, 626, DateTimeKind.Local).AddTicks(8600)
                        },
                        new
                        {
                            AssignmentId = 2,
                            IsComplete = false,
                            Name = "Hjælp til at komme i bad",
                            ResidentId = 1,
                            TimeEnd = new DateTime(2024, 6, 4, 12, 23, 14, 626, DateTimeKind.Local).AddTicks(8670),
                            TimeStart = new DateTime(2024, 6, 4, 12, 8, 14, 626, DateTimeKind.Local).AddTicks(8668)
                        },
                        new
                        {
                            AssignmentId = 3,
                            IsComplete = false,
                            Name = "Give medicin",
                            ResidentId = 1,
                            TimeEnd = new DateTime(2024, 6, 4, 12, 33, 14, 626, DateTimeKind.Local).AddTicks(8686),
                            TimeStart = new DateTime(2024, 6, 4, 12, 23, 14, 626, DateTimeKind.Local).AddTicks(8684)
                        });
                });

            modelBuilder.Entity("SoUs.Entity.CareCenter", b =>
                {
                    b.Property<int>("CareCenterId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CareCenterId"));

                    b.Property<int>("AddressId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CareCenterId");

                    b.HasIndex("AddressId");

                    b.ToTable("CareCenters");

                    b.HasData(
                        new
                        {
                            CareCenterId = 1,
                            AddressId = 1,
                            Name = "Vejle Kommune - Alderdomshjem"
                        });
                });

            modelBuilder.Entity("SoUs.Entity.Diagnosis", b =>
                {
                    b.Property<int>("DiagnosisId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DiagnosisId"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ResidentId")
                        .HasColumnType("int");

                    b.HasKey("DiagnosisId");

                    b.HasIndex("ResidentId");

                    b.ToTable("Diagnoses");

                    b.HasData(
                        new
                        {
                            DiagnosisId = 1,
                            Description = "Attention Deficit Hyperactivity Disorder",
                            Name = "ADHD"
                        },
                        new
                        {
                            DiagnosisId = 2,
                            Description = "Autism Spectrum Disorder",
                            Name = "Autisme"
                        });
                });

            modelBuilder.Entity("SoUs.Entity.Employee", b =>
                {
                    b.Property<int>("EmployeeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EmployeeId"));

                    b.Property<int>("CareCenterId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EmployeeId");

                    b.HasIndex("CareCenterId");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            EmployeeId = 1,
                            CareCenterId = 1,
                            Name = "Mads Mikkelsen"
                        },
                        new
                        {
                            EmployeeId = 2,
                            CareCenterId = 1,
                            Name = "Morten Bossen"
                        },
                        new
                        {
                            EmployeeId = 3,
                            CareCenterId = 1,
                            Name = "Michael Jensen"
                        });
                });

            modelBuilder.Entity("SoUs.Entity.Medicine", b =>
                {
                    b.Property<int>("MedicineId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MedicineId"));

                    b.Property<bool>("Administered")
                        .HasColumnType("bit");

                    b.Property<int?>("AssignmentId")
                        .HasColumnType("int");

                    b.Property<int>("Dosage")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Unit")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MedicineId");

                    b.HasIndex("AssignmentId");

                    b.ToTable("Medicine");

                    b.HasData(
                        new
                        {
                            MedicineId = 1,
                            Administered = false,
                            AssignmentId = 3,
                            Dosage = 1,
                            Name = "Panodil",
                            Unit = "stk"
                        });
                });

            modelBuilder.Entity("SoUs.Entity.Prescription", b =>
                {
                    b.Property<int>("PrescriptionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PrescriptionId"));

                    b.Property<int>("Dosage")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ResidentId")
                        .HasColumnType("int");

                    b.Property<string>("Unit")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PrescriptionId");

                    b.HasIndex("ResidentId");

                    b.ToTable("Prescriptions");
                });

            modelBuilder.Entity("SoUs.Entity.Resident", b =>
                {
                    b.Property<int>("ResidentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ResidentId"));

                    b.Property<int?>("CareCenterId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Notes")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoomNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ResidentId");

                    b.HasIndex("CareCenterId");

                    b.ToTable("Residents");

                    b.HasData(
                        new
                        {
                            ResidentId = 1,
                            CareCenterId = 1,
                            Name = "Jens Hansen",
                            Notes = "Jens er en stille og rolig mand, der elsker at læse bøger. Han har brug for hjælp til at komme ud af sengen og til at komme i bad.",
                            RoomNumber = "A1"
                        });
                });

            modelBuilder.Entity("SoUs.Entity.Role", b =>
                {
                    b.Property<int>("RoleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RoleId"));

                    b.Property<string>("RoleName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RoleId");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("AssignmentEmployee", b =>
                {
                    b.HasOne("SoUs.Entity.Assignment", null)
                        .WithMany()
                        .HasForeignKey("AssignmentsAssignmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SoUs.Entity.Employee", null)
                        .WithMany()
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EmployeeRole", b =>
                {
                    b.HasOne("SoUs.Entity.Employee", null)
                        .WithMany()
                        .HasForeignKey("EmployeesEmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SoUs.Entity.Role", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SoUs.Entity.Assignment", b =>
                {
                    b.HasOne("SoUs.Entity.Resident", "Resident")
                        .WithMany()
                        .HasForeignKey("ResidentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Resident");
                });

            modelBuilder.Entity("SoUs.Entity.CareCenter", b =>
                {
                    b.HasOne("SoUs.Entity.Address", "Address")
                        .WithMany()
                        .HasForeignKey("AddressId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Address");
                });

            modelBuilder.Entity("SoUs.Entity.Diagnosis", b =>
                {
                    b.HasOne("SoUs.Entity.Resident", null)
                        .WithMany("Diagnosis")
                        .HasForeignKey("ResidentId");
                });

            modelBuilder.Entity("SoUs.Entity.Employee", b =>
                {
                    b.HasOne("SoUs.Entity.CareCenter", "CareCenter")
                        .WithMany()
                        .HasForeignKey("CareCenterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CareCenter");
                });

            modelBuilder.Entity("SoUs.Entity.Medicine", b =>
                {
                    b.HasOne("SoUs.Entity.Assignment", null)
                        .WithMany("Medicine")
                        .HasForeignKey("AssignmentId");
                });

            modelBuilder.Entity("SoUs.Entity.Prescription", b =>
                {
                    b.HasOne("SoUs.Entity.Resident", null)
                        .WithMany("Prescriptions")
                        .HasForeignKey("ResidentId");
                });

            modelBuilder.Entity("SoUs.Entity.Resident", b =>
                {
                    b.HasOne("SoUs.Entity.CareCenter", null)
                        .WithMany("Residents")
                        .HasForeignKey("CareCenterId");
                });

            modelBuilder.Entity("SoUs.Entity.Assignment", b =>
                {
                    b.Navigation("Medicine");
                });

            modelBuilder.Entity("SoUs.Entity.CareCenter", b =>
                {
                    b.Navigation("Residents");
                });

            modelBuilder.Entity("SoUs.Entity.Resident", b =>
                {
                    b.Navigation("Diagnosis");

                    b.Navigation("Prescriptions");
                });
#pragma warning restore 612, 618
        }
    }
}
