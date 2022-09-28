using System;

namespace GPACalculator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //printTable myTable = new printTable();
            //char grade = Convert.ToChar(Console.ReadLine());
            /*string course;
            int code = 0;
            int courseunit = 0;
            int weightpoint = 0; */
            //int gradeunit = 0;//this is value derived from the grade gotten.
            int score = 0;
            //char grade;
            //string remarks;
            int totalcourseunit = 0;
            int totalgradeunit = 0;
            int totalweightpoint = 0;
            //First of all, determine number of courses taken
            Console.WriteLine("Please enter the total number of courses");
            int totalCourses = Convert.ToInt32(Console.ReadLine());

            //Create arrays that will be used to store the data collected.
            string[] remarks = new string[totalCourses];
            string[] mycourse = new string[totalCourses];
            int[] mycode = new int[totalCourses];
            int[] mycourseunit = new int[totalCourses];
            char[] grade = new char[totalCourses];
            int[] gradeunit = new int[totalCourses];
            int[] myweightpoint = new int[totalCourses];

            for (int i = 0; i < totalCourses; i++)
            {
                Console.WriteLine("Enter your course name: ");
                mycourse[i] = Console.ReadLine();
                Console.WriteLine("Enter your course code: ");
                mycode[i] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter your course unit: ");
                mycourseunit[i] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter your course score: ");
                score = Convert.ToInt32(Console.ReadLine());


                if (score >= 70)
                {
                    grade[i] = 'A';
                    gradeunit[i]= 5;
                    remarks[i] = "Excellent";

                }
                else if (score >= 60 && score <= 69)
                {
                    grade[i] = 'B';
                    gradeunit[i] = 4;
                    remarks[i] = "Very Good";
                }
                else if (score >= 50 && score <= 59)
                {
                    grade[i] = 'C';
                    gradeunit[i]= 3;
                    remarks[i] = "Good";
                }
                else if (score >= 45 && score <= 49)
                {
                    grade[i] = 'D';
                    gradeunit[i] = 2;
                    remarks[i] = "Fair";
                }
                else if (score >= 40 && score <= 44)
                {
                    grade[i] = 'E';
                    gradeunit[i] = 1;
                    remarks[i] = "Pass";
                }
                else if (score >= 0 && score <= 39)
                {
                    grade[i] = 'F';
                    gradeunit[i] = 0;
                    remarks[i] = "Fail";
                }


                myweightpoint[i]= gradeunit[i] * mycourseunit[i];

                

            }

            printTable display = new printTable();

            display.output(totalCourses, mycourse,  mycode,   mycourseunit,  grade,   gradeunit,
              myweightpoint,  remarks,totalcourseunit,  totalgradeunit,   totalweightpoint);
            /*

            Console.WriteLine("|--------------------|--------------------|---------------|-------------------|--------------------|--------------------|\n" +
                "| COURSE & CODE      | COURSE UNIT        | GRADE         | GRADE UNIT        | WEIGHT PT.         | REMARK             |\n" +
                "|--------------------|--------------------|---------------|-------------------|--------------------|--------------------|");
            for(int a =0; a<totalCourses; a++)
            {
                Console.WriteLine("| " + mycourse[a]+""+ mycode[a] + "             |          " + mycourseunit[a] + "         |   " + grade[a] + "           |       "+ gradeunit[a] +
                    "           |     "+ myweightpoint[a] + "             |   "+ remarks[a]+"        |");
            }
           

            Console.WriteLine("|--------------------|--------------------|---------------|-------------------|--------------------|--------------------|");


            for(int i =0; i<mycourseunit.Length; i++)
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
            Console.WriteLine("Total GPA is = " + GPA.ToString("0.00")) ;

            */
        }
    }
}



