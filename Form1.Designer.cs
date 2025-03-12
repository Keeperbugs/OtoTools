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
            this.dgvTickets = new System.Windows.Forms.DataGridView();
            this.groupDestinatario = new System.Windows.Forms.GroupBox();
            this.rbCad = new System.Windows.Forms.RadioButton();
            this.rbSupport = new System.Windows.Forms.RadioButton();
            this.lblOggetto = new System.Windows.Forms.Label();
            this.txtOggetto = new System.Windows.Forms.TextBox();
            this.lblDescrizione = new System.Windows.Forms.Label();
            this.txtDescrizione = new System.Windows.Forms.TextBox();
            this.btnInviaTicket = new System.Windows.Forms.Button();
            this.btnAggiorna = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTickets)).BeginInit();
            this.groupDestinatario.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvTickets
            // 
            this.dgvTickets.AllowUserToAddRows = false;
            this.dgvTickets.AllowUserToDeleteRows = false;
            this.dgvTickets.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvTickets.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTickets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTickets.Location = new System.Drawing.Point(12, 12);
            this.dgvTickets.MultiSelect = false;
            this.dgvTickets.Name = "dgvTickets";
            this.dgvTickets.ReadOnly = true;
            this.dgvTickets.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTickets.Size = new System.Drawing.Size(560, 350);
            this.dgvTickets.TabIndex = 0;
            // 
            // groupDestinatario
            // 
            this.groupDestinatario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupDestinatario.Controls.Add(this.rbCad);
            this.groupDestinatario.Controls.Add(this.rbSupport);
            this.groupDestinatario.Location = new System.Drawing.Point(590, 12);
            this.groupDestinatario.Name = "groupDestinatario";
            this.groupDestinatario.Size = new System.Drawing.Size(172, 70);
            this.groupDestinatario.TabIndex = 1;
            this.groupDestinatario.TabStop = false;
            this.groupDestinatario.Text = "Invia a:";
            // 
            // rbCad
            // 
            this.rbCad.AutoSize = true;
            this.rbCad.Location = new System.Drawing.Point(10, 42);
            this.rbCad.Name = "rbCad";
            this.rbCad.Size = new System.Drawing.Size(141, 19);
            this.rbCad.TabIndex = 1;
            this.rbCad.TabStop = true;
            this.rbCad.Text = "cad@zohodesk.com";
            this.rbCad.UseVisualStyleBackColor = true;
            // 
            // rbSupport
            // 
            this.rbSupport.AutoSize = true;
            this.rbSupport.Location = new System.Drawing.Point(10, 20);
            this.rbSupport.Name = "rbSupport";
            this.rbSupport.Size = new System.Drawing.Size(159, 19);
            this.rbSupport.TabIndex = 0;
            this.rbSupport.TabStop = true;
            this.rbSupport.Text = "support@zohodesk.com";
            this.rbSupport.UseVisualStyleBackColor = true;
            // 
            // lblOggetto
            // 
            this.lblOggetto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOggetto.AutoSize = true;
            this.lblOggetto.Location = new System.Drawing.Point(590, 95);
            this.lblOggetto.Name = "lblOggetto";
            this.lblOggetto.Size = new System.Drawing.Size(54, 15);
            this.lblOggetto.TabIndex = 2;
            this.lblOggetto.Text = "Oggetto:";
            // 
            // txtOggetto
            // 
            this.txtOggetto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOggetto.Location = new System.Drawing.Point(590, 113);
            this.txtOggetto.Name = "txtOggetto";
            this.txtOggetto.Size = new System.Drawing.Size(172, 23);
            this.txtOggetto.TabIndex = 3;
            // 
            // lblDescrizione
            // 
            this.lblDescrizione.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDescrizione.AutoSize = true;
            this.lblDescrizione.Location = new System.Drawing.Point(590, 150);
            this.lblDescrizione.Name = "lblDescrizione";
            this.lblDescrizione.Size = new System.Drawing.Size(71, 15);
            this.lblDescrizione.TabIndex = 4;
            this.lblDescrizione.Text = "Descrizione:";
            // 
            // txtDescrizione
            // 
            this.txtDescrizione.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescrizione.Location = new System.Drawing.Point(590, 168);
            this.txtDescrizione.Multiline = true;
            this.txtDescrizione.Name = "txtDescrizione";
            this.txtDescrizione.Size = new System.Drawing.Size(172, 80);
            this.txtDescrizione.TabIndex = 5;
            // 
            // btnInviaTicket
            // 
            this.btnInviaTicket.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInviaTicket.Location = new System.Drawing.Point(590, 265);
            this.btnInviaTicket.Name = "btnInviaTicket";
            this.btnInviaTicket.Size = new System.Drawing.Size(172, 23);
            this.btnInviaTicket.TabIndex = 6;
            this.btnInviaTicket.Text = "Invia Ticket";
            this.btnInviaTicket.UseVisualStyleBackColor = true;
            // 
            // btnAggiorna
            // 
            this.btnAggiorna.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAggiorna.Location = new System.Drawing.Point(590, 295);
            this.btnAggiorna.Name = "btnAggiorna";
            this.btnAggiorna.Size = new System.Drawing.Size(172, 23);
            this.btnAggiorna.TabIndex = 7;
            this.btnAggiorna.Text = "Aggiorna Liste";
            this.btnAggiorna.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(784, 374);
            this.Controls.Add(this.btnAggiorna);
            this.Controls.Add(this.btnInviaTicket);
            this.Controls.Add(this.txtDescrizione);
            this.Controls.Add(this.lblDescrizione);
            this.Controls.Add(this.txtOggetto);
            this.Controls.Add(this.lblOggetto);
            this.Controls.Add(this.groupDestinatario);
            this.Controls.Add(this.dgvTickets);
            this.Name = "Form1";
            this.Text = "Gestione Ticket";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTickets)).EndInit();
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
