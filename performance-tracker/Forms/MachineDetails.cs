using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace performance_tracker.Forms
{
    public partial class Machine_Details : Form
    {
        public Machine_Details()
        {
            InitializeComponent();
        }

        private void lblDesc_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnProj_Click(object sender, EventArgs e)
        {
            Project_Details proj = new Project_Details();
            proj.Show();
            this.Close();
        }
    }
}
