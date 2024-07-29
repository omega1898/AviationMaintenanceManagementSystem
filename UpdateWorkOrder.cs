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

namespace AviationMaintenanceManagementSystem
{
    public partial class UpdateWorkOrder : Form
    {
        private readonly IWorkOrderFeature _workOrderFeature;

        private BasicWorkOrder _currentWorkOrder;

        public UpdateWorkOrder(IWorkOrderFeature workOrderFeature)
        {
            _workOrderFeature = workOrderFeature;
            InitializeComponent();

            btnSearch.Click += btnSearch_Click;
            btnSave.Click += btnSave_Click;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(int.TryParse(txtJobNumber.Text, out int jobNumber))
            {
                _currentWorkOrder = _workOrderFeature.GetWorkOrderById(jobNumber);
                if (_currentWorkOrder != null)
                {
                    //Populate the form with the work order details
                    txtDiscrepancy.Text = _currentWorkOrder.Discrepancy;
                    txtNotes.Text = _currentWorkOrder.Notes;
                    txtWorkCenterId.Text = _currentWorkOrder.WorkCenter.Name;
                    txtCorrectiveAction.Text = _currentWorkOrder.CorrectiveAction;
                    txtEquipmentStatus.Text = _currentWorkOrder.EquipmentStatus;
                    txtDate.Text = _currentWorkOrder.Date.ToString();
                    txtTime.Text = _currentWorkOrder.Time.ToString();
                }
                else
                {
                    MessageBox.Show("Work Order not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Invalid Job Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
