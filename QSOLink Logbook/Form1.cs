using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace QSOLink_Logbook
{
    public partial class Form1 : Form
    {
        private AddContact AddContactForm = new AddContact();
        private List<ContactInfo> contacts = new List<ContactInfo>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RefreshContacts();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddContactForm = new AddContact(contacts);
            AddContactForm.Show();
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
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            RefreshContacts();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

    [Serializable]
    public class ContactInfo
    {
        public string CallSign { get; set; }
        public string Country { get; set; }
        public string Mode { get; set; }
        public string Time { get; set; }
        public bool IsDX { get; set; }
        public string CustomComments { get; set; }
    }
}
