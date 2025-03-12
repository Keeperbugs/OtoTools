using System;
using System.ComponentModel;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
// Per Outlook interop:
using Outlook = Microsoft.Office.Interop.Outlook;

namespace OtoTools
{
    public partial class Form1 : UserControl
    {
        private BindingList<Ticket> _tickets;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _tickets = new BindingList<Ticket>();
            dgvTickets.DataSource = _tickets;
            rbSupport.Checked = true; // default
        }

        /// <summary>
        /// Evento click del pulsante Invia Ticket.
        /// Crea un ticket e invia l'email al destinatario selezionato.
        /// </summary>
        private void btnInviaTicket_Click(object sender, EventArgs e)
        {
            try
            {
                string destinatario = rbSupport.Checked ? "support@zohodesk.com" : "cad@zohodesk.com";
                string oggetto = txtOggetto.Text.Trim();
                string descrizione = txtDescrizione.Text.Trim();

                if (string.IsNullOrWhiteSpace(oggetto))
                {
                    MessageBox.Show("Inserire un oggetto per il ticket.");
                    return;
                }

                if (string.IsNullOrWhiteSpace(descrizione))
                {
                    MessageBox.Show("Inserire una descrizione per il ticket.");
                    return;
                }

                // Crea un nuovo ticket in stato "In attesa di ID"
                var nuovoTicket = new Ticket
                {
                    Id = 0,
                    Oggetto = oggetto,
                    Descrizione = descrizione,
                    Destinatario = destinatario,
                    Stato = "In attesa di ID"
                };

                // Invia l'email tramite Outlook Interop
                InviaTicketEmail(nuovoTicket);

                // Aggiungo temporaneamente il ticket nella lista
                _tickets.Add(nuovoTicket);

                MessageBox.Show("Ticket inviato. Attendere la mail di risposta con l'ID del ticket.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errore durante l'invio del ticket: " + ex.Message);
            }
        }

        /// <summary>
        /// Evento click del pulsante Aggiorna.
        /// Simula la lettura delle nuove mail in arrivo per aggiornare lo stato dei ticket.
        /// </summary>
        private void btnAggiorna_Click(object sender, EventArgs e)
        {
            try
            {
                AggiornaTicketDaEmail();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errore durante l'aggiornamento dei ticket: " + ex.Message);
            }
        }

        /// <summary>
        /// Metodo per inviare un'email con Outlook Interop.
        /// Nel caso reale, dopo l'invio il sistema di ticketing invia una mail di conferma creazione.
        /// </summary>
        private void InviaTicketEmail(Ticket ticket)
        {
            // Creare l'istanza di Outlook
            Outlook.Application outlookApp = new Outlook.Application();
            Outlook.MailItem mail = (Outlook.MailItem)outlookApp.CreateItem(Outlook.OlItemType.olMailItem);

            mail.To = ticket.Destinatario;
            mail.Subject = ticket.Oggetto;
            mail.Body = ticket.Descrizione;

            // Invia l'email
            mail.Send();

            // In un caso reale, si aspetta l'email di risposta dal sistema di ticketing
        }

        /// <summary>
        /// Legge le email in arrivo (simulazione) e aggiorna lo stato dei ticket.
        /// Nel caso reale, qui dovresti accedere alla casella di posta, filtrare i messaggi non letti e cercare quelli
        /// con oggetti come:
        /// [##11412##] Il tuo ticket è stato creato
        /// [##11412##] Il tuo ticket è stato Chiuso
        /// [##11412##] Risposta al tuo ticket (per le mail intermedie)
        /// </summary>
        private void AggiornaTicketDaEmail()
        {
            // SIMULAZIONE: qui dovresti usare Outlook Interop per leggere la Posta in arrivo.
            // Di seguito mettiamo del codice fittizio per mostrare la logica di aggiornamento.

            Outlook.Application outlookApp = new Outlook.Application();
            Outlook.NameSpace outlookNs = outlookApp.GetNamespace("MAPI");
            Outlook.MAPIFolder inbox = outlookNs.GetDefaultFolder(Outlook.OlDefaultFolders.olFolderInbox);

            // Filtrare i messaggi in arrivo (semplificazione: qui li prendiamo tutti)
            foreach (Outlook.MailItem mail in inbox.Items)
            {
                // Estrarre l'ID dal soggetto
                int idTicket = EstraiIdTicketDaOggetto(mail.Subject);
                if (idTicket > 0)
                {
                    // Trovare il ticket corrispondente nella lista
                    var ticket = _tickets.FirstOrDefault(t => t.Id == idTicket || (t.Id == 0 && t.Oggetto == mail.Subject));
                    if (ticket == null && mail.Subject.Contains("creato"))
                    {
                        // Se non esiste un ticket con quell'ID ma il soggetto dice che è stato creato,
                        // significa che è la mail di creazione e stiamo ricevendo ora l'ID.
                        // Aggiorniamo l'ultimo ticket inviato senza ID, se esiste.
                        ticket = _tickets.LastOrDefault(t => t.Stato == "In attesa di ID");
                        if (ticket != null)
                        {
                            ticket.Id = idTicket;
                            ticket.Stato = "Aperto";
                        }
                    }
                    else if (ticket != null)
                    {
                        // Controllare se è una mail di chiusura
                        if (mail.Subject.Contains("Chiuso"))
                        {
                            ticket.Stato = "Chiuso";
                        }
                        else if (mail.Subject.Contains("creato"))
                        {
                            // Già gestito sopra: settiamo l'ID e stato "Aperto"
                            // Qui potresti anche aggiornare altri campi, se necessario.
                            ticket.Stato = "Aperto";
                            ticket.Id = idTicket;
                        }
                        else
                        {
                            // Mail di risposta intermedia
                            // Potresti aggiornare il ticket con note, ultime risposte, etc.
                            // Ad esempio:
                            ticket.Stato = "In lavorazione";
                        }
                    }
                }

                // Nella realtà, potresti impostare la mail come letta o spostarla in un'altra cartella
                // dopo averla processata.
            }

            // Forziamo l'aggiornamento della griglia
            dgvTickets.Refresh();
        }

        /// <summary>
        /// Cerca l'ID del ticket nell'oggetto della mail. L'oggetto contiene qualcosa come [##11412##]
        /// Qui estraiamo il numero tra ##.
        /// </summary>
        private int EstraiIdTicketDaOggetto(string subject)
        {
            if (string.IsNullOrEmpty(subject)) return 0;

            // Cerchiamo un pattern come: [##12345##]
            Match m = Regex.Match(subject, @"\[\##(\d+)##\]");
            if (m.Success && int.TryParse(m.Groups[1].Value, out int id))
            {
                return id;
            }
            return 0;
        }
    }
}

public class Ticket
{
    public int Id { get; set; }
    public string Oggetto { get; set; }
    public string Descrizione { get; set; }
    public string Destinatario { get; set; } // ad es. support@zohodesk.com o cad@zohodesk.com
    public string Stato { get; set; } // "Aperto", "Chiuso"
}

