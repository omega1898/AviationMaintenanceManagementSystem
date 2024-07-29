using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AviationMaintenanceManagementSystem.Features;
using AviationMaintenanceManagementSystem.ModelClasses;
using AviationMaintenanceManagementSystem.Data_CRUDops_;

namespace AviationMaintenanceManagementSystem
{
    public partial class CreateWorkOrder : Form
    {
        private readonly IWorkOrderFeature _workOrderFeature;

        public CreateWorkOrder(IWorkCenterFeature workOrderFeature)
        {
            _workOrderFeature = workOrderFeature();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var workOrder = new SpecialWorkOrder
            {

               JobNumber = Convert.ToInt32(txtJobNumber.Text),
                WorkCenter = txtWorkCenter.Text,
                WorkOrderType = txtWorkOrderType.Text,
                WorkOrderStatus = txtWorkOrderStatus.Text,
                WorkOrderStartDate = Convert.ToDateTime(txtWorkOrderStartDate.Text),
                WorkOrderEndDate = Convert.ToDateTime(txtWorkOrderEndDate.Text),
                WorkOrderPriority = txtWorkOrderPriority.Text,
                WorkOrderDescription = txtWorkOrderDescription.Text,
                WorkOrderNotes = txtWorkOrderNotes.Text,
                WorkOrderLaborHours = Convert.ToInt32(txtWorkOrderLaborHours.Text),
                WorkOrderLaborRate = Convert.ToDecimal(txtWorkOrderLaborRate.Text),
                WorkOrderTotalCost = Convert.ToDecimal(txtWorkOrderTotalCost}
        }
    }
}
