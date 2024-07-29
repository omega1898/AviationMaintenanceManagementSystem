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
         private void workOrdersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //This will create a new instance of the WorkOrderForm.
            var workOrders = new WorkOrderForm(_workOrderFeature);
            workOrderForm.Show();
        }
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
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var deleteWorkOrder = new DeleteWorkOrder(_workOrderFeature);
            deleteWorkOrder.Show();
        }
        #endregion

        private void workCenterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //This will create a new instance of the WorkCenterForm.
            var workCenterForm = new WorkCenterForm(_workCenterFeature);
            workCenterForm.Show();
        }

        private void inventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //This will create a new instance of the InventoryForm.
            var inventoryForm = new InventoryForm(_inventoryFeature);
            inventoryForm.Show();
        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //This will create a new instance of the CustomerForm.
            var customerForm = new CustomerForm(_customerFeature);
            customerForm.Show();
        }

       
    }
}
