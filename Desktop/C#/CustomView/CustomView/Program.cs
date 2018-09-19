using GUI.Start;
using System;
using System.Windows.Forms;

namespace CustomView
{
    static class Program
    {
        #region Application Properties

        public static Authentication.Security Security;
        private static Context.ApplicationContext _ApplicationContext;
        public static Context.ApplicationContext ApplicationContext
        {
            get
            {
                if (_ApplicationContext == null)
                {
                    _ApplicationContext = new Context.ApplicationContext();
                }
                return _ApplicationContext;
            }
            set
            {
                _ApplicationContext = value;
            }
        }

        #endregion
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
        }
    }
}
