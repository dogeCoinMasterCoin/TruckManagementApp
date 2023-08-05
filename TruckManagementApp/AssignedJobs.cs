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
    public partial class AssignedJobs : Form
    {
        public AssignedJobs()
        {
            InitializeComponent();
        }

        private void AssignedJobs_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'truckManagementAppDataSet8.ASSIGNED_JOBS' table. You can move, or remove it, as needed.
            this.aSSIGNED_JOBSTableAdapter2.Fill(this.truckManagementAppDataSet8.ASSIGNED_JOBS);



        }

        private void label1_Click(object sender, EventArgs e)
        {
            MainPage main = new MainPage();
            main.Show();
            this.Hide();
        }

        private void downloadBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0]; 
                //int userId = selectedRow.Cells["useridDataGridViewTextBoxColumn"].Value;
                //int jobId = selectedRow.Cells["dataGridViewTextBoxColumn1"].Value;

                byte[] fileData = (byte[])selectedRow.Cells["dataGridViewImageColumn1"].Value;

                if (fileData != null)
                {
                    SaveFileDialog saveFileDialog = new SaveFileDialog();
                    saveFileDialog.Filter = "Fișiere imagine (*.jpg, *.jpeg, *.png)|*.jpg;*.jpeg;*.png";

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string filePath = saveFileDialog.FileName;
                        File.WriteAllBytes(filePath, fileData);
                        MessageBox.Show("Download successfully!");
                    }
                }
                else
                {
                    MessageBox.Show("No data available");
                }
            }
            else
            {
                MessageBox.Show("Select an image.");
            }
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void LoadDataIntoDataGridView()
        {
            string connectionString = "Server=localhost\\SQLEXPRESS;Database=TruckManagementApp;Trusted_Connection=True;";
            string selectQuery = "SELECT * FROM ASSIGNED_JOBS";

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

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
