using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Bundick_2017
{
    public partial class CustomerSearch : Form
    {
        
        public int index, searchfields= 0;
        public Main LogicalParent { get; set; }
        //classic7_bundickDataSet ds = new classic7_bundickDataSet();
    
        public CustomerSearch()
        {
          InitializeComponent();
        }

        private void CustomerSearch_Load(object sender, EventArgs e)
        {

            this.job_SheetTableAdapter.Fill(this.classic7_bundickDataSet.Job_Sheet);
            //string ConString = "server=classicsiamese.com;user id=classic7_jisatsu;password=Mexic0123!;persistsecurityinfo=True;database=classic7_bundick";
            //MySqlConnection connection = new MySqlConnection(ConString);
            //connection.Open();

            //    MySqlCommand cmd = connection.CreateCommand();
            //    cmd.CommandText = "SELECT * FROM `Job Sheet`";
            //    MySqlDataAdapter adap = new MySqlDataAdapter(cmd);
            //    DataSet ds = new DataSet();
            //    adap.Fill(ds);

            //    if(connection.State == ConnectionState.Open)
            //    {
            //        connection.Clone();
            //    }


            //int countyCount = ds.Tables[0].Rows.Count;
            //Console.WriteLine(countyCount);
            AutoComplete();

        }

        private void AutoComplete()
        {
            string ConString = "server=classicsiamese.com;user id=classic7_jisatsu;password=Mexic0123!;persistsecurityinfo=True;database=classic7_bundick";
            MySqlConnection connection = new MySqlConnection(ConString);
            connection.Open();

            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "SELECT * FROM `Job Sheet`";
            MySqlDataAdapter adap = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adap.Fill(ds);

            if (connection.State == ConnectionState.Open)
            {
                connection.Clone();
            }


            int countyCount = ds.Tables[0].Rows.Count;
            Console.WriteLine(countyCount);
            //TODO Get data from database
            //classic7_bundickDataSet ds = new classic7_bundickDataSet();
            //classic7_bundickDataSet.Job_SheetDataTable dt = new classic7_bundickDataSet.Job_SheetDataTable();
            this.nameToolStripTextBox.AutoCompleteMode = AutoCompleteMode.Suggest;
            this.nameToolStripTextBox.AutoCompleteSource = AutoCompleteSource.CustomSource;

            AutoCompleteStringCollection data = new AutoCompleteStringCollection();
            //data.Add(ds.Tables[1].Rows[0]["Name"].ToString());


            for (int i = 0; i < countyCount; i++)
            {
                data.Add(ds.Tables[0].Rows[i]["Name"].ToString());
                Console.WriteLine("Name: " + ds.Tables[0].Rows[i]["Name"].ToString());
            }
            //foreach (DataRow row in ds.Tables[0].Rows)
            //{
            //    data.Add(row[0].ToString());
            //}


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
