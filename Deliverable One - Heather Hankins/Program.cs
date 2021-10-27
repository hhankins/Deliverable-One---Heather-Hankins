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
            Console.WriteLine("Please select a measurement type: Choose 1 for fidget spinners or choose 2 for memes ");
            int userSelection = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

                if (userSelection == 1)
                {
                    Console.WriteLine("Please input the number of units to convert from fidget spinners to inches: ");
                    double userInput2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine();
                    double totalUnits1 = userInput2 * 3.5;
                    Console.WriteLine(userInput2 + " fidget spinners is equal to " + totalUnits1 + " inches.");
                }

                else
                {
                    Console.WriteLine("Please input the number of units to convert from memes to feet: ");
                    double userInput3 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine();
                    double totalUnits2 = userInput3 * 5;
                    Console.WriteLine(userInput3 + " memes is equal to " + totalUnits2 + " feet. ");
                }

                Console.WriteLine("Would you like to perform another conversion? Choose 'Y' for yes and 'N' for no. ");
                string yOrN = Console.ReadLine();
 
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