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
    public partial class Supplier : Form
    {
        public Supplier()
        {
            InitializeComponent();
        }

        private void Supplier_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'truckManagementAppDataSet1.Suppliers' table. You can move, or remove it, as needed.
            this.suppliersTableAdapter.Fill(this.truckManagementAppDataSet1.Suppliers);


        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            AddSupplier addSupplier = new AddSupplier();
            addSupplier.Show();
            this.Hide();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                int selectedRowIndex = dataGridView.SelectedRows[0].Index;
                string supplierId = dataGridView.Rows[selectedRowIndex].Cells[0].Value.ToString();


                string connectionString = "Server=localhost\\SQLEXPRESS;Database=TruckManagementApp;Trusted_Connection=True;";
                string deleteQuery = "DELETE FROM SUPPLIERS WHERE supplier_id = " + supplierId;

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand deleteCommand = new SqlCommand(deleteQuery, connection);
                    deleteCommand.Parameters.AddWithValue("@supplierid", supplierId);

                    try
                    {
                        connection.Open();
                        int rowsAffected = deleteCommand.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            // Ștergerea a fost realizată cu succes
                            dataGridView.Rows.RemoveAt(selectedRowIndex);
                            MessageBox.Show("The supplier was succesfully deleted.");
                        }
                        else
                        {
                            MessageBox.Show("Error while deleting the supplier.");
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
                MessageBox.Show("No register selected for delete.");
            }
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                int selectedSupplierId = Convert.ToInt32(dataGridView.SelectedRows[0].Cells[0].Value.ToString());

                EditSuppliers editSuppliers = new EditSuppliers(selectedSupplierId);
                editSuppliers.ShowDialog();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please select a supplier to edit.");
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            MainPage mainPage = new MainPage();
            mainPage.Show();
            this.Hide();
        }
    }
}
