using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace PrinterSupport
{
    public partial class MainForm : Form
    {
        private PrintDocument printDocument1;
        private NotifyIcon notifyIcon;
        public MainForm()
        {
            InitializeComponent();
            this.notifyIcon = new NotifyIcon();
            this.notifyIcon.Icon = new Icon(@"PrinterSupport\connected.ico");
            this.notifyIcon.Text = "Printer Support";
            this.notifyIcon.Click += new EventHandler(NotifyIcon_Click);
            this.notifyIcon.Visible = true;
        }
        private void NotifyIcon_Click(object sender, EventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            GetLocalPrinters();
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true; // Hủy đóng Form khi bấm nút Close
                this.Hide(); // Ẩn Form đi
            }
        }
        private void GetLocalPrinters()
        {
            cb_printer_hoadon.Items.Clear();
            // Lấy danh sách các máy in đã được cài đặt trên máy tính
            string[] installedPrinters = PrinterSettings.InstalledPrinters.Cast<string>().ToArray();
            foreach (string printer in installedPrinters)
            {
                if (IsPrinterConnected(printer))
                {
                    cb_printer_hoadon.Items.Add(printer);
                    cb_printer_phieuuudai.Items.Add(printer);
                    cb_printer2.Items.Add(printer);
                    cb_printer3.Items.Add(printer);
                }
            }
            if (cb_printer_hoadon.Items.Count > 0)
            {
                cb_printer_hoadon.SelectedIndex = 0;
            }
            // Khởi tạo PrintDocument để in bản in thử
            printDocument1 = new PrintDocument();
            printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
        }
        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            // Vẽ một dòng chữ "Hello, world!" bằng font Arial với kích cỡ 16
            var font = new Font("Arial", 16);
            e.Graphics.DrawString("Hello, world!", font, Brushes.Black, new PointF(100, 100));
        }
        private bool IsPrinterConnected(string printerName)
        {
            try
            {
                PrinterSettings ps = new PrinterSettings();
                ps.PrinterName = printerName;
                return ps.IsValid;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private void btn_SaveSetup_Click(object sender, EventArgs e)
        {
            string selectedPrinter = cb_printer_hoadon.SelectedItem.ToString();
            Console.WriteLine(selectedPrinter);
            printDocument1.PrinterSettings.PrinterName = selectedPrinter;
            // In bản in thử
            //printDocument1.Print();
            //Thread backgroundThread = new Thread(new ThreadStart(RunBackground));
            //backgroundThread.Start();
            this.Hide();
        }

    }
}
