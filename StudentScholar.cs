using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_Example
{
    public class StudentScholar : Student
    {
        private string sponsor;
        private double maintainingGrade;

        public StudentScholar(string sponsor, double maintainingGrade)
            :base()
        {
            this.Sponsor = sponsor;
            this.MaintainingGrade = maintainingGrade;
        }

        public string Sponsor { get => sponsor; set => sponsor = value; }
        public double MaintainingGrade { get => maintainingGrade; set => maintainingGrade = value; }
    }
}
