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
    }
}