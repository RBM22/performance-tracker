namespace performance_tracker
{
    partial class OperatorDetails
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
            this.OprtrDGV = new System.Windows.Forms.DataGridView();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.txtOprtrName = new System.Windows.Forms.TextBox();
            this.lblPrjDesc = new System.Windows.Forms.Label();
            this.lblPrjName = new System.Windows.Forms.Label();
            this.OprtrId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OprtrName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OprtrDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.OprtrDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // OprtrDGV
            // 
            this.OprtrDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OprtrDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OprtrId,
            this.OprtrName,
            this.OprtrDesc});
            this.OprtrDGV.Location = new System.Drawing.Point(19, 125);
            this.OprtrDGV.Name = "OprtrDGV";
            this.OprtrDGV.Size = new System.Drawing.Size(390, 150);
            this.OprtrDGV.TabIndex = 12;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(334, 87);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(232, 87);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(127, 87);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(19, 87);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(103, 49);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(306, 20);
            this.txtDesc.TabIndex = 6;
            // 
            // txtOprtrName
            // 
            this.txtOprtrName.Location = new System.Drawing.Point(103, 9);
            this.txtOprtrName.Name = "txtOprtrName";
            this.txtOprtrName.Size = new System.Drawing.Size(158, 20);
            this.txtOprtrName.TabIndex = 7;
            // 
            // lblPrjDesc
            // 
            this.lblPrjDesc.AutoSize = true;
            this.lblPrjDesc.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPrjDesc.Location = new System.Drawing.Point(19, 56);
            this.lblPrjDesc.Name = "lblPrjDesc";
            this.lblPrjDesc.Size = new System.Drawing.Size(60, 13);
            this.lblPrjDesc.TabIndex = 4;
            this.lblPrjDesc.Text = "Description";
            // 
            // lblPrjName
            // 
            this.lblPrjName.AutoSize = true;
            this.lblPrjName.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPrjName.Location = new System.Drawing.Point(19, 16);
            this.lblPrjName.Name = "lblPrjName";
            this.lblPrjName.Size = new System.Drawing.Size(79, 13);
            this.lblPrjName.TabIndex = 5;
            this.lblPrjName.Text = "Operator Name";
            // 
            // OprtrId
            // 
            this.OprtrId.DataPropertyName = "OprtrId";
            this.OprtrId.HeaderText = "Operator Id";
            this.OprtrId.Name = "OprtrId";
            this.OprtrId.Visible = false;
            // 
            // OprtrName
            // 
            this.OprtrName.DataPropertyName = "OprtrName";
            this.OprtrName.HeaderText = "Operator Name";
            this.OprtrName.Name = "OprtrName";
            this.OprtrName.Width = 150;
            // 
            // OprtrDesc
            // 
            this.OprtrDesc.DataPropertyName = "OprtrDescription";
            this.OprtrDesc.HeaderText = "Description";
            this.OprtrDesc.Name = "OprtrDesc";
            this.OprtrDesc.Width = 200;
            // 
            // OperatorDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(432, 287);
            this.Controls.Add(this.OprtrDGV);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.txtOprtrName);
            this.Controls.Add(this.lblPrjDesc);
            this.Controls.Add(this.lblPrjName);
            this.Name = "OperatorDetails";
            this.Text = "Operator Details";
            ((System.ComponentModel.ISupportInitialize)(this.OprtrDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView OprtrDGV;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.TextBox txtOprtrName;
        private System.Windows.Forms.Label lblPrjDesc;
        private System.Windows.Forms.Label lblPrjName;
        private System.Windows.Forms.DataGridViewTextBoxColumn OprtrId;
        private System.Windows.Forms.DataGridViewTextBoxColumn OprtrName;
        private System.Windows.Forms.DataGridViewTextBoxColumn OprtrDesc;
    }
}