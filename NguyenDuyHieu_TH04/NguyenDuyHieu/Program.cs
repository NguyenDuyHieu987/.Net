using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using NguyenDuyHieu.Solution;

namespace NguyenDuyHieu
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
            //Application.Run(new Cau1());
            //Application.Run(new Cau2());
            //Application.Run(new Cau3());
            //Application.Run(new Cau4());
            //Application.Run(new Cau5());
            //Application.Run(new Cau6());

            Application.Run(new frmCongDan());
        }
    }
}
