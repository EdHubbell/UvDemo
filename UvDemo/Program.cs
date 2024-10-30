using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using NLog;

namespace CSharpWinFormsTemplate
{

    internal static class Program
    {
        private static Logger logger = null;

        [DllImport("SHCore.dll", SetLastError = true)]
        private static extern bool SetProcessDpiAwareness(PROCESS_DPI_AWARENESS awareness);

        private enum PROCESS_DPI_AWARENESS
        {
            Process_DPI_Unaware = 0,
            Process_System_DPI_Aware = 1,
            Process_Per_Monitor_DPI_Aware = 2
        }


        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // This worked to fix the scaling issue on Ed's laptop (150% screen) so it renders at the same resolution as the design view when VS is running at 100% scaling.
            // FWIW, Version.Major is 6 for Vista, 7 for Win7, 8 for Win8, 10 for Win10
            if (Environment.OSVersion.Version.Major >= 6) SetProcessDpiAwareness(PROCESS_DPI_AWARENESS.Process_DPI_Unaware);


            try
            {
                logger = LogManager.GetCurrentClassLogger();
            }
            catch
            {
                MessageBox.Show("Missing NLog.config file. This software can't run without an NLog.config file.");
                Application.Exit();
            }


            try
            {
                logger.Info("Program.cs Main - Application launch");

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new frmMain());
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Program.cs Main - Application launch error");
            }
        }
    }
}
