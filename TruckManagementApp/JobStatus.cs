using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace TruckManagementApp
{
    public partial class JobStatus : Form
    {
        int currentUserId = ((LoginFile)Application.OpenForms["LoginFile"]).LoggedUserId;

        List<string> jobIdList = new List<string>();
        List<string> jobNameList = new List<string>();

        string connectionString = "Server=localhost\\SQLEXPRESS;Database=TruckManagementApp;Trusted_Connection=True;";

        public JobStatus()
        {
            string queryGetUserName = "SELECT job_id, job_name FROM ASSIGNED_JOBS WHERE user_id  =" + currentUserId;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(queryGetUserName, connection))
                {
                    command.Parameters.Add("@userId", SqlDbType.Int).Value = currentUserId;


                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string currentUserName = reader.GetString(0);
                            string currentJobName = reader.GetString(1);

                            jobIdList.Add(currentUserName);
                            jobNameList.Add(currentJobName);
                        }

                    }
                }
            }


            InitializeComponent();
        }

        private void JobStatus_Load(object sender, EventArgs e)
        {
            if(jobIdList.Count > 0)
            {
                dataGridView1.Rows.Add(jobIdList.Count);
                for (int i = 0; i < jobIdList.Count; i++)
                {
                    dataGridView1.Rows[i].Cells[0].Value = jobIdList[i];
                    dataGridView1.Rows[i].Cells[1].Value = jobNameList[i];

                }
            }         
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            MainPage mainPage = new MainPage();
            mainPage.Show();
            this.Hide();
        }

        private void inProgressBtn_Click(object sender, EventArgs e)
        {
            string messageForInProgress = "Task was started by the driver";

            if (dataGridView1.SelectedRows.Count > 0)
            {
                int selectedJobId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                string selectedJobName = Convert.ToString(dataGridView1.SelectedRows[0].Cells[1].Value);

                string connectionString = "Server=localhost\\SQLEXPRESS;Database=TruckManagementApp;Trusted_Connection=True;";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "INSERT INTO Task_Status (job_id, job_name, user_id, status) VALUES (@jobId, @jobName, @userId, @Status)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@jobId", selectedJobId);
                        command.Parameters.AddWithValue("@jobName", selectedJobName);
                        command.Parameters.AddWithValue("@userId", currentUserId);
                        command.Parameters.AddWithValue("@Status", messageForInProgress);


                        command.ExecuteNonQuery();

                        MessageBox.Show("Status updated!");
                    }
                }
            }
            else
            {
                MessageBox.Show("Select a job id before change status.");
            }
        }

        private void doneBtn_Click(object sender, EventArgs e)
        {
            string messageForInProgress = "Task is done!";
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int selectedJobId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                string selectedJobName = Convert.ToString(dataGridView1.SelectedRows[0].Cells[1].Value);
                string connectionString = "Server=localhost\\SQLEXPRESS;Database=TruckManagementApp;Trusted_Connection=True;";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "INSERT INTO Task_Status (job_id, job_name, user_id, status) VALUES (@jobId, @jobName, @userId, @Status)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@jobId", selectedJobId);
                        command.Parameters.AddWithValue("@jobName", selectedJobName);
                        command.Parameters.AddWithValue("@userId", currentUserId);
                        command.Parameters.AddWithValue("@Status", messageForInProgress);


                        command.ExecuteNonQuery();

                        MessageBox.Show("Status updated!");
                    }
                }
            }
            else
            {
                MessageBox.Show("Select a job id before change status.");
            }
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
