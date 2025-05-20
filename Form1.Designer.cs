namespace OtoTools
{
    partial class Form1
    {
        /// <summary>
        /// Variabile richiesta dal designer.
        /// </summary>
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

        #region Codice generato da Windows Form Designer

        /// <summary>
        /// Metodo richiesto dal Windows Form Designer - non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvTickets = new DataGridView();
            this.groupDestinatario = new GroupBox();
            this.rbCad = new RadioButton();
            this.rbSupport = new RadioButton();
            this.lblOggetto = new Label();
            this.txtOggetto = new TextBox();
            this.lblDescrizione = new Label();
            this.txtDescrizione = new TextBox();
            this.btnInviaTicket = new Button();
            this.btnAggiorna = new Button();
            ((System.ComponentModel.ISupportInitialize)this.dgvTickets).BeginInit();
            this.groupDestinatario.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvTickets
            // 
            this.dgvTickets.AllowUserToAddRows = false;
            this.dgvTickets.AllowUserToDeleteRows = false;
            this.dgvTickets.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            this.dgvTickets.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTickets.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTickets.Location = new Point(12, 12);
            this.dgvTickets.MultiSelect = false;
            this.dgvTickets.Name = "dgvTickets";
            this.dgvTickets.ReadOnly = true;
            this.dgvTickets.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvTickets.Size = new Size(560, 350);
            this.dgvTickets.TabIndex = 0;
            // 
            // groupDestinatario
            // 
            this.groupDestinatario.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.groupDestinatario.Controls.Add(this.rbCad);
            this.groupDestinatario.Controls.Add(this.rbSupport);
            this.groupDestinatario.Location = new Point(590, 12);
            this.groupDestinatario.Name = "groupDestinatario";
            this.groupDestinatario.Size = new Size(172, 70);
            this.groupDestinatario.TabIndex = 1;
            this.groupDestinatario.TabStop = false;
            this.groupDestinatario.Text = "Invia a:";
            // 
            // rbCad
            // 
            this.rbCad.AutoSize = true;
            this.rbCad.Location = new Point(10, 42);
            this.rbCad.Name = "rbCad";
            this.rbCad.Size = new Size(132, 19);
            this.rbCad.TabIndex = 1;
            this.rbCad.TabStop = true;
            this.rbCad.Text = "cad@zohodesk.com";
            this.rbCad.UseVisualStyleBackColor = true;
            // 
            // rbSupport
            // 
            this.rbSupport.AutoSize = true;
            this.rbSupport.Location = new Point(10, 20);
            this.rbSupport.Name = "rbSupport";
            this.rbSupport.Size = new Size(154, 19);
            this.rbSupport.TabIndex = 0;
            this.rbSupport.TabStop = true;
            this.rbSupport.Text = "support@zohodesk.com";
            this.rbSupport.UseVisualStyleBackColor = true;
            // 
            // lblOggetto
            // 
            this.lblOggetto.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.lblOggetto.AutoSize = true;
            this.lblOggetto.Location = new Point(590, 95);
            this.lblOggetto.Name = "lblOggetto";
            this.lblOggetto.Size = new Size(54, 15);
            this.lblOggetto.TabIndex = 2;
            this.lblOggetto.Text = "Oggetto:";
            // 
            // txtOggetto
            // 
            this.txtOggetto.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.txtOggetto.Location = new Point(590, 113);
            this.txtOggetto.Name = "txtOggetto";
            this.txtOggetto.Size = new Size(172, 23);
            this.txtOggetto.TabIndex = 3;
            // 
            // lblDescrizione
            // 
            this.lblDescrizione.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.lblDescrizione.AutoSize = true;
            this.lblDescrizione.Location = new Point(590, 150);
            this.lblDescrizione.Name = "lblDescrizione";
            this.lblDescrizione.Size = new Size(70, 15);
            this.lblDescrizione.TabIndex = 4;
            this.lblDescrizione.Text = "Descrizione:";
            // 
            // txtDescrizione
            // 
            this.txtDescrizione.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.txtDescrizione.Location = new Point(590, 168);
            this.txtDescrizione.Multiline = true;
            this.txtDescrizione.Name = "txtDescrizione";
            this.txtDescrizione.Size = new Size(172, 80);
            this.txtDescrizione.TabIndex = 5;
            // 
            // btnInviaTicket
            // 
            this.btnInviaTicket.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.btnInviaTicket.Location = new Point(590, 265);
            this.btnInviaTicket.Name = "btnInviaTicket";
            this.btnInviaTicket.Size = new Size(172, 23);
            this.btnInviaTicket.TabIndex = 6;
            this.btnInviaTicket.Text = "Invia Ticket";
            this.btnInviaTicket.UseVisualStyleBackColor = true;
            this.btnInviaTicket.Click += this.btnInviaTicket_Click;
            // 
            // btnAggiorna
            // 
            this.btnAggiorna.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.btnAggiorna.Location = new Point(590, 295);
            this.btnAggiorna.Name = "btnAggiorna";
            this.btnAggiorna.Size = new Size(172, 23);
            this.btnAggiorna.TabIndex = 7;
            this.btnAggiorna.Text = "Aggiorna Liste";
            this.btnAggiorna.UseVisualStyleBackColor = true;
            this.btnAggiorna.Click += this.btnAggiorna_Click;
            // 
            // Form1
            // 
            this.Controls.Add(this.btnAggiorna);
            this.Controls.Add(this.btnInviaTicket);
            this.Controls.Add(this.txtDescrizione);
            this.Controls.Add(this.lblDescrizione);
            this.Controls.Add(this.txtOggetto);
            this.Controls.Add(this.lblOggetto);
            this.Controls.Add(this.groupDestinatario);
            this.Controls.Add(this.dgvTickets);
            this.Name = "Form1";
            this.Size = new Size(784, 374);
            ((System.ComponentModel.ISupportInitialize)this.dgvTickets).EndInit();
            this.groupDestinatario.ResumeLayout(false);
            this.groupDestinatario.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTickets;
        private System.Windows.Forms.GroupBox groupDestinatario;
        private System.Windows.Forms.RadioButton rbCad;
        private System.Windows.Forms.RadioButton rbSupport;
        private System.Windows.Forms.Label lblOggetto;
        private System.Windows.Forms.TextBox txtOggetto;
        private System.Windows.Forms.Label lblDescrizione;
        private System.Windows.Forms.TextBox txtDescrizione;
        private System.Windows.Forms.Button btnInviaTicket;
        private System.Windows.Forms.Button btnAggiorna;
    }
}
