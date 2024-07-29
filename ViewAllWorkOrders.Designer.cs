namespace AviationMaintenanceManagementSystem
{
    partial class ViewAllWorkOrders
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
            this.workOrderDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.workOrderDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // workOrderDataGridView
            // 
            this.workOrderDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.workOrderDataGridView.Location = new System.Drawing.Point(3, 4);
            this.workOrderDataGridView.Name = "workOrderDataGridView";
            this.workOrderDataGridView.RowHeadersWidth = 62;
            this.workOrderDataGridView.RowTemplate.Height = 28;
            this.workOrderDataGridView.Size = new System.Drawing.Size(1370, 1089);
            this.workOrderDataGridView.TabIndex = 0;
            // 
            // ViewAllWorkOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 1090);
            this.Controls.Add(this.workOrderDataGridView);
            this.Name = "ViewAllWorkOrders";
            this.Text = "ViewAllWorkOrders";
            ((System.ComponentModel.ISupportInitialize)(this.workOrderDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView workOrderDataGridView;
    }
}