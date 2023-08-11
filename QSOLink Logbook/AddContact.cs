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
            ContactInfo contact = new ContactInfo
            {
                CallSign = CallSign_Textfield.Text,
                Country = Country_Textfield.Text,
                Mode = Mode_ComboBox.SelectedItem?.ToString(),
                Time = dateTimePicker1.Value.ToString(),
                IsDX = IsDX.Checked,
                CustomComments = richTextBox1.Text
            };

            contacts.Add(contact);

            SaveContactsToBinary();

            MessageBox.Show("Contact saved successfully!");
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
