using System;
using System.Linq;


namespace GPACalculator
{
    public class printTable
    {
        public void output(int totalCourses, string[] mycourse, int[] mycode, int[] mycourseunit, char[] grade, int[] gradeunit, int[] myweightpoint, string[] remarks, int totalcourseunit, int totalgradeunit, int totalweightpoint)


        {

            
            
            
            Console.WriteLine("|-----------------------|-----------------------|---------------|--------------------|-----------------------|-----------------------|\n" +
               "| COURSE & CODE\t\t| COURSE UNIT\t\t| GRADE\t\t| GRADE UNIT\t\t| WEIGHT PT\t\t| REMARK \t\t|\n" +
               "|-----------------------|-----------------------|---------------|--------------------|-----------------------|-----------------------|\n");
            for (int a = 0; a < totalCourses; a++)
            {
                Console.WriteLine("| " + mycourse[a] + "" + mycode[a] + "\t\t| " + mycourseunit[a] + "\t\t\t| " + grade[a] + " \t\t|" + gradeunit[a] + "                   | " + myweightpoint[a] + " \t\t\t|" + remarks[a] + " \t\t\t|");

            }


            Console.WriteLine("|-----------------------|-----------------------|---------------|--------------------|-----------------------|-----------------------|\n");

            
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

