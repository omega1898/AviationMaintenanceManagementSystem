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
    public partial class ViewAllWorkOrders : Form
    {
        private readonly IWorkOrderFeature _workOrderFeature;

        public ViewAllWorkOrders(IWorkOrderFeature workOrderFeature)
        {
            _workOrderFeature = workOrderFeature;
            InitializeComponent();
        }
        private void ViewAllWorkOrders_Load(object sender, EventArgs e)
        {
            var workOrders = _workOrderFeature.GetAllWorkOrders().ToList();
            workOrderDataGridView.DataSource = workOrders;

        }
    }
}
