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
                MessageBox.Show("Completați toate câmpurile!");
                return;
            }

            Utilizator user = service.Login(email, parola);

            if (user != null)
            {
                new PaginaPrincipala(user).Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Email sau parolă incorecte!");
            }
        }

        private void btnMergelaInregistrare_Click(object sender, EventArgs e)
        {
            Inregistrare register = new Inregistrare();
            register.Show();
            this.Hide();
        }

        private void Autentificare_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}