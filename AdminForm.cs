using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace teste_auto
{
    public partial class AdminForm : Form
    {
        private Utilizator utilizatorCurent;
        private bool isDarkMode = false;

        public AdminForm(Utilizator user)
        {
            InitializeComponent();
            utilizatorCurent = user;
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            lblSalut.Text = $"Bună ziua, {utilizatorCurent.Nume} {utilizatorCurent.Prenume}!";
            RoundCorners(pnlStat1, 12);
            RoundCorners(pnlStat2, 12);
            RoundCorners(pnlStat3, 12);
            RoundCorners(pnlStat4, 12);
            RoundCorners(btnDashboard, 8);
            RoundCorners(btnIntrebari, 8);
            RoundCorners(btnUtilizatori, 8);
            RoundCorners(btnRezultate, 8);
            RoundCorners(btnDarkMode, 8);
            RoundCorners(btnLogoutSidebar, 8);
            RoundCorners(btnAdaugaIntrebare, 8);
            RoundCorners(btnExport, 8);
            RoundCorners(btnGestionareUtil, 8);
            IncarcaDashboard();
        }

        private void IncarcaDashboard()
        {
            try
            {
                using (var con = DatabaseHelper.GetConnection())
                {
                    con.Open();

                    
                    var cmd1 = new MySqlCommand("SELECT COUNT(*) FROM utilizatori WHERE rol='candidat'", con);
                    lblStat1Num.Text = cmd1.ExecuteScalar().ToString();

                    
                    var cmd2 = new MySqlCommand("SELECT COUNT(*) FROM teste", con);
                    lblStat2Num.Text = cmd2.ExecuteScalar().ToString();

                   
                    var cmd3 = new MySqlCommand("SELECT ROUND(SUM(promovat)*100/COUNT(*),0) FROM teste", con);
                    var rata = cmd3.ExecuteScalar();
                    lblStat3Num.Text = (rata == DBNull.Value ? "0" : rata.ToString()) + "%";

                    
                    var cmd4 = new MySqlCommand("SELECT COUNT(*) FROM intrebari", con);
                    lblStat4Num.Text = cmd4.ExecuteScalar().ToString();
                }

                IncarcaUtilizatoriRecenti();
                IncarcaRezultateRecente();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la încărcarea datelor: " + ex.Message);
            }
        }

        private void IncarcaUtilizatoriRecenti()
        {
            dgvUtilizatori.Rows.Clear();
            dgvUtilizatori.Columns.Clear();
            dgvUtilizatori.Columns.Add("Nume", "Nume");
            dgvUtilizatori.Columns.Add("Prenume", "Prenume");
            dgvUtilizatori.Columns.Add("Email", "Email");
            dgvUtilizatori.Columns.Add("Rol", "Rol");

            using (var con = DatabaseHelper.GetConnection())
            {
                con.Open();
                string query = "SELECT nume, prenume, email, rol FROM utilizatori ORDER BY id DESC LIMIT 10";
                var cmd = new MySqlCommand(query, con);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    dgvUtilizatori.Rows.Add(
                        reader.GetString("nume"),
                        reader.GetString("prenume"),
                        reader.GetString("email"),
                        reader.GetString("rol")
                    );
                }
            }
        }

        private void IncarcaRezultateRecente()
        {
            dgvRezultate.Rows.Clear();
            dgvRezultate.Columns.Clear();
            dgvRezultate.Columns.Add("Candidat", "Candidat");
            dgvRezultate.Columns.Add("Scor", "Scor");
            dgvRezultate.Columns.Add("Data", "Data");
            dgvRezultate.Columns.Add("Status", "Status");

            using (var con = DatabaseHelper.GetConnection())
            {
                con.Open();
                string query = "SELECT CONCAT(u.nume, ' ', u.prenume) as candidat, " +
                               "t.scor, t.data_test, t.promovat " +
                               "FROM teste t JOIN utilizatori u ON t.id_utilizator = u.id " +
                               "ORDER BY t.data_test DESC LIMIT 10";
                var cmd = new MySqlCommand(query, con);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    dgvRezultate.Rows.Add(
                        reader.GetString("candidat"),
                        $"{reader.GetInt32("scor")}/24",
                        reader.GetDateTime("data_test").ToString("dd.MM.yyyy"),
                        reader.GetBoolean("promovat") ? "Promovat" : "Respins"
                    );
                }
            }
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            IncarcaDashboard();
        }

        private void btnIntrebari_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Modulul de gestionare a întrebărilor — în dezvoltare!",
                "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnUtilizatori_Click(object sender, EventArgs e)
        {
            IncarcaUtilizatoriRecenti();
            MessageBox.Show("Lista utilizatorilor a fost actualizată!",
                "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnRezultate_Click(object sender, EventArgs e)
        {
            IncarcaRezultateRecente();
            MessageBox.Show("Lista rezultatelor a fost actualizată!",
                "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnAdaugaIntrebare_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Modulul de adăugare întrebări — în dezvoltare!",
                "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            try
            {
                string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\rezultate_teste.csv";
                using (StreamWriter sw = new StreamWriter(path, false, System.Text.Encoding.UTF8))
                {
                    sw.WriteLine("Candidat,Scor,Data,Status");
                    using (var con = DatabaseHelper.GetConnection())
                    {
                        con.Open();
                        string query = "SELECT CONCAT(u.nume, ' ', u.prenume) as candidat, " +
                                       "t.scor, t.data_test, t.promovat " +
                                       "FROM teste t JOIN utilizatori u ON t.id_utilizator = u.id " +
                                       "ORDER BY t.data_test DESC";
                        var cmd = new MySqlCommand(query, con);
                        var reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            sw.WriteLine($"{reader.GetString("candidat")}," +
                                        $"{reader.GetInt32("scor")}/26," +
                                        $"{reader.GetDateTime("data_test"):dd.MM.yyyy}," +
                                        $"{(reader.GetBoolean("promovat") ? "Promovat" : "Respins")}");
                        }
                    }
                }
                MessageBox.Show($"Datele au fost exportate cu succes!\nFișier salvat pe Desktop: rezultate_teste.csv",
                    "Export reușit", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la export: " + ex.Message);
            }
        }

        private void btnGestionareUtil_Click(object sender, EventArgs e)
        {
            IncarcaUtilizatoriRecenti();
            MessageBox.Show("Utilizatorii au fost actualizați!",
                "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            var confirmare = MessageBox.Show("Ești sigur că vrei să ieși?", "Confirmare",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmare == DialogResult.Yes)
            {
                new Autentificare().Show();
                this.Close();
            }
        }

        private void btnDarkMode_Click(object sender, EventArgs e)
        {
            isDarkMode = !isDarkMode;
            Color bg = isDarkMode ? Color.FromArgb(30, 30, 30) : Color.FromArgb(232, 234, 240);
            Color fg = isDarkMode ? Color.White : Color.Black;
            Color sidebar = isDarkMode ? Color.FromArgb(20, 20, 20) : Color.FromArgb(12, 68, 124);

            this.BackColor = bg;
            pnlMain.BackColor = bg;
            pnlSidebar.BackColor = sidebar;
            lblSalut.ForeColor = Color.White;
            btnDarkMode.Text = isDarkMode ? "☀ Light Mode" : "🌙 Dark Mode";
        }

        [System.Runtime.InteropServices.DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern System.IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        private void RoundCorners(System.Windows.Forms.Control control, int radius)
        {
            control.Region = System.Drawing.Region.FromHrgn(
                CreateRoundRectRgn(0, 0, control.Width, control.Height, radius, radius));
        }
    }
}