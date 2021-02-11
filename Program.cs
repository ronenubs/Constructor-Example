using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentScholar ss = new StudentScholar("Metrobank", 95.0);
            ss.Lastname = "Enubs";
            ss.Firstname = "Ron";
            ss.Middlename = "Ibo";
            ss.Course = "BSIT";
            ss.Age = 39;
            ss.YearLevel = 4;

            Console.WriteLine(ss.Firstname + " " + ss.Middlename + " " + ss.Lastname + "\n" +
                "Couse-year: " + ss.Course + "-" + ss.YearLevel + "\n" +
                "Sponsor: " + ss.Sponsor + "\n" +
                "Maintaining Grade: " + ss.MaintainingGrade);

            Console.ReadLine();
        }

    }
}
