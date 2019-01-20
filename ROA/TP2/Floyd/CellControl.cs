using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ROA.TP2.Floyd
{
    public partial class CellControl : UserControl
    {
        public CellControl()
        {
            InitializeComponent();
        }

        int valeur = -1;
        public int Valeur
        {
            get
            {
                return valeur;
            }
            set
            {
                valeur = value;
                if (value == -1)
                {
                    textBoxValue.Text = "∞";
                    //textBoxValue.BackColor = System.Drawing.SystemColors.Control;
                }
                else
                {
                    textBoxValue.Text = value.ToString();
                    //textBoxValue.BackColor = System.Drawing.SystemColors.Window;
                }              
            }
        }
        int cout = -1;
        public int Cout
        {
            get
            {
                return cout;
            }
            set
            {
                cout = value;
                if (value == -1)
                {
                    textBoxTop.Text = "∞";
                    //textBoxTop.BackColor = System.Drawing.SystemColors.Control;
                }
                else
                {
                    textBoxTop.Text = value.ToString();
                    //textBoxTop.BackColor = System.Drawing.SystemColors.Window;
                }
            }
        }
        int suivant = -1;
        public int Suivant
        {
            get
            {
                return suivant;
            }
            set
            {
                suivant = value;
                if (value==-1)
                {
                    textBoxBottom.Text = "∅";
                    //textBoxBottom.BackColor = System.Drawing.SystemColors.Control;
                }
                else
                {
                textBoxBottom.Text ="V" + value.ToString();
                    //textBoxBottom.BackColor = System.Drawing.SystemColors.Window;
                }
            }
        }
    }
}
