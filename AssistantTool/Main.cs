using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Threading;

namespace AssistantTool
{

    public partial class Main : Form
    {

        public Main()
        {
            InitializeComponent();
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            IntPtr windowHandler = new IntPtr(Int32.Parse(txtWindowHandler.Text));
            if (WindowsHelp.IsWindowVisible(windowHandler))

                WindowsHelp.ShowWindow(windowHandler, WindowsHelp.SW_HIDE);
            else
                WindowsHelp.ShowWindow(windowHandler, WindowsHelp.SW_SHOW);
        }

        private void btnAutoRun_Click(object sender, EventArgs e)
        {
            IntPtr windowHandler = new IntPtr(Int32.Parse(txtWindowHandler.Text));
            //WindowsHelp.SendMessage(windowHandler, WindowsHelp.WM_PARENTNOTIFY, 0x204, 0x01da0201);
            //WindowsHelp.SendMessage(windowHandler, WindowsHelp.WM_PARENTNOTIFY, 0x204, 0x01da0201);

            WindowsHelp.SetForegroundWindow(windowHandler);
            WindowsHelp.SendMessage(windowHandler, WindowsHelp.WM_RBUTTONDOWN, 0, 0x01da0201);
            Thread.Sleep(100);
            WindowsHelp.SendMessage(windowHandler, WindowsHelp.WM_RBUTTONDOWN, 0, 0x01da0201);
            WindowsHelp.SendMessage(windowHandler, WindowsHelp.WM_RBUTTONUP, 0, 0x01da0201);
        }
    }


}
