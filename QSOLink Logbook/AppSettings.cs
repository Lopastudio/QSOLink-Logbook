using System;

namespace QSOLink_Logbook
{
    [Serializable]
    public class AppSettings
    {
        public string Callsign { get; set; }
        public bool DisplayCallSign { get; set; }
    }
}
