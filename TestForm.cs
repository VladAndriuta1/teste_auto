using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace teste_auto
{
    public partial class TestForm : Form
    {
        private Utilizator utilizatorCurent;
        private TestService testService = new TestService();
        private List<Intrebare> intrebari;
        private int indexCurent = 0;
        private int scor = 0;
        private int secundeRamase = 1800;
        private bool esteExamen;

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

            AfiseazaIntrebare();
        }

        private void AfiseazaIntrebare()
        {
            if (indexCurent >= intrebari.Count)
            {
                FinalizareTest();
                return;
            }

            var intrebare = intrebari[indexCurent];
            lblProgres.Text = $"Întrebarea {indexCurent + 1} din {intrebari.Count}";
            lblIntrebare.Text = intrebare.TextIntrebare;

            rbA.Checked = false;
            rbB.Checked = false;
            rbC.Checked = false;

            if (intrebare.Variante.Count >= 3)
            {
                rbA.Text = intrebare.Variante[0].TextRaspuns;
                rbB.Text = intrebare.Variante[1].TextRaspuns;
                rbC.Text = intrebare.Variante[2].TextRaspuns;
            }
        }

        private void btnUrmatoarea_Click(object sender, EventArgs e)
        {
            if (!rbA.Checked && !rbB.Checked && !rbC.Checked)
            {
                MessageBox.Show("Selectați un răspuns!", "Atenție",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var intrebare = intrebari[indexCurent];
            int indexSelectat = rbA.Checked ? 0 : rbB.Checked ? 1 : 2;

            if (intrebare.Variante[indexSelectat].EsteCorect)
                scor++;

            indexCurent++;
            AfiseazaIntrebare();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            secundeRamase--;
            int minute = secundeRamase / 60;
            int secunde = secundeRamase % 60;
            lblTimer.Text = $"⏱ {minute:D2}:{secunde:D2}";

            if (secundeRamase <= 60)
                lblTimer.ForeColor = Color.Red;

            if (secundeRamase <= 0)
                FinalizareTest();
        }

        private void FinalizareTest()
        {
            timer1.Stop();
            int timpTotal = esteExamen ? 1800 - secundeRamase : 0;
            testService.SalveazaRezultat(utilizatorCurent.Id, scor, timpTotal);

            bool promovat = scor >= 22;
            string status = promovat ? "✅ PROMOVAT" : "❌ RESPINS";
            string mesaj = $"{status}\n\nScor obținut: {scor}/{intrebari.Count}\n" +
                           (esteExamen ? $"Timp folosit: {timpTotal / 60:D2}:{timpTotal % 60:D2}" : "");

            MessageBox.Show(mesaj, "Rezultat test",
                MessageBoxButtons.OK,
                promovat ? MessageBoxIcon.Information : MessageBoxIcon.Warning);

            var paginaPrincipala = new PaginaPrincipala(utilizatorCurent);
            paginaPrincipala.Show();
            this.Close();
        }
    }
}