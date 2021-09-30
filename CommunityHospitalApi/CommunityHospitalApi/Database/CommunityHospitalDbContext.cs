using CommunityHospitalApi.Models;
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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Department>().ToTable("Department");
            modelBuilder.Entity<Medication>().ToTable("Medication");
            modelBuilder.Entity<Medication>(m => m.HasCheckConstraint("CK_Cost", "MedicationCost >= 0"));
            modelBuilder.Entity<Medication>().Property(m => m.MedicationCost).HasColumnType("decimal(18,4)");
        }
    }
}
