using System;
using System.Windows.Forms;
using Outlook = Microsoft.Office.Interop.Outlook;

namespace OtoTools
{
    //public partial class FormSuggerimenti : Form
    //{
    //    public FormSuggerimenti()
    //    {
    //        InitializeComponent();
    //    }

    //    private void BtnInvia_Click(object sender, EventArgs e)
    //    {
    //        string testoSuggerimenti = txtSuggerimenti.Text;

    //        if (string.IsNullOrWhiteSpace(testoSuggerimenti))
    //        {
    //            MessageBox.Show("Per favore, scrivi qualcosa prima di inviare.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Warning);
    //            return;
    //        }

    //        try
    //        {
    //            // Crea una nuova applicazione Outlook
    //            Outlook.Application outlookApp = new Outlook.Application();
    //            Outlook.MailItem mailItem = (Outlook.MailItem)outlookApp.CreateItem(Outlook.OlItemType.olMailItem);

    //            // Configura i campi della mail
    //            mailItem.To = "luciano.martina@fivesgroup.com";
    //            mailItem.Subject = "SUGGERIMENTI/MIGLIORAMENTI PER CONFRONTA DISTINTE";
    //            mailItem.Body = testoSuggerimenti;

    //            // Invia la mail
    //            mailItem.Send();
    //            MessageBox.Show("Suggerimenti inviati con successo!", "Successo", MessageBoxButtons.OK, MessageBoxIcon.Information);
    //            this.Close();
    //        }
    //        catch (Exception ex)
    //        {
    //            MessageBox.Show("Errore durante l'invio della mail tramite Outlook: " + ex.Message, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
    //        }
    //    }
    //}

    public partial class FormSuggerimenti : Form
    {
        private const string filePath = "suggerimenti.txt";

        public FormSuggerimenti()
        {
            InitializeComponent();
            LoadSuggerimenti();
        }

        private void BtnInvia_Click(object sender, EventArgs e)
        {
            string testoSuggerimenti = txtSuggerimenti.Text;

            if (string.IsNullOrWhiteSpace(testoSuggerimenti))
            {
                MessageBox.Show("Per favore, scrivi qualcosa prima di inviare.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Salva il suggerimento nel file
                File.AppendAllText(filePath, $"{DateTime.Now}: {testoSuggerimenti}{Environment.NewLine}");

                // Aggiorna la tabella con il nuovo suggerimento
                dgvSuggerimenti.Rows.Add(DateTime.Now.ToString(), testoSuggerimenti);

                // Crea una nuova applicazione Outlook
                Outlook.Application outlookApp = new();
                Outlook.MailItem mailItem = (Outlook.MailItem)outlookApp.CreateItem(Outlook.OlItemType.olMailItem);

                // Configura i campi della mail
                mailItem.To = "luciano.martina@fivesgroup.com";
                mailItem.Subject = "SUGGERIMENTI/MIGLIORAMENTI PER CONFRONTA DISTINTE";
                mailItem.Body = testoSuggerimenti;

                // Invia la mail
                mailItem.Send();
                MessageBox.Show("Suggerimento inserito e inviato con successo!", "Successo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSuggerimenti.Clear();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Errore durante l'inserimentoe e l'invio del suggerimento: " + ex.Message, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadSuggerimenti()
        {
            try
            {
                if (File.Exists(filePath))
                {
                    string[] suggerimenti = File.ReadAllLines(filePath);
                    foreach (string suggerimento in suggerimenti)
                    {
                        string[] parts = suggerimento.Split(new[] { ": " }, 2, StringSplitOptions.None);
                        if (parts.Length == 2)
                        {
                            dgvSuggerimenti.Rows.Add(parts[0], parts[1]);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errore durante il caricamento dei suggerimenti: " + ex.Message, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

}
