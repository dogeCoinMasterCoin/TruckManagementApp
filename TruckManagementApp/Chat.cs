using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using Microsoft.AspNet.SignalR.Client;
using System.Web;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.IO;
using static System.Windows.Forms.ListViewItem;

namespace TruckManagementApp
{
    public partial class Chat : Form
    {
        public class User
        {
            public int ID { get; set; }
            public string UserName { get; set; }
        }

        
        private int loggedInUserId;

        private byte[] lastAttachmentData;

        private string imagePath = "";

        private List<User> users = new List<User>();

        public Chat()
        {
            InitializeComponent();
            lvUsers.SelectedIndexChanged += LvUsers_SelectedIndexChanged;

        }

        private void Chat_Load(object sender, EventArgs e)
        {
            LoadUsersFromDatabase();
        }

        public void LoadUsersFromDatabase()
        {
            try
            {
               
                string connectionString = "Server=localhost\\SQLEXPRESS;Database=TruckManagementApp;Trusted_Connection=True;";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "SELECT user_id, user_name FROM Users";
                    SqlCommand command = new SqlCommand(query, connection);

                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                   
                    lvUsers.Items.Clear();
                    users.Clear();

                    // add users in lvw
                    while (reader.Read())
                    {
                        int userId = Convert.ToInt32(reader["user_id"]);
                        string username = reader["user_name"].ToString();

                        User user = new User
                        {
                            ID = userId,
                            UserName = username
                        };

                        users.Add(user);

                        lvUsers.Items.Add(username);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading users " + ex.Message);
            }
        }

        private int GetSelectedUserId()
        {
            if (lvUsers.SelectedIndices.Count > 0)
            {
                int selectedIndex = lvUsers.SelectedIndices[0];
                return users[selectedIndex].ID;              
            }

            return -1; 
        }


        private void LvUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedUserId = GetSelectedUserId();

            if (selectedUserId != -1)
            {
                DisplayMessages(((LoginFile)Application.OpenForms["LoginFile"]).LoggedUserId, selectedUserId);
                if (lvMessages.SelectedItems.Count > 0)
                {
                    ListViewItem selectedItem = lvMessages.SelectedItems[0];
                  //  byte[] imageBytes = selectedItem.Tag as byte[];

                }
            }
        }
        private void AddMessageToListView(string senderName, string messageText, DateTime dateTime)
        {
            ListViewItem item = new ListViewItem(senderName);
            item.SubItems.Add(messageText);
            item.SubItems.Add(dateTime.ToString());

            lvMessages.Items.Add(item);
        }

        private void btnSendMessage_Click(object sender, EventArgs e)
        {
            string messageText = txtSendMessage.Text;
            int selectedUserId = GetSelectedUserId();
            if (selectedUserId != -1)
            {
                InsertMessageIntoDatabase(messageText, selectedUserId, imagePath);
                AddMessageToListView("You", messageText, DateTime.Now);
            }
            else
            {
                MessageBox.Show("Selectați un utilizator pentru a trimite mesajul.");
            }
            
        }

        private void InsertMessageIntoDatabase(string messageText, int selectedUserId, string imagePath)
        {
            try
            {
                int senderId = ((LoginFile)Application.OpenForms["LoginFile"]).LoggedUserId;
                int receiverId = users[lvUsers.SelectedIndices[0]].ID;
                DateTime dateTime = DateTime.Now;

                string connectionString = "Server=localhost\\SQLEXPRESS;Database=TruckManagementApp;Trusted_Connection=True;";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "INSERT INTO Messages (message_id, receiver_id, sender_id, date_and_time, message, Uploads) VALUES (next value for seq_message_id, @receiverId, @senderId, @dateTime, @message, null)";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@senderId", senderId);
                    command.Parameters.AddWithValue("@receiverId", receiverId);
                    command.Parameters.AddWithValue("@message", messageText);
                    command.Parameters.AddWithValue("@dateTime", dateTime);

                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inserting message: " + ex.Message);
            }
        }

        private void DisplayMessages(int senderId, int receiverId)
        {
            try
            {
                string connectionString = "Server=localhost\\SQLEXPRESS;Database=TruckManagementApp;Trusted_Connection=True;";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "SELECT sender_id, message, date_and_time, Uploads FROM Messages WHERE (sender_id = @senderId AND receiver_id = @receiverId) OR (sender_id = @receiverId AND receiver_id = @senderId) ORDER BY date_and_time";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@senderId", senderId);
                    command.Parameters.AddWithValue("@receiverId", receiverId);

                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    lvMessages.Items.Clear();

                    while (reader.Read())
                    {
                        int msgSenderId = Convert.ToInt32(reader["sender_id"]);
                        string messageText = reader["message"].ToString();
                        DateTime dateTime = Convert.ToDateTime(reader["date_and_time"]);
                        byte[] imageBytes = reader["Uploads"] as byte[];

                        string senderName = (msgSenderId == senderId) ? "You" : users.Find(u => u.ID == msgSenderId)?.UserName;

                        if (imageBytes != null && imageBytes.Length > 0)
                        {
                            ListViewItem item = new ListViewItem(senderName);
                            item.SubItems.Add(messageText);
                            item.SubItems.Add(dateTime.ToString());

                            ListViewSubItem buttonSubItem = new ListViewSubItem();
                            buttonSubItem.Text = "Descarcă";
                            buttonSubItem.Tag = imageBytes;

                            item.SubItems.Add(buttonSubItem);
                            lvMessages.Items.Add(item);
                        }


                        else
                        {
                            ListViewItem item = new ListViewItem(senderName);
                            item.SubItems.Add(messageText);
                            item.SubItems.Add(dateTime.ToString());
                            lvMessages.Items.Add(item);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error. Can't load messages " + ex.Message);
            }
        }

        private void UploadImage(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Fișiere imagine (*.jpg, *.jpeg, *.png)|*.jpg;*.jpeg;*.png|Fișiere PDF (*.pdf)|*.pdf";
                openFileDialog.Multiselect = false;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    int senderId = ((LoginFile)Application.OpenForms["LoginFile"]).LoggedUserId;
                    int receiverId = users[lvUsers.SelectedIndices[0]].ID;
                    DateTime dateTime = DateTime.Now;
                    string filePath = openFileDialog.FileName;

                    byte[] fileData = File.ReadAllBytes(filePath);

                    string connectionString = "Server=localhost\\SQLEXPRESS;Database=TruckManagementApp;Trusted_Connection=True;";
                    string query = "INSERT INTO Messages (message_id, receiver_id, sender_id, date_and_time, message, Uploads) VALUES (next value for seq_message_id, @receiverId, @senderId, @dateTime, 'Attachement sent.', @FileData)";

                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@FileData", fileData);
                        command.Parameters.AddWithValue("@senderId", senderId);
                        command.Parameters.AddWithValue("@receiverId", receiverId);
                        command.Parameters.AddWithValue("@dateTime", dateTime);

                        connection.Open();
                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("Image successfully upload!");
                    AddMessageToListView("You", "Attachement sent.", DateTime.Now);

                }
            }
        }
        private void btnUploadDocument_Click(object sender, EventArgs e)
        {
                    UploadImage(sender, e);

        }

        private void SaveImageFromDatabaseAndDownload(object sender, EventArgs e)
        {

            int senderId = ((LoginFile)Application.OpenForms["LoginFile"]).LoggedUserId;
            int receiverId = users[lvUsers.SelectedIndices[0]].ID;
            string connectionString = "Server=localhost\\SQLEXPRESS;Database=TruckManagementApp;Trusted_Connection=True;";
            string query = "SELECT TOP 1 Uploads FROM Messages WHERE ((sender_id = @senderId AND receiver_id = @receiverId) OR (sender_id = @receiverId AND receiver_id = @senderId)) AND Uploads IS NOT NULL ORDER BY DATE_AND_TIME DESC;";


            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@senderId", senderId);
                command.Parameters.AddWithValue("@receiverId", receiverId);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                     
                    if (reader.Read())
                    {
                        if (!reader.IsDBNull(reader.GetOrdinal("Uploads")))
                        {
                            byte[] fileData = (byte[])reader["Uploads"];

                            SaveFileDialog saveFileDialog = new SaveFileDialog();
                            saveFileDialog.Filter = "Fișiere (*.jpg, *.jpeg, *.png, *.pdf)|*.jpg;*.jpeg;*.png;*.pdf";
                            if (saveFileDialog.ShowDialog() == DialogResult.OK)
                            {
                                string filePath = saveFileDialog.FileName;
                                File.WriteAllBytes(filePath, fileData);
                                MessageBox.Show("Download successfully!");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Attachment downloaded did not exist.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("No attachment available for download.");
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error downloading document: " + ex.Message);
                }
            }
        }


        private void btnDownload_Click(object sender, EventArgs e)
        {
            int selectedUserId = GetSelectedUserId();

            if (selectedUserId != -1)
            {
                SaveImageFromDatabaseAndDownload(sender, e);
            }
            else
            {
                MessageBox.Show("Select an user to download attachment.");
            }
        }

        private void btnBackUsers_Click(object sender, EventArgs e)
        {
            MainPage mainPage = new MainPage();
            mainPage.Show();
            this.Hide();
        }

        private void lvMessages_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}  
     