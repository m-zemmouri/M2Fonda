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

namespace ROA.TP1.Exercice2
{
    public partial class FormExercice2 : Form
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

        public FormExercice2()
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

        private void generateButton_Click(object sender, EventArgs e)
        {
            try
            {
                grapheBindingSource.EndEdit();
                if (MyGraphe != null)
                {
                    bindingMatrice();
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

                    //List<List<int>> ListStable = new List<List<int>>();
                    Dictionary<string, List<int>> ListStable2 = new Dictionary<string, List<int>>();

                    #endregion

                    List<int> stable;
                    List<int> newStable;
                    List<int> listElements = new List<int>();
                    List<int> restofElements;
                    string key;
                    int i;

                    for (i = 0; i < MyGraphe.Dimension; i++)
                    {
                        stable = new List<int>();
                        stable.Add(i);
                        listElements.Add(i);
                        //ListStable.Add(stable);
                        ListStable2[i.ToString()] = stable;
                    }

                    i = 0;

                    while (i < ListStable2.Count )
                    {
                        if (timeOutNnumeric.Value > 0 && DateTime.Now.Subtract(TimeDebut).Seconds > timeOutNnumeric.Value)
                            break;

                        stable = ListStable2.ElementAt(i).Value;
                        restofElements = listElements.Except(stable).ToList();

                        foreach (int j in restofElements)
                        {
                            // Check if exist 
                            newStable = stable.ToList();
                            newStable.Add(j);
                            newStable = newStable.OrderBy(x => x).ToList();
                            key = String.Join(", ", newStable);
                            if (!ListStable2.ContainsKey(key))
                            {
                                bool isStable = true;
                                foreach (int s in stable)
                                {
                                    if (MyGraphe.Matrice[s, j])
                                    {
                                        isStable = false;
                                        break;
                                    }
                                }
                                if (isStable)
                                {
                                    ListStable2[key] = newStable;
                                }
                            }
                        }
                        i++;
                    }

                    #region Finalization
                    //Order
                    if (i == ListStable2.Count)
                    {
                        MyGraphe.Stable = (from stbl in ListStable2
                                           orderby stbl.Key.Length descending
                                           select stbl.Key).First();

                        DateTime Timefin = DateTime.Now;

                        MyGraphe.Temps = Timefin.Subtract(TimeDebut).Milliseconds;
                    }
                    else
                    {
                        MyGraphe.Stable = "Time Out";
                        MyGraphe.Temps = null;
                        MessageBox.Show("Time Out");
                    }
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