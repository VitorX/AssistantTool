using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace AssistantTool
{
    public class WindowsHelp
    {
        public const int SW_SHOW = 5;
        public const int SW_HIDE = 0;

        public const int WM_PARENTNOTIFY = 0x0210;
        //public const int WM_PARENTNOTIFY = 0x0210;
        public const int WM_RBUTTONDOWN =0x0204;
        public const int WM_RBUTTONUP = 0x0205;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll", EntryPoint = "ShowWindow")]
        public static extern bool ShowWindow(System.IntPtr hWnd, int nCmdShow);

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll", EntryPoint = "IsWindowVisible")]
        public static extern bool IsWindowVisible(IntPtr hwnd);

        [DllImport("USER32.DLL")]
        public static extern bool SetForegroundWindow(IntPtr hWnd);         

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        public static extern int SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);
    }
}
