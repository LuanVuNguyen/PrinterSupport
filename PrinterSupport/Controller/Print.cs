using Patagames.Pdf.Net;
using Patagames.Pdf.Net.Controls.WinForms;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Windows.Forms;

namespace PrinterSupport
{
    class Print
    {
        public async void Main(string idhoadon, string selectedPrinter,string token)
        {
            if (idhoadon != null)
            {
                string ApiUrl = string.Format("{0}/{1}{2}={3}",ConfigVaribales.url ,ConfigVaribales.endpoint_hoadon, ConfigVaribales.param_idhoadon, idhoadon);
                try
                {
                    using (HttpClient client = new HttpClient())
                    {
                        client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
                        HttpResponseMessage response = await client.GetAsync(ApiUrl);
                        Console.WriteLine(response);
                        if (response.IsSuccessStatusCode && response.Content != null)
                        {
                            var stream = await response.Content.ReadAsStreamAsync();

                            using (var document = PdfDocument.Load(stream))
                            {
                                // Create a new instance of the PdfPrintDocument class
                                var printDoc = new PdfPrintDocument(document);

                                // Set the printer name (optional)
                                printDoc.PrinterSettings.PrinterName = selectedPrinter;

                                // Set any additional print settings (optional)
                                printDoc.PrinterSettings.Copies = 1;

                                // Print the document
                                printDoc.Print();
                            }
                        }
                        else
                        {
                            throw new Exception($"Failed to get PDF data. Status code: {response.StatusCode}");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "API Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Console.WriteLine(ex.Message);
                }
            }
            else
            {
                Console.WriteLine("ID HOA DON IF NOT FOUND");
            }
        }
    }
}
