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
using System.Web.Script.Serialization;
using System.Web.UI;

namespace DesktopApp
{
    public partial class RegisteredAppUsers : Form
    {
        public RegisteredAppUsers()
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
                HttpResponseMessage response = client.GetAsync("users").Result;
                response.EnsureSuccessStatusCode();
                string result = response.Content.ReadAsStringAsync().Result;
            }*/

            var client = "http://192.168.10.107:8000/api/user";

            WebRequest wrGETURL;
            wrGETURL = WebRequest.Create(client);

            Stream objStream;
            objStream = wrGETURL.GetResponse().GetResponseStream();

            StreamReader objReader = new StreamReader(objStream);

            string sLine = "";
            int i = 0;

            JavaScriptSerializer js = new JavaScriptSerializer();
            Person[] persons = js.Deserialize<Person[]>(json);

            while (sLine != null)
            {
                i++;
                sLine = objReader.ReadLine();
                if (sLine != null)
                    Console.WriteLine("{0}:{1}", i, sLine);
                lstVRegisteredAppUsers.Items.Add(new ListViewItem(sLine));
            }
            Console.ReadLine();

           /* String result = String.Empty;

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(URI);
            request.AutomaticDecompression = DecompressionMethods.GZip;

            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            {
                result = reader.ReadToEnd();
            }

            //For debugging
            Console.WriteLine(result);*/
        }

        private void RegisteredAppUsers_Load(object sender, EventArgs e)
        {
            /*using (var client = new HttpClient(new HttpClientHandler { AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate }))
            {
                client.BaseAddress = new Uri("http://0.0.0.0");
                HttpResponseMessage response = client.GetAsync("users").Result;
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
