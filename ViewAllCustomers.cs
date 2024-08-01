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
    public partial class ViewAllCustomers : Form
    {
        private readonly ICustomerFeature _customerFeature;

        public ViewAllCustomers(ICustomerFeature customerFeature)
        {
            _customerFeature = customerFeature;
            InitializeComponent();
        }


        private void ViewAllCustomers_Load(object sender, EventArgs e)
        {
            var customers = _customerFeature.GetAllCustomers();
            dataGridView1.DataSource = customers;
        }

    }
}
