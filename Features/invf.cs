using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AviationMaintenanceManagementSystem.ModelClasses;

namespace AviationMaintenanceManagementSystem.Features
{
    public interface IInventoryFeature
    {
        IEnumerable<Inventory> GetAllInventory();
        Inventory GetInventoryByPartNumber(string partNumber);
        void CreateInventory(Inventory inventory);
        void UpdateInventory(Inventory inventory);
        void DeleteInventory(string partNumber);
    }
}
