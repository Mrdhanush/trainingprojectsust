using Microsoft.EntityFrameworkCore;
using AllocateResourceAPI.Models;

namespace AllocateResourceAPI.Data
{
    public class ResourceAllContext : DbContext
    {
        public ResourceAllContext(DbContextOptions<ResourceAllContext> options)
            : base(options)
        { }

        public DbSet<ResourceAllocated> ResourceAllocated { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Table Name Configuration (Optional)
            modelBuilder.Entity<ResourceAllocated>().ToTable("ResourceAllocated");

            // Property Configurations
            modelBuilder.Entity<ResourceAllocated>(entity =>
            {
                // Primary Key
                entity.HasKey(e => e.AllocationId);

                // Property Constraints and Configurations
                entity.Property(e => e.ResourceName)
                      .IsRequired() // Makes the column NOT NULL
                      .HasMaxLength(100); // Sets max length for ResourceName

                entity.Property(e => e.Location)
                      .HasMaxLength(200);

                entity.Property(e => e.Severity)
                      .HasMaxLength(50);

                entity.Property(e => e.QuantityAllocated)
                      .IsRequired(); // Makes the column NOT NULL
            });

            // Additional Configurations (if any)
        }
    }
}
