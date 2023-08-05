using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TruckManagementApp
{
    public partial class TrackJobs : Form
    {
        public TrackJobs()
        {
            InitializeComponent();
        }

        private void TrackJobs_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'truckManagementAppDataSet6.Task_Status' table. You can move, or remove it, as needed.
            this.task_StatusTableAdapter1.Fill(this.truckManagementAppDataSet6.Task_Status);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
