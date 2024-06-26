﻿using Octokit;
using System;
using System.Collections.Generic;
using System.Device.Location;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QSOLink_Logbook
{
    public partial class QSOLinkLogBookWindow : Form
    {
        public string Version = "v4.0-Alpha"; // CHANGE THIS WHEN A NEW VERSION COMES OUT!!!

        private AddContact AddContactForm = new AddContact();
        private Changelog ChangelogForm = new Changelog();
        private Settings SettingsForm = new Settings();
        private List<ContactInfo> contacts = new List<ContactInfo>();
        private System.Windows.Forms.Timer timer;

        private GeoCoordinateWatcher watcher = new GeoCoordinateWatcher(GeoPositionAccuracy.Default);

        public QSOLinkLogBookWindow()
        {
            InitializeComponent();
            label1.Text = Version;
            RefreshContacts(false);
            LoadSettings();
            MacroButtonsSetup();
            this.KeyDown += Form1_KeyDown;

            // Initialize the timer
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 10000;
            timer.Tick += Timer_Tick;



            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            LocationMessage();
        }

        bool location_services_enabled = false;

        private void LoadSettings()
        {
            AppSettings settings = SettingsManager.LoadSettings();
            CallsignLabel.Text = settings.Callsign;
            location_services_enabled = settings.locserv;
            CallsignLabel.Visible = settings.DisplayCallSign;
            MacroButtonsSetup();

            /*
            if (!settings.AlphaWarn)
            {
                MessageBox.Show("This is an Alpha release. If you have any problems, please open an issue on my GitHub (https://s.lopastudio.sk/issue)");
            }
            */
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                macro1.PerformClick();
            }
            else if (e.KeyCode == Keys.F2)
            {
                macro2.PerformClick();
                // button3.PerformClick(); Print button - Disabled
            }
            else if (e.KeyCode == Keys.F3)
            {
                macro3.PerformClick();
            }
            else if (e.KeyCode == Keys.F4)
            {
                macro4.PerformClick();
            }

        }

        private void MacroButtonsSetup()
        {
            //Properties.Settings.Default.MacroButton1


            // Macro Button 1
            string[] labels1 = { "Refresh", "Add Contact", "Help", "Save as", "Load", "Export to ADIF", "Import ADIF" };
            int selectedIndex1 = Properties.Settings.Default.MacroButton1;
            if (selectedIndex1 >= 0 && selectedIndex1 < labels1.Length)
            {
                string label1 = labels1[selectedIndex1];
                macro1.Text = label1;
            }
            else
            {
                macro1.Text = "Invalid";
            }

            // Macro Button 2
            string[] labels2 = { "Refresh", "Add Contact", "Help", "Save as", "Load", "Export to ADIF", "Import ADIF" };
            int selectedIndex2 = Properties.Settings.Default.MacroButton2;
            if (selectedIndex2 >= 0 && selectedIndex2 < labels2.Length)
            {
                string label2 = labels2[selectedIndex2];
                macro2.Text = label2;
            }
            else
            {
                macro2.Text = "Invalid";
            }

            // Macro Button 3
            string[] labels3 = { "Refresh", "Add Contact", "Help", "Save as", "Load", "Export to ADIF", "Import ADIF" };
            int selectedIndex3 = Properties.Settings.Default.MacroButton3;
            if (selectedIndex3 >= 0 && selectedIndex3 < labels3.Length)
            {
                string label3 = labels3[selectedIndex3];
                macro3.Text = label3;
            }
            else
            {
                macro3.Text = "Invalid";
            }

            // Macro Button 4
            string[] labels4 = { "Refresh", "Add Contact", "Help", "Save as", "Load", "Export to ADIF", "Import ADIF" };
            int selectedIndex4 = Properties.Settings.Default.MacroButton4;
            if (selectedIndex4 >= 0 && selectedIndex4 < labels4.Length)
            {
                string label4 = labels4[selectedIndex4];
                macro4.Text = label4;
            }
            else
            {
                macro4.Text = "Invalid";
            }



        }

        private void dataGridView1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            // Block all keyboard input except for arrow keys (for scrolling)
            if (e.KeyCode != Keys.Up && e.KeyCode != Keys.Down &&
                e.KeyCode != Keys.Left && e.KeyCode != Keys.Right)
            {
                e.IsInputKey = true;
            }
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            RefreshContacts(false);
            LoadSettings();


            // Updating logic

            var latestRelease = await CheckForUpdatesAsync();
            if (latestRelease != null)
            {
                var dialogResult = MessageBox.Show(
                    $"A new version ({latestRelease.TagName}) is available. Do you want to update?",
                    "Update Available",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Information
                );

                if (dialogResult == DialogResult.Yes)
                {
                    System.Diagnostics.Process.Start(latestRelease.HtmlUrl);
                }
            }
        }




        private async Task<Release> CheckForUpdatesAsync()
        {
            var github = new GitHubClient(new ProductHeaderValue("QSOLink-Logbook"));
            var releases = await github.Repository.Release.GetAll("Lopastudio", "QSOLink-Logbook");
            var latestRelease = releases.FirstOrDefault(); // Assumes releases are sorted in descending order (latest first). Please do not critisize it. It is my first time making an actual working updater. Thanks :)

            if (latestRelease != null && !IsCurrentVersion(latestRelease.TagName))
            {
                return latestRelease;
            }
            else
            {
                return null;
            }
        }

        private bool IsCurrentVersion(string latestVersion)
        {
            var currentVersion = Version;
            return string.Equals(currentVersion, latestVersion, StringComparison.OrdinalIgnoreCase);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] labels4 = { "Refresh", "Add Contact", "Help", "Save as", "Load", "Export to ADIF", "Import ADIF" };
            int selectedIndex4 = Properties.Settings.Default.MacroButton4;

            if (selectedIndex4 >= 0 && selectedIndex4 < labels4.Length)
            {
                string label = labels4[selectedIndex4];
                macro4.Text = label;

                switch (selectedIndex4)
                {
                    case 0:
                        RefreshContacts(false);
                        break;
                    case 1:
                        AddContactForm = new AddContact(contacts);
                        AddContactForm.ShowDialog();
                        RefreshContacts(false);
                        break;
                    case 2:
                        System.Diagnostics.Process.Start("https://github.com/Lopastudio/QSOLink-Logbook/wiki");
                        break;
                    case 3:
                        SaveContactsToBinary(true);
                        break;
                    case 4:
                        RefreshContacts(true);
                        SaveContactsToBinary(false);
                        break;
                    case 5:
                        ExportADIF_Click();
                        break;
                    case 6:
                        ImportADIF_Click();
                        break;
                    default:
                        MessageBox.Show("Error: Invalid Macro Button Code. Please report this error message on our Github Page (s.lopastudio.sk/issue).", "Backend Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                }
            }
            else
            {
                macro4.Text = "MacroButtonError";
            }
        }

        private void RefreshContacts(bool SaveFileDialogShow)
        {
            string filePath = "";
            if (SaveFileDialogShow == true)
            {
                FileDialog FileDialog = new OpenFileDialog();
                FileDialog.Filter = "QSOLink Data Files|*.DAT";

                if (FileDialog.ShowDialog() == DialogResult.OK)
                {
                    string SaveFilePath = FileDialog.FileName;
                    filePath = SaveFilePath;
                }
            }
            else
            {
                filePath = "Contacts.dat";
            }

            if (File.Exists(filePath))
            {
                using (FileStream stream = new FileStream(filePath, System.IO.FileMode.Open))
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    contacts = (List<ContactInfo>)formatter.Deserialize(stream);
                }
            }

            dataGridView1.DataSource = contacts;

            /*
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                DataGridViewCell cell = row.Cells["IsDX"];
                if (cell != null)
                {
                    cell.ReadOnly = true;
                }
            }
            */

            // Hide the "indexNumber" column
            if (dataGridView1.Columns.Contains("indexNumber"))
            {
                dataGridView1.Columns["indexNumber"].Visible = false;
            }

            LoadSettings();
        }

        private void ExportToHtml(string htmlFilePath)
        {
            try
            {
                AppSettings settings = SettingsManager.LoadSettings();
                using (StreamWriter writer = new StreamWriter(htmlFilePath, false, Encoding.UTF8))
                {
                    writer.WriteLine("<html>");
                    writer.WriteLine("<head>");
                    writer.WriteLine("<title>QSOLink-Logbook Contacts</title>");
                    writer.WriteLine("<link rel='stylesheet' href='https://stackpath.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css'>");
                    writer.WriteLine("</head>");
                    writer.WriteLine("<body>");
                    writer.WriteLine("<div class='container'>");
                    writer.WriteLine("<h1 class='mt-4'>Contact logbook of: " + settings.Callsign + "</h1>");
                    writer.WriteLine("<h1 class='mt-4'>Rig: " + settings.Rig + "</h1>");
                    writer.WriteLine("<table class='table table-bordered mt-4'>");
                    writer.WriteLine("<thead class='thead-dark'>");
                    writer.WriteLine("<tr>");
                    foreach (DataGridViewColumn column in dataGridView1.Columns)
                    {
                        // Exclude "indexNumber" column
                        if (column.Name != "indexNumber")
                        {
                            writer.WriteLine("<th>" + column.HeaderText + "</th>");
                        }
                    }
                    writer.WriteLine("</tr>");
                    writer.WriteLine("</thead>");

                    // Export data
                    writer.WriteLine("<tbody>");
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        writer.WriteLine("<tr>");
                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            if (dataGridView1.Columns[cell.ColumnIndex].Name != "indexNumber")
                            {
                                writer.WriteLine("<td>" + cell.Value + "</td>");
                            }
                        }
                        writer.WriteLine("</tr>");
                    }
                    writer.WriteLine("</tbody>");

                    writer.WriteLine("</table>");
                    writer.WriteLine("</div>");

                    writer.WriteLine("<script src='https://code.jquery.com/jquery-3.5.1.slim.min.js'></script>");
                    writer.WriteLine("<script src='https://cdn.jsdelivr.net/npm/@popperjs/core@2.9.3/dist/umd/popper.min.js'></script>");
                    writer.WriteLine("<script src='https://stackpath.bootstrapcdn.com/bootstrap/4.5.2/js/bootstrap.min.js'></script>");

                    writer.WriteLine("</body>");
                    writer.WriteLine("</html>");
                }

                MessageBox.Show("Data exported to HTML successfully.", "Export Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex + 1;

            EditContact editContactForm = new EditContact(rowIndex);
            editContactForm.ShowDialog(); // Use ShowDialog to wait for the form to close
            RefreshContacts(false); // Refresh the data after the EditContact form closes
        }

        private void EditButton_TEMP_Click(object sender, EventArgs e)
        {
            string[] labels3 = { "Refresh", "Add Contact", "Help", "Save as", "Load", "Export to ADIF", "Import ADIF" };
            int selectedIndex3 = Properties.Settings.Default.MacroButton3;

            if (selectedIndex3 >= 0 && selectedIndex3 < labels3.Length)
            {
                string label = labels3[selectedIndex3];
                macro3.Text = label;

                switch (selectedIndex3)
                {
                    case 0:
                        RefreshContacts(false);
                        break;
                    case 1:
                        AddContactForm = new AddContact(contacts);
                        AddContactForm.ShowDialog();
                        RefreshContacts(false);
                        break;
                    case 2:
                        System.Diagnostics.Process.Start("https://github.com/Lopastudio/QSOLink-Logbook/wiki");
                        break;
                    case 3:
                        SaveContactsToBinary(true);
                        break;
                    case 4:
                        RefreshContacts(true);
                        SaveContactsToBinary(false);
                        break;
                    case 5:
                        ExportADIF_Click();
                        break;
                    case 6:
                        ImportADIF_Click();
                        break;
                    default:
                        MessageBox.Show("Error: Invalid Macro Button Code. Please report this error message on our Github Page (s.lopastudio.sk/issue).", "Backend Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                }
            }
            else
            {
                macro3.Text = "MacroButtonError";
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // Not in use anymore
        }
        /* Printing code
         string tempHtmlFilePath = Path.Combine(Path.GetTempPath(), "tempPrint.html");
            ExportToHtml(tempHtmlFilePath);

            if (File.Exists(tempHtmlFilePath))
            {
                string pdfFilePath = Path.Combine(Path.GetTempPath(), "tempPrint.pdf");
                HtmlToPdf converter = new HtmlToPdf();
                PdfDocument pdfDocument = converter.ConvertHtmlString(File.ReadAllText(tempHtmlFilePath));
                pdfDocument.Save(pdfFilePath);
                pdfDocument.Close();
                PrintPDF(pdfFilePath);
            }
            else
            {
                MessageBox.Show("The HTML file does not exist.");
            } 
        */
        private void button3_Click(object sender, EventArgs e)
        {
            string[] labels2 = { "Refresh", "Add Contact", "Help", "Save as", "Load", "Export to ADIF", "Import ADIF" };
            int selectedIndex2 = Properties.Settings.Default.MacroButton2;

            if (selectedIndex2 >= 0 && selectedIndex2 < labels2.Length)
            {
                string label = labels2[selectedIndex2];
                macro2.Text = label;

                switch (selectedIndex2)
                {
                    case 0:
                        RefreshContacts(false);
                        break;
                    case 1:
                        AddContactForm = new AddContact(contacts);
                        AddContactForm.ShowDialog();
                        RefreshContacts(false);
                        break;
                    case 2:
                        System.Diagnostics.Process.Start("https://github.com/Lopastudio/QSOLink-Logbook/wiki");
                        break;
                    case 3:
                        SaveContactsToBinary(true);
                        break;
                    case 4:
                        RefreshContacts(true);
                        SaveContactsToBinary(false);
                        break;
                    case 5:
                        ExportADIF_Click();
                        break;
                    case 6:
                        ImportADIF_Click();
                        break;
                    default:
                        MessageBox.Show("Error: Invalid Macro Button Code. Please report this error message on our Github Page (s.lopastudio.sk/issue).", "Backend Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                }
            }
            else
            {
                macro2.Text = "MacroButtonError";
            }
        }

        private void PrintPDF(string pdfFilePath)
        {
            if (File.Exists(pdfFilePath))
            {
                ProcessStartInfo psi = new ProcessStartInfo
                {
                    FileName = pdfFilePath,
                    Verb = "print",
                };
                Process.Start(psi);
            }
            else
            {
                MessageBox.Show("The PDF file does not exist.");
            }
        }



        private void button4_Click(object sender, EventArgs e)
        {
            string[] labels1 = { "Refresh", "Add Contact", "Help", "Save as", "Load", "Export to ADIF", "Import ADIF" };
            int selectedIndex1 = Properties.Settings.Default.MacroButton1;

            if (selectedIndex1 >= 0 && selectedIndex1 < labels1.Length)
            {
                string label = labels1[selectedIndex1];
                macro1.Text = label;

                switch (selectedIndex1)
                {
                    case 0:
                        RefreshContacts(false);
                        break;
                    case 1:
                        AddContactForm = new AddContact(contacts);
                        AddContactForm.ShowDialog();
                        RefreshContacts(false);
                        break;
                    case 2:
                        System.Diagnostics.Process.Start("https://github.com/Lopastudio/QSOLink-Logbook/wiki");
                        break;
                    case 3:
                        SaveContactsToBinary(true);
                        break;
                    case 4:
                        RefreshContacts(true);
                        SaveContactsToBinary(false);
                        break;
                    case 5:
                        ExportADIF_Click();
                        break;
                    case 6:
                        ImportADIF_Click();
                        break;
                    default:
                        MessageBox.Show("Error: Invalid Macro Button Code. Please report this error message on our Github Page (s.lopastudio.sk/issue).", "Backend Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                }
            }
            else
            {
                macro1.Text = "MacroButtonError";
            }

        }

        private void SaveContactsToBinary()
        {
            string filePath = "Contacts.dat";

            using (FileStream stream = new FileStream(filePath, System.IO.FileMode.Create))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(stream, contacts);
            }
        }

        private void RenumberContacts()
        {
            for (int i = 0; i < contacts.Count; i++)
            {
                contacts[i].indexNumber = i + 1;
            }
        }

        private void ImportADIF_Click()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "ADIF Files|*.adi";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string adifFilePath = openFileDialog.FileName;

                List<ContactInfo> importedContacts = ParseADIFFile(adifFilePath);
                if (importedContacts != null && importedContacts.Count > 0)
                {
                    contacts.AddRange(importedContacts);
                    RenumberContacts();
                    SaveContactsToBinary();
                    RefreshContacts(false);
                }
            }
        }

        private void ExportADIF_Click()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "ADIF Files|*.adi";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string adifFilePath = saveFileDialog.FileName;
                string adifContent = GenerateADIFContent(contacts);
                try
                {
                    File.WriteAllText(adifFilePath, adifContent);
                    MessageBox.Show("Contacts exported successfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error exporting contacts: " + ex.Message);
                }
            }
        }

        private string GenerateADIFContent(List<ContactInfo> contacts)
        {
            StringBuilder adifContent = new StringBuilder();

            if (contacts != null)
            {
                foreach (var contact in contacts)
                {
                    if (contact != null) // Check if contact is not null
                    {

                        // Add the mandatory ADIF fields with proper formatting
                        adifContent.AppendLine($"<CALL:{contact.CallSign?.Length}>{contact.CallSign} <RST_RCVD:{contact.RSTRcvd?.Length}>{contact.RSTRcvd} <RST_SENT:{contact.RSTSent?.Length}>{contact.RSTSent} <MODE:{contact.Mode?.Length}>{contact.Mode} <FREQ:{contact.TXFreq?.Length}>{contact.TXFreq}");
                        adifContent.AppendLine("<EOR>"); // End of record marker
                        // <QSO_DATE:8>{contact.QSODate} <TIME_ON:6>{contact.TimeOn} <BAND:{contact.Band?.Length}>{contact.Band}

                        // Work-In-Progress
                    }
                }
            }

            return adifContent.ToString();
        }


        private List<ContactInfo> ParseADIFFile(string adifFilePath)
        {
            List<ContactInfo> importedContacts = new List<ContactInfo>();

            try
            {
                string[] adifLines = File.ReadAllLines(adifFilePath);

                ContactInfo currentContact = null;
                foreach (string line in adifLines)
                {
                    if (line.StartsWith("<CALL:"))
                    {
                        if (currentContact != null)
                        {
                            importedContacts.Add(currentContact);
                        }
                        currentContact = new ContactInfo();
                        currentContact.CallSign = ExtractValueFromADIFLine(line);
                    }
                    else if (line.StartsWith("<QSO_DATE:"))
                    {
                        if (currentContact != null)
                        {
                            currentContact.Time = ExtractValueFromADIFLine(line);
                        }
                    }
                    else if (line.StartsWith("<TIME_ON:"))
                    {
                        if (currentContact != null)
                        {
                            currentContact.Time = ExtractValueFromADIFLine(line);
                        }
                    }
                    else if (line.StartsWith("<RST_RCVD:"))
                    {
                        if (currentContact != null)
                        {
                            currentContact.RSTRcvd = ExtractValueFromADIFLine(line);
                        }
                    }
                    else if (line.StartsWith("<RST_SENT:"))
                    {
                        if (currentContact != null)
                        {
                            currentContact.RSTSent = ExtractValueFromADIFLine(line);
                        }
                    }
                    else if (line.StartsWith("<FREQ:"))
                    {
                        if (currentContact != null)
                        {
                            currentContact.TXFreq = ExtractValueFromADIFLine(line);

                            // string frequency = ExtractValueFromADIFLine(line);
                            // currentContact.Band = DetermineBandFromFrequency(frequency);
                        }
                    }
                    else if (line.StartsWith("<FREQ_RX:"))
                    {
                        if (currentContact != null)
                        {
                            currentContact.RXFreq = ExtractValueFromADIFLine(line);

                            // string frequency = ExtractValueFromADIFLine(line);
                            // currentContact.Band = DetermineBandFromFrequency(frequency);
                        }
                    }
                    else if (line.StartsWith("<MODE:"))
                    {
                        if (currentContact != null)
                        {
                            currentContact.Mode = ExtractValueFromADIFLine(line);
                        }
                    }
                    // Add other fields as needed

                    // EOR indicates the end of a contact record
                    else if (line.StartsWith("<EOR>"))
                    {
                        if (currentContact != null)
                        {
                            importedContacts.Add(currentContact);
                            currentContact = null; // Reset current contact for the next record
                        }
                    }
                }

                MessageBox.Show("Contacts imported successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error importing contacts: " + ex.Message);
                importedContacts.Clear();
            }

            return importedContacts;
        }


        private string ExtractValueFromADIFLine(string line)
        {
            int startIndex = line.IndexOf('>') + 1;
            int length = int.Parse(line.Substring(6, line.IndexOf('>') - 6));
            return line.Substring(startIndex, length);
        }




        private void button5_Click(object sender, EventArgs e)
        {
            ImportADIF_Click();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ExportADIF_Click();
        }

        private void CallsignLabel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Wow, what a cool easteregg :)");
        }

        private void pictureBox3_Click(object sender, EventArgs e) // Help Button
        {
            // No longer in use
        }

        private void SaveContactsToBinary(bool SaveFileDialogShow)
        {
            string filePath = "";
            if (SaveFileDialogShow == true)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "QSOLink Data Files|*.DAT";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string SaveFilePath = saveFileDialog.FileName;
                    filePath = SaveFilePath;
                }
            }
            else
            {
                filePath = "Contacts.dat";
            }

            try
            {
                using (FileStream stream = new FileStream(filePath, System.IO.FileMode.Create))
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    formatter.Serialize(stream, contacts);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "File Save Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SettingsForm = new Settings();
            SettingsForm.ShowDialog();
            RefreshContacts(false);
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Lopastudio/QSOLink-Logbook/wiki");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void saveADIFAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExportADIF_Click();
        }

        private void importADIFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ImportADIF_Click();
        }

        private void aboutQSOLinkLogbookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("QSOLink Version: " + Version, "About");
        }

        private void saveAsDATToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveContactsToBinary(true);
        }

        private void loadToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            RefreshContacts(true);
            SaveContactsToBinary(false);
        }

        private void exportToHTMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "HTML files (*.html)|*.html|All files (*.*)|*.*";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string htmlFilePath = saveFileDialog.FileName;
                ExportToHtml(htmlFilePath);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("OMG, Another easteregg!");
        }

        // Telnet part: 

        private Process telnetProcess;

        private void connectTelnetBackendToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // MessageBox.Show("Runs");
            string exePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Telnet-Interface.exe");

            if (File.Exists(exePath))
            {
                ProcessStartInfo startInfo = new ProcessStartInfo
                {
                    FileName = exePath,
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    RedirectStandardInput = true,
                    CreateNoWindow = true
                };

                telnetProcess = new Process
                {
                    StartInfo = startInfo
                };

                telnetProcess.OutputDataReceived += (s, eventArgs) =>
                {
                    if (!string.IsNullOrEmpty(eventArgs.Data))
                    {
                        // Add the new item at the top of the ListBox
                        Telnet.Invoke((MethodInvoker)delegate
                        {
                            Telnet.Items.Insert(0, eventArgs.Data);
                        });

                        // Scroll to the bottom (top index)
                        Telnet.Invoke((MethodInvoker)delegate
                        {
                            Telnet.TopIndex = 0;
                        });
                    }
                };

                try
                {
                    telnetProcess.Start();
                    telnetProcess.BeginOutputReadLine();

                    timer.Start();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error starting Telnet process: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Telnet-Interface.exe not found in the application directory.");
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            telnetProcess.StandardInput.WriteLine();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {


            if (telnetProcess != null && !telnetProcess.HasExited)
            {
                try
                {
                    telnetProcess.StandardInput.WriteLine(textBox1.Text);
                    textBox1.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error writing to Telnet process: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Telnet process is not running.");
            }
        }

        private void changelogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangelogForm = new Changelog();
            ChangelogForm.ShowDialog();
        }

        // GPS Garbage:


        private static readonly string StrChrUp = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private static readonly string StrChrLo = "abcdefghijklmnopqrstuvwxyz";
        private static readonly string StrNum = "0123456789";

        private string CalculateQthDec(double latitude, double longitude)
        {
            if (location_services_enabled == true)
            {
                latitude += 90; // Shift latitude range from [-90, 90] to [0, 180]
                longitude += 180; // Shift longitude range from [-180, 180] to [0, 360]

                // Calculate Maidenhead Grid Square
                char[] gridSquare = new char[6];
                gridSquare[0] = StrChrUp[(int)(longitude / 20)]; // 1st digit: 20-degree longitude slot
                gridSquare[1] = StrChrUp[(int)(latitude / 10)]; // 2nd digit: 10-degree latitude slot
                gridSquare[2] = StrNum[(int)((longitude % 20) / 2)]; // 3rd digit: 2-degree longitude slot
                gridSquare[3] = StrNum[(int)((latitude % 10) / 1)]; // 4th digit: 1-degree latitude slot
                gridSquare[4] = StrChrLo[(int)((longitude % 10) % 2 * 12)]; // 5th digit: 5-minute longitude slot
                gridSquare[5] = StrChrLo[(int)((latitude % 10) % 2 * 24)]; // 6th digit: 2.5-minute latitude slot

                return new string(gridSquare);
            }
            else
            {
                MessageBox.Show("Couldn't calculate gridsquare: You must enable location services in the settings of QSOLink-Logbook for this functionality to work.");
                return "";
            }
        }



        private void LocationMessage()
        {
            watcher.Start();
            watcher.PositionChanged += (sender, e) =>
            {
                var coordinate = e.Position.Location;
                // Output latitude and longitude
                //MessageBox.Show("Latitude: " + coordinate.Latitude + "  ;  Longitude: " + coordinate.Longitude);

                string gridSquare = CalculateQthDec(coordinate.Latitude, coordinate.Longitude);
                locator_text.Text = gridSquare;
                watcher.Stop();
            };
        }


        /*
        // Check if the device is ready
        if (watcher.Status == GeoPositionStatus.Ready)
        {
            // Start retrieving location information
            watcher.Start();

            // Wait for the position to be obtained
            watcher.PositionChanged += (sender, e) =>
            {
                var coordinate = e.Position.Location;

                // Output latitude and longitude
                MessageBox.Show("Latitude: " + coordinate.Latitude + "  ;  Longitude: " + coordinate.Longitude);

                // Stop the watcher
                watcher.Stop();
            };

            MessageBox.Show("Getting location...");
        }
        else
        {
            MessageBox.Show("Location service is not available.");
        }*/

        private void getGpsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            LocationMessage();
        }
    }

    public class Values
    {
        public int rowIndex { get; set; }
    }

    [Serializable]
    public class ContactInfo
    {
        public int indexNumber { get; set; }
        public string CallSign { get; set; }
        public string Country { get; set; }
        public string Mode { get; set; }
        public string RSTSent { get; set; }
        public string RSTRcvd { get; set; }
        public string TXFreq { get; set; }
        public string RXFreq { get; set; }
        public string Time { get; set; }
        public string Power { get; set; }
        public string Locator { get; set; }
        public string CustomComments { get; set; }
    }
}