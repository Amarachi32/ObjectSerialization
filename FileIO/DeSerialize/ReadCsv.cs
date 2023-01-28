using CsvHelper.Configuration;
using System.Globalization;
using System.Text;

namespace FileIO.DeSerialize
{
    public class ReadCsv
    {
        public static void ReadCsvTxt()
        {
            //2)   Deserialize to CSV
/*            var csvConfig = new CsvConfiguration(CultureInfo.CurrentCulture)
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
            }*/
        }
    }
}
