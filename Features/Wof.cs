using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AviationMaintenanceManagementSystem.ModelClasses;

namespace AviationMaintenanceManagementSystem.Features
{
    public interface IWorkOrderFeature
    {
        IEnumerable<WorkOrderTemplate> GetAllWorkOrders();
        WorkOrderTemplate GetWorkOrderById(int id);
        void CreateWorkOrder(WorkOrderTemplate workOrder);
        void UpdateWorkOrder(WorkOrderTemplate workOrder);
        void DeleteWorkOrder(int id);
    }
}
