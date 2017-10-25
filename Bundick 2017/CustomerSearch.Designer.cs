namespace Bundick_2017
{
    partial class CustomerSearch
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jobLocationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taxIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.callindateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.completionDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jobSheetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.classic7bundickDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.classic7_bundickDataSet = new Bundick_2017.classic7_bundickDataSet();
            this.job_SheetTableAdapter = new Bundick_2017.classic7_bundickDataSetTableAdapters.Job_SheetTableAdapter();
            this.fillByToolStrip = new System.Windows.Forms.ToolStrip();
            this.nameToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.nameToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillByToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.fillBy1ToolStrip = new System.Windows.Forms.ToolStrip();
            this.addressToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.addressToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillBy1ToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.txtNameSearch = new System.Windows.Forms.TextBox();
            this.btnOpenJob = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobSheetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classic7bundickDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classic7_bundickDataSet)).BeginInit();
            this.fillByToolStrip.SuspendLayout();
            this.fillBy1ToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.jobLocationDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.taxIDDataGridViewTextBoxColumn,
            this.callindateDataGridViewTextBoxColumn,
            this.completionDateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.jobSheetBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 80);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(651, 182);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // jobLocationDataGridViewTextBoxColumn
            // 
            this.jobLocationDataGridViewTextBoxColumn.DataPropertyName = "Job Location";
            this.jobLocationDataGridViewTextBoxColumn.HeaderText = "Job Location";
            this.jobLocationDataGridViewTextBoxColumn.Name = "jobLocationDataGridViewTextBoxColumn";
            this.jobLocationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Phone";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            this.phoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // taxIDDataGridViewTextBoxColumn
            // 
            this.taxIDDataGridViewTextBoxColumn.DataPropertyName = "TaxID";
            this.taxIDDataGridViewTextBoxColumn.HeaderText = "TaxID";
            this.taxIDDataGridViewTextBoxColumn.Name = "taxIDDataGridViewTextBoxColumn";
            this.taxIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // callindateDataGridViewTextBoxColumn
            // 
            this.callindateDataGridViewTextBoxColumn.DataPropertyName = "Callindate";
            this.callindateDataGridViewTextBoxColumn.HeaderText = "Callindate";
            this.callindateDataGridViewTextBoxColumn.Name = "callindateDataGridViewTextBoxColumn";
            this.callindateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // completionDateDataGridViewTextBoxColumn
            // 
            this.completionDateDataGridViewTextBoxColumn.DataPropertyName = "CompletionDate";
            this.completionDateDataGridViewTextBoxColumn.HeaderText = "CompletionDate";
            this.completionDateDataGridViewTextBoxColumn.Name = "completionDateDataGridViewTextBoxColumn";
            this.completionDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // jobSheetBindingSource
            // 
            this.jobSheetBindingSource.DataMember = "Job Sheet";
            this.jobSheetBindingSource.DataSource = this.classic7bundickDataSetBindingSource;
            // 
            // classic7bundickDataSetBindingSource
            // 
            this.classic7bundickDataSetBindingSource.DataSource = this.classic7_bundickDataSet;
            this.classic7bundickDataSetBindingSource.Position = 0;
            // 
            // classic7_bundickDataSet
            // 
            this.classic7_bundickDataSet.DataSetName = "classic7_bundickDataSet";
            this.classic7_bundickDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // job_SheetTableAdapter
            // 
            this.job_SheetTableAdapter.ClearBeforeFill = true;
            // 
            // fillByToolStrip
            // 
            this.fillByToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nameToolStripLabel,
            this.nameToolStripTextBox,
            this.fillByToolStripButton});
            this.fillByToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillByToolStrip.Name = "fillByToolStrip";
            this.fillByToolStrip.Size = new System.Drawing.Size(651, 25);
            this.fillByToolStrip.TabIndex = 1;
            this.fillByToolStrip.Text = "fillByToolStrip";
            // 
            // nameToolStripLabel
            // 
            this.nameToolStripLabel.Name = "nameToolStripLabel";
            this.nameToolStripLabel.Size = new System.Drawing.Size(42, 22);
            this.nameToolStripLabel.Text = "Name:";
            // 
            // nameToolStripTextBox
            // 
            this.nameToolStripTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.nameToolStripTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.nameToolStripTextBox.Name = "nameToolStripTextBox";
            this.nameToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // fillByToolStripButton
            // 
            this.fillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByToolStripButton.Name = "fillByToolStripButton";
            this.fillByToolStripButton.Size = new System.Drawing.Size(26, 22);
            this.fillByToolStripButton.Text = "Go";
            this.fillByToolStripButton.Click += new System.EventHandler(this.fillByToolStripButton_Click);
            // 
            // fillBy1ToolStrip
            // 
            this.fillBy1ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addressToolStripLabel,
            this.addressToolStripTextBox,
            this.fillBy1ToolStripButton});
            this.fillBy1ToolStrip.Location = new System.Drawing.Point(0, 25);
            this.fillBy1ToolStrip.Name = "fillBy1ToolStrip";
            this.fillBy1ToolStrip.Size = new System.Drawing.Size(651, 25);
            this.fillBy1ToolStrip.TabIndex = 2;
            this.fillBy1ToolStrip.Text = "fillBy1ToolStrip";
            // 
            // addressToolStripLabel
            // 
            this.addressToolStripLabel.Name = "addressToolStripLabel";
            this.addressToolStripLabel.Size = new System.Drawing.Size(52, 22);
            this.addressToolStripLabel.Text = "Address:";
            // 
            // addressToolStripTextBox
            // 
            this.addressToolStripTextBox.Name = "addressToolStripTextBox";
            this.addressToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // fillBy1ToolStripButton
            // 
            this.fillBy1ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillBy1ToolStripButton.Name = "fillBy1ToolStripButton";
            this.fillBy1ToolStripButton.Size = new System.Drawing.Size(26, 22);
            this.fillBy1ToolStripButton.Text = "Go";
            this.fillBy1ToolStripButton.Click += new System.EventHandler(this.fillBy1ToolStripButton_Click);
            // 
            // txtNameSearch
            // 
            this.txtNameSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtNameSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtNameSearch.Location = new System.Drawing.Point(61, 54);
            this.txtNameSearch.Name = "txtNameSearch";
            this.txtNameSearch.Size = new System.Drawing.Size(100, 20);
            this.txtNameSearch.TabIndex = 3;
            // 
            // btnOpenJob
            // 
            this.btnOpenJob.Location = new System.Drawing.Point(471, 331);
            this.btnOpenJob.Name = "btnOpenJob";
            this.btnOpenJob.Size = new System.Drawing.Size(75, 23);
            this.btnOpenJob.TabIndex = 4;
            this.btnOpenJob.Text = "Open";
            this.btnOpenJob.UseVisualStyleBackColor = true;
            this.btnOpenJob.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(564, 52);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // CustomerSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 366);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnOpenJob);
            this.Controls.Add(this.txtNameSearch);
            this.Controls.Add(this.fillBy1ToolStrip);
            this.Controls.Add(this.fillByToolStrip);
            this.Controls.Add(this.dataGridView1);
            this.Name = "CustomerSearch";
            this.Text = "CustomerSearch";
            this.Load += new System.EventHandler(this.CustomerSearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobSheetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classic7bundickDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classic7_bundickDataSet)).EndInit();
            this.fillByToolStrip.ResumeLayout(false);
            this.fillByToolStrip.PerformLayout();
            this.fillBy1ToolStrip.ResumeLayout(false);
            this.fillBy1ToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource classic7bundickDataSetBindingSource;
        private classic7_bundickDataSet classic7_bundickDataSet;
        private System.Windows.Forms.BindingSource jobSheetBindingSource;
        private classic7_bundickDataSetTableAdapters.Job_SheetTableAdapter job_SheetTableAdapter;
        private System.Windows.Forms.ToolStrip fillByToolStrip;
        private System.Windows.Forms.ToolStripLabel nameToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox nameToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillByToolStripButton;
        private System.Windows.Forms.ToolStrip fillBy1ToolStrip;
        private System.Windows.Forms.ToolStripLabel addressToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox addressToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillBy1ToolStripButton;
        private System.Windows.Forms.TextBox txtNameSearch;
        private System.Windows.Forms.Button btnOpenJob;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jobLocationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn taxIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn callindateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn completionDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnSearch;
    }
}