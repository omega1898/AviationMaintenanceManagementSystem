using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AviationMaintenanceManagementSystem.Features;

namespace AviationMaintenanceManagementSystem.ModelClasses
{
    public class CustomWorkOrder : BasicWorkOrder
    {
        //This is a new property for cases where special inductions are needed of different aviation assets
        //These assets have maintenance schedules that are different from the baselines established.
        public string SpecialInductions { get; set; }


        public override void CreateWorkOrder()
        {
            MessageBox.Show($"You are creating a Custom Work Order: {JobNumber}", "Create Work Order(Custom)", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public override void Process(WorkCenter AssignedWC)
        {
            this.WorkCenter = AssignedWC;
            MessageBox.Show($"You are processing a Custom Work Order: {JobNumber}.Please refer to notes.","In Process...", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
