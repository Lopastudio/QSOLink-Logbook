using QSOLink_Logbook.Properties;
using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Windows.Forms;

using Octokit;
using System.Linq;
using System.Threading.Tasks;

namespace QSOLink_Logbook
{
    public partial class QSOLinkLogBookWindow : Form
    {
        public string Version = "v3.1-Alpha";

        private AddContact AddContactForm = new AddContact();
        private Settings SettingsForm = new Settings();
        private List<ContactInfo> contacts = new List<ContactInfo>();

        public QSOLinkLogBookWindow()
        {
            InitializeComponent();
            label1.Text = Version;
            RefreshContacts();
            LoadSettings();
        }

        

        private void LoadSettings()
        {
            AppSettings settings = SettingsManager.LoadSettings();
            // All the settings that need to be applied go here
            CallsignLabel.Text = settings.Callsign;
            CallsignLabel.Visible = settings.DisplayCallSign;

            /*
            if (!settings.AlphaWarn)
            {
                MessageBox.Show("This is an Alpha release. If you have any problems, please open an issue on my GitHub (https://s.lopastudio.sk/issue)");
            }
            */
        }


        private async void Form1_Load(object sender, EventArgs e)
        {
            RefreshContacts();
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
            var latestRelease = releases.FirstOrDefault(); // Assumes releases are sorted in descending order (latest first).

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
            var currentVersion = "v3.0-Alpha";
            return string.Equals(currentVersion, latestVersion, StringComparison.OrdinalIgnoreCase);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddContactForm = new AddContact(contacts);
            AddContactForm.ShowDialog();
            RefreshContacts();
        }

        private void RefreshContacts()
        {
            string filePath = "Contacts.dat";

            if (File.Exists(filePath))
            {
                using (FileStream stream = new FileStream(filePath, System.IO.FileMode.Open))
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    contacts = (List<ContactInfo>)formatter.Deserialize(stream);
                }
            }

            dataGridView1.DataSource = contacts;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                DataGridViewCell cell = row.Cells["IsDX"];
                if (cell != null)
                {
                    cell.ReadOnly = true;
                }
            }

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
                    // Include Bootstrap CSS link
                    writer.WriteLine("<link rel='stylesheet' href='https://stackpath.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css'>");
                    writer.WriteLine("</head>");
                    writer.WriteLine("<body>");
                    writer.WriteLine("<div class='container'>");
                    writer.WriteLine("<h1 class='mt-4'>Contact logbook of: " + settings.Callsign + "</h1>");
                    writer.WriteLine("<table class='table table-bordered mt-4'>");

                    // Export headers
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
                            // Exclude "indexNumber" column
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

                    // Include Bootstrap JS and jQuery scripts
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
            RefreshContacts(); // Refresh the data after the EditContact form closes
        }

        private void EditButton_TEMP_Click(object sender, EventArgs e)
        {
            RefreshContacts();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            SettingsForm = new Settings();
            SettingsForm.ShowDialog();
            RefreshContacts();
        }


        WebBrowser myWebBrowser = new WebBrowser();
        private void button3_Click(object sender, EventArgs e) // Print button
        {
            string tempHtmlFilePath = Path.Combine(Path.GetTempPath(), "tempPrint.html");
            ExportToHtml(tempHtmlFilePath);

            myWebBrowser.DocumentCompleted += myWebBrowser_DocumentCompleted;
            myWebBrowser.DocumentText = System.IO.File.ReadAllText(tempHtmlFilePath);
        }
        private void myWebBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            myWebBrowser.Print();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "HTML files (*.html)|*.html|All files (*.*)|*.*";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string htmlFilePath = saveFileDialog.FileName;
                ExportToHtml(htmlFilePath);
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
                    RefreshContacts();
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

            foreach (var contact in contacts)
            {
                adifContent.AppendLine($"<CALL:{contact.CallSign.Length}>{contact.CallSign}");
                adifContent.AppendLine($"<COUNTRY:{contact.Country.Length}>{contact.Country}");
                adifContent.AppendLine($"<MODE:{contact.Mode.Length}>{contact.Mode}");
                adifContent.AppendLine($"<RST_SENT:{contact.RSTSent.Length}>{contact.RSTSent}");
                adifContent.AppendLine($"<RST_RCVD:{contact.RSTRcvd.Length}>{contact.RSTRcvd}");
                adifContent.AppendLine($"<TX_FREQ:{contact.TXFreq.Length}>{contact.TXFreq}");
                adifContent.AppendLine($"<RX_FREQ:{contact.RXFreq.Length}>{contact.RXFreq}");
                adifContent.AppendLine($"<TIME_ON:{contact.Time.Length}>{contact.Time}");
                adifContent.AppendLine($"<DXCC:{(contact.IsDX ? "1" : "0")}>");
                adifContent.AppendLine($"<COMMENT:{contact.CustomComments.Length}>{contact.CustomComments}");
                adifContent.AppendLine("<EOR>"); // End of record marker
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
                    else if (line.StartsWith("<COUNTRY:"))
                    {
                        if (currentContact != null)
                        {
                            currentContact.Country = ExtractValueFromADIFLine(line);
                        }
                    }
                    else if (line.StartsWith("<MODE:"))
                    {
                        if (currentContact != null)
                        {
                            currentContact.Mode = ExtractValueFromADIFLine(line);
                        }
                    }
                    else if (line.StartsWith("<RST_SENT:"))
                    {
                        if (currentContact != null)
                        {
                            currentContact.RSTSent = ExtractValueFromADIFLine(line);
                        }
                    }
                    else if (line.StartsWith("<RST_RCVD:"))
                    {
                        if (currentContact != null)
                        {
                            currentContact.RSTRcvd = ExtractValueFromADIFLine(line);
                        }
                    }
                    else if (line.StartsWith("<TX_FREQ:"))
                    {
                        if (currentContact != null)
                        {
                            currentContact.TXFreq = ExtractValueFromADIFLine(line);
                        }
                    }
                    else if (line.StartsWith("<RX_FREQ:"))
                    {
                        if (currentContact != null)
                        {
                            currentContact.RXFreq = ExtractValueFromADIFLine(line);
                        }
                    }
                    else if (line.StartsWith("<TIME_ON:"))
                    {
                        if (currentContact != null)
                        {
                            currentContact.Time = ExtractValueFromADIFLine(line);
                        }
                    }
                    else if (line.StartsWith("<DXCC:"))
                    {
                        if (currentContact != null)
                        {
                            currentContact.IsDX = ExtractValueFromADIFLine(line).Equals("1", StringComparison.OrdinalIgnoreCase);
                        }
                    }
                    else if (line.StartsWith("<COMMENT:"))
                    {
                        if (currentContact != null)
                        {
                            currentContact.CustomComments = ExtractValueFromADIFLine(line);
                        }
                    }
                }

                if (currentContact != null)
                {
                    importedContacts.Add(currentContact);
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
            if (startIndex < line.Length)
            {
                return line.Substring(startIndex).Trim();
            }
            return string.Empty;
        }


        private void button5_Click(object sender, EventArgs e)
        {
            ImportADIF_Click();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ExportADIF_Click();
        }

        private void label1_Click(object sender, EventArgs e)
        {

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
        public bool IsDX { get; set; }
        public string CustomComments { get; set; }
    }
}