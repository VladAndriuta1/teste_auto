using System;
using System.Windows.Forms;

namespace teste_auto
{
    public partial class Autentificare : Form
    {
        private UtilizatorService service = new UtilizatorService();

        public Autentificare()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string parola = txtParola.Text.Trim();

            if (email == "" || parola == "")
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

            Utilizator user = service.Login(email, parola);

            if (user != null)
            {
                if (user.Rol == "admin")
                    new AdminForm(user).Show();
                else
                    new PaginaPrincipala(user).Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Email sau parolă incorectă!", "Autentificare eșuată",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnMergelaInregistrare_Click(object sender, EventArgs e)
        {
            new Inregistrare().Show();
            this.Hide();
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
    }
}