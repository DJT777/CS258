using System;

namespace CS258MethodsProgram1
{
    class MethodsLectureProgram1
    {
        static void Main(string[] args)
        {
            int number = MethodsLectureProgram1.EnterChoice();
            Console.WriteLine("You chose the number " + number + ". Thank you for your input.");


        }

        public static int EnterChoice()
        {
            Console.WriteLine("Please Enter an Integer: ");
            string userInputString = Console.ReadLine();
            int userInputInteger = Convert.ToInt32(userInputString);
            return userInputInteger;
        }
    }
}