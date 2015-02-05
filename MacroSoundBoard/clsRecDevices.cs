using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
using System.Collections;
namespace MacroSoundBoard
{
    class clsRecDevices
    {
        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public struct WaveInCaps
        {
            public short wMid;
            public short wPid;
            public int vDriverVersion;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
            public char[] szPname;
            public uint dwFormats;
            public short wChannels;
            public short wReserved1;
        }
        public struct WaveOutCaps
        {
            public short wMid;
            public short wPid;
            public int vDriverVersion;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
            public char[] szPname;
            public uint dwFormats;
            public short wChannels;
            public short wReserved1;
        }

        [DllImport("winmm.dll")]
        public static extern int waveInGetNumDevs();

        [DllImport("winmm.dll")]
        public static extern int waveOutGetNumDevs();

        [DllImport("winmm.dll", EntryPoint = "waveInGetDevCaps")]
        public static extern int waveInGetDevCapsA(int uDeviceID, ref WaveInCaps lpCaps, int uSize);

        [DllImport("winmm.dll", EntryPoint = "waveOutGetDevCaps")]
        public static extern int waveOutGetDevCapsA(int uDeviceID, ref WaveOutCaps lpCaps, int uSize);

        public ArrayList getInputDevices() //fill sound recording devices array
        {
            ArrayList arrLst = new ArrayList();
            int waveInDevicesCount = waveInGetNumDevs(); //get total
            if (waveInDevicesCount > 0)
            {
                for (int uDeviceID = 0; uDeviceID < waveInDevicesCount; uDeviceID++)
                {
                    WaveInCaps waveInCaps = new WaveInCaps();
                    waveInGetDevCapsA(uDeviceID, ref waveInCaps, Marshal.SizeOf(typeof(WaveInCaps)));
                    arrLst.Add(new string(waveInCaps.szPname).Remove(new string(waveInCaps.szPname).IndexOf('\0')).Trim());
                }
            }
            return arrLst;
        }
        public ArrayList getOutputDevices() //fill sound recording devices array
        {
            ArrayList arrLst = new ArrayList();
            int waveOutDevicesCount = waveOutGetNumDevs(); //get total
            if (waveOutDevicesCount > 0)
            {
                for (int uDeviceID = 0; uDeviceID < waveOutDevicesCount; uDeviceID++)
                {
                    WaveOutCaps waveOutCaps = new WaveOutCaps();
                    waveOutGetDevCapsA(uDeviceID, ref waveOutCaps, Marshal.SizeOf(typeof(WaveOutCaps)));
                    arrLst.Add(new string(waveOutCaps.szPname).Remove(new string(waveOutCaps.szPname).IndexOf('\0')).Trim());
                }
            }
            return arrLst;
        }
    }
}