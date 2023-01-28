using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace FileIO.Serialize
{
    public class WriteXml
    {
        public static void WriteToXML()
        {

            Console.WriteLine("converting text to xml");
            string filePath = "DocumentAttributes.txt";
            string text = File.ReadAllText(filePath);
            XmlSerializer serializer = new XmlSerializer(typeof(string));

            using (FileStream stream = File.OpenWrite("DocumentAttributes.xml"))
            {
                serializer.Serialize(stream, text);
            }
        }
    }
}
