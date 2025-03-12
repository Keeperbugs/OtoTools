namespace OtoTools
{
    partial class import
    {
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">true se le risorse gestite devono essere eliminate; false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo richiesto per il supporto della finestra di progettazione - non modificare
        /// il contenuto di questo metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            buttonImport = new Button();
            dataGridView1 = new DataGridView();
            comboBoxSeparator = new ComboBox();
            labelSeparator = new Label();
            checkedListBoxColumns = new CheckedListBox();
            buttonDeleteColumns = new Button();
            labelColumns = new Label();
            buttonCopy = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // buttonImport
            // 
            buttonImport.Location = new Point(10, 11);
            buttonImport.Name = "buttonImport";
            buttonImport.Size = new Size(83, 22);
            buttonImport.TabIndex = 0;
            buttonImport.Text = "Importa File";
            buttonImport.UseVisualStyleBackColor = true;
            buttonImport.Click += ButtonImport_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(10, 38);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 24;
            dataGridView1.Size = new Size(525, 372);
            dataGridView1.TabIndex = 1;
            // 
            // comboBoxSeparator
            // 
            comboBoxSeparator.FormattingEnabled = true;
            comboBoxSeparator.Items.AddRange(new object[] { ",", ";", "\\t", "|" });
            comboBoxSeparator.Location = new Point(298, 11);
            comboBoxSeparator.Name = "comboBoxSeparator";
            comboBoxSeparator.Size = new Size(106, 23);
            comboBoxSeparator.TabIndex = 2;
            // 
            // labelSeparator
            // 
            labelSeparator.AutoSize = true;
            labelSeparator.Location = new Point(192, 14);
            labelSeparator.Name = "labelSeparator";
            labelSeparator.Size = new Size(90, 15);
            labelSeparator.TabIndex = 3;
            labelSeparator.Text = "Separatore CSV:";
            // 
            // checkedListBoxColumns
            // 
            checkedListBoxColumns.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            checkedListBoxColumns.FormattingEnabled = true;
            checkedListBoxColumns.Location = new Point(541, 38);
            checkedListBoxColumns.Name = "checkedListBoxColumns";
            checkedListBoxColumns.Size = new Size(149, 274);
            checkedListBoxColumns.TabIndex = 4;
            // 
            // buttonDeleteColumns
            // 
            buttonDeleteColumns.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonDeleteColumns.Location = new Point(541, 334);
            buttonDeleteColumns.Name = "buttonDeleteColumns";
            buttonDeleteColumns.Size = new Size(149, 50);
            buttonDeleteColumns.TabIndex = 5;
            buttonDeleteColumns.Text = "Mantieni Colonne Selezionate";
            buttonDeleteColumns.UseVisualStyleBackColor = true;
            buttonDeleteColumns.Click += ButtonDeleteColumns_Click;
            // 
            // labelColumns
            // 
            labelColumns.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelColumns.AutoSize = true;
            labelColumns.Location = new Point(538, 20);
            labelColumns.Name = "labelColumns";
            labelColumns.Size = new Size(114, 15);
            labelColumns.TabIndex = 6;
            labelColumns.Text = "Colonne Disponibili:";
            // 
            // buttonCopy
            // 
            buttonCopy.Location = new Point(99, 11);
            buttonCopy.Name = "buttonCopy";
            buttonCopy.Size = new Size(50, 22);
            buttonCopy.TabIndex = 8;
            buttonCopy.Text = "Copia";
            buttonCopy.UseVisualStyleBackColor = true;
            buttonCopy.Click += ButtonCopy_Click;
            // 
            // import
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 422);
            Controls.Add(buttonCopy);
            Controls.Add(labelColumns);
            Controls.Add(buttonDeleteColumns);
            Controls.Add(checkedListBoxColumns);
            Controls.Add(labelSeparator);
            Controls.Add(comboBoxSeparator);
            Controls.Add(dataGridView1);
            Controls.Add(buttonImport);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "import";
            Text = "Importa File Excel";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button buttonImport;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBoxSeparator;
        private System.Windows.Forms.Label labelSeparator;
        private System.Windows.Forms.CheckedListBox checkedListBoxColumns;
        private System.Windows.Forms.Button buttonDeleteColumns;
        private System.Windows.Forms.Label labelColumns;
        private System.Windows.Forms.Button buttonCopy;
    }
}
