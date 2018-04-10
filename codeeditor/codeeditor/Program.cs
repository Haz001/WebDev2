using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace codeeditor
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[]  args)
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            WebDev2.Starter appli = new WebDev2.Starter();

            if (args.Length == 0)
            {
                
                Application.Run(appli);
            }else if(args.Length >= 1)
            {
                if (File.Exists(args[0]))
                {
                    appli.file_path = args[0];
                }
                
                Application.Run(appli);
            }
        }
    }
}
