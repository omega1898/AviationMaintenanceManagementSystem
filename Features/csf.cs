using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AviationMaintenanceManagementSystem.ModelClasses;

namespace AviationMaintenanceManagementSystem.Features
{
    public interface ICustomerFeature
    {
        IEnumerable<Customer> GetAllCustomers();
        Customer GetCustomerById(string id);
        void CreateCustomer(Customer customer);
        void UpdateCustomer(Customer customer);
        void DeleteCustomer(string id);
    }
}
