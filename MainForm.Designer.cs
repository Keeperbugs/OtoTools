namespace OtoTools
{
    partial class MainForm
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
            this.label1 = new Label();
            this.tableLayoutPanel1 = new TableLayoutPanel();
            this.tabControl1 = new TabControl();
            this.tabPage2 = new TabPage();
            this.confrontaDistinte1 = new ConfrontaDistinte();
            this.tabPage1 = new TabPage();
            this.form11 = new EsportaOre();
            this.tabPage3 = new TabPage();
            this.shortcutMod1 = new ShortcutMod();
            this.tabPage4 = new TabPage();
            this.form12 = new Form1();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new Font("Jokerman", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            this.label1.Location = new Point(390, 0);
            this.label1.Name = "label1";
            this.label1.RightToLeft = RightToLeft.No;
            this.label1.Size = new Size(203, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "OtoTools";
            this.label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 18F));
            this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 18F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tabControl1, 1, 1);
            this.tableLayoutPanel1.Dock = DockStyle.Fill;
            this.tableLayoutPanel1.Location = new Point(0, 0);
            this.tableLayoutPanel1.Margin = new Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 15F));
            this.tableLayoutPanel1.Size = new Size(984, 911);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = DockStyle.Fill;
            this.tabControl1.Location = new Point(21, 57);
            this.tabControl1.Margin = new Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new Size(942, 837);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.confrontaDistinte1);
            this.tabPage2.Location = new Point(4, 24);
            this.tabPage2.Margin = new Padding(3, 2, 3, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new Padding(3, 2, 3, 2);
            this.tabPage2.Size = new Size(934, 809);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "ConfrontaDistinte";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // confrontaDistinte1
            // 
            this.confrontaDistinte1.AutoSize = true;
            this.confrontaDistinte1.Dock = DockStyle.Fill;
            this.confrontaDistinte1.Location = new Point(3, 2);
            this.confrontaDistinte1.Margin = new Padding(3, 2, 3, 2);
            this.confrontaDistinte1.Name = "confrontaDistinte1";
            this.confrontaDistinte1.Size = new Size(928, 805);
            this.confrontaDistinte1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.form11);
            this.tabPage1.Location = new Point(4, 24);
            this.tabPage1.Margin = new Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new Padding(3, 2, 3, 2);
            this.tabPage1.Size = new Size(934, 809);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "EsportaOre";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // form11
            // 
            this.form11.AutoSize = true;
            this.form11.Dock = DockStyle.Fill;
            this.form11.Location = new Point(3, 2);
            this.form11.Name = "form11";
            this.form11.Size = new Size(928, 805);
            this.form11.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.shortcutMod1);
            this.tabPage3.Location = new Point(4, 24);
            this.tabPage3.Margin = new Padding(3, 2, 3, 2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new Padding(3, 2, 3, 2);
            this.tabPage3.Size = new Size(934, 809);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "ModificaCollegamenti";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // shortcutMod1
            // 
            this.shortcutMod1.Dock = DockStyle.Fill;
            this.shortcutMod1.Location = new Point(3, 2);
            this.shortcutMod1.Margin = new Padding(4, 4, 4, 4);
            this.shortcutMod1.Name = "shortcutMod1";
            this.shortcutMod1.Size = new Size(928, 805);
            this.shortcutMod1.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.form12);
            this.tabPage4.Location = new Point(4, 24);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new Padding(3);
            this.tabPage4.Size = new Size(934, 809);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // form12
            // 
            this.form12.Location = new Point(6, 6);
            this.form12.Name = "form12";
            this.form12.Size = new Size(784, 374);
            this.form12.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(984, 911);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new Padding(3, 2, 3, 2);
            this.MinimumSize = new Size(1000, 950);
            this.Name = "MainForm";
            this.Text = "OtoTools 1.0b by MartinaLuciano";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private Label label1;
        private TableLayoutPanel tableLayoutPanel1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private EsportaOre form11;
        private TabPage tabPage3;
        private ConfrontaDistinte confrontaDistinte1;
        private ShortcutMod shortcutMod1;
        private TabPage tabPage4;
        private Form1 form12;
    }
}