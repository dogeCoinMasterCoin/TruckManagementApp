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
    public partial class AddProducts : Form
    {
        public AddProducts()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Products products = new Products();
            products.Show();
            this.Hide();
        }

        //Submit button
        private void button1_Click(object sender, EventArgs e)
        {
            string productName = productNameTxt.Text;
            string productCost = productCostTxt.Text;
            string productSupplier = productSupplierTxt.Text;

            string connectionString = "Server=localhost\\SQLEXPRESS;Database=TruckManagementApp;Trusted_Connection=True;";
            string insertQuery = "INSERT INTO Products (product_id, product_name, product_cost, product_suplier) VALUES (NEXT VALUE FOR SEQ_PRODUCTS, @ProductName, @ProductCost, @ProductSupplier)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand insertCommand = new SqlCommand(insertQuery, connection);

                insertCommand.Parameters.AddWithValue("@ProductName", productName);
                insertCommand.Parameters.AddWithValue("@ProductCost", productCost);
                insertCommand.Parameters.AddWithValue("@ProductSupplier", productSupplier);

                try
                {
                    connection.Open();
                    int rowsAffected = insertCommand.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Data successfully deleted!");
                    }
                    else
                    {
                        MessageBox.Show("Error deleting data.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Eroare: " + ex.Message);
                }
            }
        }

        private void AddProducts_Load(object sender, EventArgs e)
        {

        }
    }
}
