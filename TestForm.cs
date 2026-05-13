using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace teste_auto
{
    public partial class TestForm : Form
    {
        private Utilizator utilizatorCurent;
        private TestService testService = new TestService();
        private List<Intrebare> intrebari;
        private int indexCurent = 0;
        private int secundeRamase = 1800;
        private bool esteExamen;

        private List<Button> btnNavigare = new List<Button>();

        private readonly Color CuloareNeatins = Color.FromArgb(180, 180, 180);
        private readonly Color CuloareCorect = Color.FromArgb(40, 167, 69);
        private readonly Color CuloareGresit = Color.FromArgb(220, 53, 69);
        private readonly Color CuloareCurent = Color.FromArgb(24, 95, 165);

        public TestForm(Utilizator user, bool examen)
        {
            InitializeComponent();
            utilizatorCurent = user;
            esteExamen = examen;
        }

        private void TestForm_Load(object sender, EventArgs e)
        {
            intrebari = testService.GetIntrebariAleatorii();

            if (esteExamen)
            {
                lblTimer.Visible = true;
                timer1.Start();
                this.Text = "Examen simulat";
            }
            else
            {
                lblTimer.Visible = false;
                this.Text = "Test practică";
            }

            ConstruiesteNavigare();
            AfiseazaIntrebare();
        }

        private void ConstruiesteNavigare()
        {
            int btnSize = 34;
            int spacing = 3;

            for (int i = 0; i < intrebari.Count; i++)
            {
                int idx = i;
                var btn = new Button
                {
                    Size = new Size(btnSize, btnSize),
                    Location = new Point(i * (btnSize + spacing), 0),
                    Text = (i + 1).ToString(),
                    Font = new Font("Segoe UI", 8, FontStyle.Bold),
                    FlatStyle = FlatStyle.Flat,
                    BackColor = CuloareNeatins,
                    ForeColor = Color.White,
                    Cursor = Cursors.Hand,
                    TabStop = false
                };
                btn.FlatAppearance.BorderSize = 0;
                btn.Click += (s, ev) => NavigheazaLa(idx);
                pnlNavigare.Controls.Add(btn);
                btnNavigare.Add(btn);
            }
        }

        private void ActualizeazaNavigare()
        {
            for (int i = 0; i < intrebari.Count; i++)
            {
                var intr = intrebari[i];
                Color c;

                if (i == indexCurent)
                    c = CuloareCurent;
                else if (intr.RaspunsCorect == true)
                    c = CuloareCorect;
                else if (intr.RaspunsCorect == false)
                    c = CuloareGresit;
                else
                    c = CuloareNeatins;

                btnNavigare[i].BackColor = c;
            }
        }

        private void NavigheazaLa(int index)
        {
            SalveazaSelectieCurenta();
            indexCurent = index;
            AfiseazaIntrebare();
        }

        private void AfiseazaIntrebare()
        {
            if (indexCurent >= intrebari.Count) { FinalizareTest(); return; }

            var intr = intrebari[indexCurent];
            lblProgres.Text = $"Întrebarea {indexCurent + 1} din {intrebari.Count}";
            lblIntrebare.Text = intr.TextIntrebare;

            // Imagine
            if (!string.IsNullOrEmpty(intr.ImagineUrl))
            {
                string cale = Path.Combine(Application.StartupPath, "Images", intr.ImagineUrl);
                if (File.Exists(cale))
                {
                    picImagine.Image = Image.FromFile(cale);
                    picImagine.Visible = true;
                }
                else
                    picImagine.Visible = false;
            }
            else
            {
                picImagine.Visible = false;
                picImagine.Image = null;
            }

            // Restaurează selecția
            rbA.Checked = false;
            rbB.Checked = false;
            rbC.Checked = false;

            if (intr.Variante.Count >= 3)
            {
                rbA.Text = intr.Variante[0].TextRaspuns;
                rbB.Text = intr.Variante[1].TextRaspuns;
                rbC.Text = intr.Variante[2].TextRaspuns;

                if (intr.IndexRaspunsSelectat == 0) rbA.Checked = true;
                else if (intr.IndexRaspunsSelectat == 1) rbB.Checked = true;
                else if (intr.IndexRaspunsSelectat == 2) rbC.Checked = true;
            }

            // Dacă întrebarea e deja răspunsă, dezactivează radio-urile
            bool raspunsData = intr.RaspunsCorect != null;
            rbA.Enabled = !raspunsData;
            rbB.Enabled = !raspunsData;
            rbC.Enabled = !raspunsData;
            btnUrmatoarea.Enabled = !raspunsData;

            ActualizeazaNavigare();
        }

        private void SalveazaSelectieCurenta()
        {
            if (indexCurent >= intrebari.Count) return;
            var intr = intrebari[indexCurent];
            if (rbA.Checked) intr.IndexRaspunsSelectat = 0;
            else if (rbB.Checked) intr.IndexRaspunsSelectat = 1;
            else if (rbC.Checked) intr.IndexRaspunsSelectat = 2;
        }

        private bool ToateRaspunse()
        {
            foreach (var intr in intrebari)
                if (intr.RaspunsCorect == null) return false;
            return true;
        }

        private void GasesteUrmatoareaNeterminata()
        {
            // Caută de la indexCurent+1 înainte
            for (int i = indexCurent + 1; i < intrebari.Count; i++)
                if (intrebari[i].RaspunsCorect == null) { indexCurent = i; return; }

            // Dacă nu găsește, caută de la început
            for (int i = 0; i < indexCurent; i++)
                if (intrebari[i].RaspunsCorect == null) { indexCurent = i; return; }

            // Toate răspunse
            indexCurent = intrebari.Count;
        }

        private void btnUrmatoarea_Click(object sender, EventArgs e)
        {
            if (!rbA.Checked && !rbB.Checked && !rbC.Checked)
            {
                MessageBox.Show("Selectați un răspuns!", "Atenție",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var intr = intrebari[indexCurent];
            int idx = rbA.Checked ? 0 : rbB.Checked ? 1 : 2;
            intr.IndexRaspunsSelectat = idx;
            intr.RaspunsCorect = intr.Variante[idx].EsteCorect;

            if (ToateRaspunse())
                FinalizareTest();
            else
            {
                GasesteUrmatoareaNeterminata();
                AfiseazaIntrebare();
            }
        }

        private void btnAcasa_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(
                "Ești sigur că vrei să ieși? Progresul testului se va pierde.",
                "Ieșire", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                timer1.Stop();
                var pp = new PaginaPrincipala(utilizatorCurent);
                pp.Show();
                this.Close();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            secundeRamase--;
            int m = secundeRamase / 60;
            int s = secundeRamase % 60;
            lblTimer.Text = $"⏱ {m:D2}:{s:D2}";

            if (secundeRamase <= 60)
                lblTimer.ForeColor = Color.Red;

            if (secundeRamase <= 0)
                FinalizareTest();
        }

        private void FinalizareTest()
        {
            timer1.Stop();

            int scor = 0;
            foreach (var intr in intrebari)
                if (intr.RaspunsCorect == true) scor++;

            int timpTotal = esteExamen ? 1800 - secundeRamase : 0;
            string tipTest = esteExamen ? "examen" : "test";
            testService.SalveazaRezultat(utilizatorCurent.Id, scor, timpTotal, tipTest);

            bool promovat = scor >= 22;
            string status = promovat ? "✅ PROMOVAT" : "❌ RESPINS";
            string mesaj = $"{status}\n\nScor obținut: {scor}/{intrebari.Count}\n" +
                           (esteExamen ? $"Timp folosit: {timpTotal / 60:D2}:{timpTotal % 60:D2}" : "");

            MessageBox.Show(mesaj, "Rezultat test",
                MessageBoxButtons.OK,
                promovat ? MessageBoxIcon.Information : MessageBoxIcon.Warning);

            var pp = new PaginaPrincipala(utilizatorCurent);
            pp.Show();
            this.Close();
        }
    }
}