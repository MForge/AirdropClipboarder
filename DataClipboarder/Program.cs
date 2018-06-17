using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace AirdropClipboarder
{
    static class Program
    {
        public static int appCount = 0;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            foreach (Process process in Process.GetProcesses())
            {
                if (process.ProcessName == "AirdropClipboarder")
                {
                    appCount++;
                }
            }

            if (appCount <= 1)
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);

                Application.Run(new AirdropClipboarderMain());
            }
            else
            {
                MessageBox.Show("Data Clipboarder is already running", "Data Clipboarder", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
