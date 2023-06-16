using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TruckManagementApp
{
    public partial class MainPage : Form
    {

        string connectionString = "Server=localhost\\SQLEXPRESS;Database=TruckManagementApp;Trusted_Connection=True;";

        public MainPage()
        {
            InitializeComponent();
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
            ChatAdmin chatAdmin = new ChatAdmin();  
            chatAdmin.Show();
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
            JobsHistory history = new JobsHistory();
            history.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AvailableJobs jobs = new AvailableJobs();
            jobs.Show();
            this.Hide();
        }
    }
}
