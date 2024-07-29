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

namespace AviationMaintenanceManagementSystem
{
    public partial class ViewWorkOrderByJobNumber : Form
    {
        private readonly IWorkOrderFeature _workOrderFeature;

        public ViewWorkOrderByJobNumber(IWorkOrderFeature workOrderFeature)
        {
            _workOrderFeature = workOrderFeature;
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtJobNumber.Text, out int jobNumber))
            {
                var workOrder = _workOrderFeature.GetWorkOrderById(jobNumber);
                if (workOrder != null)
                {
                    workOrderDataGridView.DataSource = new[] { workOrder };
                }
                else
                {
                    MessageBox.Show("Work Order not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid Job Number", "Invalid Job Number", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
