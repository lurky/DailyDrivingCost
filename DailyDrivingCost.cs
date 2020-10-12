using System;
/*
Michael Wood and Jonathan Winston
10/07/2020
Research several car-pooling websites. Write an app that calculates your daily driving cost, so that you can estimate how
much money could be saved by carpooling, which also has other advantages such as reducing carbon emissions and reducing
traffic congestion. The app should input the following information and display the user’s cost per day of driving to work:

Total miles driven per day.
Cost per gallon of gasoline (in cents).
Average miles per gallon.
Parking fees per day (in cents).
Tolls per day (in cents).
Call the program DailyDrivingCost

Hint:

Be sure to get cost per mile and use that to get the daily driving cost.
 */

namespace CIS214
{
    class DailyDrivingCost
    {
        static void Main(string[] args)
        {
            //Declarations
            int totalMiles;
            int costPerMile;
            int costPerGal;
            int milePerGal;
            int parkingFees;
            int tollCost;
            decimal dailyDrivingCost;

      
            //Prompt for total daily miles
            Console.WriteLine("Enter your total daily miles: ");

            //Input total miles
           totalMiles = Convert.ToInt32(Console.ReadLine());

            //Prompt for cost per gal
            Console.WriteLine("Enter cost per gallon of gasoline in cents: ");

            //Input cost per gal
            costPerGal = Convert.ToInt32(Console.ReadLine());

            //Prompt for mpg
            Console.WriteLine("Enter your average miles per gallon: ");

            //Input mpg
            milePerGal = Convert.ToInt32(Console.ReadLine());

            //Prompt for Parking fees
            Console.WriteLine("Enter your parking fees in cents: ");

            //Input Parking Fees
           parkingFees = Convert.ToInt32(Console.ReadLine());

            //Prompt for toll cost
            Console.WriteLine("Enter your toll cost in cents: ");

            //Input toll cost
            tollCost= Convert.ToInt32(Console.ReadLine());

            //calculation
            costPerMile = costPerGal / milePerGal ;

            dailyDrivingCost = ((costPerMile * totalMiles) + parkingFees + tollCost)/100M;
           

            //output
            Console.WriteLine($"Your total daily driving cost is ${dailyDrivingCost}");
            Console.WriteLine($"You could save money by carpooling.");
        }//End Main
    }//End Class Printing
}//End Namespace
