using iTextSharp.text.pdf;
using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIO.Convert
{
    public class ReadPdf
    {
        public static void ReadPdfToTxt()
        {
            //5)     Deserialize to PDF
/*            using (var stream = new MemoryStream())
            {
                Document pdfDoc = new Document();
                PdfWriter.GetInstance(pdfDoc, stream).CloseStream = false;
                pdfDoc.Open();
                pdfDoc.Add(new Paragraph(json.ToString()));
                pdfDoc.Close();
                stream.Position = 0;
                byte[] pdfContent = stream.ToArray();
                Console.WriteLine("\n\nPDF format: " + pdfContent);
                // Console.WriteLine(File.ReadAllText("object.pdf"));
            }*/
        }
    }
}
