namespace OtoTools
{
    partial class ConfrontaDistinte
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvDistintaCREO;
        private System.Windows.Forms.Label lblDistintaAX;
        private System.Windows.Forms.Label lblDistintaCREO;


        /// <summary>
        /// Pulizia delle risorse utilizzate.
        /// </summary>
        /// <param name="disposing">True se le risorse gestite devono essere eliminate; False in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Windows Form Designer

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            dgvDistintaCREO = new DataGridView();
            dataGridViewTextBoxColumn10 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            lblDistintaAX = new Label();
            lblDistintaCREO = new Label();
            toolTip1 = new ToolTip(components);
            button1 = new Button();
            dataGridViewTextBoxColumn8 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn9 = new DataGridViewTextBoxColumn();
            dgvDistintaAX = new DataGridView();
            splitContainer1 = new SplitContainer();
            tableLayoutPanel1 = new TableLayoutPanel();
            splitContainer2 = new SplitContainer();
            tableLayoutPanel2 = new TableLayoutPanel();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button5 = new Button();
            tableLayoutPanel3 = new TableLayoutPanel();
            label8 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label2 = new Label();
            buttonSuggest = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvDistintaCREO).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDistintaAX).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // dgvDistintaCREO
            // 
            dgvDistintaCREO.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDistintaCREO.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn10, dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4 });
            dgvDistintaCREO.Dock = DockStyle.Fill;
            dgvDistintaCREO.Location = new Point(413, 23);
            dgvDistintaCREO.Name = "dgvDistintaCREO";
            dgvDistintaCREO.RowHeadersWidth = 70;
            dgvDistintaCREO.Size = new Size(364, 497);
            dgvDistintaCREO.TabIndex = 1;
            dgvDistintaCREO.KeyDown += DataGridView_KeyDown;
            // 
            // dataGridViewTextBoxColumn10
            // 
            dataGridViewTextBoxColumn10.HeaderText = "Gruppo";
            dataGridViewTextBoxColumn10.MinimumWidth = 6;
            dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            dataGridViewTextBoxColumn10.Width = 125;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Codice";
            dataGridViewTextBoxColumn1.MinimumWidth = 10;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Descrizione";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ToolTipText = "Non è obbligatorio compilare questa colonna. Non influenza la riuscita del confronto distinte.";
            dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Quantità";
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "Trovato in Distinta AX";
            dataGridViewTextBoxColumn4.MinimumWidth = 6;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            dataGridViewTextBoxColumn4.Width = 125;
            // 
            // lblDistintaAX
            // 
            lblDistintaAX.AutoSize = true;
            lblDistintaAX.Location = new Point(23, 0);
            lblDistintaAX.Name = "lblDistintaAX";
            lblDistintaAX.Size = new Size(75, 15);
            lblDistintaAX.TabIndex = 3;
            lblDistintaAX.Text = "DISTINTA AX";
            // 
            // lblDistintaCREO
            // 
            lblDistintaCREO.AutoSize = true;
            lblDistintaCREO.Location = new Point(413, 0);
            lblDistintaCREO.Name = "lblDistintaCREO";
            lblDistintaCREO.Size = new Size(90, 15);
            lblDistintaCREO.TabIndex = 4;
            lblDistintaCREO.Text = "DISTINTA CREO";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top;
            button1.Location = new Point(583, 3);
            button1.Name = "button1";
            button1.Size = new Size(114, 52);
            button1.TabIndex = 29;
            button1.Text = "Nascondi Descrizione";
            toolTip1.SetToolTip(button1, "Nascone le colonne DESCRIZIONE.");
            button1.UseVisualStyleBackColor = true;
            button1.Click += ButtonHideDescrizione_Click;
            // 
            // dataGridViewTextBoxColumn8
            // 
            dataGridViewTextBoxColumn8.HeaderText = "Trovato in Distinta CREO";
            dataGridViewTextBoxColumn8.MinimumWidth = 6;
            dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            dataGridViewTextBoxColumn8.ReadOnly = true;
            dataGridViewTextBoxColumn8.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            dataGridViewTextBoxColumn7.HeaderText = "Quantità";
            dataGridViewTextBoxColumn7.MinimumWidth = 6;
            dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            dataGridViewTextBoxColumn7.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.HeaderText = "Descrizione";
            dataGridViewTextBoxColumn6.MinimumWidth = 6;
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            dataGridViewTextBoxColumn6.ToolTipText = "Non è obbligatorio compilare questa colonna. Non influenza la riuscita del confronto distinte.";
            dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.HeaderText = "Codice";
            dataGridViewTextBoxColumn5.MinimumWidth = 10;
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn9
            // 
            dataGridViewTextBoxColumn9.HeaderText = "Gruppo";
            dataGridViewTextBoxColumn9.MinimumWidth = 6;
            dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            dataGridViewTextBoxColumn9.Width = 125;
            // 
            // dgvDistintaAX
            // 
            dgvDistintaAX.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDistintaAX.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn9, dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6, dataGridViewTextBoxColumn7, dataGridViewTextBoxColumn8 });
            dgvDistintaAX.Dock = DockStyle.Fill;
            dgvDistintaAX.Location = new Point(23, 23);
            dgvDistintaAX.Name = "dgvDistintaAX";
            dgvDistintaAX.RowHeadersWidth = 70;
            dgvDistintaAX.Size = new Size(364, 497);
            dgvDistintaAX.TabIndex = 0;
            dgvDistintaAX.KeyDown += DataGridView_KeyDown;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(tableLayoutPanel1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(splitContainer2);
            splitContainer1.Size = new Size(800, 774);
            splitContainer1.SplitterDistance = 523;
            splitContainer1.TabIndex = 19;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 5;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(dgvDistintaAX, 1, 1);
            tableLayoutPanel1.Controls.Add(dgvDistintaCREO, 3, 1);
            tableLayoutPanel1.Controls.Add(lblDistintaAX, 1, 0);
            tableLayoutPanel1.Controls.Add(lblDistintaCREO, 3, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(800, 523);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            splitContainer2.Dock = DockStyle.Fill;
            splitContainer2.FixedPanel = FixedPanel.Panel1;
            splitContainer2.IsSplitterFixed = true;
            splitContainer2.Location = new Point(0, 0);
            splitContainer2.Name = "splitContainer2";
            splitContainer2.Orientation = Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(tableLayoutPanel2);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(tableLayoutPanel3);
            splitContainer2.Size = new Size(800, 247);
            splitContainer2.SplitterDistance = 60;
            splitContainer2.TabIndex = 39;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.AutoSize = true;
            tableLayoutPanel2.ColumnCount = 7;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(button4, 1, 0);
            tableLayoutPanel2.Controls.Add(button3, 2, 0);
            tableLayoutPanel2.Controls.Add(button2, 3, 0);
            tableLayoutPanel2.Controls.Add(button5, 4, 0);
            tableLayoutPanel2.Controls.Add(button1, 5, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.Size = new Size(800, 60);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Top;
            button4.Location = new Point(103, 3);
            button4.Name = "button4";
            button4.Size = new Size(114, 52);
            button4.TabIndex = 25;
            button4.Text = "Avvia Confronto";
            button4.UseVisualStyleBackColor = true;
            button4.Click += BtnConfronta_Click;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Top;
            button3.Location = new Point(223, 3);
            button3.Name = "button3";
            button3.Size = new Size(114, 52);
            button3.TabIndex = 26;
            button3.Text = "Mostra Report";
            button3.UseVisualStyleBackColor = true;
            button3.Click += BtnApriModifiche_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top;
            button2.Location = new Point(343, 3);
            button2.Name = "button2";
            button2.Size = new Size(114, 52);
            button2.TabIndex = 27;
            button2.Text = "Reset Tabelle";
            button2.UseVisualStyleBackColor = true;
            button2.Click += BtnResetTabelle_Click;
            // 
            // button5
            // 
            button5.Anchor = AnchorStyles.Top;
            button5.Location = new Point(463, 3);
            button5.Name = "button5";
            button5.Size = new Size(114, 52);
            button5.TabIndex = 28;
            button5.Text = "Apri Import";
            button5.UseVisualStyleBackColor = true;
            button5.Click += BtnApriImport_Click;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.AutoSize = true;
            tableLayoutPanel3.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel3.ColumnCount = 3;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(label8, 1, 5);
            tableLayoutPanel3.Controls.Add(label3, 1, 0);
            tableLayoutPanel3.Controls.Add(label4, 1, 1);
            tableLayoutPanel3.Controls.Add(label5, 1, 2);
            tableLayoutPanel3.Controls.Add(label6, 1, 3);
            tableLayoutPanel3.Controls.Add(label7, 1, 4);
            tableLayoutPanel3.Controls.Add(label2, 2, 8);
            tableLayoutPanel3.Controls.Add(buttonSuggest, 2, 7);
            tableLayoutPanel3.Controls.Add(label1, 2, 9);
            tableLayoutPanel3.Dock = DockStyle.Bottom;
            tableLayoutPanel3.Location = new Point(0, 17);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 11;
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.Size = new Size(800, 166);
            tableLayoutPanel3.TabIndex = 42;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top;
            label8.AutoSize = true;
            label8.BackColor = Color.Fuchsia;
            label8.ForeColor = SystemColors.ActiveCaptionText;
            label8.Location = new Point(208, 75);
            label8.Name = "label8";
            label8.Size = new Size(383, 15);
            label8.TabIndex = 35;
            label8.Text = "FUCHSIA: COMPONENTI PRESENTI PIù VOLTE NELLA STESSA DISTINTA";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Location = new Point(348, 0);
            label3.Name = "label3";
            label3.Size = new Size(103, 15);
            label3.TabIndex = 30;
            label3.Text = "LEGENDA COLORI";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.BackColor = Color.Red;
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(177, 15);
            label4.Name = "label4";
            label4.Size = new Size(446, 15);
            label4.TabIndex = 31;
            label4.Text = "ROSSO: COMPONENTI NON TROVATI IN CREO DA ELIMINARE DALLA DISTINTA AX";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.AutoSize = true;
            label5.BackColor = Color.Yellow;
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(196, 30);
            label5.Name = "label5";
            label5.Size = new Size(407, 15);
            label5.TabIndex = 32;
            label5.Text = "GIALLO: COMPONENTI PRESENTI IN CREO CON QUANTITA' VARIATA IN AX";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top;
            label6.AutoSize = true;
            label6.BackColor = Color.Lime;
            label6.ForeColor = SystemColors.ActiveCaptionText;
            label6.Location = new Point(224, 45);
            label6.Name = "label6";
            label6.Size = new Size(352, 15);
            label6.TabIndex = 33;
            label6.Text = "VERDE: COMPONENTI TROVATI IN CREO DA AGGIUNGERE AD AX";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top;
            label7.AutoSize = true;
            label7.BackColor = Color.Cyan;
            label7.ForeColor = SystemColors.ActiveCaptionText;
            label7.Location = new Point(190, 60);
            label7.Name = "label7";
            label7.Size = new Size(420, 15);
            label7.TabIndex = 34;
            label7.Text = "AZZURRO: COMPONENTI PRESENTI IN AX CON QUANTITA' VARIATA IN CREO";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(650, 136);
            label2.Name = "label2";
            label2.Size = new Size(147, 15);
            label2.TabIndex = 40;
            label2.Text = "Creato da Martina Luciano";
            // 
            // buttonSuggest
            // 
            buttonSuggest.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonSuggest.Location = new Point(677, 93);
            buttonSuggest.Name = "buttonSuggest";
            buttonSuggest.Size = new Size(120, 40);
            buttonSuggest.TabIndex = 41;
            buttonSuggest.Text = "Suggerimenti";
            buttonSuggest.UseVisualStyleBackColor = true;
            buttonSuggest.Click += ButtonSuggest_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(644, 151);
            label1.Name = "label1";
            label1.Size = new Size(153, 15);
            label1.TabIndex = 39;
            label1.Text = "ConfrontaDistinte vers. 1.6b";
            // 
            // ConfrontaDistinte
            // 
            Controls.Add(splitContainer1);
            Name = "ConfrontaDistinte";
            Size = new Size(800, 774);
            ((System.ComponentModel.ISupportInitialize)dgvDistintaCREO).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDistintaAX).EndInit();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel1.PerformLayout();
            splitContainer2.Panel2.ResumeLayout(false);
            splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private ToolTip toolTip1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private DataGridView dgvDistintaAX;
        private SplitContainer splitContainer1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private SplitContainer splitContainer2;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private Label label1;
        private Button buttonSuggest;
        private Label label2;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button5;
        private Button button1;

        public FormBorderStyle FormBorderStyle { get; private set; }
        public bool MaximizeBox { get; private set; }
    }
}
