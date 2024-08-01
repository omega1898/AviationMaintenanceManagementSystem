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
    public partial class ViewCustomerById : Form
    {
        private readonly ICustomerFeature _customerFeature;

        public ViewCustomerById(ICustomerFeature customerFeature)
        {
            _customerFeature = customerFeature;
            InitializeComponent();
            btnSearch.Click += btnSearch_Click;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchQuery = txtSearch.Text;

            if (!string.IsNullOrEmpty(searchQuery))
            {
                var customers = _customerFeature.GetAllCustomers()
                    .Where(c => c.CustomerId.Equals(searchQuery, StringComparison.OrdinalIgnoreCase) ||
                                c.Name.Equals(searchQuery, StringComparison.OrdinalIgnoreCase))
                    .ToList();
                dataGridViewResults.DataSource = customers;

                if (customers.Count == 0)
                {
                    MessageBox.Show("No customers found");
                }

            }
            else
            {
                MessageBox.Show("Please enter a valid customer ID");
            }
        }
    }
}