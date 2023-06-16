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

namespace TruckManagementApp
{
    public partial class ChatAdmin : Form
    {
        public ChatAdmin()
        {
            InitializeComponent();
        }

        private void ChatAdmin_Load(object sender, EventArgs e)
        {
            LoadUsersFromDatabase();
        }

        public void LoadUsersFromDatabase()
        {
            try
            {
                // Realizează interogarea asupra bazei de date pentru a obține utilizatorii din tabelul "Users"
                string connectionString = "Server=localhost\\SQLEXPRESS;Database=TruckManagementApp;Trusted_Connection=True;";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "SELECT user_name FROM Users";
                    SqlCommand command = new SqlCommand(query, connection);

                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    // Golește ListView-ul
                    lvUsers.Items.Clear();

                    // Adaugă utilizatorii în ListView
                    while (reader.Read())
                    {
                        string username = reader["user_name"].ToString();
                        lvUsers.Items.Add(username);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la încărcarea utilizatorilor din baza de date: " + ex.Message);
            }
        }

        private void btnRefreshUsersAdmin_Click_1(object sender, EventArgs e)
        {
            LoadUsersFromDatabase();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainPage mainPage = new MainPage();
            mainPage.Show();
            this.Hide();
            
        }
    }
}
