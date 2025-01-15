using System;
using System.Drawing.Drawing2D;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using KonstantinStoykovD;
using MySql.Data.MySqlClient;

namespace VolleyballRecruitmentApp
{
    public partial class LogReg : Form
    {
        private string mysqlcon;

        public LogReg()
        {
            InitializeComponent();

            // MySQL Connection String
            mysqlcon = "server=localhost;database=volleyballrecruitmentagency;user=root;password=;port=3307";

            // Set up the form appearance
            this.FormBorderStyle = FormBorderStyle.None;  // No border for fullscreen view
            this.WindowState = FormWindowState.Maximized; // Set the window to maximize on load
        }

        private void LogReg_Load(object sender, EventArgs e)
        {
            // Setup modern background with gradient effect
            this.Paint += (sender, e) =>
            {
                var brush = new LinearGradientBrush(
                    this.ClientRectangle,
                    Color.CornflowerBlue,
                    Color.LightSkyBlue,
                    90F
                );
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            };

            // Position elements dynamically on the screen
            SetupFormElements();
        }

        private void SetupFormElements()
        {
            // Username TextBox
            txtUsername.Size = new Size(300, 35);
            txtUsername.Location = new Point((ClientSize.Width - txtUsername.Width) / 2, (ClientSize.Height - txtUsername.Height) / 2 - 50);

            // Password TextBox
            txtPassword.Size = new Size(300, 35);
            txtPassword.Location = new Point((ClientSize.Width - txtPassword.Width) / 2, (ClientSize.Height - txtPassword.Height) / 2 + 20);

            // Email TextBox (for registration only)
            txtEmail.Size = new Size(300, 35);
            txtEmail.Location = new Point((ClientSize.Width - txtEmail.Width) / 2, (ClientSize.Height - txtEmail.Height) / 2 + 90);
            txtEmail.Visible = false;

            // Login Button
            btnLogin.Size = new Size(140, 45);
            btnLogin.Location = new Point((ClientSize.Width - btnLogin.Width) / 2 - 80, (ClientSize.Height - btnLogin.Height) / 2 + 150);
            btnLogin.Font = new Font("Arial", 12, FontStyle.Bold);
            btnLogin.Text = "Login";
            btnLogin.BackColor = Color.DodgerBlue;
            btnLogin.ForeColor = Color.White;
            btnLogin.FlatStyle = FlatStyle.Flat;

            // Register Button (only visible when registering)
            btnRegister.Size = new Size(140, 45);
            btnRegister.Location = new Point((ClientSize.Width - btnRegister.Width) / 2 + 80, (ClientSize.Height - btnRegister.Height) / 2 + 150);
            btnRegister.Font = new Font("Arial", 12, FontStyle.Bold);
            btnRegister.Text = "Register";
            btnRegister.BackColor = Color.SeaGreen;
            btnRegister.ForeColor = Color.White;
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.Visible = false;

            // Radio Buttons for Login/Register toggle
            radioLogin.Location = new Point((ClientSize.Width - radioLogin.Width) / 2 - 60, (ClientSize.Height - radioLogin.Height) / 2 - 120);
            radioLogin.Text = "Login";
            radioLogin.Checked = true;

            radioRegister.Location = new Point((ClientSize.Width - radioRegister.Width) / 2 + 60, (ClientSize.Height - radioRegister.Height) / 2 - 120);
            radioRegister.Text = "Register";

            // Labels
            lblUsername.Text = "Username:";
            lblUsername.Location = new Point((ClientSize.Width - lblUsername.Width) / 2 - 150, (ClientSize.Height - lblUsername.Height) / 2 - 50);

            lblPassword.Text = "Password:";
            lblPassword.Location = new Point((ClientSize.Width - lblPassword.Width) / 2 - 150, (ClientSize.Height - lblPassword.Height) / 2 + 20);

            lblEmail.Text = "Email:";
            lblEmail.Location = new Point((ClientSize.Width - lblEmail.Width) / 2 - 150, (ClientSize.Height - lblEmail.Height) / 2 + 90);
            lblEmail.Visible = false;
        }

        private void RadioLogin_CheckedChanged(object sender, EventArgs e)
        {
            // Show/Hide elements based on selected option
            ToggleLoginRegisterVisibility(true);
        }

        private void RadioRegister_CheckedChanged(object sender, EventArgs e)
        {
            ToggleLoginRegisterVisibility(false);
        }

        private void ToggleLoginRegisterVisibility(bool isLogin)
        {
            // Toggle visibility of registration-only fields
            lblEmail.Visible = !isLogin;
            txtEmail.Visible = !isLogin;
            btnRegister.Visible = !isLogin;
            btnLogin.Visible = isLogin;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please fill in both username and password.");
                return;
            }

            string userType = AuthenticateUser(username, password);

            if (!string.IsNullOrEmpty(userType))
            {
                // Store the username in the session
                UserSession.LoggedInUsername = username;
                MessageBox.Show("Login successful!");

                // Redirect based on user type
                if (userType == "Player")
                {
                    RedirectToUserLogin(username);
                }
                else if (userType == "Coach" || userType == "Scout")
                {
                    RedirectToCoachScout();
                }
                else
                {
                    MessageBox.Show("Unrecognized user type.");
                }

                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password.");
            }
        }

        private string AuthenticateUser(string username, string password)
        {
            string query = "SELECT UserType FROM Users WHERE Username=@Username AND PasswordHash=SHA2(@Password, 256)";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(mysqlcon))
                {
                    //MessageBox.Show(mysqlcon);
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        //MessageBox.Show("2");
                        cmd.Parameters.AddWithValue("@Username", username);
                        cmd.Parameters.AddWithValue("@Password", password);

                        object result = cmd.ExecuteScalar();
                        return result?.ToString(); // Return the UserType
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error during authentication: {ex.Message}");
                return null;
            }
        }

        private void RedirectToUserLogin(string username)
        {
            UserLogin userLoginForm = new UserLogin(username);
            userLoginForm.Show();
            userLoginForm.WindowState = FormWindowState.Maximized;
        }

        private void RedirectToCoachScout()
        {
            CoachScout coachScoutForm = new CoachScout();
            coachScoutForm.Show();
            coachScoutForm.WindowState = FormWindowState.Maximized;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            string email = txtEmail.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Please fill in all required fields.");
                return;
            }

            if (username.Length < 5)
            {
                MessageBox.Show("Username must be at least 5 characters long.");
                return;
            }

            if (!IsPasswordValid(password))
            {
                MessageBox.Show("Password must be at least 8 characters long, include at least one uppercase letter, and at least one symbol.");
                return;
            }

            if (IsUsernameTaken(username))
            {
                MessageBox.Show("Username already taken. Please choose a different username.");
                return;
            }

            if (RegisterUser(username, password, email))
            {
                MessageBox.Show("Registration successful! Redirecting to Player Details...");
                PlayerDetails playerDetailsForm = new PlayerDetails(mysqlcon, username);
                playerDetailsForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Registration failed. Please try again.");
            }
        }

        private bool IsPasswordValid(string password)
        {
            string passwordPattern = @"^(?=.*[A-Z])(?=.*\W).{8,}$";
            return new Regex(passwordPattern).IsMatch(password);
        }

        private bool IsUsernameTaken(string username)
        {
            string query = "SELECT COUNT(1) FROM Users WHERE Username=@Username";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(mysqlcon))
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Username", username);
                        return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error checking username availability: {ex.Message}");
                return false;
            }
        }

        private bool RegisterUser(string username, string password, string email)
        {
            string query = "INSERT INTO Users (Username, PasswordHash, Email, UserType) VALUES (@Username, SHA2(@Password, 256), @Email, 'Player')";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(mysqlcon))
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Username", username);
                        cmd.Parameters.AddWithValue("@Password", password);
                        cmd.Parameters.AddWithValue("@Email", email);
                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error during registration: {ex.Message}");
                return false;
            }
        }
    }
}
