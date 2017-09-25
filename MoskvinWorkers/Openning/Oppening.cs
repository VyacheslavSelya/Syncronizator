using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace MoskvinWorkers
{
    public static class Oppening
    {
        /// <summary>
        /// Открыть файл в проводнике Windows.
        /// </summary>
        /// <param name="file">Путь к файлу.</param>
        public static void OpenInWindowsExplorer(string file)
        {
            Process PrFolder = new Process();
            ProcessStartInfo psi = new ProcessStartInfo();
            
            psi.CreateNoWindow = true;
            psi.WindowStyle = ProcessWindowStyle.Normal;

            psi.FileName = "explorer";
            psi.Arguments = @"/n, /select, " + file;

            PrFolder.StartInfo = psi;
            PrFolder.Start();
        }
    }
}
