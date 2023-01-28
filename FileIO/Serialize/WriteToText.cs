namespace FileIO.Serialize
{
    public class WriteToText
    {
        public static void CreateText()
        {
            Console.WriteLine("************ Reading Documentation To Text ********\n\n");


            string documentation = TextDocs.GetDocs();
            //File.WriteAllLines("document.txt", FileMode.OpenOrCreate);
            Console.WriteLine("read");
            using (StreamWriter writer = new StreamWriter("document.txt"))
            {
                writer.Write(documentation);
            }
        }
         
    }

}
