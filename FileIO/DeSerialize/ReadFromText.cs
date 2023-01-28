namespace FileIO.Convert
{
    public class ReadFromText
    {
        public static void ReadText()
        {

            using (StreamReader sr = File.OpenText("document.txt"))
            {
                string input = null;

                while ((input = sr.ReadLine()) != null)
                {
                    Console.WriteLine($"\n {input}");
                }
            }
        }
        /* public static void ReadFromTxt()
         {
             if (File.Exists("document.txt"))
             {
                 string text = File.ReadAllText("document.txt");
                 Console.WriteLine($"\n\nTEXT format: {text}");
             }
             else
             {
                 Console.WriteLine("document.txt not found");
             }

         }*/
    }
}
