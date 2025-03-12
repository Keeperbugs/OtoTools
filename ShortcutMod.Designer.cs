namespace OtoTools
{
    partial class ShortcutMod
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
            browseButton = new Button();
            includeSubfoldersCheckBox = new CheckBox();
            treeView1 = new ListView();
            oldTextTextBox = new TextBox();
            newTextTextBox = new TextBox();
            updateButton = new Button();
            folderBrowserDialog1 = new FolderBrowserDialog();
            SuspendLayout();
            // 
            // browseButton
            // 
            browseButton.Location = new Point(16, 18);
            browseButton.Margin = new Padding(4, 5, 4, 5);
            browseButton.Name = "browseButton";
            browseButton.Size = new Size(160, 35);
            browseButton.TabIndex = 0;
            browseButton.Text = "Seleziona cartella";
            browseButton.UseVisualStyleBackColor = true;
            browseButton.Click += BrowseButton_Click;
            // 
            // includeSubfoldersCheckBox
            // 
            includeSubfoldersCheckBox.AutoSize = true;
            includeSubfoldersCheckBox.Location = new Point(184, 25);
            includeSubfoldersCheckBox.Margin = new Padding(4, 5, 4, 5);
            includeSubfoldersCheckBox.Name = "includeSubfoldersCheckBox";
            includeSubfoldersCheckBox.Size = new Size(162, 24);
            includeSubfoldersCheckBox.TabIndex = 1;
            includeSubfoldersCheckBox.Text = "Includi sottocartelle";
            includeSubfoldersCheckBox.UseVisualStyleBackColor = true;
            includeSubfoldersCheckBox.CheckedChanged += IncludeSubfoldersCheckBox_CheckedChanged;
            // 
            // treeView1
            // 
            treeView1.FullRowSelect = true;
            treeView1.GridLines = true;
            treeView1.Location = new Point(16, 63);
            treeView1.Margin = new Padding(4, 5, 4, 5);
            treeView1.Name = "treeView1";
            treeView1.Size = new Size(632, 306);
            treeView1.TabIndex = 2;
            treeView1.UseCompatibleStateImageBehavior = false;
            treeView1.View = View.Details;
            // 
            // oldTextTextBox
            // 
            oldTextTextBox.Location = new Point(16, 380);
            oldTextTextBox.Margin = new Padding(4, 5, 4, 5);
            oldTextTextBox.Name = "oldTextTextBox";
            oldTextTextBox.Size = new Size(265, 27);
            oldTextTextBox.TabIndex = 3;
            oldTextTextBox.Text = "Testo da cambiare";
            // 
            // newTextTextBox
            // 
            newTextTextBox.Location = new Point(291, 380);
            newTextTextBox.Margin = new Padding(4, 5, 4, 5);
            newTextTextBox.Name = "newTextTextBox";
            newTextTextBox.Size = new Size(265, 27);
            newTextTextBox.TabIndex = 4;
            newTextTextBox.Text = "Sostituire con";
            // 
            // updateButton
            // 
            updateButton.Location = new Point(565, 377);
            updateButton.Margin = new Padding(4, 5, 4, 5);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(84, 35);
            updateButton.TabIndex = 5;
            updateButton.Text = "Aggiorna";
            updateButton.UseVisualStyleBackColor = true;
            updateButton.Click += UpdateButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(665, 431);
            Controls.Add(updateButton);
            Controls.Add(newTextTextBox);
            Controls.Add(oldTextTextBox);
            Controls.Add(treeView1);
            Controls.Add(includeSubfoldersCheckBox);
            Controls.Add(browseButton);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            Text = "Modificatore link";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button browseButton;
        private CheckBox includeSubfoldersCheckBox;
        private ListView treeView1;
        private TextBox oldTextTextBox;
        private TextBox newTextTextBox;
        private Button updateButton;
        private FolderBrowserDialog folderBrowserDialog1;
    }
}
