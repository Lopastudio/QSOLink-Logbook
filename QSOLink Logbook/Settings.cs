using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Windows.Forms;

namespace QSOLink_Logbook
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
            LoadSettings();
        }

        private void LoadSettings()
        {
            try
            {
                if (File.Exists("settings.bin"))
                {
                    using (FileStream fs = new FileStream("settings.bin", FileMode.Open))
                    {
                        BinaryFormatter formatter = new BinaryFormatter();
                        AppSettings loadedSettings = (AppSettings)formatter.Deserialize(fs);

                        Callsign.Text = loadedSettings.Callsign;
                        DisplayCallSign.Checked = loadedSettings.DisplayCallSign;
                        // AlphaWarn.Checked = loadedSettings.AlphaWarn;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading settings: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    Rig = Rig.Text,
                };

                using (FileStream fs = new FileStream("settings.bin", FileMode.Create))
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    formatter.Serialize(fs, settings);
                }

                MessageBox.Show("Settings applied successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error applying settings: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
