using FileIO.Convert;
using FileIO.DeSerialize;
using FileIO.Serialize;

namespace FileIO
{
    public static class Utility
    {


        private static int _choice;
        private static int _choicer;
        public static void ShowMenu()
        {
            Console.WriteLine("Menu\n 1. Write to File \n 2.Read File to Console\n 3.Write to JSON" +
                "\n 4.Read json to Console\n 5.Write to Pdf \n 6. Read Pdf to Console " +
                "\n 7. Write to CSV \n 8. Read CSV \n 9. Write To XML\n 10.Read To XML ");
        }


        public static void ChooseAction()
        {

            ShowMenu();


        attempt: Console.WriteLine("\nPlease enter an option:");



            try
            {

                _choice = int.Parse(Console.ReadLine());


                switch (_choice)
                {
                    case 1:

                        Console.Clear();

                        WriteToText.CreateText();

                        goto nextattempt;


                        break;

                    case 2:

                        Console.Clear();

                        ReadFromText.ReadText();

                        goto nextattempt;

                        

                    case 3:
                        Console.Clear();
                        JsonDoc.GetWriteToJson();
                        Console.WriteLine("Successfully created a  JSON file...");
                        Thread.Sleep(1000);
                        goto nextattempt;
                        break;

                    case 4:
                        Console.Clear();
                        ReadJson.ReadJsonConsole();
                        goto nextattempt;
                        break;
                    case 5:
                        Console.Clear();
                        Console.WriteLine("Successfully created a  PDF file...");
                        WritePdf.WriteTxtToPdf();
                        goto nextattempt;
                        break;
                    case 6:
                        Console.Clear();
                        ReadPdf.ReadPdfToTxt();
                        goto nextattempt;
                        break;
                    case 7:
                        Console.Clear();
                        Console.WriteLine("Successfully created a  CSV file...");
                        WriteCsv.WriteTxtToCsv();
                        goto nextattempt;
                        break;
                    case 8:
                        Console.Clear();
                        ReadCsv.ReadCsvTxt();
                        goto nextattempt;
                        break;
                    case 9:
                        Console.Clear();
                        Console.WriteLine("Successfully created a  XML file...");
                        WriteCsv.WriteTxtToCsv();
                        goto nextattempt;
                        break;
                    case 10:
                        Console.Clear();
                        ReadXml.ReadXmlTxt();
                        goto nextattempt;
                        break;
                    case 0:

                        Environment.Exit(0);

                        break;

                    default:

                        Console.WriteLine("Invalid entry, please try again!!!");

                        goto attempt;


                        break;


                }

            }
            catch
            {
                Console.WriteLine("Invalid entry, please try again!!!");

                goto attempt;

            }

            Console.WriteLine("\nDo you wish to continue");

        nextattempt: Console.WriteLine("\n press 1 to exit or 2 to continue");

            try
            {
                _choicer = int.Parse(Console.ReadLine());

                switch (_choicer)
                {
                    case 1:

                        Environment.Exit(0);

                        break;

                    case 2:
                        Console.Clear();

                        ShowMenu();

                        goto attempt;


                        break;


                    default:

                        Console.WriteLine("please enter a valid option");

                        goto nextattempt;


                        break;


                }

            }
            catch
            {
                Console.WriteLine("please enter a valid option");

                goto nextattempt;
            }

        }
    }
}
