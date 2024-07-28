using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using AviationMaintenanceManagementSystem.Features;

namespace AviationMaintenanceManagementSystem.ModelClasses
{
    public class CustomWorkOrder : BasicWorkOrder
    {
        //This is a new property for cases where special inductions are needed of different aviation assets
        //These assets have maintenance schedules that are different from the baselines established.
        public string SpecialInductions { get; set; }


        public override void CreateWorkOrder()
        {
            //You would add special processes here for creating a work order for a custom work order.
            Console.WriteLine("Special Intructions to be added in the notes.");
        }
    }
}
