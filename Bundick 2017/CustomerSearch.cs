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

        public bool hasName = false, hasAddress = false, hasLocation = false, hasPhone = false;

        classic7_bundickDataSet ds = new classic7_bundickDataSet();

        public CustomerSearch()
        {
                       
           // classic7_bundickDataSet bundickDataSet = new classic7_bundickDataSet(); 
            InitializeComponent();
            // this.textBox1.AutoCompleteSource = AutoCompleteSource.CustomSource;
            //this.textBox1.AutoCompleteMode = AutoCompleteMode.Suggest;
            //this.textBox1.AutoCompleteCustomSource.AddRange(new String[] { "John", "Joy", "Lucy", "Leo" });
            // this.textBox1.DataBindings.Add("Text", bundickDataSet, "Name");

            int count = classic7_bundickDataSet.Job_Sheet.Rows.Count;

            //MessageBox.Show(count.ToString());

            
        }

        private void CustomerSearch_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'classic7_bundickDataSet.Job_Sheet' table. You can move, or remove it, as needed.
            AutoComplete();

            this.job_SheetTableAdapter.Fill(this.classic7_bundickDataSet.Job_Sheet);

        }

        private void AutoComplete()
        {
            DataTable dt = new DataTable("JobSheet");
            AutoCompleteStringCollection source = new AutoCompleteStringCollection();
            txtNameSearch.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtNameSearch.AutoCompleteSource = AutoCompleteSource.CustomSource;
            //for (int i=0; i < dt.Rows.Count; ++i)
            //{
            //    source.Add(dt.Rows[i][0].ToString());
            //}

            foreach (DataRow rw in dt.Rows)
            {
                source.Add(rw[0].ToString());

            }
            txtNameSearch.AutoCompleteCustomSource = source;

            //AutoCompleteStringCollection AutoItem = new AutoCompleteStringCollection();
            //foreach (DataRow rw in )
            //txtNameSearch.AutoCompleteMode = AutoCompleteMode.Suggest;
            //txtNameSearch.AutoCompleteSource = AutoCompleteSource.CustomSource;
            //AutoCompleteStringCollection combData2 = new AutoCompleteStringCollection();


            //          foreach (DataRow row in ds.Tables[1].Rows)
            //              {
            //                  combData2.Add(row[0].ToString());
            //              Console.WriteLine(combData2.Add(row[0].ToString()));
            //               }
            //          txtNameSearch.AutoCompleteCustomSource = combData2;
        }

        private void getData(AutoCompleteStringCollection dataCollection)
        {
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                dataCollection.Add(row[1].ToString());
                //Console.WriteLine(dataCollection.)
            }
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

        // private void addressToolStripTextBox_TextChanged(object sender, EventArgs e)
        /*
                private void addressToolStripTextBox_TextChanged(object sender, EventArgs e)
                {
                    if (addressToolStripTextBox.Text == "")
                    {
                        hasAddress = false;
                    }
                    else
                    {
                        hasAddress = true;
                        searchfields += 1;
                    }
                }
                */

        //private void nameToolStripTextBox_TextChanged(object sender, EventArgs e)
        /*
        private void nameToolStripTextBox_TextChanged(object sender, EventArgs e)
        {
            if (nameToolStripTextBox.Text == "")
            {
                hasName = false;
            }
            else
            {
                hasName = true;
                searchfields += 1;
            }
        }

        */

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            Main main = new Main();
            index = e.RowIndex;

           // main.formIndex = e.RowIndex;
            LogicalParent.formIndex = e.RowIndex;
            //try {
                //DataGridViewRow selectedRow = dataGridView1.Rows[index];


            MessageBox.Show(index.ToString());
        }


        // Open button for Customer Search Job Sheet
        private void button1_Click(object sender, EventArgs e)
        {
           Main main = new Main();
           main.Refresh();
           this.LogicalParent.updateFormData();
            this.Hide();
        }

        private void btnSearch_Click(object sender, EventArgs e)
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
                MessageBox.Show("Please enter your search into the fields", "Error");
                this.job_SheetTableAdapter.Fill(this.classic7_bundickDataSet.Job_Sheet);

            }
            else if (searchfields > 1) 
            {
                MessageBox.Show("Please limit search to one field", "Error");
                nameToolStripTextBox.Text = "";
                addressToolStripTextBox.Text = "";
                searchfields = 0;

            }
            else
            {
                if (nameToolStripTextBox.Text != "")
                {
                    this.job_SheetTableAdapter.FillBy(this.classic7_bundickDataSet.Job_Sheet, nameToolStripTextBox.Text);
                }
                else if (addressToolStripTextBox.Text != "")
                {
                    this.job_SheetTableAdapter.FillBy(this.classic7_bundickDataSet.Job_Sheet, addressToolStripTextBox.Text);

                }
            }
        }
    }
}
