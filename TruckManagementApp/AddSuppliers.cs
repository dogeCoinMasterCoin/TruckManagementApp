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
    public partial class AddSuppliers : Form
    {
        public AddSuppliers()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Supplier suppliers = new Supplier();
            suppliers.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string supplierName = txtsuppliername.Text;
            string contractStart = txtContractStart.Text;
            string contractEnd = txtContractEnd.Text;
            string productType = txtProductType.Text;

            string connectionString = "Server=localhost\\SQLEXPRESS01;Database=TruckManagementApp;Trusted_Connection=True;";
            string insertQuery = "INSERT INTO Suppliers (supplier_id, supplier_name, contract_start_date, contract_expiration_date, produs_type)  VALUES (NEXT VALUE FOR SEQ_SUPPLIER_ID, @SupplierName, @ContractStart, @ContractEnd, @ProductType);";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand insertCommand = new SqlCommand(insertQuery, connection);

                insertCommand.Parameters.AddWithValue("@SupplierName", supplierName);
                insertCommand.Parameters.AddWithValue("@ContractStart", contractStart);
                insertCommand.Parameters.AddWithValue("@ContractEnd", contractEnd);
                insertCommand.Parameters.AddWithValue("@ProductType", productType);


                try
                {
                    connection.Open();
                    int rowsAffected = insertCommand.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("The supplier was added succesfully.");
                    }
                    else
                    {
                        MessageBox.Show("Error while trying to add the supplier.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
    }
}
