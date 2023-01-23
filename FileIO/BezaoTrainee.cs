using DocumentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIO
{
    [Document("A Software Engineering program ", Input = "C-sharp and Angular", Output = "None")]
    public class BezaoTrainee
    {
        [Document("Student's Age")]
        public int _age;
        [Document("Student's FullName")]
        public string FullName { get; set; }

        public string Address { get; set; }

        public BezaoTrainee(string fullname, string address)
        {
            FullName = fullname;
            Address = address;
        }
        [Document("Details of Student for the program", Input = "course outline", Output = "None")]
        public BezaoTrainee()
        {

        }

        [Document("what student sreams", "GodAbeg", "Project on Console app")]
        public string StudentsAction(string fullname)
        {
            return $"{FullName} screams {Scream.HeyGod}";
        }


    }
    [Document("this is what trainee screams", "Omo!")]
    public enum Scream
    {
        Omo = 1,
        HeyGod,
        GodAbeg,
        OhShit,
    }
}
