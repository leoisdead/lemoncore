using System;
using System.Windows.Forms;

namespace Lemon
{
    static class Program
    {
        public static About about;
        public static LemonCore.Libs.image _img = new LemonCore.Libs.image();
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Some random Change here for testing idk.
            //sup
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new main());
        }
    }
}
