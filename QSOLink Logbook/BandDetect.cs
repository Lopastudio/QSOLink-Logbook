namespace QSOLink_Logbook
{
    internal class BandDetect
    {
        private string BandPlz(string frequency)
        {
            double freqValue = double.Parse(frequency);

            // EU Band Plan (kHz)
            if (freqValue >= 135.7 && freqValue <= 137.8)
            {
                return "2200M";
            }
            else if (freqValue >= 472 && freqValue <= 479)
            {
                return "630M";
            }
            else if (freqValue >= 1810 && freqValue <= 1850)
            {
                return "160M";
            }
            else if (freqValue >= 3500 && freqValue <= 3800)
            {
                return "80M";
            }
            else if (freqValue >= 5351.5 && freqValue <= 5366.5)
            {
                return "60M";
            }
            else if (freqValue >= 7000 && freqValue <= 7200)
            {
                return "40M";
            }
            else if (freqValue >= 10100 && freqValue <= 10150)
            {
                return "30M";
            }
            else if (freqValue >= 14000 && freqValue <= 14350)
            {
                return "20M";
            }
            else if (freqValue >= 18068 && freqValue <= 18168)
            {
                return "17M";
            }
            else if (freqValue >= 21000 && freqValue <= 21450)
            {
                return "15M";
            }
            else if (freqValue >= 24890 && freqValue <= 24990)
            {
                return "12M";
            }
            else if (freqValue >= 28000 && freqValue <= 29700)
            {
                return "10M";
            }
            else if (freqValue >= 50060 && freqValue <= 50400)
            {
                return "6M";
            }
            else if (freqValue >= 70000 && freqValue <= 70500)
            {
                return "4M";
            }
            else if (freqValue >= 144000 && freqValue <= 146000)
            {
                return "2M";
            }
            else if (freqValue >= 430000 && freqValue <= 440000)
            {
                return "70CM";
            }
            else if (freqValue >= 1240000 && freqValue <= 1300000)
            {
                return "23CM";
            }
            else if (freqValue >= 2300000 && freqValue <= 2450000)
            {
                return "13CM";
            }
            else if (freqValue >= 5650000 && freqValue <= 5850000)
            {
                return "6CM";
            }
            else if (freqValue >= 10000000 && freqValue <= 10500000)
            {
                return "3CM";
            }
            else if (freqValue >= 24000000 && freqValue <= 24250000)
            {
                return "1.25CM";
            }
            else if (freqValue >= 47000000 && freqValue <= 47200000)
            {
                return "70CM";
            }
            else if (freqValue >= 75500000 && freqValue <= 81000000)
            {
                return "4MM";
            }
            else if (freqValue >= 122250000 && freqValue <= 123000000)
            {
                return "2.4MM";
            }
            else if (freqValue >= 134000000 && freqValue <= 141000000)
            {
                return "2MM";
            }
            else if (freqValue >= 241000000 && freqValue <= 250000000)
            {
                return "1.2MM";
            }
            else if (freqValue >= 470000000 && freqValue <= 472000000)
            {
                return "70CM";
            }
            else if (freqValue >= 755000000 && freqValue <= 810000000)
            {
                return "4MM";
            }
            else if (freqValue >= 1222500000 && freqValue <= 1230000000)
            {
                return "2.4MM";
            }
            else if (freqValue >= 1340000000 && freqValue <= 1410000000)
            {
                return "2MM";
            }
            else if (freqValue >= 2410000000 && freqValue <= 2500000000)
            {
                return "1.2MM";
            }
            else if (freqValue >= 5650000000 && freqValue <= 5850000000)
            {
                return "6CM";
            }
            else if (freqValue >= 10000000000 && freqValue <= 10500000000)
            {
                return "3CM";
            }
            else if (freqValue >= 24000000000 && freqValue <= 24250000000)
            {
                return "1.25CM";
            }
            else if (freqValue >= 47000000000 && freqValue <= 47200000000)
            {
                return "70CM";
            }
            else if (freqValue >= 75500000000 && freqValue <= 81000000000)
            {
                return "4MM";
            }
            else if (freqValue >= 122250000000 && freqValue <= 123000000000)
            {
                return "2.4MM";
            }
            else if (freqValue >= 134000000000 && freqValue <= 141000000000)
            {
                return "2MM";
            }
            else if (freqValue >= 241000000000 && freqValue <= 250000000000)
            {
                return "1.2MM";
            }
            else
            {
                return "Unknown"; // or any default value if frequency does not fall within known bands
            }
        }

    }
}
