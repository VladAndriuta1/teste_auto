using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace teste_auto
{
    public partial class UtilizatoriForm : Form
    {
        private DataGridView dgv;

        public UtilizatoriForm()
        {
            InitializeComponent();
            this.Text = "Utilizatori";
            this.Size = new Size(900, 620);
            this.BackColor = Color.FromArgb(232, 234, 240);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Load += UtilizatoriForm_Load;
        }

        private void UtilizatoriForm_Load(object sender, EventArgs e)
        {
            // ── Panel top ─────────────────────────────────────────────
            var pnlTop = new Panel();
            pnlTop.Dock = DockStyle.Top;
            pnlTop.Height = 65;
            pnlTop.BackColor = Color.FromArgb(24, 95, 165);

            var lblTitlu = new Label();
            lblTitlu.Text = "Toți utilizatorii";
            lblTitlu.Font = new Font("Segoe UI", 16, FontStyle.Bold);
            lblTitlu.ForeColor = Color.White;
            lblTitlu.AutoSize = true;
            lblTitlu.Location = new Point(20, 18);
            pnlTop.Controls.Add(lblTitlu);

            // ── Bara de căutare ───────────────────────────────────────
            var pnlCautare = new Panel();
            pnlCautare.Dock = DockStyle.Top;
            pnlCautare.Height = 50;
            pnlCautare.BackColor = Color.FromArgb(232, 234, 240);
            pnlCautare.Padding = new Padding(15, 8, 15, 8);

            var lblCautare = new Label();
            lblCautare.Text = "🔍 Caută:";
            lblCautare.Font = new Font("Segoe UI", 10);
            lblCautare.Location = new Point(15, 14);
            lblCautare.AutoSize = true;

            var txtCautare = new TextBox();
            txtCautare.Font = new Font("Segoe UI", 10);
            txtCautare.Location = new Point(90, 11);
            txtCautare.Size = new Size(280, 28);

            var cmbFiltruRol = new ComboBox();
            cmbFiltruRol.Font = new Font("Segoe UI", 10);
            cmbFiltruRol.Location = new Point(390, 11);
            cmbFiltruRol.Size = new Size(130, 28);
            cmbFiltruRol.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFiltruRol.Items.AddRange(new object[] { "Toate", "candidat", "admin" });
            cmbFiltruRol.SelectedIndex = 0;

            var btnReset = new Button();
            btnReset.Text = "Reset";
            btnReset.Font = new Font("Segoe UI", 9);
            btnReset.BackColor = Color.FromArgb(108, 117, 125);
            btnReset.ForeColor = Color.White;
            btnReset.FlatStyle = FlatStyle.Flat;
            btnReset.FlatAppearance.BorderSize = 0;
            btnReset.Size = new Size(80, 30);
            btnReset.Location = new Point(535, 10);
            btnReset.Cursor = Cursors.Hand;

            pnlCautare.Controls.Add(lblCautare);
            pnlCautare.Controls.Add(txtCautare);
            pnlCautare.Controls.Add(cmbFiltruRol);
            pnlCautare.Controls.Add(btnReset);

            // ── DataGridView ──────────────────────────────────────────
            dgv = new DataGridView();
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
            dgv.Columns.Add("Nume", "Nume");
            dgv.Columns.Add("Prenume", "Prenume");
            dgv.Columns.Add("Email", "Email");
            dgv.Columns.Add("Rol", "Rol");
            dgv.Columns.Add("Data", "Data înregistrării");

            dgv.Columns["Nr"].FillWeight = 5;
            dgv.Columns["Nume"].FillWeight = 15;
            dgv.Columns["Prenume"].FillWeight = 15;
            dgv.Columns["Email"].FillWeight = 30;
            dgv.Columns["Rol"].FillWeight = 10;
            dgv.Columns["Data"].FillWeight = 20;

            // ── Evenimente căutare ────────────────────────────────────
            string placeholder = "Nume, prenume sau email...";

            txtCautare.Text = placeholder;
            txtCautare.ForeColor = Color.Gray;

            txtCautare.GotFocus += (s, ev) => {
                if (txtCautare.ForeColor == Color.Gray)
                {
                    txtCautare.Text = "";
                    txtCautare.ForeColor = Color.Black;
                }
            };

            txtCautare.LostFocus += (s, ev) => {
                if (string.IsNullOrWhiteSpace(txtCautare.Text))
                {
                    txtCautare.Text = placeholder;
                    txtCautare.ForeColor = Color.Gray;
                }
            };

            string GetTextCautare() =>
                txtCautare.ForeColor == Color.Gray ? "" : txtCautare.Text.Trim();

            btnReset.Click += (s, ev) =>
            {
                txtCautare.Text = placeholder;
                txtCautare.ForeColor = Color.Gray;
                cmbFiltruRol.SelectedIndex = 0;
                IncarcaUtilizatori("", "Toate");
            };

            txtCautare.TextChanged += (s, ev) =>
            {
                if (txtCautare.ForeColor != Color.Gray)
                    IncarcaUtilizatori(GetTextCautare(), cmbFiltruRol.SelectedItem.ToString());
            };

            cmbFiltruRol.SelectedIndexChanged += (s, ev) =>
                IncarcaUtilizatori(GetTextCautare(), cmbFiltruRol.SelectedItem.ToString());


            // ── Asamblare UI ──────────────────────────────────────────
            var pnlContent = new Panel();
            pnlContent.Dock = DockStyle.Fill;
            pnlContent.Padding = new Padding(15, 5, 15, 15);
            pnlContent.Controls.Add(dgv);

            this.Controls.Add(pnlContent);
            this.Controls.Add(pnlCautare);
            this.Controls.Add(pnlTop);

            IncarcaUtilizatori("", "Toate");
        }

        private void IncarcaUtilizatori(string cautare, string rol)
        {
            try
            {
                dgv.Rows.Clear();
                int nr = 1;

                using (var con = DatabaseHelper.GetConnection())
                {
                    con.Open();

                    string query = "SELECT id, nume, prenume, email, rol, data_inregistrare " +
                                   "FROM utilizatori WHERE 1=1";

                    if (!string.IsNullOrEmpty(cautare))
                        query += " AND (LOWER(nume) LIKE @cautare " +
                                 "OR LOWER(prenume) LIKE @cautare " +
                                 "OR LOWER(email) LIKE @cautare)";

                    if (rol != "Toate")
                        query += " AND rol = @rol";

                    query += " ORDER BY id";

                    var cmd = new MySqlCommand(query, con);

                    if (!string.IsNullOrEmpty(cautare))
                        cmd.Parameters.AddWithValue("@cautare", $"%{cautare.ToLower()}%");

                    if (rol != "Toate")
                        cmd.Parameters.AddWithValue("@rol", rol);

                    var reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        int rowIdx = dgv.Rows.Add(
                            nr++,
                            reader.GetString("nume"),
                            reader.GetString("prenume"),
                            reader.GetString("email"),
                            reader.GetString("rol"),
                            reader.GetDateTime("data_inregistrare").ToString("dd.MM.yyyy HH:mm")
                        );
                        dgv.Rows[rowIdx].DefaultCellStyle.BackColor =
                            reader.GetString("rol") == "admin"
                            ? Color.FromArgb(220, 230, 255)
                            : Color.White;
                    }
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la încărcarea utilizatorilor:\n" + ex.Message,
                    "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}