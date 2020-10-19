using System;

namespace Programming_Assignment_2
{
    class PaymentCalculatorApp
    {
        static void Main(string[] args)
        {
            Display();
        }
        
        public static void Display()
        {
            double interestRateInput = GetYearlyInterestRate();
            double principleInput = GetLoanPrinciple();
            DisplayPaymentOption(3, interestRateInput, principleInput);
            DisplayPaymentOption(4, interestRateInput, principleInput);
            DisplayPaymentOption(5, interestRateInput, principleInput);


            //This method will be called by the main method.
            //It will print out the monthly payment,
            //total amount paid for 3, 4, 5 year loan options.
            //Calls calculation methods 3 times to provide years, interest, and principal
        }

        public static void DisplayPaymentOption(double loanTerm, double interestRate, double principle)
        {
           double totalPayout = CalculateTotalPayout(loanTerm, interestRate, principle);
           double calculatedMonthlyPayment = CalculateMonthlyLoanPayment(interestRate, principle, loanTerm);
           Console.WriteLine(
               "The total amount of your loan with interest is {0:C} for " + loanTerm + " years.", totalPayout);
           Console.WriteLine("Your monthly payment is {0:C} for " + loanTerm + " years.", calculatedMonthlyPayment);

        }

        public static double GetYearlyInterestRate()
        {
            //Take user input of yearly interest rate and returns a double representing percentage as a decimal.
            Console.WriteLine("Please Enter the Yearly Interest Rate, e.g. 50 for 50%, : ");
            double interestRate = (Double.Parse(Console.ReadLine())/100);
            //Console.WriteLine("The interest rate for your loan is: {0:P}", interestRate);
            return interestRate;
        }

        public static double GetLoanPrinciple()
        {
            //Prompts user to enter amount of the loan without formatting and returns a double
            Console.WriteLine("Please Enter the Amount of the Loan, e.g. 1000 for $1000.00");
            double principle = Double.Parse(Console.ReadLine());
            //Console.WriteLine("The principle of your loan is: {0:C}", principle);
            return principle;
        }

        public static double CalculateMonthlyLoanPayment(in double interestRate, in double principle, in double years)
        {
            //input parameters are interest rate, principle, and terms.
            //Calculate monthly payment needed.
            double monthlyPayment = ((interestRate / 12) * principle) / (1 -  Math.Pow((1 + (interestRate / 12)), -(years * 12)));
            //Console.WriteLine("Your monthly payment is {0:C} for " + years + " years.", monthlyPayment);
            return monthlyPayment;


        }
        
        
        //unnecessary method intentionally left in as an optional feature of the program.
        public static double CalculateYearlyPayment(in double interestRate, in double years, in double principle)
        {
            //calcualtes the yearly payment by multiplying the monthly payment by 12.
            double yearlyPayment =
                ((interestRate / 12) * principle) / (1 - Math.Pow((1 + (interestRate / 12)), -(years * 12))) * 12;
            //Console.WriteLine("Your yearly payment is {0:C} for " + years + " years.", yearlyPayment);
            return yearlyPayment;
        }

        public static double CalculateTotalPayout(in double years, in double interestRate, in double principle)
        {
            //input parameters are interest rate, number of years, and principle.
            //calculates and returns the total payout corresponding to its input parameters
            double totalAmount = principle * (1 + (interestRate * years));
            //Console.WriteLine("The total amount of your loan with interest is {0:C} for " + years + " years.", totalAmount);
            return totalAmount;
        }
        
    }
}