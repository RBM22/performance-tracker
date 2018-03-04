namespace performance_tracker
{
    partial class MenuForm
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
            this.ControlTab = new System.Windows.Forms.TabControl();
            this.Files = new System.Windows.Forms.TabPage();
            this.MasterEntry = new System.Windows.Forms.TabPage();
            this.Reports = new System.Windows.Forms.TabPage();
            this.ControlTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // ControlTab
            // 
            this.ControlTab.Controls.Add(this.Files);
            this.ControlTab.Controls.Add(this.MasterEntry);
            this.ControlTab.Controls.Add(this.Reports);
            this.ControlTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ControlTab.Location = new System.Drawing.Point(0, 0);
            this.ControlTab.Multiline = true;
            this.ControlTab.Name = "ControlTab";
            this.ControlTab.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ControlTab.SelectedIndex = 0;
            this.ControlTab.Size = new System.Drawing.Size(843, 363);
            this.ControlTab.TabIndex = 0;
            // 
            // Files
            // 
            this.Files.BackColor = System.Drawing.Color.Transparent;
            this.Files.Location = new System.Drawing.Point(4, 22);
            this.Files.Name = "Files";
            this.Files.Padding = new System.Windows.Forms.Padding(3);
            this.Files.Size = new System.Drawing.Size(835, 337);
            this.Files.TabIndex = 0;
            this.Files.Text = "File";
            // 
            // MasterEntry
            // 
            this.MasterEntry.Location = new System.Drawing.Point(4, 22);
            this.MasterEntry.Name = "MasterEntry";
            this.MasterEntry.Padding = new System.Windows.Forms.Padding(3);
            this.MasterEntry.Size = new System.Drawing.Size(835, 337);
            this.MasterEntry.TabIndex = 1;
            this.MasterEntry.Text = "Master Entry";
            this.MasterEntry.UseVisualStyleBackColor = true;
            this.MasterEntry.Click += new System.EventHandler(this.MasterEntry_Click);
            // 
            // Reports
            // 
            this.Reports.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Reports.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Reports.Location = new System.Drawing.Point(4, 22);
            this.Reports.Name = "Reports";
            this.Reports.Size = new System.Drawing.Size(835, 337);
            this.Reports.TabIndex = 2;
            this.Reports.Text = "Reports";
            this.Reports.UseVisualStyleBackColor = true;
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(843, 363);
            this.Controls.Add(this.ControlTab);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "MenuForm";
            this.Text = "PerformanceTracker";
            this.Load += new System.EventHandler(this.MenuForm_Load);
            this.ControlTab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl ControlTab;
        private System.Windows.Forms.TabPage Files;
        private System.Windows.Forms.TabPage MasterEntry;
        private System.Windows.Forms.TabPage Reports;
    }
}

