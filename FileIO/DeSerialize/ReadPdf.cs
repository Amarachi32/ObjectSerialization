using iTextSharp.text.pdf;
using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iTextSharp.text.pdf.parser;

namespace FileIO.Convert
{
    public class ReadPdf
    {
        public static void ReadPdfToTxt()
        {
            using (PdfReader reader = new PdfReader("document.pdf"))
            {
                StringBuilder text = new StringBuilder();

                for (int i = 1; i <= reader.NumberOfPages; i++)
                {
                    text.Append(PdfTextExtractor.GetTextFromPage(reader, i));
                }
                Console.WriteLine(text.ToString());
            }
        }
    }
}
