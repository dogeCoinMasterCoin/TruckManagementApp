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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TruckManagementApp
{
    public partial class LoginFile : Form
    {
        public int LoggedUserId { get; private set; }

        public LoginFile()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (VerifyUser(username, password))
            {
                LoggedUserId = GetUserId(username);
                //MessageBox.Show("Autentificare reușită!");

                MainPage mainPage = new MainPage();
                mainPage.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Username or password are wrong!");
            }
        }
        private bool VerifyUser(string username, string password)
        {
            string connectionString = "Server=localhost\\SQLEXPRESS;Database=TruckManagementApp;Trusted_Connection=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT COUNT(*) FROM Users WHERE user_name = @username AND user_password = @password";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);

                connection.Open();
                int count = (int)command.ExecuteScalar();

                return count > 0;
            }
        }

        private int GetUserId(string username)
        {
            string connectionString = "Server=localhost\\SQLEXPRESS;Database=TruckManagementApp;Trusted_Connection=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT user_id FROM Users WHERE user_name = @username";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@username", username);

                connection.Open();
                object result = command.ExecuteScalar();

                return (result != null) ? Convert.ToInt32(result) : 0;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCreateAcc_Click(object sender, EventArgs e)
        {
            
            CreateAccount createAccount = new CreateAccount();
            createAccount.Show();
            this.Hide();

        }

        private void LoginFile_Load(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
        }
    }
}
