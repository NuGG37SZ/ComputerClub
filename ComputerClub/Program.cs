using System;
using System.Windows.Forms;

namespace ComputerClub
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            AuthForm authForm = new AuthForm();

            if (authForm.ShowDialog() == DialogResult.OK)
            {
                if (!authForm.IsDisposed)
                {
                    Application.Run(new MainForm());
                }
            }
        }
    }
}
