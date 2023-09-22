using System;

namespace QSOLink_Logbook
{
    [Serializable]
    public class AppSettings
    {
        public string Callsign { get; set; }
        public string Rig { get; set; }
        public bool DisplayCallSign { get; set; }
        public bool updateAlert { get; set; }



        // public bool AlphaWarn { get; set; }
    }
}
