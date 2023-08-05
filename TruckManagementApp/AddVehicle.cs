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
    public partial class AddVehicle : Form
    {
        public AddVehicle()
        {
            InitializeComponent();
        }

        private void backLbl_Click(object sender, EventArgs e)
        {
            Vehicles vehicles = new Vehicles();
            vehicles.Show();
            this.Hide();
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            // string vehicleId = vehicleTxt.Text;
            int userId = Convert.ToInt32(userTxt.Text);
            string firstName = firstNameTxt.Text;
            string lastName = lastNameTxt.Text;
            string registrationNumber = registrationNumberTxt.Text;
            string vehicleModel = vehicleTxt.Text;

            string connectionString = "Server=localhost\\SQLEXPRESS;Database=TruckManagementApp;Trusted_Connection=True;";
            string insertQuery = "INSERT INTO Vehicles (vehicles_id, user_id, first_name, last_name, numar_de_inmatriculare, model_masina) VALUES (NEXT VALUE FOR SEQ_PRODUCTS, @UserId, @FirstName, @LastName, @NumarDeInregistrare, @ModelMasina)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand insertCommand = new SqlCommand(insertQuery, connection);

                insertCommand.Parameters.AddWithValue("@UserId", userId);
                insertCommand.Parameters.AddWithValue("@FirstName", firstName);
                insertCommand.Parameters.AddWithValue("@LastName", lastName);
                insertCommand.Parameters.AddWithValue("@NumarDeInregistrare", registrationNumber);
                insertCommand.Parameters.AddWithValue("@ModelMasina", vehicleModel);

                try
                {
                    connection.Open();
                    int rowsAffected = insertCommand.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Data successfully addded!");
                    }
                    else
                    {
                        MessageBox.Show("Error uploading data into database.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Eroare: " + ex.Message);
                }
            }
        }

    }
}
