using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TruckManagementApp
{
    public partial class TasksManagement : Form
    {
        string connectionString = "Server=localhost\\SQLEXPRESS;Database=TruckManagementApp;Trusted_Connection=True;";

        public TasksManagement()
        {
            InitializeComponent();
        }

        //Maps btn
        private void lastJobBtn_Click(object sender, EventArgs e)
        {
            Maps lastLocation = new Maps();
            lastLocation.Show();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            MainPage mainPage = new MainPage();
            mainPage.Show();
            this.Hide();
        }

        private void TasksManagement_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'truckManagementAppDataSet.USERS' table. You can move, or remove it, as needed.
            this.uSERSTableAdapter.Fill(this.truckManagementAppDataSet.USERS);
            LoadDataIntoDataGridView();


        }

        //Display users with firstName equals with searchBar text
        private void searchBtn_Click(object sender, EventArgs e)
        {
            string searchText = searchBoxTxt.Text.Trim();

            string query = "SELECT user_id, user_name,first_name, last_name FROM USERS WHERE first_name LIKE @SearchText";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@SearchText", "%" + searchText + "%");

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                dataGridView1.DataSource = dataTable;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void assignTaskBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int selectedUserId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);

                AssignJob assignJob = new AssignJob(selectedUserId);
                assignJob.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Select an user before assign a job.");
            }
        }

        private void jOBSBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void LoadDataIntoDataGridView()
        {
            string connectionString = "Server=localhost\\SQLEXPRESS;Database=TruckManagementApp;Trusted_Connection=True;";
            string selectQuery = "SELECT user_id, user_name, first_name, last_name FROM USERS";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(selectQuery, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();

                try
                {
                    connection.Open();
                    adapter.Fill(dataTable);

                    dataGridView1.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
    }
}
