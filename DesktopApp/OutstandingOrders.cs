using Newtonsoft.Json;
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
using System.Windows.Forms;

namespace DesktopApp
{
    public partial class OutstandingOrders : Form
    {
        public OutstandingOrders()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            //String URI = "URL";
            //String result = String.Empty;

            //HttpWebRequest request = (HttpWebRequest)WebRequest.Create(URI);
            //request.AutomaticDecompression = DecompressionMethods.GZip;

            //using (HttpWebResponse response = (HttpWebRequest)request.GetResponse);

            //HttpClient client = new HttpClient();

            using (var client = new HttpClient(new HttpClientHandler { AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate }))
            {
                client.BaseAddress = new Uri("http://0.0.0.0");
                HttpResponseMessage response = client.GetAsync("orders").Result;
                response.EnsureSuccessStatusCode();
                string result = response.Content.ReadAsStringAsync().Result;
            }
            //HttpClientReponseMessage response = await client.GetAsync("server url");
            //response.EnsureSuccessStatusCode();
            //string responseBody = await response.Content.ReadAsStringAsync();

            //lstVNewOrders.Items.Add(new ListViewItem(new string[] {"1", "2", "3", "4", "5", "6" }));
        }

        private void OutstandingOrders_Load(object sender, EventArgs e)
        {
            using (var client = new HttpClient(new HttpClientHandler { AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate }))
            {
                client.BaseAddress = new Uri("http://0.0.0.0");
                HttpResponseMessage response = client.GetAsync("orders").Result;
                response.EnsureSuccessStatusCode();
                string result = response.Content.ReadAsStringAsync().Result;
            }
        }
    }
}
