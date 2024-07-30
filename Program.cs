using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;
using AviationMaintenanceManagementSystem.Features;
using AviationMaintenanceManagementSystem.Data_CRUDops_;
using AviationMaintenanceManagementSystem.ModelClasses;
using Microsoft.EntityFrameworkCore;

namespace AviationMaintenanceManagementSystem
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Dependency Injection
            var features = new ServiceCollection();
            ConfigureServices(features);

            var serviceProvider = features.BuildServiceProvider();  

            Application.Run(serviceProvider.GetRequiredService<MaintenanceDashboard>());
        }
        private static void ConfigureServices(IServiceCollection features)
        {

            //Db Connection

            features.AddDbContext<MaintenanceContext>(options =>
            {
                options.UseSqlite("Data Source = Maintenance.db");
            });

            //Features connection
            features.AddTransient<IWorkOrderFeature, WorkOrderFeature>();
            features.AddTransient<IWorkCenterFeature, WorkCenterFeature>();
            features.AddTransient<IInventoryFeature, InventoryFeature>();
            features.AddTransient<ICustomerFeature, CustomerFeature>();

            //Forms connection
            features.AddScoped<MaintenanceDashboard>();
        }
    }
}
