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
                MessageBox.Show("Completați toate câmpurile!", "Eroare",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!email.Contains("@") || !email.Contains("."))
            {
                MessageBox.Show("Introduceți o adresă de email validă!", "Eroare",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (parola != confirma)
            {
                MessageBox.Show("Parolele nu coincid!", "Eroare",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (parola.Length < 6)
            {
                MessageBox.Show("Parola trebuie să aibă minim 6 caractere!", "Eroare",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (service.EmailExista(email))
            {
                MessageBox.Show("Acest email este deja înregistrat!", "Eroare",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool succes = service.Inregistreaza(nume, prenume, email, parola);
            if (succes)
            {
                MessageBox.Show("Cont creat cu succes! Vă puteți autentifica.", "Succes",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                new Autentificare().Show();
                this.Close();
            }
        }

        private void btnInapoi_Click(object sender, EventArgs e)
        {
            new Autentificare().Show();
            this.Close();
        }

        private void btnShowPass_Click(object sender, EventArgs e)
        {
            if (txtParola.PasswordChar == '*')
            {
                txtParola.PasswordChar = '\0';
                btnShowPass.Text = "🙈";
            }
            else
            {
                txtParola.PasswordChar = '*';
                btnShowPass.Text = "👁";
            }
        }

        private void btnShowConfirma_Click(object sender, EventArgs e)
        {
            if (txtConfirma.PasswordChar == '*')
            {
                txtConfirma.PasswordChar = '\0';
                btnShowConfirma.Text = "🙈";
            }
            else
            {
                txtConfirma.PasswordChar = '*';
                btnShowConfirma.Text = "👁";
            }
        }
    }
}