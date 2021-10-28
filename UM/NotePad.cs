using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace UM
{
    public static class NotePad
    {
        [DllImport("user32.dll", EntryPoint = "FindWindowEx")]
        private static extern IntPtr FindWindowEx(IntPtr hwndParent, IntPtr hwndChildAfter, string lpszClass, string lpszWindow);

        [DllImport("User32.dll", EntryPoint = "SendMessage")]
        private static extern int SendMessage(IntPtr hWnd, int uMsg, int wParam, string lParam);

        public static void Show(string message = null)
        {
            Process notepad = Process.Start(new ProcessStartInfo("notepad.exe"));
            if (notepad != null)
            {
                notepad.WaitForInputIdle();

                SendMessage((IntPtr)FindWindowEx(notepad.MainWindowHandle, new IntPtr(0), "Edit", null), 0x000C, 0, message);
            }
        }
    }
}
