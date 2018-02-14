using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using System.IO;

namespace Pt2
{
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        
        private static String themeFileName = null;
        public static bool usedTheme = true;
        public static Form1 form1 = new Form1();

        public static string ThemeFileName { get => themeFileName; set => themeFileName = value; }
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(form1);
        }
    }
}
