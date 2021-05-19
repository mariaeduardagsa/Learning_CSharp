using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the amount of students in your class");
            int amountOfStudents = int.Parse(Console.ReadLine());

            double averageGrade = 0;
            double highestGrade = 0;
            string highestGradeName = "";


            string[] studentsNames = new string[amountOfStudents];
            double[] grades = new double[amountOfStudents]; 

            for(int i = 0; i < amountOfStudents; i++)
            {
                Console.WriteLine("Enter students #{0} name", i + 1);
                string name = Console.ReadLine();
                studentsNames[i] = name;
                Console.WriteLine("Enter students #{0} grade", i + 1);
                double grade = double.Parse(Console.ReadLine());
                grades[i] = grade;
                averageGrade += grade;

                if(grade > highestGrade)
                {
                    highestGrade = grade;
                    highestGradeName = name;
                }
            }

            // printing
            averageGrade = averageGrade / amountOfStudents;
            Console.WriteLine("The avearage grade of the class is {0}", averageGrade);
            Console.WriteLine("The highest grade of the class is {0} and their name was {1}", highestGrade, highestGradeName);




        }
    }
}
