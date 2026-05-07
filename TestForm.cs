using System;
using System.Collections.Generic;
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
    }
}