using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AviationMaintenanceManagementSystem.ModelClasses
{
    public class Inventory
    {
        public string PartNumber { get; set; }
        public string Nomenclature { get; set; }
        public int Quantity { get; set; }
        public decimal PricePerUnit { get; set; }
        public string Manufacturer { get; set; }
        public string DeliveryStatus { get; set; }
    }
}
