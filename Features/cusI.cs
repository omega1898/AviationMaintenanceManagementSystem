using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AviationMaintenanceManagementSystem.ModelClasses;
using AviationMaintenanceManagementSystem.Data_CRUDops_;
using System.Windows.Forms;

namespace AviationMaintenanceManagementSystem.Features
{
    internal class CustomerFeature : ICustomerFeature
    {
        private readonly MaintenanceContext _context;

        public CustomerFeature(MaintenanceContext context)
        {
            _context = context;
        }
        public IEnumerable<Customer> GetAllCustomers()
        {
            return _context.Customers.ToList();
        }
        public Customer GetCustomerById(string id)
        {
            var customer = _context.Customers.Find(id);
            if (customer != null)
            {
                return customer;
            }
            else
            {
                MessageBox.Show($"Customer with ID {id} not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
        public void CreateCustomer(Customer customer)
        {
            _context.Customers.Add(customer);
            _context.SaveChanges();
        }
        public void DeleteCustomer(string id)
        {
            var customer = _context.Customers.Find(id);
            if (customer != null)
            {
                _context.Customers.Remove(customer);
                _context.SaveChanges();
            }
            else
            {
                MessageBox.Show($"Customer with ID {id} not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void UpdateCustomer(Customer customer)
        {
            _context.Customers.Update(customer);
            _context.SaveChanges();
        }
    }
}