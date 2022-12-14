using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using AdvancedProgrammingAssignment2.View;
using MongoDB.Driver;

namespace AdvancedProgrammingAssignment2
{
    internal static class Program
    {
        private const int ATTACH_PARENT_PROCESS = -1;

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
            AttachConsole(ATTACH_PARENT_PROCESS);

            //Connect to DB
            MongoClientSettings settings = MongoClientSettings.FromConnectionString(
                "mongodb+srv://admin:HWiRjWnroiKmcyQw@librarymanagement.io7gmky.mongodb.net/?retryWrites=true&w=majority");
            settings.ServerApi = new ServerApi(ServerApiVersion.V1);
            MongoClient client = new MongoClient(settings);

            //Run the form
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ProgessForm());
        }
    }
}