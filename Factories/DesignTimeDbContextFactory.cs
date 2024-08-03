using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using AviationMaintenanceManagementSystem.Data_CRUDops_;
using AviationMaintenanceManagementSystem.ModelClasses;


namespace AviationMaintenanceManagementSystem.Factories
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<MaintenanceContext>
    {
        public MaintenanceContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<MaintenanceContext>();
            optionsBuilder.UseSqlite("Data Source=Maintenance.db");
            return new MaintenanceContext(optionsBuilder.Options);
        }
    }
}
