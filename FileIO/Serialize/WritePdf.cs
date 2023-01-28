using iTextSharp.text.pdf;
using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIO.Serialize
{
    public class WritePdf
    {
        public static void WriteTxtToPdf()
        {
            string documentation = TextDocs.GetDocs();

            //create a pdf file and write to it

            using (FileStream fs = new FileStream("document.pdf", FileMode.Create))
            {
                using (Document doc = new Document())
                {
                    using (PdfWriter writer = PdfWriter.GetInstance(doc, fs))
                    {
                        doc.Open();

                        doc.Add(new Paragraph(documentation));

                        doc.Close();


                    }
                }

            }
        }
    }
}
