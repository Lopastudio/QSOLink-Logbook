﻿using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace QSOLink_Logbook
{
    public partial class Settings : Form
    {
        private Dev DevForm = new Dev();

        public Settings()
        {
            InitializeComponent();
            LoadSettings();

        }

        private void LoadSettings()
        {

            // Telnet
            string host = "";
            string port = "";
            string callsign = "";

            try
            {
                // Specify the path to your text file
                string filePath = "config.txt";

                // Read all lines from the file
                string[] lines = File.ReadAllLines(filePath);

                // Check if we have at least 3 lines
                if (lines.Length < 3)
                {
                    Console.WriteLine("File does not contain enough lines.");
                    return;
                }

                // Extract the values from the lines
                host = lines[0].Trim();
                port = lines[1].Trim();
                callsign = lines[2].Trim();

                // Now you can use these values as needed
                textBox1.Text = (host);
                textBox2.Text = (port);
                textBox3.Text = (callsign);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while reading config file: {ex.Message}");
                return;
            }


            try
            {
                //Macro Button 1
                string[] labels1 = { "Refresh", "Add Contact", "Help", "Save as", "Load", "Export to ADIF", "Import ADIF" };
                string label1 = labels1[Properties.Settings.Default.MacroButton1];
                comboBox1.Text = label1;

                //Macro Button 2
                string[] labels2 = { "Refresh", "Add Contact", "Help", "Save as", "Load", "Export to ADIF", "Import ADIF" };
                string label2 = labels2[Properties.Settings.Default.MacroButton2];
                comboBox2.Text = label2;

                //Macro Button 3
                string[] labels3 = { "Refresh", "Add Contact", "Help", "Save as", "Load", "Export to ADIF", "Import ADIF" };
                string label3 = labels3[Properties.Settings.Default.MacroButton3];
                comboBox3.Text = label3;

                //Macro Button 4
                string[] labels4 = { "Refresh", "Add Contact", "Help", "Save as", "Load", "Export to ADIF", "Import ADIF" };
                string label4 = labels4[Properties.Settings.Default.MacroButton4];
                comboBox4.Text = label4;

                if (File.Exists("settings.bin"))
                {
                    using (FileStream fs = new FileStream("settings.bin", FileMode.Open))
                    {
                        BinaryFormatter formatter = new BinaryFormatter();
                        AppSettings loadedSettings = (AppSettings)formatter.Deserialize(fs);

                        Callsign.Text = loadedSettings.Callsign;
                        DisplayCallSign.Checked = loadedSettings.DisplayCallSign;
                        updateAlert.Checked = loadedSettings.updateAlert;
                        Rig.Text = loadedSettings.Rig;
                        locserv.Checked = loadedSettings.locserv;
                        // AlphaWarn.Checked = loadedSettings.AlphaWarn;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading settings: {ex.Message}", "Settings.cs LoadSettings() error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // MessageBox.Show(Properties.Settings.Default.MacroButton4.ToString());
            }
        }

        private void ApplyButton_Click(object sender, EventArgs e)
        {
            try
            {
                AppSettings settings = new AppSettings
                {
                    Callsign = Callsign.Text,
                    DisplayCallSign = DisplayCallSign.Checked,
                    updateAlert = updateAlert.Checked,
                    Rig = Rig.Text,
                    locserv = locserv.Checked
                };

                using (FileStream fs = new FileStream("settings.bin", FileMode.Create))
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    formatter.Serialize(fs, settings);
                }

                // VisualStudio settings manager (used for macro buttons)
                Properties.Settings.Default.Save();

                MessageBox.Show("Settings applied successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error applying settings: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }




            try
            {
                // Specify the path to your text file
                string filePath = "config.txt";

                // Open the file for writing (creating if it doesn't exist, and overwriting if it does)
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    // Write the host, port, and callsign to the file
                    writer.WriteLine(textBox1.Text); // Assuming textBox1, textBox2, textBox3 are your UI elements
                    writer.WriteLine(textBox2.Text);
                    writer.WriteLine(textBox3.Text);
                }

                Console.WriteLine("Config file written successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while writing config file: {ex.Message}");
            }


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.MacroButton1 = comboBox1.SelectedIndex;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.MacroButton2 = comboBox2.SelectedIndex;
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.MacroButton3 = comboBox3.SelectedIndex;
        }
        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.MacroButton4 = comboBox4.SelectedIndex;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void openDevWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DevForm = new Dev();
            DevForm.ShowDialog();
        }




    }
}
