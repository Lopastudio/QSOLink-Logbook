using QSOLink_Logbook.Properties;
using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Windows.Forms;

namespace QSOLink_Logbook
{
    public partial class QSOLinkLogBookWindow : Form
    {
        public string Version = "Alpha2.2";

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


        private void Form1_Load(object sender, EventArgs e)
        {
            RefreshContacts();
            LoadSettings();
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
                using (FileStream stream = new FileStream(filePath, FileMode.Open))
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

        private void button2_Click(object sender, EventArgs e) // Export button
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "HTML files (*.html)|*.html|All files (*.*)|*.*";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string htmlFilePath = saveFileDialog.FileName;
                ExportToHtml(htmlFilePath);
            }
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