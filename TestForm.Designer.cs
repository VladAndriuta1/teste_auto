namespace teste_auto
{
    partial class TestForm
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
            this.components = new System.ComponentModel.Container();
            this.pnlNavigare = new System.Windows.Forms.Panel();
            this.lblProgres = new System.Windows.Forms.Label();
            this.lblTimer = new System.Windows.Forms.Label();
            this.lblIntrebare = new System.Windows.Forms.Label();
            this.picImagine = new System.Windows.Forms.PictureBox();
            this.rbA = new System.Windows.Forms.RadioButton();
            this.rbB = new System.Windows.Forms.RadioButton();
            this.rbC = new System.Windows.Forms.RadioButton();
            this.btnUrmatoarea = new System.Windows.Forms.Button();
            this.btnAcasa = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picImagine)).BeginInit();
            this.SuspendLayout();

            // ── Form ──────────────────────────────────────────────────
            this.ClientSize = new System.Drawing.Size(920, 660);
            this.Text = "Test";
            this.BackColor = System.Drawing.Color.FromArgb(232, 234, 240);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.MinimumSize = new System.Drawing.Size(920, 660);
            this.Load += new System.EventHandler(this.TestForm_Load);

            // ── lblProgres ────────────────────────────────────────────
            this.lblProgres.Text = "Întrebarea 1 din 24";
            this.lblProgres.Font = new System.Drawing.Font("Segoe UI", 11, System.Drawing.FontStyle.Bold);
            this.lblProgres.ForeColor = System.Drawing.Color.FromArgb(12, 68, 124);
            this.lblProgres.Location = new System.Drawing.Point(12, 14);
            this.lblProgres.Size = new System.Drawing.Size(280, 26);

            // ── lblTimer ──────────────────────────────────────────────
            this.lblTimer.Text = "⏱ 30:00";
            this.lblTimer.Font = new System.Drawing.Font("Segoe UI", 14, System.Drawing.FontStyle.Bold);
            this.lblTimer.ForeColor = System.Drawing.Color.FromArgb(24, 95, 165);
            this.lblTimer.Location = new System.Drawing.Point(740, 8);
            this.lblTimer.Size = new System.Drawing.Size(160, 34);
            this.lblTimer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            // ── pnlNavigare ───────────────────────────────────────────
            // 24 butoane × (34+3) = 888px → încap perfect în 900
            this.pnlNavigare.Location = new System.Drawing.Point(12, 50);
            this.pnlNavigare.Size = new System.Drawing.Size(896, 40);
            this.pnlNavigare.BackColor = System.Drawing.Color.FromArgb(232, 234, 240);

            // ── lblIntrebare ──────────────────────────────────────────
            this.lblIntrebare.Text = "Textul întrebării...";
            this.lblIntrebare.Font = new System.Drawing.Font("Segoe UI", 12);
            this.lblIntrebare.ForeColor = System.Drawing.Color.FromArgb(30, 30, 30);
            this.lblIntrebare.BackColor = System.Drawing.Color.White;
            this.lblIntrebare.Location = new System.Drawing.Point(12, 100);
            this.lblIntrebare.Size = new System.Drawing.Size(896, 90);
            this.lblIntrebare.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblIntrebare.Padding = new System.Windows.Forms.Padding(12);

            // ── picImagine ────────────────────────────────────────────
            this.picImagine.Location = new System.Drawing.Point(12, 200);
            this.picImagine.Size = new System.Drawing.Size(360, 220);
            this.picImagine.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picImagine.BackColor = System.Drawing.Color.White;
            this.picImagine.Visible = false;

            // ── rbA ───────────────────────────────────────────────────
            this.rbA.Text = "Varianta A";
            this.rbA.Font = new System.Drawing.Font("Segoe UI", 11);
            this.rbA.ForeColor = System.Drawing.Color.FromArgb(30, 30, 30);
            this.rbA.BackColor = System.Drawing.Color.White;
            this.rbA.Location = new System.Drawing.Point(12, 205);
            this.rbA.Size = new System.Drawing.Size(896, 55);
            this.rbA.Padding = new System.Windows.Forms.Padding(10);

            // ── rbB ───────────────────────────────────────────────────
            this.rbB.Text = "Varianta B";
            this.rbB.Font = new System.Drawing.Font("Segoe UI", 11);
            this.rbB.ForeColor = System.Drawing.Color.FromArgb(30, 30, 30);
            this.rbB.BackColor = System.Drawing.Color.White;
            this.rbB.Location = new System.Drawing.Point(12, 270);
            this.rbB.Size = new System.Drawing.Size(896, 55);
            this.rbB.Padding = new System.Windows.Forms.Padding(10);

            // ── rbC ───────────────────────────────────────────────────
            this.rbC.Text = "Varianta C";
            this.rbC.Font = new System.Drawing.Font("Segoe UI", 11);
            this.rbC.ForeColor = System.Drawing.Color.FromArgb(30, 30, 30);
            this.rbC.BackColor = System.Drawing.Color.White;
            this.rbC.Location = new System.Drawing.Point(12, 335);
            this.rbC.Size = new System.Drawing.Size(896, 55);
            this.rbC.Padding = new System.Windows.Forms.Padding(10);

            // ── btnAcasa (jos-stânga) ─────────────────────────────────
            this.btnAcasa.Text = "🏠 Acasă";
            this.btnAcasa.Font = new System.Drawing.Font("Segoe UI", 10, System.Drawing.FontStyle.Bold);
            this.btnAcasa.BackColor = System.Drawing.Color.FromArgb(108, 117, 125);
            this.btnAcasa.ForeColor = System.Drawing.Color.White;
            this.btnAcasa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAcasa.FlatAppearance.BorderSize = 0;
            this.btnAcasa.Size = new System.Drawing.Size(130, 45);
            this.btnAcasa.Location = new System.Drawing.Point(12, 598);
            this.btnAcasa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAcasa.Click += new System.EventHandler(this.btnAcasa_Click);

            // ── btnUrmatoarea (jos-dreapta) ───────────────────────────
            this.btnUrmatoarea.Text = "Confirmă →";
            this.btnUrmatoarea.Font = new System.Drawing.Font("Segoe UI", 11, System.Drawing.FontStyle.Bold);
            this.btnUrmatoarea.BackColor = System.Drawing.Color.FromArgb(24, 95, 165);
            this.btnUrmatoarea.ForeColor = System.Drawing.Color.White;
            this.btnUrmatoarea.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUrmatoarea.FlatAppearance.BorderSize = 0;
            this.btnUrmatoarea.Size = new System.Drawing.Size(200, 45);
            this.btnUrmatoarea.Location = new System.Drawing.Point(708, 598);
            this.btnUrmatoarea.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUrmatoarea.Click += new System.EventHandler(this.btnUrmatoarea_Click);

            // ── timer1 ────────────────────────────────────────────────
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);

            // ── Controls.Add ──────────────────────────────────────────
            this.Controls.Add(this.lblProgres);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.pnlNavigare);
            this.Controls.Add(this.lblIntrebare);
            this.Controls.Add(this.picImagine);
            this.Controls.Add(this.rbA);
            this.Controls.Add(this.rbB);
            this.Controls.Add(this.rbC);
            this.Controls.Add(this.btnAcasa);
            this.Controls.Add(this.btnUrmatoarea);

            ((System.ComponentModel.ISupportInitialize)(this.picImagine)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel pnlNavigare;
        private System.Windows.Forms.Label lblProgres;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Label lblIntrebare;
        private System.Windows.Forms.PictureBox picImagine;
        private System.Windows.Forms.RadioButton rbA;
        private System.Windows.Forms.RadioButton rbB;
        private System.Windows.Forms.RadioButton rbC;
        private System.Windows.Forms.Button btnUrmatoarea;
        private System.Windows.Forms.Button btnAcasa;
        private System.Windows.Forms.Timer timer1;
    }
}