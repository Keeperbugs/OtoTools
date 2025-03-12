using OtoTools;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace OtoTools
{
    public partial class ConfrontaDistinte : UserControl
    {
        private List<string> modifiche = new(); // Lista globale delle modifiche

        public ConfrontaDistinte()
        {
            InitializeComponent();
            InizializzaDataGridView();

        }

        private void InizializzaDataGridView()
        {
            for (int i = 0; i < 300; i++)
            {
                dgvDistintaAX.Rows.Add();
                dgvDistintaAX.Rows[i].HeaderCell.Value = (i + 1).ToString();

                dgvDistintaCREO.Rows.Add();
                dgvDistintaCREO.Rows[i].HeaderCell.Value = (i + 1).ToString();
            }
        }

        private static string NormalizzaCodice(string codice)
        {
            if (string.IsNullOrWhiteSpace(codice)) return string.Empty;

            codice = codice.Trim();
            return codice.StartsWith("S", StringComparison.OrdinalIgnoreCase)
                ? codice[1..]
                : codice;
        }

        private static int ConvertiQuantita(string quantitaString)
        {
            if (string.IsNullOrWhiteSpace(quantitaString)) return 0;

            // Sostituisce la virgola con un punto per unificare il formato numerico
            quantitaString = quantitaString.Replace(',', '.');

            // Tenta di convertire in un decimale e poi tronca a intero
            if (decimal.TryParse(quantitaString, System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, out decimal quantitaDecimale))
            {
                return (int)Math.Floor(quantitaDecimale); // Ignora i decimali
            }

            return 0; // Se non è un numero valido, ritorna 0
        }

        //private void AvviaConfronto()
        //{
        //    // Resetta i colori delle righe e i valori delle colonne 'Trovato in...'
        //    foreach (DataGridViewRow row in dgvDistintaAX.Rows)
        //    {
        //        row.DefaultCellStyle.BackColor = Color.White;
        //        row.Cells[3].Value = null; // Resetta il valore
        //    }

        //    foreach (DataGridViewRow row in dgvDistintaCREO.Rows)
        //    {
        //        row.DefaultCellStyle.BackColor = Color.White;
        //        row.Cells[3].Value = null; // Resetta il valore
        //    }

        //    modifiche.Clear(); // Svuota la lista delle modifiche prima di iniziare un nuovo confronto

        //    var distintaAX = new Dictionary<string, (string descrizione, int quantita)>();
        //    var distintaCREO = new Dictionary<string, (string descrizione, int quantita)>();

        //    // Lettura dati dalla DISTINTA AX
        //    foreach (DataGridViewRow row in dgvDistintaAX.Rows)
        //    {
        //        if (row.Cells[0].Value != null)
        //        {
        //            var codice = NormalizzaCodice(row.Cells[0].Value.ToString());
        //            var descrizione = row.Cells[1]?.Value?.ToString() ?? "";
        //            var quantita = ConvertiQuantita(row.Cells[2]?.Value?.ToString());
        //            distintaAX[codice] = (descrizione, quantita);
        //        }
        //    }

        //    // Lettura dati dalla DISTINTA CREO
        //    foreach (DataGridViewRow row in dgvDistintaCREO.Rows)
        //    {
        //        if (row.Cells[0].Value != null)
        //        {
        //            var codice = NormalizzaCodice(row.Cells[0].Value.ToString());
        //            var descrizione = row.Cells[1]?.Value?.ToString() ?? "";
        //            var quantita = ConvertiQuantita(row.Cells[2]?.Value?.ToString());
        //            distintaCREO[codice] = (descrizione, quantita);
        //        }
        //    }

        //    // Confronto tra le due distinte
        //    foreach (var ax in distintaAX)
        //    {
        //        if (!distintaCREO.ContainsKey(ax.Key))
        //        {
        //            // Codice non trovato in CREO (rosso)
        //            var row = dgvDistintaAX.Rows
        //                .Cast<DataGridViewRow>()
        //                .FirstOrDefault(r => NormalizzaCodice(r.Cells[0].Value?.ToString()) == ax.Key);
        //            if (row != null)
        //            {
        //                row.DefaultCellStyle.BackColor = Color.Red;
        //                row.Cells[3].Value = 0; // Quantità in CREO
        //                modifiche.Add($"Rimuovi {ax.Key} - Quantità: {ax.Value.quantita} da AX");
        //            }
        //        }
        //        else if (distintaCREO[ax.Key].quantita != ax.Value.quantita)
        //        {
        //            // Quantità diversa (giallo)
        //            var row = dgvDistintaAX.Rows
        //                .Cast<DataGridViewRow>()
        //                .FirstOrDefault(r => NormalizzaCodice(r.Cells[0].Value?.ToString()) == ax.Key);
        //            if (row != null)
        //            {
        //                row.DefaultCellStyle.BackColor = Color.Yellow;
        //                row.Cells[3].Value = distintaCREO[ax.Key].quantita; // Quantità trovata in CREO
        //                modifiche.Add($"Modifica {ax.Key} in AX - Quantità: {distintaCREO[ax.Key].quantita}");
        //            }
        //        }
        //    }

        //    foreach (var creo in distintaCREO)
        //    {
        //        if (!distintaAX.ContainsKey(creo.Key))
        //        {
        //            // Codice non trovato in AX (verde)
        //            var row = dgvDistintaCREO.Rows
        //                .Cast<DataGridViewRow>()
        //                .FirstOrDefault(r => NormalizzaCodice(r.Cells[0].Value?.ToString()) == creo.Key);
        //            if (row != null)
        //            {
        //                row.DefaultCellStyle.BackColor = Color.Green;
        //                row.Cells[3].Value = 0; // Quantità in AX
        //                modifiche.Add($"Aggiungi {creo.Key} - Quantità: {creo.Value.quantita} a AX");
        //            }
        //        }
        //        else if (distintaAX[creo.Key].quantita != creo.Value.quantita)
        //        {
        //            // Quantità diversa (azzurro)
        //            var row = dgvDistintaCREO.Rows
        //                .Cast<DataGridViewRow>()
        //                .FirstOrDefault(r => NormalizzaCodice(r.Cells[0].Value?.ToString()) == creo.Key);
        //            if (row != null)
        //            {
        //                row.DefaultCellStyle.BackColor = Color.Aqua;
        //                row.Cells[3].Value = distintaAX[creo.Key].quantita; // Quantità trovata in AX
        //            }
        //        }
        //    }
        //}

        //private void AvviaConfronto()
        //{
        //    // Resetta i colori delle righe e i valori delle colonne 'Trovato in...'
        //    foreach (DataGridViewRow row in dgvDistintaAX.Rows)
        //    {
        //        row.DefaultCellStyle.BackColor = Color.White;
        //        row.Cells[4].Value = null; // Resetta il valore
        //    }

        //    foreach (DataGridViewRow row in dgvDistintaCREO.Rows)
        //    {
        //        row.DefaultCellStyle.BackColor = Color.White;
        //        row.Cells[4].Value = null; // Resetta il valore
        //    }

        //    modifiche.Clear(); // Svuota la lista delle modifiche prima di iniziare un nuovo confronto

        //    var distintaAX = new Dictionary<string, (string gruppo, string descrizione, int quantita)>();
        //    var distintaCREO = new Dictionary<string, (string livello, string descrizione, int quantita)>();
        //    var duplicatiAX = new HashSet<string>();
        //    var duplicatiCREO = new HashSet<string>();

        //    // Lettura dati dalla DISTINTA AX
        //    foreach (DataGridViewRow row in dgvDistintaAX.Rows)
        //    {
        //        if (row.Cells[1].Value != null)
        //        {
        //            var livello = row.Cells[0]?.Value?.ToString() ?? "";
        //            var codice = NormalizzaCodice(row.Cells[1].Value.ToString());
        //            var descrizione = row.Cells[2]?.Value?.ToString() ?? "";
        //            var quantita = ConvertiQuantita(row.Cells[3]?.Value?.ToString());

        //            // Gestione duplicati
        //            if (distintaAX.ContainsKey(codice))
        //            {
        //                distintaAX[codice] = (livello, descrizione, distintaAX[codice].quantita + quantita);
        //                duplicatiAX.Add(codice); // Segna come duplicato
        //            }
        //            else
        //            {
        //                distintaAX[codice] = (livello, descrizione, quantita);
        //            }
        //        }
        //    }

        //    // Evidenzia righe duplicate nella griglia AX
        //    foreach (DataGridViewRow row in dgvDistintaAX.Rows)
        //    {
        //        var codice = NormalizzaCodice(row.Cells[1].Value?.ToString());
        //        if (duplicatiAX.Contains(codice))
        //        {
        //            row.DefaultCellStyle.BackColor = Color.Fuchsia;
        //        }
        //    }

        //    // Lettura dati dalla DISTINTA CREO
        //    foreach (DataGridViewRow row in dgvDistintaCREO.Rows)
        //    {
        //        if (row.Cells[1].Value != null)
        //        {
        //            var livello = row.Cells[0]?.Value?.ToString() ?? "";
        //            var codice = NormalizzaCodice(row.Cells[1].Value.ToString());
        //            var descrizione = row.Cells[2]?.Value?.ToString() ?? "";
        //            var quantita = ConvertiQuantita(row.Cells[3]?.Value?.ToString());

        //            // Gestione duplicati
        //            if (distintaCREO.ContainsKey(codice))
        //            {
        //                distintaCREO[codice] = (livello, descrizione, distintaCREO[codice].quantita + quantita);
        //                duplicatiCREO.Add(codice); // Segna come duplicato
        //            }
        //            else
        //            {
        //                distintaCREO[codice] = (livello, descrizione, quantita);
        //            }
        //        }
        //    }

        //    // Evidenzia righe duplicate nella griglia CREO
        //    foreach (DataGridViewRow row in dgvDistintaCREO.Rows)
        //    {
        //        var codice = NormalizzaCodice(row.Cells[1].Value?.ToString());
        //        if (duplicatiCREO.Contains(codice))
        //        {
        //            row.DefaultCellStyle.BackColor = Color.Fuchsia;
        //        }
        //    }

        //    // Confronto tra le due distinte
        //    foreach (var ax in distintaAX)
        //    {
        //        if (!distintaCREO.ContainsKey(ax.Key))
        //        {
        //            // Codice non trovato in CREO (rosso)
        //            var row = dgvDistintaAX.Rows
        //                .Cast<DataGridViewRow>()
        //                .FirstOrDefault(r => NormalizzaCodice(r.Cells[1].Value?.ToString()) == ax.Key);
        //            if (row != null)
        //            {
        //                row.DefaultCellStyle.BackColor = Color.Red;
        //                row.Cells[4].Value = 0; // Quantità in CREO
        //                modifiche.Add($"Rimuovi {ax.Key} - Quantità: {ax.Value.quantita} da AX");
        //            }
        //        }
        //        else if (distintaCREO[ax.Key].quantita != ax.Value.quantita)
        //        {
        //            // Quantità diversa (giallo)
        //            var row = dgvDistintaAX.Rows
        //                .Cast<DataGridViewRow>()
        //                .FirstOrDefault(r => NormalizzaCodice(r.Cells[1].Value?.ToString()) == ax.Key);
        //            if (row != null)
        //            {
        //                row.DefaultCellStyle.BackColor = Color.Yellow;
        //                row.Cells[4].Value = distintaCREO[ax.Key].quantita; // Quantità trovata in CREO
        //                modifiche.Add($"Modifica {ax.Key} in AX - Quantità: {distintaCREO[ax.Key].quantita}");
        //            }
        //        }
        //    }

        //    foreach (var creo in distintaCREO)
        //    {
        //        if (!distintaAX.ContainsKey(creo.Key))
        //        {
        //            // Codice non trovato in AX (verde)
        //            var row = dgvDistintaCREO.Rows
        //                .Cast<DataGridViewRow>()
        //                .FirstOrDefault(r => NormalizzaCodice(r.Cells[1].Value?.ToString()) == creo.Key);
        //            if (row != null)
        //            {
        //                row.DefaultCellStyle.BackColor = Color.Green;
        //                row.Cells[4].Value = 0; // Quantità in AX
        //                modifiche.Add($"Aggiungi {creo.Key} - Quantità: {creo.Value.quantita} a AX");
        //            }
        //        }
        //        else if (distintaAX[creo.Key].quantita != creo.Value.quantita)
        //        {
        //            // Quantità diversa (azzurro)
        //            var row = dgvDistintaCREO.Rows
        //                .Cast<DataGridViewRow>()
        //                .FirstOrDefault(r => NormalizzaCodice(r.Cells[1].Value?.ToString()) == creo.Key);
        //            if (row != null)
        //            {
        //                row.DefaultCellStyle.BackColor = Color.Aqua;
        //                row.Cells[4].Value = distintaAX[creo.Key].quantita; // Quantità trovata in AX
        //            }
        //        }
        //    }
        //}

        //private void AvviaConfronto()
        //{
        //    // Resetta i colori delle righe e i valori delle colonne 'Trovato in...'
        //    foreach (DataGridViewRow row in dgvDistintaAX.Rows)
        //    {
        //        row.DefaultCellStyle.BackColor = Color.White;
        //        row.Cells[4].Value = null; // Resetta il valore
        //    }

        //    foreach (DataGridViewRow row in dgvDistintaCREO.Rows)
        //    {
        //        row.DefaultCellStyle.BackColor = Color.White;
        //        row.Cells[4].Value = null; // Resetta il valore
        //    }

        //    modifiche.Clear(); // Svuota la lista delle modifiche prima di iniziare un nuovo confronto

        //    var distintaAX = new Dictionary<(string livello, string codice), (string descrizione, int quantita)>();
        //    var distintaCREO = new Dictionary<(string livello, string codice), (string descrizione, int quantita)>();
        //    var duplicatiAX = new HashSet<(string livello, string codice)>();
        //    var duplicatiCREO = new HashSet<(string livello, string codice)>();

        //    // Lettura dati dalla DISTINTA AX
        //    foreach (DataGridViewRow row in dgvDistintaAX.Rows)
        //    {
        //        if (row.Cells[1].Value != null)
        //        {
        //            var livello = row.Cells[0]?.Value?.ToString() ?? "";
        //            var codice = NormalizzaCodice(row.Cells[1].Value.ToString());
        //            var descrizione = row.Cells[2]?.Value?.ToString() ?? "";
        //            var quantita = ConvertiQuantita(row.Cells[3]?.Value?.ToString());

        //            var chiave = (livello, codice);

        //            // Gestione duplicati
        //            if (distintaAX.ContainsKey(chiave))
        //            {
        //                distintaAX[chiave] = (descrizione, distintaAX[chiave].quantita + quantita);
        //                duplicatiAX.Add(chiave); // Segna come duplicato
        //            }
        //            else
        //            {
        //                distintaAX[chiave] = (descrizione, quantita);
        //            }
        //        }
        //    }

        //    // Evidenzia righe duplicate nella griglia AX
        //    foreach (DataGridViewRow row in dgvDistintaAX.Rows)
        //    {
        //        var livello = row.Cells[0]?.Value?.ToString() ?? "";
        //        var codice = NormalizzaCodice(row.Cells[1].Value?.ToString());
        //        var chiave = (livello, codice);

        //        if (duplicatiAX.Contains(chiave))
        //        {
        //            row.DefaultCellStyle.BackColor = Color.Fuchsia;
        //        }
        //    }

        //    // Lettura dati dalla DISTINTA CREO
        //    foreach (DataGridViewRow row in dgvDistintaCREO.Rows)
        //    {
        //        if (row.Cells[1].Value != null)
        //        {
        //            var livello = row.Cells[0]?.Value?.ToString() ?? "";
        //            var codice = NormalizzaCodice(row.Cells[1].Value.ToString());
        //            var descrizione = row.Cells[2]?.Value?.ToString() ?? "";
        //            var quantita = ConvertiQuantita(row.Cells[3]?.Value?.ToString());

        //            var chiave = (livello, codice);

        //            // Gestione duplicati
        //            if (distintaCREO.ContainsKey(chiave))
        //            {
        //                distintaCREO[chiave] = (descrizione, distintaCREO[chiave].quantita + quantita);
        //                duplicatiCREO.Add(chiave); // Segna come duplicato
        //            }
        //            else
        //            {
        //                distintaCREO[chiave] = (descrizione, quantita);
        //            }
        //        }
        //    }

        //    // Evidenzia righe duplicate nella griglia CREO
        //    foreach (DataGridViewRow row in dgvDistintaCREO.Rows)
        //    {
        //        var livello = row.Cells[0]?.Value?.ToString() ?? "";
        //        var codice = NormalizzaCodice(row.Cells[1].Value?.ToString());
        //        var chiave = (livello, codice);

        //        if (duplicatiCREO.Contains(chiave))
        //        {
        //            row.DefaultCellStyle.BackColor = Color.Fuchsia;
        //        }
        //    }

        //    // Confronto tra le due distinte
        //    foreach (var ax in distintaAX)
        //    {
        //        if (!distintaCREO.ContainsKey(ax.Key))
        //        {
        //            // Codice non trovato in CREO (rosso)
        //            var row = dgvDistintaAX.Rows
        //                .Cast<DataGridViewRow>()
        //                .FirstOrDefault(r =>
        //                    (r.Cells[0]?.Value?.ToString() ?? "", NormalizzaCodice(r.Cells[1].Value?.ToString())) == ax.Key);
        //            if (row != null)
        //            {
        //                row.DefaultCellStyle.BackColor = Color.Red;
        //                row.Cells[4].Value = 0; // Quantità in CREO
        //                modifiche.Add($"Rimuovi {ax.Key.codice} - Quantità: {ax.Value.quantita} da AX");
        //            }
        //        }
        //        else if (distintaCREO[ax.Key].quantita != ax.Value.quantita)
        //        {
        //            // Quantità diversa (giallo)
        //            var row = dgvDistintaAX.Rows
        //                .Cast<DataGridViewRow>()
        //                .FirstOrDefault(r =>
        //                    (r.Cells[0]?.Value?.ToString() ?? "", NormalizzaCodice(r.Cells[1].Value?.ToString())) == ax.Key);
        //            if (row != null)
        //            {
        //                row.DefaultCellStyle.BackColor = Color.Yellow;
        //                row.Cells[4].Value = distintaCREO[ax.Key].quantita; // Quantità trovata in CREO
        //                modifiche.Add($"Modifica {ax.Key.codice} in AX - Quantità: {distintaCREO[ax.Key].quantita}");
        //            }
        //        }
        //    }

        //    foreach (var creo in distintaCREO)
        //    {
        //        if (!distintaAX.ContainsKey(creo.Key))
        //        {
        //            // Codice non trovato in AX (verde)
        //            var row = dgvDistintaCREO.Rows
        //                .Cast<DataGridViewRow>()
        //                .FirstOrDefault(r =>
        //                    (r.Cells[0]?.Value?.ToString() ?? "", NormalizzaCodice(r.Cells[1].Value?.ToString())) == creo.Key);
        //            if (row != null)
        //            {
        //                row.DefaultCellStyle.BackColor = Color.Green;
        //                row.Cells[4].Value = 0; // Quantità in AX
        //                modifiche.Add($"Aggiungi {creo.Key.codice} - Quantità: {creo.Value.quantita} a AX");
        //            }
        //        }
        //        else if (distintaAX[creo.Key].quantita != creo.Value.quantita)
        //        {
        //            // Quantità diversa (azzurro)
        //            var row = dgvDistintaCREO.Rows
        //                .Cast<DataGridViewRow>()
        //                .FirstOrDefault(r =>
        //                    (r.Cells[0]?.Value?.ToString() ?? "", NormalizzaCodice(r.Cells[1].Value?.ToString())) == creo.Key);
        //            if (row != null)
        //            {
        //                row.DefaultCellStyle.BackColor = Color.Aqua;
        //                row.Cells[4].Value = distintaAX[creo.Key].quantita; // Quantità trovata in AX
        //            }
        //        }
        //    }
        //}

        private void AvviaConfronto()
        {
            // Resetta i colori delle righe e i valori delle colonne 'Trovato in...'
            foreach (DataGridViewRow row in dgvDistintaAX.Rows)
            {
                row.DefaultCellStyle.BackColor = Color.White;
                row.Cells[4].Value = null; // Resetta il valore
            }

            foreach (DataGridViewRow row in dgvDistintaCREO.Rows)
            {
                row.DefaultCellStyle.BackColor = Color.White;
                row.Cells[4].Value = null; // Resetta il valore
            }

            modifiche.Clear(); // Svuota la lista delle modifiche prima di iniziare un nuovo confronto

            var distintaAX = new Dictionary<(string gruppo, string codice), (string descrizione, int quantita)>();
            var distintaCREO = new Dictionary<(string gruppo, string codice), (string descrizione, int quantita)>();
            var duplicatiAX = new HashSet<(string gruppo, string codice)>();
            var duplicatiCREO = new HashSet<(string gruppo, string codice)>();

            // Lettura dati dalla DISTINTA AX
            foreach (DataGridViewRow row in dgvDistintaAX.Rows)
            {
                if (row.Cells[1].Value != null)
                {
                    var gruppo = row.Cells[0]?.Value?.ToString() ?? "";
                    var codice = NormalizzaCodice(row.Cells[1].Value.ToString());
                    var descrizione = row.Cells[2]?.Value?.ToString() ?? "";
                    var quantita = ConvertiQuantita(row.Cells[3]?.Value?.ToString());

                    var chiave = (gruppo, codice);

                    // Gestione duplicati
                    if (distintaAX.ContainsKey(chiave))
                    {
                        distintaAX[chiave] = (descrizione, distintaAX[chiave].quantita + quantita);
                        duplicatiAX.Add(chiave); // Segna come duplicato
                    }
                    else
                    {
                        distintaAX[chiave] = (descrizione, quantita);
                    }
                }
            }

            // Evidenzia righe duplicate nella griglia AX
            foreach (DataGridViewRow row in dgvDistintaAX.Rows)
            {
                var gruppo = row.Cells[0]?.Value?.ToString() ?? "";
                var codice = NormalizzaCodice(row.Cells[1].Value?.ToString());
                var chiave = (gruppo, codice);

                if (duplicatiAX.Contains(chiave))
                {
                    row.DefaultCellStyle.BackColor = Color.Fuchsia;
                }
            }

            // Lettura dati dalla DISTINTA CREO
            foreach (DataGridViewRow row in dgvDistintaCREO.Rows)
            {
                if (row.Cells[1].Value != null)
                {
                    var gruppo = row.Cells[0]?.Value?.ToString() ?? "";
                    var codice = NormalizzaCodice(row.Cells[1].Value.ToString());
                    var descrizione = row.Cells[2]?.Value?.ToString() ?? "";
                    var quantita = ConvertiQuantita(row.Cells[3]?.Value?.ToString());

                    var chiave = (gruppo, codice);

                    // Gestione duplicati
                    if (distintaCREO.ContainsKey(chiave))
                    {
                        distintaCREO[chiave] = (descrizione, distintaCREO[chiave].quantita + quantita);
                        duplicatiCREO.Add(chiave); // Segna come duplicato
                    }
                    else
                    {
                        distintaCREO[chiave] = (descrizione, quantita);
                    }
                }
            }

            // Evidenzia righe duplicate nella griglia CREO
            foreach (DataGridViewRow row in dgvDistintaCREO.Rows)
            {
                var gruppo = row.Cells[0]?.Value?.ToString() ?? "";
                var codice = NormalizzaCodice(row.Cells[1].Value?.ToString());
                var chiave = (gruppo, codice);

                if (duplicatiCREO.Contains(chiave))
                {
                    row.DefaultCellStyle.BackColor = Color.Fuchsia;
                }
            }

            // Confronto tra le due distinte
            foreach (var ax in distintaAX)
            {
                if (!distintaCREO.ContainsKey(ax.Key))
                {
                    // Codice non trovato in CREO (rosso)
                    var row = dgvDistintaAX.Rows
                        .Cast<DataGridViewRow>()
                        .FirstOrDefault(r =>
                            (r.Cells[0]?.Value?.ToString() ?? "", NormalizzaCodice(r.Cells[1].Value?.ToString())) == ax.Key);
                    if (row != null)
                    {
                        row.DefaultCellStyle.BackColor = Color.Red;
                        row.Cells[4].Value = 0; // Quantità in CREO
                        modifiche.Add($"Rimuovi {ax.Key.codice} dal gruppo {ax.Key.gruppo} - Quantità: {ax.Value.quantita} da AX");
                    }
                }
                else if (distintaCREO[ax.Key].quantita != ax.Value.quantita)
                {
                    // Quantità diversa (giallo)
                    var row = dgvDistintaAX.Rows
                        .Cast<DataGridViewRow>()
                        .FirstOrDefault(r =>
                            (r.Cells[0]?.Value?.ToString() ?? "", NormalizzaCodice(r.Cells[1].Value?.ToString())) == ax.Key);
                    if (row != null)
                    {
                        row.DefaultCellStyle.BackColor = Color.Yellow;
                        row.Cells[4].Value = distintaCREO[ax.Key].quantita; // Quantità trovata in CREO
                        modifiche.Add($"Modifica {ax.Key.codice} nel gruppo {ax.Key.gruppo} in AX - Nuova Quantità: {distintaCREO[ax.Key].quantita}");
                    }
                }
            }

            foreach (var creo in distintaCREO)
            {
                if (!distintaAX.ContainsKey(creo.Key))
                {
                    // Codice non trovato in AX (verde)
                    var row = dgvDistintaCREO.Rows
                        .Cast<DataGridViewRow>()
                        .FirstOrDefault(r =>
                            (r.Cells[0]?.Value?.ToString() ?? "", NormalizzaCodice(r.Cells[1].Value?.ToString())) == creo.Key);
                    if (row != null)
                    {
                        row.DefaultCellStyle.BackColor = Color.Green;
                        row.Cells[4].Value = 0; // Quantità in AX
                        modifiche.Add($"Aggiungi {creo.Key.codice} nel gruppo {creo.Key.gruppo} - Quantità: {creo.Value.quantita} a AX");
                    }
                }
                else if (distintaAX[creo.Key].quantita != creo.Value.quantita)
                {
                    // Quantità diversa (azzurro)
                    var row = dgvDistintaCREO.Rows
                        .Cast<DataGridViewRow>()
                        .FirstOrDefault(r =>
                            (r.Cells[0]?.Value?.ToString() ?? "", NormalizzaCodice(r.Cells[1].Value?.ToString())) == creo.Key);
                    if (row != null)
                    {
                        row.DefaultCellStyle.BackColor = Color.Aqua;
                        row.Cells[4].Value = distintaAX[creo.Key].quantita; // Quantità trovata in AX
                        //modifiche.Add($"Modifica {creo.Key.codice} nel livello {creo.Key.livello} in CREO - Nuova Quantità: {distintaAX[creo.Key].quantita}");
                    }
                }
            }
        }


        private void BtnApriImport_Click(object sender, EventArgs e)
        {
            import import = new();
            import.ShowDialog();
        }

        private void BtnConfronta_Click(object sender, EventArgs e)
        {
            AvviaConfronto();
        }

        private void BtnApriModifiche_Click(object sender, EventArgs e)
        {
            if (modifiche.Count == 0)
            {
                // Nessuna modifica da fare
                MessageBox.Show("Nessuna modifica da fare", "Informazione", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Avvisa che la lista potrebbe non essere aggiornata
            //var result = MessageBox.Show("La lista delle modifiche potrebbe non essere aggiornata. Vuoi continuare?",
            //    "Avviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            //if (result == DialogResult.No)
            //{
            //    return; // L'utente ha scelto di non aprire la lista
            //}

            // Apri la form delle modifiche
            ModificheDistintaAXForm modificheForm = new();
            foreach (var modifica in modifiche)
            {
                modificheForm.dataGridViewReport.Rows.Add(modifica);
            }
            modificheForm.ShowDialog();
        }

        private void BtnResetTabelle_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Tutte le modifiche andranno perse, azione non reversibile. Vuoi continuare?",
            "Avviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.No)
            {
                return; // L'utente ha scelto di non aprire la lista
            }
            dgvDistintaAX.Rows.Clear();
            dgvDistintaCREO.Rows.Clear();
            dgvDistintaAX.Columns["dataGridViewTextBoxColumn6"].Visible = true;
            dgvDistintaCREO.Columns["dataGridViewTextBoxColumn2"].Visible = true;
            modifiche = new List<string>();
            //Aggiungi righe vuote(300);
            InizializzaDataGridView();
        }

        private void DataGridView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.V) // Controlla Ctrl + V
            {
                if (sender is not DataGridView dgv) return;

                // Ottieni i dati dalla clipboard
                string clipboardText = Clipboard.GetText();
                if (string.IsNullOrWhiteSpace(clipboardText)) return;

                // Dividi i dati in righe
                string[] rows = clipboardText.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.RemoveEmptyEntries);

                int startRow = dgv.CurrentCell?.RowIndex ?? 0;
                int startCol = dgv.CurrentCell?.ColumnIndex ?? 0;

                for (int i = 0; i < rows.Length; i++)
                {
                    string[] cells = rows[i].Split('\t');
                    int targetRow = startRow + i;

                    // Aggiungi una nuova riga se necessario
                    if (targetRow >= dgv.RowCount)
                    {
                        dgv.Rows.Add();
                        dgv.Rows[targetRow].HeaderCell.Value = (targetRow + 1).ToString();
                    }

                    for (int j = 0; j < cells.Length; j++)
                    {
                        int targetCol = startCol + j;

                        // Verifica se la cella di destinazione esiste
                        if (targetCol < dgv.ColumnCount)
                        {
                            dgv.Rows[targetRow].Cells[targetCol].Value = cells[j].Trim();
                        }
                    }
                }
            }
        }

        private void ButtonHideDescrizione_Click(object sender, EventArgs e)
        {
            dgvDistintaAX.Columns["dataGridViewTextBoxColumn6"].Visible = false;
            dgvDistintaCREO.Columns["dataGridViewTextBoxColumn2"].Visible = false;
        }

        private void ButtonSuggest_Click(object sender, EventArgs e)
        {
            FormSuggerimenti formSuggerimenti = new();
            formSuggerimenti.ShowDialog();
        }
    }
}
