 using System;

namespace CS_ASP_26

{
    class Program
    {
        static void Main(string[] args)
        {

            // Create First Student

            Student FirstStudent = new Student();

            // Get Student Info

            FirstStudent.StudentNum = AskForStudentNumber();
            FirstStudent.StudentFirstName = AskForStudentName("First");
            FirstStudent.StudentLastName = AskForStudentName("Last");
            FirstStudent.Major = AskForMajor(FirstStudent.StudentFirstName);
            FirstStudent.Score1 = AskForExamScore(1);
            FirstStudent.Score2 = AskForExamScore(2);
            FirstStudent.Score3 = AskForExamScore(3);

            Console.Clear();
            Console.WriteLine("First Student");
            Console.WriteLine(FirstStudent.ToString());

            Console.WriteLine("Press any key to end");
            Console.ReadKey(); 
        }

        private static int AskForStudentName(int whichOne)
        {

            String inValue;
            Console.WriteLine("Enter Students {0} Name :", whichOne);
            inValue = Console.ReadLine();
            return inValue;

        }

        private static string AskForMajor(string studentFirstName)
        {
            string inVlaue;
            Console.WriteLine("Enter {0}\'s Major :", studentFirstName);
            inVlaue = Console.ReadLine();
            return inValue;


        }

        private static string AskForStudentNumber()
        {

            string inValue;
            Console.WriteLine("Enter Student ID Number :");
            inValue = Console.ReadLine();
            return inVaue;

        }
        // Need to finish the video time 16:56 for video







    }
}
