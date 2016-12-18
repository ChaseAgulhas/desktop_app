using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopApp
{
    public partial class CompletedOrders : Form
    {
        public CompletedOrders()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            GetAllOrders();
        }

        public async void GetAllOrders()
        {
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

        private void CompletedOrders_Load(object sender, EventArgs e)
        {
            GetAllOrders();
        }
    }
}
