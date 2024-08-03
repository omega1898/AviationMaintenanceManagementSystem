using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AviationMaintenanceManagementSystem.Features;

namespace AviationMaintenanceManagementSystem.ModelClasses
{
    public abstract class WorkOrderTemplate
    {
        public int JobNumber { get; set; }
        public string Discrepancy { get; set; }
        public string CorrectiveAction { get; set; }
        public string Notes { get; set; }
        public DateTime Date { get; set; }
        public DateTime Time { get; set; }
        public string EquipmentStatus { get; set; } 
        public int WorkCenterId { get; set; }   
        public WorkCenter WorkCenter { get; set; }//This is a navigation property

        public  abstract void CreateWorkOrder();
        public abstract void Process(WorkCenter AssignedWC);
    }
}
