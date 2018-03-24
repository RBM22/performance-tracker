namespace performance_tracker.Forms
{
    partial class Machine_Details
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
            this.lblMachId = new System.Windows.Forms.Label();
            this.lblMachName = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MachId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MachName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MachDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MachineId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnProj = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMachId
            // 
            this.lblMachId.AutoSize = true;
            this.lblMachId.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblMachId.Location = new System.Drawing.Point(12, 13);
            this.lblMachId.Name = "lblMachId";
            this.lblMachId.Size = new System.Drawing.Size(62, 13);
            this.lblMachId.TabIndex = 0;
            this.lblMachId.Text = "Machine ID";
            // 
            // lblMachName
            // 
            this.lblMachName.AutoSize = true;
            this.lblMachName.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblMachName.Location = new System.Drawing.Point(12, 45);
            this.lblMachName.Name = "lblMachName";
            this.lblMachName.Size = new System.Drawing.Size(79, 13);
            this.lblMachName.TabIndex = 0;
            this.lblMachName.Text = "Machine Name";
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblDesc.Location = new System.Drawing.Point(12, 77);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(60, 13);
            this.lblDesc.TabIndex = 0;
            this.lblDesc.Text = "Description";
            this.lblDesc.Click += new System.EventHandler(this.lblDesc_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(106, 10);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(106, 42);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(167, 20);
            this.textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(106, 74);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(279, 20);
            this.textBox3.TabIndex = 1;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MachId,
            this.MachName,
            this.MachDesc,
            this.MachineId});
            this.dataGridView1.Location = new System.Drawing.Point(12, 132);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(424, 150);
            this.dataGridView1.TabIndex = 2;
            // 
            // MachId
            // 
            this.MachId.DataPropertyName = "Machid";
            this.MachId.HeaderText = "MachineId";
            this.MachId.Name = "MachId";
            // 
            // MachName
            // 
            this.MachName.DataPropertyName = "MachName";
            this.MachName.HeaderText = "Machine Name";
            this.MachName.Name = "MachName";
            // 
            // MachDesc
            // 
            this.MachDesc.DataPropertyName = "MachDesc";
            this.MachDesc.HeaderText = "Description";
            this.MachDesc.Name = "MachDesc";
            // 
            // MachineId
            // 
            this.MachineId.DataPropertyName = "MachineID";
            this.MachineId.HeaderText = "Machine Id";
            this.MachineId.Name = "MachineId";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(12, 103);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(128, 103);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(244, 103);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(360, 103);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnProj
            // 
            this.btnProj.Location = new System.Drawing.Point(350, 294);
            this.btnProj.Name = "btnProj";
            this.btnProj.Size = new System.Drawing.Size(85, 23);
            this.btnProj.TabIndex = 4;
            this.btnProj.Text = "Project Details";
            this.btnProj.UseVisualStyleBackColor = true;
            this.btnProj.Click += new System.EventHandler(this.btnProj_Click);
            // 
            // Machine_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(448, 328);
            this.Controls.Add(this.btnProj);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.lblMachName);
            this.Controls.Add(this.lblMachId);
            this.Name = "Machine_Details";
            this.Text = "Machine Details";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMachId;
        private System.Windows.Forms.Label lblMachName;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridViewTextBoxColumn MachId;
        private System.Windows.Forms.DataGridViewTextBoxColumn MachName;
        private System.Windows.Forms.DataGridViewTextBoxColumn MachDesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn MachineId;
        private System.Windows.Forms.Button btnProj;
    }
}