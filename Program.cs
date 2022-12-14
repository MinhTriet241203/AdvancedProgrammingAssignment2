using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using MongoDB.Bson;
using MongoDB.Driver;

namespace AdvancedProgrammingAssignment2
{
    internal static class Program
    {
        /// <summary>
        ///     The main entry point for the application.
        /// </summary>
        [STAThread]
        
        //Set additional output as console
        [DllImport( "kernel32.dll" )]
        static extern bool AttachConsole( int dwProcessId );
        private const int ATTACH_PARENT_PROCESS = -1;
        
        private static void Main()
        {
            //Init console for testing
            AttachConsole( ATTACH_PARENT_PROCESS );
            
            //Connect to DB
            var settings = MongoClientSettings.FromConnectionString("mongodb+srv://admin:HWiRjWnroiKmcyQw@librarymanagement.io7gmky.mongodb.net/?retryWrites=true&w=majority");
            settings.ServerApi = new ServerApi(ServerApiVersion.V1);
            var client = new MongoClient(settings);
            
            var filter = Builders<BsonDocument>.Filter.ElemMatch<BsonValue>("scores", new BsonDocument { 
                { "type", "exam" }, {"score", new BsonDocument { { "$lt", 60 }}}
            });

            //Run the form
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LibraryApp());
        }
    }
}