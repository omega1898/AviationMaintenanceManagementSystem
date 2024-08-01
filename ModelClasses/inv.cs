using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using AviationMaintenanceManagementSystem.Features;

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
        public string AssignedJobNumber { get; set; }
        public string AssignedWorkCenter { get; set; }
        public DateTime RecievedDate { get; set; }
        public string ReceivedBy { get; set; }
    }
}
