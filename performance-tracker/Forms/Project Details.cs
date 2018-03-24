using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace performance_tracker
{
    public partial class Project_Details : Form
    {
        ProjectDetail pd = new ProjectDetail();

        public Project_Details()
        {
            InitializeComponent();
        }

        public void clear()
        {
            txtDesc.Clear();
            txtPrjName.Clear();
            btnDelete.Enabled = false;

        }

        private void Project_Details_Load(object sender, EventArgs e)
        {
            clear();
            populateGridView();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        public void populateGridView()
        {
            ProjDGV.AutoGenerateColumns = false;

            using (PerformaneAnalyzerEntities pte = new PerformaneAnalyzerEntities())
            {
                ProjDGV.DataSource = pte.ProjectDetails.ToList<ProjectDetail>();
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                pd.ProjName = txtPrjName.Text.Trim();
                pd.ProjDescription = txtDesc.Text.Trim();
                using (PerformaneAnalyzerEntities pte = new PerformaneAnalyzerEntities())
                {
                    if (pd.ProjId == 0)//insert
                        pte.ProjectDetails.Add(pd);
                    else//update
                        pte.Entry(pd).State = System.Data.Entity.EntityState.Modified;
                        pte.SaveChanges();

                }
                clear();
                populateGridView();
                MessageBox.Show("Data saved successfully");

            }
            catch (System.Data.Entity.Validation.DbEntityValidationException dbEx)
            {
                Exception raise = dbEx;
                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        string message = string.Format("{0}:{1}",
                            validationErrors.Entry.Entity.ToString(),
                            validationError.ErrorMessage);
                        // raise a new exception nesting
                        // the current instance as InnerException
                        raise = new InvalidOperationException(message, raise);
                    }
                }
                throw raise;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void ProjDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ProjDGV_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (ProjDGV.CurrentRow.Index != -1)
                {
                    pd.ProjId = Convert.ToInt32(ProjDGV.CurrentRow.Cells["ProjId"].Value);
                    using (PerformaneAnalyzerEntities pte = new PerformaneAnalyzerEntities())
                    {
                        pd = pte.ProjectDetails.Where(x => x.ProjId == pd.ProjId).FirstOrDefault();
                        txtPrjName.Text = pd.ProjName;
                        txtDesc.Text = pd.ProjDescription;
                    }

                    btnSave.Text = "Update Succesful!";
                    btnDelete.Enabled = true;
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Unexpected error occured"+err);
            }
        }

        private void btnComp_Click(object sender, EventArgs e)
        {
            ComponentDetails Cd = new ComponentDetails();
            Cd.ShowDialog();
            this.Close();
        }
    }
}
