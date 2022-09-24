using System;
using System.Linq;

namespace GPACalculator
{
    public class printTable
    {
        public void output(int totalCourses, string[] mycourse, int[] mycode, int[] mycourseunit, char[] grade, int[] gradeunit, int[] myweightpoint, string[] remarks, int totalcourseunit, int totalgradeunit, int totalweightpoint)


        {


            Console.WriteLine("|--------------------|--------------------|---------------|-------------------|--------------------|--------------------|\n" +
                "| COURSE & CODE      | COURSE UNIT        | GRADE         | GRADE UNIT        | WEIGHT PT.         | REMARK             |\n" +
                "|--------------------|--------------------|---------------|-------------------|--------------------|--------------------|");
            for (int a = 0; a < totalCourses; a++)
            {
                Console.WriteLine("| " + mycourse[a] + "" + mycode[a] + "             |          " + mycourseunit[a] + "         |   " + grade[a] + "           |       " + gradeunit[a] +
                    "           |     " + myweightpoint[a] + "             |   " + remarks[a] + "        |");
            }


            Console.WriteLine("|--------------------|--------------------|---------------|-------------------|--------------------|--------------------|");


            for (int i = 0; i < mycourseunit.Length; i++)
            {
                totalcourseunit += mycourseunit[i];
            }

            for (int i = 0; i < gradeunit.Length; i++)
            {
                totalgradeunit += gradeunit[i];
            }

            for (int i = 0; i < myweightpoint.Length; i++)
            {
                totalweightpoint += myweightpoint[i];
            }

            Console.WriteLine("Total Course Unit Registered is " + totalcourseunit);
            Console.WriteLine("Total Course Unit Passed is " + totalgradeunit);
            Console.WriteLine("Total Weight Point is " + totalweightpoint);

            double GPA = ((double)totalweightpoint / totalcourseunit);
            Console.WriteLine("Total GPA is = " + GPA.ToString("0.00"));


        }

        
    }
}

