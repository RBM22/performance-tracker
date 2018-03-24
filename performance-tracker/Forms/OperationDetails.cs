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
    public partial class OperationDetails : Form
    {
        OperationDetail od = new OperationDetail();


        public OperationDetails()
        {
            InitializeComponent();
        }

        private void lblOprnId_Click(object sender, EventArgs e)
        {

        }

        private void txtOpId_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnOprtr_Click(object sender, EventArgs e)
        {
            OperatorDetails OprtrDtls = new OperatorDetails();
            OprtrDtls.ShowDialog();
            this.Close();
        }
    }
}
