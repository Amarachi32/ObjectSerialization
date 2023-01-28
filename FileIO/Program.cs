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
            Utility.ChooseAction();
        }
    }
}