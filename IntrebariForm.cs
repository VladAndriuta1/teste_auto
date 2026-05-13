using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace teste_auto
{
    public class IntrebariForm : Form
    {
        private DataGridView dgv;
        private int idIntrebareSelectata = -1;

        public IntrebariForm()
        {
            this.Text = "Întrebări";
            this.Size = new Size(1200, 720);
            this.BackColor = Color.FromArgb(232, 234, 240);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Load += IntrebariForm_Load;
        }

        private void IntrebariForm_Load(object sender, EventArgs e)
        {
            // ── Panel top ─────────────────────────────────────────────
            var pnlTop = new Panel();
            pnlTop.Dock = DockStyle.Top;
            pnlTop.Height = 65;
            pnlTop.BackColor = Color.FromArgb(24, 95, 165);

            var lblTitlu = new Label();
            lblTitlu.Text = "Banca de întrebări";
            lblTitlu.Font = new Font("Segoe UI", 16, FontStyle.Bold);
            lblTitlu.ForeColor = Color.White;
            lblTitlu.AutoSize = true;
            lblTitlu.Location = new Point(20, 18);
            pnlTop.Controls.Add(lblTitlu);

            // Butoane CRUD în top-right
            var btnAdauga = CreeazaBtnTop("+ Adaugă", Color.FromArgb(40, 167, 69), 700);
            var btnEditeaza = CreeazaBtnTop("✎ Editează", Color.FromArgb(24, 95, 165), 830);
            var btnSterge = CreeazaBtnTop("🗑 Șterge", Color.FromArgb(220, 53, 69), 960);

            btnAdauga.Click += (s, ev) => AdaugaIntrebare();
            btnEditeaza.Click += (s, ev) => EditeazaIntrebare();
            btnSterge.Click += (s, ev) => StergeIntrebare();

            pnlTop.Controls.Add(btnAdauga);
            pnlTop.Controls.Add(btnEditeaza);
            pnlTop.Controls.Add(btnSterge);

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
            dgv.RowTemplate.Height = 42;
            dgv.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgv.ColumnHeadersHeight = 44;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(12, 68, 124);
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.EnableHeadersVisualStyles = false;
            dgv.DefaultCellStyle.Font = new Font("Segoe UI", 9);
            dgv.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgv.DefaultCellStyle.Padding = new Padding(4, 0, 4, 0);
            dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(24, 95, 165);
            dgv.DefaultCellStyle.SelectionForeColor = Color.White;
            dgv.RowHeadersVisible = false;

            // Coloana ascunsă pentru ID
            var colId = new DataGridViewTextBoxColumn();
            colId.Name = "Id";
            colId.Visible = false;
            dgv.Columns.Add(colId);

            dgv.Columns.Add("Nr", "Nr.");
            dgv.Columns.Add("Intrebare", "Întrebare");
            dgv.Columns.Add("Categorie", "Categorie");

            var colA = new DataGridViewTextBoxColumn { Name = "RaspA", HeaderText = "Varianta A" };
            var colB = new DataGridViewTextBoxColumn { Name = "RaspB", HeaderText = "Varianta B" };
            var colC = new DataGridViewTextBoxColumn { Name = "RaspC", HeaderText = "Varianta C" };
            colA.DefaultCellStyle.BackColor = Color.FromArgb(245, 250, 255);
            colB.DefaultCellStyle.BackColor = Color.FromArgb(245, 250, 255);
            colC.DefaultCellStyle.BackColor = Color.FromArgb(245, 250, 255);
            dgv.Columns.Add(colA);
            dgv.Columns.Add(colB);
            dgv.Columns.Add(colC);

            dgv.Columns["Nr"].FillWeight = 4;
            dgv.Columns["Intrebare"].FillWeight = 25;
            dgv.Columns["Categorie"].FillWeight = 13;
            dgv.Columns["RaspA"].FillWeight = 17;
            dgv.Columns["RaspB"].FillWeight = 17;
            dgv.Columns["RaspC"].FillWeight = 17;

            dgv.SelectionChanged += (s, ev) =>
            {
                if (dgv.SelectedRows.Count > 0)
                    idIntrebareSelectata = Convert.ToInt32(dgv.SelectedRows[0].Cells["Id"].Value);
            };

            IncarcaDate();

            var pnlContent = new Panel();
            pnlContent.Dock = DockStyle.Fill;
            pnlContent.Padding = new Padding(15);
            pnlContent.Controls.Add(dgv);

            this.Controls.Add(pnlContent);
            this.Controls.Add(pnlTop);
        }

        private Button CreeazaBtnTop(string text, Color culoare, int x)
        {
            var btn = new Button();
            btn.Text = text;
            btn.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            btn.BackColor = culoare;
            btn.ForeColor = Color.White;
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.Size = new Size(120, 36);
            btn.Location = new Point(x, 14);
            btn.Cursor = Cursors.Hand;
            return btn;
        }

        private void IncarcaDate()
        {
            dgv.Rows.Clear();
            int nr = 1;

            using (var con = DatabaseHelper.GetConnection())
            {
                con.Open();
                string query = "SELECT i.id, i.text_intrebare, c.nume_categorie " +
                               "FROM intrebari i JOIN categorii c ON i.id_categorie = c.id " +
                               "ORDER BY i.id";
                var cmd = new MySqlCommand(query, con);
                var reader = cmd.ExecuteReader();
                var list = new System.Collections.Generic.List<(int id, string text, string cat)>();
                while (reader.Read())
                    list.Add((reader.GetInt32("id"), reader.GetString("text_intrebare"), reader.GetString("nume_categorie")));
                reader.Close();

                foreach (var item in list)
                {
                    var cmd2 = new MySqlCommand(
                    "SELECT text_raspuns, este_corect FROM raspunsuri WHERE id_intrebare=@id ORDER BY RAND()", con);
                    cmd2.Parameters.AddWithValue("@id", item.id);
                    var r2 = cmd2.ExecuteReader();

                    string[] v = { "", "", "" };
                    bool[] corect = { false, false, false };
                    int idx = 0;
                    while (r2.Read() && idx < 3)
                    {
                        v[idx] = r2.GetString("text_raspuns");
                        corect[idx] = r2.GetBoolean("este_corect");
                        idx++;
                    }
                    r2.Close();

                    int rowIdx = dgv.Rows.Add(item.id, nr, item.text, item.cat, v[0], v[1], v[2]);

                    dgv.Rows[rowIdx].DefaultCellStyle.BackColor = nr % 2 == 0
                        ? Color.FromArgb(240, 245, 255) : Color.White;

                    string coloanaCorecta = corect[0] ? "RaspA" : corect[1] ? "RaspB" : "RaspC";
                    dgv.Rows[rowIdx].Cells[coloanaCorecta].Style.BackColor = Color.FromArgb(200, 240, 200);
                    dgv.Rows[rowIdx].Cells[coloanaCorecta].Style.ForeColor = Color.FromArgb(20, 100, 20);
                    dgv.Rows[rowIdx].Cells[coloanaCorecta].Style.Font = new Font("Segoe UI", 9, FontStyle.Bold);

                    nr++;
                }
            }
        }
        private void AdaugaIntrebare()
        {
            var form = new IntrebareEditForm(0);
            if (form.ShowDialog() == DialogResult.OK)
                IncarcaDate();
        }

        private void EditeazaIntrebare()
        {
            if (idIntrebareSelectata <= 0)
            {
                MessageBox.Show("Selectați o întrebare din listă!", "Atenție",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var form = new IntrebareEditForm(idIntrebareSelectata);
            if (form.ShowDialog() == DialogResult.OK)
                IncarcaDate();
        }

        private void StergeIntrebare()
        {
            if (idIntrebareSelectata <= 0)
            {
                MessageBox.Show("Selectați o întrebare din listă!", "Atenție",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirm = MessageBox.Show(
                "Ești sigur că vrei să ștergi această întrebare?\nToate răspunsurile asociate vor fi șterse.",
                "Confirmare ștergere", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirm != DialogResult.Yes) return;

            try
            {
                using (var con = DatabaseHelper.GetConnection())
                {
                    con.Open();

                    var cmd1 = new MySqlCommand("DELETE FROM raspunsuri WHERE id_intrebare=@id", con);
                    cmd1.Parameters.AddWithValue("@id", idIntrebareSelectata);
                    cmd1.ExecuteNonQuery();

                    var cmd2 = new MySqlCommand("DELETE FROM intrebari WHERE id=@id", con);
                    cmd2.Parameters.AddWithValue("@id", idIntrebareSelectata);
                    cmd2.ExecuteNonQuery();
                }

                idIntrebareSelectata = -1;
                IncarcaDate();
                MessageBox.Show("Întrebarea a fost ștearsă.", "Succes",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la ștergere: " + ex.Message, "Eroare",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}