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
            string jobNumber = txtJobNumber.Text;
            
                var workOrder = _workOrderFeature.GetWorkOrderById(jobNumber);
                if (workOrder != null)
                {
                    workOrderDataGridView.DataSource = new[] { workOrder };
                }
           
            
            else
            {
                MessageBox.Show("Job Not Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
