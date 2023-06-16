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
            // Configurează serverul Self-Hosted SignalR
            string url = "http://localhost:8080";
            using (WebApp.Start<Startup>(url))
            {
                Console.WriteLine("Serverul SignalR rulează la adresa: " + url);
                Console.ReadLine();
            }

            //Application.Run(new LoginFile());
            Application.Run(new TasksManagement());

            //Database connection
            string connectionString = "Server=localhost\\SQLEXPRESS;Database=TruckManagementApp;Trusted_Connection=True;";
            connection = new SqlConnection(connectionString);
            connection.Open();
        }
    }

        public class Startup
        {
            public void Configuration(IAppBuilder app)
            {
                // Permite accesul Cross-Origin (CORS)
                app.UseCors(CorsOptions.AllowAll);

                // Configurare rutare și setare a hub-ului SignalR
                app.MapSignalR();
            }
        }
}
