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
            Project_Details pd = new Project_Details();
            pd.ShowDialog();
            
        }
    }
}
