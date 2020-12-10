using System;

namespace Task_003
{
    class Program
    {
        static void Main(string[] args)
        {
            double currencyAmount = default(double);
            double currencyCourse = default(double);
            string currencyName = default;

            SetData(ref currencyAmount, ref currencyCourse, ref currencyName);

            Console.WriteLine($"Your want convert to {currencyName} - {currencyAmount}");
            Console.WriteLine($"In {currencyName} it equal {CalculateCurrency(currencyAmount,currencyCourse)}");

            // Delay
            Console.ReadLine();
        }

        static void SetData(ref double currencyAmount, ref double currencyCourse, ref string currencyName) 
        {
            bool isCorrectNumber = false;

            Console.WriteLine("Hello, Please indicate the name of the currency in which you want to change your current... ");
            currencyName = Console.ReadLine();
                
            while (!isCorrectNumber)
            {
                Console.WriteLine($"Please type how much {currencyName} do you want to change?");
                String userInputString = Console.ReadLine();
                bool isConvertCorrect = double.TryParse(userInputString, out currencyAmount);
                if (isConvertCorrect)
                {
                    currencyAmount = double.Parse(userInputString);
                    if (currencyAmount <= 0) { Console.WriteLine("You cant convert less than 0 or 0"); } 
                    isCorrectNumber = true;
                }
                else Console.WriteLine("Input error, please try again ");
            }

            isCorrectNumber = false;

            while (!isCorrectNumber)
            {
                Console.WriteLine($"Hi, Please type the {currencyName} currency rate");
                String userInputString = Console.ReadLine();
                bool isConvertCorrect = double.TryParse(userInputString, out currencyCourse);
                if (isConvertCorrect)
                {
                    currencyCourse = double.Parse(userInputString);
                    if (currencyCourse <= 0) { Console.WriteLine("currency rate cannot be less than or equal to 0"); }
                    isCorrectNumber = true;
                }
                else Console.WriteLine("Input error, please try again ");
            }
        }
        static double CalculateCurrency(double currencyAmount, double currencyCourse)
        {
            return currencyAmount * currencyCourse;
        }
    }
}
