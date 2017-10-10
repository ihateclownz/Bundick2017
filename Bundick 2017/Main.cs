using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bundick_2017
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
/*
        private void job_SheetBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text == "")
            {
                Console.WriteLine("Not Saved");
                MessageBox.Show("Form not saved, please check that all required data is accurate.", "Not Saved!");
            }
            else
            {
                this.Validate();
                this.job_SheetBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.classic7_bundickDataSet);
            }
        }
*/
        private void Main_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'classic7_bundickDataSet.Employees' table. You can move, or remove it, as needed.
            this.employeesTableAdapter.Fill(this.classic7_bundickDataSet.Employees);
            // TODO: This line of code loads data into the 'classic7_bundickDataSet.Job_Sheet' table. You can move, or remove it, as needed.
            this.job_SheetTableAdapter.Fill(this.classic7_bundickDataSet.Job_Sheet);
            this.job_SheetBindingSource.MoveLast();
        }


        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Console.WriteLine("You are trying to quit...quitter");
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            job_SheetBindingSource.AddNew();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text == "")
            {
                Console.WriteLine("Not Saved");
                MessageBox.Show("Form not saved, please check that all required data is accurate.", "Not Saved!");
            }
            else
            {
                Save();
            }
        }

        private void Save()
        {
            this.Validate();
            this.job_SheetBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.classic7_bundickDataSet);
        }

        private void ToolStripButton1_Click(object sender, EventArgs e)
        {
            Save();
            this.job_SheetBindingSource.MovePrevious();

        }

        private void employeesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 fm = new Form1();
            fm.Show();
        }


        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            this.job_SheetBindingSource.MoveNext();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            this.job_SheetBindingSource.MoveFirst();
        }

        private void ToolStripButton4_Click(object sender, EventArgs e)
        {
            this.job_SheetBindingSource.MoveLast();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you really want to delete this?", "Deletion", MessageBoxButtons.OKCancel);
            if(dialogResult == DialogResult.OK)
            {
                this.job_SheetBindingSource.RemoveCurrent();
                Save();
            }
        }
    }
}
