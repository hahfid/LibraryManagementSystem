using System;
using System.Windows.Forms;
using LibraryManagementSystem.Models;

namespace LibraryManagementSystem
{
    public partial class Dashboard : UserControl
    {
        private DashboardQuery query = new DashboardQuery();

        public Dashboard()
        {
            InitializeComponent();
            displayAB();
            displayIB();
            displayRB();
        }

        public void refreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)refreshData);
                return;
            }

            displayAB();
            displayIB();
            displayRB();
        }

        public void displayAB()
        {
            try
            {
            //    int totalAvailableBooks = query.CountAvailableBooks();
                dashboard_AB.Text = query.CountAvailableBooks().ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void displayIB()
        {
            try
            {
                int totalIssuedBooks = query.CountIssuedBooks();
                dashboard_IB.Text = totalIssuedBooks.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void displayRB()
        {
            try
            {
                int totalReturnedBooks = query.CountReturnedBooks();
                dashboard_RB.Text = totalReturnedBooks.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }
    }
}
