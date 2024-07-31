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
using System.Drawing.Text;

namespace AviationMaintenanceManagementSystem
{
    public partial class UpdateCustomer : Form
        {
        private readonly ICustomerFeature _customerFeature;
        private Customer _currentCustomer;

        public UpdateCustomer(ICustomerFeature customerFeature)
        {
            _customerFeature = customerFeature;
            InitializeComponent();
            btnSearch.Click += btnSearch_Click;
            btnSave.Click += btnSave_Click;
            btnCancel.Click += btnCancel_Click;
            btnDelete.Click += btnDelete_Click;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            _currentCustomer = _customerFeature.GetCustomerById(txtCustomerID.Text);

                if (_currentCustomer != null)
                {
                    txtName.Text = _currentCustomer.Name;
                    txtPhone.Text = _currentCustomer.Phone;
                    txtEmail.Text = _currentCustomer.Email;
                    txtAddress.Text = _currentCustomer.Address;
                }
                else
                {
                    MessageBox.Show("Customer not found");
                }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_currentCustomer != null)
            {
                _currentCustomer.Name = txtName.Text;
                _currentCustomer.Phone = txtPhone.Text;
                _currentCustomer.Email = txtEmail.Text;
                _currentCustomer.Address = txtAddress.Text;

                _customerFeature.UpdateCustomer(_currentCustomer);
                MessageBox.Show("Customer Updated");
            }
            else
            {
                MessageBox.Show("Invalid Action");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (_currentCustomer != null)
            {
                _customerFeature.DeleteCustomer(_currentCustomer.CustomerId);
                MessageBox.Show("Customer Deleted");
                Clearfields();
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid Action");
            }
        }

        private void Clearfields()
        {
            txtCustomerID.Text = string.Empty;
            txtName.Text = string.Empty;
            txtPhone.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtAddress.Text = string.Empty;
        }
    }
}
