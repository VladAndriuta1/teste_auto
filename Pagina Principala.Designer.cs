namespace teste_auto
{
    partial class PaginaPrincipala
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblSalut = new System.Windows.Forms.Label();
            this.lblRol = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.btnStatistici = new System.Windows.Forms.Button();
            this.btnTestelemele = new System.Windows.Forms.Button();
            this.btnInfo = new System.Windows.Forms.Button();
            this.btnDarkMode = new System.Windows.Forms.Button();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlCardTotal = new System.Windows.Forms.Panel();
            this.lblTotalNum = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.pnlCardPromovate = new System.Windows.Forms.Panel();
            this.lblPromovateNum = new System.Windows.Forms.Label();
            this.lblPromovate = new System.Windows.Forms.Label();
            this.pnlCardRespinse = new System.Windows.Forms.Panel();
            this.lblRespinseNum = new System.Windows.Forms.Label();
            this.lblRespinse = new System.Windows.Forms.Label();
            this.pnlTest = new System.Windows.Forms.Panel();
            this.lblTestTitle = new System.Windows.Forms.Label();
            this.lblTestDesc = new System.Windows.Forms.Label();
            this.lblTestTimer = new System.Windows.Forms.Label();
            this.pnlExamen = new System.Windows.Forms.Panel();
            this.lblExamenTitle = new System.Windows.Forms.Label();
            this.lblExamenDesc = new System.Windows.Forms.Label();
            this.lblExamenTimer = new System.Windows.Forms.Label();
            this.lblUltimele = new System.Windows.Forms.Label();
            this.dgvIstoricTeste = new System.Windows.Forms.DataGridView();
            this.btnStatistici.Click += new System.EventHandler(this.btnStatistici_Click);
            this.btnTestelemele.Click += new System.EventHandler(this.btnTestelemele_Click);
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            this.pnlTop.SuspendLayout();
            this.pnlSidebar.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.pnlCardTotal.SuspendLayout();
            this.pnlCardPromovate.SuspendLayout();
            this.pnlCardRespinse.SuspendLayout();
            this.pnlTest.SuspendLayout();
            this.pnlExamen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIstoricTeste)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(95)))), ((int)(((byte)(165)))));
            this.pnlTop.Controls.Add(this.lblSalut);
            this.pnlTop.Controls.Add(this.lblRol);
            this.pnlTop.Controls.Add(this.btnLogout);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(160, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(840, 65);
            this.pnlTop.TabIndex = 0;
            // 
            // lblSalut
            // 
            this.lblSalut.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblSalut.ForeColor = System.Drawing.Color.White;
            this.lblSalut.Location = new System.Drawing.Point(15, 10);
            this.lblSalut.Name = "lblSalut";
            this.lblSalut.Size = new System.Drawing.Size(600, 25);
            this.lblSalut.TabIndex = 0;
            this.lblSalut.Text = "Bună ziua!";
            // 
            // lblRol
            // 
            this.lblRol.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblRol.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(212)))), ((int)(((byte)(244)))));
            this.lblRol.Location = new System.Drawing.Point(15, 38);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(200, 20);
            this.lblRol.TabIndex = 1;
            this.lblRol.Text = "candidat";
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnLogout.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(885, 14);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(100, 36);
            this.btnLogout.TabIndex = 2;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(68)))), ((int)(((byte)(124)))));
            this.pnlSidebar.Controls.Add(this.btnStatistici);
            this.pnlSidebar.Controls.Add(this.btnTestelemele);
            this.pnlSidebar.Controls.Add(this.btnInfo);
            this.pnlSidebar.Controls.Add(this.btnDarkMode);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Location = new System.Drawing.Point(0, 0);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(160, 650);
            this.pnlSidebar.TabIndex = 1;
            this.pnlSidebar.Controls.Add(this.btnLogoutSidebar);
            // 
            // btnStatistici
            // 
            this.btnStatistici.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(95)))), ((int)(((byte)(165)))));
            this.btnStatistici.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(138)))), ((int)(((byte)(221)))));
            this.btnStatistici.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStatistici.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnStatistici.ForeColor = System.Drawing.Color.White;
            this.btnStatistici.Location = new System.Drawing.Point(10, 20);
            this.btnStatistici.Name = "btnStatistici";
            this.btnStatistici.Size = new System.Drawing.Size(140, 45);
            this.btnStatistici.TabIndex = 0;
            this.btnStatistici.Text = "Statistici";
            this.btnStatistici.UseVisualStyleBackColor = false;
            // 
            // btnTestelemele
            // 
            this.btnTestelemele.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(68)))), ((int)(((byte)(124)))));
            this.btnTestelemele.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(95)))), ((int)(((byte)(165)))));
            this.btnTestelemele.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTestelemele.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnTestelemele.ForeColor = System.Drawing.Color.White;
            this.btnTestelemele.Location = new System.Drawing.Point(10, 75);
            this.btnTestelemele.Name = "btnTestelemele";
            this.btnTestelemele.Size = new System.Drawing.Size(140, 45);
            this.btnTestelemele.TabIndex = 1;
            this.btnTestelemele.Text = "Testele mele";
            this.btnTestelemele.UseVisualStyleBackColor = false;
            // 
            // btnInfo
            // 
            this.btnInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(68)))), ((int)(((byte)(124)))));
            this.btnInfo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(95)))), ((int)(((byte)(165)))));
            this.btnInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInfo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnInfo.ForeColor = System.Drawing.Color.White;
            this.btnInfo.Location = new System.Drawing.Point(10, 130);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(140, 45);
            this.btnInfo.TabIndex = 2;
            this.btnInfo.Text = "Informații utile";
            this.btnInfo.UseVisualStyleBackColor = false;
            // 
            // btnDarkMode
            // 
            this.btnDarkMode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(44)))), ((int)(((byte)(83)))));
            this.btnDarkMode.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(68)))), ((int)(((byte)(124)))));
            this.btnDarkMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDarkMode.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnDarkMode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(183)))), ((int)(((byte)(235)))));
            this.btnDarkMode.Location = new System.Drawing.Point(10, 520);
            this.btnDarkMode.Name = "btnDarkMode";
            this.btnDarkMode.Size = new System.Drawing.Size(140, 45);
            this.btnDarkMode.TabIndex = 3;
            this.btnDarkMode.Text = "🌙 Dark Mode";
            this.btnDarkMode.UseVisualStyleBackColor = false;
            this.btnDarkMode.Click += new System.EventHandler(this.btnDarkMode_Click);
            // 
            // btnLogout
            // 

            this.btnLogoutSidebar = new System.Windows.Forms.Button();

            this.btnLogoutSidebar.BackColor = System.Drawing.Color.FromArgb(163, 45, 45);
            this.btnLogoutSidebar.ForeColor = System.Drawing.Color.White;
            this.btnLogoutSidebar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogoutSidebar.FlatAppearance.BorderSize = 0;
            this.btnLogoutSidebar.Font = new System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold);
            this.btnLogoutSidebar.Text = "Logout";
            this.btnLogoutSidebar.Size = new System.Drawing.Size(140, 45);
            this.btnLogoutSidebar.Location = new System.Drawing.Point(10, 580);
            this.btnLogoutSidebar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogoutSidebar.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(240)))));
            this.pnlMain.Controls.Add(this.pnlCardTotal);
            this.pnlMain.Controls.Add(this.pnlCardPromovate);
            this.pnlMain.Controls.Add(this.pnlCardRespinse);
            this.pnlMain.Controls.Add(this.pnlTest);
            this.pnlMain.Controls.Add(this.pnlExamen);
            this.pnlMain.Controls.Add(this.lblUltimele);
            this.pnlMain.Controls.Add(this.dgvIstoricTeste);
            this.pnlMain.Location = new System.Drawing.Point(160, 65);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(840, 585);
            this.pnlMain.TabIndex = 2;
            // 
            // pnlCardTotal
            // 
            this.pnlCardTotal.BackColor = System.Drawing.Color.White;
            this.pnlCardTotal.Controls.Add(this.lblTotalNum);
            this.pnlCardTotal.Controls.Add(this.lblTotal);
            this.pnlCardTotal.Location = new System.Drawing.Point(20, 20);
            this.pnlCardTotal.Name = "pnlCardTotal";
            this.pnlCardTotal.Size = new System.Drawing.Size(240, 80);
            this.pnlCardTotal.TabIndex = 0;
            // 
            // lblTotalNum
            // 
            this.lblTotalNum.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblTotalNum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(74)))), ((int)(((byte)(183)))));
            this.lblTotalNum.Location = new System.Drawing.Point(90, 8);
            this.lblTotalNum.Name = "lblTotalNum";
            this.lblTotalNum.Size = new System.Drawing.Size(60, 40);
            this.lblTotalNum.TabIndex = 0;
            this.lblTotalNum.Text = "0";
            this.lblTotalNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotal
            // 
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(94)))), ((int)(((byte)(90)))));
            this.lblTotal.Location = new System.Drawing.Point(70, 50);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(110, 20);
            this.lblTotal.TabIndex = 1;
            this.lblTotal.Text = "Teste totale";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlCardPromovate
            // 
            this.pnlCardPromovate.BackColor = System.Drawing.Color.White;
            this.pnlCardPromovate.Controls.Add(this.lblPromovateNum);
            this.pnlCardPromovate.Controls.Add(this.lblPromovate);
            this.pnlCardPromovate.Location = new System.Drawing.Point(290, 20);
            this.pnlCardPromovate.Name = "pnlCardPromovate";
            this.pnlCardPromovate.Size = new System.Drawing.Size(240, 80);
            this.pnlCardPromovate.TabIndex = 1;
            // 
            // lblPromovateNum
            // 
            this.lblPromovateNum.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblPromovateNum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(110)))), ((int)(((byte)(86)))));
            this.lblPromovateNum.Location = new System.Drawing.Point(90, 8);
            this.lblPromovateNum.Name = "lblPromovateNum";
            this.lblPromovateNum.Size = new System.Drawing.Size(60, 40);
            this.lblPromovateNum.TabIndex = 0;
            this.lblPromovateNum.Text = "0";
            this.lblPromovateNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPromovate
            // 
            this.lblPromovate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblPromovate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(94)))), ((int)(((byte)(90)))));
            this.lblPromovate.Location = new System.Drawing.Point(75, 50);
            this.lblPromovate.Name = "lblPromovate";
            this.lblPromovate.Size = new System.Drawing.Size(100, 20);
            this.lblPromovate.TabIndex = 1;
            this.lblPromovate.Text = "Promovate";
            this.lblPromovate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlCardRespinse
            // 
            this.pnlCardRespinse.BackColor = System.Drawing.Color.White;
            this.pnlCardRespinse.Controls.Add(this.lblRespinseNum);
            this.pnlCardRespinse.Controls.Add(this.lblRespinse);
            this.pnlCardRespinse.Location = new System.Drawing.Point(560, 20);
            this.pnlCardRespinse.Name = "pnlCardRespinse";
            this.pnlCardRespinse.Size = new System.Drawing.Size(240, 80);
            this.pnlCardRespinse.TabIndex = 2;
            // 
            // lblRespinseNum
            // 
            this.lblRespinseNum.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblRespinseNum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.lblRespinseNum.Location = new System.Drawing.Point(90, 8);
            this.lblRespinseNum.Name = "lblRespinseNum";
            this.lblRespinseNum.Size = new System.Drawing.Size(60, 40);
            this.lblRespinseNum.TabIndex = 0;
            this.lblRespinseNum.Text = "0";
            this.lblRespinseNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRespinse
            // 
            this.lblRespinse.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblRespinse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(94)))), ((int)(((byte)(90)))));
            this.lblRespinse.Location = new System.Drawing.Point(80, 50);
            this.lblRespinse.Name = "lblRespinse";
            this.lblRespinse.Size = new System.Drawing.Size(90, 20);
            this.lblRespinse.TabIndex = 1;
            this.lblRespinse.Text = "Respinse";
            this.lblRespinse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlTest
            // 
            this.pnlTest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(242)))), ((int)(((byte)(255)))));
            this.pnlTest.Controls.Add(this.lblTestTitle);
            this.pnlTest.Controls.Add(this.lblTestDesc);
            this.pnlTest.Controls.Add(this.lblTestTimer);
            this.pnlTest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlTest.Location = new System.Drawing.Point(20, 120);
            this.pnlTest.Name = "pnlTest";
            this.pnlTest.Size = new System.Drawing.Size(390, 130);
            this.pnlTest.TabIndex = 3;
            this.pnlTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // lblTestTitle
            // 
            this.lblTestTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTestTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(95)))), ((int)(((byte)(165)))));
            this.lblTestTitle.Location = new System.Drawing.Point(15, 10);
            this.lblTestTitle.Name = "lblTestTitle";
            this.lblTestTitle.Size = new System.Drawing.Size(200, 35);
            this.lblTestTitle.TabIndex = 0;
            this.lblTestTitle.Text = "TEST";
            this.lblTestTitle.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // lblTestDesc
            // 
            this.lblTestDesc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTestDesc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(95)))), ((int)(((byte)(165)))));
            this.lblTestDesc.Location = new System.Drawing.Point(15, 50);
            this.lblTestDesc.Name = "lblTestDesc";
            this.lblTestDesc.Size = new System.Drawing.Size(350, 20);
            this.lblTestDesc.TabIndex = 1;
            this.lblTestDesc.Text = "Practică fără limită de timp";
            this.lblTestDesc.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // lblTestTimer
            // 
            this.lblTestTimer.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTestTimer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(95)))), ((int)(((byte)(165)))));
            this.lblTestTimer.Location = new System.Drawing.Point(15, 80);
            this.lblTestTimer.Name = "lblTestTimer";
            this.lblTestTimer.Size = new System.Drawing.Size(200, 25);
            this.lblTestTimer.TabIndex = 2;
            this.lblTestTimer.Text = "Fără timer";
            this.lblTestTimer.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // pnlExamen
            // 
            this.pnlExamen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(95)))), ((int)(((byte)(165)))));
            this.pnlExamen.Controls.Add(this.lblExamenTitle);
            this.pnlExamen.Controls.Add(this.lblExamenDesc);
            this.pnlExamen.Controls.Add(this.lblExamenTimer);
            this.pnlExamen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlExamen.Location = new System.Drawing.Point(430, 120);
            this.pnlExamen.Name = "pnlExamen";
            this.pnlExamen.Size = new System.Drawing.Size(390, 130);
            this.pnlExamen.TabIndex = 4;
            this.pnlExamen.Click += new System.EventHandler(this.btnExamen_Click);
            // 
            // lblExamenTitle
            // 
            this.lblExamenTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblExamenTitle.ForeColor = System.Drawing.Color.White;
            this.lblExamenTitle.Location = new System.Drawing.Point(15, 10);
            this.lblExamenTitle.Name = "lblExamenTitle";
            this.lblExamenTitle.Size = new System.Drawing.Size(250, 35);
            this.lblExamenTitle.TabIndex = 0;
            this.lblExamenTitle.Text = "EXAMEN";
            this.lblExamenTitle.Click += new System.EventHandler(this.btnExamen_Click);
            // 
            // lblExamenDesc
            // 
            this.lblExamenDesc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblExamenDesc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(212)))), ((int)(((byte)(244)))));
            this.lblExamenDesc.Location = new System.Drawing.Point(15, 50);
            this.lblExamenDesc.Name = "lblExamenDesc";
            this.lblExamenDesc.Size = new System.Drawing.Size(370, 20);
            this.lblExamenDesc.TabIndex = 1;
            this.lblExamenDesc.Text = "Simulare reală, 24 de întrebări, minim 22 pentru promovare";
            this.lblExamenDesc.Click += new System.EventHandler(this.btnExamen_Click);
            // 
            // lblExamenTimer
            // 
            this.lblExamenTimer.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblExamenTimer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(74)))), ((int)(((byte)(183)))));
            this.lblExamenTimer.Location = new System.Drawing.Point(15, 80);
            this.lblExamenTimer.Name = "lblExamenTimer";
            this.lblExamenTimer.Size = new System.Drawing.Size(200, 25);
            this.lblExamenTimer.TabIndex = 2;
            this.lblExamenTimer.Text = "30 de minute";
            this.lblExamenTimer.Click += new System.EventHandler(this.btnExamen_Click);
            // 
            // lblUltimele
            // 
            this.lblUltimele.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblUltimele.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(42)))));
            this.lblUltimele.Location = new System.Drawing.Point(20, 270);
            this.lblUltimele.Name = "lblUltimele";
            this.lblUltimele.Size = new System.Drawing.Size(200, 30);
            this.lblUltimele.TabIndex = 5;
            this.lblUltimele.Text = "Ultimele teste";
            // 
            // dgvIstoricTeste
            // 
            this.dgvIstoricTeste.AllowUserToAddRows = false;
            this.dgvIstoricTeste.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvIstoricTeste.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(110)))));
            this.dgvIstoricTeste.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(68)))), ((int)(((byte)(124)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvIstoricTeste.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvIstoricTeste.ColumnHeadersHeight = 29;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(110)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvIstoricTeste.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvIstoricTeste.EnableHeadersVisualStyles = false;
            this.dgvIstoricTeste.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(95)))), ((int)(((byte)(165)))));
            this.dgvIstoricTeste.Location = new System.Drawing.Point(20, 305);
            this.dgvIstoricTeste.Name = "dgvIstoricTeste";
            this.dgvIstoricTeste.ReadOnly = true;
            this.dgvIstoricTeste.RowHeadersVisible = false;
            this.dgvIstoricTeste.RowHeadersWidth = 51;
            this.dgvIstoricTeste.Size = new System.Drawing.Size(800, 250);
            this.dgvIstoricTeste.TabIndex = 6;
            // 
            // PaginaPrincipala
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(1000, 650);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.pnlSidebar);
            this.Controls.Add(this.pnlMain);
            this.pnlSidebar.Controls.Add(this.btnLogoutSidebar);
            this.MinimumSize = new System.Drawing.Size(1000, 650);
            this.Name = "PaginaPrincipala";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Teste Auto";
            this.Load += new System.EventHandler(this.PaginaPrincipala_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlSidebar.ResumeLayout(false);
            this.pnlMain.ResumeLayout(false);
            this.pnlCardTotal.ResumeLayout(false);
            this.pnlCardPromovate.ResumeLayout(false);
            this.pnlCardRespinse.ResumeLayout(false);
            this.pnlTest.ResumeLayout(false);
            this.pnlExamen.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIstoricTeste)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblSalut;
        private System.Windows.Forms.Label lblRol;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Button btnStatistici;
        private System.Windows.Forms.Button btnTestelemele;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.Button btnDarkMode;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlCardTotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblTotalNum;
        private System.Windows.Forms.Panel pnlCardPromovate;
        private System.Windows.Forms.Label lblPromovate;
        private System.Windows.Forms.Label lblPromovateNum;
        private System.Windows.Forms.Panel pnlCardRespinse;
        private System.Windows.Forms.Label lblRespinse;
        private System.Windows.Forms.Label lblRespinseNum;
        private System.Windows.Forms.Panel pnlTest;
        private System.Windows.Forms.Label lblTestTitle;
        private System.Windows.Forms.Label lblTestDesc;
        private System.Windows.Forms.Label lblTestTimer;
        private System.Windows.Forms.Panel pnlExamen;
        private System.Windows.Forms.Label lblExamenTitle;
        private System.Windows.Forms.Label lblExamenDesc;
        private System.Windows.Forms.Label lblExamenTimer;
        private System.Windows.Forms.Label lblUltimele;
        private System.Windows.Forms.DataGridView dgvIstoricTeste;
        private System.Windows.Forms.Button btnLogoutSidebar;
    }
}