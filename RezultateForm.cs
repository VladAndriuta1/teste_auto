using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace teste_auto
{
    public class RezultateForm : Form
    {
        public RezultateForm()
        {
            this.Text = "Toate rezultatele";
            this.Size = new Size(1000, 650);
            this.BackColor = Color.FromArgb(232, 234, 240);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Load += RezultateForm_Load;
        }

        private void RezultateForm_Load(object sender, EventArgs e)
        {
            var pnlTop = new Panel();
            pnlTop.Dock = DockStyle.Top;
            pnlTop.Height = 60;
            pnlTop.BackColor = Color.FromArgb(24, 95, 165);

            var lblTitlu = new Label();
            lblTitlu.Text = "Toate rezultatele testelor";
            lblTitlu.Font = new Font("Segoe UI", 16, FontStyle.Bold);
            lblTitlu.ForeColor = Color.White;
            lblTitlu.AutoSize = true;
            lblTitlu.Location = new Point(20, 15);
            pnlTop.Controls.Add(lblTitlu);

            var dgv = new DataGridView();
            dgv.Dock = DockStyle.Fill;
            dgv.ReadOnly = true;
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToResizeRows = false;
            dgv.MultiSelect = false;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.BorderStyle = BorderStyle.None;
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv.GridColor = Color.FromArgb(200, 210, 230);
            dgv.RowTemplate.Height = 36;
            dgv.ColumnHeadersHeight = 40;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(12, 68, 124);
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.EnableHeadersVisualStyles = false;
            dgv.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgv.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(24, 95, 165);
            dgv.DefaultCellStyle.SelectionForeColor = Color.White;
            dgv.RowHeadersVisible = false;

            dgv.Columns.Add("Nr", "Nr.");
            dgv.Columns.Add("Candidat", "Candidat");
            dgv.Columns.Add("Tip", "Tip");
            dgv.Columns.Add("Scor", "Scor");
            dgv.Columns.Add("Timp", "Timp");
            dgv.Columns.Add("Data", "Data");
            dgv.Columns.Add("Status", "Rezultat");

            dgv.Columns["Nr"].FillWeight = 5;
            dgv.Columns["Candidat"].FillWeight = 20;
            dgv.Columns["Tip"].FillWeight = 10;
            dgv.Columns["Scor"].FillWeight = 10;
            dgv.Columns["Timp"].FillWeight = 10;
            dgv.Columns["Data"].FillWeight = 20;
            dgv.Columns["Status"].FillWeight = 15;

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
                    int rowIdx = dgv.Rows.Add(
                        nr++,
                        reader.GetString("candidat"),
                        tip,
                        $"{reader.GetInt32("scor")}/24",
                        timp > 0 ? $"{timp / 60:D2}:{timp % 60:D2}" : "—",
                        reader.GetDateTime("data_test").ToString("dd.MM.yyyy HH:mm"),
                        promovat ? "✅ Promovat" : "❌ Respins"
                    );
                    dgv.Rows[rowIdx].DefaultCellStyle.BackColor =
                        promovat ? Color.FromArgb(220, 242, 220) : Color.FromArgb(255, 235, 235);
                    dgv.Rows[rowIdx].DefaultCellStyle.ForeColor =
                        promovat ? Color.FromArgb(30, 120, 30) : Color.FromArgb(180, 30, 30);
                }
            }

            var pnlContent = new Panel();
            pnlContent.Dock = DockStyle.Fill;
            pnlContent.Padding = new Padding(15);
            pnlContent.Controls.Add(dgv);

            // Ordinea contează: Fill primul, Top al doilea
            this.Controls.Add(pnlContent);
            this.Controls.Add(pnlTop);
        }
    }
}