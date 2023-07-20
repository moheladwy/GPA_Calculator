using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace GPA_Calculator_Library.Models
{
    public enum Grades
    {
        APlus,
        A,
        BPlus,
        B,
        CPlus,
        C,
        DPlus,
        D,
        F,
    }

    public class GradesProcessor
    {
        public static string ToString(Grades grade)
        {
            if (grade == Grades.APlus)
                return "A+";
            else if (grade == Grades.A)
                return "A";
            else if (grade == Grades.BPlus)
                return "B+";
            else if (grade == Grades.B)
                return "B";
            else if (grade == Grades.CPlus)
                return "C+";
            else if (grade == Grades.C)
                return "C";
            else if (grade == Grades.DPlus)
                return "D+";
            else if (grade == Grades.D)
                return "D";
            else
                return "F";
        }

        public static double GetGPA(string grade)
        {
            if (grade == "A+")
                return 4;
            else if (grade == "A")
                return 3.7;
            else if (grade == "B+")
                return 3.3;
            else if (grade == "B")
                return 3;
            else if (grade == "C+")
                return 2.7;
            else if (grade == "C")
                return 2.4;
            else if (grade == "D+")
                return 2.2;
            else if (grade == "D")
                return 2;
            else
                return 0;
        }
    }
}
