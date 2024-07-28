using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AviationMaintenanceManagementSystem.ModelClasses;

namespace AviationMaintenanceManagementSystem.Data_CRUDops_
{
    public class MaintenanceContext : DbContext
    {
        //These are proprties that basically represent the tables in the database.
        public DbSet<BasicWorkOrder> WorkOrders { get; set; }
        public DbSet<WorkCenter> WorkCenters { get; set; }
        public DbSet<Inventory> Inventories { get; set; }
        public DbSet<Customer> Customers { get; set; }

        //In the next portion the Db is being configured.
        //Were usiing SQLite as the database provider.
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=Maintenance.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BasicWorkOrder>(entity =>
            {
                entity.HasKey(e => e.JobNumber);//Primary Key
                entity.Property(e => e.Discrepancy).IsRequired().HasMaxLength(500);
                entity.Property(e => e.CorrectiveAction).IsRequired().HasMaxLength(500);
                entity.Property(e => e.Notes).HasMaxLength(500);
                entity.Property(e => e.Date).IsRequired();
                entity.Property(e => e.Time).IsRequired();
                entity.Property(e => e.EquipmentStatus).IsRequired();
                entity.HasOne(e => e.WorkCenter) //Each work order will have one work center
                       .WithMany(wc => wc.BasicWorkOrders) // Each work center will have many work orders
                       .HasForeignKey(e => e.WorkCenterId); // Foreign Key
            });

            modelBuilder.Entity<WorkCenter>(entity =>
            {
                entity.HasKey(e => e.WorkCenterId); //Primary Key
                entity.Property(e => e.Name).IsRequired().HasMaxLength(50);
                entity.Property(e => e.Supervisor).IsRequired().HasMaxLength(50);
                entity.Property(e => e.PhoneExtension).IsRequired().HasMaxLength(12);
            });

            modelBuilder.Entity<Inventory>(entity =>
            {
                entity.HasKey(e => e.PartNumber); //Primary Key
                entity.Property(e => e.Nomenclature).IsRequired().HasMaxLength(100);
                entity.Property(e => e.Quantity).IsRequired();
                entity.Property(e => e.PricePerUnit).IsRequired();
                entity.Property(e => e.Manufacturer).IsRequired().HasMaxLength(50);
                entity.Property(e => e.DeliveryStatus).IsRequired().HasMaxLength(100);

            });
            
            modelBuilder.Entity<Customer>(entity =>
            {
                entity.HasKey(e => e.CustomerId); //Primary Key
                entity.Property(e => e.Name).IsRequired().HasMaxLength(50);
                entity.Property(e => e.Phone).IsRequired().HasMaxLength(12);
                entity.Property(e => e.Email).IsRequired().HasMaxLength(50);
                entity.Property(e => e.Address).IsRequired().HasMaxLength(100);
            });
               
        }
    }
}
