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

namespace ROA.TP1.Exercice3
{
    public partial class FormExercice3 : Form
    {
        Graphe MyGraphe
        {
            get
            {
                Graphe result = null;
                if (grapheBindingSource.Current != null)
                {
                    result = (Graphe)grapheBindingSource.Current;
                }
                return result;
            }
        }

        public FormExercice3()
        {
            try
            {
                InitializeComponent();
                dataGridViewCombinaison.TopLeftHeaderCell.Value = "ID";
                numericTime.Maximum = int.MaxValue;
                grapheBindingSource.AddNew();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #region Parametrage

        private void genereTestButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < NBNumeric.Value; i++)
            {
                grapheBindingSource.AddNew();
                grapheBindingSource.MoveLast();
                MyGraphe.Dimension = i + 2;
                grapheBindingSource.EndEdit();
                grapheBindingSource.ResetBindings(false);
            }
        }

        private void grapheBindingSource_AddingNew(object sender, AddingNewEventArgs e)
        {
            try
            {
                Graphe graphe = new Graphe();
                graphe.Nom = "Graphe " + (grapheBindingSource.Count + 1).ToString();
                e.NewObject = graphe;
                nomJeuTextBox.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bindingMatrice()
        {
            try
            {
                dataGridViewCombinaison.Columns.Clear();

                if (MyGraphe != null && MyGraphe.Matrice != null)
                {
                    int height = MyGraphe.Matrice.GetLength(0);
                    int width = MyGraphe.Matrice.GetLength(1);

                    for (int i = 0; i < height; i++)
                    {
                        DataGridViewCheckBoxColumn objetColumn = new DataGridViewCheckBoxColumn();
                        objetColumn.Name = 'O' + i.ToString();
                        objetColumn.HeaderText = 'O' + i.ToString();
                        this.dataGridViewCombinaison.Columns.Add(objetColumn);
                    }

                    for (int i = 0; i < height; i++)
                    {
                        dataGridViewCombinaison.Rows.Add();
                        this.dataGridViewCombinaison.Rows[i].HeaderCell.Value = 'O' + i.ToString();

                        for (int j = 0; j < width; j++)
                        {
                            this.dataGridViewCombinaison.Rows[i].Cells[j].Value = MyGraphe.Matrice[i, j];
                        }
                        this.dataGridViewCombinaison.Rows[i].Cells[i].ReadOnly = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool[,] readGrid()
        {
            bool[,] result = null;
            try
            {
                result = new bool[dataGridViewCombinaison.RowCount, dataGridViewCombinaison.ColumnCount];
                for (int i = 0; i < dataGridViewCombinaison.RowCount; i++)
                {
                    for (int j = 0; j < dataGridViewCombinaison.ColumnCount; j++)
                    {
                        result[i, j] = (bool)this.dataGridViewCombinaison.Rows[i].Cells[j].Value;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return result;
        }

        private void connexeButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (MyGraphe != null && MyGraphe.Matrice != null)
                {
                    List<int> connexe = new List<int>();
                    connexe.Add(0);
                    int c = 0;
                    do
                    {
                        for (int i = 0; i < MyGraphe.Dimension; i++)
                        {
                            if (MyGraphe.Matrice[connexe[c], i])
                            {
                                connexe.Add(i);
                            }
                        }
                        c++;

                    } while (c < connexe.Count);
                    MyGraphe.IsConnexe = c == MyGraphe.Dimension;
                    //MessageBox.Show("Cette fonction n'est pas implimenter car le graphe est supposeé qu'il est connexe", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
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
                Cursor = Cursors.WaitCursor;
                if (MyGraphe != null)
                {
                    #region Initialization

                    MyGraphe.Matrice = readGrid();

                    connexeButton_Click(null, null);

                    int i, j, nbConnexion;
                    bool isEulerien = MyGraphe.IsConnexe;

                    for (i = 0; i < MyGraphe.Dimension && isEulerien; i++)
                    {
                        nbConnexion = 0;
                        for (j = 0; i < MyGraphe.Dimension; i++)
                        {
                            if (MyGraphe.Matrice[i, j])
                            {
                                nbConnexion++;
                            }
                        }
                        isEulerien = nbConnexion % 2 == 0;
                    }

                    DateTime Timefin = DateTime.Now;

                    MyGraphe.Temps = Timefin.Subtract(TimeDebut).Milliseconds;
                    MyGraphe.IsEulerien = isEulerien;
                    grapheBindingSource.EndEdit();
                    grapheBindingSource.ResetBindings(false);
                    chart1.DataBind();
                    Cursor = Cursors.Default;
                    #endregion
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void grapheBindingSource_CurrentItemChanged(object sender, EventArgs e)
        {
            try
            { bindingMatrice(); }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewCombinaison_Validated(object sender, EventArgs e)
        {
            try
            {
                if (MyGraphe != null)
                {
                    MyGraphe.Matrice = readGrid();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewCombinaison_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            this.dataGridViewCombinaison.Rows[e.ColumnIndex].Cells[e.RowIndex].Value = this.dataGridViewCombinaison.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
        }

        private void buttonCalculerTous_Click(object sender, EventArgs e)
        {
            try
            {
                grapheBindingSource.MoveFirst();
                calculerButton_Click(null, null);
                while (grapheBindingSource.Position < grapheBindingSource.Count - 1)
                {
                    grapheBindingSource.MoveNext();
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