using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YamlDotNet.Core.Tokens;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QSOLink_Logbook
{
    public partial class EditContact : Form
    {
        private int indexValue;

        private List<ContactInfo> contacts;
        string filePath = "Contacts.dat";
        public EditContact(int selectedindexValue)
        {
            InitializeComponent();
            indexValue = selectedindexValue;
            RefreshContacts();
            setValues();
        }
        private void RefreshContacts()
        {

            if (File.Exists(filePath))
            {
                using (FileStream stream = new FileStream(filePath, FileMode.Open))
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    contacts = (List<ContactInfo>)formatter.Deserialize(stream);
                }
            }
        }
        private void setValues()
        {
            if (File.Exists(filePath))
            {
                ContactInfo contactToDisplay = contacts.FirstOrDefault(contact => contact.indexNumber == indexValue);

                if (contactToDisplay != null)
                {
                    if (DateTime.TryParse(contactToDisplay.Time, out DateTime parsedDate))
                    {
                        dateTimePicker1.Value = parsedDate;
                    }

                    CallSign_Textfield.Text = contactToDisplay.CallSign;
                    Country_Textfield.Text = contactToDisplay.Country;
                    Mode_ComboBox.Text = contactToDisplay.Mode;
                    IsDX.Checked = contactToDisplay.IsDX;
                    richTextBox1.Text = contactToDisplay.CustomComments;
                    label2.Text = "Editing Contact: " + contactToDisplay.CallSign.ToString();
                }
                else
                {
                    MessageBox.Show("Contact with the specified ID was not found.");
                }
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

        private void CallSign_Textfield_TextChanged(object sender, EventArgs e)
        {
            //nothing
        }

        private void RemoveContact(int indexValue)
        {
            ContactInfo contactToRemove = contacts.FirstOrDefault(contact => contact.indexNumber == indexValue);

            if (contactToRemove != null)
            {
                contacts.Remove(contactToRemove);
                RenumberContacts();
                SaveContactsToBinary();
                MessageBox.Show("Contact removed successfully!");
            }
            else
            {
                MessageBox.Show("Contact with the specified ID was not found.");
            }
        }

        private void RenumberContacts()
        {
            for (int i = 0; i < contacts.Count; i++)
            {
                contacts[i].indexNumber = i + 1;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ContactInfo updatedContact = new ContactInfo
            {
                CallSign = CallSign_Textfield.Text,
                Country = Country_Textfield.Text,
                Mode = Mode_ComboBox.SelectedItem?.ToString(),
                Time = dateTimePicker1.Value.ToString(),
                IsDX = IsDX.Checked,
                CustomComments = richTextBox1.Text
            };

            ContactInfo contactToUpdate = contacts.FirstOrDefault(contact => contact.indexNumber == indexValue);

            if (contactToUpdate != null)
            {
                // Update contact's properties
                contactToUpdate.CallSign = updatedContact.CallSign;
                contactToUpdate.Country = updatedContact.Country;
                contactToUpdate.Mode = updatedContact.Mode;
                contactToUpdate.Time = updatedContact.Time;
                contactToUpdate.IsDX = updatedContact.IsDX;
                contactToUpdate.CustomComments = updatedContact.CustomComments;

                SaveContactsToBinary();

                MessageBox.Show("Contact updated successfully!");
            }
            else
            {
                MessageBox.Show("Contact with the specified ID was not found.");
            }
        }




        private void label2_Click(object sender, EventArgs e)
        {
           // MessageBox.Show(indexValue.ToString());
        }
        private void RemoveCurrentContact_Click(object sender, EventArgs e)
        {
            RemoveContact(indexValue);
            Close();
        }

    }
}
