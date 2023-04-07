using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrinterSupport
{
    
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>+
        
        [STAThread]
        static void Main()
        {
            bool createdNew = true;
            using (Mutex mutex = new Mutex(true, "PRINTER SUPPORT", out createdNew))
            {
                if (createdNew)
                {
                    // Nếu ứng dụng chưa chạy, thì tiếp tục khởi động ứng dụng
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    Application.Run(new MainForm());
                }
                else
                {
                    // Nếu ứng dụng đang chạy, hiển thị thông báo cho người dùng
                    MessageBox.Show("APP IS RUNNING!", "NOTIFICATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ShowLog.WriteLogE("OPEN APP","APP IS RUNNING!");
                }
            }
        }
    }
}
