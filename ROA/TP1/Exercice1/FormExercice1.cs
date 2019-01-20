using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ROA.TP1.Exercice1
{
    public partial class FormExercice1 : Form
    {
        private bool generateObjet = false;

        Jeu MyGraphe
        {
            get
            {
                Jeu result = null;
                if (jeuBindingSource.Current != null)
                {
                    result = (Jeu)jeuBindingSource.Current;
                }
                return result;
            }
        }

        public FormExercice1()
        {
            try
            {
                InitializeComponent();
                numericTime.Maximum = int.MaxValue;
                jeuBindingSource.AddNew();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #region Parametrage

        private void generateObjetsButton_Click(object sender, EventArgs e)
        {
            try
            {
                generateObjet = true;
                if (objetsBindingSource.Count > numericNombre_Objet.Value && MessageBox.Show("Voulez-vous supprimer les objet en plus?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    while (objetsBindingSource.Count > numericNombre_Objet.Value)
                        objetsBindingSource.RemoveAt(objetsBindingSource.Count - 1);
                }
                while (objetsBindingSource.Count < numericNombre_Objet.Value)
                    objetsBindingSource.AddNew();
                generateObjet = false;
                objetsBindingSource.EndEdit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void objetsBindingSource_AddingNew(object sender, AddingNewEventArgs e)
        {
            try
            {
                Objet o = new Objet();
                o.Nom = "Objet " + (objetsBindingSource.Count + 1).ToString();
                o.Poids = 1;
                o.Utilite = 1;
                e.NewObject = o;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void bindingNavigatorCountItem_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!generateObjet) numericNombre_Objet.Value = objetsBindingSource.Count;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        private void calculerButton_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime TimeDebut = DateTime.Now;

                #region Initialization
                tabControl1.SelectedTab = tabPage2;
                combinaisonsBindingSource.Clear();
                objetsBindingSource.EndEdit();
                jeuBindingSource.EndEdit();

                while (dataGridViewCombinaison.Columns.Count > 4)
                    dataGridViewCombinaison.Columns.RemoveAt(4);
                if (MyGraphe != null)
                {


                    int i;
                    for (i = 0; i < MyGraphe.Objets.Count; i++)
                    {
                        DataGridViewCheckBoxColumn objetColumn = new DataGridViewCheckBoxColumn();
                        objetColumn.Name = MyGraphe.Objets[i].Nom;
                        objetColumn.HeaderText = MyGraphe.Objets[i].Nom;
                        this.dataGridViewCombinaison.Columns.Add(objetColumn);
                    }
                    numericTime.Value = 0;

                    #endregion
                    double nb = Math.Pow(2, MyGraphe.Objets.Count);
                    bool ShowMessage = true;
                    for (i = 0; i < nb; i++)
                    {
                        if (timeOutNnumeric.Value > 0 && ShowMessage && DateTime.Now.Subtract(TimeDebut).Seconds > timeOutNnumeric.Value)
                        {
                            ShowMessage = false;
                            if (MessageBox.Show("Time Out, Reste " + (nb - i).ToString() + " itérations non traitées\n Voulez vous Continuer (Oui) ou arretêr le travail (Non)", "Time Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                            {
                                MyGraphe.Temps = null;
                                break;
                            }
                        }
                        Combinaison combinaison = new Combinaison(MyGraphe.Objets, i);
                        combinaisonsBindingSource.Add(combinaison);
                    }

                    #region Finalization

                    if (i == nb)
                    {
                        DateTime Timefin = DateTime.Now;
                        MyGraphe.Temps = Timefin.Subtract(TimeDebut).Milliseconds;
                    }
                    //combinaisonsBindingSource.ResetBindings(false);
                    combinaisonsBindingSource.EndEdit();
                    jeuBindingSource.ResetBindings(false);
                    jeuBindingSource.EndEdit();
                    dataGridViewCombinaison_Paint(null, null);
                    chart1.DataBind();
                }
                #endregion
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void jeuBindingSource_AddingNew(object sender, AddingNewEventArgs e)
        {
            try
            {
                Jeu test = new Jeu();
                test.Nom = "Test " + (jeuBindingSource.Count + 1).ToString();
                test.Poids_Max = 1;
                e.NewObject = test;
                nomJeuTextBox.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void dataGridViewCombinaison_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                Jeu jeu = (Jeu)jeuBindingSource.Current;
                if (jeu != null)
                {
                    foreach (DataGridViewRow row in dataGridViewCombinaison.Rows)
                    {
                        string combinaisonString = row.Cells["CombinaisonString"].Value.ToString();
                        int combinaisonUtilite = (int)row.Cells["CombinaisonUtilite"].Value;
                        int combibaisonPoids = (int)row.Cells["CombibaisonPoids"].Value;

                        for (int j = 0; j < jeu.Objets.Count; j++)
                        {
                            row.Cells[j + 4].Value = combinaisonString[j] == '1';
                        }

                        if (combibaisonPoids > jeu.Poids_Max)
                        {
                            row.Cells["CombibaisonPoids"].Style.BackColor = Color.Red;
                        }
                        else if (combinaisonUtilite == jeu.ResultatUtilite)
                        {
                            row.Cells["CombinaisonUtilite"].Style.BackColor = Color.Green;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void genereTestButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < NBNumeric.Value; i++)
            {
                jeuBindingSource.AddNew();
                jeuBindingSource.MoveLast();
                numericNombre_Objet.Value = i + 2;
                generateObjetsButton_Click(null, null);
                jeuBindingSource.EndEdit();
                jeuBindingSource.ResetBindings(false);
            }
        }

        private void buttonCalculerTous_Click(object sender, EventArgs e)
        {
            try
            {
                jeuBindingSource.MoveFirst();
                calculerButton_Click(null, null);
                while (jeuBindingSource.Position < jeuBindingSource.Count - 1)
                {
                    jeuBindingSource.MoveNext();
                    calculerButton_Click(null, null);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}