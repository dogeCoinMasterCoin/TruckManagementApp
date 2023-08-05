namespace TruckManagementApp
{
    partial class Chat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Chat));
            this.btnSendMessage = new System.Windows.Forms.Button();
            this.txtSendMessage = new System.Windows.Forms.TextBox();
            this.lvUsers = new System.Windows.Forms.ListView();
            this.colUsername = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnBackUsers = new System.Windows.Forms.Button();
            this.lvMessages = new System.Windows.Forms.ListView();
            this.colUser = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colMessage = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDateAndHour = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnUploadDocument = new System.Windows.Forms.Button();
            this.btnDownload = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSendMessage
            // 
            this.btnSendMessage.Location = new System.Drawing.Point(827, 405);
            this.btnSendMessage.Margin = new System.Windows.Forms.Padding(4);
            this.btnSendMessage.Name = "btnSendMessage";
            this.btnSendMessage.Size = new System.Drawing.Size(119, 28);
            this.btnSendMessage.TabIndex = 0;
            this.btnSendMessage.Text = "Send";
            this.btnSendMessage.UseVisualStyleBackColor = true;
            this.btnSendMessage.Click += new System.EventHandler(this.btnSendMessage_Click);
            // 
            // txtSendMessage
            // 
            this.txtSendMessage.Location = new System.Drawing.Point(312, 407);
            this.txtSendMessage.Margin = new System.Windows.Forms.Padding(4);
            this.txtSendMessage.Name = "txtSendMessage";
            this.txtSendMessage.Size = new System.Drawing.Size(505, 22);
            this.txtSendMessage.TabIndex = 1;
            // 
            // lvUsers
            // 
            this.lvUsers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colUsername});
            this.lvUsers.HideSelection = false;
            this.lvUsers.Location = new System.Drawing.Point(68, 42);
            this.lvUsers.Margin = new System.Windows.Forms.Padding(4);
            this.lvUsers.Name = "lvUsers";
            this.lvUsers.Size = new System.Drawing.Size(199, 390);
            this.lvUsers.TabIndex = 2;
            this.lvUsers.UseCompatibleStateImageBehavior = false;
            this.lvUsers.View = System.Windows.Forms.View.Details;
            // 
            // colUsername
            // 
            this.colUsername.Text = "Username";
            this.colUsername.Width = 146;
            // 
            // btnBackUsers
            // 
            this.btnBackUsers.Location = new System.Drawing.Point(983, 6);
            this.btnBackUsers.Margin = new System.Windows.Forms.Padding(4);
            this.btnBackUsers.Name = "btnBackUsers";
            this.btnBackUsers.Size = new System.Drawing.Size(200, 28);
            this.btnBackUsers.TabIndex = 3;
            this.btnBackUsers.Text = "Back";
            this.btnBackUsers.UseVisualStyleBackColor = true;
            this.btnBackUsers.Click += new System.EventHandler(this.btnBackUsers_Click);
            // 
            // lvMessages
            // 
            this.lvMessages.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colUser,
            this.colMessage,
            this.colDateAndHour});
            this.lvMessages.HideSelection = false;
            this.lvMessages.Location = new System.Drawing.Point(312, 42);
            this.lvMessages.Margin = new System.Windows.Forms.Padding(4);
            this.lvMessages.Name = "lvMessages";
            this.lvMessages.Size = new System.Drawing.Size(869, 357);
            this.lvMessages.TabIndex = 4;
            this.lvMessages.UseCompatibleStateImageBehavior = false;
            this.lvMessages.View = System.Windows.Forms.View.Details;
            this.lvMessages.SelectedIndexChanged += new System.EventHandler(this.lvMessages_SelectedIndexChanged);
            // 
            // colUser
            // 
            this.colUser.Text = "Username";
            this.colUser.Width = 147;
            // 
            // colMessage
            // 
            this.colMessage.Text = "Message";
            this.colMessage.Width = 293;
            // 
            // colDateAndHour
            // 
            this.colDateAndHour.Text = "Date and Hour";
            this.colDateAndHour.Width = 156;
            // 
            // btnUploadDocument
            // 
            this.btnUploadDocument.Location = new System.Drawing.Point(953, 405);
            this.btnUploadDocument.Margin = new System.Windows.Forms.Padding(4);
            this.btnUploadDocument.Name = "btnUploadDocument";
            this.btnUploadDocument.Size = new System.Drawing.Size(100, 28);
            this.btnUploadDocument.TabIndex = 5;
            this.btnUploadDocument.Text = "Attachment";
            this.btnUploadDocument.UseVisualStyleBackColor = true;
            this.btnUploadDocument.Click += new System.EventHandler(this.btnUploadDocument_Click);
            // 
            // btnDownload
            // 
            this.btnDownload.Location = new System.Drawing.Point(1061, 404);
            this.btnDownload.Margin = new System.Windows.Forms.Padding(4);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(121, 28);
            this.btnDownload.TabIndex = 6;
            this.btnDownload.Text = "Download";
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // Chat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1227, 463);
            this.Controls.Add(this.btnDownload);
            this.Controls.Add(this.btnUploadDocument);
            this.Controls.Add(this.lvMessages);
            this.Controls.Add(this.btnBackUsers);
            this.Controls.Add(this.lvUsers);
            this.Controls.Add(this.txtSendMessage);
            this.Controls.Add(this.btnSendMessage);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Chat";
            this.Text = "Chat";
            this.Load += new System.EventHandler(this.Chat_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSendMessage;
        private System.Windows.Forms.TextBox txtSendMessage;
        private System.Windows.Forms.ListView lvUsers;
        private System.Windows.Forms.Button btnBackUsers;
        private System.Windows.Forms.ColumnHeader colUsername;
        private System.Windows.Forms.ListView lvMessages;
        private System.Windows.Forms.ColumnHeader colUser;
        private System.Windows.Forms.ColumnHeader colMessage;
        private System.Windows.Forms.ColumnHeader colDateAndHour;
        private System.Windows.Forms.Button btnUploadDocument;
        private System.Windows.Forms.Button btnDownload;
    }
}