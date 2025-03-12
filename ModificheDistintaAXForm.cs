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
    public partial class ModificheDistintaAXForm : Form
    {
        public ModificheDistintaAXForm()
        {
            InitializeComponent();
        }

        private void ButtonCopy_Click(object sender, EventArgs e)
        {
            if (dataGridViewReport.Rows.Count > 0 && !dataGridViewReport.Rows[0].IsNewRow)
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
            dataGridViewReport.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText;

            // Seleziona tutte le celle
            dataGridViewReport.SelectAll();

            // Ottieni il contenuto da copiare
            DataObject dataObj = dataGridViewReport.GetClipboardContent();

            if (dataObj != null)
            {
                Clipboard.SetDataObject(dataObj);
            }

            // Deseleziona tutte le celle
            dataGridViewReport.ClearSelection();
        }
    }
}
