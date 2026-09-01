using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD1
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
            Application.Run(new Form1());
            //Application.Run(new frmManageApplicationTypes());
            //Application.Run(new frmAddPerson(-1));
            //Application.Run(new frmPeople());
            //Application.Run(new frmMain());
            //Application.Run(new frmUsers());
        }
    }
}
