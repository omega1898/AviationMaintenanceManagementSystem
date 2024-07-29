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
    public partial class WorkOrderForm : Form
    {
        private readonly IWorkOrderFeature _workOrderFeature;

        public WorkOrderForm(IWorkOrderFeature workOrderFeature)
        {
            _workOrderFeature = workOrderFeature;
            InitializeComponent();
            LoadWorkOrders();
        }

        private void LoadWorkOrders()
        {
            var workOrders = _workOrderFeature.GetAllWorkOrders();
            workOrderGridView.DataSource = workOrders;
        }

        public WorkOrderForm()
        {
            InitializeComponent();
        }

       
    }
}
