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
    public partial class Vehicles : Form
    {
        public Vehicles()
        {
            InitializeComponent();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            MainPage mainPage = new MainPage();
            this.Hide();
            mainPage.Show();    
        }

        private void LoadDataIntoDataGridView()
        {
            string connectionString = "Server=localhost\\SQLEXPRESS;Database=TruckManagementApp;Trusted_Connection=True;";
            string selectQuery = "SELECT * FROM Vehicles";

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

        private void Vehicles_Load(object sender, EventArgs e)
        {
           
            LoadDataIntoDataGridView();

        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            AddVehicle addVehicle = new AddVehicle();
            addVehicle.Show();
            this.Hide();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int selectedRowIndex = dataGridView1.SelectedRows[0].Index;
                string vehiclesId = dataGridView1.Rows[selectedRowIndex].Cells[0].Value.ToString();


                string connectionString = "Server=localhost\\SQLEXPRESS;Database=TruckManagementApp;Trusted_Connection=True;";
                string deleteQuery = "DELETE FROM Vehicles WHERE vehicles_id = " + vehiclesId;

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand deleteCommand = new SqlCommand(deleteQuery, connection);
                    deleteCommand.Parameters.AddWithValue("@ProductId", vehiclesId);

                    try
                    {
                        connection.Open();
                        int rowsAffected = deleteCommand.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            // Ștergerea a fost realizată cu succes
                            dataGridView1.Rows.RemoveAt(selectedRowIndex);
                            MessageBox.Show("Data successfully deleted!");
                        }
                        else
                        {
                            MessageBox.Show("Error deleting data from database.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Eroare: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("No registration selected.");
            }
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int selectedVehicleId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());

                EditVehicles editForm = new EditVehicles(selectedVehicleId);
                editForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Select product first");
            }
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            LoadDataIntoDataGridView();
        }
    }
}
