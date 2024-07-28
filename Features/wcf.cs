using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AviationMaintenanceManagementSystem.ModelClasses;

namespace AviationMaintenanceManagementSystem.Features
{
    public interface IWorkCenterFeature
    {
        IEnumerable<WorkCenter> GetAllWorkCenters();
        WorkCenter GetWorkCenterById(int id);
        void CreateWorkCenter(WorkCenter workCenter);
        void UpdateWorkCenter(WorkCenter workCenter);
        void DeleteWorkCenter(int id);
    }
}
