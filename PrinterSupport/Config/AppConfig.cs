using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
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
            ConfigVaribales.url_socket = dataInFile["url_socket"];
            ConfigVaribales.printer_hoadon = dataInFile["printer_hoadon"];
            ConfigVaribales.printer_voucher = dataInFile["printer_voucher"];
            ConfigVaribales.printer_hoadontam = dataInFile["printer_hoadontam"];
            ConfigVaribales.printer3 = dataInFile["printer3"];
            ConfigVaribales.type_print_HoaDon = dataInFile["type_print_HoaDon"];
            ConfigVaribales.type_print_Voucher = dataInFile["type_print_Voucher"];
            ConfigVaribales.type_print_HoaDonTam = dataInFile["type_print_HoaDonTam"];
            ConfigVaribales.type_print_billnuoc = dataInFile["type_print_billnuoc"];
            ConfigVaribales.label_hoadon = dataInFile["label_hoadon"];
            ConfigVaribales.label_hoadontam = dataInFile["label_hoadontam"];
            ConfigVaribales.label_voucher = dataInFile["label_voucher"];
            ConfigVaribales.label_phieuorder = dataInFile["label_phieuorder"];
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
        public static void write_Fileini(string path, Dictionary<string, string> data)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(path))
                {
                    foreach (var item in data)
                    {
                        sw.WriteLine($"{item.Key}={item.Value}");
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error. Can not write to file!" + "\n" + e,
                                "Can not write to file!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(0);
            }
        }
        public static void ReplaceIniKeyValue(string keyToReplace, string newValue)
        {
            string filePath = @"Config\Config.ini";
            // Read the INI file into a string
            string fileContent = File.ReadAllText(filePath);
            // Replace the old value with the new value
            string newContent = Regex.Replace(
                fileContent,
                $"({keyToReplace}\\s*=\\s*)(.*)",
                $"{keyToReplace}={newValue}",
                RegexOptions.Multiline);

            // Write the updated content back to the file
            File.WriteAllText(filePath, newContent, Encoding.UTF8);
        }

    }
}
