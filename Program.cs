using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using AdvancedProgrammingAssignment2.View;

namespace AdvancedProgrammingAssignment2
{
    internal static class Program
    {
        private const int AttachParentProcess = -1;

        /// <summary>
        ///     The main entry point for the application.
        /// </summary>
        [STAThread]

        //Set additional output as console
        [DllImport("kernel32.dll")]
        private static extern bool AttachConsole(int dwProcessId);

        private static void Main()
        {
            //Init console for testing
            AttachConsole(AttachParentProcess);

            //Run the form
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ProgressForm());
        }
    }
}