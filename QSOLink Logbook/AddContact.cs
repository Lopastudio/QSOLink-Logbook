using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace QSOLink_Logbook
{
    public partial class AddContact : Form
    {
        private List<ContactInfo> contacts;

        public AddContact()
        {
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
                IsDX = IsDX.Checked,
                CustomComments = richTextBox1.Text
            };

            contacts.Add(contact);

            SaveContactsToBinary();

            MessageBox.Show("Contact saved successfully!");

            Close();
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
    }
}
