using Newtonsoft.Json;
using System;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopApp
{
    public partial class DailySpecials : Form
    {
        public DailySpecials()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            String name, price, day;
            name = txtItemName.Text;
            price = txtItemPrice.Text;
            day = cmbDaysOfTheWeek.SelectedText;

            postSpecial(name, price, day);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtItemName.Text = "";
            txtItemPrice.Text = "";
            cmbDaysOfTheWeek.SelectedIndex = 0;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /*Function to POST JSON to server */
        public async void postSpecial(String itemName, String itemPrice, String dayOfSpecial)
        {
            main.domain.specials.DailySpecial special = new main.domain.specials.DailySpecial();
            special.Name = itemName;
            special.Price = itemPrice;
            special.DayOfSpecial = dayOfSpecial;
            var jsonContent = await Task.Run(() => JsonConvert.SerializeObject(special));
            var httpContent = new StringContent(jsonContent,Encoding.UTF8,"application/json");
            using (var httpClient = new HttpClient())
            {
                var httpResponse = await httpClient.PostAsync("URL here", httpContent);

                if(httpResponse.IsSuccessStatusCode)
                {
                    MessageBox.Show("Special posted sucessfully");
                }
                else
                {
                    MessageBox.Show("Error connecting to database");
                }
            }

        }
    }

}
