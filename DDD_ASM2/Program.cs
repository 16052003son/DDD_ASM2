using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DDD_ASM2
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
            Application.Run(new Login());
            if (Appdata.isLogined)
            {
                if (Appdata.isAdmin)
                {
                    Application.Run(new Home());
                }
                else
                {
                    Application.Run(new SearchStudent());
                }
            }
        }
    }
    

}
