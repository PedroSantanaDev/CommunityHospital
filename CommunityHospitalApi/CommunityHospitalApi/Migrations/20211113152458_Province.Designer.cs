﻿// <auto-generated />
using System;
using CommunityHospitalApi.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CommunityHospitalApi.Migrations
{
    [DbContext(typeof(CommunityHospitalDbContext))]
    [Migration("20211113152458_Province")]
    partial class Province
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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
                    b.Property<string>("NursingUnitId")
                        .HasColumnType("nvarchar(450)");

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

            modelBuilder.Entity("CommunityHospitalApi.Models.Physician", b =>
                {
                    b.Property<Guid>("PhysicianId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OHIPRegistration")
                        .HasColumnType("int");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Specialty")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PhysicianId");

                    b.ToTable("Physician");
                });

            modelBuilder.Entity("CommunityHospitalApi.Models.Province", b =>
                {
                    b.Property<Guid>("ProvinceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ProvinceCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProvinceName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProvinceId");

                    b.ToTable("Province");
                });
#pragma warning restore 612, 618
        }
    }
}
