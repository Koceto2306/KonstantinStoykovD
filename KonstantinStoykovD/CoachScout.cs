using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace VolleyballRecruitmentApp
{
    public partial class CoachScout : Form
    {
        private readonly string username;

        // Constructor
        public CoachScout(string loggedInUsername)
        {
            InitializeComponent();
            username = loggedInUsername;

            // Bind button events
            BindEvents();

            // Show dashboard view by default
            ShowDashboard();
        }

        // Default constructor for designer use
        public CoachScout() => InitializeComponent();

        // Bind button events
        private void BindEvents()
        {
            PlayersBt.Click += PlayersBt_Click;
            DashboardBt.Click += DashboardBt_Click;
        }

        // Show the dashboard when the Dashboard button is clicked
        private void DashboardBt_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = false;

            ShowDashboard();
            UpdateMenuAppearance(DashboardBt);
        }

        // Show the players when the Players button is clicked
        private void PlayersBt_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;  // Hide the dashboard panel
            panel2.Visible = true;   // Show the players panel

            ShowPlayers();           // Load the players into the DataGridView
            UpdateMenuAppearance(PlayersBt);
        }

        // Method to show the dashboard in panel1
        private void ShowDashboard()
        {
            panel1.Controls.Clear();

            Label dashboardLabel = new Label
            {
                Text = "Dashboard Coming Soon...",
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Arial", 20, FontStyle.Bold)
            };
            panel1.Controls.Add(dashboardLabel);
        }

        // Method to fetch and display players in panel2
        private void ShowPlayers()
        {
            panel2.Controls.Clear();

            // Create and configure DataGridView
            DataGridView playersGridView = new DataGridView
            {
                Dock = DockStyle.Fill,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                ReadOnly = true,
                AllowUserToAddRows = false,
                AllowUserToDeleteRows = false
            };

            try
            {
                // Fetch players data
                string query = @"SELECT 
                                    Email, 
                                    UserType, 
                                    RegistrationDate, 
                                    FirstName, 
                                    MiddleName, 
                                    LastName, 
                                    Position, 
                                    Height, 
                                    Weight, 
                                    BirthDate 
                                 FROM Players";

                using (SqlCommand command = new SqlCommand(query, DataBase.Instance.Connection))
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    DataTable playersTable = new DataTable();
                    adapter.Fill(playersTable);

                    // Bind data to DataGridView
                    playersGridView.DataSource = playersTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading players: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            panel2.Controls.Add(playersGridView);  // Add the DataGridView to the panel
        }

        // Update the appearance of the menu buttons for navigation
        private void UpdateMenuAppearance(Button activeButton)
        {
            foreach (Button menuButton in panelTop.Controls.OfType<Button>())
            {
                menuButton.BackColor = (menuButton == activeButton) ? Color.RoyalBlue : Color.MidnightBlue;
            }
        }

        private void PlayersBt_Click_1(object sender, EventArgs e)
        {

        }
    }
}
