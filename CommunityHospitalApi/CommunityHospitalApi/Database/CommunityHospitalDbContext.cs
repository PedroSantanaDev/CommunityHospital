﻿using CommunityHospitalApi.Models;
using Microsoft.EntityFrameworkCore;

namespace CommunityHospitalApi.Database
{
    public class CommunityHospitalDbContext : DbContext
    {
        public CommunityHospitalDbContext(DbContextOptions<CommunityHospitalDbContext> options)
    :       base(options)
        { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=CommunityHospitalDb;Integrated Security=True; MultipleActiveResultSets=True");
        }

        public DbSet<Department> Departments { get; set; }
        public DbSet<Medication> Medications { get; set; }
        public DbSet<NursingUnit> NursingUnits { get; set; }
        public DbSet<Physician> Physicians { get; set; }
        public DbSet<Province> Provinces { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Vendor> Vendors { get; set; }
        public DbSet<Admission> Admissions { get; set; }
        public DbSet<Encounter> Encounters { get; set; }

      


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Department>().ToTable("Department");
            modelBuilder.Entity<Medication>().ToTable("Medication");
            modelBuilder.Entity<NursingUnit>().ToTable("NursingUnit");
            modelBuilder.Entity<Physician>().ToTable("Physician");
            modelBuilder.Entity<Province>().ToTable("Province");
            modelBuilder.Entity<Patient>().ToTable("Patient");
            modelBuilder.Entity<Vendor>().ToTable("Vendor");
            modelBuilder.Entity<Admission>().ToTable("Admission");
            modelBuilder.Entity<Encounter>().ToTable("Encounter");

            modelBuilder.Entity<Medication>(m => m.HasCheckConstraint("CK_Cost", "MedicationCost >= 0"));
            modelBuilder.Entity<Medication>().Property(m => m.MedicationCost).HasColumnType("decimal(18,4)");
        }
    }
}
