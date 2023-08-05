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
    public partial class EditProduct : Form
    {

        private int selectedProductId;
        public EditProduct(int selectedProductId)
        {
            InitializeComponent();
            this.selectedProductId = selectedProductId;
        }

        private void EditProduct_Load(object sender, EventArgs e)
        {

        }


        private void submitBtn_Click(object sender, EventArgs e)
        {
            string newProductName = newProductNameTxt.Text;
            string newProductCost = newProductCostTxt.Text;
            string newProductSupplier = newProductSupplierTxt.Text;

            // Verificați dacă a fost furnizat un id valid pentru produsul selectat
            if (selectedProductId > 0)
            {
                // Conectați-vă la baza de date și executați actualizarea
                string connectionString = "Server=localhost\\SQLEXPRESS;Database=TruckManagementApp;Trusted_Connection=True;";
                string updateQuery = "UPDATE PRODUCTS SET product_name = @ProductName, product_cost = @ProductCost, product_suplier = @ProductSupplier WHERE product_id = @ProductId";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand updateCommand = new SqlCommand(updateQuery, connection);
                    updateCommand.Parameters.AddWithValue("@ProductName", newProductName);
                    updateCommand.Parameters.AddWithValue("@ProductCost", newProductCost);
                    updateCommand.Parameters.AddWithValue("@ProductSupplier", newProductSupplier);
                    updateCommand.Parameters.AddWithValue("@ProductId", selectedProductId);

                    try
                    {
                        connection.Open();
                        int rowsAffected = updateCommand.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Product data edited successfully!");
                        }
                        else
                        {
                            MessageBox.Show("No changes was made.");
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
                MessageBox.Show("No product was selected.");
            }
        }

        private void newProductCostTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
