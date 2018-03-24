namespace performance_tracker
{
    partial class OperationDetails
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
            this.btnSave = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.lblOprnId = new System.Windows.Forms.Label();
            this.lblOprnName = new System.Windows.Forms.Label();
            this.lblCT = new System.Windows.Forms.Label();
            this.lblDT = new System.Windows.Forms.Label();
            this.txtOpId = new System.Windows.Forms.TextBox();
            this.txtDTime = new System.Windows.Forms.TextBox();
            this.txtOpName = new System.Windows.Forms.TextBox();
            this.txtCTime = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.OprnDGV = new System.Windows.Forms.DataGridView();
            this.OpId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OprtrId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OprnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OprnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Deleted = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DelayTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CycleTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PtcID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblPTC = new System.Windows.Forms.Label();
            this.cmbPTC = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnOprtr = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.OprnDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(9, 155);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(193, 155);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 0;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(377, 155);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 0;
            this.button3.Text = "Clear";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(561, 155);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 0;
            this.button4.Text = "Close";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // lblOprnId
            // 
            this.lblOprnId.AutoSize = true;
            this.lblOprnId.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblOprnId.Location = new System.Drawing.Point(10, 43);
            this.lblOprnId.Name = "lblOprnId";
            this.lblOprnId.Size = new System.Drawing.Size(65, 13);
            this.lblOprnId.TabIndex = 1;
            this.lblOprnId.Text = "Operation Id";
            this.lblOprnId.Click += new System.EventHandler(this.lblOprnId_Click);
            // 
            // lblOprnName
            // 
            this.lblOprnName.AutoSize = true;
            this.lblOprnName.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblOprnName.Location = new System.Drawing.Point(10, 70);
            this.lblOprnName.Name = "lblOprnName";
            this.lblOprnName.Size = new System.Drawing.Size(84, 13);
            this.lblOprnName.TabIndex = 1;
            this.lblOprnName.Text = "Operation Name";
            // 
            // lblCT
            // 
            this.lblCT.AutoSize = true;
            this.lblCT.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblCT.Location = new System.Drawing.Point(393, 96);
            this.lblCT.Name = "lblCT";
            this.lblCT.Size = new System.Drawing.Size(59, 13);
            this.lblCT.TabIndex = 1;
            this.lblCT.Text = "Cycle Time";
            // 
            // lblDT
            // 
            this.lblDT.AutoSize = true;
            this.lblDT.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblDT.Location = new System.Drawing.Point(10, 96);
            this.lblDT.Name = "lblDT";
            this.lblDT.Size = new System.Drawing.Size(60, 13);
            this.lblDT.TabIndex = 1;
            this.lblDT.Text = "Delay Time";
            // 
            // txtOpId
            // 
            this.txtOpId.Location = new System.Drawing.Point(119, 39);
            this.txtOpId.Name = "txtOpId";
            this.txtOpId.Size = new System.Drawing.Size(74, 20);
            this.txtOpId.TabIndex = 2;
            this.txtOpId.TextChanged += new System.EventHandler(this.txtOpId_TextChanged);
            // 
            // txtDTime
            // 
            this.txtDTime.Location = new System.Drawing.Point(119, 92);
            this.txtDTime.Name = "txtDTime";
            this.txtDTime.Size = new System.Drawing.Size(100, 20);
            this.txtDTime.TabIndex = 2;
            // 
            // txtOpName
            // 
            this.txtOpName.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtOpName.Location = new System.Drawing.Point(119, 66);
            this.txtOpName.Name = "txtOpName";
            this.txtOpName.Size = new System.Drawing.Size(244, 20);
            this.txtOpName.TabIndex = 2;
            // 
            // txtCTime
            // 
            this.txtCTime.Location = new System.Drawing.Point(458, 92);
            this.txtCTime.Name = "txtCTime";
            this.txtCTime.Size = new System.Drawing.Size(100, 20);
            this.txtCTime.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(393, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Deleted?";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.checkBox1.Location = new System.Drawing.Point(458, 41);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(40, 17);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "No";
            this.checkBox1.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(10, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Description";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(119, 118);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(392, 20);
            this.textBox5.TabIndex = 2;
            // 
            // OprnDGV
            // 
            this.OprnDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OprnDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OpId,
            this.OprtrId,
            this.OprnId,
            this.OprnName,
            this.Deleted,
            this.DelayTime,
            this.CycleTime,
            this.PtcID});
            this.OprnDGV.Location = new System.Drawing.Point(9, 193);
            this.OprnDGV.Name = "OprnDGV";
            this.OprnDGV.Size = new System.Drawing.Size(628, 150);
            this.OprnDGV.TabIndex = 5;
            // 
            // OpId
            // 
            this.OpId.DataPropertyName = "oprtnId";
            this.OpId.HeaderText = "OprtnId";
            this.OpId.Name = "OpId";
            this.OpId.Visible = false;
            // 
            // OprtrId
            // 
            this.OprtrId.DataPropertyName = "OprtrId";
            this.OprtrId.HeaderText = "Operator";
            this.OprtrId.Name = "OprtrId";
            // 
            // OprnId
            // 
            this.OprnId.DataPropertyName = "OperationId";
            this.OprnId.HeaderText = "Operation Id";
            this.OprnId.Name = "OprnId";
            // 
            // OprnName
            // 
            this.OprnName.DataPropertyName = "OprnName";
            this.OprnName.HeaderText = "Operation Name";
            this.OprnName.Name = "OprnName";
            this.OprnName.Width = 150;
            // 
            // Deleted
            // 
            this.Deleted.DataPropertyName = "deleted";
            this.Deleted.HeaderText = "Deleted";
            this.Deleted.Name = "Deleted";
            this.Deleted.Visible = false;
            // 
            // DelayTime
            // 
            this.DelayTime.DataPropertyName = "DelayTime";
            this.DelayTime.HeaderText = "Delay Time";
            this.DelayTime.Name = "DelayTime";
            // 
            // CycleTime
            // 
            this.CycleTime.DataPropertyName = "CycleTime";
            this.CycleTime.HeaderText = "Cycle Time";
            this.CycleTime.Name = "CycleTime";
            // 
            // PtcID
            // 
            this.PtcID.DataPropertyName = "PTCId";
            this.PtcID.HeaderText = "Component";
            this.PtcID.Name = "PtcID";
            // 
            // lblPTC
            // 
            this.lblPTC.AutoSize = true;
            this.lblPTC.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPTC.Location = new System.Drawing.Point(10, 20);
            this.lblPTC.Name = "lblPTC";
            this.lblPTC.Size = new System.Drawing.Size(61, 13);
            this.lblPTC.TabIndex = 1;
            this.lblPTC.Text = "Component";
            // 
            // cmbPTC
            // 
            this.cmbPTC.FormattingEnabled = true;
            this.cmbPTC.Location = new System.Drawing.Point(119, 12);
            this.cmbPTC.Name = "cmbPTC";
            this.cmbPTC.Size = new System.Drawing.Size(194, 21);
            this.cmbPTC.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(393, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Operator";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(458, 66);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(149, 21);
            this.comboBox1.TabIndex = 8;
            // 
            // btnOprtr
            // 
            this.btnOprtr.Location = new System.Drawing.Point(613, 65);
            this.btnOprtr.Name = "btnOprtr";
            this.btnOprtr.Size = new System.Drawing.Size(24, 23);
            this.btnOprtr.TabIndex = 9;
            this.btnOprtr.Text = "...";
            this.btnOprtr.UseVisualStyleBackColor = true;
            this.btnOprtr.Click += new System.EventHandler(this.btnOprtr_Click);
            // 
            // OperationDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(652, 384);
            this.Controls.Add(this.btnOprtr);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbPTC);
            this.Controls.Add(this.OprnDGV);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtOpName);
            this.Controls.Add(this.txtCTime);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.txtDTime);
            this.Controls.Add(this.txtOpId);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblDT);
            this.Controls.Add(this.lblCT);
            this.Controls.Add(this.lblOprnName);
            this.Controls.Add(this.lblPTC);
            this.Controls.Add(this.lblOprnId);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnSave);
            this.Name = "OperationDetails";
            this.Text = "Operation Details";
            ((System.ComponentModel.ISupportInitialize)(this.OprnDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label lblOprnId;
        private System.Windows.Forms.Label lblOprnName;
        private System.Windows.Forms.Label lblCT;
        private System.Windows.Forms.Label lblDT;
        private System.Windows.Forms.TextBox txtOpId;
        private System.Windows.Forms.TextBox txtDTime;
        private System.Windows.Forms.TextBox txtOpName;
        private System.Windows.Forms.TextBox txtCTime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.DataGridView OprnDGV;
        private System.Windows.Forms.Label lblPTC;
        private System.Windows.Forms.ComboBox cmbPTC;
        private System.Windows.Forms.DataGridViewTextBoxColumn OpId;
        private System.Windows.Forms.DataGridViewTextBoxColumn OprtrId;
        private System.Windows.Forms.DataGridViewTextBoxColumn OprnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn OprnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Deleted;
        private System.Windows.Forms.DataGridViewTextBoxColumn DelayTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn CycleTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn PtcID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnOprtr;
    }
}