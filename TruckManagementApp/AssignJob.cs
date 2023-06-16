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

        public AssignJob(int selectedUserId)
        {
            InitializeComponent();
            this.selectedUserId = selectedUserId;
        }

        private void AssignJob_Load(object sender, EventArgs e)
        {
            this.jOBSTableAdapter.Fill(this.truckManagementAppDataSet1.JOBS);

        }

        //TBD for the moment you can download the file from that specific line, is in need to be sent to that user.
        private void sendJobBtn_Click(object sender, EventArgs e)
        {
            int jobId;

            if (int.TryParse(jobIdTxt.Text, out jobId))
            {
                string connectionString = "Server=localhost\\SQLEXPRESS;Database=TruckManagementApp;Trusted_Connection=True;";
                string query = "SELECT job_description FROM JOBS WHERE job_id = @JobId";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@JobId", jobId);

                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.Read())
                        {
                            if (!reader.IsDBNull(reader.GetOrdinal("job_description")))
                            {
                                byte[] fileData = (byte[])reader["job_description"];

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
                                MessageBox.Show("No data found in job description.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("No job found for this Id.");
                        }

                        reader.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Enter valid data number for job.");
            }
        }
    }
}
