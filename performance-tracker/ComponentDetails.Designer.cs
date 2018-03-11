namespace performance_tracker
{
    partial class ComponentDetails
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
            this.ProjDGV = new System.Windows.Forms.DataGridView();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.txtCompName = new System.Windows.Forms.TextBox();
            this.lblPrjDesc = new System.Windows.Forms.Label();
            this.lblPrjName = new System.Windows.Forms.Label();
            this.CompId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CompName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CompDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ProjDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // ProjDGV
            // 
            this.ProjDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProjDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CompId,
            this.CompName,
            this.CompDesc});
            this.ProjDGV.Location = new System.Drawing.Point(12, 125);
            this.ProjDGV.Name = "ProjDGV";
            this.ProjDGV.Size = new System.Drawing.Size(414, 150);
            this.ProjDGV.TabIndex = 12;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(351, 87);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(238, 87);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(125, 87);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(12, 87);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(120, 49);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(306, 20);
            this.txtDesc.TabIndex = 6;
            // 
            // txtCompName
            // 
            this.txtCompName.Location = new System.Drawing.Point(120, 9);
            this.txtCompName.Name = "txtCompName";
            this.txtCompName.Size = new System.Drawing.Size(158, 20);
            this.txtCompName.TabIndex = 7;
            // 
            // lblPrjDesc
            // 
            this.lblPrjDesc.AutoSize = true;
            this.lblPrjDesc.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPrjDesc.Location = new System.Drawing.Point(12, 56);
            this.lblPrjDesc.Name = "lblPrjDesc";
            this.lblPrjDesc.Size = new System.Drawing.Size(60, 13);
            this.lblPrjDesc.TabIndex = 4;
            this.lblPrjDesc.Text = "Description";
            // 
            // lblPrjName
            // 
            this.lblPrjName.AutoSize = true;
            this.lblPrjName.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPrjName.Location = new System.Drawing.Point(12, 16);
            this.lblPrjName.Name = "lblPrjName";
            this.lblPrjName.Size = new System.Drawing.Size(92, 13);
            this.lblPrjName.TabIndex = 5;
            this.lblPrjName.Text = "Component Name";
            // 
            // CompId
            // 
            this.CompId.DataPropertyName = "CompId";
            this.CompId.HeaderText = "Component Id";
            this.CompId.Name = "CompId";
            this.CompId.Visible = false;
            // 
            // CompName
            // 
            this.CompName.DataPropertyName = "CompName";
            this.CompName.HeaderText = "Component Name";
            this.CompName.Name = "CompName";
            this.CompName.Width = 175;
            // 
            // CompDesc
            // 
            this.CompDesc.DataPropertyName = "CompDescription";
            this.CompDesc.HeaderText = "Description";
            this.CompDesc.Name = "CompDesc";
            this.CompDesc.Width = 225;
            // 
            // ComponentDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(443, 290);
            this.Controls.Add(this.ProjDGV);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.txtCompName);
            this.Controls.Add(this.lblPrjDesc);
            this.Controls.Add(this.lblPrjName);
            this.Name = "ComponentDetails";
            this.Text = "Component Details";
            ((System.ComponentModel.ISupportInitialize)(this.ProjDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ProjDGV;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.TextBox txtCompName;
        private System.Windows.Forms.Label lblPrjDesc;
        private System.Windows.Forms.Label lblPrjName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CompId;
        private System.Windows.Forms.DataGridViewTextBoxColumn CompName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CompDesc;
    }
}