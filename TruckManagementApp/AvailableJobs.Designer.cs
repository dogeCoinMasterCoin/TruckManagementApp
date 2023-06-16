namespace TruckManagementApp
{
    partial class AvailableJobs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AvailableJobs));
            this.browseBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.jOBSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.truckManagementAppDataSet1 = new TruckManagementApp.TruckManagementAppDataSet1();
            this.truckManagementAppDataSet = new TruckManagementApp.TruckManagementAppDataSet();
            this.truckManagementAppDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jOBSTableAdapter = new TruckManagementApp.TruckManagementAppDataSet1TableAdapters.JOBSTableAdapter();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.jOBSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.truckManagementAppDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.truckManagementAppDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.truckManagementAppDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // browseBtn
            // 
            this.browseBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.browseBtn.BackColor = System.Drawing.Color.SlateGray;
            this.browseBtn.Location = new System.Drawing.Point(165, 120);
            this.browseBtn.Name = "browseBtn";
            this.browseBtn.Size = new System.Drawing.Size(201, 29);
            this.browseBtn.TabIndex = 0;
            this.browseBtn.Text = "Browse";
            this.browseBtn.UseVisualStyleBackColor = false;
            this.browseBtn.Click += new System.EventHandler(this.browseBtn_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label1.Location = new System.Drawing.Point(161, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Upload job documents.";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(179, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Accepted formats: .jpg, .pdf,";
            // 
            // jOBSBindingSource
            // 
            this.jOBSBindingSource.DataMember = "JOBS";
            this.jOBSBindingSource.DataSource = this.truckManagementAppDataSet1;
            // 
            // truckManagementAppDataSet1
            // 
            this.truckManagementAppDataSet1.DataSetName = "TruckManagementAppDataSet1";
            this.truckManagementAppDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // truckManagementAppDataSet
            // 
            this.truckManagementAppDataSet.DataSetName = "TruckManagementAppDataSet";
            this.truckManagementAppDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // truckManagementAppDataSetBindingSource
            // 
            this.truckManagementAppDataSetBindingSource.DataSource = this.truckManagementAppDataSet;
            this.truckManagementAppDataSetBindingSource.Position = 0;
            // 
            // jOBSTableAdapter
            // 
            this.jOBSTableAdapter.ClearBeforeFill = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label3.ForeColor = System.Drawing.Color.Aqua;
            this.label3.Location = new System.Drawing.Point(472, 9);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(42, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Back";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // AvailableJobs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(522, 287);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.browseBtn);
            this.Name = "AvailableJobs";
            this.Text = "AvailableJobs";
            this.Load += new System.EventHandler(this.AvailableJobs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.jOBSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.truckManagementAppDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.truckManagementAppDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.truckManagementAppDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button browseBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private TruckManagementAppDataSet truckManagementAppDataSet;
        private System.Windows.Forms.BindingSource truckManagementAppDataSetBindingSource;
        private TruckManagementAppDataSet1 truckManagementAppDataSet1;
        private System.Windows.Forms.BindingSource jOBSBindingSource;
        private TruckManagementAppDataSet1TableAdapters.JOBSTableAdapter jOBSTableAdapter;
        private System.Windows.Forms.Label label3;
    }
}