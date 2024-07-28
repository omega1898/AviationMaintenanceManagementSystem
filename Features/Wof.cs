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
        IEnumerable<BasicWorkOrder> GetAllWorkOrders();
        BasicWorkOrder GetWorkOrderById(int id);
        void CreateWorkOrder(BasicWorkOrder workOrder);
        void UpdateWorkOrder(BasicWorkOrder workOrder);
        void DeleteWorkOrder(int id);
        void ProcessWorkOrder(int id,WorkCenter AssignedWC);
    }
}
