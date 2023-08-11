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
using YamlDotNet.Serialization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;


namespace QSOLink_Logbook
{
    public partial class AddContact : Form
    {
        private List<ContactInfo> contacts = new List<ContactInfo>();
        public AddContact()
        {
            InitializeComponent();
        }

        private void AddContact_Load(object sender, EventArgs e) // Loading Form
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e) // IS DX checkbox
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e) // Date of the contact
        {

        }

        private void label5_Click(object sender, EventArgs e) // Custom Comments label
        {
            MessageBox.Show("What a cool place to put an easteregg in :)");
        }

        private void label1_Click(object sender, EventArgs e) //Add Your Contact label
        {
            // nothing :((
        }

        private void CallSign_Textfield_TextChanged(object sender, EventArgs e) // Callsign TextField
        {

        }

        private void Country_Textfield_TextChanged(object sender, EventArgs e) // Country TextField
        {

        }

        private void Mode_ComboBox_SelectedIndexChanged(object sender, EventArgs e) // Contact Mode ComboBox
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e) // Custom Comments field
        {

        }

        private void button1_Click(object sender, EventArgs e) // Add contact button
        {
            ContactInfo contact = new ContactInfo
            {
                CallSign = CallSign_Textfield.Text,
                Country = Country_Textfield.Text,
                Mode = Mode_ComboBox.SelectedItem.ToString(),
                Time = dateTimePicker1.Value.ToString(),
                IsDX = IsDX.Checked,
                CustomComments = richTextBox1.Text
            };

            contacts.Add(contact); // Add the new contact to the list

            SaveContactsToYaml();

            // Optionally, you can display a message to indicate that the contact has been saved.
            MessageBox.Show("Contact saved successfully!");
        }

        private void SaveContactsToYaml()
        {
            var serializer = new SerializerBuilder().Build();
            var yaml = serializer.Serialize(contacts);

            // You can modify the path as needed to save the YAML file to a specific location.
            string filePath = "contacts.yaml";

            File.WriteAllText(filePath, yaml);
        }
    }
}
