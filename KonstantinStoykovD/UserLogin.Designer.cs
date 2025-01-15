namespace VolleyballRecruitmentApp
{
    partial class UserLogin
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnTransfer;
        private System.Windows.Forms.Button btnNotifications;
        private System.Windows.Forms.Button btnPlayers;
        private System.Windows.Forms.Panel panel1; // For Dashboard and other controls
        private System.Windows.Forms.Panel panel2; // For TransferDashboard

        private void InitializeComponent()
        {
            panelTop = new Panel();
            tableLayoutPanel = new TableLayoutPanel();
            btnDashboard = new Button();
            btnTransfer = new Button();
            btnNotifications = new Button();
            btnPlayers = new Button();
            panel1 = new Panel();
            panel2 = new Panel();

            panelTop.SuspendLayout();
            tableLayoutPanel.SuspendLayout();
            SuspendLayout();

            // 
            // panelTop
            // 
            panelTop.BackColor = Color.LightGray;
            panelTop.Controls.Add(tableLayoutPanel);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(1475, 62);
            panelTop.TabIndex = 0;

            // 
            // tableLayoutPanel
            // 
            tableLayoutPanel.ColumnCount = 4;
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel.Controls.Add(btnDashboard, 0, 0);
            tableLayoutPanel.Controls.Add(btnTransfer, 1, 0);
            tableLayoutPanel.Controls.Add(btnNotifications, 2, 0);
            tableLayoutPanel.Controls.Add(btnPlayers, 3, 0);
            tableLayoutPanel.Dock = DockStyle.Fill;
            tableLayoutPanel.Location = new Point(0, 0);
            tableLayoutPanel.Name = "tableLayoutPanel";
            tableLayoutPanel.RowCount = 1;
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel.Size = new Size(1475, 62);
            tableLayoutPanel.TabIndex = 0;

            // 
            // btnDashboard
            // 
            btnDashboard.Dock = DockStyle.Fill;
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(362, 56);
            btnDashboard.TabIndex = 0;
            btnDashboard.Text = "Dashboard";
            btnDashboard.Click += btnDashboard_Click;

            // 
            // btnTransfer
            // 
            btnTransfer.Dock = DockStyle.Fill;
            btnTransfer.Name = "btnTransfer";
            btnTransfer.Size = new Size(362, 56);
            btnTransfer.TabIndex = 1;
            btnTransfer.Text = "Transfer";
            btnTransfer.Click += btnTransfer_Click;

            // 
            // btnNotifications
            // 
            btnNotifications.Dock = DockStyle.Fill;
            btnNotifications.Name = "btnNotifications";
            btnNotifications.Size = new Size(362, 56);
            btnNotifications.TabIndex = 2;
            btnNotifications.Text = "Notifications";
            btnNotifications.Click += BtnNotifications_Click;

            // 
            // btnPlayers
            // 
            btnPlayers.Dock = DockStyle.Fill;
            btnPlayers.Name = "btnPlayers";
            btnPlayers.Size = new Size(362, 56);
            btnPlayers.TabIndex = 3;
            btnPlayers.Text = "Players";
            btnPlayers.Click += BtnPlayers_Click;

            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 62);
            panel1.Name = "panel1";
            panel1.Size = new Size(1475, 566);
            panel1.TabIndex = 1;

            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 62);
            panel2.Name = "panel2";
            panel2.Size = new Size(1475, 566);
            panel2.TabIndex = 2;
            panel2.Visible = false; // Initially hidden

            // 
            // UserLogin
            // 
            ClientSize = new Size(1475, 628);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panelTop);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UserLogin";
            Text = "User Login";
            WindowState = FormWindowState.Maximized;

            panelTop.ResumeLayout(false);
            tableLayoutPanel.ResumeLayout(false);
            ResumeLayout(false);
        }
    }
}
