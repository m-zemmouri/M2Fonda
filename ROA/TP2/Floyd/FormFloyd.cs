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

namespace ROA.TP2.Floyd
{
    public partial class FormFloyd : Form
    {
        System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyleInfinity;

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
        public FormFloyd()
        {
            try
            {
                InitializeComponent();
                dataGridViewCellStyleInfinity = new System.Windows.Forms.DataGridViewCellStyle();
                dataGridViewCellStyleInfinity.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
                dataGridViewCellStyleInfinity.BackColor = System.Drawing.SystemColors.Control;
                dataGridViewCellStyleInfinity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                dataGridViewCellStyleInfinity.ForeColor = System.Drawing.SystemColors.WindowText;
                dataGridViewCellStyleInfinity.SelectionBackColor = System.Drawing.SystemColors.Highlight;
                dataGridViewCellStyleInfinity.SelectionForeColor = System.Drawing.SystemColors.HighlightText;


                generate_Templates();
                dataGridViewGraph.TopLeftHeaderCell.Value = "ID";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #region Parametrage

        private void bindingMatrice(DataGridView dataGridView, int[,] Matrice, string spetialChar= "∞")
        {
            try
            {
                dataGridView.Columns.Clear();

                if (Matrice != null)
                {
                    int height = Matrice.GetLength(0);
                    int width = Matrice.GetLength(1);

                    for (int i = 0; i < height; i++)
                    {

                        DataGridViewTextBoxColumn objetColumn = new DataGridViewTextBoxColumn();
                        objetColumn.DefaultCellStyle = new DataGridViewCellStyle();
                        objetColumn.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
                        objetColumn.DefaultCellStyle.NullValue = -1;
                        objetColumn.Name = 'V' + i.ToString();
                        objetColumn.HeaderText = 'V' + i.ToString();
                        dataGridView.Columns.Add(objetColumn);
                    }
                    object val;
                    for (int i = 0; i < height; i++)
                    {
                        dataGridView.Rows.Add();
                        dataGridView.Rows[i].HeaderCell.Value = 'V' + i.ToString();
                        for (int j = 0; j < width; j++)
                        {

                            if (Matrice[i, j] == -1)
                            {
                                val = spetialChar;
                                dataGridView.Rows[i].Cells[j].Style = dataGridViewCellStyleInfinity;
                            }
                            else
                            {
                                val = Matrice[i, j];
                                dataGridView.Rows[i].Cells[j].Style = dataGridView.DefaultCellStyle;
                            }
                            dataGridView.Rows[i].Cells[j].Value = val;
                        }
                        dataGridView.Rows[i].Cells[i].ReadOnly = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int[,] readGrid(DataGridView dataGridView)
        {
            int[,] result = null;
            try
            {
                result = new int[dataGridView.RowCount, dataGridView.ColumnCount];
                int val;
                for (int i = 0; i < dataGridView.RowCount; i++)
                {
                    for (int j = 0; j < dataGridView.ColumnCount; j++)
                    {
                        try
                        {
                            val = (int)dataGridView.Rows[i].Cells[j].Value;
                        }
                        catch 
                        {
                          val = -1;
                        }          ;
                        result[i, j] = val;
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
                if (MyGraphe != null)
                {
                    bindingMatrice(this.dataGridViewGraph, MyGraphe.Matrice);
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
                for (int i = 0; i < MyGraphe.Dimension; i++)
                {
                    for (int j = 0; j < MyGraphe.Dimension; j++)
                    {
                        MyGraphe.Cout[i, j] = MyGraphe.Matrice[i, j];
                        if (i == j || MyGraphe.Matrice[i, j] > -1)
                        {
                            MyGraphe.Suivant[i, j] = j;
                        }
                        else
                        {
                            MyGraphe.Suivant[i, j] = -1;
                        }
                    }
                }
   for (int k = 0; k < MyGraphe.Dimension; k++)
                {
                    for (int i = 0; i < MyGraphe.Dimension; i++)
                    {
                        for (int j = 0; j < MyGraphe.Dimension; j++)
                        {
                            if (MyGraphe.Cout[i, k] > 0 && MyGraphe.Cout[k, j] > 0 && MyGraphe.Cout[i, k] + MyGraphe.Cout[k, j] < MyGraphe.Cout[i, j])
                            {
                                MyGraphe.Cout[i, j] = MyGraphe.Cout[i, k] + MyGraphe.Cout[k, j];
                                MyGraphe.Suivant[i, j] = MyGraphe.Suivant[i, k];
                                //System.Threading.Thread.Sleep(1000);
                                //bindingMatrice(this.dataGridViewDistance, MyGraphe.Distance);
                                //bindingMatrice(this.dataGridViewSuivant, MyGraphe.Suivant);
                            }
                        }
                    }
                }
                bindingMatrice(this.dataGridViewDistance, MyGraphe.Cout);
                bindingMatrice(this.dataGridViewSuivant, MyGraphe.Suivant, "∅");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewGraph_Validated(object sender, EventArgs e)
        {
            try
            {
                if (MyGraphe != null)
                {
                    MyGraphe.Matrice = readGrid(this.dataGridViewGraph);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewGraph_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                object val = this.dataGridViewGraph.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                int iVal;
                System.Windows.Forms.DataGridViewCellStyle cellStyle;
                if (val != null)
                {
                    if (!int.TryParse(val.ToString(), out iVal))
                    {
                        iVal = -1;
                    }
                }
                else
                {
                    iVal = -1;
                }
                if (iVal == -1)
                {
                    val = "∞";
                    cellStyle = dataGridViewCellStyleInfinity;
                }
                else
                {
                    cellStyle = this.dataGridViewGraph.DefaultCellStyle;
                }
                this.dataGridViewGraph.Rows[e.ColumnIndex].Cells[e.RowIndex].Value = val;
                this.dataGridViewGraph.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = val;
                this.dataGridViewGraph.Rows[e.ColumnIndex].Cells[e.RowIndex].Style = cellStyle;
                this.dataGridViewGraph.Rows[e.RowIndex].Cells[e.ColumnIndex].Style = cellStyle;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void generate_Templates()
        {
            try
            {
                Graphe graphe;
                
                // Modèle 1
                graphe = new Graphe();
                graphe.Nom = "Modèle 1 (4 Villes)";
                graphe.Dimension = 4;
                graphe.Matrice = new int[,] {
                    {0, 5, 8, 7},
                    {5, 0, 6, 7},
                    {8, 6, 0, 5},
                    {7, 7, 5, 0},
                };
                grapheBindingSource.Add(graphe);


                // Modèle 2
                graphe = new Graphe();
                graphe.Nom = "Modèle 2 (5 Villes)";
                graphe.Dimension = 5;
                graphe.Matrice = new int[,] {
                    {-1, 5, 7, 3, 5},
                    {5, -1, -1, -1, 9},
                    {7, -1, -1, 2, -1},
                    {3, -1, 2, -1, 1},
                    {5, 9, -1, 1, -1}
                };
                grapheBindingSource.Add(graphe);


                // Modèle 3
                graphe = new Graphe();
                graphe.Nom = "Modèle 3 (4 Villes)";
                graphe.Dimension = 4;
                graphe.Matrice = new int[,] {
                    {0, 5, 8, 7},
                    {5, 0, 6, 7},
                    {8, 6, 0, 5},
                    {7, 7, 5, 0},
                };
                grapheBindingSource.Add(graphe);

                grapheBindingSource.EndEdit();
                grapheBindingSource.ResetBindings(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void grapheBindingSource_CurrentItemChanged(object sender, EventArgs e)
        {
            try
            {
                if (MyGraphe != null)
                {
                    bindingMatrice(this.dataGridViewGraph, MyGraphe.Matrice);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}