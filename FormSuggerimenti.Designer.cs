namespace OtoTools
{
    //partial class FormSuggerimenti
    //{
    //    private System.ComponentModel.IContainer components = null;
    //    private TextBox txtSuggerimenti;
    //    private Button btnInvia;

    //    protected override void Dispose(bool disposing)
    //    {
    //        if (disposing && (components != null))
    //        {
    //            components.Dispose();
    //        }
    //        base.Dispose(disposing);
    //    }

    //    private void InitializeComponent()
    //    {
    //        txtSuggerimenti = new TextBox();
    //        btnInvia = new Button();
    //        label1 = new Label();
    //        SuspendLayout();
    //        // 
    //        // txtSuggerimenti
    //        // 
    //        txtSuggerimenti.Location = new Point(12, 64);
    //        txtSuggerimenti.Margin = new Padding(3, 4, 3, 4);
    //        txtSuggerimenti.Multiline = true;
    //        txtSuggerimenti.Name = "txtSuggerimenti";
    //        txtSuggerimenti.ScrollBars = ScrollBars.Vertical;
    //        txtSuggerimenti.Size = new Size(507, 230);
    //        txtSuggerimenti.TabIndex = 0;
    //        // 
    //        // btnInvia
    //        // 
    //        btnInvia.Location = new Point(218, 302);
    //        btnInvia.Margin = new Padding(3, 4, 3, 4);
    //        btnInvia.Name = "btnInvia";
    //        btnInvia.Size = new Size(80, 38);
    //        btnInvia.TabIndex = 1;
    //        btnInvia.Text = "Invia";
    //        btnInvia.UseVisualStyleBackColor = true;
    //        btnInvia.Click += BtnInvia_Click;
    //        // 
    //        // label1
    //        // 
    //        label1.AutoSize = true;
    //        label1.Location = new Point(12, 23);
    //        label1.Name = "label1";
    //        label1.Size = new Size(507, 20);
    //        label1.TabIndex = 2;
    //        label1.Text = "Suggerisci i miglioramenti o indica i problemi che riscontri nel programma:";
    //        // 
    //        // FormSuggerimenti
    //        // 
    //        AutoScaleDimensions = new SizeF(8F, 20F);
    //        AutoScaleMode = AutoScaleMode.Font;
    //        ClientSize = new Size(532, 353);
    //        Controls.Add(label1);
    //        Controls.Add(btnInvia);
    //        Controls.Add(txtSuggerimenti);
    //        Margin = new Padding(3, 4, 3, 4);
    //        Name = "FormSuggerimenti";
    //        Text = "Suggerimenti e Miglioramenti";
    //        ResumeLayout(false);
    //        PerformLayout();
    //    }

    //    private Label label1;
    //}

    // Designer File
    partial class FormSuggerimenti
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox txtSuggerimenti;
        private Button btnInvia;
        private DataGridView dgvSuggerimenti;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            txtSuggerimenti = new TextBox();
            btnInvia = new Button();
            dgvSuggerimenti = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvSuggerimenti).BeginInit();
            SuspendLayout();
            // 
            // txtSuggerimenti
            // 
            txtSuggerimenti.Location = new Point(12, 15);
            txtSuggerimenti.Margin = new Padding(3, 4, 3, 4);
            txtSuggerimenti.Multiline = true;
            txtSuggerimenti.Name = "txtSuggerimenti";
            txtSuggerimenti.ScrollBars = ScrollBars.Vertical;
            txtSuggerimenti.Size = new Size(558, 124);
            txtSuggerimenti.TabIndex = 0;
            // 
            // btnInvia
            // 
            btnInvia.Location = new Point(12, 150);
            btnInvia.Margin = new Padding(3, 4, 3, 4);
            btnInvia.Name = "btnInvia";
            btnInvia.Size = new Size(80, 38);
            btnInvia.TabIndex = 1;
            btnInvia.Text = "Invia";
            btnInvia.UseVisualStyleBackColor = true;
            btnInvia.Click += BtnInvia_Click;
            // 
            // dgvSuggerimenti
            // 
            dgvSuggerimenti.AllowUserToAddRows = false;
            dgvSuggerimenti.AllowUserToDeleteRows = false;
            dgvSuggerimenti.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSuggerimenti.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2 });
            dgvSuggerimenti.Location = new Point(12, 200);
            dgvSuggerimenti.Margin = new Padding(3, 4, 3, 4);
            dgvSuggerimenti.Name = "dgvSuggerimenti";
            dgvSuggerimenti.ReadOnly = true;
            dgvSuggerimenti.RowHeadersVisible = false;
            dgvSuggerimenti.RowHeadersWidth = 51;
            dgvSuggerimenti.Size = new Size(558, 340);
            dgvSuggerimenti.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewTextBoxColumn1.HeaderText = "Data e Ora";
            dataGridViewTextBoxColumn1.MinimumWidth = 16;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            dataGridViewTextBoxColumn1.Width = 110;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewTextBoxColumn2.HeaderText = "Descrizione suggerimento";
            dataGridViewTextBoxColumn2.MinimumWidth = 16;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            dataGridViewTextBoxColumn2.Width = 192;
            // 
            // FormSuggerimenti
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(582, 553);
            Controls.Add(dgvSuggerimenti);
            Controls.Add(btnInvia);
            Controls.Add(txtSuggerimenti);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormSuggerimenti";
            Text = "Suggerimenti e Miglioramenti";
            ((System.ComponentModel.ISupportInitialize)dgvSuggerimenti).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}