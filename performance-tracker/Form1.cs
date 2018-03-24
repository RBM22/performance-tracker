using performance_tracker.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace performance_tracker
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {
            //FormWindowState.Maximized;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
        }

        private void MasterEntry_Click(object sender, EventArgs e)
        {

        }

        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileSelection fs = new FileSelection();
            fs.ShowDialog();
        }

        private void componentsMAsterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ComponentDetails cd = new ComponentDetails();
            cd.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void projectsMasterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Machine_Details md = new Machine_Details();
            md.ShowDialog();

        }

        private void machineDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Project_Details pd = new Project_Details();
            pd.ShowDialog();
        }

        private void machineDetailsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Machine_Details md = new Machine_Details();
            md.FormBorderStyle = FormBorderStyle.FixedDialog;
            md.ShowDialog();
            
        }

        private void projectDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Project_Details pd = new Project_Details();
            pd.ShowDialog();
        }

        private void componentDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ComponentDetails cd = new ComponentDetails();
            cd.ShowDialog();
        }

        private void operationDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OperationDetails od = new OperationDetails();
            od.ShowDialog();
        }

        private void operatorDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OperatorDetails oprtrd = new OperatorDetails();
            oprtrd.ShowDialog();
        }
    }
}
