using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AviationMaintenanceManagementSystem.Features;
using AviationMaintenanceManagementSystem.ModelClasses;

namespace AviationMaintenanceManagementSystem
{
    public partial class AddInventory : Form
    {
        private readonly IInventoryFeature _inventoryFeature;

        public AddInventory(IInventoryFeature inventoryFeature)
        {
            _inventoryFeature = inventoryFeature;
            InitializeComponent();
            btnCancel.Click += btnCancel_Click;
            btnSave.Click += btnSave_Click;
        }
       

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(int.TryParse(txtQuantity.Text, out int quantity) &&
                decimal.TryParse(txtPrice.Text, out decimal pricPerUnit))
            {
                MessageBox.Show("Quantity must be an Integer");
                return;
            }
            var inventory = new Inventory
            {
                PartNumber = txtPartNumber.Text,
                Nomenclature = txtNomenclature.Text,
                Quantity = Convert.ToInt32(txtQuantity.Text),
                PricePerUnit = Convert.ToDecimal(txtPrice.Text),
                Manufacturer = txtManufacturer.Text,
                DeliveryStatus = txtDelivery.Text,
                AssignedJobNumber = txtAssignedJobNumber.Text,
                AssignedWorkCenter = txtWorkCenter.Text,
                RecievedDate = Convert.ToDateTime(txtDateReceived.Text),
                ReceivedBy = txtReceivedBy.Text
            };

            _inventoryFeature.CreateInventory(inventory);
            MessageBox.Show("Inventory Added Successfully");
            ClearForm();
            this.Close();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ClearForm()
        {
            txtPartNumber.Text = "";
            txtNomenclature.Text = "";
            txtQuantity.Text = "";
            txtPrice.Text = "";
            txtManufacturer.Text = "";
            txtDelivery.Text = "";
            txtAssignedJobNumber.Text = "";
            txtWorkCenter.Text = "";
            txtDateReceived.Text = "";
            txtReceivedBy.Text = "";
        }
    }
}
