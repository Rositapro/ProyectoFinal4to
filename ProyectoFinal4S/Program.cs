using System;

namespace ProyectoFinal4S.ProyectoFinal4S
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ProyectoFinal4S.ApplicationConfiguration.Initialize();
            System.Windows.Forms.Application.Run(new FrmMenu());
        }
    }
}