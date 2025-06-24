using Unicomtic_manegment_system.data;
using Unicomtic_manegment_system.model;
using Unicomtic_manegment_system.view;

namespace Unicomtic_manegment_system
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            tablecreate.CreateTables();
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new second());
        }
    }
}