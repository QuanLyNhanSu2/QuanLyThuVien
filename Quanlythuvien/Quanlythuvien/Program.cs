using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Quanlythuvien.View;

namespace Quanlythuvien
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Dangnhap dn = new Dangnhap();
            dn.StartPosition = FormStartPosition.CenterScreen;
            Application.Run(dn);
        }
    }
}
