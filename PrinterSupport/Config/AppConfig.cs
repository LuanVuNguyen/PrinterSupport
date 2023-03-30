using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrinterSupport
{
    class AppConfig
    {
        public static void parseConfig()
        {
            // Parse config value in config ini
            Dictionary<string, string> dataInFile = getDictionaryConfig(@"Config\Config.ini");

            ConfigVaribales.url = dataInFile["url"];
            ConfigVaribales.endpoint_hoadon = dataInFile["endpoint_hoadon"];
            ConfigVaribales.url_socket = dataInFile["url_socket"];
            ConfigVaribales.printer_hoadon = dataInFile["printer_hoadon"];
            ConfigVaribales.printer_voucher = dataInFile["printer_voucher"];
            ConfigVaribales.printer_hoadontam = dataInFile["printer_hoadontam"];
            ConfigVaribales.printer3 = dataInFile["printer3"];
            ConfigVaribales.param_idhoadon = dataInFile["param_idhoadon"];
            ConfigVaribales.type_print_HoaDon = dataInFile["type_print_HoaDon"];
            ConfigVaribales.type_print_Voucher = dataInFile["type_print_Voucher"];
            ConfigVaribales.type_print_HoaDonTam = dataInFile["type_print_HoaDonTam"];
            ConfigVaribales.type_print_billnuoc = dataInFile["type_print_billnuoc"];
        }

        public static Dictionary<string, string> getDictionaryConfig(string path)
        {
            Dictionary<string, string> Config = new Dictionary<string, string>();
            List<string> result = read_Fileini(path);
            foreach (string line in result)
            {
                if (!line.Contains("="))
                {
                    continue;
                }

                string[] temp = line.Split('=');
                Config[temp[0].Trim()] = temp[1].Trim();
            }
            return Config;
        }

        public static List<string> read_Fileini(string path)
        {
            List<string> result = new List<string>();
            if (!File.Exists(path))
            {
                MessageBox.Show("No config file is found!");
                Environment.Exit(0);
            }

            try
            {
                StreamReader sr = new StreamReader(path);
                string line = sr.ReadLine();
                while (line != null)
                {
                    result.Add(line);
                    line = sr.ReadLine();
                }
                sr.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error. Can not read file!" + "\n" + e,
                                "Can not read file!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(0);
            }
            return result;
        }
    }
}
