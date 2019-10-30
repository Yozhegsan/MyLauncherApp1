using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace MyLauncherApp1
{
    public partial class Form1 : Form
    {
        //-------- SetWindowsHookEx --------------------------------------------------------------------------------------------------------
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr SetWindowsHookEx(int idHook, LowLevelKeyboardProc lpfn, IntPtr hMod, uint dwThreadId);
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern bool UnhookWindowsHookEx(IntPtr hhk);
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr CallNextHookEx(IntPtr hhk, int nCode, IntPtr wParam, IntPtr lParam);
        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr GetModuleHandle(string lpModuleName);
        private const int WH_KEYBOARD_LL = 13;
        private const int WM_KEYDOWN = 0x0100;
        private static LowLevelKeyboardProc _proc = HookCallback;
        private static IntPtr _hookID = IntPtr.Zero;
        private static IntPtr SetHook(LowLevelKeyboardProc proc)
        {
            using (Process curProcess = Process.GetCurrentProcess())
            using (ProcessModule curModule = curProcess.MainModule) { return SetWindowsHookEx(WH_KEYBOARD_LL, proc, GetModuleHandle(curModule.ModuleName), 0); }
        }
        private delegate IntPtr LowLevelKeyboardProc(int nCode, IntPtr wParam, IntPtr lParam);
        private static IntPtr HookCallback(int nCode, IntPtr wParam, IntPtr lParam)
        {
            if ((nCode >= 0) && (wParam == (IntPtr)WM_KEYDOWN))
            {
                
                int vkCode = Marshal.ReadInt32(lParam);
                if ((Keys)vkCode == Keys.LWin) return (IntPtr)1;
                if ((Keys)vkCode == Keys.RWin) return (IntPtr)1;
                if ((Keys)vkCode == Keys.Escape) return (IntPtr)1;

                //if (((Keys)vkCode == Keys.ControlKey) && ((Keys)vkCode == Keys.Escape)) return (IntPtr)1;

                //if (((Keys)vkCode == Keys.ControlKey+Keys.Alt) || ((Keys)vkCode == Keys.Escape)) return (IntPtr)1;



            }
            return CallNextHookEx(_hookID, nCode, wParam, lParam);
        }
        //--- Load hook       _hookID = SetHook(_proc);
        //--- Unload hook     UnhookWindowsHookEx(_hookID);
        //=============================================================================================================================

        //###########################################################################################################

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _hookID = SetHook(_proc); //Load hook
            string[] s = Environment.GetEnvironmentVariable("path").Split(';');
            foreach (string ss in s)
                listBox1.Items.Add(ss);
            picTest.Image = Icon.ExtractAssociatedIcon(@"C:\Program Files (x86)\Adobe\Adobe Photoshop CS3\Photoshop.exe").ToBitmap();
        }

        private void ShowAppInfo(string obj)
        {
            label1.Text = obj;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            UnhookWindowsHookEx(_hookID); //Unload hook
        }
    }
}
