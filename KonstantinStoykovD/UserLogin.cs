using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace VolleyballRecruitmentApp
{
    public partial class UserLogin : Form
    {
        private string mysqlcon;
        private string username;

        // Constructor to initialize the form and database connection
        public UserLogin(string loggedInUsername)
        {
            InitializeComponent();  // Initializes all components from the designer, including panel1
            mysqlcon = "server=localhost;database=volleyballrecruitmentagency;user=root;password=;port=3307";
            username = loggedInUsername;

            // Bind button click events
            btnDashboard.Click += btnDashboard_Click;
            btnNotifications.Click += BtnNotifications_Click;
            btnTransfer.Click += btnTransfer_Click;
            btnPlayers.Click += BtnPlayers_Click;

            // Show the dashboard by default
            ShowDashboard();
        }

        // Default constructor for designer use (if necessary)
        public UserLogin() => InitializeComponent();

        // Show the dashboard when the dashboard button is clicked
        private void btnDashboard_Click(object? sender, EventArgs e)
        {
            // Show panel1 and hide panel2
            panel1.Visible = true;
            panel2.Visible = false;

            ShowDashboard();
            menuChange(btnDashboard);
        }


        // Placeholder for the Notifications button action
        private void BtnNotifications_Click(object? sender, EventArgs e)
        {
            MessageBox.Show("Notifications section is under construction.");
            menuChange(btnNotifications);
        }

        // Show the transfer section when the transfer button is clicked
        private void btnTransfer_Click(object? sender, EventArgs e)
        {
            // Hide panel1 and show panel2
            panel1.Visible = false;
            panel2.Visible = true;

            // Clear any existing controls in panel2
            panel2.Controls.Clear();

            // Check if TransferDashboard_UserControl instance is already in panel2
            if (!panel2.Controls.Contains(TransferDashboard_UserControl.Instance))
            {
                // Dock the control to fill the panel
                TransferDashboard_UserControl.Instance.Dock = DockStyle.Fill;

                // Add TransferDashboard_UserControl to panel2
                panel2.Controls.Add(TransferDashboard_UserControl.Instance);
            }

            // Bring TransferDashboard_UserControl instance to the front and focus
            TransferDashboard_UserControl.Instance.BringToFront();
            TransferDashboard_UserControl.Instance.Focus();

            // Optional: Update button appearance for navigation
            menuChange(btnTransfer);
        }


        // Placeholder for the Players button action
        private void BtnPlayers_Click(object? sender, EventArgs e)
        {
            MessageBox.Show("Players section is under construction.");
            menuChange(btnPlayers);
        }

        // Method to show the dashboard
        private void ShowDashboard()
        {
            panel1.Controls.Clear();  // Clear previous content

            if (!panel1.Controls.Contains(Dashboard_UserControl.Instance))
            {
                Dashboard_UserControl.Instance.Dock = DockStyle.Fill;
                panel1.Controls.Add(Dashboard_UserControl.Instance);
            }

            Dashboard_UserControl.Instance.BringToFront();
            Dashboard_UserControl.Instance.Focus();
        }

        // Update the menu button colors
        private void menuChange(Button btn)
        {
            foreach (Button menuButton in panelTop.Controls.OfType<Button>())
            {
                menuButton.BackColor = (menuButton == btn) ? Color.RoyalBlue : Color.MidnightBlue;
            }
            GC.Collect();
        }
    }
}
