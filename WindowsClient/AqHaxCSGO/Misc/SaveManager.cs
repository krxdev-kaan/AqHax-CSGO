using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Resolvers;
using System.Xml.Serialization;
using System.Xml.Linq;

namespace AqHaxCSGO
{
    public static class SaveManager
    {
        public class SettingsScheme
        {
            public int IdlePowerConsumption { get; set; }
            public int UsagePowerConsumption { get; set; }
            public int BunnyAccuracy { get; set; }
            public int TriggerKey { get; set; }
        }

        public static void SaveSettings(SettingsScheme settingsScheme)
        {
            string appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            string programDataPath = Path.Combine(appDataPath, "AqHaxCSGO");
            string fullSavePath = Path.Combine(programDataPath, "settings.xml");

            var doc = new XDocument();
            using (var writer = doc.CreateWriter())
            {
                var serializer = new XmlSerializer(typeof(SettingsScheme));

                serializer.Serialize(writer, settingsScheme);
            }

            doc.Save(fullSavePath);
        }

        public static SettingsScheme LoadSettings()
        {
            string appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            string programDataPath = Path.Combine(appDataPath, "AqHaxCSGO");
            string fullSavePath = Path.Combine(programDataPath, "settings.xml");

            if (File.Exists(fullSavePath))
            {
                var serializer = new XmlSerializer(typeof(SettingsScheme));
                using (var fs = new FileStream(fullSavePath, FileMode.Open))
                {
                    SettingsScheme settings = (SettingsScheme)serializer.Deserialize(fs);
                    return settings;
                }
            }
            else 
            {
                SettingsScheme settings = new SettingsScheme();
                settings.BunnyAccuracy = 1;
                settings.IdlePowerConsumption = 10;
                settings.UsagePowerConsumption = 1;
                settings.TriggerKey = 16;

                SaveManager.SaveSettings(settings);
                return settings;
            }
        }
    }
}
