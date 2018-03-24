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
    public partial class ComponentDetails : Form
    {
        ComponentDetail cd = new ComponentDetail();

        public ComponentDetails()
        {
            InitializeComponent();
        }

        public void populateGridView()
        {
            CompDGV.AutoGenerateColumns = false;

            using (PerformaneAnalyzerEntities pte = new PerformaneAnalyzerEntities())
            {
                CompDGV.DataSource = pte.ComponentDetails.ToList<ComponentDetail>();
                    //pte.ProjectDetails.ToList<ProjectDetail>();
            }

        }

        public void clear()
        {
            txtCompId.Clear();
            txtCompName.Clear();
            txtDesc.Clear();
        }

        private void btnOprn_Click(object sender, EventArgs e)
        {
            OperationDetails Od = new OperationDetails();
            Od.ShowDialog();
            this.Close();
        }

        private void ComponentDetails_Load(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            cd.CompId = Convert.ToInt32( txtCompId.Text.Trim());
            cd.CompDescription = txtDesc.Text.Trim();
            cd.CompName = txtCompName.Text.Trim();
            using (PerformaneAnalyzerEntities pte = new PerformaneAnalyzerEntities())
            {
                if (cd.ProjId == 0)//insert
                    pte.ComponentDetails.Add(cd);
                else//update
                    pte.Entry(cd).State = System.Data.Entity.EntityState.Modified;
                pte.SaveChanges();

            }
            clear();
            populateGridView();
            MessageBox.Show("Data saved successfully");
        }

        private void ProjDGV_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (CompDGV.CurrentRow.Index != -1)
                {
                    cd.CompId = Convert.ToInt32(CompDGV.CurrentRow.Cells["CompId"].Value);
                    using (PerformaneAnalyzerEntities pte = new PerformaneAnalyzerEntities())
                    {
                        cd = pte.ComponentDetails.Where(x => x.CompId == cd.CompId).FirstOrDefault();
                        //pd = pte.ProjectDetails.Where(x => x.ProjId == pd.ProjId).FirstOrDefault();
                        txtCompName.Text = cd.CompName;
                        txtCompId.Text = Convert.ToString( cd.ComponetID);
                        txtDesc.Text = cd.CompDescription;
                    }

                    btnSave.Text = "Update";
                    btnDelete.Enabled = true;
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Unexpected error occured" + err);
            }
        }
    }
}
