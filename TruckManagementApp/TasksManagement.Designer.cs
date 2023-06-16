namespace TruckManagementApp
{
    partial class TasksManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TasksManagement));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.uSERSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.truckManagementAppDataSet = new TruckManagementApp.TruckManagementAppDataSet();
            this.lastJobBtn = new System.Windows.Forms.Button();
            this.assignTaskBtn = new System.Windows.Forms.Button();
            this.searchBoxTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.backBtn = new System.Windows.Forms.Button();
            this.searchBtn = new System.Windows.Forms.Button();
            this.uSERSTableAdapter = new TruckManagementApp.TruckManagementAppDataSetTableAdapters.USERSTableAdapter();
            this.truckManagementAppDataSet1 = new TruckManagementApp.TruckManagementAppDataSet1();
            this.jOBSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jOBSTableAdapter = new TruckManagementApp.TruckManagementAppDataSet1TableAdapters.JOBSTableAdapter();
            this.useridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSERSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.truckManagementAppDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.truckManagementAppDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jOBSBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Silver;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.useridDataGridViewTextBoxColumn,
            this.usernameDataGridViewTextBoxColumn,
            this.firstnameDataGridViewTextBoxColumn,
            this.lastnameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.uSERSBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(345, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(678, 426);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // uSERSBindingSource
            // 
            this.uSERSBindingSource.DataMember = "USERS";
            this.uSERSBindingSource.DataSource = this.truckManagementAppDataSet;
            // 
            // truckManagementAppDataSet
            // 
            this.truckManagementAppDataSet.DataSetName = "TruckManagementAppDataSet";
            this.truckManagementAppDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lastJobBtn
            // 
            this.lastJobBtn.BackColor = System.Drawing.Color.Silver;
            this.lastJobBtn.Location = new System.Drawing.Point(12, 200);
            this.lastJobBtn.Name = "lastJobBtn";
            this.lastJobBtn.Size = new System.Drawing.Size(142, 40);
            this.lastJobBtn.TabIndex = 1;
            this.lastJobBtn.Text = "Last Job Location";
            this.lastJobBtn.UseVisualStyleBackColor = false;
            this.lastJobBtn.Click += new System.EventHandler(this.lastJobBtn_Click);
            // 
            // assignTaskBtn
            // 
            this.assignTaskBtn.BackColor = System.Drawing.Color.Silver;
            this.assignTaskBtn.Location = new System.Drawing.Point(176, 200);
            this.assignTaskBtn.Name = "assignTaskBtn";
            this.assignTaskBtn.Size = new System.Drawing.Size(143, 40);
            this.assignTaskBtn.TabIndex = 2;
            this.assignTaskBtn.Text = "Assign Task";
            this.assignTaskBtn.UseVisualStyleBackColor = false;
            this.assignTaskBtn.Click += new System.EventHandler(this.assignTaskBtn_Click);
            // 
            // searchBoxTxt
            // 
            this.searchBoxTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.searchBoxTxt.Location = new System.Drawing.Point(12, 79);
            this.searchBoxTxt.Name = "searchBoxTxt";
            this.searchBoxTxt.Size = new System.Drawing.Size(307, 30);
            this.searchBoxTxt.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(50, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Search by first or last name";
            // 
            // backBtn
            // 
            this.backBtn.BackColor = System.Drawing.Color.Silver;
            this.backBtn.Location = new System.Drawing.Point(176, 134);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(143, 40);
            this.backBtn.TabIndex = 6;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // searchBtn
            // 
            this.searchBtn.BackColor = System.Drawing.Color.Silver;
            this.searchBtn.Location = new System.Drawing.Point(12, 134);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(142, 40);
            this.searchBtn.TabIndex = 5;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = false;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // uSERSTableAdapter
            // 
            this.uSERSTableAdapter.ClearBeforeFill = true;
            // 
            // truckManagementAppDataSet1
            // 
            this.truckManagementAppDataSet1.DataSetName = "TruckManagementAppDataSet1";
            this.truckManagementAppDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // jOBSBindingSource
            // 
            this.jOBSBindingSource.DataMember = "JOBS";
            this.jOBSBindingSource.DataSource = this.truckManagementAppDataSet1;
            this.jOBSBindingSource.CurrentChanged += new System.EventHandler(this.jOBSBindingSource_CurrentChanged);
            // 
            // jOBSTableAdapter
            // 
            this.jOBSTableAdapter.ClearBeforeFill = true;
            // 
            // useridDataGridViewTextBoxColumn
            // 
            this.useridDataGridViewTextBoxColumn.DataPropertyName = "user_id";
            this.useridDataGridViewTextBoxColumn.HeaderText = "user_id";
            this.useridDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.useridDataGridViewTextBoxColumn.Name = "useridDataGridViewTextBoxColumn";
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "user_name";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "user_name";
            this.usernameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            // 
            // firstnameDataGridViewTextBoxColumn
            // 
            this.firstnameDataGridViewTextBoxColumn.DataPropertyName = "first_name";
            this.firstnameDataGridViewTextBoxColumn.HeaderText = "first_name";
            this.firstnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.firstnameDataGridViewTextBoxColumn.Name = "firstnameDataGridViewTextBoxColumn";
            // 
            // lastnameDataGridViewTextBoxColumn
            // 
            this.lastnameDataGridViewTextBoxColumn.DataPropertyName = "last_name";
            this.lastnameDataGridViewTextBoxColumn.HeaderText = "last_name";
            this.lastnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lastnameDataGridViewTextBoxColumn.Name = "lastnameDataGridViewTextBoxColumn";
            // 
            // TasksManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1038, 450);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchBoxTxt);
            this.Controls.Add(this.assignTaskBtn);
            this.Controls.Add(this.lastJobBtn);
            this.Controls.Add(this.dataGridView1);
            this.Name = "TasksManagement";
            this.Text = "TasksManagement";
            this.Load += new System.EventHandler(this.TasksManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSERSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.truckManagementAppDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.truckManagementAppDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jOBSBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button lastJobBtn;
        private System.Windows.Forms.Button assignTaskBtn;
        private System.Windows.Forms.TextBox searchBoxTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button searchBtn;
        private TruckManagementAppDataSet truckManagementAppDataSet;
        private System.Windows.Forms.BindingSource uSERSBindingSource;
        private TruckManagementAppDataSetTableAdapters.USERSTableAdapter uSERSTableAdapter;
        private TruckManagementAppDataSet1 truckManagementAppDataSet1;
        private System.Windows.Forms.BindingSource jOBSBindingSource;
        private TruckManagementAppDataSet1TableAdapters.JOBSTableAdapter jOBSTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn useridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastnameDataGridViewTextBoxColumn;
    }
}