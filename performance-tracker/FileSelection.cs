using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace performance_tracker
{
    public partial class FileSelection : Form
    {
        public FileSelection()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            System.IO.Stream myStream;
            OpenFileDialog ofd = new OpenFileDialog();
            //string filePath; 
            ofd.Multiselect = true;
            //ofd.Filter = ",";
            ofd.InitialDirectory = @"C:\";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                //string fileName = ofd.FileName;
                //MessageBox.Show("You have chosen : " + fileName);
                foreach (string item in ofd.FileNames)
                {
                    try
                    {
                        if ((myStream = ofd.OpenFile()) != null)
                        {
                            using (myStream)
                            {
                                listBox1.Items.Add(item);
                            }
                        }
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                    }

                }

            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {

                string path = @"C:\Temp\FilesPath.txt";
                if (!File.Exists(path))
                {
                    File.Create(path);
                    TextWriter tw = new StreamWriter(path);
                    tw.WriteLine("The very first line!");
                    tw.Close();
                }
                else if (File.Exists(path))
                {
                    TextWriter tw = new StreamWriter(path);
                    tw.WriteLine("The next line!");
                    tw.Close();
                }
                MessageBox.Show("file/s selected succesfully.");
                this.Close();
            }
            
               catch (Exception ex)
            {
                MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
            }
        }
    }
}
