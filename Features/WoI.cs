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
    public class WorkOrderFeature : IWorkOrderFeature
    {
        private readonly MaintenanceContext _context; //This should not be edited/visible. This is basically the Db dependency injection. 

        public WorkOrderFeature(MaintenanceContext context)//The "context" is the Db dependency injection. Its basically an isntance of the db.
        {
            _context = context;
        }
        public IEnumerable<BasicWorkOrder> GetAllWorkOrders()
        {
            //Thisn is to retrieve all work orders from the database.
            return _context.WorkOrders.ToList();
        }
        public BasicWorkOrder GetWorkOrderById(int id)
        {
            //This is to retrieve a specific work order by its id(which is the job number) from the database.
            var workOrder = _context.WorkOrders.Find(id);
            if (workOrder != null)
            {
                return workOrder;
            }
            else
            {
                MessageBox.Show($"Work Order {id} not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
        public void CreateWorkOrder(BasicWorkOrder workOrder)
        {
            //Create a new work order in the database.
            _context.WorkOrders.Add(workOrder);
            //You have to save the changes to the database.
            _context.SaveChanges();
        }
        public void DeleteWorkOrder(int id)
        {
            //This is to delete a work order from the database.
            var workOrder = _context.WorkOrders.Find(id);
            if (workOrder != null)
            {
                _context.WorkOrders.Remove(workOrder);
                _context.SaveChanges();
            }
            else
            {
                MessageBox.Show($"Work Order {id} not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public void UpdateWorkOrder(BasicWorkOrder workOrder)
        {
            //Update and save changes to a work order.
            _context.WorkOrders.Update(workOrder);
            _context.SaveChanges();
        }
        public void ProcessWorkOrder(int id, WorkCenter AssignedWC)
        {
            //This is to process a work order.Which basically is assgining the work order to a work center.
            var workOrder = _context.WorkOrders.Find(id);
            if (workOrder != null)
            {
                workOrder.Process(AssignedWC);
                _context.SaveChanges();
            }
            else
            {
                MessageBox.Show($"Work Order {id} not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
