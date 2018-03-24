namespace performance_tracker
{
    partial class Project_Details
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
            this.lblPrjName = new System.Windows.Forms.Label();
            this.lblPrjDesc = new System.Windows.Forms.Label();
            this.txtPrjName = new System.Windows.Forms.TextBox();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.ProjDGV = new System.Windows.Forms.DataGridView();
            this.ProjId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProjName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProjDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnComp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ProjDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPrjName
            // 
            this.lblPrjName.AutoSize = true;
            this.lblPrjName.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPrjName.Location = new System.Drawing.Point(24, 25);
            this.lblPrjName.Name = "lblPrjName";
            this.lblPrjName.Size = new System.Drawing.Size(71, 13);
            this.lblPrjName.TabIndex = 0;
            this.lblPrjName.Text = "Project Name";
            // 
            // lblPrjDesc
            // 
            this.lblPrjDesc.AutoSize = true;
            this.lblPrjDesc.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPrjDesc.Location = new System.Drawing.Point(24, 65);
            this.lblPrjDesc.Name = "lblPrjDesc";
            this.lblPrjDesc.Size = new System.Drawing.Size(60, 13);
            this.lblPrjDesc.TabIndex = 0;
            this.lblPrjDesc.Text = "Description";
            // 
            // txtPrjName
            // 
            this.txtPrjName.Location = new System.Drawing.Point(108, 18);
            this.txtPrjName.Name = "txtPrjName";
            this.txtPrjName.Size = new System.Drawing.Size(158, 20);
            this.txtPrjName.TabIndex = 1;
            this.txtPrjName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(108, 58);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(306, 20);
            this.txtDesc.TabIndex = 1;
            this.txtDesc.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(24, 96);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(132, 96);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(237, 96);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(339, 96);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ProjDGV
            // 
            this.ProjDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProjDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProjId,
            this.ProjName,
            this.ProjDesc});
            this.ProjDGV.Location = new System.Drawing.Point(24, 134);
            this.ProjDGV.Name = "ProjDGV";
            this.ProjDGV.Size = new System.Drawing.Size(390, 150);
            this.ProjDGV.TabIndex = 3;
            this.ProjDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProjDGV_CellContentClick);
            this.ProjDGV.DoubleClick += new System.EventHandler(this.ProjDGV_DoubleClick);
            // 
            // ProjId
            // 
            this.ProjId.DataPropertyName = "ProjId";
            this.ProjId.HeaderText = "Project Id";
            this.ProjId.Name = "ProjId";
            this.ProjId.Visible = false;
            // 
            // ProjName
            // 
            this.ProjName.DataPropertyName = "ProjName";
            this.ProjName.HeaderText = "Project Name";
            this.ProjName.Name = "ProjName";
            this.ProjName.Width = 150;
            // 
            // ProjDesc
            // 
            this.ProjDesc.DataPropertyName = "ProjDescription";
            this.ProjDesc.HeaderText = "Description";
            this.ProjDesc.Name = "ProjDesc";
            this.ProjDesc.Width = 200;
            // 
            // btnComp
            // 
            this.btnComp.Location = new System.Drawing.Point(294, 290);
            this.btnComp.Name = "btnComp";
            this.btnComp.Size = new System.Drawing.Size(120, 23);
            this.btnComp.TabIndex = 4;
            this.btnComp.Text = "Component Details";
            this.btnComp.UseVisualStyleBackColor = true;
            this.btnComp.Click += new System.EventHandler(this.btnComp_Click);
            // 
            // Project_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(449, 321);
            this.Controls.Add(this.btnComp);
            this.Controls.Add(this.ProjDGV);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.txtPrjName);
            this.Controls.Add(this.lblPrjDesc);
            this.Controls.Add(this.lblPrjName);
            this.Name = "Project_Details";
            this.Text = "Project Details";
            this.Load += new System.EventHandler(this.Project_Details_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProjDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPrjName;
        private System.Windows.Forms.Label lblPrjDesc;
        private System.Windows.Forms.TextBox txtPrjName;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView ProjDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProjId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProjName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProjDesc;
        private System.Windows.Forms.Button btnComp;
    }
}