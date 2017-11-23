using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music_Organizer
{
    public class Runner
    {
        public string rootFolder, destFolder;
        public bool removeFeat, removeNonAudio;
        public string[] audioFileTypes = { "*.mp3", "*.wav", "*.wma", "*.m4a" };
        public string errorLogLoc;
        public int songsMoved = 0;
    }
}
