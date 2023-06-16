namespace TruckManagementApp
{
    partial class AssignJob
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AssignJob));
            this.truckManagementAppDataSet1 = new TruckManagementApp.TruckManagementAppDataSet1();
            this.jOBSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jOBSTableAdapter = new TruckManagementApp.TruckManagementAppDataSet1TableAdapters.JOBSTableAdapter();
            this.jobIdTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.sendJobBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.truckManagementAppDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jOBSBindingSource)).BeginInit();
            this.SuspendLayout();
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
            // 
            // jOBSTableAdapter
            // 
            this.jOBSTableAdapter.ClearBeforeFill = true;
            // 
            // jobIdTxt
            // 
            this.jobIdTxt.BackColor = System.Drawing.Color.Chocolate;
            this.jobIdTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.jobIdTxt.Location = new System.Drawing.Point(191, 59);
            this.jobIdTxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.jobIdTxt.Name = "jobIdTxt";
            this.jobIdTxt.Size = new System.Drawing.Size(83, 28);
            this.jobIdTxt.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label1.Location = new System.Drawing.Point(120, 63);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Job ID";
            // 
            // sendJobBtn
            // 
            this.sendJobBtn.BackColor = System.Drawing.Color.Silver;
            this.sendJobBtn.FlatAppearance.BorderColor = System.Drawing.Color.Chocolate;
            this.sendJobBtn.FlatAppearance.BorderSize = 0;
            this.sendJobBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.sendJobBtn.Location = new System.Drawing.Point(282, 59);
            this.sendJobBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sendJobBtn.Name = "sendJobBtn";
            this.sendJobBtn.Size = new System.Drawing.Size(83, 28);
            this.sendJobBtn.TabIndex = 2;
            this.sendJobBtn.Text = "Send Job";
            this.sendJobBtn.UseVisualStyleBackColor = false;
            this.sendJobBtn.Click += new System.EventHandler(this.sendJobBtn_Click);
            // 
            // AssignJob
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(443, 184);
            this.Controls.Add(this.sendJobBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.jobIdTxt);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AssignJob";
            this.Text = "AssignJob";
            this.Load += new System.EventHandler(this.AssignJob_Load);
            ((System.ComponentModel.ISupportInitialize)(this.truckManagementAppDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jOBSBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TruckManagementAppDataSet1 truckManagementAppDataSet1;
        private System.Windows.Forms.BindingSource jOBSBindingSource;
        private TruckManagementAppDataSet1TableAdapters.JOBSTableAdapter jOBSTableAdapter;
        private System.Windows.Forms.TextBox jobIdTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button sendJobBtn;
    }
}