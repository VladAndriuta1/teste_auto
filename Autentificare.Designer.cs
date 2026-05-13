namespace teste_auto
{
    partial class Autentificare
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblTitlu = new System.Windows.Forms.Label();
            this.lblSubtitlu = new System.Windows.Forms.Label();
            this.pnlForm = new System.Windows.Forms.Panel();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblParola = new System.Windows.Forms.Label();
            this.txtParola = new System.Windows.Forms.TextBox();
            this.btnShowPass = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnMergelaInregistrare = new System.Windows.Forms.Button();
            this.pnlTop.SuspendLayout();
            this.pnlForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(95)))), ((int)(((byte)(165)))));
            this.pnlTop.Controls.Add(this.lblTitlu);
            this.pnlTop.Controls.Add(this.lblSubtitlu);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(420, 130);
            this.pnlTop.TabIndex = 0;
            // 
            // lblTitlu
            // 
            this.lblTitlu.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitlu.ForeColor = System.Drawing.Color.White;
            this.lblTitlu.Location = new System.Drawing.Point(0, 25);
            this.lblTitlu.Name = "lblTitlu";
            this.lblTitlu.Size = new System.Drawing.Size(420, 45);
            this.lblTitlu.TabIndex = 0;
            this.lblTitlu.Text = "Bun venit!";
            this.lblTitlu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSubtitlu
            // 
            this.lblSubtitlu.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSubtitlu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(212)))), ((int)(((byte)(244)))));
            this.lblSubtitlu.Location = new System.Drawing.Point(0, 75);
            this.lblSubtitlu.Name = "lblSubtitlu";
            this.lblSubtitlu.Size = new System.Drawing.Size(420, 30);
            this.lblSubtitlu.TabIndex = 1;
            this.lblSubtitlu.Text = "Autentifică-te pentru a continua";
            this.lblSubtitlu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlForm
            // 
            this.pnlForm.BackColor = System.Drawing.Color.White;
            this.pnlForm.Controls.Add(this.lblEmail);
            this.pnlForm.Controls.Add(this.txtEmail);
            this.pnlForm.Controls.Add(this.lblParola);
            this.pnlForm.Controls.Add(this.txtParola);
            this.pnlForm.Controls.Add(this.btnShowPass);
            this.pnlForm.Location = new System.Drawing.Point(30, 155);
            this.pnlForm.Name = "pnlForm";
            this.pnlForm.Size = new System.Drawing.Size(360, 245);
            this.pnlForm.TabIndex = 1;
            // 
            // lblEmail
            // 
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(68)))), ((int)(((byte)(124)))));
            this.lblEmail.Location = new System.Drawing.Point(25, 25);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(310, 22);
            this.lblEmail.TabIndex = 0;
            this.lblEmail.Text = "Email:";
            // 
            // txtEmail
            // 
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtEmail.Location = new System.Drawing.Point(25, 50);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(310, 32);
            this.txtEmail.TabIndex = 1;
            // 
            // lblParola
            // 
            this.lblParola.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblParola.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(68)))), ((int)(((byte)(124)))));
            this.lblParola.Location = new System.Drawing.Point(25, 105);
            this.lblParola.Name = "lblParola";
            this.lblParola.Size = new System.Drawing.Size(310, 22);
            this.lblParola.TabIndex = 2;
            this.lblParola.Text = "Parolă:";
            // 
            // txtParola
            // 
            this.txtParola.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtParola.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtParola.Location = new System.Drawing.Point(25, 130);
            this.txtParola.Name = "txtParola";
            this.txtParola.PasswordChar = '*';
            this.txtParola.Size = new System.Drawing.Size(280, 32);
            this.txtParola.TabIndex = 3;
            // 
            // btnShowPass
            // 
            this.btnShowPass.BackColor = System.Drawing.Color.White;
            this.btnShowPass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowPass.FlatAppearance.BorderSize = 0;
            this.btnShowPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowPass.Location = new System.Drawing.Point(308, 130);
            this.btnShowPass.Name = "btnShowPass";
            this.btnShowPass.Size = new System.Drawing.Size(30, 30);
            this.btnShowPass.TabIndex = 4;
            this.btnShowPass.Text = "👁";
            this.btnShowPass.UseVisualStyleBackColor = false;
            this.btnShowPass.Click += new System.EventHandler(this.btnShowPass_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(95)))), ((int)(((byte)(165)))));
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(30, 418);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(360, 45);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Autentificare";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnMergelaInregistrare
            // 
            this.btnMergelaInregistrare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(240)))));
            this.btnMergelaInregistrare.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMergelaInregistrare.FlatAppearance.BorderSize = 0;
            this.btnMergelaInregistrare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMergelaInregistrare.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnMergelaInregistrare.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(95)))), ((int)(((byte)(165)))));
            this.btnMergelaInregistrare.Location = new System.Drawing.Point(30, 481);
            this.btnMergelaInregistrare.Name = "btnMergelaInregistrare";
            this.btnMergelaInregistrare.Size = new System.Drawing.Size(360, 35);
            this.btnMergelaInregistrare.TabIndex = 3;
            this.btnMergelaInregistrare.Text = "Nu ai cont? Înregistrează-te";
            this.btnMergelaInregistrare.UseVisualStyleBackColor = false;
            this.btnMergelaInregistrare.Click += new System.EventHandler(this.btnMergelaInregistrare_Click);
            // 
            // Autentificare
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(420, 520);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.pnlForm);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnMergelaInregistrare);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Autentificare";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Autentificare";
            this.pnlTop.ResumeLayout(false);
            this.pnlForm.ResumeLayout(false);
            this.pnlForm.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblTitlu;
        private System.Windows.Forms.Label lblSubtitlu;
        private System.Windows.Forms.Panel pnlForm;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblParola;
        private System.Windows.Forms.TextBox txtParola;
        private System.Windows.Forms.Button btnShowPass;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnMergelaInregistrare;
    }
}