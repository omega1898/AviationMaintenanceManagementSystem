namespace AviationMaintenanceManagementSystem
{
    partial class MaintenanceDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.workOrdersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.byJobNumberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.workCenterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addPartsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updatePartsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewInventoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewAllInventoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewPartNumberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewWorkCenterInventoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.viewCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allCustomersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.byCustomerIDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allWCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.byWCIDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createWCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateWCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.assignedJobsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Gray;
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.workOrdersToolStripMenuItem,
            this.workCenterToolStripMenuItem,
            this.inventoryToolStripMenuItem,
            this.customerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(10, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1181, 31);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // workOrdersToolStripMenuItem
            // 
            this.workOrdersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createToolStripMenuItem,
            this.updateToolStripMenuItem,
            this.showAllToolStripMenuItem});
            this.workOrdersToolStripMenuItem.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.workOrdersToolStripMenuItem.Name = "workOrdersToolStripMenuItem";
            this.workOrdersToolStripMenuItem.Size = new System.Drawing.Size(136, 25);
            this.workOrdersToolStripMenuItem.Text = "Work Order";
            // 
            // createToolStripMenuItem
            // 
            this.createToolStripMenuItem.Name = "createToolStripMenuItem";
            this.createToolStripMenuItem.Size = new System.Drawing.Size(176, 34);
            this.createToolStripMenuItem.Text = "Create";
            this.createToolStripMenuItem.Click += new System.EventHandler(this.createToolStripMenuItem_Click);
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(176, 34);
            this.updateToolStripMenuItem.Text = "Update";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
            // 
            // showAllToolStripMenuItem
            // 
            this.showAllToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.allToolStripMenuItem,
            this.byJobNumberToolStripMenuItem});
            this.showAllToolStripMenuItem.Name = "showAllToolStripMenuItem";
            this.showAllToolStripMenuItem.Size = new System.Drawing.Size(176, 34);
            this.showAllToolStripMenuItem.Text = "View";
            // 
            // allToolStripMenuItem
            // 
            this.allToolStripMenuItem.Name = "allToolStripMenuItem";
            this.allToolStripMenuItem.Size = new System.Drawing.Size(253, 34);
            this.allToolStripMenuItem.Text = "All";
            this.allToolStripMenuItem.Click += new System.EventHandler(this.viewAllToolStripMenuItem_Click);
            // 
            // byJobNumberToolStripMenuItem
            // 
            this.byJobNumberToolStripMenuItem.Name = "byJobNumberToolStripMenuItem";
            this.byJobNumberToolStripMenuItem.Size = new System.Drawing.Size(253, 34);
            this.byJobNumberToolStripMenuItem.Text = "By Job Number";
            this.byJobNumberToolStripMenuItem.Click += new System.EventHandler(this.viewbyJobNumberToolStripMenuItem_Click);
            // 
            // workCenterToolStripMenuItem
            // 
            this.workCenterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewToolStripMenuItem,
            this.createWCToolStripMenuItem,
            this.updateWCToolStripMenuItem,
            this.assignedJobsToolStripMenuItem});
            this.workCenterToolStripMenuItem.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.workCenterToolStripMenuItem.Name = "workCenterToolStripMenuItem";
            this.workCenterToolStripMenuItem.Size = new System.Drawing.Size(147, 25);
            this.workCenterToolStripMenuItem.Text = "Work Center";
            // 
            // inventoryToolStripMenuItem
            // 
            this.inventoryToolStripMenuItem.BackColor = System.Drawing.Color.Gray;
            this.inventoryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addPartsToolStripMenuItem,
            this.updatePartsToolStripMenuItem,
            this.viewInventoryToolStripMenuItem});
            this.inventoryToolStripMenuItem.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventoryToolStripMenuItem.Name = "inventoryToolStripMenuItem";
            this.inventoryToolStripMenuItem.Size = new System.Drawing.Size(125, 25);
            this.inventoryToolStripMenuItem.Text = "Inventory";
            // 
            // addPartsToolStripMenuItem
            // 
            this.addPartsToolStripMenuItem.Name = "addPartsToolStripMenuItem";
            this.addPartsToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.addPartsToolStripMenuItem.Text = "Add Parts";
            this.addPartsToolStripMenuItem.Click += new System.EventHandler(this.addPartsToolStripMenuItem_Click);
            // 
            // updatePartsToolStripMenuItem
            // 
            this.updatePartsToolStripMenuItem.Name = "updatePartsToolStripMenuItem";
            this.updatePartsToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.updatePartsToolStripMenuItem.Text = "Update Parts";
            // 
            // viewInventoryToolStripMenuItem
            // 
            this.viewInventoryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewAllInventoryToolStripMenuItem,
            this.viewPartNumberToolStripMenuItem,
            this.viewWorkCenterInventoryToolStripMenuItem});
            this.viewInventoryToolStripMenuItem.Name = "viewInventoryToolStripMenuItem";
            this.viewInventoryToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.viewInventoryToolStripMenuItem.Text = "View Inventory";
            // 
            // viewAllInventoryToolStripMenuItem
            // 
            this.viewAllInventoryToolStripMenuItem.Name = "viewAllInventoryToolStripMenuItem";
            this.viewAllInventoryToolStripMenuItem.Size = new System.Drawing.Size(396, 34);
            this.viewAllInventoryToolStripMenuItem.Text = "View All Inventory";
            // 
            // viewPartNumberToolStripMenuItem
            // 
            this.viewPartNumberToolStripMenuItem.Name = "viewPartNumberToolStripMenuItem";
            this.viewPartNumberToolStripMenuItem.Size = new System.Drawing.Size(396, 34);
            this.viewPartNumberToolStripMenuItem.Text = "View Part Number";
            // 
            // viewWorkCenterInventoryToolStripMenuItem
            // 
            this.viewWorkCenterInventoryToolStripMenuItem.Name = "viewWorkCenterInventoryToolStripMenuItem";
            this.viewWorkCenterInventoryToolStripMenuItem.Size = new System.Drawing.Size(396, 34);
            this.viewWorkCenterInventoryToolStripMenuItem.Text = "View Work Center Inventory";
            // 
            // customerToolStripMenuItem
            // 
            this.customerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.updateToolStripMenuItem1,
            this.viewCustomerToolStripMenuItem});
            this.customerToolStripMenuItem.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerToolStripMenuItem.Name = "customerToolStripMenuItem";
            this.customerToolStripMenuItem.Size = new System.Drawing.Size(114, 25);
            this.customerToolStripMenuItem.Text = "Customer";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(330, 34);
            this.addToolStripMenuItem.Text = "Add Customer";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // updateToolStripMenuItem1
            // 
            this.updateToolStripMenuItem1.Name = "updateToolStripMenuItem1";
            this.updateToolStripMenuItem1.Size = new System.Drawing.Size(330, 34);
            this.updateToolStripMenuItem1.Text = "Update Customer Info";
            this.updateToolStripMenuItem1.Click += new System.EventHandler(this.updateToolStripMenuItem1_Click);
            // 
            // viewCustomerToolStripMenuItem
            // 
            this.viewCustomerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.allCustomersToolStripMenuItem,
            this.byCustomerIDToolStripMenuItem});
            this.viewCustomerToolStripMenuItem.Name = "viewCustomerToolStripMenuItem";
            this.viewCustomerToolStripMenuItem.Size = new System.Drawing.Size(330, 34);
            this.viewCustomerToolStripMenuItem.Text = "View Customer";
            // 
            // allCustomersToolStripMenuItem
            // 
            this.allCustomersToolStripMenuItem.Name = "allCustomersToolStripMenuItem";
            this.allCustomersToolStripMenuItem.Size = new System.Drawing.Size(275, 34);
            this.allCustomersToolStripMenuItem.Text = "All Customers";
            this.allCustomersToolStripMenuItem.Click += new System.EventHandler(this.allCustomersToolStripMenuItem_Click);
            // 
            // byCustomerIDToolStripMenuItem
            // 
            this.byCustomerIDToolStripMenuItem.Name = "byCustomerIDToolStripMenuItem";
            this.byCustomerIDToolStripMenuItem.Size = new System.Drawing.Size(275, 34);
            this.byCustomerIDToolStripMenuItem.Text = "By  Customer ID";
            this.byCustomerIDToolStripMenuItem.Click += new System.EventHandler(this.byCustomerIDToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.allWCToolStripMenuItem,
            this.byWCIDToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // allWCToolStripMenuItem
            // 
            this.allWCToolStripMenuItem.Name = "allWCToolStripMenuItem";
            this.allWCToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.allWCToolStripMenuItem.Text = "All W/C";
            // 
            // byWCIDToolStripMenuItem
            // 
            this.byWCIDToolStripMenuItem.Name = "byWCIDToolStripMenuItem";
            this.byWCIDToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.byWCIDToolStripMenuItem.Text = "By W/C ID";
            // 
            // createWCToolStripMenuItem
            // 
            this.createWCToolStripMenuItem.Name = "createWCToolStripMenuItem";
            this.createWCToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.createWCToolStripMenuItem.Text = "Create W/C";
            // 
            // updateWCToolStripMenuItem
            // 
            this.updateWCToolStripMenuItem.Name = "updateWCToolStripMenuItem";
            this.updateWCToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.updateWCToolStripMenuItem.Text = "Update W/C";
            // 
            // assignedJobsToolStripMenuItem
            // 
            this.assignedJobsToolStripMenuItem.Name = "assignedJobsToolStripMenuItem";
            this.assignedJobsToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.assignedJobsToolStripMenuItem.Text = "Assigned Jobs";
            // 
            // MaintenanceDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1181, 775);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Courier New", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MaintenanceDashboard";
            this.Text = "Maintenance Dashboard";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem workOrdersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem workCenterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem byJobNumberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem viewCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allCustomersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem byCustomerIDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addPartsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updatePartsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewInventoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewAllInventoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewPartNumberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewWorkCenterInventoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allWCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem byWCIDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createWCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateWCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem assignedJobsToolStripMenuItem;
    }
}

