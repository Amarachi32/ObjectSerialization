using CsvHelper;
using CsvHelper.Configuration;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Newtonsoft.Json;
using System.Globalization;
using System.Text;
using System.Xml.Serialization;

namespace FileIO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**********************Software Engineering Documentation***************************");
            // ReflectionDocs.GetDocs();
            BezaoTrainee obj = new BezaoTrainee { FullName = "John", Address = "centenery" };

            //1)     Deserialize to JSON
            string json = JsonConvert.SerializeObject(obj);
            Console.WriteLine("\nJSON format: " + json);

            //2)   Deserialize to CSV
            var csvConfig = new CsvConfiguration(CultureInfo.CurrentCulture)
            {
                HasHeaderRecord = true,
                Delimiter = ",",
                Encoding = Encoding.UTF8,
                Comment = '@',
                AllowComments = true,
                TrimOptions = TrimOptions.Trim,
                IgnoreBlankLines = true,
            };
            using (var writer = new StringWriter())
            using (var csv = new CsvWriter(writer, csvConfig))
            {
                csv.WriteRecord(obj);
                csv.Flush();
                string csvText = writer.ToString();
                Console.WriteLine("\n\nCSV format: " + csvText);
            }

            //3)     Deserialize to XML
            var xmlSerializer = new XmlSerializer(obj.GetType());
            using (var writer = new StringWriter())
            {
                xmlSerializer.Serialize(writer, obj);
                string xmlText = writer.ToString();
                Console.WriteLine("\n\nXML format: " + xmlText);
            }
            //4)    Deserialize to TxT file
            string sw = json;
            File.WriteAllText("object.txt", sw.ToString());
            Console.WriteLine($"\n\nTEXT format:{ File.ReadAllText("object.txt")}");

            //5)     Deserialize to PDF
            using (var stream = new MemoryStream())
            {
                Document pdfDoc = new Document();
                PdfWriter.GetInstance(pdfDoc, stream).CloseStream = false;
                pdfDoc.Open();
                pdfDoc.Add(new Paragraph(json.ToString()));
                pdfDoc.Close();
                stream.Position = 0;
                byte[] pdfContent = stream.ToArray();
                Console.WriteLine("\n\nPDF format: " + pdfContent);
                Console.WriteLine(File.ReadAllText("object.pdf"));
            }
        }
    }
}