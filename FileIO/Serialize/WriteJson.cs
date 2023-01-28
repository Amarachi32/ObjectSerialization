using System.Text.Json;

namespace FileIO.Serialize
{
    public class WriteJson
    {


        public static void WriteToJson(object objGraph, string fileName)
        {
            var options = new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                IncludeFields = true,
                WriteIndented = true
            };

            File.WriteAllText(fileName, JsonSerializer.Serialize(objGraph, options));
        }
    }
}
