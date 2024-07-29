namespace AviationMaintenanceManagementSystem
{
    partial class UpdateWorkOrder
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtJobNumber = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtDiscrepancy = new System.Windows.Forms.TextBox();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.txtEquipmentStatus = new System.Windows.Forms.TextBox();
            this.txtWorkCenterId = new System.Windows.Forms.TextBox();
            this.txtCorrectiveAction = new System.Windows.Forms.TextBox();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Job Number";
            // 
            // txtJobNumber
            // 
            this.txtJobNumber.Location = new System.Drawing.Point(16, 32);
            this.txtJobNumber.Name = "txtJobNumber";
            this.txtJobNumber.Size = new System.Drawing.Size(219, 26);
            this.txtJobNumber.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(241, 30);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(103, 28);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtDiscrepancy
            // 
            this.txtDiscrepancy.Location = new System.Drawing.Point(16, 241);
            this.txtDiscrepancy.Multiline = true;
            this.txtDiscrepancy.Name = "txtDiscrepancy";
            this.txtDiscrepancy.Size = new System.Drawing.Size(486, 115);
            this.txtDiscrepancy.TabIndex = 3;
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(16, 178);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(219, 26);
            this.txtDate.TabIndex = 4;
            // 
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(263, 178);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(219, 26);
            this.txtTime.TabIndex = 5;
            // 
            // txtEquipmentStatus
            // 
            this.txtEquipmentStatus.Location = new System.Drawing.Point(263, 119);
            this.txtEquipmentStatus.Name = "txtEquipmentStatus";
            this.txtEquipmentStatus.Size = new System.Drawing.Size(219, 26);
            this.txtEquipmentStatus.TabIndex = 6;
            // 
            // txtWorkCenterId
            // 
            this.txtWorkCenterId.Location = new System.Drawing.Point(12, 119);
            this.txtWorkCenterId.Name = "txtWorkCenterId";
            this.txtWorkCenterId.Size = new System.Drawing.Size(219, 26);
            this.txtWorkCenterId.TabIndex = 7;
            // 
            // txtCorrectiveAction
            // 
            this.txtCorrectiveAction.Location = new System.Drawing.Point(16, 382);
            this.txtCorrectiveAction.Multiline = true;
            this.txtCorrectiveAction.Name = "txtCorrectiveAction";
            this.txtCorrectiveAction.Size = new System.Drawing.Size(486, 111);
            this.txtCorrectiveAction.TabIndex = 9;
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(12, 519);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(490, 99);
            this.txtNotes.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Work Center";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(259, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Equipment Status";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(259, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Time";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 218);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "Discrepancy";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 359);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(129, 20);
            this.label8.TabIndex = 17;
            this.label8.Text = "Corrective Action";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 496);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 20);
            this.label9.TabIndex = 18;
            this.label9.Text = "Notes";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(35, 655);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(129, 54);
            this.btnSave.TabIndex = 19;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(353, 655);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(129, 54);
            this.button2.TabIndex = 20;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(194, 655);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(129, 54);
            this.btnDelete.TabIndex = 21;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // UpdateWorkOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(519, 731);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNotes);
            this.Controls.Add(this.txtCorrectiveAction);
            this.Controls.Add(this.txtWorkCenterId);
            this.Controls.Add(this.txtEquipmentStatus);
            this.Controls.Add(this.txtTime);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.txtDiscrepancy);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtJobNumber);
            this.Controls.Add(this.label1);
            this.Name = "UpdateWorkOrder";
            this.Text = "UpdateWorkOrder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtJobNumber;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtDiscrepancy;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.TextBox txtEquipmentStatus;
        private System.Windows.Forms.TextBox txtWorkCenterId;
        private System.Windows.Forms.TextBox txtCorrectiveAction;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnDelete;
    }
}