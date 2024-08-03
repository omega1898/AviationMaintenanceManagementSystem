using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AviationMaintenanceManagementSystem.Features;
using System.Windows.Forms;
using AviationMaintenanceManagementSystem.Data_CRUDops_;

namespace AviationMaintenanceManagementSystem.ModelClasses
{
    public class Customer
    {
        public string CustomerId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }   
    }
}
