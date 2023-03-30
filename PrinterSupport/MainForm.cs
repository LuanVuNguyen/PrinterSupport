using System;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.WebSockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

namespace PrinterSupport
{
    public partial class MainForm : Form
    {
        private NotifyIcon notifyIcon;
        private ContextMenuStrip trayMenu;
        private string selectedPrinter = "";
        private string token = null;
        private string idhoadon = null;
        private string type = null;
        private HttpListener _listener;
        private bool _isListening = false;

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
            AppConfig.parseConfig();
            Init();
            GetLocalPrinters();
            Log.Logger();
            Task.Run(() =>CreatSocket());
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

            // Get the list of installed printers on the computer
            string[] installedPrinters = PrinterSettings.InstalledPrinters.Cast<string>().ToArray();

            foreach (string printer in installedPrinters)
            {
                cb_printer_hoadon.Items.Add(printer);
                cb_printer_phieuuudai.Items.Add(printer);
                cb_printer_HoaDonTam.Items.Add(printer);
                cb_printer3.Items.Add(printer);
            }

            // Select the default printers if they exist
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
            this.Hide();
        }

        private async void CreatSocket()
        {
            if (!_isListening)
            {
                _listener = new HttpListener();
                _listener.Prefixes.Add(ConfigVaribales.url_socket);
                //_listener.Prefixes.Add("http://" + host + ":" + port + "/");
                _listener.Start();
                //text_received.AppendText("Listening for incoming WebSocket connections...\r\n");
                Console.WriteLine("Listening for incoming WebSocket connections...\r\n");
                Log.Logs("Listening for incoming WebSocket connections...\r\n");
                _isListening = true;
                //lbl_connectionStatus.Text = "connected";
                while (_isListening)
                {
                    var context = await _listener.GetContextAsync();
                    if (context.Request.IsWebSocketRequest)
                    {
                        var webSocketContext = await context.AcceptWebSocketAsync(null);
                        //text_received.AppendText("WebSocket connection established.\r\n");
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
            var buffer = new byte[1024];
            while (webSocket.State == WebSocketState.Open)
            {
                var result = await webSocket.ReceiveAsync(new ArraySegment<byte>(buffer), CancellationToken.None);
                if (result.MessageType == WebSocketMessageType.Text)
                {
                    var message = Encoding.UTF8.GetString(buffer, 0, result.Count);
                    Console.WriteLine(message);
                    Log.Logs(message);
                    //text_received.AppendText($"Received message: {message}\r\n");
                    JObject res = JObject.Parse(message);                   
                    idhoadon = (string)res["hoaDonID"];
                    token = (string)res["token"];
                    type = (string)res["type"];
                    Console.WriteLine("ID: " + idhoadon);
                    Console.WriteLine("Token: " + token);
                    Console.WriteLine("Type: " + type);
                }
                while (idhoadon == null)
                {
                    Thread.Sleep(1000); // Sleep for 1 second before checking for new message
                }
                // Do something with the new message
                Print print = new Print();
                switch (type)
                {
                    case string s when s == ConfigVaribales.type_print_HoaDon:
                        cb_printer_hoadon.Invoke((MethodInvoker)delegate
                        {
                            selectedPrinter = cb_printer_hoadon.Text;
                        });
                        break;
                    case string s when s == ConfigVaribales.type_print_Voucher:
                        cb_printer_phieuuudai.Invoke((MethodInvoker)delegate
                        {
                            selectedPrinter = cb_printer_phieuuudai.Text;
                        });
                        break;
                    case string s when s == ConfigVaribales.type_print_HoaDonTam:
                        cb_printer_HoaDonTam.Invoke((MethodInvoker)delegate
                        {
                            selectedPrinter = cb_printer_HoaDonTam.Text;
                        });
                        break;
                    default:
                        cb_printer3.Invoke((MethodInvoker)delegate
                        {
                            selectedPrinter = cb_printer3.Text;
                        });
                        break;
                }
                print.Main(idhoadon, selectedPrinter, token);
                //Reset the idhoadon variable
                idhoadon = null;
            }

        }
        private void Init()
        {
            type_in1.Text = ConfigVaribales.type_print_HoaDon;
            type_in2.Text = ConfigVaribales.type_print_Voucher;
            type_in3.Text = ConfigVaribales.type_print_HoaDonTam;
            type_in4.Text = ConfigVaribales.type_print_billnuoc;
        }

    }
}
