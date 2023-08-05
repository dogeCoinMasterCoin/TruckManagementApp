using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace TruckManagementApp
{
    public partial class Maps : Form
    {
        public string userInputOrigin;
        public string userInputDestination;

        public Maps()
        {
            InitializeComponent();
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            
        }

        private void webBrowser1_Load(object sender, EventArgs e)
        {
            
        }

        private void Maps_Load(object sender, EventArgs e)
        {
            webBrowser1.ScriptErrorsSuppressed = true;
            webBrowser1.Navigate("https://www.bing.com/maps", null, null, "User-Agent: Mozilla/5.0 (Windows NT 10.0; Win64; x64; rv:80.0) Gecko/20100101 Firefox/80.0");
        }


        private void originAddresTxt_TextChanged(object sender, EventArgs e)
        {

        }

        //private async void button1_Click(object sender, EventArgs e)
        //{
        //    string origin = originAddresTxt.Text;
        //    string destination = destinationAddressTxt.Text;

        //    try
        //    {
        //        double distance = await BingMapsDistanceCalculator.GetDistance(origin, destination);
        //        MessageBox.Show($"Distanța dintre {origin} și {destination} este de aproximativ {distance} km.");
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show($"A apărut o eroare: {ex.Message}");
        //    }
        //}

        //private void distanceLbl_Click(object sender, EventArgs e)
        //{

        //}
    }

    //public class BingMapsDistanceCalculator
    //{
    //    private const string BingMapsApiKey = "AncfoCukBkezgjsGnlTW08z9wh8TPTJnFUCbFDNe0JPhayvw6Xsn_CUGis_EJ8H_";

    //    public static async Task<double> GetDistance(string origin, string destination)
    //    {
    //        string url = $"https://dev.virtualearth.net/REST/v1/Routes/DistanceMatrix?origins={origin}&destinations={destination}&travelMode=driving&key={BingMapsApiKey}";

    //        using (HttpClient client = new HttpClient())
    //        {
    //            HttpResponseMessage response = await client.GetAsync(url);
    //            if (response.IsSuccessStatusCode)
    //            {
    //                string json = await response.Content.ReadAsStringAsync();
    //                dynamic data = Newtonsoft.Json.JsonConvert.DeserializeObject(json);
    //                double distance = (double)data.resourceSets[0].resources[0].results[0].travelDistance;
    //                return distance;
    //            }
    //            else
    //            {
    //                throw new Exception($"Request failed with status code {response.StatusCode}");
    //            }
    //        }
    //    }
    //}
}
