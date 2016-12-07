using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopApp
{
    public partial class ReportsMenu : Form
    {
        public ReportsMenu()
        {
            InitializeComponent();
        }

        private void btnCompletedOrders_Click(object sender, EventArgs e)
        {
            CompletedOrders completed = new CompletedOrders();
            completed.Show();
        }

        private void btnListAppUsers_Click(object sender, EventArgs e)
        {
            RegisteredAppUsers registeredUsers = new RegisteredAppUsers();
            registeredUsers.Show();
        }

        private void btnListDrivers_Click(object sender, EventArgs e)
        {
            RegisteredDrivers registeredDrivers = new RegisteredDrivers();
            registeredDrivers.Show();
        }

        private void btnComments_Click(object sender, EventArgs e)
        {
            ReviewsAndComplaints reviews = new ReviewsAndComplaints();
            reviews.Show();
        }

        private void btnCloseReportsMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
