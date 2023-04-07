using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.WebSockets;
using System.Printing;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using Patagames.Pdf.Net;
using Patagames.Pdf.Net.Controls.WinForms;

namespace PrinterSupport
{
    public partial class MainForm : Form
    {
        private NotifyIcon notifyIcon;
        private ContextMenuStrip trayMenu;
        private string type = null;
        private string table;
        private HttpListener _listener;
        private bool _isListening = false;
        private string message;
        private string idhoadon;
        private bool checkRun = true;
        public MainForm()
        {
            InitializeComponent();
            InitializeNotifyIcon();
        }
        private void InitializeNotifyIcon()
        {
            notifyIcon = new NotifyIcon();
            notifyIcon.Icon = new Icon(@"Config/pinter_icon.ico");
            notifyIcon.Text = "Printer Support";
            notifyIcon.Visible = true;
            notifyIcon.MouseClick += NotifyIcon_MouseClick;
            trayMenu = new ContextMenuStrip();
            trayMenu.Items.Add("Open", null, TrayMenu_Open);
            trayMenu.Items.Add("Exit", null, TrayMenu_Exit);
            notifyIcon.ContextMenuStrip = trayMenu;
        }
        private void NotifyIcon_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                // handle left click
                this.Show();
            }
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            
            Init();
            CreatSocket();
            this.FormClosing += MainForm_FormClosing;         
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                this.Hide();               
            }
        }
        private void TrayMenu_Open(object sender, EventArgs e)
        {
            this.Show();
        }
        private void TrayMenu_Exit(object sender, EventArgs e)
        {
            notifyIcon.Visible = false;
            Application.Exit();
        }

        private void GetLocalPrinters()
        {
            cb_printer_hoadon.Items.Clear();
            // Lấy danh sách các máy in đang cài đặt trên máy tính
            LocalPrintServer printServer = new LocalPrintServer();
            PrintQueueCollection printQueues = printServer.GetPrintQueues();
            foreach (PrintQueue queue in printQueues)
            {
                if (!queue.QueueStatus.ToString().Contains("NotAvailable"))
                {
                    // Máy in khả dụng, thêm vào danh sách
                    string printerName = queue.Name;
                    cb_printer_hoadon.Items.Add(printerName);
                    cb_printer_phieuuudai.Items.Add(printerName);
                    cb_printer_HoaDonTam.Items.Add(printerName);
                    cb_printer3.Items.Add(printerName);
                }
                else
                {
                    // Máy in không khả dụng, bỏ qua
                    ShowLog.WriteLogE("Printer",$"{queue.Name} Not Available");
                }
            }
            // Chọn máy in mặc định nếu nó tồn tại trong danh sách
            if (cb_printer_hoadon.Items.Count > 0 && cb_printer_phieuuudai.Items.Count > 0 && cb_printer_HoaDonTam.Items.Count > 0 && cb_printer3.Items.Count > 0)
            {
                cb_printer_hoadon.SelectedIndex = cb_printer_hoadon.FindStringExact(ConfigVaribales.printer_hoadon);
                cb_printer_phieuuudai.SelectedIndex = cb_printer_phieuuudai.FindStringExact(ConfigVaribales.printer_voucher);
                cb_printer_HoaDonTam.SelectedIndex = cb_printer_HoaDonTam.FindStringExact(ConfigVaribales.printer_hoadontam);
                cb_printer3.SelectedIndex = cb_printer3.FindStringExact(ConfigVaribales.printer3);
            }
        }


        private void Btn_SaveSetup_Click(object sender, EventArgs e)
        {
            AppConfig.ReplaceIniKeyValue("printer_hoadon", cb_printer_hoadon.Text);
            AppConfig.ReplaceIniKeyValue("printer_voucher", cb_printer_phieuuudai.Text);
            AppConfig.ReplaceIniKeyValue("printer_hoadontam", cb_printer_HoaDonTam.Text);
            AppConfig.ReplaceIniKeyValue("printer3", cb_printer3.Text);
            this.Hide();
        }

        private async void CreatSocket()
        {
            if (!_isListening)
            {
                _listener = new HttpListener();
                _listener.Prefixes.Add(ConfigVaribales.url_socket);
                _listener.Start();
                ShowLog.WriteLogE("Socket start","Listening for incoming WebSocket connections...");
                _isListening = true;
                while (_isListening)
                {
                    var context = await _listener.GetContextAsync();
                    status_socket.Image = Image.FromFile(@"Config\connected.png");
                    txt_status.Text = "Connected";
                    ShowLog.WriteLogE("Connection", "Client is connected");
                    notifyIcon.ShowBalloonTip(1000, "Connection", "Client is connected", ToolTipIcon.Info);
                    if (context.Request.IsWebSocketRequest)
                    {
                        var webSocketContext = await context.AcceptWebSocketAsync(null);
                        await Receive(webSocketContext.WebSocket);
                    }
                    else
                    {
                        context.Response.StatusCode = 400;
                        context.Response.Close();
                    }
                }
            }
        }
        private async Task Receive(WebSocket webSocket)
        {
            try
            {
                var buffer = new byte[1024];
                var stream = new MemoryStream();
                while (webSocket.State == WebSocketState.Open)
                {
                    var result = await webSocket.ReceiveAsync(new ArraySegment<byte>(buffer), CancellationToken.None);
                    if (result.MessageType == WebSocketMessageType.Close)
                    {
                        // Client closed the connection, so close the WebSocket
                        await webSocket.CloseAsync(result.CloseStatus.Value, result.CloseStatusDescription, CancellationToken.None);
                        status_socket.Image = Image.FromFile(@"Config\unconnected.png");
                        txt_status.Text = "Disconnect";
                        ShowLog.WriteLogE("Disconnection", "Client is disconnected");
                        notifyIcon.ShowBalloonTip(1000, "Disconnection", "Client is disconnected", ToolTipIcon.Warning);
                        break;
                    }
                    if (result.MessageType == WebSocketMessageType.Text)
                    {
                        message = Encoding.UTF8.GetString(buffer, 0, result.Count);
                        JObject res = JObject.Parse(message);
                        idhoadon = (string)res["hoaDonID"];
                        type = (string)res["type"];
                        table = (string)res["table"];
                    }
                    if (result.MessageType == WebSocketMessageType.Binary)
                    {
                        stream.Write(buffer, 0, result.Count);
                        if (result.EndOfMessage)
                        {
                            var data = stream.ToArray();                      
                            stream.Dispose();
                            using (var pdf = PdfDocument.Load(data))
                            {
                                // Create a new instance of the PdfPrintDocument class
                                var printDoc = new PdfPrintDocument(pdf);

                                // Set the printer name (optional)
                                if (type == ConfigVaribales.type_print_HoaDonTam)
                                {
                                    printDoc.PrinterSettings.PrinterName = cb_printer_HoaDonTam.Text;
                                }
                                else if (type == ConfigVaribales.type_print_HoaDon)
                                {
                                    printDoc.PrinterSettings.PrinterName = cb_printer_hoadon.Text;
                                }  
                                else if (type == ConfigVaribales.type_print_Voucher)
                                {
                                    printDoc.PrinterSettings.PrinterName = cb_printer_phieuuudai.Text;
                                }
                                else
                                {
                                    printDoc.PrinterSettings.PrinterName = cb_printer3.Text;
                                }
                                // Set any additional print settings (optional)
                                printDoc.PrinterSettings.Copies = 1;
                                // Print the document
                                printDoc.Print();
                                ShowLog.WriteLogP(type, $"ID: {idhoadon}, số bàn:{table}");
                            }
                            stream = new MemoryStream();
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                ShowLog.WriteLogE("Exception", e.Message);                   
            }
        }

        private void Init()
        {
            AppConfig.parseConfig();
            GetLocalPrinters();            
            status_socket.Image = Image.FromFile(@"Config\unconnected.png");
            type_in1.Text = ConfigVaribales.label_hoadon;
            type_in2.Text = ConfigVaribales.label_voucher;
            type_in3.Text = ConfigVaribales.label_hoadontam;
            type_in4.Text = ConfigVaribales.label_phieuorder;
        }

        private void btn_Printed_Click(object sender, EventArgs e)
        {
            string File = "Printed.txt";
            Process.Start(File);
        }

        private void CheckRun()
        {
            using (Mutex mutex = new Mutex(true, "MyAppMutex", out checkRun))
            {
                if (checkRun)
                {
                    // Nếu ứng dụng chưa chạy, thì tiếp tục khởi động ứng dụng
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    Application.Run(new MainForm());
                }
                else
                {
                    // Nếu ứng dụng đang chạy, hiển thị thông báo cho người dùng
                    MessageBox.Show("Ứng dụng đang chạy!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
