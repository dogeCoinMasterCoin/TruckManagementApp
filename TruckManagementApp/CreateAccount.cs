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
    public partial class CreateAccount : Form
    {
        public CreateAccount()
        {
            InitializeComponent();
        }

        private void btnCreeazaContul_Click(object sender, EventArgs e)
        {
            string username = txtCreateAccUsername.Text;
            string password = txtCreateAccPassword.Text;
            string repeatPassword = txtCreateAccRepeatPass.Text;
            string firstName = txtCreateAccFirstName.Text;
            string lastName = txtCreateAccLastName.Text;

            // Verifică dacă parolele coincid
            if (password != repeatPassword)
            {
                MessageBox.Show("Password & confirm password are diffrent.");
                return;
            }
            else if (username.Length < 6 || password.Length < 6 || repeatPassword.Length < 6)
            {
                MessageBox.Show("Username or password need to be at least 6 characters long.");
                return;
            }
            // Înserează datele în baza de date
            string connectionString = "Server=localhost\\SQLEXPRESS;Database=TruckManagementApp;Trusted_Connection=True;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Creează o comandă SQL pentru inserarea datelor
                    string query = "INSERT INTO USERS (user_id, user_name, user_password, first_name, last_name) VALUES (NEXT VALUE FOR SEQ_USER_ID, @username, @password, @firstName, @lastName)";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@username", username);
                        command.Parameters.AddWithValue("@password", password);
                        command.Parameters.AddWithValue("@firstName", firstName);
                        command.Parameters.AddWithValue("@lastName", lastName);

                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("Cont creat cu succes!");
                    MainPage mainPage = new MainPage();
                    mainPage.Show();
                    this.Hide();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error creating account: " + ex.Message);
                }
            }
        }

        private void txtCreateAccUsername_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginFile loginFile = new LoginFile();
            loginFile.Show();
            this.Hide();
        }

        private void CreateAccount_Load(object sender, EventArgs e)
        {
            txtCreateAccPassword.UseSystemPasswordChar = true;
            txtCreateAccRepeatPass.UseSystemPasswordChar = true;
        }
    }
}
