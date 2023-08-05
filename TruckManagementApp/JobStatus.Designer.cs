namespace TruckManagementApp
{
    partial class JobStatus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JobStatus));
            this.truckManagementAppDataSet2 = new TruckManagementApp.TruckManagementAppDataSet2();
            this.jOBSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jOBSTableAdapter = new TruckManagementApp.TruckManagementAppDataSet2TableAdapters.JOBSTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.jobIdCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jobNameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inProgressBtn = new System.Windows.Forms.Button();
            this.doneBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.truckManagementAppDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jOBSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // truckManagementAppDataSet2
            // 
            this.truckManagementAppDataSet2.DataSetName = "TruckManagementAppDataSet2";
            this.truckManagementAppDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // jOBSBindingSource
            // 
            this.jOBSBindingSource.DataMember = "JOBS";
            this.jOBSBindingSource.DataSource = this.truckManagementAppDataSet2;
            // 
            // jOBSTableAdapter
            // 
            this.jOBSTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.jobIdCol,
            this.jobNameCol});
            this.dataGridView1.Location = new System.Drawing.Point(11, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(276, 426);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // jobIdCol
            // 
            this.jobIdCol.HeaderText = "Job_Id";
            this.jobIdCol.MinimumWidth = 6;
            this.jobIdCol.Name = "jobIdCol";
            this.jobIdCol.Width = 125;
            // 
            // jobNameCol
            // 
            this.jobNameCol.HeaderText = "Job Name";
            this.jobNameCol.MinimumWidth = 6;
            this.jobNameCol.Name = "jobNameCol";
            this.jobNameCol.Width = 125;
            // 
            // inProgressBtn
            // 
            this.inProgressBtn.Location = new System.Drawing.Point(287, 12);
            this.inProgressBtn.Name = "inProgressBtn";
            this.inProgressBtn.Size = new System.Drawing.Size(88, 53);
            this.inProgressBtn.TabIndex = 1;
            this.inProgressBtn.Text = "In Progress";
            this.inProgressBtn.UseVisualStyleBackColor = true;
            this.inProgressBtn.Click += new System.EventHandler(this.inProgressBtn_Click);
            // 
            // doneBtn
            // 
            this.doneBtn.Location = new System.Drawing.Point(381, 12);
            this.doneBtn.Name = "doneBtn";
            this.doneBtn.Size = new System.Drawing.Size(88, 53);
            this.doneBtn.TabIndex = 2;
            this.doneBtn.Text = "Done";
            this.doneBtn.UseVisualStyleBackColor = true;
            this.doneBtn.Click += new System.EventHandler(this.doneBtn_Click);
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(381, 385);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(88, 53);
            this.backBtn.TabIndex = 3;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // JobStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(481, 450);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.doneBtn);
            this.Controls.Add(this.inProgressBtn);
            this.Controls.Add(this.dataGridView1);
            this.Name = "JobStatus";
            this.Text = "JobStatus";
            this.Load += new System.EventHandler(this.JobStatus_Load);
            ((System.ComponentModel.ISupportInitialize)(this.truckManagementAppDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jOBSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private TruckManagementAppDataSet2 truckManagementAppDataSet2;
        private System.Windows.Forms.BindingSource jOBSBindingSource;
        private TruckManagementAppDataSet2TableAdapters.JOBSTableAdapter jOBSTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button inProgressBtn;
        private System.Windows.Forms.Button doneBtn;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jobIdCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn jobNameCol;
    }
}