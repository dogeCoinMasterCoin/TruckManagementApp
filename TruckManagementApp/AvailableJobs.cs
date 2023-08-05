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
    public partial class AvailableJobs : Form
    {

        public AvailableJobs()
        {
            InitializeComponent();
        }

        private void browseBtn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Fișiere imagine (*.jpg, *.jpeg, *.png)|*.jpg;*.jpeg;*.png|Fișiere PDF (*.pdf)|*.pdf";
                openFileDialog.Multiselect = false;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;

                    byte[] fileData = File.ReadAllBytes(filePath);
                    string originName = originTxt.Text;
                    string destinationName = destinationTxt.Text;
                    string startTime = startTimeTxt.Text;
                    string finishTime = finishTimeTxt.Text;
                    string jobName = jobNameTxt.Text;

                    string connectionString = "Server=localhost\\SQLEXPRESS;Database=TruckManagementApp;Trusted_Connection=True;";
                    string query = "INSERT INTO JOBS (job_id, job_name, job_description, origin_name, destination_name, start_time, finish_time) " +
                                   "VALUES (NEXT VALUE FOR SEQ_JOB_ID,@JobName, @FileData, @OriginName, @DestinationName, @StartTime, @FinishTime)";

                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@JobName", jobName);
                        command.Parameters.AddWithValue("@FileData", fileData);
                        command.Parameters.AddWithValue("@OriginName", originName);
                        command.Parameters.AddWithValue("@DestinationName", destinationName);
                        command.Parameters.AddWithValue("@StartTime", startTime);
                        command.Parameters.AddWithValue("FinishTime", finishTime);

                        connection.Open();
                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("Upload successfully!");
                }
            }
        }


        private void AvailableJobs_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'truckManagementAppDataSet1.JOBS' table. You can move, or remove it, as needed.
            //this.jOBSTableAdapter.Fill(this.truckManagementAppDataSet1.JOBS);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {
            MainPage mainPage = new MainPage();
            mainPage.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
