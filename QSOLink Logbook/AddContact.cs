using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QSOLink_Logbook
{
    public partial class AddContact : Form
    {
        private List<ContactInfo> contacts;

        public AddContact()
        {
            InitializeComponent();
        }

        public AddContact(List<ContactInfo> contacts)
        {
            InitializeComponent();
            this.contacts = contacts;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int newIndex = contacts.Count + 1; // Get the new index directly

            ContactInfo contact = new ContactInfo
            {
                indexNumber = newIndex,
                CallSign = CallSign_Textfield.Text,
                Country = Country_Textfield.Text,
                Mode = Mode_ComboBox.SelectedItem?.ToString(),
                RSTSent = RSTSent.Text.ToString(),
                RSTRcvd = RSTRcvd.Text.ToString(),
                TXFreq = TXFreq.Text.ToString(),
                RXFreq = RXFreq.Text.ToString(),
                Time = dateTimePicker1.Value.ToString(),
                Power = PowerTextbox.Text.ToString(),
                IsDX = IsDX.Checked,
                CustomComments = richTextBox1.Text
            };

            contacts.Add(contact);

            SaveContactsToBinary();

            MessageBox.Show("Contact saved successfully!");

            Close();
        }

        private async Task<string> FetchCountryFromQRZ(string callSign)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    var formContent = new FormUrlEncodedContent(new[]
                    {
                        new KeyValuePair<string, string>("callsign", callSign)
                    });

                    HttpResponseMessage response = await client.PostAsync("https://www.qrz.com/lookup", formContent);

                    if (response.IsSuccessStatusCode)
                    {
                        string htmlContent = await response.Content.ReadAsStringAsync();

                        // Extract the country information from the HTML content
                        string country = ExtractCountryFromHtml(htmlContent);

                        return country;
                    }
                    else
                    {
                        return "Error fetching country";
                    }
                }
            }
            catch (Exception ex)
            {
                return "Error: " + ex.Message;
            }
        }

        private string ExtractCountryFromHtml(string htmlContent)  // Pls dont sue me, I do not have any money for an api to use in a hobby project. Thanks :)
        {
            // First pattern
            string pattern1 = @"<b style=""color:red"">[^<]+<\/b>\s*looks like a callsign from\s*<b style=""color:green"">([^<]+)<\/b>";
            Match match1 = Regex.Match(htmlContent, pattern1);

            // Second pattern
            string pattern2 = @"<span class=""ptr""[^>]*>(?:<img[^>]+>\s*)?<span[^>]*>([^<]+)<\/span>";
            Match match2 = Regex.Match(htmlContent, pattern2);

            if (match1.Success)
            {
                return match1.Groups[1].Value.Trim();
            }
            else if (match2.Success)
            {
                return match2.Groups[1].Value.Trim();
            }
            else
            {
                return "Country not found";
            }
        }

        private void SaveContactsToBinary()
        {
            string filePath = "Contacts.dat";

            using (FileStream stream = new FileStream(filePath, FileMode.Create))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(stream, contacts);
            }
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            string callSign = CallSign_Textfield.Text;
            string country = await FetchCountryFromQRZ(callSign);
            Country_Textfield.Text = country;
        }

        private void AddContact_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e) // Help button
        {
            System.Diagnostics.Process.Start("https://github.com/Lopastudio/QSOLink-Logbook/wiki");
        }
    }
}
