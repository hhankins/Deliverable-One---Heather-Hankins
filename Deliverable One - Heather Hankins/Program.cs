using System;

namespace Deliverable_One___Heather_Hankins
{
    class Program
    {
        static void Main(string[] args)
        {
            bool anotherConversion = true;

            Console.WriteLine("Welcome! This program will allow you to convert MilHip units into Imperial units.");
            Console.WriteLine();

            do
            {
            Console.WriteLine("Please select a measurement type: Choose 1 for fidget spinners, 2 for memes, 3 for inches, or 4 for feet. ");
            int userSelection = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

                if (userSelection == 1)
                {
                    Console.WriteLine("Please input the number of units to convert from fidget spinners to inches: ");
                    double userInput2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine();
                    double totalUnits1 = userInput2 * 3.5;
                    Console.WriteLine(userInput2 + " fidget spinners is equal to " + totalUnits1 + " inches.");
                    Console.WriteLine();
                }

                else if (userSelection == 2)
                {
                    Console.WriteLine("Please input the number of units to convert from memes to feet: ");
                    double userInput3 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine();
                    double totalUnits2 = userInput3 * 5;
                    Console.WriteLine(userInput3 + " memes is equal to " + totalUnits2 + " feet. ");
                    Console.WriteLine();
                }

                else if (userSelection == 3)
                {
                    Console.WriteLine("Please input the number of units to convert from inches to fidget spinners: ");
                    double userInput4 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine();
                    double totalUnits3 = userInput4 / 3.5;
                    Console.WriteLine(userInput4 + " inches is equal to " + totalUnits3 + " fidget spinners. ");
                    Console.WriteLine();
                }

                else if (userSelection == 4)
                {
                    Console.WriteLine("Please input the number of units to convert from feet to memes: ");
                    double userInput5 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine();
                    double totalUnits4 = userInput5 / 5;
                    Console.WriteLine(userInput5 + " feet is equal to " + totalUnits4 + " memes. ");
                    Console.WriteLine();
                }

                Console.WriteLine("Would you like to perform another conversion? Choose 'Y' for yes and 'N' for no. ");
                string yOrN = Console.ReadLine();
                Console.WriteLine();
 
                if (yOrN.ToUpper() == "Y")
                {
                    anotherConversion = true;
                }
                else
                {
                    anotherConversion = false;
                }
            } while (anotherConversion);
        }
    }
}