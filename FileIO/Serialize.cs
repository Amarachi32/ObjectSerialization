using Newtonsoft.Json;
using System.Xml.Serialization;

namespace FileIO
{

    public class Serialize
    {

        public static void ReadFromTxt()
        {
            if (File.Exists("DocumentAttributes.txt"))
            {
                string text = File.ReadAllText("DocumentAttributes.txt");
                Console.WriteLine($"\n\nTEXT format: {text}");
            }
            else
            {
                Console.WriteLine("DocumentAttributes.txt not found");
            }

        }

        /*  public static void WriteToJSON()
          {

              try
              {
                  var options = new JsonSerializerOptions
                  {
                      IncludeFields = true,
                      WriteIndented = true
                  };
                  string txt = File.ReadAllText("DocumentAttributes.txt");
                  dynamic jsonObject = JsonConvert.DeserializeObject(txt);
                  string jsonText = JsonConvert.SerializeObject(jsonObject);
                  File.WriteAllText("DocumentAttributes.json", jsonText);

                  Console.WriteLine("\n\t JSON file created successfully!");
              }
              catch (Exception e)
              {
                  Console.WriteLine("\n\t An error occurred while writing to the JSON file: " + e.Message);
              }

          }*/
        public static void ReadJson()
        {
            string jsonString = File.ReadAllText("DocumentAttributes.json");

            dynamic jsonObject = JsonConvert.DeserializeObject(jsonString);

            Console.WriteLine(jsonObject.ToString());

        }
        /*       public static void WriteToXML()
               {

                   Console.WriteLine("converting text to xml");
                   string filePath = "DocumentAttributes.txt";
                   string text = File.ReadAllText(filePath);
                   XmlSerializer serializer = new XmlSerializer(typeof(string));

                   using (FileStream stream = File.OpenWrite("DocumentAttributes.xml"))
                   {
                       serializer.Serialize(stream, text);
                   }
               }*/
        public static void ReadXml()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(string));
            using (FileStream fileStream = new FileStream("DocumentAttributes.xml", FileMode.Open))
            {
                string xmlString = (string)serializer.Deserialize(fileStream);
                Console.WriteLine(xmlString);
            }
        }

    }
}
