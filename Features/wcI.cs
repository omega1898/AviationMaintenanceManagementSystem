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
    public class WorkCenterFeature : IWorkCenterFeature
    {
        private readonly MaintenanceContext _context;
        public WorkCenterFeature(MaintenanceContext context)
        {
            _context = context;
        }
        public IEnumerable<WorkCenter> GetAllWorkCenters()
        {
            return _context.WorkCenters.ToList();
        }

        public WorkCenter GetWorkCenterById(int id)
        {
            var workCenter = _context.WorkCenters.Find(id);
            if (workCenter != null)
            {
                return workCenter;
            }
            else
            {
                MessageBox.Show($"WorkCenter {id} not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public void CreateWorkCenter(WorkCenter workCenter)
        {
            _context.WorkCenters.Add(workCenter);
            _context.SaveChanges();
        }

        public void DeleteWorkCenter(int id)
        {
           var workCenter = _context.WorkCenters.Find(id);
            if (workCenter != null)
            {
                _context.WorkCenters.Remove(workCenter);
                _context.SaveChanges();
            }
            else
            {
                MessageBox.Show($"WorkCenter {id} not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        public void UpdateWorkCenter(WorkCenter workCenter)
        {
            _context.WorkCenters.Update(workCenter);
            _context.SaveChanges();
        }
    }
}
