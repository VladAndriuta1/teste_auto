namespace teste_auto
{
    partial class AdminForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblSalut = new System.Windows.Forms.Label();
            this.lblRol = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.btnIntrebari = new System.Windows.Forms.Button();
            this.btnUtilizatori = new System.Windows.Forms.Button();
            this.btnRezultate = new System.Windows.Forms.Button();
            this.btnDarkMode = new System.Windows.Forms.Button();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlStat1 = new System.Windows.Forms.Panel();
            this.lblStat1Num = new System.Windows.Forms.Label();
            this.lblStat1Text = new System.Windows.Forms.Label();
            this.pnlStat2 = new System.Windows.Forms.Panel();
            this.lblStat2Num = new System.Windows.Forms.Label();
            this.lblStat2Text = new System.Windows.Forms.Label();
            this.pnlStat3 = new System.Windows.Forms.Panel();
            this.lblStat3Num = new System.Windows.Forms.Label();
            this.lblStat3Text = new System.Windows.Forms.Label();
            this.pnlStat4 = new System.Windows.Forms.Panel();
            this.lblStat4Num = new System.Windows.Forms.Label();
            this.lblStat4Text = new System.Windows.Forms.Label();
            this.lblUtilizatori = new System.Windows.Forms.Label();
            this.dgvUtilizatori = new System.Windows.Forms.DataGridView();
            this.lblRezultate = new System.Windows.Forms.Label();
            this.dgvRezultate = new System.Windows.Forms.DataGridView();
            this.btnAdaugaIntrebare = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnGestionareUtil = new System.Windows.Forms.Button();
            this.btnLogoutSidebar = new System.Windows.Forms.Button();

            this.SuspendLayout();

            // Form
            this.ClientSize = new System.Drawing.Size(1050, 650);
            this.Text = "Teste Auto - Administrator";
            this.BackColor = System.Drawing.Color.FromArgb(232, 234, 240);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.AdminForm_Load);

            // pnlTop
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(24, 95, 165);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Height = 65;
            this.pnlTop.Controls.Add(this.lblSalut);
            this.pnlTop.Controls.Add(this.lblRol);
            this.pnlTop.Controls.Add(this.btnLogout);

            this.lblSalut.Text = "Bună ziua, Admin!";
            this.lblSalut.Font = new System.Drawing.Font("Segoe UI", 13, System.Drawing.FontStyle.Bold);
            this.lblSalut.ForeColor = System.Drawing.Color.White;
            this.lblSalut.Location = new System.Drawing.Point(15, 10);
            this.lblSalut.Size = new System.Drawing.Size(400, 25);

            this.lblRol.Text = "Administrator";
            this.lblRol.Font = new System.Drawing.Font("Segoe UI", 9);
            this.lblRol.ForeColor = System.Drawing.Color.FromArgb(181, 212, 244);
            this.lblRol.Location = new System.Drawing.Point(15, 38);
            this.lblRol.Size = new System.Drawing.Size(200, 20);

            this.btnLogout.Text = "Logout";
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 10, System.Drawing.FontStyle.Bold);
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(163, 45, 45);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.Size = new System.Drawing.Size(100, 36);
            this.btnLogout.Location = new System.Drawing.Point(935, 14);
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);

            // pnlSidebar
            this.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(12, 68, 124);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Width = 150;
            this.pnlSidebar.Controls.Add(this.btnDashboard);
            this.pnlSidebar.Controls.Add(this.btnIntrebari);
            this.pnlSidebar.Controls.Add(this.btnUtilizatori);
            this.pnlSidebar.Controls.Add(this.btnRezultate);
            this.pnlSidebar.Controls.Add(this.btnDarkMode);
            this.pnlSidebar.Controls.Add(this.btnLogoutSidebar);

            // Butoane sidebar
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.Font = new System.Drawing.Font("Segoe UI", 10, System.Drawing.FontStyle.Bold);
            this.btnDashboard.BackColor = System.Drawing.Color.FromArgb(24, 95, 165);
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.Size = new System.Drawing.Size(130, 45);
            this.btnDashboard.Location = new System.Drawing.Point(10, 20);
            this.btnDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);

            this.btnIntrebari.Text = "Întrebări";
            this.btnIntrebari.Font = new System.Drawing.Font("Segoe UI", 10, System.Drawing.FontStyle.Bold);
            this.btnIntrebari.BackColor = System.Drawing.Color.FromArgb(12, 68, 124);
            this.btnIntrebari.ForeColor = System.Drawing.Color.White;
            this.btnIntrebari.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIntrebari.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(24, 95, 165);
            this.btnIntrebari.Size = new System.Drawing.Size(130, 45);
            this.btnIntrebari.Location = new System.Drawing.Point(10, 75);
            this.btnIntrebari.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIntrebari.Click += new System.EventHandler(this.btnIntrebari_Click);

            this.btnUtilizatori.Text = "Utilizatori";
            this.btnUtilizatori.Font = new System.Drawing.Font("Segoe UI", 10, System.Drawing.FontStyle.Bold);
            this.btnUtilizatori.BackColor = System.Drawing.Color.FromArgb(12, 68, 124);
            this.btnUtilizatori.ForeColor = System.Drawing.Color.White;
            this.btnUtilizatori.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUtilizatori.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(24, 95, 165);
            this.btnUtilizatori.Size = new System.Drawing.Size(130, 45);
            this.btnUtilizatori.Location = new System.Drawing.Point(10, 130);
            this.btnUtilizatori.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUtilizatori.Click += new System.EventHandler(this.btnUtilizatori_Click);

            this.btnRezultate.Text = "Rezultate";
            this.btnRezultate.Font = new System.Drawing.Font("Segoe UI", 10, System.Drawing.FontStyle.Bold);
            this.btnRezultate.BackColor = System.Drawing.Color.FromArgb(12, 68, 124);
            this.btnRezultate.ForeColor = System.Drawing.Color.White;
            this.btnRezultate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRezultate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(24, 95, 165);
            this.btnRezultate.Size = new System.Drawing.Size(130, 45);
            this.btnRezultate.Location = new System.Drawing.Point(10, 185);
            this.btnRezultate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRezultate.Click += new System.EventHandler(this.btnRezultate_Click);

            this.btnDarkMode.Text = "🌙 Dark Mode";
            this.btnDarkMode.Font = new System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold);
            this.btnDarkMode.BackColor = System.Drawing.Color.FromArgb(4, 44, 83);
            this.btnDarkMode.ForeColor = System.Drawing.Color.FromArgb(133, 183, 235);
            this.btnDarkMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDarkMode.FlatAppearance.BorderSize = 0;
            this.btnDarkMode.Size = new System.Drawing.Size(130, 45);
            this.btnDarkMode.Location = new System.Drawing.Point(10, 500);
            this.btnDarkMode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDarkMode.Click += new System.EventHandler(this.btnDarkMode_Click);

            this.btnLogoutSidebar.Text = "Logout";
            this.btnLogoutSidebar.Font = new System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold);
            this.btnLogoutSidebar.BackColor = System.Drawing.Color.FromArgb(163, 45, 45);
            this.btnLogoutSidebar.ForeColor = System.Drawing.Color.White;
            this.btnLogoutSidebar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogoutSidebar.FlatAppearance.BorderSize = 0;
            this.btnLogoutSidebar.Size = new System.Drawing.Size(130, 45);
            this.btnLogoutSidebar.Location = new System.Drawing.Point(10, 570);
            this.btnLogoutSidebar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogoutSidebar.Click += new System.EventHandler(this.btnLogout_Click);


            // pnlMain
            this.pnlMain.BackColor = System.Drawing.Color.FromArgb(232, 234, 240);
            this.pnlMain.Location = new System.Drawing.Point(150, 65);
            this.pnlMain.Size = new System.Drawing.Size(900, 585);
            this.pnlMain.Controls.Add(this.pnlStat1);
            this.pnlMain.Controls.Add(this.pnlStat2);
            this.pnlMain.Controls.Add(this.pnlStat3);
            this.pnlMain.Controls.Add(this.pnlStat4);
            this.pnlMain.Controls.Add(this.lblUtilizatori);
            this.pnlMain.Controls.Add(this.dgvUtilizatori);
            this.pnlMain.Controls.Add(this.lblRezultate);
            this.pnlMain.Controls.Add(this.dgvRezultate);
            this.pnlMain.Controls.Add(this.btnAdaugaIntrebare);
            this.pnlMain.Controls.Add(this.btnExport);
            this.pnlMain.Controls.Add(this.btnGestionareUtil);

            // Carduri statistici
            int cardW = 195, cardH = 80, cardY = 15;

            this.pnlStat1.BackColor = System.Drawing.Color.White;
            this.pnlStat1.Location = new System.Drawing.Point(15, cardY);
            this.pnlStat1.Size = new System.Drawing.Size(cardW, cardH);
            this.pnlStat1.Controls.Add(this.lblStat1Num);
            this.pnlStat1.Controls.Add(this.lblStat1Text);

            this.lblStat1Num.Text = "0";
            this.lblStat1Num.Font = new System.Drawing.Font("Segoe UI", 20, System.Drawing.FontStyle.Bold);
            this.lblStat1Num.ForeColor = System.Drawing.Color.FromArgb(83, 74, 183);
            this.lblStat1Num.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblStat1Num.Location = new System.Drawing.Point(0, 8);
            this.lblStat1Num.Size = new System.Drawing.Size(cardW, 38);

            this.lblStat1Text.Text = "Utilizatori";
            this.lblStat1Text.Font = new System.Drawing.Font("Segoe UI", 9);
            this.lblStat1Text.ForeColor = System.Drawing.Color.FromArgb(95, 94, 90);
            this.lblStat1Text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblStat1Text.Location = new System.Drawing.Point(0, 48);
            this.lblStat1Text.Size = new System.Drawing.Size(cardW, 22);

            this.pnlStat2.BackColor = System.Drawing.Color.White;
            this.pnlStat2.Location = new System.Drawing.Point(225, cardY);
            this.pnlStat2.Size = new System.Drawing.Size(cardW, cardH);
            this.pnlStat2.Controls.Add(this.lblStat2Num);
            this.pnlStat2.Controls.Add(this.lblStat2Text);

            this.lblStat2Num.Text = "0";
            this.lblStat2Num.Font = new System.Drawing.Font("Segoe UI", 20, System.Drawing.FontStyle.Bold);
            this.lblStat2Num.ForeColor = System.Drawing.Color.FromArgb(15, 110, 86);
            this.lblStat2Num.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblStat2Num.Location = new System.Drawing.Point(0, 8);
            this.lblStat2Num.Size = new System.Drawing.Size(cardW, 38);

            this.lblStat2Text.Text = "Teste susținute";
            this.lblStat2Text.Font = new System.Drawing.Font("Segoe UI", 9);
            this.lblStat2Text.ForeColor = System.Drawing.Color.FromArgb(95, 94, 90);
            this.lblStat2Text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblStat2Text.Location = new System.Drawing.Point(0, 48);
            this.lblStat2Text.Size = new System.Drawing.Size(cardW, 22);

            this.pnlStat3.BackColor = System.Drawing.Color.White;
            this.pnlStat3.Location = new System.Drawing.Point(435, cardY);
            this.pnlStat3.Size = new System.Drawing.Size(cardW, cardH);
            this.pnlStat3.Controls.Add(this.lblStat3Num);
            this.pnlStat3.Controls.Add(this.lblStat3Text);

            this.lblStat3Num.Text = "0%";
            this.lblStat3Num.Font = new System.Drawing.Font("Segoe UI", 20, System.Drawing.FontStyle.Bold);
            this.lblStat3Num.ForeColor = System.Drawing.Color.FromArgb(133, 79, 11);
            this.lblStat3Num.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblStat3Num.Location = new System.Drawing.Point(0, 8);
            this.lblStat3Num.Size = new System.Drawing.Size(cardW, 38);

            this.lblStat3Text.Text = "Rata promovare";
            this.lblStat3Text.Font = new System.Drawing.Font("Segoe UI", 9);
            this.lblStat3Text.ForeColor = System.Drawing.Color.FromArgb(95, 94, 90);
            this.lblStat3Text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblStat3Text.Location = new System.Drawing.Point(0, 48);
            this.lblStat3Text.Size = new System.Drawing.Size(cardW, 22);

            this.pnlStat4.BackColor = System.Drawing.Color.White;
            this.pnlStat4.Location = new System.Drawing.Point(645, cardY);
            this.pnlStat4.Size = new System.Drawing.Size(cardW, cardH);
            this.pnlStat4.Controls.Add(this.lblStat4Num);
            this.pnlStat4.Controls.Add(this.lblStat4Text);

            this.lblStat4Num.Text = "0";
            this.lblStat4Num.Font = new System.Drawing.Font("Segoe UI", 20, System.Drawing.FontStyle.Bold);
            this.lblStat4Num.ForeColor = System.Drawing.Color.FromArgb(163, 45, 45);
            this.lblStat4Num.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblStat4Num.Location = new System.Drawing.Point(0, 8);
            this.lblStat4Num.Size = new System.Drawing.Size(cardW, 38);

            this.lblStat4Text.Text = "Întrebări";
            this.lblStat4Text.Font = new System.Drawing.Font("Segoe UI", 9);
            this.lblStat4Text.ForeColor = System.Drawing.Color.FromArgb(95, 94, 90);
            this.lblStat4Text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblStat4Text.Location = new System.Drawing.Point(0, 48);
            this.lblStat4Text.Size = new System.Drawing.Size(cardW, 22);

            // lblUtilizatori
            this.lblUtilizatori.Text = "Utilizatori recenți";
            this.lblUtilizatori.Font = new System.Drawing.Font("Segoe UI", 12, System.Drawing.FontStyle.Bold);
            this.lblUtilizatori.ForeColor = System.Drawing.Color.FromArgb(12, 68, 124);
            this.lblUtilizatori.Location = new System.Drawing.Point(15, 110);
            this.lblUtilizatori.Size = new System.Drawing.Size(200, 28);

            // dgvUtilizatori
            this.dgvUtilizatori.Location = new System.Drawing.Point(15, 140);
            this.dgvUtilizatori.Size = new System.Drawing.Size(420, 320);
            this.dgvUtilizatori.BackgroundColor = System.Drawing.Color.FromArgb(30, 58, 110);
            this.dgvUtilizatori.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(30, 58, 110);
            this.dgvUtilizatori.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvUtilizatori.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10);
            this.dgvUtilizatori.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(12, 68, 124);
            this.dgvUtilizatori.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvUtilizatori.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10, System.Drawing.FontStyle.Bold);
            this.dgvUtilizatori.EnableHeadersVisualStyles = false;
            this.dgvUtilizatori.RowHeadersVisible = false;
            this.dgvUtilizatori.AllowUserToAddRows = false;
            this.dgvUtilizatori.ReadOnly = true;
            this.dgvUtilizatori.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvUtilizatori.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUtilizatori.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;

            // lblRezultate
            this.lblRezultate.Text = "Ultimele rezultate";
            this.lblRezultate.Font = new System.Drawing.Font("Segoe UI", 12, System.Drawing.FontStyle.Bold);
            this.lblRezultate.ForeColor = System.Drawing.Color.FromArgb(12, 68, 124);
            this.lblRezultate.Location = new System.Drawing.Point(455, 110);
            this.lblRezultate.Size = new System.Drawing.Size(200, 28);

            // dgvRezultate
            this.dgvRezultate.Location = new System.Drawing.Point(455, 140);
            this.dgvRezultate.Size = new System.Drawing.Size(430, 320);
            this.dgvRezultate.BackgroundColor = System.Drawing.Color.FromArgb(30, 58, 110);
            this.dgvRezultate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(30, 58, 110);
            this.dgvRezultate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvRezultate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10);
            this.dgvRezultate.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(12, 68, 124);
            this.dgvRezultate.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvRezultate.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10, System.Drawing.FontStyle.Bold);
            this.dgvRezultate.EnableHeadersVisualStyles = false;
            this.dgvRezultate.RowHeadersVisible = false;
            this.dgvRezultate.AllowUserToAddRows = false;
            this.dgvRezultate.ReadOnly = true;
            this.dgvRezultate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvRezultate.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

            // Butoane actiuni
            this.btnAdaugaIntrebare.Text = "+ Adaugă întrebare";
            this.btnAdaugaIntrebare.Font = new System.Drawing.Font("Segoe UI", 10, System.Drawing.FontStyle.Bold);
            this.btnAdaugaIntrebare.BackColor = System.Drawing.Color.FromArgb(24, 95, 165);
            this.btnAdaugaIntrebare.ForeColor = System.Drawing.Color.White;
            this.btnAdaugaIntrebare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdaugaIntrebare.FlatAppearance.BorderSize = 0;
            this.btnAdaugaIntrebare.Size = new System.Drawing.Size(260, 45);
            this.btnAdaugaIntrebare.Location = new System.Drawing.Point(15, 520);
            this.btnAdaugaIntrebare.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdaugaIntrebare.Click += new System.EventHandler(this.btnAdaugaIntrebare_Click);

            this.btnExport.Text = "Export rezultate";
            this.btnExport.Font = new System.Drawing.Font("Segoe UI", 10, System.Drawing.FontStyle.Bold);
            this.btnExport.BackColor = System.Drawing.Color.White;
            this.btnExport.ForeColor = System.Drawing.Color.FromArgb(24, 95, 165);
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(24, 95, 165);
            this.btnExport.Size = new System.Drawing.Size(260, 45);
            this.btnExport.Location = new System.Drawing.Point(310, 520);
            this.btnExport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);

            this.btnGestionareUtil.Text = "Gestionare utilizatori";
            this.btnGestionareUtil.Font = new System.Drawing.Font("Segoe UI", 10, System.Drawing.FontStyle.Bold);
            this.btnGestionareUtil.BackColor = System.Drawing.Color.White;
            this.btnGestionareUtil.ForeColor = System.Drawing.Color.FromArgb(24, 95, 165);
            this.btnGestionareUtil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestionareUtil.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(24, 95, 165);
            this.btnGestionareUtil.Size = new System.Drawing.Size(260, 45);
            this.btnGestionareUtil.Location = new System.Drawing.Point(610, 520);
            this.btnGestionareUtil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGestionareUtil.Click += new System.EventHandler(this.btnGestionareUtil_Click);

            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.pnlSidebar);
            this.Controls.Add(this.pnlMain);

            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblSalut;
        private System.Windows.Forms.Label lblRol;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnIntrebari;
        private System.Windows.Forms.Button btnUtilizatori;
        private System.Windows.Forms.Button btnRezultate;
        private System.Windows.Forms.Button btnDarkMode;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlStat1;
        private System.Windows.Forms.Label lblStat1Num;
        private System.Windows.Forms.Label lblStat1Text;
        private System.Windows.Forms.Panel pnlStat2;
        private System.Windows.Forms.Label lblStat2Num;
        private System.Windows.Forms.Label lblStat2Text;
        private System.Windows.Forms.Panel pnlStat3;
        private System.Windows.Forms.Label lblStat3Num;
        private System.Windows.Forms.Label lblStat3Text;
        private System.Windows.Forms.Panel pnlStat4;
        private System.Windows.Forms.Label lblStat4Num;
        private System.Windows.Forms.Label lblStat4Text;
        private System.Windows.Forms.Label lblUtilizatori;
        private System.Windows.Forms.DataGridView dgvUtilizatori;
        private System.Windows.Forms.Label lblRezultate;
        private System.Windows.Forms.DataGridView dgvRezultate;
        private System.Windows.Forms.Button btnAdaugaIntrebare;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnGestionareUtil;
        private System.Windows.Forms.Button btnLogoutSidebar;
    }
}