using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Windows.Forms;
namespace PrinterSupport
{
    public partial class MainForm : Form
    {
        private NotifyIcon notifyIcon;
        public MainForm()
        {
            InitializeComponent();
            this.notifyIcon = new NotifyIcon();
            this.notifyIcon.Icon = new Icon("pinter_icon.ico");
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
            // Get the default document folder path
            string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            // Combine the document path with the new folder name
            string newFolderPath = Path.Combine(documentsPath, "HoaDon");

            // Check if the folder already exists
            if (!Directory.Exists(newFolderPath))
            {
                // Create the new folder
                Directory.CreateDirectory(newFolderPath);
            }
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
        public void PrintPdf(string filename, string printerName)
        {
            ProcessStartInfo info = new ProcessStartInfo();
            info.Verb = "printto";
            info.FileName = filename;
            info.Arguments = "\"" + printerName + "\"";
            info.CreateNoWindow = true;
            info.WindowStyle = ProcessWindowStyle.Hidden;
            Process p = new Process();
            p.StartInfo = info;
            p.Start();
            p.WaitForExit();
        }

        private void btn_SaveSetup_Click(object sender, EventArgs e)
        {
            string selectedPrinter = cb_printer_hoadon.SelectedItem.ToString();
            string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string dicrectionPath = Path.Combine(documentsPath, "HoaDon");
            this.Hide();
            PrintNewPdfFiles(dicrectionPath, selectedPrinter);           
        }
        public void PrintNewPdfFiles(string directoryPath, string printerName)
        {
            while (true)
            {
                // Get a list of all PDF files in the directory
                string[] pdfFiles = Directory.GetFiles(directoryPath, "*.pdf");

                // Print each new PDF file that hasn't been printed before
                foreach (string pdfFile in pdfFiles)
                {
                    if (!File.Exists(pdfFile + ".printed"))
                    {
                        PrintPdf(pdfFile, printerName);
                        File.Create(pdfFile + ".printed").Dispose(); // Mark the file as printed
                    }
                }
                // Wait for 1 second before checking again
                Thread.Sleep(1000);
            }
        }
    }
}
