using System;
using System.IO;

namespace MinimalisticTelnet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("QSOLink-Logbook Telnet client; Written by Rafael Rodrigues, Ported for QSOLink by Patrik Nagy.");

            string host = "";
            int port = 0;
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
                port = int.Parse(lines[1].Trim());
                callsign = lines[2].Trim();

                // Now you can use these values as needed
                Console.WriteLine($"Host: {host}");
                Console.WriteLine($"Port: {port}");
                Console.WriteLine($"Callsign: {callsign}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while reading config file: {ex.Message}");
                return;
            }

            try
            {
                TelnetConnection tc = new TelnetConnection(host, port);

                // Send the callsign
                tc.WriteLine(callsign);

                string prompt = "";

                // While connected and not instructed to exit
                while (tc.IsConnected && prompt.Trim() != "exit")
                {
                    // Display server output
                    Console.Write(tc.Read());

                    // Send client input to server
                    prompt = Console.ReadLine();
                    tc.WriteLine(prompt);

                    // Display server output
                    Console.Write(tc.Read());
                }

                Console.WriteLine("***DISCONNECTED");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while running Telnet client: {ex.Message}");
            }

            Console.ReadLine();
        }
    }
}
