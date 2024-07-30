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
    public partial class MaintenanceDashboard : Form
    {
        // These are the feature interfaces for dependency injections
        private readonly IWorkOrderFeature _workOrderFeature;
        private readonly IWorkCenterFeature _workCenterFeature;
        private readonly IInventoryFeature _inventoryFeature;
        private readonly ICustomerFeature _customerFeature;

        public MaintenanceDashboard(IWorkOrderFeature workOrderFeature, IWorkCenterFeature workCenterFeature, IInventoryFeature inventoryFeature, ICustomerFeature customerFeature)
        {
            _workOrderFeature = workOrderFeature;
            _workCenterFeature = workCenterFeature;
            _inventoryFeature = inventoryFeature;
            _customerFeature = customerFeature;
            InitializeComponent();
        }
        #region Work Orders
        private void createToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var createWorkOrder = new CreateWorkOrder(_workOrderFeature);
            createWorkOrder.Show();
        }
        private void viewAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var viewAllWorkOrders = new ViewAllWorkOrders(_workOrderFeature);
            viewAllWorkOrders.Show();
        }
        private void viewbyJobNumberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var viewWorkOrderByJobNumber = new ViewWorkOrderByJobNumber(_workOrderFeature);
            viewWorkOrderByJobNumber.Show();
        }
        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var updateWorkOrder = new UpdateWorkOrder(_workOrderFeature);
            updateWorkOrder.Show();
        }

        #endregion

        #region Customer
        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var addCustomer = new AddCustomer(_customerFeature);
            addCustomer.Show();
        }

        #endregion

        #region Work Center

        #endregion

        #region Inventory

        #endregion


    }
}
