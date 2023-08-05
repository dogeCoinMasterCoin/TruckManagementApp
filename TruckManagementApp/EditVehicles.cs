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
    public partial class EditVehicles : Form
    {
        private int selectedVehicleId;
        public EditVehicles(int selectedVehicleId)
        {
            InitializeComponent();
            this.selectedVehicleId = selectedVehicleId;
        }

        private void EditVehicles_Load(object sender, EventArgs e)
        {

        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            int newUserId = Convert.ToInt32(userIdTxt.Text);
            string newFirstName = firstNameTxt.Text;
            string newLastName = lastNameTxt.Text;
            string newRegistrationNumber = registrationNumberTxt.Text;
            string newVehicleModel = vehicleModelTxt.Text;

            if (selectedVehicleId > 0)
            {
                // Conectați-vă la baza de date și executați actualizarea
                string connectionString = "Server=localhost\\SQLEXPRESS;Database=TruckManagementApp;Trusted_Connection=True;";
                string updateQuery = "UPDATE Vehicles SET user_id = @UserId, first_name = @FirstName, last_name = @LastName, numar_de_inmatriculare = @NumarDeInmatriculare, model_masina = @ModelMasina WHERE vehicles_id = " + selectedVehicleId;

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand updateCommand = new SqlCommand(updateQuery, connection);
                    updateCommand.Parameters.AddWithValue("@UserId", newUserId);
                    updateCommand.Parameters.AddWithValue("@FirstName", newFirstName);
                    updateCommand.Parameters.AddWithValue("@LastName", newLastName);
                    updateCommand.Parameters.AddWithValue("@NumarDeInmatriculare", newRegistrationNumber);
                    updateCommand.Parameters.AddWithValue("@ModelMasina", newVehicleModel);
                    updateCommand.Parameters.AddWithValue("@ProductId", selectedVehicleId);

                    try
                    {
                        connection.Open();
                        int rowsAffected = updateCommand.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Data successfully updated!");
                        }
                        else
                        {
                            MessageBox.Show("No changed for this product.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error shows up: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Nu s-a selectat niciun produs pentru actualizare.");
            }
        }
    }
}
