using System;
using System.Windows.Forms;

namespace teste_auto
{
    public partial class Inregistrare : Form
    {
        private UtilizatorService service = new UtilizatorService();

        public Inregistrare()
        {
            InitializeComponent();
        }

        private void btnInregistreaza_Click(object sender, EventArgs e)
        {
            string nume = txtNume.Text.Trim();
            string prenume = txtPrenume.Text.Trim();
            string email = txtEmail.Text.Trim();
            string parola = txtParola.Text.Trim();
            string confirma = txtConfirma.Text.Trim();

            if (nume == "" || prenume == "" || email == "" || parola == "")
            {
                MessageBox.Show("Completați toate câmpurile!");
                return;
            }

            if (parola != confirma)
            {
                MessageBox.Show("Parolele nu coincid!");
                return;
            }

            if (service.EmailExista(email))
            {
                MessageBox.Show("Acest email este deja înregistrat!");
                return;
            }

            bool succes = service.Inregistreaza(nume, prenume, email, parola);
            if (succes)
            {
                MessageBox.Show("Cont creat cu succes! Vă puteți autentifica.");
                this.Hide();
                new Autentificare().Show();
            }
        }

        private void btnInapoi_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Autentificare().Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}