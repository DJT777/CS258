using System;

/* 
     Programmer:  Dylan Tussey
     Date:               9/3/2020
     Description:    This program calculates the total sales, net sales and commission amounts 
                             for a computer club candy sale.
*/


namespace Assignment1
{
    class CandySales
    {
        static void Main(string[] args)
        {
            const double salePrice = 0.75;
            const double caseCost = 5.00;
            const int barsPerCase = 12;
            const double commissionRate = .10;

            
            Console.WriteLine("Please enter the name of your club: ");
            string clubName = Console.ReadLine();
            Console.WriteLine("Please enter the number of cases sold: ");
            double casesSold = Convert.ToInt32(Console.ReadLine());
            
            double calculatedSales = casesSold * barsPerCase * salePrice;
            double calculatedCost = (casesSold * caseCost);
            double commission = (calculatedSales - calculatedCost) * commissionRate;
            double netProceeds = (calculatedSales - calculatedCost - commission);

            Console.WriteLine("The USI computer club produced {0:C} from their candy sales project", calculatedSales);
            Console.WriteLine("The total cost of the candy was {0:c}", calculatedCost);
            Console.WriteLine("The student government commission amount was {0:c}", commission);
            Console.WriteLine("The net proceeds was {0:C}", netProceeds);

        }
    }
}