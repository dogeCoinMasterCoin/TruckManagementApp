using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TruckManagementApp
{
    public partial class AssignJob : Form
    {
        private int selectedUserId;
        private List<string> destinationOfTheDriver = new List<string>();

        public AssignJob(int selectedUserId)
        {
            InitializeComponent();
            this.selectedUserId = selectedUserId;
        }

        private void AssignJob_Load(object sender, EventArgs e)
        {
          //  this.jOBSTableAdapter.Fill(this.truckManagementAppDataSet1.JOBS);
            destinationOfTheDriver = GetDestinationsForUser(selectedUserId);
            destinationOfTheDriver.Reverse();
            if(destinationOfTheDriver.Count == 0)
            {
                //do nothing
            }
            else
            {
                label3.Text = destinationOfTheDriver[0];
            }                  
        }

        private void sendJobBtn_Click(object sender, EventArgs e)
        {
            int jobId;
            int userId;

            if (int.TryParse(jobIdTxt.Text, out jobId) && int.TryParse(selectedUserId.ToString(), out userId))
            {
                string connectionString = "Server=localhost\\SQLEXPRESS;Database=TruckManagementApp;Trusted_Connection=True;";
                string selectQuery = "SELECT job_description, job_name, origin_name, destination_name FROM JOBS WHERE job_id = @JobId";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand selectCommand = new SqlCommand(selectQuery, connection);
                    selectCommand.Parameters.AddWithValue("@JobId", jobId);

                    try
                    {
                        connection.Open();
                        SqlDataReader reader = selectCommand.ExecuteReader();

                        if (reader.Read())
                        {
                            if (!reader.IsDBNull(reader.GetOrdinal("job_description")))
                            {
                                byte[] fileData = (byte[])reader["job_description"];
                                string jobName = reader["job_name"].ToString();
                                string originName = reader["origin_name"].ToString();
                                string destinationName = reader["destination_name"].ToString();

                                string insertQuery = "INSERT INTO ASSIGNED_JOBS (user_id, job_id, job_name, job_description, origin_name, destination_name) VALUES (@UserId, @JobId, @JobName, @JobDescription, @OriginName, @DestinationName)";
                                SqlCommand insertCommand = new SqlCommand(insertQuery, connection);
                                insertCommand.Parameters.AddWithValue("@UserId", userId);
                                insertCommand.Parameters.AddWithValue("@jobName", jobName);
                                insertCommand.Parameters.AddWithValue("@JobId", jobId);
                                insertCommand.Parameters.AddWithValue("@JobDescription", fileData);
                                insertCommand.Parameters.AddWithValue("@OriginName", originName);
                                insertCommand.Parameters.AddWithValue("@DestinationName", destinationName);

                                reader.Close();

                                int rowsAffected = insertCommand.ExecuteNonQuery();

                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show("Job successfully sent!");
                                }
                                else
                                {
                                    MessageBox.Show("Failed to send job!");
                                }
                            }
                            else
                            {
                                MessageBox.Show("No data found in job description.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("No job found for this Id.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Enter valid job and user IDs.");
            }
        }


        private void labelBack_Click(object sender, EventArgs e)
        {
            TasksManagement tasks = new TasksManagement();
            tasks.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private List<string> GetDestinationsForUser(int userId)
{
            string connectionString = "Server=localhost\\SQLEXPRESS;Database=TruckManagementApp;Trusted_Connection=True;";
            string selectQuery = "SELECT destination_name FROM ASSIGNED_JOBS WHERE user_id = @UserId";

            List<string> destinations = new List<string>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand selectCommand = new SqlCommand(selectQuery, connection);
                selectCommand.Parameters.AddWithValue("@UserId", userId);

                try
                {
                    connection.Open();
                    SqlDataReader reader = selectCommand.ExecuteReader();

                    while (reader.Read())
                    {
                        string destination = reader["destination_name"].ToString();
                        destinations.Add(destination);
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Eroare: " + ex.Message);
                }
            }

            return destinations;
        }

    }
}
