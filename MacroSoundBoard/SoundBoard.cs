using Microsoft.Win32;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MacroSoundBoard
{
    public partial class SoundBoard : Form
    {

        Boolean isRunning = false;
        Process pid_ar_1 = null;
        Process pid_ar_2 = null;
        Process pid_ar_3 = null;
        public SoundBoard()
        {
            InitializeComponent();
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
        }

        private void SoundBoard_Load(object sender, EventArgs e)
        {

            vac_folder_tb.Text = Properties.Settings.Default.vac_directory;

            if (Properties.Settings.Default.vlc_directory.Length>0) {
                vlc_folder_tb.Text = Properties.Settings.Default.vlc_directory;
            } else {
                string temp = vlc_getInstallFromReg();
                if (temp != null)
                {
                    vlc_folder_tb.Text = temp;
                }
            }
            
            clsRecDevices recDev = new clsRecDevices();
            ArrayList imps = recDev.getInputDevices();
            ArrayList outs = recDev.getOutputDevices();
            foreach (string imp in imps)
            {
                realmic_name.Items.Add(imp);
                virtualmic_name.Items.Add(imp);
                virtualinput_name.Items.Add(imp);
            }
            foreach (string _out in outs)
            {
                realspeakers_name.Items.Add(_out);
            }
            realmic_name.SelectedIndex = realmic_name.FindStringExact(Properties.Settings.Default.vac_realmic);
            virtualmic_name.SelectedIndex = virtualmic_name.FindStringExact(Properties.Settings.Default.vac_virtmic);
            virtualinput_name.SelectedIndex = virtualinput_name.FindStringExact(Properties.Settings.Default.vac_virtinput);
            realspeakers_name.SelectedIndex = realspeakers_name.FindStringExact(Properties.Settings.Default.vac_realspeak);

            startVAC(true);
            updateLabels();
        }
        private string vlc_getInstallFromReg()
        {
            try
            {
                RegistryKey[] keys = new RegistryKey[] {
                    Registry.LocalMachine.OpenSubKey("SOFTWARE\\VideoLAN\\VLC"),
                    Registry.LocalMachine.OpenSubKey("SOFTWARE\\Wow6432Node\\VideoLAN\\VLC"),
                    Registry.CurrentUser.OpenSubKey("Software\\VideoLAN\\VLC"),
                    Registry.CurrentUser.OpenSubKey("Software\\Wow6432Node\\VideoLAN\\VLC")
                };
                foreach (RegistryKey key in keys)
                {
                    if (key != null)
                    {
                        Object o = key.GetValue("InstallDir");
                        if (o != null)
                        {
                            return o.ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
            }
            return null;
        }
        private void vac_folder_btn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.SelectedPath = vac_folder_tb.Text;
            fbd.ShowNewFolderButton = false;
            if (fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                vac_folder_tb.Text = fbd.SelectedPath;
            }
        }

        private void vac_folder_tb_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.vac_directory = vac_folder_tb.Text;
            Properties.Settings.Default.Save();
        }

        private void vlc_folder_btn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.SelectedPath = vlc_folder_tb.Text;
            fbd.ShowNewFolderButton = false;
            if (fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                vlc_folder_tb.Text = fbd.SelectedPath;
            }
        }
        private void vlc_folder_tb_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.vlc_directory = vlc_folder_tb.Text;
            Properties.Settings.Default.Save();
        }

        private void vac_cp_launch_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.vac_directory.Length > 0)
            {
                System.Diagnostics.Process.Start(Properties.Settings.Default.vac_directory + @"\vcctlpan.exe");
            }   
        }

        private void vac_ar_launch_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.vac_directory.Length > 0)
            {
                System.Diagnostics.Process.Start(Properties.Settings.Default.vac_directory + @"\audiorepeater.exe");
            }
        }

        private void realmic_name_SelectedIndexChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.vac_realmic = realmic_name.Text;
            Properties.Settings.Default.Save();
        }

        private void virtualmic_name_SelectedIndexChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.vac_virtmic = virtualmic_name.Text;
            Properties.Settings.Default.Save();
        }

        private void virtualinput_name_SelectedIndexChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.vac_virtinput = virtualinput_name.Text;
            Properties.Settings.Default.Save();
        }
        private void realspeakers_name_SelectedIndexChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.vac_realspeak = realspeakers_name.Text;
            Properties.Settings.Default.Save();
        }

        private void stopVAC() {
            if (pid_ar_1 != null)
            {
                pid_ar_1.Kill();
                pid_ar_1 = null;
            }
            if (pid_ar_2 != null)
            {
                pid_ar_2.Kill();
                pid_ar_2 = null;
            }
            if (pid_ar_3 != null)
            {
                pid_ar_3.Kill();
                pid_ar_3 = null;
            }
            isRunning = false;
        }
        private void startVAC(bool force=false)
        {
            if (force)
            {
                stopVAC();
            }
            if (
                (Properties.Settings.Default.vac_realmic.Length > 0) &&
                (Properties.Settings.Default.vac_virtmic.Length > 0) &&
                (Properties.Settings.Default.vac_virtinput.Length > 0) &&
                (Properties.Settings.Default.vac_realspeak.Length > 0)
            )
            {
                pid_ar_1 = PipeAudio(Properties.Settings.Default.vac_realmic, Properties.Settings.Default.vac_virtmic, 150, true);
                pid_ar_2 = PipeAudio(Properties.Settings.Default.vac_virtinput, Properties.Settings.Default.vac_virtmic, 200);
                pid_ar_3 = PipeAudio(Properties.Settings.Default.vac_virtinput, Properties.Settings.Default.vac_realspeak, 200);
                isRunning = true;
            }
        }

        private void toggle_ar_Click(object sender, EventArgs e)
        {
            if (isRunning)
            {
                stopVAC();
            }
            else
            {
                startVAC();
            }
            updateLabels();
        }

        private void updateLabels()
        {
            ar_1.Text = (pid_ar_1 != null) ? "Running (Pid: " + pid_ar_1.Id + ")" : "Not running";
            ar_2.Text = (pid_ar_2 != null) ? "Running (Pid: " + pid_ar_2.Id + ")" : "Not running";
            ar_3.Text = (pid_ar_3 != null) ? "Running (Pid: " + pid_ar_3.Id + ")" : "Not running";
            toggle_ar.Text = isRunning ? "Stop" : "Start";
            menuItem_toggle.Text = isRunning ? "Stop" : "Start";
        }

        private static Process PipeAudio(string inDevice, string outDevice, int bufferMs, bool isHighPriority = false)
        {
            string priority = isHighPriority ? "high" : "normal";
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.FileName = Properties.Settings.Default.vac_directory + @"\audiorepeater.exe";
            startInfo.Arguments = "/Input: \"" + inDevice + "\" /Output: \"" + outDevice + "\" /BufferMs:" + bufferMs + " /SamplingRate:44100 /Priority:" + priority + " /AutoStart";
            return Process.Start(startInfo);
        }
        private void SoundBoard_FormClosing(object sender, FormClosingEventArgs e)
        {
            stopVAC();
        }
        private void SoundBoard_FormClosed(object sender, FormClosedEventArgs e)
        {
            stopVAC();
        }

        private void trayIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }

        private void menuItem_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SoundBoard_Resize(object sender, EventArgs e)
        {
            trayIcon.BalloonTipTitle = "Macro Sound Board";
            trayIcon.BalloonTipText = "Macro Sound Board is running in the background...";

            if (this.WindowState == FormWindowState.Minimized)
            {
                trayIcon.Visible = true;
                trayIcon.ShowBalloonTip(200);
                this.Hide();
            }
            else if (this.WindowState == FormWindowState.Normal)
            {
                trayIcon.Visible = false;
                this.ShowInTaskbar = true;
            }
        }
    }
}
