using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AviationMaintenanceManagementSystem.Features;


//This is a new class that inherits from the WorkOrderTemplate class.
namespace AviationMaintenanceManagementSystem.ModelClasses
{
    public class ActualWorkOrder : WorkOrderTemplate
    {

        public override void CreateWorkOrder()
        {

            //You can add any logic here to create a work order, BASED ON CUSTOMER REQUIREMENTS.But all workorders will have the same base template. 
            MessageBox.Show($"You are creating a Work Order: {JobNumber}", "Create Work Order", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
