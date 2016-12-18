using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Http;
using System.IO;

namespace DesktopApp
{
    public partial class RegisteredDrivers : Form
    {
        public RegisteredDrivers()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            /*using (var client = new HttpClient(new HttpClientHandler { AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate }))
            {
                client.BaseAddress = new Uri("http://0.0.0.0");
                HttpResponseMessage response = client.GetAsync("drivers").Result;
                response.EnsureSuccessStatusCode();
                string result = response.Content.ReadAsStringAsync().Result;
            }*/

            String URI = "http://127.0.0.1";
            String result = String.Empty;

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(URI);
            request.AutomaticDecompression = DecompressionMethods.GZip;

            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            {
                result = reader.ReadToEnd();
            }

            //For debugging
            Console.WriteLine(result);
        }

        private void RegisteredDrivers_Load(object sender, EventArgs e)
        {
            /*using (var client = new HttpClient(new HttpClientHandler { AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate }))
            {
                client.BaseAddress = new Uri("http://0.0.0.0");
                HttpResponseMessage response = client.GetAsync("drivers").Result;
                response.EnsureSuccessStatusCode();
                string result = response.Content.ReadAsStringAsync().Result;
            }*/

            String URI = "http://127.0.0.1";
            String result = String.Empty;

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(URI);
            request.AutomaticDecompression = DecompressionMethods.GZip;

            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            {
                result = reader.ReadToEnd();
            }

            //For debugging
            Console.WriteLine(result);
        }
    }
}
