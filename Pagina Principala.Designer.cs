using System;
using System.Drawing;
using System.Windows.Forms;

partial class PaginaPrincipala
{
        private System.ComponentModel.IContainer components = null;

        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.btnDarkMode = new System.Windows.Forms.Button();
            this.btnIstoricTeste = new System.Windows.Forms.Button();
            this.btnInfo = new System.Windows.Forms.Button();
            this.btnStatistici = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnTest = new System.Windows.Forms.Button();
            this.btnExamen = new System.Windows.Forms.Button();
            this.dgvIstoricTeste = new System.Windows.Forms.DataGridView();
            this.pnlTop.SuspendLayout();
            this.pnlSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIstoricTeste)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(-8, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(900, 22);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Teste Auto";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(74)))), ((int)(((byte)(183)))));
            this.pnlTop.Controls.Add(this.btnLogout);
            this.pnlTop.Controls.Add(this.label1);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(899, 50);
            this.pnlTop.TabIndex = 0;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(802, 12);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 23);
            this.btnLogout.TabIndex = 1;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;

            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(42, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bine ai venit";
            // 
            // pnlSideBar
            // 
            this.pnlSidebar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlSidebar.Controls.Add(this.btnDarkMode);
            this.pnlSidebar.Controls.Add(this.btnIstoricTeste);
            this.pnlSidebar.Controls.Add(this.btnInfo);
            this.pnlSidebar.Controls.Add(this.btnStatistici);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Location = new System.Drawing.Point(0, 50);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(120, 453);
            this.pnlSidebar.TabIndex = 2;
            // 
            // btnDarkMode
            // 
            this.btnDarkMode.Location = new System.Drawing.Point(12, 323);
            this.btnDarkMode.Name = "btnDarkMode";
            this.btnDarkMode.Size = new System.Drawing.Size(105, 28);
            this.btnDarkMode.TabIndex = 3;
            this.btnDarkMode.Text = "Dark/Light";
            this.btnDarkMode.UseVisualStyleBackColor = true;
            // 
            // btnIstoricTeste
            // 
            this.btnIstoricTeste.Location = new System.Drawing.Point(17, 77);
            this.btnIstoricTeste.Name = "btnIstoricTeste";
            this.btnIstoricTeste.Size = new System.Drawing.Size(91, 23);
            this.btnIstoricTeste.TabIndex = 2;
            this.btnIstoricTeste.Text = "Istoric teste";
            this.btnIstoricTeste.UseVisualStyleBackColor = true;
            // 
            // btnInfo
            // 
            this.btnInfo.Location = new System.Drawing.Point(26, 115);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(75, 23);
            this.btnInfo.TabIndex = 1;
            this.btnInfo.Text = "Informatii utile";
            this.btnInfo.UseVisualStyleBackColor = true;
            // 
            // btnStatistici
            // 
            this.btnStatistici.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnStatistici.Location = new System.Drawing.Point(26, 29);
            this.btnStatistici.Name = "btnStatistici";
            this.btnStatistici.Size = new System.Drawing.Size(75, 23);
            this.btnStatistici.TabIndex = 0;
            this.btnStatistici.Text = "Statistici";
            this.btnStatistici.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(243, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(437, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(724, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "label4";
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(313, 150);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(75, 23);
            this.btnTest.TabIndex = 6;
            this.btnTest.Text = "TEST";
            this.btnTest.UseVisualStyleBackColor = true;
            // 
            // btnExamen
            // 
            this.btnExamen.Location = new System.Drawing.Point(681, 150);
            this.btnExamen.Name = "btnExamen";
            this.btnExamen.Size = new System.Drawing.Size(75, 23);
            this.btnExamen.TabIndex = 7;
            this.btnExamen.Text = "EXAMEN";
            this.btnExamen.UseVisualStyleBackColor = true;
            // 
            // dgvIstoricTeste
            // 
            this.dgvIstoricTeste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIstoricTeste.Location = new System.Drawing.Point(285, 260);
            this.dgvIstoricTeste.Name = "dgvIstoricTeste";
            this.dgvIstoricTeste.RowHeadersWidth = 51;
            this.dgvIstoricTeste.RowTemplate.Height = 24;
            this.dgvIstoricTeste.Size = new System.Drawing.Size(458, 231);
            this.dgvIstoricTeste.TabIndex = 8;
            // 
            // PaginaPrincipala
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 503);
            this.Controls.Add(this.dgvIstoricTeste);
            this.Controls.Add(this.btnExamen);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pnlSidebar);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.textBox1);
            this.MinimumSize = new System.Drawing.Size(900, 550);
            this.Name = "PaginaPrincipala";
            this.Text = "Pagina Principala";
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.pnlSidebar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIstoricTeste)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private void PaginaPrincipala_Load(object sender, EventArgs e)
        {
            label1.Text = $"Bună ziua, {utilizatorCurent.Nume} {utilizatorCurent.Prenume}!";
            IncarcaStatistici();
            IncarcaIstoricTeste();
        }

        private void IncarcaStatistici()
        {
            var statistici = testService.GetStatistici(utilizatorCurent.Id);
            label2.Text = $"Teste totale\n{statistici.Item1}";
            label3.Text = $"Trecute\n{statistici.Item2}";
            label4.Text = $"Picate\n{statistici.Item3}";
        }

        private void IncarcaIstoricTeste()
        {
            var istoric = testService.GetIstoric(utilizatorCurent.Id);
            dgvIstoricTeste.Rows.Clear();
            dgvIstoricTeste.Columns.Clear();

            dgvIstoricTeste.Columns.Add("Data", "Data");
            dgvIstoricTeste.Columns.Add("Scor", "Scor");
            dgvIstoricTeste.Columns.Add("Timp", "Timp");
            dgvIstoricTeste.Columns.Add("Status", "Status");

            foreach (var r in istoric)
            {
                int minute = r.TimpSecunde / 60;
                int secunde = r.TimpSecunde % 60;
                dgvIstoricTeste.Rows.Add(
                    r.DataTest.ToString("dd MMM yyyy"),
                    $"{r.Scor}/26 corecte",
                    $"{minute:D2}:{secunde:D2}",
                    r.Promovat ? "Promovat" : "Respins"
                );
            }
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            new TestForm(utilizatorCurent, false).Show();
            this.Hide();
        }

        private void btnExamen_Click(object sender, EventArgs e)
        {
            var confirmare = MessageBox.Show(
                "Ești pregătit să începi examenul?\n26 întrebări · 30 minute · minim 22 corecte",
                "Confirmare examen",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirmare == DialogResult.Yes)
            {
                new TestForm(utilizatorCurent, true).Show();
                this.Hide();
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            var confirmare = MessageBox.Show(
                "Ești sigur că vrei să ieși?",
                "Confirmare",
                MessageBoxButtons.YesNo);

            if (confirmare == DialogResult.Yes)
            {
                new Autentificare().Show();
                this.Close();
            }
        }

        private void btnDarkMode_Click(object sender, EventArgs e)
        {
            isDarkMode = !isDarkMode;
            Color bg = isDarkMode ? Color.FromArgb(30, 30, 30) : Color.White;
            Color fg = isDarkMode ? Color.White : Color.Black;
            Color sidebar = isDarkMode ? Color.FromArgb(45, 45, 45) : Color.FromArgb(245, 245, 245);

            this.BackColor = bg;
            pnlSidebar.BackColor = sidebar;
            label1.ForeColor = fg;
            label2.ForeColor = fg;
            label3.ForeColor = fg;
            label4.ForeColor = fg;
            dgvIstoricTeste.BackgroundColor = bg;
            dgvIstoricTeste.DefaultCellStyle.BackColor = bg;
            dgvIstoricTeste.DefaultCellStyle.ForeColor = fg;

            btnDarkMode.Text = isDarkMode ? "☀ Light Mode" : "🌙 Dark Mode";
        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Button btnExamen;
        private System.Windows.Forms.DataGridView dgvIstoricTeste;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Button btnDarkMode;
        private System.Windows.Forms.Button btnIstoricTeste;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.Button btnStatistici;
        private System.Windows.Forms.Label label1;
    }
}