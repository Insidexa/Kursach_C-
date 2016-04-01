using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Kursach
{
    class CloseProcess
    {
        public static void FormClose(Object sender, FormClosingEventArgs e = null)
        {
            Process[] processesWord = Process.GetProcessesByName("WINWORD");
            if (processesWord.Length > 0)
                foreach (Process proc in processesWord)
                {
                    proc.CloseMainWindow();
                }
            Process[] processesExcel = Process.GetProcessesByName("excel");
            if (processesExcel.Length > 0)
                foreach (Process proc in processesExcel)
                {
                    proc.CloseMainWindow();
                }
            
            GC.Collect();
            Application.Exit();
        }
    }
}
