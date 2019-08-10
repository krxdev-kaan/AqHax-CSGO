using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;
using System.Net;
using System.Windows.Forms;
using Newtonsoft.Json;
using static AqHaxCSGO.Offsets;

namespace AqHaxCSGO.MemoryManagers
{
    static class OffsetManager
    {
        /**
         * Loads Offsets from a save file if you have a file like that
         */
        public static void LoadOffsets()
        {
            try
            {
                string[] contentsOfFile = File.ReadAllLines("Offsets.data"); //Read the offset save file
                foreach (string line in contentsOfFile)
                {
                    string[] props = line.Split(' '); //Split with ' ' since file is formatted like this: "offset_name offset_int32"
                    try
                    {
                        typeof(Offsets).GetField(props[0], BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.SetField | BindingFlags.Instance | BindingFlags.Public | BindingFlags.SetProperty).SetValue(null, Convert.ToInt32(props[1])); //Get the variable field with offsets name and set it's value
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show("Field Of Offset Missing: " + props[0]); //If we got an error this means we found a offset name which doesn't confront any of the variables name
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("IO Error. Restarting the Program is recommended.");
            }
        }

        /**
         * Downloads the offsets from frk1/hazedumper repo and makes a save file out of it
         */
        public static void DownloadOffsets()
        {
            try
            {
                StreamWriter sw = new StreamWriter(File.OpenWrite("Offsets.data")); //Prepare to update the save file
                TextWriter tw = sw;
                string offsetJSON = (new WebClient()).DownloadString("https://raw.githubusercontent.com/frk1/hazedumper/master/csgo.json"); //Download the JSON containing updated offsets (Thanks to frk1/hazedumper :))
                FieldInfo currentField = null;
                JsonTextReader reader = new JsonTextReader(new StringReader(offsetJSON)); //Init JSON Reader
                while (reader.Read()) //Starting reading and loop through
                {
                    if (reader.Value != null)
                    {
                        if (reader.TokenType == JsonToken.PropertyName) //If the type is PropertyName this means we found a offset name so let's set currentField to appropriate variable field
                        {
                            try
                            {
                                currentField = typeof(Offsets).GetField(reader.Value.ToString(), BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.SetField | BindingFlags.Instance | BindingFlags.Public | BindingFlags.SetProperty);
                                if (reader.Value.ToString() != "signatures" && reader.Value.ToString() != "netvars") tw.Write(reader.Value.ToString() + " ");
                                Console.WriteLine("Prop: " + reader.Value.ToString());
                            }
                            catch
                            {
                                MessageBox.Show("Unknown Field Of Offset: {0}", reader.Value.ToString());
                            }
                        }
                        else if (reader.TokenType == JsonToken.Integer) //If we found an integer it's the value of the variable which we previously set the currentField to be
                        {
                            if (currentField != null)
                            {
                                try
                                {
                                    currentField.SetValue(null, Convert.ToInt32(reader.Value.ToString()));
                                    tw.WriteLine(reader.Value.ToString());
                                    Console.WriteLine("Val: " + reader.Value);
                                }
                                catch
                                {
                                    MessageBox.Show("Could Not Access The Field: {0}", reader.Value.ToString());
                                }
                            }
                            else
                            {
                                MessageBox.Show("Field Of Offset Is Null: {0}", reader.Value.ToString());
                                tw.WriteLine();
                            }
                        }
                    }
                }

                tw.Close();
                sw.Close();
            }
            catch
            {
                MessageBox.Show("FATAL ERROR");
            }
        }

        /**
         * Scans the offsets by using SigScanner
         */
        public static void ScanOffsets()
        {
            //Implement when a list of needed offsets made
        }
    }
}
