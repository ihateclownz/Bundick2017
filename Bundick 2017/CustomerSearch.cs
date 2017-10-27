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
    public partial class CustomerSearch : Form
    {
        
        public int index, searchfields= 0;
        public Main LogicalParent { get; set; }
        classic7_bundickDataSet ds = new classic7_bundickDataSet();

        public CustomerSearch()
        {
          InitializeComponent();
        }

        private void CustomerSearch_Load(object sender, EventArgs e)
        {

            this.job_SheetTableAdapter.Fill(this.classic7_bundickDataSet.Job_Sheet);
            AutoComplete();

        }

        private void AutoComplete()
        {

            //TODO Get data from database
            classic7_bundickDataSet ds = new classic7_bundickDataSet();
            classic7_bundickDataSet.Job_SheetDataTable dt = new classic7_bundickDataSet.Job_SheetDataTable();
            this.nameToolStripTextBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.nameToolStripTextBox.AutoCompleteSource = AutoCompleteSource.CustomSource;

            AutoCompleteStringCollection data = new AutoCompleteStringCollection();

            for (int i = 0; i <= dt.Count; i++)
            {
                Console.WriteLine("in for loop");
                //data.Add(ds.Tables[1].Rows[i]["Name"].ToString());
                try
                {
                   // data.Add(ds.Tables[1].Rows[i]["Name"].ToString());
                    data.Add(ds.Job_Sheet.Rows[0]["Name"].ToString());
                }
           
                catch
                {
                    Console.WriteLine("well, this didnt work like i thought");
                }
            }

            this.nameToolStripTextBox.AutoCompleteCustomSource = data;

        }

            private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            if (nameToolStripTextBox.Text == "")
            {
                this.job_SheetTableAdapter.Fill(this.classic7_bundickDataSet.Job_Sheet);
            }
            else
            {
                try
                {
                    this.job_SheetTableAdapter.FillBy(this.classic7_bundickDataSet.Job_Sheet, nameToolStripTextBox.Text);
                }
                catch (System.Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message);
                }
            }
        }

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.job_SheetTableAdapter.FillBy1(this.classic7_bundickDataSet.Job_Sheet, addressToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            Main main = new Main();
            index = e.RowIndex;

            DataTable dt = new DataTable("JobSheet");
            //dt.Columns["ID"]; Rows[index];
            //dt.Select("")
            string sid = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["ID"].Value.ToString();
            int.TryParse(sid, out LogicalParent.formIndex);
            
            //LogicalParent.formIndex = e.RowIndex;

        }


        // Open button for Customer Search Job Sheet
        private void button1_Click(object sender, EventArgs e)
        {
           Main main = new Main();
           main.Refresh();
           this.LogicalParent.updateFormData();
           this.Hide();
        }

        private void nameToolStripTextBox_TextChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Search();
        }

        private void addressToolStripTextBox_TextChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Search()
        {
            searchfields = 0;

            if (nameToolStripTextBox.Text != "")
            {
                searchfields += 1;
            }
            if (addressToolStripTextBox.Text != "")
            {
                searchfields += 1;
            }

            Console.WriteLine(searchfields.ToString());

            if (searchfields == 0)
            {
                //MessageBox.Show("Please enter your search into the fields", "Error");
                this.job_SheetTableAdapter.Fill(this.classic7_bundickDataSet.Job_Sheet);

            }
            else if (searchfields > 1)
            {
                nameToolStripTextBox.Text = "";
                addressToolStripTextBox.Text = "";
                searchfields = 0;
                MessageBox.Show("Please limit search to one field", "Error");

            }
            else
            {
                if (nameToolStripTextBox.Text != "")
                {
                    this.job_SheetTableAdapter.FillBy(this.classic7_bundickDataSet.Job_Sheet, nameToolStripTextBox.Text + "%");
                }
                else if (addressToolStripTextBox.Text != "")
                {
                    this.job_SheetTableAdapter.FillBy(this.classic7_bundickDataSet.Job_Sheet, addressToolStripTextBox.Text + "%");

                }
            }
        }
    }
}
