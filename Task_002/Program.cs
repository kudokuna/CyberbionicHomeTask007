using System;

namespace Task_002
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstValue = default;
            int secondValue = default;
            string sign = default;
            FindUserInput(ref firstValue, ref secondValue, ref sign);   
            ChooseOperation(ref firstValue, ref secondValue, ref sign);

            // Delay
            Console.ReadKey();


        }

        static void FindUserInput(ref int firstValue, ref int secondValue, ref string sign)
        {
            bool isCorrectNumber = false;

            while (!isCorrectNumber)
            {
                Console.WriteLine("Hi, Please type first Value...");
                String userInputString = Console.ReadLine();
                bool isConvertCorrect = int.TryParse(userInputString, out firstValue);
                if (isConvertCorrect)
                {
                    firstValue = int.Parse(userInputString);
                    isCorrectNumber = true;
                }
                else Console.WriteLine("Input error, please try again ");
            }

            isCorrectNumber = false;

            while (!isCorrectNumber)
            {
                Console.WriteLine("Hi, Please type second Value...");
                String userInputString = Console.ReadLine();
                bool isConvertCorrect = int.TryParse(userInputString, out secondValue);
                if (isConvertCorrect)
                {
                    secondValue = int.Parse(userInputString);
                    isCorrectNumber = true;
                }
                else Console.WriteLine("Input error, please try again ");
            }

            isCorrectNumber = false;

            while (!isCorrectNumber)
            {
                Console.WriteLine("Please type symbol for calculation (+ - * /)...");
                sign = Console.ReadLine();

                switch (sign) 
                {
                    case "+":
                        isCorrectNumber = true;
                        break;
                    case "-":
                        isCorrectNumber = true;
                        break;
                    case "*":
                        isCorrectNumber = true;
                        break;
                    case "/":
                        isCorrectNumber = true;
                        break;
                    default:
                        Console.WriteLine("Wrong input");
                        break;
                }
            }

            
        }
        static void ChooseOperation(ref int firstValue, ref int secondValue, ref string sign) 
        {
            switch (sign) 
            {
                case "+":
                    Add(firstValue,secondValue);
                    break;

                case "-":
                    Sub(firstValue, secondValue);
                    break;

                case "*":
                    Mul(firstValue, secondValue);
                    break;
                    
                case "/":
                    Div(firstValue, secondValue);
                    break;
            }
        }

        static void Add(in int firstValue, in int secondValue) 
        {
            Console.WriteLine($"Result of Addition is {firstValue + secondValue}");
        }

        static void Sub(in int firstValue, in int secondValue)
        {
            Console.WriteLine($"Result of Subtraction is {firstValue - secondValue}");
        }

        static void Mul(in int firstValue, in int secondValue)
        {
            Console.WriteLine($"Result of Multiplication is {firstValue - secondValue}");
        }

        static void Div(in int firstValue, in int secondValue)
        {
            if (secondValue != 0) 
            {
                Console.WriteLine($"Result of Division is {(double)firstValue / secondValue}");
            }
            else Console.WriteLine("You cannot divide by zero");
            
        }

    }
}
