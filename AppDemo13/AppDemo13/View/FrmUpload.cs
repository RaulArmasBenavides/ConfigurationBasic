using AppDemo13.Common;
using GemBox.Spreadsheet;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppDemo13.View
{
    public partial class FrmUpload : Form
    {
        public FrmUpload()
        {
            InitializeComponent();
   
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            System.Uri url = new System.Uri("http://localhost:17476/ProductRESTService.svc/UploadImage");
            string filePath = @"C:\Users\raula\OneDrive - BW2 Technologies AG\Pictures\fuego.png";

            // Set license key to use GemBox.Spreadsheet in Free mode.
            SpreadsheetInfo.SetLicense("FREE-LIMITED-KEY");

            // Create a new empty Excel file.
            var workbook = new ExcelFile();

            // Create a new worksheet and set cell A1 value to 'Hello world!'.
            workbook.Worksheets.Add("Sheet 1").Cells["A1"].Value = "Hello world!";
            workbook.Worksheets[0].Cells["A2"].Value = "Z1";
            workbook.Worksheets[0].Cells["A3"].Value = "Z2";
            workbook.Worksheets[0].Cells["A4"].Value = "Z3";
            workbook.Worksheets[0].Cells["A5"].Value = "Z4";
            workbook.Worksheets[0].Cells["A6"].Value = "Z5";
            workbook.Worksheets[0].Cells["A7"].Value = "Z6";
            workbook.Worksheets[0].Cells["A8"].Value = "Z7";
            workbook.Worksheets[0].Cells["A9"].Value = "Z8";
            workbook.Worksheets[0].Cells["A10"].Value = "Z9";
            workbook.Worksheets[0].Cells["A11"].Value = "Z10";
            workbook.Worksheets[0].Cells["A12"].Value = "Z11";
            workbook.Worksheets[0].Cells["A13"].Value = "Z12";

            workbook.Worksheets[0].Cells["B2"].Value = "1000";
            workbook.Worksheets[0].Cells["B3"].Value = "1000";
            workbook.Worksheets[0].Cells["B4"].Value = "1000";
            workbook.Worksheets[0].Cells["B5"].Value = "1000";
            workbook.Worksheets[0].Cells["B6"].Value = "1000";
            workbook.Worksheets[0].Cells["B7"].Value = "1000";
            workbook.Worksheets[0].Cells["B8"].Value = "1000";
            workbook.Worksheets[0].Cells["B9"].Value = "1000";
            workbook.Worksheets[0].Cells["B10"].Value = "1000";
            workbook.Worksheets[0].Cells["B11"].Value = "1000";
            workbook.Worksheets[0].Cells["B12"].Value = "1000";
            workbook.Worksheets[0].Cells["B13"].Value = "1000";
            // Save to XLSX file.
            workbook.Save("Spreadsheet.xlsx");

            // Load an Excel file into the ExcelFile object.
            var workbook2 = ExcelFile.Load("Spreadsheet.xlsx");

            // Create image save options.
            var imageOptions = new ImageSaveOptions(ImageSaveFormat.Png)
            {
                PageNumber = 0, // Select the first Excel page.
                Width = 1240, // Set the image width.
                CropToContent = true // Export only the sheet's content.
            };

            // Save the ExcelFile object to a PNG file.
            workbook2.Save(filePath, imageOptions);

            //Helper2.CreatingImageTest(filePath);
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Accept = "application/octet-stream";
            request.Method = "POST";
            request.ContentType = "image/jpeg";
            using (Stream fileStream = File.OpenRead(filePath))
            using (Stream requestStream = request.GetRequestStream())
            {
                int bufferSize = 1024;
                byte[] buffer = new byte[bufferSize];
                int byteCount = 0;
                while ((byteCount = fileStream.Read(buffer, 0, bufferSize)) > 0)
                {
                    requestStream.Write(buffer, 0, byteCount);
                }
            }
            string result;
            using (WebResponse response = request.GetResponse())
            using (StreamReader reader = new StreamReader(response.GetResponseStream()))
            {
                result = reader.ReadToEnd();
            }
        }
    }
}
