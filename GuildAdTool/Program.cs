using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JohnBPearson.Windows.Forms.KeyBindingButler
{
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

            // Add handler for UI thread exceptions
            Application.ThreadException += new ThreadExceptionEventHandler(UIThreadException);

            // Force all WinForms errors to go through handler
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);

            // This handler is for catching non-UI thread exceptions
            AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(CurrentDomain_UnhandledException);

            var main = new Main();
            Application.Run(main);
        }

        private static void CurrentDomain_UnhandledException(Object sender, UnhandledExceptionEventArgs e)
        {
            try
            {
                Exception ex = (Exception)e.ExceptionObject;
                MessageBox.Show("Unhadled domain exception:\n\n" + ex.Message);
            }
            catch (Exception exc)
            {
                try
                {
                    MessageBox.Show("Fatal exception happend inside UnhadledExceptionHandler: \n\n"
                        + exc.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                finally
                {
                    Application.Exit();
                }
            }

            // It should terminate our main thread so Application.Exit() is unnecessary here
        }

        private static void UIThreadException(object sender, ThreadExceptionEventArgs t)
        {
            try
            {
                MessageBox.Show("Unhandled exception catched.\n Application is going to close now.");
            }
            catch
            {
                try
                {
                    MessageBox.Show("Fatal exception happend inside UIThreadException handler",
                        "Fatal Windows Forms Error", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Stop);
                }
                finally
                {
                    Application.Exit();
                }
            }

            // Here we can decide if we want to end our application or do something else
            Application.Exit();
        }
    }
}
