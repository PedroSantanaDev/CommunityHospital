﻿// <auto-generated />
using System;
using CommunityHospitalApi.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CommunityHospitalApi.Migrations
{
    [DbContext(typeof(CommunityHospitalDbContext))]
    partial class CommunityHospitalDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CommunityHospitalApi.Models.Department", b =>
                {
                    b.Property<Guid>("DepartmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<string>("DepartmentName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ManagerFirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ManagerLastName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DepartmentId");

                    b.ToTable("Department");
                });

            modelBuilder.Entity("CommunityHospitalApi.Models.Medication", b =>
                {
                    b.Property<Guid>("MedicationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("LastPrescribedDate")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("MedicationCost")
                        .HasColumnType("decimal(18,4)");

                    b.Property<string>("MedicationDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PackageSize")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sig")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Strength")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UnitsUsedYtd")
                        .HasColumnType("int");

                    b.HasKey("MedicationId");

                    b.ToTable("Medication");

                    b.HasCheckConstraint("CK_Cost", "MedicationCost >= 0");
                });

            modelBuilder.Entity("CommunityHospitalApi.Models.NursingUnit", b =>
                {
                    b.Property<Guid>("NursingUnitId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Beds")
                        .HasColumnType("int");

                    b.Property<int>("Extension")
                        .HasColumnType("int");

                    b.Property<string>("ManagerFirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ManagerLastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Specialty")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("NursingUnitId");

                    b.ToTable("NursingUnit");
                });
#pragma warning restore 612, 618
        }
    }
}
