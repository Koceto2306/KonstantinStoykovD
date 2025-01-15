namespace VolleyballRecruitmentApp
{
    partial class CoachScout
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Button DashboardBt;
        private System.Windows.Forms.Button PlayersBt;
        private System.Windows.Forms.Panel panel1; // Dashboard panel
        private System.Windows.Forms.Panel panel2; // Players panel

        private void InitializeComponent()
        {
            panelTop = new Panel();
            tableLayoutPanel = new TableLayoutPanel();
            DashboardBt = new Button();
            PlayersBt = new Button();
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
            tableLayoutPanel.ColumnCount = 2;
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel.Controls.Add(DashboardBt, 0, 0);
            tableLayoutPanel.Controls.Add(PlayersBt, 1, 0);
            tableLayoutPanel.Dock = DockStyle.Fill;
            tableLayoutPanel.Location = new Point(0, 0);
            tableLayoutPanel.Name = "tableLayoutPanel";
            tableLayoutPanel.RowCount = 1;
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel.Size = new Size(1475, 62);
            tableLayoutPanel.TabIndex = 0;
            // 
            // DashboardBt
            // 
            DashboardBt.Dock = DockStyle.Fill;
            DashboardBt.Location = new Point(3, 3);
            DashboardBt.Name = "DashboardBt";
            DashboardBt.Size = new Size(731, 56);
            DashboardBt.TabIndex = 0;
            DashboardBt.Text = "Dashboard";
            // 
            // PlayersBt
            // 
            PlayersBt.Dock = DockStyle.Fill;
            PlayersBt.Location = new Point(740, 3);
            PlayersBt.Name = "PlayersBt";
            PlayersBt.Size = new Size(732, 56);
            PlayersBt.TabIndex = 1;
            PlayersBt.Text = "Players";
            PlayersBt.Click += PlayersBt_Click_1;
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
            panel2.Visible = false;
            // 
            // CoachScout
            // 
            ClientSize = new Size(1475, 628);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panelTop);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CoachScout";
            Text = "Coach Scout";
            WindowState = FormWindowState.Maximized;
            panelTop.ResumeLayout(false);
            tableLayoutPanel.ResumeLayout(false);
            ResumeLayout(false);
        }
    }
}
