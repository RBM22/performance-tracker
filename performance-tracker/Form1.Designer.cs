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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.masterDetailsEntryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.machineDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projectDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.componentDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.operationDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.operatorDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.masterDetailsEntryToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(843, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFileToolStripMenuItem,
            this.closeFilesToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openFileToolStripMenuItem
            // 
            this.openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
            this.openFileToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.openFileToolStripMenuItem.Text = "Open File/s";
            this.openFileToolStripMenuItem.Click += new System.EventHandler(this.openFileToolStripMenuItem_Click);
            // 
            // closeFilesToolStripMenuItem
            // 
            this.closeFilesToolStripMenuItem.Name = "closeFilesToolStripMenuItem";
            this.closeFilesToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.closeFilesToolStripMenuItem.Text = "Close File/s";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // masterDetailsEntryToolStripMenuItem
            // 
            this.masterDetailsEntryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.machineDetailsToolStripMenuItem,
            this.projectDetailsToolStripMenuItem,
            this.componentDetailsToolStripMenuItem,
            this.operationDetailsToolStripMenuItem,
            this.operatorDetailsToolStripMenuItem});
            this.masterDetailsEntryToolStripMenuItem.Name = "masterDetailsEntryToolStripMenuItem";
            this.masterDetailsEntryToolStripMenuItem.Size = new System.Drawing.Size(123, 20);
            this.masterDetailsEntryToolStripMenuItem.Text = "Master Details Entry";
            // 
            // machineDetailsToolStripMenuItem
            // 
            this.machineDetailsToolStripMenuItem.Name = "machineDetailsToolStripMenuItem";
            this.machineDetailsToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.machineDetailsToolStripMenuItem.Text = "Machine Details";
            this.machineDetailsToolStripMenuItem.Click += new System.EventHandler(this.machineDetailsToolStripMenuItem_Click_1);
            // 
            // projectDetailsToolStripMenuItem
            // 
            this.projectDetailsToolStripMenuItem.Name = "projectDetailsToolStripMenuItem";
            this.projectDetailsToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.projectDetailsToolStripMenuItem.Text = "Project Details";
            this.projectDetailsToolStripMenuItem.Click += new System.EventHandler(this.projectDetailsToolStripMenuItem_Click);
            // 
            // componentDetailsToolStripMenuItem
            // 
            this.componentDetailsToolStripMenuItem.Name = "componentDetailsToolStripMenuItem";
            this.componentDetailsToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.componentDetailsToolStripMenuItem.Text = "Component Details";
            this.componentDetailsToolStripMenuItem.Click += new System.EventHandler(this.componentDetailsToolStripMenuItem_Click);
            // 
            // operationDetailsToolStripMenuItem
            // 
            this.operationDetailsToolStripMenuItem.Name = "operationDetailsToolStripMenuItem";
            this.operationDetailsToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.operationDetailsToolStripMenuItem.Text = "Operation Details";
            this.operationDetailsToolStripMenuItem.Click += new System.EventHandler(this.operationDetailsToolStripMenuItem_Click);
            // 
            // operatorDetailsToolStripMenuItem
            // 
            this.operatorDetailsToolStripMenuItem.Name = "operatorDetailsToolStripMenuItem";
            this.operatorDetailsToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.operatorDetailsToolStripMenuItem.Text = "Operator Details";
            this.operatorDetailsToolStripMenuItem.Click += new System.EventHandler(this.operatorDetailsToolStripMenuItem_Click);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(843, 363);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MenuForm";
            this.Text = "PerformanceTracker";
            this.Load += new System.EventHandler(this.MenuForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeFilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem masterDetailsEntryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem machineDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem projectDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem componentDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem operationDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem operatorDetailsToolStripMenuItem;
    }
}

