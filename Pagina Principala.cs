using System;
using System.Drawing;
using System.Windows.Forms;

namespace teste_auto
{

    public partial class PaginaPrincipala : Form
    {
        private Utilizator utilizatorCurent;
        private TestService testService = new TestService();
        private bool isDarkMode = false;

        public PaginaPrincipala(Utilizator user)
        {
            InitializeComponent();
            utilizatorCurent = user;
        }
        [System.Runtime.InteropServices.DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern System.IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        private void RoundCorners(System.Windows.Forms.Control control, int radius)
        {
            control.Region = System.Drawing.Region.FromHrgn(
                CreateRoundRectRgn(0, 0, control.Width, control.Height, radius, radius));
        }

        private void PaginaPrincipala_Load(object sender, EventArgs e)
        {
            lblSalut.Text = $"Bună ziua, {utilizatorCurent.Nume} {utilizatorCurent.Prenume}!";
            lblRol.Text = utilizatorCurent.Rol;
            IncarcaStatistici();
            IncarcaIstoricTeste();
            // Colturi rotunjite
            RoundCorners(pnlCardTotal, 12);
            RoundCorners(pnlCardPromovate, 12);
            RoundCorners(pnlCardRespinse, 12);
            RoundCorners(pnlTest, 12);
            RoundCorners(pnlExamen, 12);
            RoundCorners(btnStatistici, 8);
            RoundCorners(btnTestelemele, 8);
            RoundCorners(btnInfo, 8);
            RoundCorners(btnDarkMode, 8);
            RoundCorners(btnLogoutSidebar, 8);

            // Text mai lizibil in EXAMEN
            lblExamenDesc.ForeColor = System.Drawing.Color.White;
            lblExamenTimer.ForeColor = System.Drawing.Color.White;
            lblExamenTimer.Font = new System.Drawing.Font("Segoe UI", 12, System.Drawing.FontStyle.Bold);
        }

        private void IncarcaStatistici()
        {
            var statistici = testService.GetStatistici(utilizatorCurent.Id);
            lblTotalNum.Text = statistici.Item1.ToString();
            lblPromovateNum.Text = statistici.Item2.ToString();
            lblRespinseNum.Text = statistici.Item3.ToString();
        }

        private void IncarcaIstoricTeste()
        {
            var istoric = testService.GetIstoric(utilizatorCurent.Id);
            dgvIstoricTeste.Rows.Clear();
            dgvIstoricTeste.Columns.Clear();

            dgvIstoricTeste.Columns.Add("Data", "Data");
            dgvIstoricTeste.Columns.Add("Tip", "Tip");
            dgvIstoricTeste.Columns.Add("Scor", "Scor");
            dgvIstoricTeste.Columns.Add("Timp", "Timp");
            dgvIstoricTeste.Columns.Add("Status", "Status");

            foreach (var r in istoric)
            {
                int minute = r.TimpSecunde / 60;
                int secunde = r.TimpSecunde % 60;
                dgvIstoricTeste.Rows.Add(
                    r.DataTest.ToString("dd.MM.yyyy"),
                    r.TipTest == "examen" ? "Examen" : "Test",
                    $"{r.Scor}/24",
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
                "Ești pregătit să începi examenul?\n24 întrebări · 30 minute · minim 22 corecte",
                "Confirmare examen",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirmare == DialogResult.Yes)
            {
                new TestForm(utilizatorCurent, true).Show();
                this.Hide();
            }
        }

        private void btnDarkMode_Click(object sender, EventArgs e)
        {
            isDarkMode = !isDarkMode;

            if (isDarkMode)
            {
                // Dark mode - culori calde si placute
                this.BackColor = System.Drawing.Color.FromArgb(18, 25, 38);
                pnlMain.BackColor = System.Drawing.Color.FromArgb(18, 25, 38);
                pnlSidebar.BackColor = System.Drawing.Color.FromArgb(10, 16, 28);
                pnlTop.BackColor = System.Drawing.Color.FromArgb(10, 16, 28);

                pnlCardTotal.BackColor = System.Drawing.Color.FromArgb(28, 38, 58);
                pnlCardPromovate.BackColor = System.Drawing.Color.FromArgb(28, 38, 58);
                pnlCardRespinse.BackColor = System.Drawing.Color.FromArgb(28, 38, 58);

                pnlTest.BackColor = System.Drawing.Color.FromArgb(28, 38, 58);
                lblTestTitle.ForeColor = System.Drawing.Color.FromArgb(100, 160, 240);
                lblTestDesc.ForeColor = System.Drawing.Color.FromArgb(100, 160, 240);
                lblTestTimer.ForeColor = System.Drawing.Color.FromArgb(100, 160, 240);

                lblUltimele.ForeColor = System.Drawing.Color.FromArgb(180, 200, 230);
                //label1.ForeColor = System.Drawing.Color.White;

                dgvIstoricTeste.BackgroundColor = System.Drawing.Color.FromArgb(22, 32, 50);
                dgvIstoricTeste.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(22, 32, 50);
                dgvIstoricTeste.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(180, 200, 230);
                dgvIstoricTeste.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(10, 16, 28);
                dgvIstoricTeste.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;

                btnDarkMode.Text = "☀ Light Mode";
                btnDarkMode.ForeColor = System.Drawing.Color.FromArgb(255, 210, 100);
            }
            else
            {
                // Light mode
                this.BackColor = System.Drawing.Color.FromArgb(232, 234, 240);
                pnlMain.BackColor = System.Drawing.Color.FromArgb(232, 234, 240);
                pnlSidebar.BackColor = System.Drawing.Color.FromArgb(12, 68, 124);
                pnlTop.BackColor = System.Drawing.Color.FromArgb(24, 95, 165);

                pnlCardTotal.BackColor = System.Drawing.Color.White;
                pnlCardPromovate.BackColor = System.Drawing.Color.White;
                pnlCardRespinse.BackColor = System.Drawing.Color.White;

                pnlTest.BackColor = System.Drawing.Color.FromArgb(238, 242, 255);
                lblTestTitle.ForeColor = System.Drawing.Color.FromArgb(24, 95, 165);
                lblTestDesc.ForeColor = System.Drawing.Color.FromArgb(24, 95, 165);
                lblTestTimer.ForeColor = System.Drawing.Color.FromArgb(24, 95, 165);

                lblUltimele.ForeColor = System.Drawing.Color.FromArgb(44, 44, 42);
                //label1.ForeColor = System.Drawing.Color.White;

                dgvIstoricTeste.BackgroundColor = System.Drawing.Color.FromArgb(30, 58, 110);
                dgvIstoricTeste.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(30, 58, 110);
                dgvIstoricTeste.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
                dgvIstoricTeste.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(12, 68, 124);
                dgvIstoricTeste.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;

                btnDarkMode.Text = "🌙 Dark Mode";
                btnDarkMode.ForeColor = System.Drawing.Color.FromArgb(133, 183, 235);
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

        private void btnStatistici_Click(object sender, EventArgs e)
        {
            // Reincarca statisticile si istoricul
            IncarcaStatistici();
            IncarcaIstoricTeste();
            MessageBox.Show("Statisticile au fost actualizate!", "Info",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnTestelemele_Click(object sender, EventArgs e)
        {
            new TestelemeleForm(utilizatorCurent).ShowDialog();
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Informații utile pentru examenul auto:\n\n" +
                "✔ Examenul conține 24 de întrebări\n" +
                "✔ Timpul alocat este de 30 de minute\n" +
                "✔ Sunt necesare minim 22 răspunsuri corecte\n" +
                "✔ Categorii: Indicatoare, Reguli, Manevre,\n   Situații de urgență, Legislație\n\n" +
                "Mult succes la examen!",
                "Informații utile",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
}