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
            btnDelete.Click += btnDelete_Click;
            btnCancel.Click += btnCancel_Click;

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

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_currentWorkOrder != null)
            {
                _currentWorkOrder.Discrepancy = txtDiscrepancy.Text;
                _currentWorkOrder.Notes = txtNotes.Text;
                _currentWorkOrder.CorrectiveAction = txtCorrectiveAction.Text;
                _currentWorkOrder.EquipmentStatus = txtEquipmentStatus.Text;
                _currentWorkOrder.Date = DateTime.Parse(txtDate.Text);
                _currentWorkOrder.Time = DateTime.Parse(txtTime.Text);

                _workOrderFeature.UpdateWorkOrder(_currentWorkOrder);
                MessageBox.Show("Work Order Updated", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No Work Order to update", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (_currentWorkOrder != null)
            {
                var confirmDelete = MessageBox.Show("Are you sure you want to delete this Work Order?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmDelete == DialogResult.Yes)
                {
                    _workOrderFeature.DeleteWorkOrder(_currentWorkOrder.JobNumber);
                    txtDiscrepancy.Text = "";
                    txtNotes.Text = "";
                    txtWorkCenterId.Text = "";
                    txtCorrectiveAction.Text = "";
                    txtEquipmentStatus.Text = "";
                    txtDate.Text = "";
                    txtTime.Text = "";
                }
                    
                MessageBox.Show("Work Order Deleted", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No Work Order to delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
