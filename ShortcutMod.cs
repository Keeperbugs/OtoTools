using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace OtoTools
{
    public partial class ShortcutMod : UserControl
    {
        public ShortcutMod()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            treeView1.Columns.Add("Shortcut Path", "Nome link");
            treeView1.Columns.Add("Target Path", "Target link");
        }

        private void GetShortcutTarget(string shortcutPath, out string targetPath)
        {
            IWshRuntimeLibrary.WshShell shell = new();
            IWshRuntimeLibrary.IWshShortcut shortcut = (IWshRuntimeLibrary.IWshShortcut)shell.CreateShortcut(shortcutPath);
            targetPath = shortcut.TargetPath;
        }

        private List<(string, string)> GetShortcuts(string folderPath, bool includeSubfolders)
        {
            List<(string, string)> shortcuts = new();

            foreach (string filePath in Directory.GetFiles(folderPath, "*.lnk", includeSubfolders ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly))
            {
                GetShortcutTarget(filePath, out string targetPath);
                shortcuts.Add((filePath, targetPath));
            }

            return shortcuts;
        }

        private void UpdateShortcutTarget(string shortcutPath, string oldText, string newText)
        {
            IWshRuntimeLibrary.WshShell shell = new();
            IWshRuntimeLibrary.IWshShortcut shortcut = (IWshRuntimeLibrary.IWshShortcut)shell.CreateShortcut(shortcutPath);
            string targetPath = shortcut.TargetPath.Replace(oldText, newText);
            shortcut.TargetPath = targetPath;
            shortcut.Save();
        }
        private static string GetFileNameFromPath(string filePath)
        {
            return Path.GetFileName(filePath);
        }

        private void BrowseFolder()
        {
            folderBrowserDialog1.Description = "Seleziona cartella";
            DialogResult result = folderBrowserDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                bool includeSubfolders = includeSubfoldersCheckBox.Checked;
                List<(string, string)> shortcuts = GetShortcuts(folderBrowserDialog1.SelectedPath, includeSubfolders);

                treeView1.Items.Clear();

                foreach (var (shortcutPath, targetPath) in shortcuts)
                {
                    ListViewItem item = new(new string[] { GetFileNameFromPath(shortcutPath), targetPath });
                    treeView1.Items.Add(item);
                }
            }
        }

        private void UpdateShortcuts()
        {
            string oldText = oldTextTextBox.Text;
            string newText = newTextTextBox.Text;

            foreach (ListViewItem item in treeView1.Items)
            {
                string shortcutPath = item.SubItems[0].Text;
                string targetPath = item.SubItems[1].Text;

                string updatedTargetPath = targetPath.Replace(oldText, newText);
                UpdateShortcutTarget(shortcutPath, targetPath, updatedTargetPath);

                // Aggiungi la nuova colonna e visualizza il collegamento modificato
                item.SubItems.Add(updatedTargetPath);
            }

            MessageBox.Show("Shortcut targets updated successfully.");
        }

        private void IncludeSubfoldersCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (includeSubfoldersCheckBox.Checked)
            {
                // Se la checkbox "Includi sottocartelle" è selezionata, esegui il controllo delle sottocartelle
                BrowseFolder();
            }
        }

        private void BrowseButton_Click(object sender, EventArgs e)
        {
            BrowseFolder();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            UpdateShortcuts();
        }
    }
}
