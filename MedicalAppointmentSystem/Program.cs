using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MedicalAppointmentSystem.Models; // Ensure this namespace is correct for your project structure

namespace MedicalAppointmentSystem
{
    // Remove or comment out the following line if the 'Models' namespace does not exist or is not needed:
    // using MedicalAppointmentSystem.Models; // Ensure this namespace is correct for your project structure
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());

        }
    }
}
