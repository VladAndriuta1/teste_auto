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
            new IntrebariForm().ShowDialog();
        }

        private void btnUtilizatori_Click(object sender, EventArgs e)
        {
            new UtilizatoriForm().ShowDialog();
        }

        private void btnRezultate_Click(object sender, EventArgs e)
        {
            new RezultateForm().ShowDialog();
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

            if (isDarkMode)
            {
                this.BackColor = System.Drawing.Color.FromArgb(18, 25, 38);
                pnlMain.BackColor = System.Drawing.Color.FromArgb(18, 25, 38);
                pnlSidebar.BackColor = System.Drawing.Color.FromArgb(10, 16, 28);
                pnlTop.BackColor = System.Drawing.Color.FromArgb(10, 16, 28);

                pnlStat1.BackColor = System.Drawing.Color.FromArgb(28, 38, 58);
                pnlStat2.BackColor = System.Drawing.Color.FromArgb(28, 38, 58);
                pnlStat3.BackColor = System.Drawing.Color.FromArgb(28, 38, 58);
                pnlStat4.BackColor = System.Drawing.Color.FromArgb(28, 38, 58);

                lblStat1Text.ForeColor = System.Drawing.Color.FromArgb(180, 200, 230);
                lblStat2Text.ForeColor = System.Drawing.Color.FromArgb(180, 200, 230);
                lblStat3Text.ForeColor = System.Drawing.Color.FromArgb(180, 200, 230);
                lblStat4Text.ForeColor = System.Drawing.Color.FromArgb(180, 200, 230);

                lblUtilizatori.ForeColor = System.Drawing.Color.FromArgb(180, 200, 230);
                lblRezultate.ForeColor = System.Drawing.Color.FromArgb(180, 200, 230);

                dgvUtilizatori.BackgroundColor = System.Drawing.Color.FromArgb(22, 32, 50);
                dgvUtilizatori.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(22, 32, 50);
                dgvUtilizatori.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(180, 200, 230);
                dgvUtilizatori.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(10, 16, 28);
                dgvUtilizatori.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;

                dgvRezultate.BackgroundColor = System.Drawing.Color.FromArgb(22, 32, 50);
                dgvRezultate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(22, 32, 50);
                dgvRezultate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(180, 200, 230);
                dgvRezultate.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(10, 16, 28);
                dgvRezultate.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;

                btnAdaugaIntrebare.BackColor = System.Drawing.Color.FromArgb(24, 95, 165);
                btnExport.BackColor = System.Drawing.Color.FromArgb(28, 38, 58);
                btnExport.ForeColor = System.Drawing.Color.FromArgb(100, 160, 240);
                btnGestionareUtil.BackColor = System.Drawing.Color.FromArgb(28, 38, 58);
                btnGestionareUtil.ForeColor = System.Drawing.Color.FromArgb(100, 160, 240);

                btnDarkMode.Text = "☀ Light Mode";
                btnDarkMode.ForeColor = System.Drawing.Color.FromArgb(255, 210, 100);
            }
            else
            {
                this.BackColor = System.Drawing.Color.FromArgb(232, 234, 240);
                pnlMain.BackColor = System.Drawing.Color.FromArgb(232, 234, 240);
                pnlSidebar.BackColor = System.Drawing.Color.FromArgb(12, 68, 124);
                pnlTop.BackColor = System.Drawing.Color.FromArgb(24, 95, 165);

                pnlStat1.BackColor = System.Drawing.Color.White;
                pnlStat2.BackColor = System.Drawing.Color.White;
                pnlStat3.BackColor = System.Drawing.Color.White;
                pnlStat4.BackColor = System.Drawing.Color.White;

                lblStat1Text.ForeColor = System.Drawing.Color.FromArgb(95, 94, 90);
                lblStat2Text.ForeColor = System.Drawing.Color.FromArgb(95, 94, 90);
                lblStat3Text.ForeColor = System.Drawing.Color.FromArgb(95, 94, 90);
                lblStat4Text.ForeColor = System.Drawing.Color.FromArgb(95, 94, 90);

                lblUtilizatori.ForeColor = System.Drawing.Color.FromArgb(12, 68, 124);
                lblRezultate.ForeColor = System.Drawing.Color.FromArgb(12, 68, 124);

                dgvUtilizatori.BackgroundColor = System.Drawing.Color.FromArgb(30, 58, 110);
                dgvUtilizatori.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(30, 58, 110);
                dgvUtilizatori.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
                dgvUtilizatori.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(12, 68, 124);
                dgvUtilizatori.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;

                dgvRezultate.BackgroundColor = System.Drawing.Color.FromArgb(30, 58, 110);
                dgvRezultate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(30, 58, 110);
                dgvRezultate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
                dgvRezultate.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(12, 68, 124);
                dgvRezultate.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;

                btnAdaugaIntrebare.BackColor = System.Drawing.Color.FromArgb(24, 95, 165);
                btnExport.BackColor = System.Drawing.Color.White;
                btnExport.ForeColor = System.Drawing.Color.FromArgb(24, 95, 165);
                btnGestionareUtil.BackColor = System.Drawing.Color.White;
                btnGestionareUtil.ForeColor = System.Drawing.Color.FromArgb(24, 95, 165);

                btnDarkMode.Text = "🌙 Dark Mode";
                btnDarkMode.ForeColor = System.Drawing.Color.FromArgb(133, 183, 235);
            }
        }
        private void IncarcaToateIntrebarile()
        {
            dgvUtilizatori.Rows.Clear();
            dgvUtilizatori.Columns.Clear();
            dgvUtilizatori.Columns.Add("Nr", "Nr.");
            dgvUtilizatori.Columns.Add("Intrebare", "Întrebare");
            dgvUtilizatori.Columns.Add("Categorie", "Categorie");
            dgvUtilizatori.Columns.Add("RaspA", "Varianta A");
            dgvUtilizatori.Columns.Add("RaspB", "Varianta B");
            dgvUtilizatori.Columns.Add("RaspC", "Varianta C");
            dgvUtilizatori.Columns.Add("Corect", "Răspuns corect");
            dgvUtilizatori.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRezultate.Rows.Clear();
            dgvRezultate.Columns.Clear();

            using (var con = DatabaseHelper.GetConnection())
            {
                con.Open();
                string query = "SELECT i.id, i.text_intrebare, c.nume_categorie " +
                               "FROM intrebari i JOIN categorii c ON i.id_categorie = c.id " +
                               "ORDER BY i.id";
                var cmd = new MySqlCommand(query, con);
                var reader = cmd.ExecuteReader();
                var intrebari = new System.Collections.Generic.List<(int id, string text, string cat)>();
                while (reader.Read())
                    intrebari.Add((reader.GetInt32("id"), reader.GetString("text_intrebare"), reader.GetString("nume_categorie")));
                reader.Close();

                int nr = 1;
                foreach (var intrebare in intrebari)
                {
                    string q2 = "SELECT text_raspuns, este_corect FROM raspunsuri WHERE id_intrebare=@id ORDER BY id";
                    var cmd2 = new MySqlCommand(q2, con);
                    cmd2.Parameters.AddWithValue("@id", intrebare.id);
                    var r2 = cmd2.ExecuteReader();
                    string[] variante = new string[3] { "", "", "" };
                    string corect = "";
                    int idx = 0;
                    while (r2.Read() && idx < 3)
                    {
                        variante[idx] = r2.GetString("text_raspuns");
                        if (r2.GetBoolean("este_corect"))
                            corect = new[] { "A", "B", "C" }[idx];
                        idx++;
                    }
                    r2.Close();
                    dgvUtilizatori.Rows.Add(nr++, intrebare.text, intrebare.cat,
                        variante[0], variante[1], variante[2], corect);
                }
            }
        }

        private void IncarcaTotiUtilizatorii()
        {
            dgvUtilizatori.Rows.Clear();
            dgvUtilizatori.Columns.Clear();
            dgvUtilizatori.Columns.Add("Nr", "Nr.");
            dgvUtilizatori.Columns.Add("Nume", "Nume");
            dgvUtilizatori.Columns.Add("Prenume", "Prenume");
            dgvUtilizatori.Columns.Add("Email", "Email");
            dgvUtilizatori.Columns.Add("Rol", "Rol");
            dgvUtilizatori.Columns.Add("DataInreg", "Data înregistrării");
            dgvUtilizatori.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRezultate.Rows.Clear();
            dgvRezultate.Columns.Clear();

            using (var con = DatabaseHelper.GetConnection())
            {
                con.Open();
                string query = "SELECT id, nume, prenume, email, rol, data_inregistrare FROM utilizatori ORDER BY id";
                var cmd = new MySqlCommand(query, con);
                var reader = cmd.ExecuteReader();
                int nr = 1;
                while (reader.Read())
                {
                    int rowIdx = dgvUtilizatori.Rows.Add(
                        nr++,
                        reader.GetString("nume"),
                        reader.GetString("prenume"),
                        reader.GetString("email"),
                        reader.GetString("rol"),
                        reader.GetDateTime("data_inregistrare").ToString("dd.MM.yyyy HH:mm")
                    );
                    dgvUtilizatori.Rows[rowIdx].DefaultCellStyle.BackColor =
                        reader.GetString("rol") == "admin"
                        ? Color.FromArgb(220, 230, 255)
                        : Color.White;
                }
            }
        }

        private void IncarcaToateRezultatele()
        {
            dgvRezultate.Rows.Clear();
            dgvRezultate.Columns.Clear();
            dgvRezultate.Columns.Add("Nr", "Nr.");
            dgvRezultate.Columns.Add("Candidat", "Candidat");
            dgvRezultate.Columns.Add("Tip", "Tip");
            dgvRezultate.Columns.Add("Scor", "Scor");
            dgvRezultate.Columns.Add("Timp", "Timp");
            dgvRezultate.Columns.Add("Data", "Data");
            dgvRezultate.Columns.Add("Status", "Status");
            dgvRezultate.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUtilizatori.Rows.Clear();
            dgvUtilizatori.Columns.Clear();

            using (var con = DatabaseHelper.GetConnection())
            {
                con.Open();
                string query = "SELECT CONCAT(u.nume, ' ', u.prenume) as candidat, " +
                               "t.scor, t.timp_secunde, t.promovat, t.tip_test, t.data_test " +
                               "FROM teste t JOIN utilizatori u ON t.id_utilizator = u.id " +
                               "ORDER BY t.data_test DESC";
                var cmd = new MySqlCommand(query, con);
                var reader = cmd.ExecuteReader();
                int nr = 1;
                while (reader.Read())
                {
                    int timp = reader.GetInt32("timp_secunde");
                    bool promovat = reader.GetBoolean("promovat");
                    string tip = reader.GetString("tip_test") == "examen" ? "Examen" : "Test";
                    int rowIdx = dgvRezultate.Rows.Add(
                        nr++,
                        reader.GetString("candidat"),
                        tip,
                        $"{reader.GetInt32("scor")}/26",
                        timp > 0 ? $"{timp / 60:D2}:{timp % 60:D2}" : "—",
                        reader.GetDateTime("data_test").ToString("dd.MM.yyyy HH:mm"),
                        promovat ? "✅ Promovat" : "❌ Respins"
                    );
                    dgvRezultate.Rows[rowIdx].DefaultCellStyle.BackColor =
                        promovat ? Color.FromArgb(220, 242, 220) : Color.FromArgb(255, 235, 235);
                    dgvRezultate.Rows[rowIdx].DefaultCellStyle.ForeColor =
                        promovat ? Color.FromArgb(30, 120, 30) : Color.FromArgb(180, 30, 30);
                }
            }
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