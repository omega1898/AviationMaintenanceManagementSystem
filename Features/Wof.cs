using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AviationMaintenanceManagementSystem.ModelClasses;

//This is an interface that defines the methods that will be used to create, read, update, and delete work orders.
namespace AviationMaintenanceManagementSystem.Features
{
    public interface IWorkOrderFeature
    {
        IEnumerable<WorkOrderTemplate> GetAllWorkOrders();
        WorkOrderTemplate GetWorkOrderById(string id);
        void CreateWorkOrder(WorkOrderTemplate workOrder);
        void UpdateWorkOrder(WorkOrderTemplate workOrder);
        void DeleteWorkOrder(string id);
    }
}
