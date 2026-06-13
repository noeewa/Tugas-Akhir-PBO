using Tugas_Akhir_PBO.VIEW;
using Tugas_Akhir_PBO.MODEL;
using Tugas_Akhir_PBO.CONTROLLER;
using Tugas_Akhir_PBO.Models;

namespace Tugas_Akhir_PBO
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormLogin());
        }
    }
}