using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using ClosedXML.Excel;
using System.Data;

namespace OtoTools
{
    public partial class EsportaOre : UserControl
    {
        public EsportaOre()
        {
            InitializeComponent();
            CheckBox1.CheckedChanged += CheckBox1_CheckedChanged;

            // Imposta il form sempre in primo piano
            //TopMost = true;
        }


        private void TableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void UserBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void PassBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void CheckBox1_CheckedChanged(object? sender, EventArgs e)
        {
            if (CheckBox1.Checked)
            {
                passBox1.UseSystemPasswordChar = false; // Rende la password visibile
            }
            else
            {
                passBox1.UseSystemPasswordChar = true; // Nasconde la password
            }
        }

        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void DateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            // Reimposta il valore della barra di progresso all'inizio di ogni esecuzione
            progressBar1.Value = 5;

            try
            {

                string url = "https://systems.otospa.fivesgroup.com/OtoPresenze/";

                // Mostra la barra di progresso e imposta il valore massimo
                progressBar1.Visible = true;
                progressBar1.Minimum = 0;
                progressBar1.Maximum = 100;

                ChromeOptions options = new();
                options.AddArgument("--headless"); // Imposta la modalità headless

                ChromeDriverService service = ChromeDriverService.CreateDefaultService();
                service.HideCommandPromptWindow = true; // Nascondi la finestra del prompt dei comandi

                ChromeDriver driver = new(service, options);

                // Aggiorna la barra di progresso
                progressBar1.Value = 10;

                driver.Navigate().GoToUrl(url);

                // Trova gli elementi HTML con gli ID "user" e "password"
                IWebElement userElement = driver.FindElement(By.Id("user"));
                IWebElement passwordElement = driver.FindElement(By.Id("password"));
                IWebElement enterbutton = driver.FindElement(By.CssSelector("button[type='submit']"));

                // Ottieni il valore dal TextBox UserBox1
                string username = userBox1.Text;
                string password = passBox1.Text;
                string from_date = fromDate.Text;
                string to_date = toDate.Text;

                // Esempio di azione sugli elementi trovati
                userElement.SendKeys(username);
                passwordElement.SendKeys(password);

                enterbutton.Click();

                // Controlla la presenza dell'elemento con la classe CSS "div.alert-error"
                IWebElement? errorElement = null;
                try
                {
                    errorElement = driver.FindElement(By.CssSelector("div.alert-error"));
                }
                catch (NoSuchElementException)
                {
                    // L'elemento con la classe CSS "div.alert-error" non è stato trovato
                }

                if (errorElement != null)
                {
                    driver.Quit();
                    MessageBox.Show("Nome utente o password errati", "Avviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {

                    // Aggiorna la barra di progresso
                    progressBar1.Value = 30;

                    // Imposta un timeout di attesa implicita di 10 secondi
                    WebDriverWait wait = new(driver, TimeSpan.FromSeconds(10));

                    IWebElement attivita_link = driver.FindElement(By.LinkText("Attività inserite"));
                    attivita_link.Click();

                    IWebElement from_inputElement = driver.FindElement(By.Id("idFromDate"));
                    IWebElement to_inputElement = driver.FindElement(By.Id("idToDate"));
                    from_inputElement.Clear();
                    from_inputElement.SendKeys(from_date);
                    to_inputElement.Clear();
                    to_inputElement.SendKeys(to_date);

                    IWebElement cerca_button = driver.FindElement(By.Id("btnSearch"));
                    cerca_button.Click();

                    // Trova la tabella nella pagina web
                    IWebElement tableElement = driver.FindElement(By.TagName("table"));

                    // Aggiorna la barra di progresso
                    progressBar1.Value = 50;

                    // Ottieni i dati dalla tabella
                    var table = new DataTable();
                    var rows = tableElement.FindElements(By.TagName("tr"));

                    // Leggi l'intestazione della tabella
                    var headerRow = rows[0];
                    var headerCells = headerRow.FindElements(By.TagName("th"));
                    foreach (var cell in headerCells)
                    {
                        table.Columns.Add(cell.Text);
                    }

                    // Aggiorna la barra di progresso
                    progressBar1.Value = 70;

                    // Leggi le righe della tabella
                    for (int i = 1; i < rows.Count; i++)
                    {
                        var dataCells = rows[i].FindElements(By.TagName("td"));
                        var rowData = new List<string>();
                        foreach (var cell in dataCells)
                        {
                            rowData.Add(cell.Text);
                        }
                        table.Rows.Add(rowData.ToArray());
                    }

                    // Aggiorna la barra di progresso
                    progressBar1.Value = 90;

                    // Crea il file Excel utilizzando ClosedXML
                    using var workbook = new XLWorkbook();

                    var worksheet = workbook.Worksheets.Add("Tabella");
                    worksheet.Cell(1, 1).InsertTable(table);

                    /*// Salva il file Excel sul desktop dell'utente corrente
                    string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                    string filePath = Path.Combine(desktopPath, $"consuntivo_ore_{from_date.Replace('/', '-')}_{to_date.Replace('/', '-')}.xlsx");
                    workbook.SaveAs(filePath);*/

                    // Salva il file Excel sul desktop dell'utente corrente
                    string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                    string fileName = $"consuntivo_ore_{from_date.Replace('/', '-')}_{to_date.Replace('/', '-')}.xlsx";
                    string filePath = Path.Combine(desktopPath, fileName);

                    workbook.SaveAs(filePath);

                    // Aggiorna la barra di progresso
                    progressBar1.Value = 100;

                    // Chiudi il browser
                    driver.Quit();
                    MessageBox.Show($"File Excel '{fileName}' salvato con successo sul desktop!", "Avviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                // Gestisci eventuali eccezioni qui e mostra un messaggio di errore
                MessageBox.Show("Si è verificato un errore durante l'esportazione dei dati: " + ex.Message);
            }
            finally
            {
                // Reimposta il valore della barra di progresso anche in caso di eccezione
                progressBar1.Value = 0;
            }
        }
    }
}