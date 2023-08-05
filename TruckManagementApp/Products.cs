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
    public partial class Products : Form
    {
        public Products()
        {
            InitializeComponent();
        }

        private void Products_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'truckManagementAppDataSet7.PRODUCTS' table. You can move, or remove it, as needed.
            this.pRODUCTSTableAdapter.Fill(this.truckManagementAppDataSet7.PRODUCTS);
            LoadDataIntoDataGridView();


        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            AddProducts addProducts = new AddProducts();
            addProducts.Show();
            this.Hide();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                int selectedRowIndex = dataGridView.SelectedRows[0].Index;
                string productId = dataGridView.Rows[selectedRowIndex].Cells[0].Value.ToString();


                string connectionString = "Server=localhost\\SQLEXPRESS;Database=TruckManagementApp;Trusted_Connection=True;";
                string deleteQuery = "DELETE FROM Products WHERE product_id = " + productId;

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand deleteCommand = new SqlCommand(deleteQuery, connection);
                    deleteCommand.Parameters.AddWithValue("@ProductId", productId);

                    try
                    {
                        connection.Open();
                        int rowsAffected = deleteCommand.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            // Ștergerea a fost realizată cu succes
                            dataGridView.Rows.RemoveAt(selectedRowIndex);
                            MessageBox.Show("Register deleted from database.");
                        }
                        else
                        {
                            MessageBox.Show("Error deleting this file.");
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
                MessageBox.Show("No register selected.");
            }
        }

        private void editBtn_Click(object sender, EventArgs e)
        {

            if (dataGridView.SelectedRows.Count > 0)
            {
                int selectedProductId = Convert.ToInt32(dataGridView.SelectedRows[0].Cells[0].Value.ToString());

                EditProduct editForm = new EditProduct(selectedProductId);
                editForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Select a product to delete it.");
            }
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void LoadDataIntoDataGridView()
        {
            string connectionString = "Server=localhost\\SQLEXPRESS;Database=TruckManagementApp;Trusted_Connection=True;";
            string selectQuery = "SELECT * FROM PRODUCTS";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(selectQuery, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();

                try
                {
                    connection.Open();
                    adapter.Fill(dataTable);

                    dataGridView.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            MainPage mainePage = new MainPage();
            mainePage.Show();
            this.Hide();
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
