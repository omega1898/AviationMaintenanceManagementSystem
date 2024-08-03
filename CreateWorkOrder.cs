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

        public CreateWorkOrder(IWorkOrderFeature workOrderFeature)
        {
            _workOrderFeature = workOrderFeature;
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtJobNumber.Text, out _) && int.TryParse(txtWorkCenterId.Text, out _))
            {
            var workOrder = new ActualWorkOrder
            {

                JobNumber = int.Parse(txtJobNumber.Text),
                Discrepancy = txtDiscrepancy.Text,
                CorrectiveAction = txtCorrectiveAction.Text,
                Notes = txtNotes.Text,
                Date = DateTime.Parse(txtDate.Text),
                Time = DateTime.Parse(txtTime.Text),
                EquipmentStatus = txtEquipmentStatus.Text,
                WorkCenterId = int.Parse(txtWorkCenterId.Text)
            };
            _workOrderFeature.CreateWorkOrder(workOrder);
            MessageBox.Show("Work Order Created Successfully");
            this.Close();
        }
            else
            {
                MessageBox.Show("Please enter valid numerical values for Job Number and Work Center ID.");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            // Close the form without saving any data
            this.Close();
        }
    }
    
}
