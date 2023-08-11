using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using YamlDotNet.Serialization;
using System.Data.Common;

namespace QSOLink_Logbook
{
    public partial class Form1 : Form
    {
        AddContact AddContactForm = new AddContact();
        private List<ContactInfo> contacts = new List<ContactInfo>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RefreshContacts();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddContactForm.Show();
        }

        private void RefreshContacts()
        {
            // Load contacts from YAML file
            string filePath = "contacts.yaml";
            if (File.Exists(filePath))
            {
                var deserializer = new DeserializerBuilder().Build();
                string yamlContent = File.ReadAllText(filePath);
                contacts = deserializer.Deserialize<List<ContactInfo>>(yamlContent);
            }

            // Bind the contacts list to the DataGridView
            dataGridView1.DataSource = contacts;

            // Set the IsDX column cells as read-only
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                DataGridViewCell cell = row.Cells["IsDX"]; // Replace "IsDX" with the actual column name
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
