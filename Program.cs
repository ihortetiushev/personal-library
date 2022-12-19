using PersonalLibrary.Dao;
using PersonalLibrary.View;
using System;
using System.Windows.Forms;

namespace PersonalLibrary
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Repository repository = new Repository();
            if (!repository.OpenConnection()) {
                Environment.Exit(-1);
            }
            UIState uiState = new UIState();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm(repository, uiState));
        }
    }
}
