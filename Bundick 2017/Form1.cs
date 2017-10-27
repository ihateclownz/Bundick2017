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
    public partial class Form1 : Form
    {
        System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        public Form1()
        {
            InitializeComponent();
            toolStripStatusLabel1.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.employeesTableAdapter.Fill(this.classic7_bundickDataSet.Employees);

        }

        private void employeesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {

            this.Validate();
            this.employeesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.classic7_bundickDataSet);
            toolStripStatusLabel1.Text = "Employee table saved.";

            timer.Interval = 1000;
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();

        }

        void timer_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "";
        }
    }
}
