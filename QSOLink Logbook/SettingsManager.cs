using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace QSOLink_Logbook
{
    public static class SettingsManager
    {
        private const string SettingsFilePath = "settings.bin";

        public static AppSettings LoadSettings()
        {
            try
            {
                if (File.Exists(SettingsFilePath))
                {
                    using (FileStream fs = new FileStream(SettingsFilePath, FileMode.Open))
                    {
                        BinaryFormatter formatter = new BinaryFormatter();
                        return (AppSettings)formatter.Deserialize(fs);
                    }
                }
                else
                {
                    return new AppSettings();
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions here
                MessageBox.Show("Error occurred: " + ex + ". Please report this issue on our Github page by creating a screenshot and sending it into the issue, so this error can be resolved. https://s.lopastudio.sk/issue");
                return new AppSettings(); // Return default settings in case of error
            }
        }

        public static void SaveSettings(AppSettings settings)
        {
            try
            {
                using (FileStream fs = new FileStream(SettingsFilePath, FileMode.Create))
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    formatter.Serialize(fs, settings);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred: " + ex + ". Please report this issue on our Github page by creating a screenshot and sending it into the issue, so this error can be resolved. https://s.lopastudio.sk/issue");
            }
        }
    }
}
