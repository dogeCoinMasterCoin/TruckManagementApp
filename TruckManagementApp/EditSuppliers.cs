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
    public partial class EditSuppliers : Form
    {

        private int selectedSupplierId;
        public EditSuppliers(int selectedSupplierId)
        {
            InitializeComponent();
            this.selectedSupplierId = selectedSupplierId;
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Supplier suppliers = new Supplier();
            suppliers.Show();
            this.Hide();
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            string supplierName = txtsuppliername.Text;
            string contractStart = txtContractStart.Text;
            string contractEnd = txtContractEnd.Text;
            string productType = txtProductType.Text;


            if (selectedSupplierId > 0)
            {

                string connectionString = "Server=localhost\\SQLEXPRESS;Database=TruckManagementApp;Trusted_Connection=True;";
                string updateQuery = "UPDATE SUPPLIERS SET supplier_name = @SupplierName, contract_start_date = @ContractStart, contract_expiration_date = @ContractEnd, produs_type = @ProductType WHERE supplier_id = @SupplierId";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand updateCommand = new SqlCommand(updateQuery, connection);

                    updateCommand.Parameters.AddWithValue("@SupplierName", supplierName);
                    updateCommand.Parameters.AddWithValue("@ContractStart", contractStart);
                    updateCommand.Parameters.AddWithValue("@ContractEnd", contractEnd);
                    updateCommand.Parameters.AddWithValue("@ProductType", productType);
                    updateCommand.Parameters.AddWithValue("@SupplierId", selectedSupplierId);


                    try
                    {
                        connection.Open();
                        int rowsAffected = updateCommand.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("The supplier data was succesfully updated!");
                        }
                        else
                        {
                            MessageBox.Show("No fields were updated.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occured while trying to update: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("No supplier was selected.");
            }
        }
    }
}
