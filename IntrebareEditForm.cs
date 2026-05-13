using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace teste_auto
{
    public partial class IntrebareEditForm : Form
    {
        private int idIntrebare;
        private TextBox txtIntrebare;
        private ComboBox cmbCategorie;
        private TextBox txtA, txtB, txtC;
        private RadioButton rbA, rbB, rbC;

        public IntrebareEditForm(int id)
        {
            idIntrebare = id;
            this.Text = id == 0 ? "Adaugă întrebare" : "Editează întrebare";
            this.Size = new Size(600, 500);
            this.BackColor = Color.FromArgb(232, 234, 240);
            this.StartPosition = FormStartPosition.CenterParent;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;

            ConstruiesteUI();
            if (id > 0) IncarcaDate();
        }

        private void ConstruiesteUI()
        {
            // Header
            var pnlTop = new Panel
            {
                Dock = DockStyle.Top,
                Height = 55,
                BackColor = Color.FromArgb(24, 95, 165)
            };
            var lblTitlu = new Label
            {
                Text = this.Text,
                Font = new Font("Segoe UI", 14, FontStyle.Bold),
                ForeColor = Color.White,
                AutoSize = true,
                Location = new Point(20, 14)
            };
            pnlTop.Controls.Add(lblTitlu);

            int y = 75,  ctrl_x = 150, ctrl_w = 410;

            // Întrebare
            AdeaugaLabel("Întrebare:", y);
            txtIntrebare = new TextBox
            {
                Location = new Point(ctrl_x, y),
                Size = new Size(ctrl_w, 60),
                Multiline = true,
                Font = new Font("Segoe UI", 10)
            };
            y += 75;

            // Categorie
            AdeaugaLabel("Categorie:", y);
            cmbCategorie = new ComboBox
            {
                Location = new Point(ctrl_x, y),
                Size = new Size(ctrl_w, 30),
                Font = new Font("Segoe UI", 10),
                DropDownStyle = ComboBoxStyle.DropDownList
            };
            IncarcaCategorii();
            y += 45;

            // Variante
            AdeaugaLabel("Varianta A:", y);
            txtA = new TextBox
            {
                Location = new Point(ctrl_x, y),
                Size = new Size(ctrl_w - 40, 28),
                Font = new Font("Segoe UI", 10)
            };
            rbA = new RadioButton
            {
                Location = new Point(ctrl_x + ctrl_w - 30, y + 4),
                Size = new Size(30, 20),
                Text = ""
            };
            y += 40;

            AdeaugaLabel("Varianta B:", y);
            txtB = new TextBox
            {
                Location = new Point(ctrl_x, y),
                Size = new Size(ctrl_w - 40, 28),
                Font = new Font("Segoe UI", 10)
            };
            rbB = new RadioButton
            {
                Location = new Point(ctrl_x + ctrl_w - 30, y + 4),
                Size = new Size(30, 20),
                Text = ""
            };
            y += 40;

            AdeaugaLabel("Varianta C:", y);
            txtC = new TextBox
            {
                Location = new Point(ctrl_x, y),
                Size = new Size(ctrl_w - 40, 28),
                Font = new Font("Segoe UI", 10)
            };
            rbC = new RadioButton
            {
                Location = new Point(ctrl_x + ctrl_w - 30, y + 4),
                Size = new Size(30, 20),
                Text = ""
            };
            y += 55;

            // Legendă radio
            var lblRasp = new Label
            {
                Text = "● = Răspuns corect",
                Font = new Font("Segoe UI", 9, FontStyle.Italic),
                ForeColor = Color.FromArgb(40, 167, 69),
                Location = new Point(ctrl_x, y - 10),
                AutoSize = true
            };

            // Butoane
            var btnSalveaza = new Button
            {
                Text = "💾 Salvează",
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                BackColor = Color.FromArgb(24, 95, 165),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Size = new Size(150, 40),
                Location = new Point(ctrl_x, y + 10),
                Cursor = Cursors.Hand
            };
            btnSalveaza.FlatAppearance.BorderSize = 0;
            btnSalveaza.Click += BtnSalveaza_Click;

            var btnAnuleaza = new Button
            {
                Text = "Anulează",
                Font = new Font("Segoe UI", 10),
                BackColor = Color.FromArgb(108, 117, 125),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Size = new Size(120, 40),
                Location = new Point(ctrl_x + 165, y + 10),
                Cursor = Cursors.Hand
            };
            btnAnuleaza.FlatAppearance.BorderSize = 0;
            btnAnuleaza.Click += (s, e) => { this.DialogResult = DialogResult.Cancel; this.Close(); };

            this.Controls.Add(pnlTop);
            this.Controls.Add(txtIntrebare);
            this.Controls.Add(cmbCategorie);
            this.Controls.Add(txtA); this.Controls.Add(rbA);
            this.Controls.Add(txtB); this.Controls.Add(rbB);
            this.Controls.Add(txtC); this.Controls.Add(rbC);
            this.Controls.Add(lblRasp);
            this.Controls.Add(btnSalveaza);
            this.Controls.Add(btnAnuleaza);
        }

        private void AdeaugaLabel(string text, int y)
        {
            var lbl = new Label
            {
                Text = text,
                Font = new Font("Segoe UI", 10),
                Location = new Point(20, y + 4),
                AutoSize = true
            };
            this.Controls.Add(lbl);
        }

        private void IncarcaCategorii()
        {
            using (var con = DatabaseHelper.GetConnection())
            {
                con.Open();
                var cmd = new MySqlCommand("SELECT id, nume_categorie FROM categorii ORDER BY id", con);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                    cmbCategorie.Items.Add(new CategorieItem(reader.GetInt32("id"), reader.GetString("nume_categorie")));
            }
            if (cmbCategorie.Items.Count > 0) cmbCategorie.SelectedIndex = 0;
        }

        private void IncarcaDate()
        {
            using (var con = DatabaseHelper.GetConnection())
            {
                con.Open();
                var cmd = new MySqlCommand(
                    "SELECT i.text_intrebare, i.id_categorie FROM intrebari i WHERE i.id=@id", con);
                cmd.Parameters.AddWithValue("@id", idIntrebare);
                var reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    txtIntrebare.Text = reader.GetString("text_intrebare");
                    int idCat = reader.GetInt32("id_categorie");
                    foreach (CategorieItem item in cmbCategorie.Items)
                        if (item.Id == idCat) { cmbCategorie.SelectedItem = item; break; }
                }
                reader.Close();

                var cmd2 = new MySqlCommand(
                    "SELECT text_raspuns, este_corect FROM raspunsuri WHERE id_intrebare=@id ORDER BY id", con);
                cmd2.Parameters.AddWithValue("@id", idIntrebare);
                var r2 = cmd2.ExecuteReader();
                int idx = 0;
                while (r2.Read() && idx < 3)
                {
                    string text = r2.GetString("text_raspuns");
                    bool corect = r2.GetBoolean("este_corect");
                    if (idx == 0) { txtA.Text = text; if (corect) rbA.Checked = true; }
                    else if (idx == 1) { txtB.Text = text; if (corect) rbB.Checked = true; }
                    else { txtC.Text = text; if (corect) rbC.Checked = true; }
                    idx++;
                }
            }
        }

        private void BtnSalveaza_Click(object sender, EventArgs e)
        {
            // Validare
            if (string.IsNullOrWhiteSpace(txtIntrebare.Text) ||
                string.IsNullOrWhiteSpace(txtA.Text) ||
                string.IsNullOrWhiteSpace(txtB.Text) ||
                string.IsNullOrWhiteSpace(txtC.Text))
            {
                MessageBox.Show("Completați toate câmpurile!", "Atenție",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!rbA.Checked && !rbB.Checked && !rbC.Checked)
            {
                MessageBox.Show("Selectați răspunsul corect (butonul radio ●)!", "Atenție",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idCategorie = ((CategorieItem)cmbCategorie.SelectedItem).Id;
            bool[] corect = { rbA.Checked, rbB.Checked, rbC.Checked };
            string[] variante = { txtA.Text.Trim(), txtB.Text.Trim(), txtC.Text.Trim() };

            try
            {
                using (var con = DatabaseHelper.GetConnection())
                {
                    con.Open();

                    if (idIntrebare == 0)
                    {
                        // INSERT
                        var cmd = new MySqlCommand(
                            "INSERT INTO intrebari (text_intrebare, id_categorie) VALUES (@text, @cat)", con);
                        cmd.Parameters.AddWithValue("@text", txtIntrebare.Text.Trim());
                        cmd.Parameters.AddWithValue("@cat", idCategorie);
                        cmd.ExecuteNonQuery();
                        idIntrebare = (int)cmd.LastInsertedId;
                    }
                    else
                    {
                        // UPDATE
                        var cmd = new MySqlCommand(
                            "UPDATE intrebari SET text_intrebare=@text, id_categorie=@cat WHERE id=@id", con);
                        cmd.Parameters.AddWithValue("@text", txtIntrebare.Text.Trim());
                        cmd.Parameters.AddWithValue("@cat", idCategorie);
                        cmd.Parameters.AddWithValue("@id", idIntrebare);
                        cmd.ExecuteNonQuery();

                        // Șterge răspunsurile vechi
                        var del = new MySqlCommand("DELETE FROM raspunsuri WHERE id_intrebare=@id", con);
                        del.Parameters.AddWithValue("@id", idIntrebare);
                        del.ExecuteNonQuery();
                    }

                    // Inserează răspunsurile
                    for (int i = 0; i < 3; i++)
                    {
                        var cmdR = new MySqlCommand(
                            "INSERT INTO raspunsuri (id_intrebare, text_raspuns, este_corect) VALUES (@id, @text, @corect)", con);
                        cmdR.Parameters.AddWithValue("@id", idIntrebare);
                        cmdR.Parameters.AddWithValue("@text", variante[i]);
                        cmdR.Parameters.AddWithValue("@corect", corect[i] ? 1 : 0);
                        cmdR.ExecuteNonQuery();
                    }
                }

                MessageBox.Show(idIntrebare == 0 ? "Întrebare adăugată!" : "Întrebare actualizată!",
                    "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare: " + ex.Message, "Eroare",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

    // Clasă helper pentru ComboBox
    public class CategorieItem
    {
        public int Id { get; }
        public string Nume { get; }
        public CategorieItem(int id, string nume) { Id = id; Nume = nume; }
        public override string ToString() => Nume;
    }
}