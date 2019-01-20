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

namespace ROA.TP2.Little
{
    public partial class FormLittle : Form
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
        public FormLittle()
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
                this.dataGridViewGraph.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.dataGridViewGraph.RowHeadersDefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

                generate_Templates();
                dataGridViewGraph.TopLeftHeaderCell.Value = "Villes";

                cellControlLegende.textBoxReduction.Text = "Valeur Réduite";
                cellControlLegende.textBoxValue.Text = "Valeur";
                cellControlLegende.textBoxRegret.Text = "Regret";

                treeViewGraphe.ImageIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #region Parametrage

        private void bindingMatrice(DataGridView dataGridView, Graphe graphe, string spetialChar = "∞")
        {
            try
            {
                dataGridView.Columns.Clear();

                if (graphe != null)
                {
                    for (int j = 0; j < graphe.Dimension; j++)
                    {
                        DataGridViewTextBoxColumn objetColumn = new DataGridViewTextBoxColumn();
                        objetColumn.DefaultCellStyle = new DataGridViewCellStyle();
                        objetColumn.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
                        objetColumn.DefaultCellStyle.NullValue = float.PositiveInfinity;
                        objetColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
                        objetColumn.Name = graphe.villesDestination[j];
                        objetColumn.HeaderText = graphe.villesDestination[j];
                        objetColumn.Width = 50;
                        dataGridView.Columns.Add(objetColumn);
                    }
                    object val;
                    DataGridViewRow row;
                    for (int i = 0; i < graphe.Dimension; i++)
                    {
                        dataGridView.Rows.Add();
                        row = dataGridView.Rows[i];
                        row.Height = 50;
                        row.HeaderCell.Value = graphe.villesDepart[i];
                        for (int j = 0; j < graphe.Dimension; j++)
                        {
                            float value = graphe.getValeur(i, j);

                            if (value.IsInfinity())
                                row.Cells[j].Style = dataGridViewCellStyleInfinity;
                           else
                                row.Cells[j].Style = dataGridView.DefaultCellStyle;

                            row.Cells[j].Value = value;
                        }
                        row.Cells[i].ReadOnly = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void drawSolutione(Graphe graphe)
        {
            try
            {
                CellControl cellControl; Label label; Control control;

                while (tableLayoutPanelSolution.RowCount < graphe.Dimension + 2)
                {
                    tableLayoutPanelSolution.ColumnCount++;
                    ColumnStyle ColumnStyle = new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F);
                    this.tableLayoutPanelSolution.ColumnStyles.Add(ColumnStyle);
                    label = new Label();
                    label.BackColor = System.Drawing.SystemColors.Control;
                    label.Dock = System.Windows.Forms.DockStyle.Fill;
                    label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    label.Location = new System.Drawing.Point(1, 1);
                    label.Margin = new System.Windows.Forms.Padding(0);
                    label.Text = graphe.villesDestination[tableLayoutPanelSolution.ColumnCount - 2];
                    label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                    this.tableLayoutPanelSolution.Controls.Add(label, tableLayoutPanelSolution.ColumnCount - 1, 0);

                    tableLayoutPanelSolution.RowCount++;
                    RowStyle RowStyle = new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F);
                    this.tableLayoutPanelSolution.RowStyles.Add(RowStyle);
                    label = new Label();
                    label.BackColor = System.Drawing.SystemColors.Control;
                    label.Dock = System.Windows.Forms.DockStyle.Fill;
                    label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    label.Location = new System.Drawing.Point(1, 1);
                    label.Margin = new System.Windows.Forms.Padding(0);
                    label.Text = graphe.villesDepart[tableLayoutPanelSolution.RowCount - 2];
                    label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                    this.tableLayoutPanelSolution.Controls.Add(label, 0, tableLayoutPanelSolution.RowCount - 1);

                    for (int i = 1; i < tableLayoutPanelSolution.RowCount - 1; i++)
                    {
                        cellControl = new CellControl();
                        cellControl.Dock = DockStyle.Fill;
                        this.tableLayoutPanelSolution.Controls.Add(cellControl, tableLayoutPanelSolution.ColumnCount - 1, i);

                        cellControl = new CellControl();
                        cellControl.Dock = DockStyle.Fill;
                        this.tableLayoutPanelSolution.Controls.Add(cellControl, i, tableLayoutPanelSolution.RowCount - 1);
                    }
                    cellControl = new CellControl();
                    cellControl.Dock = DockStyle.Fill;
                    this.tableLayoutPanelSolution.Controls.Add(cellControl, tableLayoutPanelSolution.ColumnCount - 1, tableLayoutPanelSolution.RowCount - 1);
                }

                while (tableLayoutPanelSolution.RowCount > graphe.Dimension + 2)
                {
                    for (int i = 0; i < tableLayoutPanelSolution.RowCount - 1; i++)
                    {
                        control = tableLayoutPanelSolution.GetControlFromPosition(tableLayoutPanelSolution.ColumnCount - 1, i);
                        this.tableLayoutPanelSolution.Controls.Remove(control);
                        control.Dispose();

                        control = tableLayoutPanelSolution.GetControlFromPosition(i, tableLayoutPanelSolution.RowCount - 1);
                        this.tableLayoutPanelSolution.Controls.Remove(control);
                        control.Dispose();
                    }
                    control = tableLayoutPanelSolution.GetControlFromPosition(tableLayoutPanelSolution.ColumnCount - 1, tableLayoutPanelSolution.RowCount - 1);
                    this.tableLayoutPanelSolution.Controls.Remove(control);
                    control.Dispose();

                    tableLayoutPanelSolution.RowCount--;
                    tableLayoutPanelSolution.ColumnCount--;
                }

                tableLayoutPanelSolution.AutoScroll = false;
                tableLayoutPanelSolution.AutoScroll = true;

                for (int i = 1; i < tableLayoutPanelSolution.RowCount; i++)
                {
                    tableLayoutPanelSolution.GetControlFromPosition(i, 0).Text = graphe.villesDestination[i - 1];
                    tableLayoutPanelSolution.GetControlFromPosition(0, i).Text = graphe.villesDepart[i - 1];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bindingSolutione(Graphe graphe)
        {
            try
            {
                CellControl cellControl; Control control; int val;
                if (graphe != null)
                {
                    drawSolutione(graphe);

                    for (int i = 0; i < graphe.Dimension; i++)
                    {
                        for (int j = 0; j < graphe.Dimension; j++)
                        {
                            control = tableLayoutPanelSolution.GetControlFromPosition(j + 1, i + 1);
                            cellControl = (CellControl)control;
                            cellControl.Bind(graphe.getValeur(i, j), graphe.getReduction(i, j), graphe.getRegret(i, j));
                            toolTipSolution.SetToolTip(cellControl.textBoxReduction, "Reduction " + graphe.villesDepart[i] + "→" + graphe.villesDestination[j]);
                            toolTipSolution.SetToolTip(cellControl.textBoxValue, "Value " + graphe.villesDepart[i] + "→" + graphe.villesDestination[j]);
                            toolTipSolution.SetToolTip(cellControl.textBoxRegret, "Regret " + graphe.villesDepart[i] + "↛" + graphe.villesDestination[j]);
                        }

                        control = tableLayoutPanelSolution.GetControlFromPosition(graphe.Dimension + 1, i + 1);
                        cellControl = (CellControl)control;
                        cellControl.BindMin(graphe.getValeur(i, graphe.Dimension), graphe.getReduction(i, graphe.Dimension), graphe.getRegret(i, graphe.Dimension));
                        cellControl.textBoxReduction.Text = "";
                        toolTipSolution.SetToolTip(cellControl.textBoxRegret, "Regret " + graphe.villesDepart[i] + "→ *");
                        toolTipSolution.SetToolTip(cellControl.textBoxValue, "Min Value " + graphe.villesDepart[i] + "→ *");

                        control = tableLayoutPanelSolution.GetControlFromPosition(i + 1, graphe.Dimension + 1);
                        cellControl = (CellControl)control;
                        cellControl.BindMin(graphe.getValeur(graphe.Dimension, i), graphe.getReduction(graphe.Dimension, i), graphe.getRegret(graphe.Dimension, i));
                        cellControl.textBoxValue.Text = "";

                        toolTipSolution.SetToolTip(cellControl.textBoxReduction, "Min Reduction * → " + graphe.villesDestination[i] + ")");
                        toolTipSolution.SetToolTip(cellControl.textBoxRegret, "Regret * → " + graphe.villesDestination[i] + ")");

                        control = tableLayoutPanelSolution.GetControlFromPosition(graphe.Dimension + 1, graphe.Dimension + 1);
                        cellControl = (CellControl)control;
                        cellControl.BindMin(graphe.getValeur(graphe.Dimension, graphe.Dimension), graphe.getReduction(graphe.Dimension, graphe.Dimension), graphe.getRegret(graphe.Dimension, graphe.Dimension));
                        //cellControl.textBoxReduction.Text = graphe.Separation.ToString();
                        cellControl.textBoxRegret.Text = graphe.getRegret(graphe.Dimension, graphe.Dimension).ToString();

                        toolTipSolution.SetToolTip(cellControl.textBoxReduction, "Separation");
                        toolTipSolution.SetToolTip(cellControl.textBoxValue, "Evaluation");
                        toolTipSolution.SetToolTip(cellControl.textBoxRegret, "Regret Max");
                    }

                    labelEvaluation.Text = graphe.Evaluation.ToString();
                    labelSolution.Text = String.Join(", ", graphe.traget.Where(d=>!String.IsNullOrEmpty( d.Key.Depart) && !String.IsNullOrEmpty( d.Key.Destination)).Select(d => d.Key.ToString()).ToArray());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private float[,] readGrid(DataGridView dataGridView)
        {
            float[,] result = null;
            try
            {
                result = new float[dataGridView.RowCount, dataGridView.ColumnCount];
                float val;
                for (int i = 0; i < dataGridView.RowCount; i++)
                {
                    for (int j = 0; j < dataGridView.ColumnCount; j++)
                    {
                        if (!float.TryParse(dataGridView.Rows[i].Cells[j].Value.ToString(), out val))
                        {
                            val = float.PositiveInfinity;
                        }
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
                    bindingMatrice(this.dataGridViewGraph, MyGraphe);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        void bindTree(Graphe graphe)
        {
            if (graphe != null)
            {
                treeViewGraphe.Nodes.Clear();
                treeViewGraphe.Nodes.Add(getNode(graphe));
                treeViewGraphe.ExpandAll();
            }
        }

        TreeNode getNode(Graphe graphe)
        {
            TreeNode node = null;
            if (graphe != null)
            {
                node = new TreeNode(graphe.CurrentArc.ToString() + " (" + graphe.Evaluation.ToString() + ")");

                node.ImageIndex = graphe.IsSolution ? 2 : 1;
                node.SelectedImageIndex= graphe.IsSolution ? 2 : 1;
                node.Tag = graphe;
                if (graphe.Sans != null)
                {
                    TreeNode sans = getNode(graphe.Sans);
                    if (sans != null)
                    {
                        node.Nodes.Add(sans);
                    }
                    node.ImageIndex = 0;
                    node.SelectedImageIndex = 0;

                }
                if (graphe.Avec != null)
                {
                    TreeNode avec = getNode(graphe.Avec);
                    if (avec != null)
                    {
                        node.Nodes.Add(avec);
                    }
                    node.ImageIndex = 0;
                    node.SelectedImageIndex = 0;
                }
            }
            return node;
        }

        private void calculerButton_Click(object sender, EventArgs e)
        {
            try
            {                
                MyGraphe.Evaluer();
                bindingSolutione(MyGraphe);
                tabControl1.SelectedIndex = 1;
                bindTree(MyGraphe);
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
                    MyGraphe.Read(readGrid(this.dataGridViewGraph));
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
                float iVal;
                System.Windows.Forms.DataGridViewCellStyle cellStyle;
                if (val == null ||
                    !float.TryParse(val.ToString(), out iVal) ||
                    iVal.IsInfinity())
                {
                    iVal = float.PositiveInfinity;
                    cellStyle = dataGridViewCellStyleInfinity;
                }
                else
                {
                    cellStyle = this.dataGridViewGraph.DefaultCellStyle;
                }
                this.dataGridViewGraph.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = val;
                this.dataGridViewGraph.Rows[e.RowIndex].Cells[e.ColumnIndex].Style = cellStyle;
                if (checkBoxSemetrique.Checked)
                {
                    this.dataGridViewGraph.Rows[e.ColumnIndex].Cells[e.RowIndex].Value = val;
                    this.dataGridViewGraph.Rows[e.ColumnIndex].Cells[e.RowIndex].Style = cellStyle;
                }
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
                // Modèle 2
                graphe = new Graphe();
                graphe.Nom = "Modèle 2 (5 Villes)";
                graphe.Dimension = 2;
                graphe.Read(new float[,] {
                    {-1, 5},
                    {5, -1,}
                });
                grapheBindingSource.Add(graphe);

                // Modèle 2
                graphe = new Graphe();
                graphe.Nom = "Modèle 2 (5 Villes)";
                graphe.Dimension = 5;
                graphe.Read(new float[,] {
                    {-1, 5, 7, 3, 5},
                    {5, -1, -1, -1, 9},
                    {7, -1, -1, 2, -1},
                    {3, -1, 2, -1, 1},
                    {5, 9, -1, 1, -1}
                });
                grapheBindingSource.Add(graphe);

                // Modèle 1
                graphe = new Graphe();
                graphe.Nom = "Modèle 1 (4 Villes)";
                graphe.Dimension = 4;
                graphe.Read(new float[,] {
                    {0, 5, 8, 7},
                    {5, 0, 6, 7},
                    {8, 6, 0, 5},
                    {7, 7, 5, 0},
                });
                grapheBindingSource.Add(graphe);

                // Modèle 3
                graphe = new Graphe();
                graphe.Nom = "Modèle 3 (4 Villes)";
                graphe.Dimension = 4;
                graphe.Read(new float[,] {
                    {0, 5, 8, 7},
                    {5, 0, 6, 7},
                    {8, 6, 0, 5},
                    {7, 7, 5, 0},
                });
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
                    bindingMatrice(this.dataGridViewGraph, MyGraphe);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void villesBindingSource_CurrentItemChanged(object sender, EventArgs e)
        {
            try
            {
                if (MyGraphe != null)
                {
                    MyGraphe.RebuildVilles();
                    bindingMatrice(this.dataGridViewGraph, MyGraphe);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void treeViewGraphe_AfterSelect(object sender, TreeViewEventArgs e)
        {
            try
            {
                Graphe graphe = (Graphe)e.Node.Tag;
                //graphe.Evaluer();
                bindingSolutione(graphe);
            }
            catch (Exception ex)
            {
                //throw;
            }
        }

        private void FormLittle_Load(object sender, EventArgs e)
        {
            calculerButton_Click(null, null);
        }

        private void treeViewGraphe_BeforeCheck(object sender, TreeViewCancelEventArgs e)
        {
            e.Cancel = true;
        }
    }
}