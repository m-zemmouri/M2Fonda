using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ROA.TP2.Little
{
    public partial class CellControl : UserControl
    {
        public CellControl()
        {
            InitializeComponent();
        }

        float valeur = -1;
        public float Valeur
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
        float reduction = -1;
        public float Reduction
        {
            get
            {
                return reduction;
            }
            set
            {
                reduction = value;
                if (value == -1)
                {
                    textBoxReduction.Text = "";
                    //textBoxTop.BackColor = System.Drawing.SystemColors.Control;
                }
                else
                {
                    textBoxReduction.Text = value.ToString();
                    //textBoxTop.BackColor = System.Drawing.SystemColors.Window;

                    //if (Reduction != 0)
                    //{
                    //    textBoxBottom.Text = "";
                    //}
                }
            }
        }
        float regret = -1;
        public float Regret
        {
            get
            {
                return regret;
            }
            set
            {
                regret = value;
                if (value == -1)
                {
                    textBoxRegret.Text = "∞";
                    //textBoxBottom.BackColor = System.Drawing.SystemColors.Control;
                }
                else
                {
                    if (Reduction == 0)
                    {
                        textBoxRegret.Text = value.ToString();
                    }
                    else
                    {
                        textBoxRegret.Text = "";
                    }

                    textBoxRegret.Text = value.ToString();

                    //textBoxBottom.BackColor = System.Drawing.SystemColors.Window;
                }
            }
        }

        public void Bind(float valeur, float reduction, float regret)
        {
            //Valeur
            textBoxValue.Text = "";
            Valeur = valeur;

            //Reduction
            textBoxReduction.Text = "";
            if (!float.IsPositiveInfinity(valeur) && reduction != valeur)
                Reduction = reduction;

            //Regret
            textBoxRegret.Text = "";
            if (!float.IsPositiveInfinity(valeur) && reduction == 0)
                Regret = regret;
        }

        public void BindMin(float valeur, float reduction, float regret)
        {
            textBoxReduction.Text = "";
            textBoxValue.Text = "";
            textBoxRegret.Text = "";
            Valeur = valeur;
            //if (valeur > -1)
            {
                Reduction = reduction;
                //if (reduction == 0)
                Regret = regret;
            }
        }

    }
}