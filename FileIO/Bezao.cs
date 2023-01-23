using DocumentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIO
{
    [Document("A Program Organised for Enthusiastic Developers")]
    public class Bezao
    {
        // [Document("desciption =  this gets and sets bezao cohort") ]
        [Document("C-Sharp Training", Input = "C-sharp and Angular", Output = "None")]
        public string Cohort { get; set; }


        // [Document("3.0"), Input = "it initializes bezao with cohort", input = "it takes a cohort as a string"]
        [Document("Cohort 3.0.1 for the set 2022/2023")]
        public Bezao(string cohort)
        {
            Cohort = cohort;
        }
    }
}
