using System;

namespace Task_Extra_001
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstValue = default;
            int secondValue = default;
            int thirdValue  = default;
            
            SetUserValues(ref firstValue, ref secondValue, ref thirdValue);
            Calculate(firstValue, secondValue, thirdValue);

            // Delay
            Console.ReadLine();

        }

        static void SetUserValues(ref int firstValue, ref int secondValue, ref int thirdValue)
        {
            bool isCorrect = false;

            while (!isCorrect)
            {
                Console.WriteLine("Type a first number...");
                string userInput = Console.ReadLine();

                bool isConvertCorrect = int.TryParse(userInput, out firstValue);
                if (isConvertCorrect)
                {
                    firstValue = int.Parse(userInput);
                    isCorrect = true;
                }
                else Console.WriteLine("Input error, please try again ");
            }

             isCorrect = false;

            while (!isCorrect)
            {
                Console.WriteLine("Type a first number...");
                string userInput = Console.ReadLine();

                bool isConvertCorrect = int.TryParse(userInput, out secondValue);
                if (isConvertCorrect)
                {
                    secondValue = int.Parse(userInput);
                    isCorrect = true;
                }
                else Console.WriteLine("Input error, please try again ");
            }

            isCorrect = false;

            while (!isCorrect)
            {
                Console.WriteLine("Type a first number...");
                string userInput = Console.ReadLine();

                bool isConvertCorrect = int.TryParse(userInput, out thirdValue);
                if (isConvertCorrect)
                {
                    thirdValue = int.Parse(userInput);
                    isCorrect = true;
                }
                else Console.WriteLine("Input error, please try again ");
            }

        }
        static void Calculate(int firstValue, int secondValue, int thirdValue) 
        {
            Console.WriteLine($"arithmetical mean of Values {firstValue}, {secondValue}, {thirdValue} is {(firstValue + secondValue + thirdValue) / 3}") ;
        }
    }
}
