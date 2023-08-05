namespace TruckManagementApp
{
    partial class TrackJobs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrackJobs));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.taskStatusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.truckManagementAppDataSet3 = new TruckManagementApp.TruckManagementAppDataSet3();
            this.task_StatusTableAdapter = new TruckManagementApp.TruckManagementAppDataSet3TableAdapters.Task_StatusTableAdapter();
            this.truckManagementAppDataSet6 = new TruckManagementApp.TruckManagementAppDataSet6();
            this.taskStatusBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.task_StatusTableAdapter1 = new TruckManagementApp.TruckManagementAppDataSet6TableAdapters.Task_StatusTableAdapter();
            this.jobidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jobnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.useridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskStatusBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.truckManagementAppDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.truckManagementAppDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskStatusBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.jobidDataGridViewTextBoxColumn,
            this.jobnameDataGridViewTextBoxColumn,
            this.useridDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.taskStatusBindingSource1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(723, 450);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // taskStatusBindingSource
            // 
            this.taskStatusBindingSource.DataMember = "Task_Status";
            this.taskStatusBindingSource.DataSource = this.truckManagementAppDataSet3;
            // 
            // truckManagementAppDataSet3
            // 
            this.truckManagementAppDataSet3.DataSetName = "TruckManagementAppDataSet3";
            this.truckManagementAppDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // task_StatusTableAdapter
            // 
            this.task_StatusTableAdapter.ClearBeforeFill = true;
            // 
            // truckManagementAppDataSet6
            // 
            this.truckManagementAppDataSet6.DataSetName = "TruckManagementAppDataSet6";
            this.truckManagementAppDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // taskStatusBindingSource1
            // 
            this.taskStatusBindingSource1.DataMember = "Task_Status";
            this.taskStatusBindingSource1.DataSource = this.truckManagementAppDataSet6;
            // 
            // task_StatusTableAdapter1
            // 
            this.task_StatusTableAdapter1.ClearBeforeFill = true;
            // 
            // jobidDataGridViewTextBoxColumn
            // 
            this.jobidDataGridViewTextBoxColumn.DataPropertyName = "job_id";
            this.jobidDataGridViewTextBoxColumn.HeaderText = "job_id";
            this.jobidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.jobidDataGridViewTextBoxColumn.Name = "jobidDataGridViewTextBoxColumn";
            this.jobidDataGridViewTextBoxColumn.Width = 125;
            // 
            // jobnameDataGridViewTextBoxColumn
            // 
            this.jobnameDataGridViewTextBoxColumn.DataPropertyName = "job_name";
            this.jobnameDataGridViewTextBoxColumn.HeaderText = "job_name";
            this.jobnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.jobnameDataGridViewTextBoxColumn.Name = "jobnameDataGridViewTextBoxColumn";
            this.jobnameDataGridViewTextBoxColumn.Width = 125;
            // 
            // useridDataGridViewTextBoxColumn
            // 
            this.useridDataGridViewTextBoxColumn.DataPropertyName = "user_id";
            this.useridDataGridViewTextBoxColumn.HeaderText = "user_id";
            this.useridDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.useridDataGridViewTextBoxColumn.Name = "useridDataGridViewTextBoxColumn";
            this.useridDataGridViewTextBoxColumn.Width = 125;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "status";
            this.statusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.Width = 125;
            // 
            // TrackJobs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(723, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "TrackJobs";
            this.Text = "TrackJobs";
            this.Load += new System.EventHandler(this.TrackJobs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskStatusBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.truckManagementAppDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.truckManagementAppDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskStatusBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private TruckManagementAppDataSet3 truckManagementAppDataSet3;
        private System.Windows.Forms.BindingSource taskStatusBindingSource;
        private TruckManagementAppDataSet3TableAdapters.Task_StatusTableAdapter task_StatusTableAdapter;
        private TruckManagementAppDataSet6 truckManagementAppDataSet6;
        private System.Windows.Forms.BindingSource taskStatusBindingSource1;
        private TruckManagementAppDataSet6TableAdapters.Task_StatusTableAdapter task_StatusTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn jobidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jobnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn useridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
    }
}