using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_Example
{
    public class Student
    {
        private string lastname, firstname, middlename;
        private int age;
        private int yearLevel;
        private string course;

        public Student()
        {
        }

        //Constructor Overloading
        public Student(string lastname, string firstname, string middlename, int age, int yearLevel, string course)
        {
            this.lastname = lastname;
            this.firstname = firstname;
            this.middlename = middlename;
            this.age = age;
            this.yearLevel = yearLevel;
            this.course = course;
        }

        ~Student()
        {
            Console.WriteLine("The object of Student is destroyed.");
        }

        public string Lastname { get => lastname; set => lastname = value; }
        public string Firstname { get => firstname; set => firstname = value; }
        public string Middlename { get => middlename; set => middlename = value; }
        public int Age { get => age; set => age = value; }
        public int YearLevel { get => yearLevel; set => yearLevel = value; }
        public string Course { get => course; set => course = value; }
    }
}
