namespace ROA.TP2.Little
{
    partial class FormLittle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLittle));
            this.groupBoxDonnees = new System.Windows.Forms.GroupBox();
            this.groupBoxGraphe = new System.Windows.Forms.GroupBox();
            this.dataGridViewGraph = new System.Windows.Forms.DataGridView();
            this.groupBoxVilles = new System.Windows.Forms.GroupBox();
            this.dataGridViewVille = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.villesNameBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grapheBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonCalculer = new System.Windows.Forms.Button();
            this.generateButton = new System.Windows.Forms.Button();
            this.dimensionNumeric = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxTemplates = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.checkBoxSemetrique = new System.Windows.Forms.CheckBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBoxArbre = new System.Windows.Forms.GroupBox();
            this.treeViewGraphe = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cellControlLegende = new ROA.TP2.Little.CellControl();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelSolution = new System.Windows.Forms.TableLayoutPanel();
            this.labelVille = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelSolution = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.labelEvaluation = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.toolTipSolution = new System.Windows.Forms.ToolTip(this.components);
            this.groupBoxDonnees.SuspendLayout();
            this.groupBoxGraphe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGraph)).BeginInit();
            this.groupBoxVilles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVille)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.villesNameBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grapheBindingSource)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dimensionNumeric)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBoxArbre.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanelSolution.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxDonnees
            // 
            this.groupBoxDonnees.Controls.Add(this.groupBoxGraphe);
            this.groupBoxDonnees.Controls.Add(this.groupBoxVilles);
            this.groupBoxDonnees.Controls.Add(this.tableLayoutPanel2);
            this.groupBoxDonnees.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxDonnees.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxDonnees.Location = new System.Drawing.Point(3, 3);
            this.groupBoxDonnees.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxDonnees.Name = "groupBoxDonnees";
            this.groupBoxDonnees.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxDonnees.Size = new System.Drawing.Size(1161, 497);
            this.groupBoxDonnees.TabIndex = 1;
            this.groupBoxDonnees.TabStop = false;
            this.groupBoxDonnees.Text = "Paramétrage";
            // 
            // groupBoxGraphe
            // 
            this.groupBoxGraphe.Controls.Add(this.dataGridViewGraph);
            this.groupBoxGraphe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxGraphe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxGraphe.Location = new System.Drawing.Point(151, 53);
            this.groupBoxGraphe.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxGraphe.Name = "groupBoxGraphe";
            this.groupBoxGraphe.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxGraphe.Size = new System.Drawing.Size(1006, 440);
            this.groupBoxGraphe.TabIndex = 4;
            this.groupBoxGraphe.TabStop = false;
            this.groupBoxGraphe.Text = "Graphe";
            // 
            // dataGridViewGraph
            // 
            this.dataGridViewGraph.AllowUserToAddRows = false;
            this.dataGridViewGraph.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewGraph.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewGraph.ColumnHeadersHeight = 70;
            this.dataGridViewGraph.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewGraph.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewGraph.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewGraph.Location = new System.Drawing.Point(4, 19);
            this.dataGridViewGraph.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewGraph.Name = "dataGridViewGraph";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewGraph.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewGraph.RowHeadersWidth = 70;
            this.dataGridViewGraph.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridViewGraph.Size = new System.Drawing.Size(998, 417);
            this.dataGridViewGraph.TabIndex = 0;
            this.dataGridViewGraph.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewGraph_CellEndEdit);
            this.dataGridViewGraph.Validated += new System.EventHandler(this.dataGridViewGraph_Validated);
            // 
            // groupBoxVilles
            // 
            this.groupBoxVilles.Controls.Add(this.dataGridViewVille);
            this.groupBoxVilles.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBoxVilles.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxVilles.Location = new System.Drawing.Point(4, 53);
            this.groupBoxVilles.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxVilles.Name = "groupBoxVilles";
            this.groupBoxVilles.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxVilles.Size = new System.Drawing.Size(147, 440);
            this.groupBoxVilles.TabIndex = 5;
            this.groupBoxVilles.TabStop = false;
            this.groupBoxVilles.Text = "Villes";
            // 
            // dataGridViewVille
            // 
            this.dataGridViewVille.AllowUserToAddRows = false;
            this.dataGridViewVille.AllowUserToDeleteRows = false;
            this.dataGridViewVille.AutoGenerateColumns = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewVille.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewVille.ColumnHeadersHeight = 25;
            this.dataGridViewVille.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn});
            this.dataGridViewVille.DataSource = this.villesNameBindingSource;
            this.dataGridViewVille.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewVille.Location = new System.Drawing.Point(4, 19);
            this.dataGridViewVille.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewVille.Name = "dataGridViewVille";
            this.dataGridViewVille.RowHeadersWidth = 25;
            this.dataGridViewVille.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridViewVille.Size = new System.Drawing.Size(139, 417);
            this.dataGridViewVille.TabIndex = 0;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // villesNameBindingSource
            // 
            this.villesNameBindingSource.DataMember = "VillesName";
            this.villesNameBindingSource.DataSource = this.grapheBindingSource;
            this.villesNameBindingSource.CurrentItemChanged += new System.EventHandler(this.villesBindingSource_CurrentItemChanged);
            // 
            // grapheBindingSource
            // 
            this.grapheBindingSource.DataSource = typeof(ROA.TP2.Little.Graphe);
            this.grapheBindingSource.CurrentItemChanged += new System.EventHandler(this.grapheBindingSource_CurrentItemChanged);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 9;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.692124F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.38425F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.692124F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.38425F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.692124F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.692124F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.689582F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.38425F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.38916F));
            this.tableLayoutPanel2.Controls.Add(this.buttonCalculer, 8, 0);
            this.tableLayoutPanel2.Controls.Add(this.generateButton, 7, 0);
            this.tableLayoutPanel2.Controls.Add(this.dimensionNumeric, 5, 0);
            this.tableLayoutPanel2.Controls.Add(this.label1, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.comboBoxTemplates, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label3, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.textBoxName, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.checkBoxSemetrique, 6, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(4, 19);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1153, 34);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // buttonCalculer
            // 
            this.buttonCalculer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonCalculer.Location = new System.Drawing.Point(974, 3);
            this.buttonCalculer.Name = "buttonCalculer";
            this.buttonCalculer.Size = new System.Drawing.Size(176, 28);
            this.buttonCalculer.TabIndex = 10;
            this.buttonCalculer.Text = "Calculer Solution";
            this.buttonCalculer.UseVisualStyleBackColor = true;
            this.buttonCalculer.Click += new System.EventHandler(this.calculerButton_Click);
            // 
            // generateButton
            // 
            this.generateButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.generateButton.Location = new System.Drawing.Point(798, 4);
            this.generateButton.Margin = new System.Windows.Forms.Padding(4);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(169, 26);
            this.generateButton.TabIndex = 9;
            this.generateButton.Text = "Générer Graphe";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // dimensionNumeric
            // 
            this.dimensionNumeric.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.grapheBindingSource, "Dimension", true));
            this.dimensionNumeric.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dimensionNumeric.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dimensionNumeric.Location = new System.Drawing.Point(622, 4);
            this.dimensionNumeric.Margin = new System.Windows.Forms.Padding(4);
            this.dimensionNumeric.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.dimensionNumeric.Name = "dimensionNumeric";
            this.dimensionNumeric.Size = new System.Drawing.Size(80, 22);
            this.dimensionNumeric.TabIndex = 8;
            this.dimensionNumeric.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(269, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 34);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nom";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 34);
            this.label2.TabIndex = 11;
            this.label2.Text = "Modèle";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboBoxTemplates
            // 
            this.comboBoxTemplates.DataSource = this.grapheBindingSource;
            this.comboBoxTemplates.DisplayMember = "Nom";
            this.comboBoxTemplates.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxTemplates.FormattingEnabled = true;
            this.comboBoxTemplates.Location = new System.Drawing.Point(91, 3);
            this.comboBoxTemplates.Name = "comboBoxTemplates";
            this.comboBoxTemplates.Size = new System.Drawing.Size(171, 24);
            this.comboBoxTemplates.TabIndex = 12;
            this.comboBoxTemplates.ValueMember = "Nom";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(533, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 34);
            this.label3.TabIndex = 13;
            this.label3.Text = "Dimension";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxName
            // 
            this.textBoxName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.grapheBindingSource, "Nom", true));
            this.textBoxName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxName.Location = new System.Drawing.Point(356, 3);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(171, 22);
            this.textBoxName.TabIndex = 14;
            // 
            // checkBoxSemetrique
            // 
            this.checkBoxSemetrique.Checked = true;
            this.checkBoxSemetrique.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxSemetrique.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.grapheBindingSource, "Semetrique", true));
            this.checkBoxSemetrique.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBoxSemetrique.Location = new System.Drawing.Point(709, 3);
            this.checkBoxSemetrique.Name = "checkBoxSemetrique";
            this.checkBoxSemetrique.Size = new System.Drawing.Size(82, 28);
            this.checkBoxSemetrique.TabIndex = 15;
            this.checkBoxSemetrique.Text = "Symétrique";
            this.checkBoxSemetrique.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 532);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(19, 0, 1, 0);
            this.statusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.statusStrip1.Size = new System.Drawing.Size(1175, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(266, 17);
            this.toolStripStatusLabel1.Text = "ZEMMOURI Mohamed m.zemmouri@gmail.com";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1175, 532);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBoxDonnees);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1167, 503);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Données";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.splitContainer1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1167, 503);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Solution";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBoxArbre);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer1.Size = new System.Drawing.Size(1161, 497);
            this.splitContainer1.SplitterDistance = 387;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupBoxArbre
            // 
            this.groupBoxArbre.Controls.Add(this.treeViewGraphe);
            this.groupBoxArbre.Controls.Add(this.groupBox1);
            this.groupBoxArbre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxArbre.Location = new System.Drawing.Point(0, 0);
            this.groupBoxArbre.Name = "groupBoxArbre";
            this.groupBoxArbre.Size = new System.Drawing.Size(387, 497);
            this.groupBoxArbre.TabIndex = 12;
            this.groupBoxArbre.TabStop = false;
            this.groupBoxArbre.Text = "Arbre de Solution";
            // 
            // treeViewGraphe
            // 
            this.treeViewGraphe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeViewGraphe.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeViewGraphe.ImageIndex = 0;
            this.treeViewGraphe.ImageList = this.imageList1;
            this.treeViewGraphe.Location = new System.Drawing.Point(3, 18);
            this.treeViewGraphe.Name = "treeViewGraphe";
            this.treeViewGraphe.SelectedImageIndex = 0;
            this.treeViewGraphe.Size = new System.Drawing.Size(381, 308);
            this.treeViewGraphe.TabIndex = 14;
            this.treeViewGraphe.BeforeCheck += new System.Windows.Forms.TreeViewCancelEventHandler(this.treeViewGraphe_BeforeCheck);
            this.treeViewGraphe.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewGraphe_AfterSelect);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "0");
            this.imageList1.Images.SetKeyName(1, "1");
            this.imageList1.Images.SetKeyName(2, "2");
            this.imageList1.Images.SetKeyName(3, "3");
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cellControlLegende);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(3, 326);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(381, 168);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Legende";
            // 
            // cellControlLegende
            // 
            this.cellControlLegende.BackColor = System.Drawing.Color.LemonChiffon;
            this.cellControlLegende.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cellControlLegende.Location = new System.Drawing.Point(3, 18);
            this.cellControlLegende.Margin = new System.Windows.Forms.Padding(4);
            this.cellControlLegende.Name = "cellControlLegende";
            this.cellControlLegende.Reduction = -1F;
            this.cellControlLegende.Regret = -1F;
            this.cellControlLegende.Size = new System.Drawing.Size(375, 147);
            this.cellControlLegende.TabIndex = 0;
            this.cellControlLegende.Valeur = -1F;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoScroll = true;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanelSolution, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(770, 497);
            this.tableLayoutPanel1.TabIndex = 11;
            // 
            // tableLayoutPanelSolution
            // 
            this.tableLayoutPanelSolution.AutoScroll = true;
            this.tableLayoutPanelSolution.AutoSize = true;
            this.tableLayoutPanelSolution.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanelSolution.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanelSolution.ColumnCount = 1;
            this.tableLayoutPanelSolution.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 108F));
            this.tableLayoutPanelSolution.Controls.Add(this.labelVille, 0, 0);
            this.tableLayoutPanelSolution.Location = new System.Drawing.Point(3, 38);
            this.tableLayoutPanelSolution.Name = "tableLayoutPanelSolution";
            this.tableLayoutPanelSolution.RowCount = 1;
            this.tableLayoutPanelSolution.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 71F));
            this.tableLayoutPanelSolution.Size = new System.Drawing.Size(110, 73);
            this.tableLayoutPanelSolution.TabIndex = 2;
            // 
            // labelVille
            // 
            this.labelVille.BackColor = System.Drawing.SystemColors.Control;
            this.labelVille.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelVille.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVille.Location = new System.Drawing.Point(1, 1);
            this.labelVille.Margin = new System.Windows.Forms.Padding(0);
            this.labelVille.Name = "labelVille";
            this.labelVille.Size = new System.Drawing.Size(108, 71);
            this.labelVille.TabIndex = 0;
            this.labelVille.Text = "Villes";
            this.labelVille.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelSolution);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.labelEvaluation);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(764, 29);
            this.panel1.TabIndex = 1;
            // 
            // labelSolution
            // 
            this.labelSolution.BackColor = System.Drawing.Color.WhiteSmoke;
            this.labelSolution.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelSolution.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.labelSolution.Location = new System.Drawing.Point(300, 0);
            this.labelSolution.Name = "labelSolution";
            this.labelSolution.Size = new System.Drawing.Size(464, 29);
            this.labelSolution.TabIndex = 5;
            this.labelSolution.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label13.Dock = System.Windows.Forms.DockStyle.Left;
            this.label13.Location = new System.Drawing.Point(200, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(100, 29);
            this.label13.TabIndex = 11;
            this.label13.Text = "Trajet :";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelEvaluation
            // 
            this.labelEvaluation.BackColor = System.Drawing.Color.WhiteSmoke;
            this.labelEvaluation.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelEvaluation.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.labelEvaluation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.labelEvaluation.Location = new System.Drawing.Point(100, 0);
            this.labelEvaluation.Name = "labelEvaluation";
            this.labelEvaluation.Size = new System.Drawing.Size(100, 29);
            this.labelEvaluation.TabIndex = 10;
            this.labelEvaluation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label7.Dock = System.Windows.Forms.DockStyle.Left;
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 29);
            this.label7.TabIndex = 4;
            this.label7.Text = "Coût Solution :";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolTipSolution
            // 
            this.toolTipSolution.IsBalloon = true;
            this.toolTipSolution.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipSolution.ToolTipTitle = "Description";
            // 
            // FormLittle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1175, 554);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormLittle";
            this.Text = "TP 2 : TSP Little";
            this.Load += new System.EventHandler(this.FormLittle_Load);
            this.groupBoxDonnees.ResumeLayout(false);
            this.groupBoxGraphe.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGraph)).EndInit();
            this.groupBoxVilles.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVille)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.villesNameBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grapheBindingSource)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dimensionNumeric)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBoxArbre.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanelSolution.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBoxDonnees;
        private System.Windows.Forms.DataGridView dataGridViewGraph;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.GroupBox groupBoxGraphe;
        private System.Windows.Forms.Button buttonCalculer;
        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.NumericUpDown dimensionNumeric;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxTemplates;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelSolution;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label labelEvaluation;
        private System.Windows.Forms.CheckBox checkBoxSemetrique;
        private System.Windows.Forms.GroupBox groupBoxVilles;
        private System.Windows.Forms.DataGridView dataGridViewVille;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelSolution;
        private System.Windows.Forms.Label labelVille;
        private System.Windows.Forms.ToolTip toolTipSolution;
        private System.Windows.Forms.BindingSource grapheBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource villesNameBindingSource;
        private System.Windows.Forms.GroupBox groupBoxArbre;
        private System.Windows.Forms.GroupBox groupBox1;
        private CellControl cellControlLegende;
        private System.Windows.Forms.TreeView treeViewGraphe;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ImageList imageList1;
    }
}

