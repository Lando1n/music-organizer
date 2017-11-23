using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Music_Organizer
{
    public class Cleanup
    {
        public static string[] extensions = { "*.jpg","*.png", "*.db", "*.ini", "*.nfo", "*.sfv",  "*.dat", "*.reapeaks" };

        public static void removeEmptyDirect(string startLocation)
        {
            foreach (var directory in Directory.GetDirectories(startLocation))
            {
                removeEmptyDirect(directory);
                
                if (Directory.GetFiles(directory).Length == 0 && Directory.GetDirectories(directory).Length == 0)
                {
                    Directory.Delete(directory, false);
                }
            }
        }
        public static void removeNonAudioFiles(string startLocation)
        {
            foreach (string ext in extensions)
            {
                foreach (string file in Directory.GetFiles(startLocation, ext, SearchOption.AllDirectories))
                {
                    try
                    {
                        if (File.Exists(file))
                        {
                            File.Delete(file);
                        }
                    }
                    catch
                    {
                        using (StreamWriter log = new StreamWriter(startLocation + @"rw error log.txt", true))
                        {
                            log.WriteLine("Check read/write permissions on: " + file + "\n");
                        }
                    }
                }
            }
        }
    }
}
