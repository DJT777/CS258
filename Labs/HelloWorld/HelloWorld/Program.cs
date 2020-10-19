using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = "Hi everyone, I hope you are enjoying the class";
            //25% off
            const int DISCOUNT_PERCENTAGE = 40;
            double price = 11.45;
            double discount = 11.45 * (DISCOUNT_PERCENTAGE / 100.0);
            double youPay = price - discount;
            string myStr = "Lookie here ";
            Console.WriteLine(myStr + youPay);
            Console.ReadKey();
            
        }
    }
}