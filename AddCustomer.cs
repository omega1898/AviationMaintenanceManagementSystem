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
    public partial class AddCustomer : Form
    {

        private readonly ICustomerFeature _customerFeature;

        public AddCustomer(ICustomerFeature customerFeature)
        {
            _customerFeature = customerFeature;
            InitializeComponent();
            btnSave.Click += btnSave_Click;
            btnCancel.Click += btnCancel_Click;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var customer = new Customer
            {
                Name = txtCustomerName.Text,
                Email = txtCutomerEmail.Text,
                Phone = txtCustomerPhone.Text,
                Address = txtCustomerAddress.Text,
                CustomerId = txtCustomerID.Text
            };
            
            _customerFeature.CreateCustomer(customer);
            MessageBox.Show("Customer Added Successfully");
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
