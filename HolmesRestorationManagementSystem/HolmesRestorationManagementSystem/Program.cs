using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using HolmesRestorationManagementSystem.Ui;
using Twilio.TwiML;

namespace HolmesRestorationManagementSystem
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Console.WriteLine(new VoiceResponse().Say("{body}", language: "en", voice: "alice").Hangup());

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new PropertyMaintenanceForm());
        }
    }
}
