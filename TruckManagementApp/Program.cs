using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.AspNet.SignalR;
using Microsoft.Owin.Cors;
using Owin;
using Microsoft.Owin.Hosting;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TruckManagementApp
{
    internal static class Program
    {
        static SqlConnection connection; //Connection variable


        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginFile());
            //Application.Run(new TasksManagement());

            //Database connection
            string connectionString = "Server=localhost\\SQLEXPRESS01;Database=TruckManagementApp;Trusted_Connection=True;";
            connection = new SqlConnection(connectionString);
            connection.Open();
        }
    }
}