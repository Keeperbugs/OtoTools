using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using ClosedXML.Excel;
using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;

namespace OtoTools
{
    public partial class import : Form
    {
        // Variabile per memorizzare i dati originali importati
        private DataTable? originalDataTable;

        // Variabile per memorizzare l'ordine originale delle colonne
        private List<string> originalColumnOrder;

        public import()
        {
            InitializeComponent();

            // Imposta il valore predefinito per la ComboBox
            comboBoxSeparator.SelectedIndex = 0; // Assume che la virgola sia il primo elemento

            // Nascondi le intestazioni di riga
            dataGridView1.RowHeadersVisible = false;
        }

        private void ButtonImport_Click(object sender, EventArgs e)
        {
            // Apri un OpenFileDialog per selezionare il file
            OpenFileDialog openFileDialog = new()
            {
                Filter = "Tutti i file supportati|*.csv;*.xls;*.xlsx|File CSV (*.csv)|*.csv|File Excel 97-2003 (*.xls)|*.xls|File Excel (*.xlsx)|*.xlsx",
                Title = "Seleziona un file da importare"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Reset dopo che l'utente ha selezionato un file
                ResetData();

                // Inizializza originalColumnOrder
                originalColumnOrder = new List<string>();

                string filePath = openFileDialog.FileName;
                string extension = Path.GetExtension(filePath);

                _ = new DataTable();

                try
                {
                    DataTable dt;
                    switch (extension.ToLower())
                    {
                        case ".csv":
                            // Ottieni il separatore scelto dall'utente
                            char separator = GetSeparator();
                            dt = ImportCsv(filePath, separator);
                            break;

                        case ".xls":
                            dt = ImportXls(filePath);
                            break;

                        case ".xlsx":
                            dt = ImportXlsx(filePath);
                            break;

                        default:
                            MessageBox.Show("Formato file non supportato.");
                            return;
                    }

                    // Memorizza i dati originali
                    originalDataTable = dt.Copy();

                    dataGridView1.DataSource = dt;

                    // Ripristina l'ordine delle colonne
                    RestoreColumnOrder();

                    // Popola la CheckedListBox con i nomi delle colonne
                    PopulateCheckedListBox();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Errore durante l'importazione del file: " + ex.Message);
                }
            }
        }

        private void PopulateCheckedListBox()
        {
            checkedListBoxColumns.Items.Clear();

            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                checkedListBoxColumns.Items.Add(column.HeaderText, false);
            }
        }

        private void ButtonDeleteColumns_Click(object sender, EventArgs e)
        {
            // Ottieni i nomi delle colonne selezionate (colonne da mantenere)
            var selectedColumns = checkedListBoxColumns.CheckedItems.Cast<string>().ToList();

            // Se l'utente non seleziona nessuna colonna, rimarrà vuoto
            // (Se vuoi evitare che rimanga vuoto, potresti mostrare un messaggio)
            if (selectedColumns.Count == 0)
            {
                MessageBox.Show("Seleziona almeno una colonna da mantenere.");
                return;
            }

            // Ottieni la lista di tutte le colonne attualmente nel DataGridView
            var allColumns = dataGridView1.Columns.Cast<DataGridViewColumn>().Select(c => c.HeaderText).ToList();

            // Determina le colonne da rimuovere: tutte quelle che non sono state selezionate
            var columnsToRemove = allColumns.Except(selectedColumns).ToList();

            // Rimuovi le colonne non selezionate dal DataGridView e dal DataTable
            foreach (string columnName in columnsToRemove)
            {
                if (dataGridView1.Columns.Contains(columnName))
                {
                    dataGridView1.Columns.Remove(columnName);

                    if (dataGridView1.DataSource is DataTable dt && dt.Columns.Contains(columnName))
                    {
                        dt.Columns.Remove(columnName);
                    }

                    // Rimuovi il nome della colonna dalla lista dell'ordine originale
                    if (originalColumnOrder.Contains(columnName))
                    {
                        originalColumnOrder.Remove(columnName);
                    }
                }
            }

            // Aggiorna la CheckedListBox
            PopulateCheckedListBox();
        }


        private void ButtonCopy_Click(object sender, EventArgs e)
        {
            if (dataGridView1.DataSource != null)
            {
                CopyAllToClipboard();
                MessageBox.Show("Dati copiati negli appunti.");
            }
            else
            {
                MessageBox.Show("Nessun dato da copiare.");
            }
        }

        private void CopyAllToClipboard()
        {
            // Imposta il ClipboardCopyMode per escludere le intestazioni di colonna
            dataGridView1.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText;

            // Seleziona tutte le celle
            dataGridView1.SelectAll();

            // Ottieni il contenuto da copiare
            DataObject dataObj = dataGridView1.GetClipboardContent();

            if (dataObj != null)
            {
                Clipboard.SetDataObject(dataObj);
            }

            // Deseleziona tutte le celle
            dataGridView1.ClearSelection();
        }

        private void ResetData()
        {
            dataGridView1.DataSource = null;
            checkedListBoxColumns.Items.Clear();
            originalDataTable = null;
            originalColumnOrder = null;
        }

        private void RestoreColumnOrder()
        {
            // Assicurati che le colonne nel DataGridView siano nell'ordine originale
            for (int i = 0; i < originalColumnOrder.Count; i++)
            {
                string columnName = originalColumnOrder[i];
                if (dataGridView1.Columns.Contains(columnName))
                {
                    dataGridView1.Columns[columnName].DisplayIndex = i;
                }
            }
        }

        private char GetSeparator()
        {
            string? separatorText = comboBoxSeparator.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(separatorText))
            {
                // Se nessun separatore è selezionato, usa la virgola come predefinito
                return ',';
            }

            // Gestione speciale per tabulazione
            if (separatorText == "\\t")
            {
                return '\t';
            }

            return separatorText[0];
        }

        private DataTable ImportCsv(string filePath, char separator)
        {
            DataTable dt = new();

            using (StreamReader sr = new(filePath))
            {
                string line;
                int rowNumber = 0;
                int columnCount = 0;

                while ((line = sr.ReadLine()) != null)
                {
                    string[] data = line.Split(separator);

                    if (rowNumber == 0)
                    {
                        columnCount = data.Length;
                        for (int i = 0; i < columnCount; i++)
                        {
                            string columnName = GetColumnName(i);
                            dt.Columns.Add(columnName);

                            // Aggiungi il nome della colonna alla lista dell'ordine originale
                            originalColumnOrder.Add(columnName);
                        }
                    }

                    dt.Rows.Add(data);
                    rowNumber++;
                }
            }

            return dt;
        }

        private DataTable ImportXlsx(string filePath)
        {
            DataTable dt = new();

            using (XLWorkbook workbook = new(filePath))
            {
                // Prendi il primo foglio di lavoro
                IXLWorksheet worksheet = workbook.Worksheets.First();

                int rowNumber = 0;
                int columnCount = 0;

                foreach (IXLRow row in worksheet.RowsUsed())
                {
                    if (rowNumber == 0)
                    {
                        columnCount = row.CellsUsed().Count();

                        // Crea le colonne con nomi basati su lettere
                        for (int i = 0; i < columnCount; i++)
                        {
                            string columnName = GetColumnName(i);
                            dt.Columns.Add(columnName);

                            // Aggiungi il nome della colonna alla lista dell'ordine originale
                            originalColumnOrder.Add(columnName);
                        }
                    }

                    DataRow dataRow = dt.NewRow();
                    int cellIndex = 0;

                    foreach (IXLCell cell in row.Cells(1, columnCount))
                    {
                        dataRow[cellIndex] = cell.Value.ToString();
                        cellIndex++;
                    }

                    dt.Rows.Add(dataRow);
                    rowNumber++;
                }
            }

            return dt;
        }

        private DataTable ImportXls(string filePath)
        {
            DataTable dt = new();

            using (FileStream fs = new(filePath, FileMode.Open, FileAccess.Read))
            {
                HSSFWorkbook workbook = new(fs);
                ISheet sheet = workbook.GetSheetAt(0);

                int rowNumber = 0;
                int columnCount = 0;

                foreach (IRow row in sheet)
                {
                    if (rowNumber == 0)
                    {
                        columnCount = row.LastCellNum;

                        // Crea le colonne con nomi basati su lettere
                        for (int i = 0; i < columnCount; i++)
                        {
                            string columnName = GetColumnName(i);
                            dt.Columns.Add(columnName);

                            // Aggiungi il nome della colonna alla lista dell'ordine originale
                            originalColumnOrder.Add(columnName);
                        }
                    }

                    DataRow dataRow = dt.NewRow();

                    for (int i = 0; i < columnCount; i++)
                    {
                        ICell cell = row.GetCell(i);
                        dataRow[i] = cell != null ? cell.ToString() : string.Empty;
                    }

                    dt.Rows.Add(dataRow);
                    rowNumber++;
                }
            }

            return dt;
        }

        private static string GetColumnName(int index)
        {
            const int lettersInAlphabet = 26;
            string columnName = string.Empty;

            while (index >= 0)
            {
                int remainder = index % lettersInAlphabet;
                columnName = (char)(remainder + 'A') + columnName;
                index = (index / lettersInAlphabet) - 1;
            }

            return columnName;
        }

        public override bool Equals(object? obj)
        {
            return obj is import import &&
                   EqualityComparer<DataTable>.Default.Equals(originalDataTable, import.originalDataTable);
        }
    }
}
