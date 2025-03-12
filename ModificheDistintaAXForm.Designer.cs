namespace OtoTools
{
    partial class ModificheDistintaAXForm
    {
        private System.ComponentModel.IContainer components = null;
        public System.Windows.Forms.DataGridView dataGridViewReport;
        private System.Windows.Forms.Label lblModificheAX;

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
            dataGridViewReport = new DataGridView();
            lblModificheAX = new Label();
            buttonCopy = new Button();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridViewReport).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewReport
            // 
            dataGridViewReport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewReport.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1 });
            dataGridViewReport.Location = new Point(12, 50);
            dataGridViewReport.Name = "dataGridViewReport";
            dataGridViewReport.RowHeadersVisible = false;
            dataGridViewReport.RowHeadersWidth = 51;
            dataGridViewReport.Size = new Size(758, 638);
            dataGridViewReport.TabIndex = 0;
            // 
            // lblModificheAX
            // 
            lblModificheAX.AutoSize = true;
            lblModificheAX.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblModificheAX.Location = new Point(12, 20);
            lblModificheAX.Name = "lblModificheAX";
            lblModificheAX.Size = new Size(323, 20);
            lblModificheAX.TabIndex = 1;
            lblModificheAX.Text = "Modifiche necessarie a DISTINTA AX";
            // 
            // buttonCopy
            // 
            buttonCopy.Location = new Point(359, 695);
            buttonCopy.Margin = new Padding(3, 4, 3, 4);
            buttonCopy.Name = "buttonCopy";
            buttonCopy.Size = new Size(57, 45);
            buttonCopy.TabIndex = 9;
            buttonCopy.Text = "Copia";
            buttonCopy.UseVisualStyleBackColor = true;
            buttonCopy.Click += ButtonCopy_Click;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Modifica";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.Width = 750;
            // 
            // ModificheDistintaAXForm
            // 
            ClientSize = new Size(782, 753);
            Controls.Add(buttonCopy);
            Controls.Add(lblModificheAX);
            Controls.Add(dataGridViewReport);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "ModificheDistintaAXForm";
            Text = "Modifiche Distinta AX";
            ((System.ComponentModel.ISupportInitialize)dataGridViewReport).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button buttonCopy;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    }
}
