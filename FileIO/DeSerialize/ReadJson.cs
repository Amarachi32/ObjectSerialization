using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace FileIO.Convert
{
    public class ReadJson
    {
       public static void ReadJsonConsole()
        {
            try
            {
                if (!File.Exists("document.json"))
                {
                    Console.WriteLine("\n\t You need to write to JSON File, before reading as JSON file does not exists!\n");
                }

                string json = File.ReadAllText("document.json");

                var jsonData = JsonSerializer.Deserialize<dynamic>(json);
                Console.WriteLine(jsonData);

            }
            catch (Exception e)
            {
                Console.WriteLine("\n\t An error occurred while reading from the JSON file: " + e.Message);
            }
        }
    }
}
