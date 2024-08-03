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


//This form is used to create a new work order. It is a child form of the WorkOrderForm form.
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
            {
                var workOrder = new ActualWorkOrder
                {

                    JobNumber = txtJobNumber.Text,
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
        }
    
        

        private void btnCancel_Click(object sender, EventArgs e)
        {
            // Close the form without saving any data
            this.Close();
        }
    }
    
}
