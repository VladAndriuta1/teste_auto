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
            this.lblProgres = new System.Windows.Forms.Label();
            this.lblTimer = new System.Windows.Forms.Label();
            this.lblIntrebare = new System.Windows.Forms.Label();
            this.rbA = new System.Windows.Forms.RadioButton();
            this.rbB = new System.Windows.Forms.RadioButton();
            this.rbC = new System.Windows.Forms.RadioButton();
            this.btnUrmatoarea = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);

            this.SuspendLayout();

            // Form
            this.ClientSize = new System.Drawing.Size(700, 500);
            this.Text = "Test";
            this.BackColor = System.Drawing.Color.FromArgb(232, 234, 240);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.TestForm_Load);

            // lblProgres
            this.lblProgres.Text = "Întrebarea 1 din 24";
            this.lblProgres.Font = new System.Drawing.Font("Segoe UI", 10);
            this.lblProgres.ForeColor = System.Drawing.Color.FromArgb(12, 68, 124);
            this.lblProgres.Location = new System.Drawing.Point(30, 20);
            this.lblProgres.Size = new System.Drawing.Size(300, 25);

            // lblTimer
            this.lblTimer.Text = "⏱ 30:00";
            this.lblTimer.Font = new System.Drawing.Font("Segoe UI", 14, System.Drawing.FontStyle.Bold);
            this.lblTimer.ForeColor = System.Drawing.Color.FromArgb(24, 95, 165);
            this.lblTimer.Location = new System.Drawing.Point(550, 15);
            this.lblTimer.Size = new System.Drawing.Size(120, 30);
            this.lblTimer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            // lblIntrebare
            this.lblIntrebare.Text = "Textul întrebării apare aici...";
            this.lblIntrebare.Font = new System.Drawing.Font("Segoe UI", 12);
            this.lblIntrebare.ForeColor = System.Drawing.Color.FromArgb(30, 30, 30);
            this.lblIntrebare.BackColor = System.Drawing.Color.White;
            this.lblIntrebare.Location = new System.Drawing.Point(30, 60);
            this.lblIntrebare.Size = new System.Drawing.Size(640, 100);
            this.lblIntrebare.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblIntrebare.Padding = new System.Windows.Forms.Padding(10);

            // rbA
            this.rbA.Text = "Varianta A";
            this.rbA.Font = new System.Drawing.Font("Segoe UI", 11);
            this.rbA.ForeColor = System.Drawing.Color.FromArgb(30, 30, 30);
            this.rbA.BackColor = System.Drawing.Color.White;
            this.rbA.Location = new System.Drawing.Point(30, 185);
            this.rbA.Size = new System.Drawing.Size(640, 60);
            this.rbA.Padding = new System.Windows.Forms.Padding(10);

            // rbB
            this.rbB.Text = "Varianta B";
            this.rbB.Font = new System.Drawing.Font("Segoe UI", 11);
            this.rbB.ForeColor = System.Drawing.Color.FromArgb(30, 30, 30);
            this.rbB.BackColor = System.Drawing.Color.White;
            this.rbB.Location = new System.Drawing.Point(30, 260);
            this.rbB.Size = new System.Drawing.Size(640, 60);
            this.rbB.Padding = new System.Windows.Forms.Padding(10);

            // rbC
            this.rbC.Text = "Varianta C";
            this.rbC.Font = new System.Drawing.Font("Segoe UI", 11);
            this.rbC.ForeColor = System.Drawing.Color.FromArgb(30, 30, 30);
            this.rbC.BackColor = System.Drawing.Color.White;
            this.rbC.Location = new System.Drawing.Point(30, 335);
            this.rbC.Size = new System.Drawing.Size(640, 60);
            this.rbC.Padding = new System.Windows.Forms.Padding(10);

            // btnUrmatoarea
            this.btnUrmatoarea.Text = "Următoarea →";
            this.btnUrmatoarea.Font = new System.Drawing.Font("Segoe UI", 11, System.Drawing.FontStyle.Bold);
            this.btnUrmatoarea.BackColor = System.Drawing.Color.FromArgb(24, 95, 165);
            this.btnUrmatoarea.ForeColor = System.Drawing.Color.White;
            this.btnUrmatoarea.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUrmatoarea.FlatAppearance.BorderSize = 0;
            this.btnUrmatoarea.Size = new System.Drawing.Size(200, 45);
            this.btnUrmatoarea.Location = new System.Drawing.Point(470, 430);
            this.btnUrmatoarea.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUrmatoarea.Click += new System.EventHandler(this.btnUrmatoarea_Click);

            // timer1
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);

            this.Controls.Add(this.lblProgres);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.lblIntrebare);
            this.Controls.Add(this.rbA);
            this.Controls.Add(this.rbB);
            this.Controls.Add(this.rbC);
            this.Controls.Add(this.btnUrmatoarea);

            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label lblProgres;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Label lblIntrebare;
        private System.Windows.Forms.RadioButton rbA;
        private System.Windows.Forms.RadioButton rbB;
        private System.Windows.Forms.RadioButton rbC;
        private System.Windows.Forms.Button btnUrmatoarea;
        private System.Windows.Forms.Timer timer1;
    }
}