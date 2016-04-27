using Branch.com.proem.exm.util;
using Branch.com.proem.exm.window.main;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Branch
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new BranchLogin());

            Thread t = new Thread(new ThreadStart(PingTask.Ping));
            t.Start();

            BranchLogin login = new BranchLogin();
            //窗口居中
            login.StartPosition = FormStartPosition.CenterScreen;
            login.ShowDialog();
            if(login.DialogResult == DialogResult.OK)
            {

                Thread t1 = new Thread(new ThreadStart(DataUploadTask.Run));
                t1.Start();

                BranchMain main = new BranchMain();
                //窗口居中
                main.StartPosition = FormStartPosition.CenterScreen;
                Application.Run(main);
            }
            
        }
    }
}
