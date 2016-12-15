using System;
using System.Windows.Forms;

namespace DesktopApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOutstandingOrders_Click(object sender, EventArgs e)
        {
            OutstandingOrders newOrders = new OutstandingOrders();
            newOrders.Show();
        }

        private void btnSpecials_Click(object sender, EventArgs e)
        {
            DailySpecials specials = new DailySpecials();
            specials.Show();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            ReportsMenu reportsMenu = new ReportsMenu();
            reportsMenu.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
