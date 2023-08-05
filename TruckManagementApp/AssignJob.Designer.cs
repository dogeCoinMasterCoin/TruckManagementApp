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
            this.jOBSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jobIdTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.sendJobBtn = new System.Windows.Forms.Button();
            this.labelBack = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.jOBSBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // jobIdTxt
            // 
            this.jobIdTxt.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.jobIdTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.jobIdTxt.Location = new System.Drawing.Point(112, 143);
            this.jobIdTxt.Margin = new System.Windows.Forms.Padding(4);
            this.jobIdTxt.Name = "jobIdTxt";
            this.jobIdTxt.Size = new System.Drawing.Size(83, 28);
            this.jobIdTxt.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label1.Location = new System.Drawing.Point(108, 105);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Assign Job by Job Id";
            // 
            // sendJobBtn
            // 
            this.sendJobBtn.BackColor = System.Drawing.Color.Silver;
            this.sendJobBtn.FlatAppearance.BorderColor = System.Drawing.Color.Chocolate;
            this.sendJobBtn.FlatAppearance.BorderSize = 0;
            this.sendJobBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.sendJobBtn.Location = new System.Drawing.Point(209, 143);
            this.sendJobBtn.Margin = new System.Windows.Forms.Padding(4);
            this.sendJobBtn.Name = "sendJobBtn";
            this.sendJobBtn.Size = new System.Drawing.Size(83, 28);
            this.sendJobBtn.TabIndex = 2;
            this.sendJobBtn.Text = "Send Job";
            this.sendJobBtn.UseVisualStyleBackColor = false;
            this.sendJobBtn.Click += new System.EventHandler(this.sendJobBtn_Click);
            // 
            // labelBack
            // 
            this.labelBack.AutoSize = true;
            this.labelBack.BackColor = System.Drawing.Color.Transparent;
            this.labelBack.Location = new System.Drawing.Point(380, 9);
            this.labelBack.Name = "labelBack";
            this.labelBack.Size = new System.Drawing.Size(51, 24);
            this.labelBack.TabIndex = 3;
            this.labelBack.Text = "Back";
            this.labelBack.Click += new System.EventHandler(this.labelBack_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(68, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "This driver is in:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(214, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "-";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // AssignJob
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(443, 184);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelBack);
            this.Controls.Add(this.sendJobBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.jobIdTxt);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AssignJob";
            this.Text = "AssignJob";
            this.Load += new System.EventHandler(this.AssignJob_Load);
            ((System.ComponentModel.ISupportInitialize)(this.jOBSBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        //private TruckManagementAppDataSet1 truckManagementAppDataSet1;
        private System.Windows.Forms.BindingSource jOBSBindingSource;
       // private TruckManagementAppDataSet1TableAdapters.JOBSTableAdapter jOBSTableAdapter;
        private System.Windows.Forms.TextBox jobIdTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button sendJobBtn;
        private System.Windows.Forms.Label labelBack;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}