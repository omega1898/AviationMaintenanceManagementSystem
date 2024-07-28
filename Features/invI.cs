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
    public class InventoryFeature : IInventoryFeature
    {
        private readonly MaintenanceContext _context;

        public InventoryFeature(MaintenanceContext context)
        {
            _context = context;
        }

        public IEnumerable<Inventory> GetAllInventory()
        {
            return _context.Inventories.ToList();
        }

        public Inventory GetInventoryByPartNumber(string partNumber)
        {
            var inventory = _context.Inventories.Find(partNumber);
            if (inventory != null)
            {
                return inventory;
            }
            else
            {
                MessageBox.Show($"Inventory with Part Number {partNumber} not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public void CreateInventory(Inventory inventory)
        {
            _context.Inventories.Add(inventory);
            _context.SaveChanges();
        }

        public void UpdateInventory(Inventory inventory)
        {
            _context.Inventories.Update(inventory);
            _context.SaveChanges();
        }

        public void DeleteInventory(string partNumber)
        {
            var inventory = _context.Inventories.Find(partNumber);
            if (inventory != null)
            {
                _context.Inventories.Remove(inventory);
                _context.SaveChanges();
            }
            else
            {
                MessageBox.Show($"Inventory with Part Number {partNumber} not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    } 
}
