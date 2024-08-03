using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AviationMaintenanceManagementSystem.Features;

namespace AviationMaintenanceManagementSystem.ModelClasses
{
    public class WorkCenter
    {
        public int WorkCenterId { get; set; }
        public string Name { get; set; }
        public string Supervisor { get; set; }
        public string PhoneExtension { get; set; }

        //Navigation Property
        public List<ActualWorkOrder> ActualWorkOrders { get; set; } = new List<ActualWorkOrder>();
    }
    
}
