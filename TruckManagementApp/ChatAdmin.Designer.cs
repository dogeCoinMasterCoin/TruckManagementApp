namespace TruckManagementApp
{
    partial class ChatAdmin
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
            this.btnSendMessageAdmin = new System.Windows.Forms.Button();
            this.txtSendMessageAdmin = new System.Windows.Forms.TextBox();
            this.lvUsers = new System.Windows.Forms.ListView();
            this.colUsername = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnRefreshUsersAdmin = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSendMessageAdmin
            // 
            this.btnSendMessageAdmin.Location = new System.Drawing.Point(708, 407);
            this.btnSendMessageAdmin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSendMessageAdmin.Name = "btnSendMessageAdmin";
            this.btnSendMessageAdmin.Size = new System.Drawing.Size(100, 28);
            this.btnSendMessageAdmin.TabIndex = 0;
            this.btnSendMessageAdmin.Text = "Send";
            this.btnSendMessageAdmin.UseVisualStyleBackColor = true;
            // 
            // txtSendMessageAdmin
            // 
            this.txtSendMessageAdmin.Location = new System.Drawing.Point(312, 407);
            this.txtSendMessageAdmin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSendMessageAdmin.Name = "txtSendMessageAdmin";
            this.txtSendMessageAdmin.Size = new System.Drawing.Size(387, 22);
            this.txtSendMessageAdmin.TabIndex = 1;
            // 
            // lvUsers
            // 
            this.lvUsers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colUsername});
            this.lvUsers.HideSelection = false;
            this.lvUsers.Location = new System.Drawing.Point(68, 42);
            this.lvUsers.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lvUsers.Name = "lvUsers";
            this.lvUsers.Size = new System.Drawing.Size(199, 389);
            this.lvUsers.TabIndex = 2;
            this.lvUsers.UseCompatibleStateImageBehavior = false;
            this.lvUsers.View = System.Windows.Forms.View.Details;
            // 
            // colUsername
            // 
            this.colUsername.Text = "Username";
            // 
            // btnRefreshUsersAdmin
            // 
            this.btnRefreshUsersAdmin.Location = new System.Drawing.Point(68, 441);
            this.btnRefreshUsersAdmin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRefreshUsersAdmin.Name = "btnRefreshUsersAdmin";
            this.btnRefreshUsersAdmin.Size = new System.Drawing.Size(200, 28);
            this.btnRefreshUsersAdmin.TabIndex = 3;
            this.btnRefreshUsersAdmin.Text = "Refresh";
            this.btnRefreshUsersAdmin.UseVisualStyleBackColor = true;
            this.btnRefreshUsersAdmin.Click += new System.EventHandler(this.btnRefreshUsersAdmin_Click_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(424, 496);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(307, 46);
            this.button1.TabIndex = 4;
            this.button1.Text = "Back--Temporal";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ChatAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnRefreshUsersAdmin);
            this.Controls.Add(this.lvUsers);
            this.Controls.Add(this.txtSendMessageAdmin);
            this.Controls.Add(this.btnSendMessageAdmin);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ChatAdmin";
            this.Text = "ChatAdmin";
            this.Load += new System.EventHandler(this.ChatAdmin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSendMessageAdmin;
        private System.Windows.Forms.TextBox txtSendMessageAdmin;
        private System.Windows.Forms.ListView lvUsers;
        private System.Windows.Forms.Button btnRefreshUsersAdmin;
        private System.Windows.Forms.ColumnHeader colUsername;
        private System.Windows.Forms.Button button1;
    }
}