using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pass_b_Reference_vs_Pass_by_value
{
    class Program
    {
        public static void Add(int n1, int n2 = 5)

        {

            int answer = n1 + n2;

            Console.WriteLine(answer);

        }

        static void Main(string[] args)

        {

            Add(5);

        }
        //static void Main(string[] args)
        //{

        //    // Pass by Value
        //    //int students1Grade = 75;
        //    //Console.WriteLine("Students grade before extra credit: {0}", students1Grade);
        //    //GiveExtraCredit(students1Grade);
        //    //Console.WriteLine("Students grade after extra credit {0}", students1Grade);

        //    // Pass by reference
        //    //int[] grades = new int[1];
        //    //grades[0] = 75;
        //    //Console.WriteLine("Students Array grade before extra credit {0}", grades[0]);
        //    //GiveExtraCreditArray(grades);
        //    //Console.WriteLine("Students Array grade after extra credit {0}", grades[0]);

        //    // ref and out Keyword ---------------------------------------
        //    //int studentGrade;
        //    //GiveExtraCredit(out studentGrade);
        //    //Console.WriteLine(studentGrade);

        //    int add;
        //    int mult;
        //    addAndMult(5, 10, out add, out mult);
        //    Console.WriteLine(add);
        //    Console.WriteLine(mult);


        //}

        ////public static void GiveExtraCredit(int studentsGrade)
        ////{
        ////    studentsGrade += 3;
        ////    Console.WriteLine("Students grade after extra credit inside function {0}", studentsGrade);
        ////}

        ////public static void GiveExtraCreditArray(int[] grades)
        ////{
        ////    grades[0] += 3;

        ////}

        //// ref and out keyword ---------------------------------------------
        ////public static void GiveExtraCredit(out int studentGrade)
        ////{
        ////    studentGrade = 0;
        ////    studentGrade += 3;

        ////}

        //public static void addAndMult(int a, int b, out int added, out int mult)
        //{
        //    added = a + b;
        //    mult = a * b;
        //}
    }
}
