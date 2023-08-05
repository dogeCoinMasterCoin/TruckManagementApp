using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TruckManagementApp
{
    public partial class MainPage : Form
    {

        string connectionString = "Server=localhost\\SQLEXPRESS;Database=TruckManagementApp;Trusted_Connection=True;";

        int currentUserId = ((LoginFile)Application.OpenForms["LoginFile"]).LoggedUserId;

        string currentUserName;

        public MainPage()
        {
            string queryGetUserName = "SELECT user_name FROM USERS WHERE user_id = " + currentUserId;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(queryGetUserName, connection))
                {
                    command.Parameters.Add("@userId", SqlDbType.Int).Value = currentUserId;

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {

                            currentUserName = reader.GetString(0);
                        }
                        
                    }
                }
            }

            InitializeComponent();

            if(currentUserName != "admin")
            {
                button1.Hide();
                productsBtn.Hide();
                button3.Hide();
                vehiclesBtn.Hide();
                suppliersBtn.Hide();
                trackJobsBtn.Hide();

                jobStatusBtn.Show();
            }
            else
            {
                jobStatusBtn.Hide();
            }
        }
        

        public void ShowAdminInterface()
        {
            // Afișează butoanele pentru administrator
            btnChatAdmin.Visible = true;
        }

        public void ShowUserInterface()
        {
            // Ascunde butoanele pentru administrator
            btnChatAdmin.Visible = false;
        }

        private void btnChatAdmin_Click(object sender, EventArgs e)
        {
            Chat chat = new Chat();  
            chat.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TasksManagement tasksManagement = new TasksManagement();
            tasksManagement.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            AvailableJobs jobs = new AvailableJobs();
            jobs.Show();
            this.Hide();
        }

        private void assignedJobsBtn_Click(object sender, EventArgs e)
        {
            AssignedJobs jobs = new AssignedJobs(); 
            jobs.Show();
            this.Hide();
        }

        private void productsBtn_Click(object sender, EventArgs e)
        {
            Products products = new Products();
            products.Show();
            this.Hide();
        }

        private void vehiclesBtn_Click(object sender, EventArgs e)
        {
            Vehicles vehicles = new Vehicles();
            vehicles.Show();
            this.Hide();
        }

        private void jobStatusBtn_Click(object sender, EventArgs e)
        {
            JobStatus status = new JobStatus();
            status.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void suppliersBtn_Click(object sender, EventArgs e)
        {
            Supplier suppliers = new Supplier();
            suppliers.Show();
            this.Hide();
        }

        private void trackJobsBtn_Click(object sender, EventArgs e)
        {
            TrackJobs jobs = new TrackJobs();
            jobs.Show();
        }
    }
}
