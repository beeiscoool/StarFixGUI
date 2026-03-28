using System;
using System.Windows.Forms;

namespace StarFixGUI
{
    internal static class Program
    {
        /// <summary>
        /// Main entry point of the StarFix GUI application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                ApplicationConfiguration.Initialize();
                Application.Run(new Form1());
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "An unexpected error occurred while starting the game:\n\n" + ex.Message,
                    "StarFix Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
    }
}