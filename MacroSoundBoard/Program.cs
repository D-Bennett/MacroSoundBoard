using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace MacroSoundBoard
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            if (args.Length >= 1)
            {
                if (Properties.Settings.Default.vlc_directory.Length > 0 && Properties.Settings.Default.vac_virtinput.Length > 0)
                {
                    ProcessStartInfo startInfo = new ProcessStartInfo();
                    startInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    startInfo.FileName = Properties.Settings.Default.vlc_directory + @"\vlc.exe";
                    startInfo.Arguments = "-I dummy \"" + args[0] + "\" --dummy-quiet --play-and-exit --aout=\"waveout\" --waveout-audio-device=\"" + Properties.Settings.Default.vac_virtinput + " ($1,$64)\"";
                    Process.Start(startInfo);
                }
            }
            else
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new SoundBoard());
            }
        }
    }
}
