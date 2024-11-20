using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Month_Days_Identifier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Prompt the user to enter a year
            Console.Write("Enter a year: ");
            int year = Convert.ToInt32(Console.ReadLine());

            // Prompt the user to enter a month number
            Console.Write("Enter a month number (1-12): ");
            int month = Convert.ToInt32(Console.ReadLine());

            // Determine if the year is a leap year
            bool isLeapYear = (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);

            // Use switch case to display the number of days in the given month
            switch (month)
            {
                case 1: // January
                    Console.WriteLine("January has 31 days.");
                    break;
                case 2: // February
                    if (isLeapYear)
                    {
                        Console.WriteLine("February has 29 days (leap year).");
                    }
                    else
                    {
                        Console.WriteLine("February has 28 days.");
                    }
                    break;
                case 3: // March
                    Console.WriteLine("March has 31 days.");
                    break;
                case 4: // April
                    Console.WriteLine("April has 30 days.");
                    break;
                case 5: // May
                    Console.WriteLine("May has 31 days.");
                    break;
                case 6: // June
                    Console.WriteLine("June has 30 days.");
                    break;
                case 7: // July
                    Console.WriteLine("July has 31 days.");
                    break;
                case 8: // August
                    Console.WriteLine("August has 31 days.");
                    break;
                case 9: // September
                    Console.WriteLine("September has 30 days.");
                    break;
                case 10: // October
                    Console.WriteLine("October has 31 days.");
                    break;
                case 11: // November
                    Console.WriteLine("November has 30 days.");
                    break;
                case 12: // December
                    Console.WriteLine("December has 31 days.");
                    break;
                default:
                    Console.WriteLine("Invalid month number. Please enter a number between 1 and 12.");
                    break;
            }
        }
    }
}
