using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ROA.TP1
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonExercice1_Click(object sender, EventArgs e)
        {
            new ROA.TP1.Exercice1.FormExercice1().ShowDialog();
        }

        private void buttonExercice2_Click(object sender, EventArgs e)
        {
            new ROA.TP1.Exercice2.FormExercice2().ShowDialog();
        }

        private void buttonExercice3_Click(object sender, EventArgs e)
        {
            new ROA.TP1.Exercice3.FormExercice3().ShowDialog();
        }

        private void buttonFloyd_Click(object sender, EventArgs e)
        {
            new ROA.TP2.Floyd.FormFloyd().ShowDialog();
        }

        private void buttonFloyd2_Click(object sender, EventArgs e)
        {
            new ROA.TP2.Floyd.FormFloyd2().ShowDialog();
        }

        private void buttonLittle_Click(object sender, EventArgs e)
        {
            new ROA.TP2.Little.FormLittle().ShowDialog();
        }
    }
}