namespace OtoTools
{
    partial class EsportaOre
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label7 = new Label();
            label6 = new Label();
            progressBar1 = new ProgressBar();
            button1 = new Button();
            toDate = new DateTimePicker();
            label5 = new Label();
            label4 = new Label();
            fromDate = new DateTimePicker();
            label3 = new Label();
            CheckBox1 = new CheckBox();
            passBox1 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            userBox1 = new TextBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Location = new Point(121, 83);
            label7.Name = "label7";
            label7.Size = new Size(196, 20);
            label7.TabIndex = 12;
            label7.Text = "Versione 2.0 - by L.MARTINA";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Impact", 30F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(57, 8);
            label6.Name = "label6";
            label6.Size = new Size(324, 63);
            label6.TabIndex = 11;
            label6.Text = "EsportaOre 2.0";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // progressBar1
            // 
            progressBar1.Anchor = AnchorStyles.None;
            progressBar1.Location = new Point(26, 542);
            progressBar1.Margin = new Padding(3, 4, 3, 4);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(386, 19);
            progressBar1.TabIndex = 10;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.AutoSize = true;
            button1.Location = new Point(163, 471);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(113, 40);
            button1.TabIndex = 9;
            button1.Text = "Esporta dati";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Button1_Click;
            // 
            // toDate
            // 
            toDate.Anchor = AnchorStyles.None;
            toDate.Format = DateTimePickerFormat.Short;
            toDate.Location = new Point(154, 436);
            toDate.Margin = new Padding(3, 4, 3, 4);
            toDate.Name = "toDate";
            toDate.Size = new Size(131, 27);
            toDate.TabIndex = 8;
            toDate.ValueChanged += DateTimePicker2_ValueChanged;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Location = new Point(184, 412);
            label5.Name = "label5";
            label5.Size = new Size(70, 20);
            label5.TabIndex = 7;
            label5.Text = "alla data:";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Location = new Point(179, 357);
            label4.Name = "label4";
            label4.Size = new Size(81, 20);
            label4.TabIndex = 5;
            label4.Text = "Dalla data:";
            // 
            // fromDate
            // 
            fromDate.Anchor = AnchorStyles.None;
            fromDate.Format = DateTimePickerFormat.Short;
            fromDate.Location = new Point(154, 381);
            fromDate.Margin = new Padding(3, 4, 3, 4);
            fromDate.Name = "fromDate";
            fromDate.Size = new Size(131, 27);
            fromDate.TabIndex = 6;
            fromDate.ValueChanged += DateTimePicker1_ValueChanged;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Location = new Point(34, 317);
            label3.Name = "label3";
            label3.Size = new Size(371, 40);
            label3.TabIndex = 4;
            label3.Text = "Seleziona l'intervallo di date dalle quali estrarre le ore inserite";
            // 
            // CheckBox1
            // 
            CheckBox1.Anchor = AnchorStyles.None;
            CheckBox1.AutoSize = true;
            CheckBox1.BackgroundImageLayout = ImageLayout.Center;
            CheckBox1.Location = new Point(147, 248);
            CheckBox1.Margin = new Padding(3, 4, 3, 4);
            CheckBox1.Name = "CheckBox1";
            CheckBox1.Size = new Size(144, 24);
            CheckBox1.TabIndex = 3;
            CheckBox1.Text = "Mostra password";
            CheckBox1.UseVisualStyleBackColor = true;
            CheckBox1.CheckedChanged += CheckBox1_CheckedChanged;
            // 
            // passBox1
            // 
            passBox1.Anchor = AnchorStyles.None;
            passBox1.Location = new Point(151, 213);
            passBox1.Margin = new Padding(3, 4, 3, 4);
            passBox1.Name = "passBox1";
            passBox1.Size = new Size(137, 27);
            passBox1.TabIndex = 0;
            passBox1.UseSystemPasswordChar = true;
            passBox1.TextChanged += PassBox1_TextChanged;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Location = new Point(105, 189);
            label2.Name = "label2";
            label2.Size = new Size(229, 20);
            label2.TabIndex = 2;
            label2.Text = "Password (quella di OtoPresenze)";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Location = new Point(126, 134);
            label1.Name = "label1";
            label1.Size = new Size(186, 20);
            label1.TabIndex = 1;
            label1.Text = "Nome utente (es. lmartina)";
            // 
            // userBox1
            // 
            userBox1.Anchor = AnchorStyles.None;
            userBox1.Location = new Point(151, 158);
            userBox1.Margin = new Padding(3, 4, 3, 4);
            userBox1.Name = "userBox1";
            userBox1.Size = new Size(137, 27);
            userBox1.TabIndex = 0;
            userBox1.TextChanged += UserBox1_TextChanged;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 23F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 23F));
            tableLayoutPanel1.Controls.Add(userBox1, 1, 4);
            tableLayoutPanel1.Controls.Add(label1, 1, 3);
            tableLayoutPanel1.Controls.Add(label2, 1, 5);
            tableLayoutPanel1.Controls.Add(passBox1, 1, 6);
            tableLayoutPanel1.Controls.Add(CheckBox1, 1, 7);
            tableLayoutPanel1.Controls.Add(label3, 1, 9);
            tableLayoutPanel1.Controls.Add(fromDate, 1, 11);
            tableLayoutPanel1.Controls.Add(label4, 1, 10);
            tableLayoutPanel1.Controls.Add(label5, 1, 12);
            tableLayoutPanel1.Controls.Add(toDate, 1, 13);
            tableLayoutPanel1.Controls.Add(button1, 1, 14);
            tableLayoutPanel1.Controls.Add(progressBar1, 1, 15);
            tableLayoutPanel1.Controls.Add(label6, 1, 0);
            tableLayoutPanel1.Controls.Add(label7, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 16;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 27F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 27F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 33F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 27F));
            tableLayoutPanel1.Size = new Size(439, 588);
            tableLayoutPanel1.TabIndex = 0;
            tableLayoutPanel1.Paint += TableLayoutPanel1_Paint;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(439, 588);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tool OtoPresenze - Login";
            Load += Form1_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label7;
        private Label label6;
        private ProgressBar progressBar1;
        private Button button1;
        private DateTimePicker toDate;
        private Label label5;
        private Label label4;
        private DateTimePicker fromDate;
        private Label label3;
        private CheckBox CheckBox1;
        private TextBox passBox1;
        private Label label2;
        private Label label1;
        private TextBox userBox1;
        private TableLayoutPanel tableLayoutPanel1;

        public FormBorderStyle FormBorderStyle { get; private set; }
        public bool MaximizeBox { get; private set; }
        public FormStartPosition StartPosition { get; private set; }
    }
}