using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace teste_auto
{
    public partial class TestelemeleForm : Form
    {
        private Utilizator utilizatorCurent;
        private DataGridView dgv;

        public TestelemeleForm(Utilizator user)
        {
            InitializeComponent();
            utilizatorCurent = user;
            this.Text = "Testele mele";
            this.Size = new Size(900, 600);
            this.BackColor = Color.FromArgb(232, 234, 240);
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void TestelemeleForm_Load(object sender, EventArgs e)
        {
            // Panel top (albastru ca in aplicatie)
            var pnlTop = new Panel();
            pnlTop.Dock = DockStyle.Top;
            pnlTop.Height = 70;
            pnlTop.BackColor = Color.FromArgb(24, 95, 165);

            var lblTitlu = new Label();
            lblTitlu.Text = $"Testele mele — {utilizatorCurent.Nume} {utilizatorCurent.Prenume}";
            lblTitlu.Font = new Font("Segoe UI", 16, FontStyle.Bold);
            lblTitlu.ForeColor = Color.White;
            lblTitlu.AutoSize = true;
            lblTitlu.Location = new Point(20, 18);
            pnlTop.Controls.Add(lblTitlu);

            // Panel continut
            var pnlContent = new Panel();
            pnlContent.Dock = DockStyle.Fill;
            pnlContent.BackColor = Color.FromArgb(232, 234, 240);
            pnlContent.Padding = new Padding(20);

            // DataGridView
            dgv = new DataGridView();
            dgv.Dock = DockStyle.Fill;
            dgv.ReadOnly = true;
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.AllowUserToResizeRows = false;
            dgv.MultiSelect = false;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.BorderStyle = BorderStyle.None;
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv.GridColor = Color.FromArgb(200, 210, 230);

            // Header styling
            dgv.ColumnHeadersHeight = 40;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(12, 68, 124);
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.EnableHeadersVisualStyles = false;

            // Row styling
            dgv.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgv.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(24, 95, 165);
            dgv.DefaultCellStyle.SelectionForeColor = Color.White;
            dgv.RowTemplate.Height = 36;

            // Coloane
            dgv.Columns.Add("Nr", "Nr.");
            dgv.Columns.Add("Data", "Data");
            dgv.Columns.Add("Tip", "Tip");
            dgv.Columns.Add("Scor", "Scor");
            dgv.Columns.Add("Timp", "Timp");
            dgv.Columns.Add("Status", "Rezultat");

            dgv.Columns["Nr"].FillWeight = 5;
            dgv.Columns["Data"].FillWeight = 20;
            dgv.Columns["Tip"].FillWeight = 15;
            dgv.Columns["Scor"].FillWeight = 15;
            dgv.Columns["Timp"].FillWeight = 15;
            dgv.Columns["Status"].FillWeight = 20;

            // Incarca datele
            IncarcaDate();

            // Coloreaza randurile
            dgv.RowPrePaint += (s, ev) => ev.PaintParts &= ~DataGridViewPaintParts.Focus;
            dgv.CellFormatting += Dgv_CellFormatting;

            pnlContent.Controls.Add(dgv);
            this.Controls.Add(pnlContent);
            this.Controls.Add(pnlTop);
        }

        private void IncarcaDate()
        {
            dgv.Rows.Clear();
            using (var con = DatabaseHelper.GetConnection())
            {
                con.Open();
                string query = "SELECT scor, timp_secunde, promovat, tip_test, data_test " +
                               "FROM teste WHERE id_utilizator = @id " +
                               "ORDER BY data_test DESC";
                var cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@id", utilizatorCurent.Id);
                var reader = cmd.ExecuteReader();

                int nr = 1;
                while (reader.Read())
                {
                    int scor = reader.GetInt32("scor");
                    int timp = reader.GetInt32("timp_secunde");
                    bool promovat = reader.GetBoolean("promovat");
                    string tip = reader.GetString("tip_test") == "examen" ? "Examen" : "Test";
                    DateTime data = reader.GetDateTime("data_test");

                    dgv.Rows.Add(
                        nr++,
                        data.ToString("dd.MM.yyyy HH:mm"),
                        tip,
                        $"{scor}/26",
                        timp > 0 ? $"{timp / 60:D2}:{timp % 60:D2}" : "—",
                        promovat ? "✅ Promovat" : "❌ Respins"
                    );
                }
            }
        }

        private void Dgv_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var row = dgv.Rows[e.RowIndex];
            string status = row.Cells["Status"].Value?.ToString() ?? "";

            if (status.Contains("Promovat"))
            {
                row.DefaultCellStyle.BackColor = Color.FromArgb(220, 242, 220);
                row.DefaultCellStyle.ForeColor = Color.FromArgb(30, 120, 30);
            }
            else
            {
                row.DefaultCellStyle.BackColor = Color.FromArgb(255, 235, 235);
                row.DefaultCellStyle.ForeColor = Color.FromArgb(180, 30, 30);
            }
        }
    }
}