using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace FileIO.DeSerialize
{
    public class ReadXml
    {
        public static void ReadXmlTxt()
        {
/*            XmlSerializer serializer = new XmlSerializer(typeof(string));
            using (FileStream fileStream = new FileStream("DocumentAttributes.xml", FileMode.Open))
            {
                string xmlString = (string)serializer.Deserialize(fileStream);
                Console.WriteLine(xmlString);
            }

            //3)     Deserialize to XML
            var xmlSerializer = new XmlSerializer(obj.GetType());
            using (var writer = new StringWriter())
            {
                xmlSerializer.Serialize(writer, obj);
                string xmlText = writer.ToString();
                Console.WriteLine("\n\nXML format: " + xmlText);
            }*/
        }
    }
}
